#Region "LICENSE"
'
' Copyright (c) Microncode.com
' 
' This source is subject to the Microsoft Public License. 
' See https://opensource.org/licenses/ms-pl.html.
' All other rights reserved. 
' 
' THIS CODE And INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE. 
'
#End Region

Imports System.IO
Imports System.Threading

Public Class frmAudioRecorder

    ''' <summary>
    ''' Form Load.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioRecorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AudioRecorder1.UserName = "Your email"
        AudioRecorder1.UserKey = "Your registration key"

#Region "LoadAudioProperties"

        'Formats
        cboDestinationFormat.DataSource = AudioRecorder1.GetFormats()
        cboDestinationFormat.Text = "MP3"

        'Bitrate
        cboBitrate.DataSource = AudioRecorder1.GetBitrates()
        cboBitrate.Text = "192"

        'Samplerate
        cboSamplerate.DataSource = AudioRecorder1.GetSamplerates()
        cboSamplerate.Text = "44100"

        'Bit depth
        cboBits.DataSource = AudioRecorder1.GetBits()
        cboBits.Text = "16"

        'Channels
        cboChannels.DataSource = AudioRecorder1.GetChannels()
        cboChannels.Text = "2"

        'Recorder mode
        cboRecorderMode.DataSource = AudioRecorder1.GetModes()
        cboRecorderMode.SelectedItem = AudioRecorder1.GetEnumValue(AudioRecorder1.Mode)

        'Get all the ACM Tags that installed in the system (for ACM WAV) according to the sample-rate, bits-depth And channels
        cboACMTags.DataSource = AudioRecorder1.GetACMTags(CSAudioRecorder.ACM_FORMAT.ACM_FORMATENUMF_CONVERT, 1, 44100, 2, 16)
        cboACMTags.Text = "PCM"

