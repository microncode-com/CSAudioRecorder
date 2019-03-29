namespace CSAudioRecorderExample
{
    partial class frmAudioRecorder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudioRecorder));
            this.cmdRecord = new System.Windows.Forms.Button();
            this.cmdPause = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.lblMeterIn = new System.Windows.Forms.Label();
            this.lblMeter = new System.Windows.Forms.Label();
            this.tmrMeterIn = new System.Windows.Forms.Timer(this.components);
            this.chkStartWhenNoise = new System.Windows.Forms.CheckBox();
            this.txtStartWhenNoiseVal = new System.Windows.Forms.TextBox();
            this.chkStopWhenSilence = new System.Windows.Forms.CheckBox();
            this.txtStopWhenSilenceSeconds = new System.Windows.Forms.TextBox();
            this.txtStopWhenSilenceVal = new System.Windows.Forms.TextBox();
            this.grpDestinationFile = new System.Windows.Forms.GroupBox();
            this.cmdPlayWithDefaultPlayer = new System.Windows.Forms.Button();
            this.cmdOpenFileLocation = new System.Windows.Forms.Button();
            this.lblDestinationFile = new System.Windows.Forms.Label();
            this.pnlACM = new System.Windows.Forms.Panel();
            this.cboACMFormats = new System.Windows.Forms.ComboBox();
            this.cboACMTags = new System.Windows.Forms.ComboBox();
            this.lblACMTag = new System.Windows.Forms.Label();
            this.lblACMFormats = new System.Windows.Forms.Label();
            this.grpID3Tags = new System.Windows.Forms.GroupBox();
            this.lblTagComment = new System.Windows.Forms.Label();
            this.txtTagTitle = new System.Windows.Forms.TextBox();
            this.lblTagTrackNum = new System.Windows.Forms.Label();
            this.lblTagTitle = new System.Windows.Forms.Label();
            this.txtTagTrackNum = new System.Windows.Forms.TextBox();
            this.txtTagYear = new System.Windows.Forms.TextBox();
            this.lblTagCopyright = new System.Windows.Forms.Label();
            this.lblTagYear = new System.Windows.Forms.Label();
            this.txtTagCopyright = new System.Windows.Forms.TextBox();
            this.txtTagComment = new System.Windows.Forms.TextBox();
            this.lblTagAlbum = new System.Windows.Forms.Label();
            this.txtTagAlbum = new System.Windows.Forms.TextBox();
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.lblRecorderMode = new System.Windows.Forms.Label();
            this.lblDestinationFormat = new System.Windows.Forms.Label();
            this.cboDestinationFormat = new System.Windows.Forms.ComboBox();
            this.cboRecorderMode = new System.Windows.Forms.ComboBox();
            this.cboChannels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBits = new System.Windows.Forms.Label();
            this.cboBits = new System.Windows.Forms.ComboBox();
            this.lblSamplerate = new System.Windows.Forms.Label();
            this.cboSamplerate = new System.Windows.Forms.ComboBox();
            this.lblBitrate = new System.Windows.Forms.Label();
            this.lblAudioSource = new System.Windows.Forms.Label();
            this.cboBitrate = new System.Windows.Forms.ComboBox();
            this.cboAudioSource = new System.Windows.Forms.ComboBox();
            this.lblStartWhenNoiseVal = new System.Windows.Forms.Label();
            this.lblStopWhenSilenceSeconds = new System.Windows.Forms.Label();
            this.lblStopWhenSilenceVal = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSizeIn = new System.Windows.Forms.Label();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmdUnPause = new System.Windows.Forms.Button();
            this.cmdID3Tags = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.audioRecorder1 = new CSAudioRecorder.AudioRecorder();
            this.audioMeter1 = new CSAudioRecorder.AudioMeter();
            this.audioVisualization1 = new CSAudioRecorder.AudioVisualization();
            this.cmdCheckLicense = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpDestinationFile.SuspendLayout();
            this.pnlACM.SuspendLayout();
            this.grpID3Tags.SuspendLayout();
            this.grpDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRecord
            // 
            this.cmdRecord.Location = new System.Drawing.Point(31, 897);
            this.cmdRecord.Name = "cmdRecord";
            this.cmdRecord.Size = new System.Drawing.Size(75, 23);
            this.cmdRecord.TabIndex = 23;
            this.cmdRecord.Text = "Record";
            this.cmdRecord.UseVisualStyleBackColor = true;
            this.cmdRecord.Click += new System.EventHandler(this.cmdRecord_Click);
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(112, 897);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(75, 23);
            this.cmdPause.TabIndex = 24;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(276, 897);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 25;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // lblMeterIn
            // 
            this.lblMeterIn.AutoSize = true;
            this.lblMeterIn.Location = new System.Drawing.Point(766, 71);
            this.lblMeterIn.Name = "lblMeterIn";
            this.lblMeterIn.Size = new System.Drawing.Size(28, 13);
            this.lblMeterIn.TabIndex = 45;
            this.lblMeterIn.Text = "0.00";
            // 
            // lblMeter
            // 
            this.lblMeter.AutoSize = true;
            this.lblMeter.Location = new System.Drawing.Point(29, 71);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(34, 13);
            this.lblMeter.TabIndex = 46;
            this.lblMeter.Text = "Meter";
            // 
            // tmrMeterIn
            // 
            this.tmrMeterIn.Tick += new System.EventHandler(this.tmrMeterIn_Tick);
            // 
            // chkStartWhenNoise
            // 
            this.chkStartWhenNoise.AutoSize = true;
            this.chkStartWhenNoise.Location = new System.Drawing.Point(40, 722);
            this.chkStartWhenNoise.Name = "chkStartWhenNoise";
            this.chkStartWhenNoise.Size = new System.Drawing.Size(205, 17);
            this.chkStartWhenNoise.TabIndex = 49;
            this.chkStartWhenNoise.Text = "Start to record when noise is detected";
            this.chkStartWhenNoise.UseVisualStyleBackColor = true;
            // 
            // txtStartWhenNoiseVal
            // 
            this.txtStartWhenNoiseVal.Location = new System.Drawing.Point(264, 720);
            this.txtStartWhenNoiseVal.Name = "txtStartWhenNoiseVal";
            this.txtStartWhenNoiseVal.Size = new System.Drawing.Size(61, 20);
            this.txtStartWhenNoiseVal.TabIndex = 50;
            this.txtStartWhenNoiseVal.Text = "1";
            // 
            // chkStopWhenSilence
            // 
            this.chkStopWhenSilence.AutoSize = true;
            this.chkStopWhenSilence.Location = new System.Drawing.Point(40, 758);
            this.chkStopWhenSilence.Name = "chkStopWhenSilence";
            this.chkStopWhenSilence.Size = new System.Drawing.Size(213, 17);
            this.chkStopWhenSilence.TabIndex = 51;
            this.chkStopWhenSilence.Text = "Stop to record when silence is detected";
            this.chkStopWhenSilence.UseVisualStyleBackColor = true;
            // 
            // txtStopWhenSilenceSeconds
            // 
            this.txtStopWhenSilenceSeconds.Location = new System.Drawing.Point(331, 758);
            this.txtStopWhenSilenceSeconds.Name = "txtStopWhenSilenceSeconds";
            this.txtStopWhenSilenceSeconds.Size = new System.Drawing.Size(76, 20);
            this.txtStopWhenSilenceSeconds.TabIndex = 52;
            this.txtStopWhenSilenceSeconds.Text = "3";
            // 
            // txtStopWhenSilenceVal
            // 
            this.txtStopWhenSilenceVal.Location = new System.Drawing.Point(264, 758);
            this.txtStopWhenSilenceVal.Name = "txtStopWhenSilenceVal";
            this.txtStopWhenSilenceVal.Size = new System.Drawing.Size(61, 20);
            this.txtStopWhenSilenceVal.TabIndex = 53;
            this.txtStopWhenSilenceVal.Text = "1";
            // 
            // grpDestinationFile
            // 
            this.grpDestinationFile.BackColor = System.Drawing.SystemColors.Control;
            this.grpDestinationFile.Controls.Add(this.cmdPlayWithDefaultPlayer);
            this.grpDestinationFile.Controls.Add(this.cmdOpenFileLocation);
            this.grpDestinationFile.Controls.Add(this.lblDestinationFile);
            this.grpDestinationFile.Location = new System.Drawing.Point(32, 801);
            this.grpDestinationFile.Name = "grpDestinationFile";
            this.grpDestinationFile.Size = new System.Drawing.Size(762, 71);
            this.grpDestinationFile.TabIndex = 76;
            this.grpDestinationFile.TabStop = false;
            this.grpDestinationFile.Text = "Destination File";
            // 
            // cmdPlayWithDefaultPlayer
            // 
            this.cmdPlayWithDefaultPlayer.Location = new System.Drawing.Point(548, 24);
            this.cmdPlayWithDefaultPlayer.Name = "cmdPlayWithDefaultPlayer";
            this.cmdPlayWithDefaultPlayer.Size = new System.Drawing.Size(74, 23);
            this.cmdPlayWithDefaultPlayer.TabIndex = 78;
            this.cmdPlayWithDefaultPlayer.Text = "Play";
            this.cmdPlayWithDefaultPlayer.UseVisualStyleBackColor = true;
            this.cmdPlayWithDefaultPlayer.Click += new System.EventHandler(this.cmdPlayWithDefaultPlayer_Click);
            // 
            // cmdOpenFileLocation
            // 
            this.cmdOpenFileLocation.Location = new System.Drawing.Point(628, 24);
            this.cmdOpenFileLocation.Name = "cmdOpenFileLocation";
            this.cmdOpenFileLocation.Size = new System.Drawing.Size(111, 23);
            this.cmdOpenFileLocation.TabIndex = 21;
            this.cmdOpenFileLocation.Text = "Open file Location";
            this.cmdOpenFileLocation.UseVisualStyleBackColor = true;
            this.cmdOpenFileLocation.Click += new System.EventHandler(this.cmdOpenFileLocation_Click);
            // 
            // lblDestinationFile
            // 
            this.lblDestinationFile.Location = new System.Drawing.Point(6, 24);
            this.lblDestinationFile.Name = "lblDestinationFile";
            this.lblDestinationFile.Size = new System.Drawing.Size(506, 29);
            this.lblDestinationFile.TabIndex = 74;
            this.lblDestinationFile.Text = "C:\\";
            // 
            // pnlACM
            // 
            this.pnlACM.Controls.Add(this.cboACMFormats);
            this.pnlACM.Controls.Add(this.cboACMTags);
            this.pnlACM.Controls.Add(this.lblACMTag);
            this.pnlACM.Controls.Add(this.lblACMFormats);
            this.pnlACM.Location = new System.Drawing.Point(458, 614);
            this.pnlACM.Name = "pnlACM";
            this.pnlACM.Size = new System.Drawing.Size(398, 64);
            this.pnlACM.TabIndex = 77;
            // 
            // cboACMFormats
            // 
            this.cboACMFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboACMFormats.FormattingEnabled = true;
            this.cboACMFormats.Location = new System.Drawing.Point(200, 29);
            this.cboACMFormats.Name = "cboACMFormats";
            this.cboACMFormats.Size = new System.Drawing.Size(188, 21);
            this.cboACMFormats.TabIndex = 79;
            // 
            // cboACMTags
            // 
            this.cboACMTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboACMTags.FormattingEnabled = true;
            this.cboACMTags.Location = new System.Drawing.Point(6, 29);
            this.cboACMTags.Name = "cboACMTags";
            this.cboACMTags.Size = new System.Drawing.Size(188, 21);
            this.cboACMTags.TabIndex = 78;
            this.cboACMTags.SelectedIndexChanged += new System.EventHandler(this.cboACMTags_SelectedIndexChanged);
            // 
            // lblACMTag
            // 
            this.lblACMTag.AutoSize = true;
            this.lblACMTag.Location = new System.Drawing.Point(3, 13);
            this.lblACMTag.Name = "lblACMTag";
            this.lblACMTag.Size = new System.Drawing.Size(60, 13);
            this.lblACMTag.TabIndex = 69;
            this.lblACMTag.Text = "ACM Tags:";
            // 
            // lblACMFormats
            // 
            this.lblACMFormats.AutoSize = true;
            this.lblACMFormats.Location = new System.Drawing.Point(197, 13);
            this.lblACMFormats.Name = "lblACMFormats";
            this.lblACMFormats.Size = new System.Drawing.Size(73, 13);
            this.lblACMFormats.TabIndex = 71;
            this.lblACMFormats.Text = "ACM Formats:";
            // 
            // grpID3Tags
            // 
            this.grpID3Tags.BackColor = System.Drawing.SystemColors.Control;
            this.grpID3Tags.Controls.Add(this.lblTagComment);
            this.grpID3Tags.Controls.Add(this.txtTagTitle);
            this.grpID3Tags.Controls.Add(this.lblTagTrackNum);
            this.grpID3Tags.Controls.Add(this.lblTagTitle);
            this.grpID3Tags.Controls.Add(this.txtTagTrackNum);
            this.grpID3Tags.Controls.Add(this.txtTagYear);
            this.grpID3Tags.Controls.Add(this.lblTagCopyright);
            this.grpID3Tags.Controls.Add(this.lblTagYear);
            this.grpID3Tags.Controls.Add(this.txtTagCopyright);
            this.grpID3Tags.Controls.Add(this.txtTagComment);
            this.grpID3Tags.Controls.Add(this.lblTagAlbum);
            this.grpID3Tags.Controls.Add(this.txtTagAlbum);
            this.grpID3Tags.Location = new System.Drawing.Point(448, 442);
            this.grpID3Tags.Name = "grpID3Tags";
            this.grpID3Tags.Size = new System.Drawing.Size(346, 140);
            this.grpID3Tags.TabIndex = 78;
            this.grpID3Tags.TabStop = false;
            this.grpID3Tags.Text = "ID3 Tags";
            // 
            // lblTagComment
            // 
            this.lblTagComment.AutoSize = true;
            this.lblTagComment.Location = new System.Drawing.Point(14, 82);
            this.lblTagComment.Name = "lblTagComment";
            this.lblTagComment.Size = new System.Drawing.Size(51, 13);
            this.lblTagComment.TabIndex = 76;
            this.lblTagComment.Text = "Comment";
            // 
            // txtTagTitle
            // 
            this.txtTagTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTagTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagTitle.Location = new System.Drawing.Point(17, 44);
            this.txtTagTitle.Name = "txtTagTitle";
            this.txtTagTitle.Size = new System.Drawing.Size(98, 20);
            this.txtTagTitle.TabIndex = 14;
            this.txtTagTitle.Text = "CSAudioRecorder";
            // 
            // lblTagTrackNum
            // 
            this.lblTagTrackNum.AutoSize = true;
            this.lblTagTrackNum.Location = new System.Drawing.Point(222, 28);
            this.lblTagTrackNum.Name = "lblTagTrackNum";
            this.lblTagTrackNum.Size = new System.Drawing.Size(42, 13);
            this.lblTagTrackNum.TabIndex = 75;
            this.lblTagTrackNum.Text = "Track#";
            // 
            // lblTagTitle
            // 
            this.lblTagTitle.AutoSize = true;
            this.lblTagTitle.Location = new System.Drawing.Point(14, 28);
            this.lblTagTitle.Name = "lblTagTitle";
            this.lblTagTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTagTitle.TabIndex = 66;
            this.lblTagTitle.Text = "Title";
            // 
            // txtTagTrackNum
            // 
            this.txtTagTrackNum.Location = new System.Drawing.Point(225, 44);
            this.txtTagTrackNum.Name = "txtTagTrackNum";
            this.txtTagTrackNum.Size = new System.Drawing.Size(98, 20);
            this.txtTagTrackNum.TabIndex = 16;
            this.txtTagTrackNum.Text = "1";
            // 
            // txtTagYear
            // 
            this.txtTagYear.Location = new System.Drawing.Point(121, 98);
            this.txtTagYear.Name = "txtTagYear";
            this.txtTagYear.Size = new System.Drawing.Size(98, 20);
            this.txtTagYear.TabIndex = 18;
            // 
            // lblTagCopyright
            // 
            this.lblTagCopyright.AutoSize = true;
            this.lblTagCopyright.Location = new System.Drawing.Point(222, 82);
            this.lblTagCopyright.Name = "lblTagCopyright";
            this.lblTagCopyright.Size = new System.Drawing.Size(51, 13);
            this.lblTagCopyright.TabIndex = 73;
            this.lblTagCopyright.Text = "Copyright";
            // 
            // lblTagYear
            // 
            this.lblTagYear.AutoSize = true;
            this.lblTagYear.Location = new System.Drawing.Point(118, 82);
            this.lblTagYear.Name = "lblTagYear";
            this.lblTagYear.Size = new System.Drawing.Size(29, 13);
            this.lblTagYear.TabIndex = 68;
            this.lblTagYear.Text = "Year";
            // 
            // txtTagCopyright
            // 
            this.txtTagCopyright.Location = new System.Drawing.Point(225, 98);
            this.txtTagCopyright.Name = "txtTagCopyright";
            this.txtTagCopyright.Size = new System.Drawing.Size(98, 20);
            this.txtTagCopyright.TabIndex = 19;
            // 
            // txtTagComment
            // 
            this.txtTagComment.Location = new System.Drawing.Point(19, 98);
            this.txtTagComment.Name = "txtTagComment";
            this.txtTagComment.Size = new System.Drawing.Size(96, 20);
            this.txtTagComment.TabIndex = 17;
            // 
            // lblTagAlbum
            // 
            this.lblTagAlbum.AutoSize = true;
            this.lblTagAlbum.Location = new System.Drawing.Point(118, 28);
            this.lblTagAlbum.Name = "lblTagAlbum";
            this.lblTagAlbum.Size = new System.Drawing.Size(36, 13);
            this.lblTagAlbum.TabIndex = 71;
            this.lblTagAlbum.Text = "Album";
            // 
            // txtTagAlbum
            // 
            this.txtTagAlbum.Location = new System.Drawing.Point(121, 44);
            this.txtTagAlbum.Name = "txtTagAlbum";
            this.txtTagAlbum.Size = new System.Drawing.Size(98, 20);
            this.txtTagAlbum.TabIndex = 15;
            // 
            // grpDestination
            // 
            this.grpDestination.BackColor = System.Drawing.SystemColors.Control;
            this.grpDestination.Controls.Add(this.lblRecorderMode);
            this.grpDestination.Controls.Add(this.lblDestinationFormat);
            this.grpDestination.Controls.Add(this.cboDestinationFormat);
            this.grpDestination.Controls.Add(this.cboRecorderMode);
            this.grpDestination.Controls.Add(this.cboChannels);
            this.grpDestination.Controls.Add(this.label1);
            this.grpDestination.Controls.Add(this.lblBits);
            this.grpDestination.Controls.Add(this.cboBits);
            this.grpDestination.Controls.Add(this.lblSamplerate);
            this.grpDestination.Controls.Add(this.cboSamplerate);
            this.grpDestination.Controls.Add(this.lblBitrate);
            this.grpDestination.Controls.Add(this.lblAudioSource);
            this.grpDestination.Controls.Add(this.cboBitrate);
            this.grpDestination.Controls.Add(this.cboAudioSource);
            this.grpDestination.Location = new System.Drawing.Point(32, 442);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(410, 251);
            this.grpDestination.TabIndex = 79;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Destination";
            // 
            // lblRecorderMode
            // 
            this.lblRecorderMode.AutoSize = true;
            this.lblRecorderMode.Location = new System.Drawing.Point(13, 28);
            this.lblRecorderMode.Name = "lblRecorderMode";
            this.lblRecorderMode.Size = new System.Drawing.Size(81, 13);
            this.lblRecorderMode.TabIndex = 43;
            this.lblRecorderMode.Text = "Recorder Mode";
            // 
            // lblDestinationFormat
            // 
            this.lblDestinationFormat.AutoSize = true;
            this.lblDestinationFormat.Location = new System.Drawing.Point(12, 135);
            this.lblDestinationFormat.Name = "lblDestinationFormat";
            this.lblDestinationFormat.Size = new System.Drawing.Size(95, 13);
            this.lblDestinationFormat.TabIndex = 41;
            this.lblDestinationFormat.Text = "Destination Format";
            // 
            // cboDestinationFormat
            // 
            this.cboDestinationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinationFormat.FormattingEnabled = true;
            this.cboDestinationFormat.Location = new System.Drawing.Point(16, 151);
            this.cboDestinationFormat.Name = "cboDestinationFormat";
            this.cboDestinationFormat.Size = new System.Drawing.Size(188, 21);
            this.cboDestinationFormat.TabIndex = 40;
            this.cboDestinationFormat.SelectedIndexChanged += new System.EventHandler(this.cboDestinationFormat_SelectedIndexChanged);
            // 
            // cboRecorderMode
            // 
            this.cboRecorderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecorderMode.FormattingEnabled = true;
            this.cboRecorderMode.Location = new System.Drawing.Point(16, 44);
            this.cboRecorderMode.Name = "cboRecorderMode";
            this.cboRecorderMode.Size = new System.Drawing.Size(286, 21);
            this.cboRecorderMode.TabIndex = 42;
            this.cboRecorderMode.SelectedIndexChanged += new System.EventHandler(this.cboRecorderMode_SelectedIndexChanged);
            // 
            // cboChannels
            // 
            this.cboChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChannels.FormattingEnabled = true;
            this.cboChannels.Location = new System.Drawing.Point(210, 204);
            this.cboChannels.Name = "cboChannels";
            this.cboChannels.Size = new System.Drawing.Size(91, 21);
            this.cboChannels.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Channels";
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(304, 188);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(49, 13);
            this.lblBits.TabIndex = 37;
            this.lblBits.Text = "Bit depth";
            // 
            // cboBits
            // 
            this.cboBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBits.FormattingEnabled = true;
            this.cboBits.Location = new System.Drawing.Point(307, 204);
            this.cboBits.Name = "cboBits";
            this.cboBits.Size = new System.Drawing.Size(91, 21);
            this.cboBits.TabIndex = 36;
            // 
            // lblSamplerate
            // 
            this.lblSamplerate.AutoSize = true;
            this.lblSamplerate.Location = new System.Drawing.Point(110, 188);
            this.lblSamplerate.Name = "lblSamplerate";
            this.lblSamplerate.Size = new System.Drawing.Size(60, 13);
            this.lblSamplerate.TabIndex = 35;
            this.lblSamplerate.Text = "Samplerate";
            // 
            // cboSamplerate
            // 
            this.cboSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSamplerate.FormattingEnabled = true;
            this.cboSamplerate.Location = new System.Drawing.Point(113, 204);
            this.cboSamplerate.Name = "cboSamplerate";
            this.cboSamplerate.Size = new System.Drawing.Size(91, 21);
            this.cboSamplerate.TabIndex = 34;
            // 
            // lblBitrate
            // 
            this.lblBitrate.AutoSize = true;
            this.lblBitrate.Location = new System.Drawing.Point(13, 188);
            this.lblBitrate.Name = "lblBitrate";
            this.lblBitrate.Size = new System.Drawing.Size(37, 13);
            this.lblBitrate.TabIndex = 33;
            this.lblBitrate.Text = "Bitrate";
            // 
            // lblAudioSource
            // 
            this.lblAudioSource.AutoSize = true;
            this.lblAudioSource.Location = new System.Drawing.Point(13, 81);
            this.lblAudioSource.Name = "lblAudioSource";
            this.lblAudioSource.Size = new System.Drawing.Size(71, 13);
            this.lblAudioSource.TabIndex = 32;
            this.lblAudioSource.Text = "Audio Source";
            // 
            // cboBitrate
            // 
            this.cboBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitrate.FormattingEnabled = true;
            this.cboBitrate.Location = new System.Drawing.Point(16, 204);
            this.cboBitrate.Name = "cboBitrate";
            this.cboBitrate.Size = new System.Drawing.Size(91, 21);
            this.cboBitrate.TabIndex = 31;
            // 
            // cboAudioSource
            // 
            this.cboAudioSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioSource.FormattingEnabled = true;
            this.cboAudioSource.Location = new System.Drawing.Point(16, 97);
            this.cboAudioSource.Name = "cboAudioSource";
            this.cboAudioSource.Size = new System.Drawing.Size(286, 21);
            this.cboAudioSource.TabIndex = 30;
            // 
            // lblStartWhenNoiseVal
            // 
            this.lblStartWhenNoiseVal.AutoSize = true;
            this.lblStartWhenNoiseVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStartWhenNoiseVal.Location = new System.Drawing.Point(262, 707);
            this.lblStartWhenNoiseVal.Name = "lblStartWhenNoiseVal";
            this.lblStartWhenNoiseVal.Size = new System.Drawing.Size(67, 12);
            this.lblStartWhenNoiseVal.TabIndex = 80;
            this.lblStartWhenNoiseVal.Text = "Min Meter Val:";
            // 
            // lblStopWhenSilenceSeconds
            // 
            this.lblStopWhenSilenceSeconds.AutoSize = true;
            this.lblStopWhenSilenceSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStopWhenSilenceSeconds.Location = new System.Drawing.Point(331, 745);
            this.lblStopWhenSilenceSeconds.Name = "lblStopWhenSilenceSeconds";
            this.lblStopWhenSilenceSeconds.Size = new System.Drawing.Size(76, 12);
            this.lblStopWhenSilenceSeconds.TabIndex = 81;
            this.lblStopWhenSilenceSeconds.Text = "Silence Seconds:";
            // 
            // lblStopWhenSilenceVal
            // 
            this.lblStopWhenSilenceVal.AutoSize = true;
            this.lblStopWhenSilenceVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStopWhenSilenceVal.Location = new System.Drawing.Point(261, 745);
            this.lblStopWhenSilenceVal.Name = "lblStopWhenSilenceVal";
            this.lblStopWhenSilenceVal.Size = new System.Drawing.Size(70, 12);
            this.lblStopWhenSilenceVal.TabIndex = 82;
            this.lblStopWhenSilenceVal.Text = "Max Meter Val:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(455, 723);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 83;
            this.lblSize.Text = "Size:";
            // 
            // lblSizeIn
            // 
            this.lblSizeIn.AutoSize = true;
            this.lblSizeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSizeIn.Location = new System.Drawing.Point(491, 719);
            this.lblSizeIn.Name = "lblSizeIn";
            this.lblSizeIn.Size = new System.Drawing.Size(17, 18);
            this.lblSizeIn.TabIndex = 84;
            this.lblSizeIn.Text = "0";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTimeIn.Location = new System.Drawing.Point(491, 755);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(72, 18);
            this.lblTimeIn.TabIndex = 86;
            this.lblTimeIn.Text = "00:00:00";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(455, 759);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 85;
            this.lblTime.Text = "Time:";
            // 
            // cmdUnPause
            // 
            this.cmdUnPause.Location = new System.Drawing.Point(193, 897);
            this.cmdUnPause.Name = "cmdUnPause";
            this.cmdUnPause.Size = new System.Drawing.Size(75, 23);
            this.cmdUnPause.TabIndex = 87;
            this.cmdUnPause.Text = "UnPause";
            this.cmdUnPause.UseVisualStyleBackColor = true;
            this.cmdUnPause.Click += new System.EventHandler(this.cmdUnPause_Click);
            // 
            // cmdID3Tags
            // 
            this.cmdID3Tags.Location = new System.Drawing.Point(474, 897);
            this.cmdID3Tags.Name = "cmdID3Tags";
            this.cmdID3Tags.Size = new System.Drawing.Size(145, 23);
            this.cmdID3Tags.TabIndex = 92;
            this.cmdID3Tags.Text = "ID3 Tags Editor";
            this.cmdID3Tags.UseVisualStyleBackColor = true;
            this.cmdID3Tags.Click += new System.EventHandler(this.cmdID3Tags_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(543, 16);
            this.label3.TabIndex = 284;
            this.label3.Text = ".NET component to record audio from any source to many types of audio files.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 283;
            this.label2.Text = "CSAudioRecorder |";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-36, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 45);
            this.pictureBox1.TabIndex = 285;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(-26, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(957, 45);
            this.pictureBox2.TabIndex = 286;
            this.pictureBox2.TabStop = false;
            // 
            // audioRecorder1
            // 
            this.audioRecorder1.AudioSource = null;
            this.audioRecorder1.BitrateVal = 0;
            this.audioRecorder1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.audioRecorder1.DeleteEmptyRecordedFile = true;
            this.audioRecorder1.DeviceIndex = 0;
            this.audioRecorder1.FileName = null;
            this.audioRecorder1.IsRecording = false;
            this.audioRecorder1.Latency = 80;
            this.audioRecorder1.Location = new System.Drawing.Point(192, 73);
            this.audioRecorder1.MessageArgs = null;
            this.audioRecorder1.Name = "audioRecorder1";
            this.audioRecorder1.ProgressArgs = null;
            this.audioRecorder1.RatingStars = 0F;
            this.audioRecorder1.RatingUser = "Windows Media Player 9 Series";
            this.audioRecorder1.SamplerateVal = 0;
            this.audioRecorder1.Size = new System.Drawing.Size(52, 52);
            this.audioRecorder1.StartOnNoise = false;
            this.audioRecorder1.StartOnNoiseVal = 1F;
            this.audioRecorder1.StopOnSilence = false;
            this.audioRecorder1.StopOnSilenceSeconds = 1;
            this.audioRecorder1.StopOnSilenceVal = 1F;
            this.audioRecorder1.TabIndex = 14;
            this.audioRecorder1.TagAlbum = null;
            this.audioRecorder1.TagArtists = ((System.Collections.Generic.List<string>)(resources.GetObject("audioRecorder1.TagArtists")));
            this.audioRecorder1.TagComment = null;
            this.audioRecorder1.TagComposers = ((System.Collections.Generic.List<string>)(resources.GetObject("audioRecorder1.TagComposers")));
            this.audioRecorder1.TagCopyright = null;
            this.audioRecorder1.TagGenres = ((System.Collections.Generic.List<string>)(resources.GetObject("audioRecorder1.TagGenres")));
            this.audioRecorder1.TagLyrics = null;
            this.audioRecorder1.TagPerformers = ((System.Collections.Generic.List<string>)(resources.GetObject("audioRecorder1.TagPerformers")));
            this.audioRecorder1.TagRating = ((short)(0));
            this.audioRecorder1.TagTitle = null;
            this.audioRecorder1.TagTrack = ((uint)(0u));
            this.audioRecorder1.TagYear = null;
            this.audioRecorder1.UserKey = "Your registration key";
            this.audioRecorder1.UserName = "Your email";
            this.audioRecorder1.RecordProgress += new CSAudioRecorder.OnRecordProgressEventHandler(this.audioRecorder1_RecordProgress);
            this.audioRecorder1.RecordError += new CSAudioRecorder.OnRecordErrorEventHandler(this.audioRecorder1_RecordError);
            this.audioRecorder1.RecordDone += new System.EventHandler(this.audioRecorder1_RecordDone);
            this.audioRecorder1.RecordStart += new System.EventHandler(this.audioRecorder1_RecordStart);
            // 
            // audioMeter1
            // 
            this.audioMeter1.Location = new System.Drawing.Point(32, 87);
            this.audioMeter1.Name = "audioMeter1";
            this.audioMeter1.Size = new System.Drawing.Size(762, 23);
            this.audioMeter1.TabIndex = 48;
            // 
            // audioVisualization1
            // 
            this.audioVisualization1.BackColor = System.Drawing.Color.Black;
            this.audioVisualization1.BarCount = 50;
            this.audioVisualization1.BarSpacing = 2;
            this.audioVisualization1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.audioVisualization1.ColorBase = System.Drawing.Color.Green;
            this.audioVisualization1.ColorMax = System.Drawing.Color.Red;
            this.audioVisualization1.HighQuality = true;
            this.audioVisualization1.Interval = 40;
            this.audioVisualization1.IsXLogScale = true;
            this.audioVisualization1.Location = new System.Drawing.Point(31, 129);
            this.audioVisualization1.MaximumFrequency = 10000;
            this.audioVisualization1.Name = "audioVisualization1";
            this.audioVisualization1.Size = new System.Drawing.Size(762, 285);
            this.audioVisualization1.TabIndex = 47;
            this.audioVisualization1.UseAverage = true;
            // 
            // cmdCheckLicense
            // 
            this.cmdCheckLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdCheckLicense.Image = ((System.Drawing.Image)(resources.GetObject("cmdCheckLicense.Image")));
            this.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCheckLicense.Location = new System.Drawing.Point(625, 897);
            this.cmdCheckLicense.Name = "cmdCheckLicense";
            this.cmdCheckLicense.Size = new System.Drawing.Size(168, 23);
            this.cmdCheckLicense.TabIndex = 287;
            this.cmdCheckLicense.Text = "Order a license online";
            this.cmdCheckLicense.UseVisualStyleBackColor = true;
            this.cmdCheckLicense.Click += new System.EventHandler(this.cmdCheckLicense_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 288;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAudioRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 939);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdCheckLicense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmdID3Tags);
            this.Controls.Add(this.cmdUnPause);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSizeIn);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblStopWhenSilenceVal);
            this.Controls.Add(this.lblStopWhenSilenceSeconds);
            this.Controls.Add(this.lblStartWhenNoiseVal);
            this.Controls.Add(this.pnlACM);
            this.Controls.Add(this.grpDestination);
            this.Controls.Add(this.audioRecorder1);
            this.Controls.Add(this.grpID3Tags);
            this.Controls.Add(this.grpDestinationFile);
            this.Controls.Add(this.txtStopWhenSilenceVal);
            this.Controls.Add(this.txtStopWhenSilenceSeconds);
            this.Controls.Add(this.chkStopWhenSilence);
            this.Controls.Add(this.txtStartWhenNoiseVal);
            this.Controls.Add(this.chkStartWhenNoise);
            this.Controls.Add(this.audioMeter1);
            this.Controls.Add(this.audioVisualization1);
            this.Controls.Add(this.lblMeter);
            this.Controls.Add(this.lblMeterIn);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.cmdRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioRecorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSAudioRecorder - Full Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAudioRecorder_FormClosing);
            this.Load += new System.EventHandler(this.frmAudioRecorder_Load);
            this.grpDestinationFile.ResumeLayout(false);
            this.pnlACM.ResumeLayout(false);
            this.pnlACM.PerformLayout();
            this.grpID3Tags.ResumeLayout(false);
            this.grpID3Tags.PerformLayout();
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CSAudioRecorder.AudioRecorder audioRecorder1;
        private System.Windows.Forms.Button cmdRecord;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Label lblMeterIn;
        private System.Windows.Forms.Label lblMeter;
        private CSAudioRecorder.AudioVisualization audioVisualization1;
        private CSAudioRecorder.AudioMeter audioMeter1;
        private System.Windows.Forms.Timer tmrMeterIn;
        private System.Windows.Forms.CheckBox chkStartWhenNoise;
        private System.Windows.Forms.TextBox txtStartWhenNoiseVal;
        private System.Windows.Forms.CheckBox chkStopWhenSilence;
        private System.Windows.Forms.TextBox txtStopWhenSilenceSeconds;
        private System.Windows.Forms.TextBox txtStopWhenSilenceVal;
        private System.Windows.Forms.GroupBox grpDestinationFile;
        private System.Windows.Forms.Button cmdOpenFileLocation;
        private System.Windows.Forms.Label lblDestinationFile;
        private System.Windows.Forms.Panel pnlACM;
        internal System.Windows.Forms.Label lblACMTag;
        internal System.Windows.Forms.Label lblACMFormats;
        private System.Windows.Forms.ComboBox cboACMFormats;
        private System.Windows.Forms.ComboBox cboACMTags;
        private System.Windows.Forms.Button cmdPlayWithDefaultPlayer;
        private System.Windows.Forms.GroupBox grpID3Tags;
        private System.Windows.Forms.Label lblTagComment;
        private System.Windows.Forms.TextBox txtTagTitle;
        private System.Windows.Forms.Label lblTagTrackNum;
        private System.Windows.Forms.Label lblTagTitle;
        private System.Windows.Forms.TextBox txtTagTrackNum;
        private System.Windows.Forms.TextBox txtTagYear;
        private System.Windows.Forms.Label lblTagCopyright;
        private System.Windows.Forms.Label lblTagYear;
        private System.Windows.Forms.TextBox txtTagCopyright;
        private System.Windows.Forms.TextBox txtTagComment;
        private System.Windows.Forms.Label lblTagAlbum;
        private System.Windows.Forms.TextBox txtTagAlbum;
        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.Label lblRecorderMode;
        private System.Windows.Forms.ComboBox cboRecorderMode;
        private System.Windows.Forms.Label lblDestinationFormat;
        private System.Windows.Forms.ComboBox cboDestinationFormat;
        private System.Windows.Forms.ComboBox cboChannels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.ComboBox cboBits;
        private System.Windows.Forms.Label lblSamplerate;
        private System.Windows.Forms.ComboBox cboSamplerate;
        private System.Windows.Forms.Label lblBitrate;
        private System.Windows.Forms.Label lblAudioSource;
        private System.Windows.Forms.ComboBox cboBitrate;
        private System.Windows.Forms.ComboBox cboAudioSource;
        private System.Windows.Forms.Label lblStartWhenNoiseVal;
        private System.Windows.Forms.Label lblStopWhenSilenceSeconds;
        private System.Windows.Forms.Label lblStopWhenSilenceVal;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizeIn;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button cmdUnPause;
        private System.Windows.Forms.Button cmdID3Tags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdCheckLicense;
        private System.Windows.Forms.Button button1;
    }
}