<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioRecorder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAudioRecorder))
        Me.cboChannels = New System.Windows.Forms.ComboBox()
        Me.lblSamplerate = New System.Windows.Forms.Label()
        Me.cboSamplerate = New System.Windows.Forms.ComboBox()
        Me.lblTagComment = New System.Windows.Forms.Label()
        Me.txtTagTitle = New System.Windows.Forms.TextBox()
        Me.lblTagTrackNum = New System.Windows.Forms.Label()
        Me.lblTagTitle = New System.Windows.Forms.Label()
        Me.txtTagTrackNum = New System.Windows.Forms.TextBox()
        Me.txtTagYear = New System.Windows.Forms.TextBox()
        Me.lblTagCopyright = New System.Windows.Forms.Label()
        Me.lblTagYear = New System.Windows.Forms.Label()
        Me.txtTagCopyright = New System.Windows.Forms.TextBox()
        Me.txtTagComment = New System.Windows.Forms.TextBox()
        Me.cboRecorderMode = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblBits = New System.Windows.Forms.Label()
        Me.cboBits = New System.Windows.Forms.ComboBox()
        Me.lblBitrate = New System.Windows.Forms.Label()
        Me.lblAudioSource = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmdID3Tags = New System.Windows.Forms.Button()
        Me.cboBitrate = New System.Windows.Forms.ComboBox()
        Me.cmdUnPause = New System.Windows.Forms.Button()
        Me.lblTimeIn = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblSizeIn = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblStopWhenSilenceVal = New System.Windows.Forms.Label()
        Me.lblStopWhenSilenceSeconds = New System.Windows.Forms.Label()
        Me.lblStartWhenNoiseVal = New System.Windows.Forms.Label()
        Me.cboAudioSource = New System.Windows.Forms.ComboBox()
        Me.lblTagAlbum = New System.Windows.Forms.Label()
        Me.lblMeter = New System.Windows.Forms.Label()
        Me.lblMeterIn = New System.Windows.Forms.Label()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.cmdRecord = New System.Windows.Forms.Button()
        Me.tmrMeterIn = New System.Windows.Forms.Timer(Me.components)
        Me.grpDestinationFile = New System.Windows.Forms.GroupBox()
        Me.cmdPlayWithDefaultPlayer = New System.Windows.Forms.Button()
        Me.cmdOpenFileLocation = New System.Windows.Forms.Button()
        Me.lblDestinationFile = New System.Windows.Forms.Label()
        Me.txtStopWhenSilenceVal = New System.Windows.Forms.TextBox()
        Me.txtStopWhenSilenceSeconds = New System.Windows.Forms.TextBox()
        Me.chkStopWhenSilence = New System.Windows.Forms.CheckBox()
        Me.txtStartWhenNoiseVal = New System.Windows.Forms.TextBox()
        Me.chkStartWhenNoise = New System.Windows.Forms.CheckBox()
        Me.cboDestinationFormat = New System.Windows.Forms.ComboBox()
        Me.pnlACM = New System.Windows.Forms.Panel()
        Me.cboACMFormats = New System.Windows.Forms.ComboBox()
        Me.cboACMTags = New System.Windows.Forms.ComboBox()
        Me.lblACMTag = New System.Windows.Forms.Label()
        Me.lblACMFormats = New System.Windows.Forms.Label()
        Me.cmdCheckLicense = New System.Windows.Forms.Button()
        Me.grpID3Tags = New System.Windows.Forms.GroupBox()
        Me.txtTagAlbum = New System.Windows.Forms.TextBox()
        Me.grpDestination = New System.Windows.Forms.GroupBox()
        Me.lblRecorderMode = New System.Windows.Forms.Label()
        Me.lblDestinationFormat = New System.Windows.Forms.Label()
        Me.AudioRecorder1 = New CSAudioRecorder.AudioRecorder()
        Me.AudioVisualization1 = New CSAudioRecorder.AudioVisualization()
        Me.AudioMeter1 = New CSAudioRecorder.AudioMeter()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDestinationFile.SuspendLayout()
        Me.pnlACM.SuspendLayout()
        Me.grpID3Tags.SuspendLayout()
        Me.grpDestination.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboChannels
        '
        Me.cboChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChannels.FormattingEnabled = True
        Me.cboChannels.Location = New System.Drawing.Point(210, 204)
        Me.cboChannels.Name = "cboChannels"
        Me.cboChannels.Size = New System.Drawing.Size(91, 21)
        Me.cboChannels.TabIndex = 39
        '
        'lblSamplerate
        '
        Me.lblSamplerate.AutoSize = True
        Me.lblSamplerate.Location = New System.Drawing.Point(110, 188)
        Me.lblSamplerate.Name = "lblSamplerate"
        Me.lblSamplerate.Size = New System.Drawing.Size(60, 13)
        Me.lblSamplerate.TabIndex = 35
        Me.lblSamplerate.Text = "Samplerate"
        '
        'cboSamplerate
        '
        Me.cboSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSamplerate.FormattingEnabled = True
        Me.cboSamplerate.Location = New System.Drawing.Point(113, 204)
        Me.cboSamplerate.Name = "cboSamplerate"
        Me.cboSamplerate.Size = New System.Drawing.Size(91, 21)
        Me.cboSamplerate.TabIndex = 34
        '
        'lblTagComment
        '
        Me.lblTagComment.AutoSize = True
        Me.lblTagComment.Location = New System.Drawing.Point(14, 82)
        Me.lblTagComment.Name = "lblTagComment"
        Me.lblTagComment.Size = New System.Drawing.Size(51, 13)
        Me.lblTagComment.TabIndex = 76
        Me.lblTagComment.Text = "Comment"
        '
        'txtTagTitle
        '
        Me.txtTagTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtTagTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTagTitle.Location = New System.Drawing.Point(17, 44)
        Me.txtTagTitle.Name = "txtTagTitle"
        Me.txtTagTitle.Size = New System.Drawing.Size(98, 20)
        Me.txtTagTitle.TabIndex = 14
        Me.txtTagTitle.Text = "CSAudioRecorder"
        '
        'lblTagTrackNum
        '
        Me.lblTagTrackNum.AutoSize = True
        Me.lblTagTrackNum.Location = New System.Drawing.Point(222, 28)
        Me.lblTagTrackNum.Name = "lblTagTrackNum"
        Me.lblTagTrackNum.Size = New System.Drawing.Size(42, 13)
        Me.lblTagTrackNum.TabIndex = 75
        Me.lblTagTrackNum.Text = "Track#"
        '
        'lblTagTitle
        '
        Me.lblTagTitle.AutoSize = True
        Me.lblTagTitle.Location = New System.Drawing.Point(14, 28)
        Me.lblTagTitle.Name = "lblTagTitle"
        Me.lblTagTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTagTitle.TabIndex = 66
        Me.lblTagTitle.Text = "Title"
        '
        'txtTagTrackNum
        '
        Me.txtTagTrackNum.Location = New System.Drawing.Point(225, 44)
        Me.txtTagTrackNum.Name = "txtTagTrackNum"
        Me.txtTagTrackNum.Size = New System.Drawing.Size(98, 20)
        Me.txtTagTrackNum.TabIndex = 16
        Me.txtTagTrackNum.Text = "1"
        '
        'txtTagYear
        '
        Me.txtTagYear.Location = New System.Drawing.Point(121, 98)
        Me.txtTagYear.Name = "txtTagYear"
        Me.txtTagYear.Size = New System.Drawing.Size(98, 20)
        Me.txtTagYear.TabIndex = 18
        '
        'lblTagCopyright
        '
        Me.lblTagCopyright.AutoSize = True
        Me.lblTagCopyright.Location = New System.Drawing.Point(222, 82)
        Me.lblTagCopyright.Name = "lblTagCopyright"
        Me.lblTagCopyright.Size = New System.Drawing.Size(51, 13)
        Me.lblTagCopyright.TabIndex = 73
        Me.lblTagCopyright.Text = "Copyright"
        '
        'lblTagYear
        '
        Me.lblTagYear.AutoSize = True
        Me.lblTagYear.Location = New System.Drawing.Point(118, 82)
        Me.lblTagYear.Name = "lblTagYear"
        Me.lblTagYear.Size = New System.Drawing.Size(29, 13)
        Me.lblTagYear.TabIndex = 68
        Me.lblTagYear.Text = "Year"
        '
        'txtTagCopyright
        '
        Me.txtTagCopyright.Location = New System.Drawing.Point(225, 98)
        Me.txtTagCopyright.Name = "txtTagCopyright"
        Me.txtTagCopyright.Size = New System.Drawing.Size(98, 20)
        Me.txtTagCopyright.TabIndex = 19
        '
        'txtTagComment
        '
        Me.txtTagComment.Location = New System.Drawing.Point(19, 98)
        Me.txtTagComment.Name = "txtTagComment"
        Me.txtTagComment.Size = New System.Drawing.Size(96, 20)
        Me.txtTagComment.TabIndex = 17
        '
        'cboRecorderMode
        '
        Me.cboRecorderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecorderMode.FormattingEnabled = True
        Me.cboRecorderMode.Location = New System.Drawing.Point(16, 44)
        Me.cboRecorderMode.Name = "cboRecorderMode"
        Me.cboRecorderMode.Size = New System.Drawing.Size(286, 21)
        Me.cboRecorderMode.TabIndex = 42
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(207, 188)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 13)
        Me.label1.TabIndex = 38
        Me.label1.Text = "Channels"
        '
        'lblBits
        '
        Me.lblBits.AutoSize = True
        Me.lblBits.Location = New System.Drawing.Point(304, 188)
        Me.lblBits.Name = "lblBits"
        Me.lblBits.Size = New System.Drawing.Size(49, 13)
        Me.lblBits.TabIndex = 37
        Me.lblBits.Text = "Bit depth"
        '
        'cboBits
        '
        Me.cboBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBits.FormattingEnabled = True
        Me.cboBits.Location = New System.Drawing.Point(307, 204)
        Me.cboBits.Name = "cboBits"
        Me.cboBits.Size = New System.Drawing.Size(91, 21)
        Me.cboBits.TabIndex = 36
        '
        'lblBitrate
        '
        Me.lblBitrate.AutoSize = True
        Me.lblBitrate.Location = New System.Drawing.Point(13, 188)
        Me.lblBitrate.Name = "lblBitrate"
        Me.lblBitrate.Size = New System.Drawing.Size(37, 13)
        Me.lblBitrate.TabIndex = 33
        Me.lblBitrate.Text = "Bitrate"
        '
        'lblAudioSource
        '
        Me.lblAudioSource.AutoSize = True
        Me.lblAudioSource.Location = New System.Drawing.Point(13, 81)
        Me.lblAudioSource.Name = "lblAudioSource"
        Me.lblAudioSource.Size = New System.Drawing.Size(71, 13)
        Me.lblAudioSource.TabIndex = 32
        Me.lblAudioSource.Text = "Audio Source"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(625, 720)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(74, 23)
        Me.button1.TabIndex = 317
        Me.button1.Text = "Play"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(218, 16)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(543, 16)
        Me.label3.TabIndex = 313
        Me.label3.Text = ".NET component to record audio from any source to many types of audio files."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(12, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(212, 25)
        Me.label2.TabIndex = 312
        Me.label2.Text = "CSAudioRecorder |"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pictureBox1.Location = New System.Drawing.Point(-36, -1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox1.TabIndex = 314
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pictureBox2.Location = New System.Drawing.Point(-26, 7)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox2.TabIndex = 315
        Me.pictureBox2.TabStop = False
        '
        'cmdID3Tags
        '
        Me.cmdID3Tags.Location = New System.Drawing.Point(474, 897)
        Me.cmdID3Tags.Name = "cmdID3Tags"
        Me.cmdID3Tags.Size = New System.Drawing.Size(145, 23)
        Me.cmdID3Tags.TabIndex = 311
        Me.cmdID3Tags.Text = "ID3 Tags Editor"
        Me.cmdID3Tags.UseVisualStyleBackColor = True
        '
        'cboBitrate
        '
        Me.cboBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBitrate.FormattingEnabled = True
        Me.cboBitrate.Location = New System.Drawing.Point(16, 204)
        Me.cboBitrate.Name = "cboBitrate"
        Me.cboBitrate.Size = New System.Drawing.Size(91, 21)
        Me.cboBitrate.TabIndex = 31
        '
        'cmdUnPause
        '
        Me.cmdUnPause.Location = New System.Drawing.Point(193, 897)
        Me.cmdUnPause.Name = "cmdUnPause"
        Me.cmdUnPause.Size = New System.Drawing.Size(75, 23)
        Me.cmdUnPause.TabIndex = 310
        Me.cmdUnPause.Text = "UnPause"
        Me.cmdUnPause.UseVisualStyleBackColor = True
        '
        'lblTimeIn
        '
        Me.lblTimeIn.AutoSize = True
        Me.lblTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblTimeIn.Location = New System.Drawing.Point(491, 755)
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.Size = New System.Drawing.Size(72, 18)
        Me.lblTimeIn.TabIndex = 309
        Me.lblTimeIn.Text = "00:00:00"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(455, 759)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 308
        Me.lblTime.Text = "Time:"
        '
        'lblSizeIn
        '
        Me.lblSizeIn.AutoSize = True
        Me.lblSizeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblSizeIn.Location = New System.Drawing.Point(491, 719)
        Me.lblSizeIn.Name = "lblSizeIn"
        Me.lblSizeIn.Size = New System.Drawing.Size(17, 18)
        Me.lblSizeIn.TabIndex = 307
        Me.lblSizeIn.Text = "0"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(455, 723)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 306
        Me.lblSize.Text = "Size:"
        '
        'lblStopWhenSilenceVal
        '
        Me.lblStopWhenSilenceVal.AutoSize = True
        Me.lblStopWhenSilenceVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblStopWhenSilenceVal.Location = New System.Drawing.Point(261, 745)
        Me.lblStopWhenSilenceVal.Name = "lblStopWhenSilenceVal"
        Me.lblStopWhenSilenceVal.Size = New System.Drawing.Size(70, 12)
        Me.lblStopWhenSilenceVal.TabIndex = 305
        Me.lblStopWhenSilenceVal.Text = "Max Meter Val:"
        '
        'lblStopWhenSilenceSeconds
        '
        Me.lblStopWhenSilenceSeconds.AutoSize = True
        Me.lblStopWhenSilenceSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblStopWhenSilenceSeconds.Location = New System.Drawing.Point(331, 745)
        Me.lblStopWhenSilenceSeconds.Name = "lblStopWhenSilenceSeconds"
        Me.lblStopWhenSilenceSeconds.Size = New System.Drawing.Size(76, 12)
        Me.lblStopWhenSilenceSeconds.TabIndex = 304
        Me.lblStopWhenSilenceSeconds.Text = "Silence Seconds:"
        '
        'lblStartWhenNoiseVal
        '
        Me.lblStartWhenNoiseVal.AutoSize = True
        Me.lblStartWhenNoiseVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblStartWhenNoiseVal.Location = New System.Drawing.Point(262, 707)
        Me.lblStartWhenNoiseVal.Name = "lblStartWhenNoiseVal"
        Me.lblStartWhenNoiseVal.Size = New System.Drawing.Size(67, 12)
        Me.lblStartWhenNoiseVal.TabIndex = 303
        Me.lblStartWhenNoiseVal.Text = "Min Meter Val:"
        '
        'cboAudioSource
        '
        Me.cboAudioSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudioSource.FormattingEnabled = True
        Me.cboAudioSource.Location = New System.Drawing.Point(16, 97)
        Me.cboAudioSource.Name = "cboAudioSource"
        Me.cboAudioSource.Size = New System.Drawing.Size(286, 21)
        Me.cboAudioSource.TabIndex = 30
        '
        'lblTagAlbum
        '
        Me.lblTagAlbum.AutoSize = True
        Me.lblTagAlbum.Location = New System.Drawing.Point(118, 28)
        Me.lblTagAlbum.Name = "lblTagAlbum"
        Me.lblTagAlbum.Size = New System.Drawing.Size(36, 13)
        Me.lblTagAlbum.TabIndex = 71
        Me.lblTagAlbum.Text = "Album"
        '
        'lblMeter
        '
        Me.lblMeter.AutoSize = True
        Me.lblMeter.Location = New System.Drawing.Point(29, 71)
        Me.lblMeter.Name = "lblMeter"
        Me.lblMeter.Size = New System.Drawing.Size(34, 13)
        Me.lblMeter.TabIndex = 293
        Me.lblMeter.Text = "Meter"
        '
        'lblMeterIn
        '
        Me.lblMeterIn.AutoSize = True
        Me.lblMeterIn.Location = New System.Drawing.Point(766, 71)
        Me.lblMeterIn.Name = "lblMeterIn"
        Me.lblMeterIn.Size = New System.Drawing.Size(28, 13)
        Me.lblMeterIn.TabIndex = 292
        Me.lblMeterIn.Text = "0.00"
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(276, 897)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStop.TabIndex = 291
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(112, 897)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 23)
        Me.cmdPause.TabIndex = 290
        Me.cmdPause.Text = "Pause"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'cmdRecord
        '
        Me.cmdRecord.Location = New System.Drawing.Point(31, 897)
        Me.cmdRecord.Name = "cmdRecord"
        Me.cmdRecord.Size = New System.Drawing.Size(75, 23)
        Me.cmdRecord.TabIndex = 289
        Me.cmdRecord.Text = "Record"
        Me.cmdRecord.UseVisualStyleBackColor = True
        '
        'tmrMeterIn
        '
        '
        'grpDestinationFile
        '
        Me.grpDestinationFile.BackColor = System.Drawing.SystemColors.Control
        Me.grpDestinationFile.Controls.Add(Me.cmdPlayWithDefaultPlayer)
        Me.grpDestinationFile.Controls.Add(Me.cmdOpenFileLocation)
        Me.grpDestinationFile.Controls.Add(Me.lblDestinationFile)
        Me.grpDestinationFile.Location = New System.Drawing.Point(32, 801)
        Me.grpDestinationFile.Name = "grpDestinationFile"
        Me.grpDestinationFile.Size = New System.Drawing.Size(762, 71)
        Me.grpDestinationFile.TabIndex = 299
        Me.grpDestinationFile.TabStop = False
        Me.grpDestinationFile.Text = "Destination File"
        '
        'cmdPlayWithDefaultPlayer
        '
        Me.cmdPlayWithDefaultPlayer.Location = New System.Drawing.Point(548, 24)
        Me.cmdPlayWithDefaultPlayer.Name = "cmdPlayWithDefaultPlayer"
        Me.cmdPlayWithDefaultPlayer.Size = New System.Drawing.Size(74, 23)
        Me.cmdPlayWithDefaultPlayer.TabIndex = 78
        Me.cmdPlayWithDefaultPlayer.Text = "Play"
        Me.cmdPlayWithDefaultPlayer.UseVisualStyleBackColor = True
        '
        'cmdOpenFileLocation
        '
        Me.cmdOpenFileLocation.Location = New System.Drawing.Point(628, 24)
        Me.cmdOpenFileLocation.Name = "cmdOpenFileLocation"
        Me.cmdOpenFileLocation.Size = New System.Drawing.Size(111, 23)
        Me.cmdOpenFileLocation.TabIndex = 21
        Me.cmdOpenFileLocation.Text = "Open file Location"
        Me.cmdOpenFileLocation.UseVisualStyleBackColor = True
        '
        'lblDestinationFile
        '
        Me.lblDestinationFile.Location = New System.Drawing.Point(6, 24)
        Me.lblDestinationFile.Name = "lblDestinationFile"
        Me.lblDestinationFile.Size = New System.Drawing.Size(506, 29)
        Me.lblDestinationFile.TabIndex = 74
        Me.lblDestinationFile.Text = "C:\"
        '
        'txtStopWhenSilenceVal
        '
        Me.txtStopWhenSilenceVal.Location = New System.Drawing.Point(264, 758)
        Me.txtStopWhenSilenceVal.Name = "txtStopWhenSilenceVal"
        Me.txtStopWhenSilenceVal.Size = New System.Drawing.Size(61, 20)
        Me.txtStopWhenSilenceVal.TabIndex = 298
        Me.txtStopWhenSilenceVal.Text = "1"
        '
        'txtStopWhenSilenceSeconds
        '
        Me.txtStopWhenSilenceSeconds.Location = New System.Drawing.Point(331, 758)
        Me.txtStopWhenSilenceSeconds.Name = "txtStopWhenSilenceSeconds"
        Me.txtStopWhenSilenceSeconds.Size = New System.Drawing.Size(76, 20)
        Me.txtStopWhenSilenceSeconds.TabIndex = 297
        Me.txtStopWhenSilenceSeconds.Text = "3"
        '
        'chkStopWhenSilence
        '
        Me.chkStopWhenSilence.AutoSize = True
        Me.chkStopWhenSilence.Location = New System.Drawing.Point(40, 758)
        Me.chkStopWhenSilence.Name = "chkStopWhenSilence"
        Me.chkStopWhenSilence.Size = New System.Drawing.Size(213, 17)
        Me.chkStopWhenSilence.TabIndex = 296
        Me.chkStopWhenSilence.Text = "Stop to record when silence is detected"
        Me.chkStopWhenSilence.UseVisualStyleBackColor = True
        '
        'txtStartWhenNoiseVal
        '
        Me.txtStartWhenNoiseVal.Location = New System.Drawing.Point(264, 720)
        Me.txtStartWhenNoiseVal.Name = "txtStartWhenNoiseVal"
        Me.txtStartWhenNoiseVal.Size = New System.Drawing.Size(61, 20)
        Me.txtStartWhenNoiseVal.TabIndex = 295
        Me.txtStartWhenNoiseVal.Text = "1"
        '
        'chkStartWhenNoise
        '
        Me.chkStartWhenNoise.AutoSize = True
        Me.chkStartWhenNoise.Location = New System.Drawing.Point(40, 722)
        Me.chkStartWhenNoise.Name = "chkStartWhenNoise"
        Me.chkStartWhenNoise.Size = New System.Drawing.Size(205, 17)
        Me.chkStartWhenNoise.TabIndex = 294
        Me.chkStartWhenNoise.Text = "Start to record when noise is detected"
        Me.chkStartWhenNoise.UseVisualStyleBackColor = True
        '
        'cboDestinationFormat
        '
        Me.cboDestinationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestinationFormat.FormattingEnabled = True
        Me.cboDestinationFormat.Location = New System.Drawing.Point(16, 151)
        Me.cboDestinationFormat.Name = "cboDestinationFormat"
        Me.cboDestinationFormat.Size = New System.Drawing.Size(188, 21)
        Me.cboDestinationFormat.TabIndex = 40
        '
        'pnlACM
        '
        Me.pnlACM.Controls.Add(Me.cboACMFormats)
        Me.pnlACM.Controls.Add(Me.cboACMTags)
        Me.pnlACM.Controls.Add(Me.lblACMTag)
        Me.pnlACM.Controls.Add(Me.lblACMFormats)
        Me.pnlACM.Location = New System.Drawing.Point(448, 613)
        Me.pnlACM.Name = "pnlACM"
        Me.pnlACM.Size = New System.Drawing.Size(398, 64)
        Me.pnlACM.TabIndex = 300
        '
        'cboACMFormats
        '
        Me.cboACMFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboACMFormats.FormattingEnabled = True
        Me.cboACMFormats.Location = New System.Drawing.Point(200, 29)
        Me.cboACMFormats.Name = "cboACMFormats"
        Me.cboACMFormats.Size = New System.Drawing.Size(188, 21)
        Me.cboACMFormats.TabIndex = 79
        '
        'cboACMTags
        '
        Me.cboACMTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboACMTags.FormattingEnabled = True
        Me.cboACMTags.Location = New System.Drawing.Point(6, 29)
        Me.cboACMTags.Name = "cboACMTags"
        Me.cboACMTags.Size = New System.Drawing.Size(188, 21)
        Me.cboACMTags.TabIndex = 78
        '
        'lblACMTag
        '
        Me.lblACMTag.AutoSize = True
        Me.lblACMTag.Location = New System.Drawing.Point(3, 13)
        Me.lblACMTag.Name = "lblACMTag"
        Me.lblACMTag.Size = New System.Drawing.Size(60, 13)
        Me.lblACMTag.TabIndex = 69
        Me.lblACMTag.Text = "ACM Tags:"
        '
        'lblACMFormats
        '
        Me.lblACMFormats.AutoSize = True
        Me.lblACMFormats.Location = New System.Drawing.Point(197, 13)
        Me.lblACMFormats.Name = "lblACMFormats"
        Me.lblACMFormats.Size = New System.Drawing.Size(73, 13)
        Me.lblACMFormats.TabIndex = 71
        Me.lblACMFormats.Text = "ACM Formats:"
        '
        'cmdCheckLicense
        '
        Me.cmdCheckLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdCheckLicense.Image = CType(resources.GetObject("cmdCheckLicense.Image"), System.Drawing.Image)
        Me.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCheckLicense.Location = New System.Drawing.Point(625, 897)
        Me.cmdCheckLicense.Name = "cmdCheckLicense"
        Me.cmdCheckLicense.Size = New System.Drawing.Size(168, 23)
        Me.cmdCheckLicense.TabIndex = 316
        Me.cmdCheckLicense.Text = "Order a license online"
        Me.cmdCheckLicense.UseVisualStyleBackColor = True
        '
        'grpID3Tags
        '
        Me.grpID3Tags.BackColor = System.Drawing.SystemColors.Control
        Me.grpID3Tags.Controls.Add(Me.lblTagComment)
        Me.grpID3Tags.Controls.Add(Me.txtTagTitle)
        Me.grpID3Tags.Controls.Add(Me.lblTagTrackNum)
        Me.grpID3Tags.Controls.Add(Me.lblTagTitle)
        Me.grpID3Tags.Controls.Add(Me.txtTagTrackNum)
        Me.grpID3Tags.Controls.Add(Me.txtTagYear)
        Me.grpID3Tags.Controls.Add(Me.lblTagCopyright)
        Me.grpID3Tags.Controls.Add(Me.lblTagYear)
        Me.grpID3Tags.Controls.Add(Me.txtTagCopyright)
        Me.grpID3Tags.Controls.Add(Me.txtTagComment)
        Me.grpID3Tags.Controls.Add(Me.lblTagAlbum)
        Me.grpID3Tags.Controls.Add(Me.txtTagAlbum)
        Me.grpID3Tags.Location = New System.Drawing.Point(448, 442)
        Me.grpID3Tags.Name = "grpID3Tags"
        Me.grpID3Tags.Size = New System.Drawing.Size(346, 140)
        Me.grpID3Tags.TabIndex = 301
        Me.grpID3Tags.TabStop = False
        Me.grpID3Tags.Text = "ID3 Tags"
        '
        'txtTagAlbum
        '
        Me.txtTagAlbum.Location = New System.Drawing.Point(121, 44)
        Me.txtTagAlbum.Name = "txtTagAlbum"
        Me.txtTagAlbum.Size = New System.Drawing.Size(98, 20)
        Me.txtTagAlbum.TabIndex = 15
        '
        'grpDestination
        '
        Me.grpDestination.BackColor = System.Drawing.SystemColors.Control
        Me.grpDestination.Controls.Add(Me.lblRecorderMode)
        Me.grpDestination.Controls.Add(Me.lblDestinationFormat)
        Me.grpDestination.Controls.Add(Me.cboDestinationFormat)
        Me.grpDestination.Controls.Add(Me.cboRecorderMode)
        Me.grpDestination.Controls.Add(Me.cboChannels)
        Me.grpDestination.Controls.Add(Me.label1)
        Me.grpDestination.Controls.Add(Me.lblBits)
        Me.grpDestination.Controls.Add(Me.cboBits)
        Me.grpDestination.Controls.Add(Me.lblSamplerate)
        Me.grpDestination.Controls.Add(Me.cboSamplerate)
        Me.grpDestination.Controls.Add(Me.lblBitrate)
        Me.grpDestination.Controls.Add(Me.lblAudioSource)
        Me.grpDestination.Controls.Add(Me.cboBitrate)
        Me.grpDestination.Controls.Add(Me.cboAudioSource)
        Me.grpDestination.Location = New System.Drawing.Point(32, 442)
        Me.grpDestination.Name = "grpDestination"
        Me.grpDestination.Size = New System.Drawing.Size(410, 251)
        Me.grpDestination.TabIndex = 302
        Me.grpDestination.TabStop = False
        Me.grpDestination.Text = "Destination"
        '
        'lblRecorderMode
        '
        Me.lblRecorderMode.AutoSize = True
        Me.lblRecorderMode.Location = New System.Drawing.Point(13, 28)
        Me.lblRecorderMode.Name = "lblRecorderMode"
        Me.lblRecorderMode.Size = New System.Drawing.Size(81, 13)
        Me.lblRecorderMode.TabIndex = 43
        Me.lblRecorderMode.Text = "Recorder Mode"
        '
        'lblDestinationFormat
        '
        Me.lblDestinationFormat.AutoSize = True
        Me.lblDestinationFormat.Location = New System.Drawing.Point(12, 135)
        Me.lblDestinationFormat.Name = "lblDestinationFormat"
        Me.lblDestinationFormat.Size = New System.Drawing.Size(95, 13)
        Me.lblDestinationFormat.TabIndex = 41
        Me.lblDestinationFormat.Text = "Destination Format"
        '
        'AudioRecorder1
        '
        Me.AudioRecorder1.AudioSource = Nothing
        Me.AudioRecorder1.BitrateVal = 0
        Me.AudioRecorder1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AudioRecorder1.DeleteEmptyRecordedFile = True
        Me.AudioRecorder1.DeviceIndex = 0
        Me.AudioRecorder1.FileName = Nothing
        Me.AudioRecorder1.IsRecording = False
        Me.AudioRecorder1.Latency = 100
        Me.AudioRecorder1.Location = New System.Drawing.Point(741, 9)
        Me.AudioRecorder1.MessageArgs = Nothing
        Me.AudioRecorder1.Name = "AudioRecorder1"
        Me.AudioRecorder1.ProgressArgs = Nothing
        Me.AudioRecorder1.RatingStars = 0!
        Me.AudioRecorder1.RatingUser = "Windows Media Player 9 Series"
        Me.AudioRecorder1.SamplerateVal = 0
        Me.AudioRecorder1.Size = New System.Drawing.Size(52, 52)
        Me.AudioRecorder1.StartOnNoise = False
        Me.AudioRecorder1.StartOnNoiseVal = 1.0!
        Me.AudioRecorder1.StopOnSilence = False
        Me.AudioRecorder1.StopOnSilenceSeconds = 1
        Me.AudioRecorder1.StopOnSilenceVal = 1.0!
        Me.AudioRecorder1.TabIndex = 318
        Me.AudioRecorder1.TagAlbum = Nothing
        Me.AudioRecorder1.TagArtists = CType(resources.GetObject("AudioRecorder1.TagArtists"), System.Collections.Generic.List(Of String))
        Me.AudioRecorder1.TagComment = Nothing
        Me.AudioRecorder1.TagComposers = CType(resources.GetObject("AudioRecorder1.TagComposers"), System.Collections.Generic.List(Of String))
        Me.AudioRecorder1.TagCopyright = Nothing
        Me.AudioRecorder1.TagGenres = CType(resources.GetObject("AudioRecorder1.TagGenres"), System.Collections.Generic.List(Of String))
        Me.AudioRecorder1.TagLyrics = Nothing
        Me.AudioRecorder1.TagPerformers = CType(resources.GetObject("AudioRecorder1.TagPerformers"), System.Collections.Generic.List(Of String))
        Me.AudioRecorder1.TagRating = CType(0, Short)
        Me.AudioRecorder1.TagTitle = Nothing
        Me.AudioRecorder1.TagTrack = CType(0UI, UInteger)
        Me.AudioRecorder1.TagYear = Nothing
        Me.AudioRecorder1.UserKey = "Your registration key"
        Me.AudioRecorder1.UserName = "Your email"
        '
        'AudioVisualization1
        '
        Me.AudioVisualization1.BackColor = System.Drawing.Color.Black
        Me.AudioVisualization1.BarCount = 50
        Me.AudioVisualization1.BarSpacing = 2
        Me.AudioVisualization1.ColorBase = System.Drawing.Color.DarkRed
        Me.AudioVisualization1.ColorMax = System.Drawing.Color.Snow
        Me.AudioVisualization1.HighQuality = True
        Me.AudioVisualization1.Interval = 40
        Me.AudioVisualization1.IsXLogScale = True
        Me.AudioVisualization1.Location = New System.Drawing.Point(31, 116)
        Me.AudioVisualization1.MaximumFrequency = 10000
        Me.AudioVisualization1.Name = "AudioVisualization1"
        Me.AudioVisualization1.Size = New System.Drawing.Size(762, 309)
        Me.AudioVisualization1.TabIndex = 319
        Me.AudioVisualization1.UseAverage = True
        '
        'AudioMeter1
        '
        Me.AudioMeter1.Location = New System.Drawing.Point(31, 87)
        Me.AudioMeter1.Name = "AudioMeter1"
        Me.AudioMeter1.Size = New System.Drawing.Size(762, 23)
        Me.AudioMeter1.TabIndex = 320
        '
        'frmAudioRecorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 957)
        Me.Controls.Add(Me.pnlACM)
        Me.Controls.Add(Me.AudioMeter1)
        Me.Controls.Add(Me.AudioVisualization1)
        Me.Controls.Add(Me.AudioRecorder1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.cmdID3Tags)
        Me.Controls.Add(Me.cmdUnPause)
        Me.Controls.Add(Me.lblTimeIn)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblSizeIn)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblStopWhenSilenceVal)
        Me.Controls.Add(Me.lblStopWhenSilenceSeconds)
        Me.Controls.Add(Me.lblStartWhenNoiseVal)
        Me.Controls.Add(Me.lblMeter)
        Me.Controls.Add(Me.lblMeterIn)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdRecord)
        Me.Controls.Add(Me.grpDestinationFile)
        Me.Controls.Add(Me.txtStopWhenSilenceVal)
        Me.Controls.Add(Me.txtStopWhenSilenceSeconds)
        Me.Controls.Add(Me.chkStopWhenSilence)
        Me.Controls.Add(Me.txtStartWhenNoiseVal)
        Me.Controls.Add(Me.chkStartWhenNoise)
        Me.Controls.Add(Me.cmdCheckLicense)
        Me.Controls.Add(Me.grpID3Tags)
        Me.Controls.Add(Me.grpDestination)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAudioRecorder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSAudioRecorder - VB Full Example"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDestinationFile.ResumeLayout(False)
        Me.pnlACM.ResumeLayout(False)
        Me.pnlACM.PerformLayout()
        Me.grpID3Tags.ResumeLayout(False)
        Me.grpID3Tags.PerformLayout()
        Me.grpDestination.ResumeLayout(False)
        Me.grpDestination.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboChannels As ComboBox
    Private WithEvents lblSamplerate As Label
    Private WithEvents cboSamplerate As ComboBox
    Private WithEvents lblTagComment As Label
    Private WithEvents txtTagTitle As TextBox
    Private WithEvents lblTagTrackNum As Label
    Private WithEvents lblTagTitle As Label
    Private WithEvents txtTagTrackNum As TextBox
    Private WithEvents txtTagYear As TextBox
    Private WithEvents lblTagCopyright As Label
    Private WithEvents lblTagYear As Label
    Private WithEvents txtTagCopyright As TextBox
    Private WithEvents txtTagComment As TextBox
    Private WithEvents cboRecorderMode As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents lblBits As Label
    Private WithEvents cboBits As ComboBox
    Private WithEvents lblBitrate As Label
    Private WithEvents lblAudioSource As Label
    Private WithEvents button1 As Button
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents cmdID3Tags As Button
    Private WithEvents cboBitrate As ComboBox
    Private WithEvents cmdUnPause As Button
    Private WithEvents lblTimeIn As Label
    Private WithEvents lblTime As Label
    Private WithEvents lblSizeIn As Label
    Private WithEvents lblSize As Label
    Private WithEvents lblStopWhenSilenceVal As Label
    Private WithEvents lblStopWhenSilenceSeconds As Label
    Private WithEvents lblStartWhenNoiseVal As Label
    Private WithEvents cboAudioSource As ComboBox
    Private WithEvents lblTagAlbum As Label
    Private WithEvents lblMeter As Label
    Private WithEvents lblMeterIn As Label
    Private WithEvents cmdStop As Button
    Private WithEvents cmdPause As Button
    Private WithEvents cmdRecord As Button
    Private WithEvents tmrMeterIn As Timer
    Private WithEvents grpDestinationFile As GroupBox
    Private WithEvents cmdPlayWithDefaultPlayer As Button
    Private WithEvents cmdOpenFileLocation As Button
    Private WithEvents lblDestinationFile As Label
    Private WithEvents txtStopWhenSilenceVal As TextBox
    Private WithEvents txtStopWhenSilenceSeconds As TextBox
    Private WithEvents chkStopWhenSilence As CheckBox
    Private WithEvents txtStartWhenNoiseVal As TextBox
    Private WithEvents chkStartWhenNoise As CheckBox
    Private WithEvents cboDestinationFormat As ComboBox
    Private WithEvents pnlACM As Panel
    Private WithEvents cboACMFormats As ComboBox
    Private WithEvents cboACMTags As ComboBox
    Friend WithEvents lblACMTag As Label
    Friend WithEvents lblACMFormats As Label
    Private WithEvents cmdCheckLicense As Button
    Private WithEvents grpID3Tags As GroupBox
    Private WithEvents txtTagAlbum As TextBox
    Private WithEvents grpDestination As GroupBox
    Private WithEvents lblRecorderMode As Label
    Private WithEvents lblDestinationFormat As Label
    Friend WithEvents AudioRecorder1 As CSAudioRecorder.AudioRecorder
    Friend WithEvents AudioVisualization1 As CSAudioRecorder.AudioVisualization
    Friend WithEvents AudioMeter1 As CSAudioRecorder.AudioMeter
End Class
