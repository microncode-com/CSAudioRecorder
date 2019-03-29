#region LICENSE
//
// Copyright (c) Microncode.com
// 
// This source is subject to the Microsoft Public License. 
// See https://opensource.org/licenses/ms-pl.html.
// All other rights reserved. 
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CSAudioRecorderExample
{
    public partial class frmAudioRecorder : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public frmAudioRecorder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioRecorder_Load(object sender, EventArgs e)
        {
            audioRecorder1.UserName = "Your email";
            audioRecorder1.UserKey = "Your registration key";

            #region LoadAudioProperties

            //Formats:
            cboDestinationFormat.DataSource = audioRecorder1.GetFormats();
            cboDestinationFormat.Text = "MP3";

            //Bitrate
            cboBitrate.DataSource = audioRecorder1.GetBitrates();
            cboBitrate.Text = "192";

            //Samplerate
            cboSamplerate.DataSource = audioRecorder1.GetSamplerates();
            cboSamplerate.Text = "44100";

            //Bit depth
            cboBits.DataSource = audioRecorder1.GetBits();
            cboBits.Text = "16";

            //Channels
            cboChannels.DataSource  = audioRecorder1.GetChannels();
            cboChannels.Text = "2";

            //Recorder mode
            cboRecorderMode.DataSource = audioRecorder1.GetModes();
            cboRecorderMode.SelectedItem = audioRecorder1.GetEnumValue(audioRecorder1.Mode);

            //Get all the ACM Tags that installed in the system (for ACM WAV) according to the sample-rate, bits-depth and channels:
            cboACMTags.DataSource = audioRecorder1.GetACMTags(CSAudioRecorder.ACM_FORMAT.ACM_FORMATENUMF_CONVERT, 1, 44100, 2, 16);
            cboACMTags.Text = "PCM";

            #endregion

            //Set the current year of the ID3 tag:
            txtTagYear.Text = DateTime.Now.Year.ToString();

        }

        /// <summary>
        /// Get and set the audio devices according to the capture mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboRecorderMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected capture mode:
            CSAudioRecorder.Mode mode = (CSAudioRecorder.Mode)Enum.Parse(typeof(CSAudioRecorder.Mode), cboRecorderMode.Text);

            //Get the audio devices:
            cboAudioSource.DataSource = audioRecorder1.GetDevices(mode);

            //Try to set the default device:
            int default_device_index = audioRecorder1.GetDeviceDefaultIndex(mode);

            if (default_device_index != -1)
                //Set the default device index:
                cboAudioSource.SelectedIndex = default_device_index;
            else
                //LineIn will always return -1:
                cboAudioSource.SelectedIndex = 0;

        }

        /// <summary>
        /// When done event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void audioRecorder1_RecordDone(object sender, EventArgs e)
        {
            //Set the ID3 tags:
            if ((cboDestinationFormat.Text != "WAV") && (cboDestinationFormat.Text != "ACM"))
            {
                if (File.Exists(lblDestinationFile.Text))
                {
                    //Set the ID3 tags of the destination file:
                    audioRecorder1.TagTitle = txtTagTitle.Text;
                    audioRecorder1.TagAlbum = txtTagAlbum.Text;
                    audioRecorder1.TagTrack = uint.Parse(txtTagTrackNum.Text);
                    audioRecorder1.TagComment = txtTagComment.Text;
                    audioRecorder1.TagYear = txtTagYear.Text;
                    audioRecorder1.TagCopyright = txtTagCopyright.Text;

                    //Save the ID3 tags to the file:
                    audioRecorder1.SetID3Tags(lblDestinationFile.Text);
                }
            }

            EnableDisableControls(true);

            Console.WriteLine("Done.");
        }

        /// <summary>
        /// On error event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void audioRecorder1_RecordError(object sender, CSAudioRecorder.MessageArgs e)
        {
            //MessageBox.Show(e.seconds.ToString());
            Console.WriteLine(e.Number);
            Console.WriteLine(e.String);
        }

        /// <summary>
        /// On start event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void audioRecorder1_RecordStart(object sender, EventArgs e)
        {
            Console.WriteLine("Start recording...");
        }

        /// <summary>
        /// On progress event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void audioRecorder1_RecordProgress(object sender, CSAudioRecorder.ProgressArgs e)
        {
            lblSizeIn.Text = audioRecorder1.TotalSizeIn; // Or audioRecorder1.SizeSuffix(e.Bytes);
            lblTimeIn.Text = audioRecorder1.TotalTimeIn; // Or TimeSpan.FromSeconds(e.Seconds).ToString();
        }

        /// <summary>
        /// Set the destination file. This example use the default music folder of Windows.
        /// </summary>
        private void SetDestinationFileName()
        {
            //Get the default music directory of Windows:
            string sDestinationFile = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\out." + cboDestinationFormat.Text.ToLower();

            //If the destination is ACM add the .WAV ext:
            if (cboDestinationFormat.Text == "ACM")
                sDestinationFile = sDestinationFile + ".wav";

            //Set the lblDestinationFile:
            lblDestinationFile.Text = sDestinationFile;

            //Set the destination file of the control:
            lblDestinationFile.Text = sDestinationFile;
        }

        /// <summary>
        /// Start to record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRecord_Click(object sender, EventArgs e)
        {
            //Check if the control is already recording, if so, stop the recording operation before starting.
            if(audioRecorder1.RecordingState == CSAudioRecorder.RecordingState.Recording)
            {
                audioRecorder1.Stop();

                while (audioRecorder1.RecordingState != CSAudioRecorder.RecordingState.Ready)
                {
                    Application.DoEvents();

                    Thread.Sleep(100);
                }
            }
            
            //Set the destination file name and path:
            SetDestinationFileName();

            //Set the destination file:
            audioRecorder1.FileName = lblDestinationFile.Text;

            //Set the audio device to record from:
            audioRecorder1.AudioSource = cboAudioSource.Text;

            //Set the audio device index to record from:
            audioRecorder1.DeviceIndex = cboAudioSource.SelectedIndex;

            //[Optional: Default is MP3]
            //The format of the destination file, this can be AAC, ACM(WAV), APE, MP2, MP3, OGG, WAV(PCM), and WMA.
            audioRecorder1.Format = (CSAudioRecorder.Format)Enum.Parse(typeof(CSAudioRecorder.Format), cboDestinationFormat.Text);

            #region MoreOptionalProperties

            //If the destination format is ACM (WAV) set the ACM tag and format.
            if (cboDestinationFormat.Text == "ACM")
            {
                //Set the ACM tag and format:

                //[Optional: Default is WAV]
                audioRecorder1.ACMTag = cboACMTags.Text;

                //[Optional: Default is 44100, 16, Stereo]
                audioRecorder1.ACMFormat = cboACMFormats.Text;
            }

            //[Optional: Default is 192]
            //Set the bitrate of the destination:
            audioRecorder1.Bitrate = (CSAudioRecorder.Bitrate)Enum.Parse(typeof(CSAudioRecorder.Bitrate), cboBitrate.Text);
            //Or set by value
            //audioRecorder1.BitrateVal = 192;

            //[Optional: Default is 44100]
            //Set the sample rate to record from the device and the destination audio file:
            audioRecorder1.Samplerate = (CSAudioRecorder.Samplerate)Enum.Parse(typeof(CSAudioRecorder.Samplerate), cboSamplerate.Text);
            //Or set by value
            //audioRecorder1.SamplerateVal = 48000;

            //[Optional: Default is 16]
            //Set the bit-depth to record from the device and the destination audio file:
            audioRecorder1.Bits = (CSAudioRecorder.Bits)Enum.Parse(typeof(CSAudioRecorder.Bits), cboBits.Text);

            //[Optional: Default is 2]
            //Set the number of the channels to record from the device and the destination audio file:
            audioRecorder1.Channels = (CSAudioRecorder.Channels)Enum.Parse(typeof(CSAudioRecorder.Channels), cboChannels.Text);

            //[Optional: Default is WasapiLoopbackCapture]
            //The mode of the recording process. This can be WasapiLoopbackCapture(default), WasapiCapture or LineIn:
            audioRecorder1.Mode = (CSAudioRecorder.Mode)Enum.Parse(typeof(CSAudioRecorder.Mode), cboRecorderMode.Text);

            //[Optional: Default is 100]
            //The latency of the capture in milliseconds. The default value is 100, some sound card devices need an high value in order to avoid glitches:
            audioRecorder1.Latency = 100;

            //[Optional: Default is nothing]
            //Set the audioVisualization control to display the audio graph:
            audioRecorder1.AudioVisualization = audioVisualization1;

            //[Optional: Default is nothing]
            audioRecorder1.AudioMeter = audioMeter1;

            /****************************************
                Start to record when noise is detected:
            ****************************************/

            //[Optional: Default is false]
            //Start to record only if a noise is detect:
            audioRecorder1.StartOnNoise = chkStartWhenNoise.Checked;

            //[Optional: Default is false]
            //Set the noise value (of the meter) to start the record 
            audioRecorder1.StartOnNoiseVal = float.Parse(txtStartWhenNoiseVal.Text);

            /****************************************
                Stop to record when silence is detected:
            ****************************************/

            //[Optional: Default is false]
            //Stop the recording operation when silence is detected:
            audioRecorder1.StopOnSilence = chkStopWhenSilence.Checked;

            //[Optional: Default is 0]
            //Set the minimum meter value of the silence, this can be a value between 1 to 100:
            audioRecorder1.StopOnSilenceVal = float.Parse(txtStopWhenSilenceVal.Text);

            //[Optional: Default is 3]
            //Set the number of seconds to detect the silence:
            audioRecorder1.StopOnSilenceSeconds = int.Parse(txtStopWhenSilenceSeconds.Text);

            #endregion

            //Start to record:
            audioRecorder1.Start();

            //Start the timer:
            tmrMeterIn.Interval = 40;
            tmrMeterIn.Enabled = true;

        }

        /// <summary>
        /// Stop the recording operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStop_Click(object sender, EventArgs e)
        {
            //Check if the control is recording, if not do nothing:
            if (audioRecorder1.RecordingState == CSAudioRecorder.RecordingState.Ready)
                return;

            //Disable the recording buttons:
            EnableDisableControls(false);

            //Stop the meter timer:
            tmrMeterIn.Enabled = false;

            //Stop to record:
            audioRecorder1.Stop();
        }

        /// <summary>
        /// Pause the recording operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPause_Click(object sender, EventArgs e)
        {
            audioRecorder1.Pause();
        }

        /// <summary>
        /// UnPause the recording operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUnPause_Click(object sender, EventArgs e)
        {
            audioRecorder1.UnPause();
        }

        /// <summary>
        /// Timer tick to get the meter. You can also get the meter value in RecordProgress event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrMeterIn_Tick(object sender, EventArgs e)
        {
            //Get the meter:
            lblMeterIn.Text = audioMeter1.Meter.ToString("0.00");
        }

        /// <summary>
        /// When selecting the ACM WAV format, display the ACM Tags and Formats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDestinationFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the destination:
            SetDestinationFileName();

            lblBits.Visible = false;
            cboBits.Visible = false;
            pnlACM.Visible = false;

            if (cboDestinationFormat.Text == "ACM")
            {
                //Display the ACM settings
                pnlACM.Visible = true;
                pnlACM.Left = 44;
                //pnlACM.Top = 608;
            }

            if (cboDestinationFormat.Text == "WAV")
            {
                //Display the bit-depth combo box
                lblBits.Visible = true;
                cboBits.Visible = true;
            }

        }

        /// <summary>
        /// Open the windows explorer of the file location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOpenFileLocation_Click(object sender, EventArgs e)
        {
            string argument = "/select, \"" + lblDestinationFile.Text + "\"";

            Process.Start("explorer.exe", argument);
        }

        /// <summary>
        /// Get ACM formats according to the selected tag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboACMTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboACMFormats.DataSource = audioRecorder1.GetACMFormats(cboACMTags.Text);

            cboACMFormats.SelectedIndex = 0;
        }

        /// <summary>
        /// Open the destination multimedia file with the default multimedia player of the system:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlayWithDefaultPlayer_Click(object sender, EventArgs e)
        {
            if (lblDestinationFile.Text == "") return;

            Process.Start(lblDestinationFile.Text);
        }

        /// <summary>
        /// Enable or disable the recording buttons.
        /// </summary>
        /// <param name="state"></param>
        void EnableDisableControls(bool state)
        {
            cmdRecord.Enabled = state;
            cmdPause.Enabled = state;
            cmdUnPause.Enabled = state;
        }

        /// <summary>
        /// On closing, check if the control is recording, if so, stop the recording operation before exit the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioRecorder_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region SafeExit

            //Safe exit
            if (audioRecorder1.RecordingState == CSAudioRecorder.RecordingState.Recording)
            {
                audioRecorder1.Stop();

                while (audioRecorder1.RecordingState != CSAudioRecorder.RecordingState.Ready)
                {
                    Application.DoEvents();

                    Thread.Sleep(100);
                }
            }

            #endregion
        }

        /// <summary>
        /// Show the frmID3TagsEditor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdID3Tags_Click(object sender, EventArgs e)
        {
            if (lblDestinationFile.Text == "") return;

            frmID3TagsEditor frmAllID3Tags = new frmID3TagsEditor();

            frmAllID3Tags.ShowDialog(this);
        }

        /// <summary>
        /// Check the license.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCheckLicense_Click(object sender, EventArgs e)
        {
            if (audioRecorder1.CheckLicense())
                MessageBox.Show("Registration is OK");
        }

    }
}
