namespace DigitalMicroscope
{
    partial class DigitalMicroscopeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitalMicroscopeForm));
            this.ControlPanel = new System.Windows.Forms.GroupBox();
            this.VideoRecordInfoLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MeasureTypesCombobox = new MetroFramework.Controls.MetroComboBox();
            this.MeasureButton = new System.Windows.Forms.Button();
            this.PixelResolutionLabel = new MetroFramework.Controls.MetroLabel();
            this.PixelResolutionTxt = new MetroFramework.Controls.MetroTextBox();
            this.SelectCaptureDeviceLabel = new MetroFramework.Controls.MetroLabel();
            this.CameraFpsLabel = new MetroFramework.Controls.MetroLabel();
            this.SensorSizeHeightLabel = new MetroFramework.Controls.MetroLabel();
            this.SensorSizeWidthLabel = new MetroFramework.Controls.MetroLabel();
            this.CameraFpsTxt = new MetroFramework.Controls.MetroTextBox();
            this.SensorSizeHeightTxt = new MetroFramework.Controls.MetroTextBox();
            this.SensorSizeWidthTxt = new MetroFramework.Controls.MetroTextBox();
            this.StartMonitoringButton = new System.Windows.Forms.Button();
            this.CaptureDevicesCombobox = new MetroFramework.Controls.MetroComboBox();
            this.VideoRecordStopButton = new MetroFramework.Controls.MetroButton();
            this.VideoRecordStartButton = new MetroFramework.Controls.MetroButton();
            this.TakeSnapshotButton = new MetroFramework.Controls.MetroButton();
            this.ZoomInButton = new MetroFramework.Controls.MetroButton();
            this.FocusDecreaseButton = new MetroFramework.Controls.MetroButton();
            this.ZoomOutButton = new MetroFramework.Controls.MetroButton();
            this.FocusIncreaseButton = new MetroFramework.Controls.MetroButton();
            this.Display = new System.Windows.Forms.PictureBox();
            this.ContainerDisplayPanel = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.ContainerDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.VideoRecordInfoLabel);
            this.ControlPanel.Controls.Add(this.metroLabel1);
            this.ControlPanel.Controls.Add(this.MeasureTypesCombobox);
            this.ControlPanel.Controls.Add(this.MeasureButton);
            this.ControlPanel.Controls.Add(this.PixelResolutionLabel);
            this.ControlPanel.Controls.Add(this.PixelResolutionTxt);
            this.ControlPanel.Controls.Add(this.SelectCaptureDeviceLabel);
            this.ControlPanel.Controls.Add(this.CameraFpsLabel);
            this.ControlPanel.Controls.Add(this.SensorSizeHeightLabel);
            this.ControlPanel.Controls.Add(this.SensorSizeWidthLabel);
            this.ControlPanel.Controls.Add(this.CameraFpsTxt);
            this.ControlPanel.Controls.Add(this.SensorSizeHeightTxt);
            this.ControlPanel.Controls.Add(this.SensorSizeWidthTxt);
            this.ControlPanel.Controls.Add(this.StartMonitoringButton);
            this.ControlPanel.Controls.Add(this.CaptureDevicesCombobox);
            this.ControlPanel.Controls.Add(this.VideoRecordStopButton);
            this.ControlPanel.Controls.Add(this.VideoRecordStartButton);
            this.ControlPanel.Controls.Add(this.TakeSnapshotButton);
            this.ControlPanel.Controls.Add(this.ZoomInButton);
            this.ControlPanel.Controls.Add(this.FocusDecreaseButton);
            this.ControlPanel.Controls.Add(this.ZoomOutButton);
            this.ControlPanel.Controls.Add(this.FocusIncreaseButton);
            this.ControlPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlPanel.Location = new System.Drawing.Point(509, 65);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(250, 707);
            this.ControlPanel.TabIndex = 6;
            this.ControlPanel.TabStop = false;
            this.ControlPanel.Text = "Control Panel";
            // 
            // VideoRecordInfoLabel
            // 
            this.VideoRecordInfoLabel.AutoSize = true;
            this.VideoRecordInfoLabel.Location = new System.Drawing.Point(88, 474);
            this.VideoRecordInfoLabel.Name = "VideoRecordInfoLabel";
            this.VideoRecordInfoLabel.Size = new System.Drawing.Size(116, 19);
            this.VideoRecordInfoLabel.TabIndex = 25;
            this.VideoRecordInfoLabel.Text = "Video Recording...";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 508);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Select Measure Type";
            // 
            // MeasureTypesCombobox
            // 
            this.MeasureTypesCombobox.FormattingEnabled = true;
            this.MeasureTypesCombobox.ItemHeight = 23;
            this.MeasureTypesCombobox.Location = new System.Drawing.Point(12, 530);
            this.MeasureTypesCombobox.Name = "MeasureTypesCombobox";
            this.MeasureTypesCombobox.Size = new System.Drawing.Size(202, 29);
            this.MeasureTypesCombobox.TabIndex = 22;
            this.MeasureTypesCombobox.UseSelectable = true;
            this.MeasureTypesCombobox.SelectedIndexChanged += new System.EventHandler(this.MeasureTypesCombobox_SelectedIndexChanged);
            // 
            // MeasureButton
            // 
            this.MeasureButton.Location = new System.Drawing.Point(12, 609);
            this.MeasureButton.Name = "MeasureButton";
            this.MeasureButton.Size = new System.Drawing.Size(202, 32);
            this.MeasureButton.TabIndex = 21;
            this.MeasureButton.Text = "Measure";
            this.MeasureButton.UseVisualStyleBackColor = true;
            this.MeasureButton.Click += new System.EventHandler(this.MeasureButton_Click);
            // 
            // PixelResolutionLabel
            // 
            this.PixelResolutionLabel.AutoSize = true;
            this.PixelResolutionLabel.Location = new System.Drawing.Point(12, 569);
            this.PixelResolutionLabel.Name = "PixelResolutionLabel";
            this.PixelResolutionLabel.Size = new System.Drawing.Size(107, 19);
            this.PixelResolutionLabel.TabIndex = 20;
            this.PixelResolutionLabel.Text = "Pixel Resolution :";
            // 
            // PixelResolutionTxt
            // 
            // 
            // 
            // 
            this.PixelResolutionTxt.CustomButton.Image = null;
            this.PixelResolutionTxt.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.PixelResolutionTxt.CustomButton.Name = "";
            this.PixelResolutionTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PixelResolutionTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PixelResolutionTxt.CustomButton.TabIndex = 1;
            this.PixelResolutionTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PixelResolutionTxt.CustomButton.UseSelectable = true;
            this.PixelResolutionTxt.CustomButton.Visible = false;
            this.PixelResolutionTxt.Lines = new string[0];
            this.PixelResolutionTxt.Location = new System.Drawing.Point(126, 565);
            this.PixelResolutionTxt.MaxLength = 32767;
            this.PixelResolutionTxt.Name = "PixelResolutionTxt";
            this.PixelResolutionTxt.PasswordChar = '\0';
            this.PixelResolutionTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PixelResolutionTxt.SelectedText = "";
            this.PixelResolutionTxt.SelectionLength = 0;
            this.PixelResolutionTxt.SelectionStart = 0;
            this.PixelResolutionTxt.ShortcutsEnabled = true;
            this.PixelResolutionTxt.Size = new System.Drawing.Size(88, 23);
            this.PixelResolutionTxt.TabIndex = 19;
            this.PixelResolutionTxt.UseSelectable = true;
            this.PixelResolutionTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PixelResolutionTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SelectCaptureDeviceLabel
            // 
            this.SelectCaptureDeviceLabel.AutoSize = true;
            this.SelectCaptureDeviceLabel.Location = new System.Drawing.Point(12, 29);
            this.SelectCaptureDeviceLabel.Name = "SelectCaptureDeviceLabel";
            this.SelectCaptureDeviceLabel.Size = new System.Drawing.Size(136, 19);
            this.SelectCaptureDeviceLabel.TabIndex = 18;
            this.SelectCaptureDeviceLabel.Text = "Select Capture Device";
            // 
            // CameraFpsLabel
            // 
            this.CameraFpsLabel.AutoSize = true;
            this.CameraFpsLabel.Location = new System.Drawing.Point(12, 152);
            this.CameraFpsLabel.Name = "CameraFpsLabel";
            this.CameraFpsLabel.Size = new System.Drawing.Size(123, 19);
            this.CameraFpsLabel.TabIndex = 17;
            this.CameraFpsLabel.Text = "Camera FPS Value :";
            // 
            // SensorSizeHeightLabel
            // 
            this.SensorSizeHeightLabel.AutoSize = true;
            this.SensorSizeHeightLabel.Location = new System.Drawing.Point(12, 123);
            this.SensorSizeHeightLabel.Name = "SensorSizeHeightLabel";
            this.SensorSizeHeightLabel.Size = new System.Drawing.Size(124, 19);
            this.SensorSizeHeightLabel.TabIndex = 16;
            this.SensorSizeHeightLabel.Text = "Sensor Size Height :";
            // 
            // SensorSizeWidthLabel
            // 
            this.SensorSizeWidthLabel.AutoSize = true;
            this.SensorSizeWidthLabel.Location = new System.Drawing.Point(12, 94);
            this.SensorSizeWidthLabel.Name = "SensorSizeWidthLabel";
            this.SensorSizeWidthLabel.Size = new System.Drawing.Size(121, 19);
            this.SensorSizeWidthLabel.TabIndex = 15;
            this.SensorSizeWidthLabel.Text = "Sensor Size Width :";
            // 
            // CameraFpsTxt
            // 
            // 
            // 
            // 
            this.CameraFpsTxt.CustomButton.Image = null;
            this.CameraFpsTxt.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.CameraFpsTxt.CustomButton.Name = "";
            this.CameraFpsTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CameraFpsTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CameraFpsTxt.CustomButton.TabIndex = 1;
            this.CameraFpsTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CameraFpsTxt.CustomButton.UseSelectable = true;
            this.CameraFpsTxt.CustomButton.Visible = false;
            this.CameraFpsTxt.Lines = new string[0];
            this.CameraFpsTxt.Location = new System.Drawing.Point(139, 148);
            this.CameraFpsTxt.MaxLength = 32767;
            this.CameraFpsTxt.Name = "CameraFpsTxt";
            this.CameraFpsTxt.PasswordChar = '\0';
            this.CameraFpsTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CameraFpsTxt.SelectedText = "";
            this.CameraFpsTxt.SelectionLength = 0;
            this.CameraFpsTxt.SelectionStart = 0;
            this.CameraFpsTxt.ShortcutsEnabled = true;
            this.CameraFpsTxt.Size = new System.Drawing.Size(75, 23);
            this.CameraFpsTxt.TabIndex = 11;
            this.CameraFpsTxt.UseSelectable = true;
            this.CameraFpsTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CameraFpsTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SensorSizeHeightTxt
            // 
            // 
            // 
            // 
            this.SensorSizeHeightTxt.CustomButton.Image = null;
            this.SensorSizeHeightTxt.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.SensorSizeHeightTxt.CustomButton.Name = "";
            this.SensorSizeHeightTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SensorSizeHeightTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SensorSizeHeightTxt.CustomButton.TabIndex = 1;
            this.SensorSizeHeightTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SensorSizeHeightTxt.CustomButton.UseSelectable = true;
            this.SensorSizeHeightTxt.CustomButton.Visible = false;
            this.SensorSizeHeightTxt.Lines = new string[0];
            this.SensorSizeHeightTxt.Location = new System.Drawing.Point(139, 119);
            this.SensorSizeHeightTxt.MaxLength = 32767;
            this.SensorSizeHeightTxt.Name = "SensorSizeHeightTxt";
            this.SensorSizeHeightTxt.PasswordChar = '\0';
            this.SensorSizeHeightTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SensorSizeHeightTxt.SelectedText = "";
            this.SensorSizeHeightTxt.SelectionLength = 0;
            this.SensorSizeHeightTxt.SelectionStart = 0;
            this.SensorSizeHeightTxt.ShortcutsEnabled = true;
            this.SensorSizeHeightTxt.Size = new System.Drawing.Size(75, 23);
            this.SensorSizeHeightTxt.TabIndex = 10;
            this.SensorSizeHeightTxt.UseSelectable = true;
            this.SensorSizeHeightTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SensorSizeHeightTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SensorSizeWidthTxt
            // 
            // 
            // 
            // 
            this.SensorSizeWidthTxt.CustomButton.Image = null;
            this.SensorSizeWidthTxt.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.SensorSizeWidthTxt.CustomButton.Name = "";
            this.SensorSizeWidthTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SensorSizeWidthTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SensorSizeWidthTxt.CustomButton.TabIndex = 1;
            this.SensorSizeWidthTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SensorSizeWidthTxt.CustomButton.UseSelectable = true;
            this.SensorSizeWidthTxt.CustomButton.Visible = false;
            this.SensorSizeWidthTxt.Lines = new string[0];
            this.SensorSizeWidthTxt.Location = new System.Drawing.Point(139, 90);
            this.SensorSizeWidthTxt.MaxLength = 32767;
            this.SensorSizeWidthTxt.Name = "SensorSizeWidthTxt";
            this.SensorSizeWidthTxt.PasswordChar = '\0';
            this.SensorSizeWidthTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SensorSizeWidthTxt.SelectedText = "";
            this.SensorSizeWidthTxt.SelectionLength = 0;
            this.SensorSizeWidthTxt.SelectionStart = 0;
            this.SensorSizeWidthTxt.ShortcutsEnabled = true;
            this.SensorSizeWidthTxt.Size = new System.Drawing.Size(75, 23);
            this.SensorSizeWidthTxt.TabIndex = 9;
            this.SensorSizeWidthTxt.UseSelectable = true;
            this.SensorSizeWidthTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SensorSizeWidthTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StartMonitoringButton
            // 
            this.StartMonitoringButton.Location = new System.Drawing.Point(12, 177);
            this.StartMonitoringButton.Name = "StartMonitoringButton";
            this.StartMonitoringButton.Size = new System.Drawing.Size(202, 33);
            this.StartMonitoringButton.TabIndex = 8;
            this.StartMonitoringButton.Text = "Start Monitoring";
            this.StartMonitoringButton.UseVisualStyleBackColor = true;
            this.StartMonitoringButton.Click += new System.EventHandler(this.StartMonitoringButton_Click);
            // 
            // CaptureDevicesCombobox
            // 
            this.CaptureDevicesCombobox.FormattingEnabled = true;
            this.CaptureDevicesCombobox.ItemHeight = 23;
            this.CaptureDevicesCombobox.Location = new System.Drawing.Point(12, 51);
            this.CaptureDevicesCombobox.Name = "CaptureDevicesCombobox";
            this.CaptureDevicesCombobox.Size = new System.Drawing.Size(202, 29);
            this.CaptureDevicesCombobox.TabIndex = 7;
            this.CaptureDevicesCombobox.UseSelectable = true;
            // 
            // VideoRecordStopButton
            // 
            this.VideoRecordStopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VideoRecordStopButton.BackgroundImage")));
            this.VideoRecordStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VideoRecordStopButton.Location = new System.Drawing.Point(154, 421);
            this.VideoRecordStopButton.Name = "VideoRecordStopButton";
            this.VideoRecordStopButton.Size = new System.Drawing.Size(60, 50);
            this.VideoRecordStopButton.TabIndex = 6;
            this.VideoRecordStopButton.UseSelectable = true;
            this.VideoRecordStopButton.Click += new System.EventHandler(this.VideoRecordStopButton_Click);
            // 
            // VideoRecordStartButton
            // 
            this.VideoRecordStartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VideoRecordStartButton.BackgroundImage")));
            this.VideoRecordStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VideoRecordStartButton.Location = new System.Drawing.Point(88, 421);
            this.VideoRecordStartButton.Name = "VideoRecordStartButton";
            this.VideoRecordStartButton.Size = new System.Drawing.Size(60, 50);
            this.VideoRecordStartButton.TabIndex = 6;
            this.VideoRecordStartButton.UseSelectable = true;
            this.VideoRecordStartButton.Click += new System.EventHandler(this.VideoRecordStartButton_Click);
            // 
            // TakeSnapshotButton
            // 
            this.TakeSnapshotButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TakeSnapshotButton.BackgroundImage")));
            this.TakeSnapshotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TakeSnapshotButton.Location = new System.Drawing.Point(22, 421);
            this.TakeSnapshotButton.Name = "TakeSnapshotButton";
            this.TakeSnapshotButton.Size = new System.Drawing.Size(60, 50);
            this.TakeSnapshotButton.TabIndex = 5;
            this.TakeSnapshotButton.UseSelectable = true;
            this.TakeSnapshotButton.Click += new System.EventHandler(this.TakeSnapshotButton_Click);
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ZoomInButton.BackgroundImage")));
            this.ZoomInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZoomInButton.Location = new System.Drawing.Point(93, 243);
            this.ZoomInButton.Name = "ZoomInButton";
            this.ZoomInButton.Size = new System.Drawing.Size(55, 45);
            this.ZoomInButton.TabIndex = 1;
            this.ZoomInButton.UseSelectable = true;
            this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // FocusDecreaseButton
            // 
            this.FocusDecreaseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FocusDecreaseButton.BackgroundImage")));
            this.FocusDecreaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FocusDecreaseButton.Location = new System.Drawing.Point(31, 294);
            this.FocusDecreaseButton.Name = "FocusDecreaseButton";
            this.FocusDecreaseButton.Size = new System.Drawing.Size(55, 45);
            this.FocusDecreaseButton.TabIndex = 4;
            this.FocusDecreaseButton.UseSelectable = true;
            this.FocusDecreaseButton.Click += new System.EventHandler(this.FocusDecreaseButton_Click);
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ZoomOutButton.BackgroundImage")));
            this.ZoomOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZoomOutButton.Location = new System.Drawing.Point(93, 345);
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.ZoomOutButton.Size = new System.Drawing.Size(55, 45);
            this.ZoomOutButton.TabIndex = 2;
            this.ZoomOutButton.UseSelectable = true;
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // FocusIncreaseButton
            // 
            this.FocusIncreaseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FocusIncreaseButton.BackgroundImage")));
            this.FocusIncreaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FocusIncreaseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.FocusIncreaseButton.Location = new System.Drawing.Point(154, 294);
            this.FocusIncreaseButton.Name = "FocusIncreaseButton";
            this.FocusIncreaseButton.Size = new System.Drawing.Size(55, 45);
            this.FocusIncreaseButton.TabIndex = 3;
            this.FocusIncreaseButton.UseSelectable = true;
            this.FocusIncreaseButton.Click += new System.EventHandler(this.FocusIncreaseButton_Click);
            // 
            // Display
            // 
            this.Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Display.ErrorImage = null;
            this.Display.Location = new System.Drawing.Point(27, 28);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(88, 70);
            this.Display.TabIndex = 7;
            this.Display.TabStop = false;
            this.Display.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Paint);
            this.Display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Display_MouseDown);
            this.Display.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Display_MouseMove);
            this.Display.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Display_MouseUp);
            // 
            // ContainerDisplayPanel
            // 
            this.ContainerDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContainerDisplayPanel.Controls.Add(this.Display);
            this.ContainerDisplayPanel.Location = new System.Drawing.Point(25, 65);
            this.ContainerDisplayPanel.Name = "ContainerDisplayPanel";
            this.ContainerDisplayPanel.Size = new System.Drawing.Size(143, 224);
            this.ContainerDisplayPanel.TabIndex = 14;
            // 
            // DigitalMicroscopeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 841);
            this.Controls.Add(this.ContainerDisplayPanel);
            this.Controls.Add(this.ControlPanel);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "DigitalMicroscopeForm";
            this.Resizable = false;
            this.Text = "DigitalMicroscope";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DigitalMicroscopeForm_FormClosed);
            this.Load += new System.EventHandler(this.DigitalMicroscopeForm_Load);
            this.Resize += new System.EventHandler(this.DigitalMicroscopeForm_Resize);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ContainerDisplayPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ControlPanel;
        private MetroFramework.Controls.MetroButton VideoRecordStopButton;
        private MetroFramework.Controls.MetroButton VideoRecordStartButton;
        private MetroFramework.Controls.MetroButton TakeSnapshotButton;
        private MetroFramework.Controls.MetroButton ZoomInButton;
        private MetroFramework.Controls.MetroButton FocusDecreaseButton;
        private MetroFramework.Controls.MetroButton ZoomOutButton;
        private MetroFramework.Controls.MetroButton FocusIncreaseButton;
        private System.Windows.Forms.PictureBox Display;
        private MetroFramework.Controls.MetroComboBox CaptureDevicesCombobox;
        private MetroFramework.Controls.MetroLabel CameraFpsLabel;
        private MetroFramework.Controls.MetroLabel SensorSizeHeightLabel;
        private MetroFramework.Controls.MetroLabel SensorSizeWidthLabel;
        private MetroFramework.Controls.MetroTextBox CameraFpsTxt;
        private MetroFramework.Controls.MetroTextBox SensorSizeHeightTxt;
        private MetroFramework.Controls.MetroTextBox SensorSizeWidthTxt;
        private System.Windows.Forms.Button StartMonitoringButton;
        private MetroFramework.Controls.MetroLabel SelectCaptureDeviceLabel;
        private MetroFramework.Controls.MetroLabel PixelResolutionLabel;
        private MetroFramework.Controls.MetroTextBox PixelResolutionTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox MeasureTypesCombobox;
        private System.Windows.Forms.Button MeasureButton;
        private System.Windows.Forms.Panel ContainerDisplayPanel;
        private MetroFramework.Controls.MetroLabel VideoRecordInfoLabel;
    }
}