#End Region

        'Set the current year of the ID3 tag
        txtTagYear.Text = DateTime.Now.Year.ToString()

    End Sub

    ''' <summary>
    ''' Get and set the audio devices according to the capture mode.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboRecorderMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRecorderMode.SelectedIndexChanged

        'Get the selected capture mode:
        Dim mode As CSAudioRecorder.Mode = CType([Enum].Parse(GetType(CSAudioRecorder.Mode), cboRecorderMode.Text), CSAudioRecorder.Mode)

        'Get the audio devices:
        cboAudioSource.DataSource = AudioRecorder1.GetDevices(mode)

        'Try to set the default device:
        Dim default_device_index As Integer = AudioRecorder1.GetDeviceDefaultIndex(mode)

        If default_device_index <> -1 Then
            'Set the default device index:
            cboAudioSource.SelectedIndex = default_device_index
        Else
            'LineIn will always return -1:
            cboAudioSource.SelectedIndex = 0
        End If

    End Sub

    ''' <summary>
    ''' Enable or disable the recording buttons.
    ''' </summary>
    ''' <param name="state"></param>
    Private Sub EnableDisableControls(ByVal state As Boolean)
        cmdRecord.Enabled = state
        cmdPause.Enabled = state
        cmdUnPause.Enabled = state
    End Sub

    ''' <summary>
    ''' When done event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioRecorder1_RecordDone(sender As Object, e As EventArgs) Handles AudioRecorder1.RecordDone

        'Set the ID3 tags:
        If (cboDestinationFormat.Text IsNot "WAV") AndAlso (cboDestinationFormat.Text IsNot "ACM") Then

            If File.Exists(lblDestinationFile.Text) Then

                'Set the ID3 tags of the destination file:
                AudioRecorder1.TagTitle = txtTagTitle.Text
                AudioRecorder1.TagAlbum = txtTagAlbum.Text
                AudioRecorder1.TagTrack = UInteger.Parse(txtTagTrackNum.Text)
                AudioRecorder1.TagComment = txtTagComment.Text
                AudioRecorder1.TagYear = txtTagYear.Text
                AudioRecorder1.TagCopyright = txtTagCopyright.Text
                AudioRecorder1.SetID3Tags(lblDestinationFile.Text)

            End If
        End If

        EnableDisableControls(True)

        Console.WriteLine("Done.")

    End Sub

    ''' <summary>
    ''' On error event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioRecorder1_RecordError(sender As Object, e As CSAudioRecorder.MessageArgs) Handles AudioRecorder1.RecordError

        Console.WriteLine(e.Number)
        Console.WriteLine(e.String)

    End Sub

    Private Sub AudioRecorder1_RecordPaused(sender As Object, e As EventArgs) Handles AudioRecorder1.RecordPaused

    End Sub

    ''' <summary>
    ''' On progress event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioRecorder1_RecordProgress(sender As Object, e As CSAudioRecorder.ProgressArgs) Handles AudioRecorder1.RecordProgress

        lblSizeIn.Text = AudioRecorder1.TotalSizeIn ' Or AudioRecorder1.SizeSuffix(e.Bytes)
        lblTimeIn.Text = AudioRecorder1.TotalTimeIn ' Or TimeSpan.FromSeconds(e.Seconds).ToString()

    End Sub

    ''' <summary>
    ''' On start event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioRecorder1_RecordStart(sender As Object, e As EventArgs) Handles AudioRecorder1.RecordStart

        Console.WriteLine("Start recording...")

    End Sub

    ''' <summary>
    ''' Set the destination file. This example use the default music folder of Windows.
    ''' </summary>
    Private Sub SetDestinationFileName()

        'Get the default music directory of Windows:
        Dim sDestinationFile As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) & "\out." & cboDestinationFormat.Text.ToLower()

        'If the destination is ACM add the .WAV ext:
        If cboDestinationFormat.Text = "ACM" Then sDestinationFile = sDestinationFile & ".wav"

        'Set the lblDestinationFile:
        lblDestinationFile.Text = sDestinationFile

        'Set the destination file of the control:
        lblDestinationFile.Text = sDestinationFile

    End Sub

    ''' <summary>
    ''' Start to record.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdRecord_Click(sender As Object, e As EventArgs) Handles cmdRecord.Click

        'Check if the control is already recording, if so, stop the recording operation before starting.
        If AudioRecorder1.RecordingState = CSAudioRecorder.RecordingState.Recording Then

            AudioRecorder1.[Stop]()

            While AudioRecorder1.RecordingState <> CSAudioRecorder.RecordingState.Ready
                Application.DoEvents()
                Thread.Sleep(100)
            End While

        End If

        'Set the destination file name and path:
        SetDestinationFileName()

        'Set the destination file:
        AudioRecorder1.FileName = lblDestinationFile.Text

        'Set the audio device to record from:
        AudioRecorder1.AudioSource = cboAudioSource.Text

        'Set the audio device index to record from:
        AudioRecorder1.DeviceIndex = cboAudioSource.SelectedIndex

        '[Optional Default is MP3]
        'The format of the destination file, this can be AAC, ACM(WAV), APE, MP2, MP3, OGG, WAV(PCM), And WMA.
        AudioRecorder1.Format = CType([Enum].Parse(GetType(CSAudioRecorder.Format), cboDestinationFormat.Text), CSAudioRecorder.Format)

#Region "MoreOptionalProperties"

        'If the destination format is ACM (WAV) set the ACM tag and format.
        If cboDestinationFormat.Text = "ACM" Then

            'Set the ACM tag and format:

            '[Optional: Default is WAV]
            AudioRecorder1.ACMTag = cboACMTags.Text

            '[Optional: Default is 44100, 16, Stereo]
            AudioRecorder1.ACMFormat = cboACMFormats.Text

        End If

        '[Optional: Default is 192]
        'Set the bitrate of the destination
        AudioRecorder1.Bitrate = CType([Enum].Parse(GetType(CSAudioRecorder.Bitrate), cboBitrate.Text), CSAudioRecorder.Bitrate)
        'Or set by value
        'audioRecorder1.BitrateVal = 192

        '[Optional: Default is 44100]
        'Set the sample rate to record from the device And the destination audio file
        AudioRecorder1.Samplerate = CType([Enum].Parse(GetType(CSAudioRecorder.Samplerate), cboSamplerate.Text), CSAudioRecorder.Samplerate)
        'Or set by value
        'audioRecorder1.SamplerateVal = 48000

        '[Optional: Default is 16]
        'Set the bit-depth to record from the device And the destination audio file
        AudioRecorder1.Bits = CType([Enum].Parse(GetType(CSAudioRecorder.Bits), cboBits.Text), CSAudioRecorder.Bits)

        '[Optional: Default is 2]
        'Set the number of the channels to record from the device And the destination audio file
        AudioRecorder1.Channels = CType([Enum].Parse(GetType(CSAudioRecorder.Channels), cboChannels.Text), CSAudioRecorder.Channels)

        '[Optional Default is WasapiLoopbackCapture]
        'The mode of the recording process. This can be WasapiLoopbackCapture(default), WasapiCapture Or LineIn
        AudioRecorder1.Mode = CType([Enum].Parse(GetType(CSAudioRecorder.Mode), cboRecorderMode.Text), CSAudioRecorder.Mode)

        '[Optional Default is 100]
        'The latency of the capture in milliseconds. The default value is 100, some sound card devices need an high value in order to avoid glitches
        AudioRecorder1.Latency = 100


        '[Optional Default is Nothing]
        'Set the audioVisualization control to display the audio graph
        AudioRecorder1.AudioVisualization = AudioVisualization1

        '[Optional Default is Nothing]
        AudioRecorder1.AudioMeter = AudioMeter1

        '****************************************
        'Start to record when noise is detected:
        '****************************************

        '[Optional Default is False]
        'Start to record only if a noise is detect
        AudioRecorder1.StartOnNoise = chkStartWhenNoise.Checked

        '[Optional Default is False]
        'Set the noise value (of the meter) to start the record 
        AudioRecorder1.StartOnNoiseVal = Single.Parse(txtStartWhenNoiseVal.Text)

        '****************************************
        'Stop To record When silence is detected:
        '****************************************

        '[Optional Default is False]
        'Stop the recording operation when silence is detected
        AudioRecorder1.StopOnSilence = chkStopWhenSilence.Checked

        '[Optional Default is 0]
        'Set the minimum meter value of the silence, this can be a value between 1 to 100
        AudioRecorder1.StopOnSilenceVal = Single.Parse(txtStopWhenSilenceVal.Text)

        '[Optional Default is 3]
        'Set the number of seconds to detect the silence
        AudioRecorder1.StopOnSilenceSeconds = Integer.Parse(txtStopWhenSilenceSeconds.Text)

#End Region

        'Start to record:
        AudioRecorder1.Start()

        'Start the timer:
        tmrMeterIn.Interval = 40
        tmrMeterIn.Enabled = True

    End Sub

    ''' <summary>
    ''' Stop the recording operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click

        'Check if the control is recording, if not do nothing:
        If AudioRecorder1.RecordingState = CSAudioRecorder.RecordingState.Ready Then Return

        'Disable the recording buttons:
        EnableDisableControls(False)

        'Stop the meter timer:
        tmrMeterIn.Enabled = False

        'Stop to record:
        AudioRecorder1.Stop()

    End Sub

    ''' <summary>
    ''' Pause the recording operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click

        AudioRecorder1.Pause()

    End Sub

    ''' <summary>
    ''' UnPause the recording operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdUnPause_Click(sender As Object, e As EventArgs) Handles cmdUnPause.Click

        AudioRecorder1.UnPause()

    End Sub

    ''' <summary>
    ''' Timer tick to get the meter. You can also get the meter value in RecordProgress event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrMeterIn_Tick(sender As Object, e As EventArgs) Handles tmrMeterIn.Tick

        'Get the meter
        lblMeterIn.Text = AudioMeter1.Meter.ToString("0.00")

    End Sub

    ''' <summary>
    ''' When selecting the ACM WAV format, display the ACM Tags and Formats.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboDestinationFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDestinationFormat.SelectedIndexChanged

        'Set the destination:
        SetDestinationFileName()

        lblBits.Visible = False
        cboBits.Visible = False
        pnlACM.Visible = False

        If cboDestinationFormat.Text = "ACM" Then
            'Display the ACM settings
            pnlACM.Visible = True
            pnlACM.Left = 44
        End If

        If cboDestinationFormat.Text = "WAV" Then
            'Display the bit-depth combo box
            lblBits.Visible = True
            cboBits.Visible = True
        End If

    End Sub

    ''' <summary>
    ''' Open the windows explorer of the file location.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdOpenFileLocation_Click(sender As Object, e As EventArgs) Handles cmdOpenFileLocation.Click

        Dim argument As String = "/select, """ & lblDestinationFile.Text & """"
        Process.Start("explorer.exe", argument)

    End Sub

    ''' <summary>
    ''' Get ACM formats according to the selected tag.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboACMTags_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboACMTags.SelectedIndexChanged

        cboACMFormats.DataSource = AudioRecorder1.GetACMFormats(cboACMTags.Text)

        cboACMFormats.SelectedIndex = 0

    End Sub

    ''' <summary>
    ''' Open the destination multimedia file with the default multimedia player of the system:
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPlayWithDefaultPlayer_Click(sender As Object, e As EventArgs) Handles cmdPlayWithDefaultPlayer.Click

        If lblDestinationFile.Text = "" Then Return

        Process.Start(lblDestinationFile.Text)

    End Sub

    ''' <summary>
    ''' On closing, check if the control is recording, if so, stop the recording operation before exit the program.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioRecorder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

#Region "SafeExit"

        'Safe exit
        If AudioRecorder1.RecordingState = CSAudioRecorder.RecordingState.Recording Then
            AudioRecorder1.[Stop]()

            While AudioRecorder1.RecordingState <> CSAudioRecorder.RecordingState.Ready
                Application.DoEvents()
                Thread.Sleep(100)
            End While
        End If

#End Region

    End Sub

    ''' <summary>
    ''' Show the frmID3TagsEditor.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdID3Tags_Click(sender As Object, e As EventArgs) Handles cmdID3Tags.Click

        'If lblDestinationFile.Text = "" Then Return
        'Dim frmAllID3Tags As frmID3TagsEditor = New frmID3TagsEditor()
        'frmAllID3Tags.ShowDialog(Me)

    End Sub

    ''' <summary>
    ''' Check the license.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCheckLicense_Click(sender As Object, e As EventArgs) Handles cmdCheckLicense.Click

        If AudioRecorder1.CheckLicense() Then MessageBox.Show("Registration is OK")

    End Sub
End Class
