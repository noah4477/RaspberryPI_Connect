using HardwareMixerObj;
namespace RPI
{
    partial class Form1
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
        /// 
        
        private void InitializeComponent()
        {
            this.DefaultDeviceVolume = new System.Windows.Forms.TrackBar();
            this.Program1Volume = new System.Windows.Forms.TrackBar();
            this.Program3Volume = new System.Windows.Forms.TrackBar();
            this.DefaultDevice = new System.Windows.Forms.Label();
            this.Program1 = new System.Windows.Forms.Label();
            this.Program2 = new System.Windows.Forms.Label();
            this.Program3 = new System.Windows.Forms.Label();
            this.Program2MuteEnabled = new System.Windows.Forms.Button();
            this.Program3MuteEnabled = new System.Windows.Forms.Button();
            this.MainMuteDisabled = new System.Windows.Forms.Button();
            this.Program1MuteEnabled = new System.Windows.Forms.Button();
            this.MainMuteEnabled = new System.Windows.Forms.Button();
            this.Program3Icon = new System.Windows.Forms.PictureBox();
            this.Program2Icon = new System.Windows.Forms.PictureBox();
            this.Program1Icon = new System.Windows.Forms.PictureBox();
            this.DefaultSoundIcon = new System.Windows.Forms.PictureBox();
            this.Program1MuteDisabled = new System.Windows.Forms.Button();
            this.Program2MuteDisabled = new System.Windows.Forms.Button();
            this.Program3MuteDisabled = new System.Windows.Forms.Button();
            this.Program2Volume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultDeviceVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program1Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program3Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program3Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program2Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program1Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultSoundIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program2Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // DefaultDeviceVolume
            // 
            this.DefaultDeviceVolume.AllowDrop = true;
            this.DefaultDeviceVolume.Enabled = false;
            this.DefaultDeviceVolume.LargeChange = 10;
            this.DefaultDeviceVolume.Location = new System.Drawing.Point(48, 121);
            this.DefaultDeviceVolume.Maximum = 100;
            this.DefaultDeviceVolume.Name = "DefaultDeviceVolume";
            this.DefaultDeviceVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.DefaultDeviceVolume.Size = new System.Drawing.Size(45, 115);
            this.DefaultDeviceVolume.SmallChange = 10;
            this.DefaultDeviceVolume.TabIndex = 10;
            this.DefaultDeviceVolume.TabStop = false;
            this.DefaultDeviceVolume.TickFrequency = 10;
            // 
            // Program1Volume
            // 
            this.Program1Volume.Enabled = false;
            this.Program1Volume.LargeChange = 10;
            this.Program1Volume.Location = new System.Drawing.Point(155, 121);
            this.Program1Volume.Maximum = 100;
            this.Program1Volume.Name = "Program1Volume";
            this.Program1Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Program1Volume.Size = new System.Drawing.Size(45, 115);
            this.Program1Volume.SmallChange = 10;
            this.Program1Volume.TabIndex = 7;
            this.Program1Volume.TickFrequency = 10;
            // 
            // Program3Volume
            // 
            this.Program3Volume.Enabled = false;
            this.Program3Volume.LargeChange = 10;
            this.Program3Volume.Location = new System.Drawing.Point(378, 121);
            this.Program3Volume.Maximum = 100;
            this.Program3Volume.Name = "Program3Volume";
            this.Program3Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Program3Volume.Size = new System.Drawing.Size(45, 115);
            this.Program3Volume.SmallChange = 10;
            this.Program3Volume.TabIndex = 9;
            this.Program3Volume.TickFrequency = 10;
            // 
            // DefaultDevice
            // 
            this.DefaultDevice.AutoSize = true;
            this.DefaultDevice.Location = new System.Drawing.Point(45, 79);
            this.DefaultDevice.MaximumSize = new System.Drawing.Size(48, 0);
            this.DefaultDevice.Name = "DefaultDevice";
            this.DefaultDevice.Size = new System.Drawing.Size(44, 39);
            this.DefaultDevice.TabIndex = 11;
            this.DefaultDevice.Text = "Realtek Digital Output";
            this.DefaultDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Program1
            // 
            this.Program1.AutoSize = true;
            this.Program1.Location = new System.Drawing.Point(156, 79);
            this.Program1.MaximumSize = new System.Drawing.Size(48, 0);
            this.Program1.Name = "Program1";
            this.Program1.Size = new System.Drawing.Size(44, 39);
            this.Program1.TabIndex = 12;
            this.Program1.Text = "Realtek Digital Output";
            this.Program1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Program2
            // 
            this.Program2.AutoSize = true;
            this.Program2.Location = new System.Drawing.Point(269, 79);
            this.Program2.MaximumSize = new System.Drawing.Size(48, 0);
            this.Program2.Name = "Program2";
            this.Program2.Size = new System.Drawing.Size(44, 39);
            this.Program2.TabIndex = 13;
            this.Program2.Text = "Realtek Digital Output";
            this.Program2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Program3
            // 
            this.Program3.AutoSize = true;
            this.Program3.Location = new System.Drawing.Point(379, 79);
            this.Program3.MaximumSize = new System.Drawing.Size(48, 0);
            this.Program3.Name = "Program3";
            this.Program3.Size = new System.Drawing.Size(44, 39);
            this.Program3.TabIndex = 14;
            this.Program3.Text = "Realtek Digital Output";
            this.Program3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Program2MuteEnabled
            // 
            this.Program2MuteEnabled.Image = global::RPI.Properties.Resources.Mute;
            this.Program2MuteEnabled.Location = new System.Drawing.Point(267, 243);
            this.Program2MuteEnabled.Name = "Program2MuteEnabled";
            this.Program2MuteEnabled.Size = new System.Drawing.Size(32, 32);
            this.Program2MuteEnabled.TabIndex = 17;
            this.Program2MuteEnabled.UseVisualStyleBackColor = true;
            // 
            // Program3MuteEnabled
            // 
            this.Program3MuteEnabled.Image = global::RPI.Properties.Resources.Mute;
            this.Program3MuteEnabled.Location = new System.Drawing.Point(378, 243);
            this.Program3MuteEnabled.Name = "Program3MuteEnabled";
            this.Program3MuteEnabled.Size = new System.Drawing.Size(32, 32);
            this.Program3MuteEnabled.TabIndex = 18;
            this.Program3MuteEnabled.UseVisualStyleBackColor = true;
            // 
            // MainMuteDisabled
            // 
            this.MainMuteDisabled.Enabled = false;
            this.MainMuteDisabled.Image = global::RPI.Properties.Resources.Muted;
            this.MainMuteDisabled.Location = new System.Drawing.Point(48, 243);
            this.MainMuteDisabled.Name = "MainMuteDisabled";
            this.MainMuteDisabled.Size = new System.Drawing.Size(32, 32);
            this.MainMuteDisabled.TabIndex = 19;
            this.MainMuteDisabled.UseVisualStyleBackColor = true;
            this.MainMuteDisabled.Visible = false;
            // 
            // Program1MuteEnabled
            // 
            this.Program1MuteEnabled.Image = global::RPI.Properties.Resources.Mute;
            this.Program1MuteEnabled.Location = new System.Drawing.Point(155, 243);
            this.Program1MuteEnabled.Name = "Program1MuteEnabled";
            this.Program1MuteEnabled.Size = new System.Drawing.Size(32, 32);
            this.Program1MuteEnabled.TabIndex = 16;
            this.Program1MuteEnabled.UseVisualStyleBackColor = true;
            // 
            // MainMuteEnabled
            // 
            this.MainMuteEnabled.Image = global::RPI.Properties.Resources.Mute;
            this.MainMuteEnabled.Location = new System.Drawing.Point(48, 243);
            this.MainMuteEnabled.Name = "MainMuteEnabled";
            this.MainMuteEnabled.Size = new System.Drawing.Size(32, 32);
            this.MainMuteEnabled.TabIndex = 15;
            this.MainMuteEnabled.UseVisualStyleBackColor = true;
            this.MainMuteEnabled.Click += new System.EventHandler(this.button1_Click);
            // 
            // Program3Icon
            // 
            this.Program3Icon.BackColor = System.Drawing.Color.Transparent;
            this.Program3Icon.InitialImage = null;
            this.Program3Icon.Location = new System.Drawing.Point(375, 25);
            this.Program3Icon.Margin = new System.Windows.Forms.Padding(32);
            this.Program3Icon.MaximumSize = new System.Drawing.Size(48, 48);
            this.Program3Icon.MinimumSize = new System.Drawing.Size(48, 48);
            this.Program3Icon.Name = "Program3Icon";
            this.Program3Icon.Size = new System.Drawing.Size(48, 48);
            this.Program3Icon.TabIndex = 4;
            this.Program3Icon.TabStop = false;
            // 
            // Program2Icon
            // 
            this.Program2Icon.BackColor = System.Drawing.Color.Transparent;
            this.Program2Icon.Location = new System.Drawing.Point(264, 25);
            this.Program2Icon.Name = "Program2Icon";
            this.Program2Icon.Size = new System.Drawing.Size(48, 48);
            this.Program2Icon.TabIndex = 3;
            this.Program2Icon.TabStop = false;
            // 
            // Program1Icon
            // 
            this.Program1Icon.BackColor = System.Drawing.Color.Transparent;
            this.Program1Icon.Location = new System.Drawing.Point(152, 25);
            this.Program1Icon.Margin = new System.Windows.Forms.Padding(52);
            this.Program1Icon.Name = "Program1Icon";
            this.Program1Icon.Size = new System.Drawing.Size(48, 48);
            this.Program1Icon.TabIndex = 2;
            this.Program1Icon.TabStop = false;
            // 
            // DefaultSoundIcon
            // 
            this.DefaultSoundIcon.BackColor = System.Drawing.Color.Transparent;
            this.DefaultSoundIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DefaultSoundIcon.Image = global::RPI.Properties.Resources.MainVolumeIcon;
            this.DefaultSoundIcon.Location = new System.Drawing.Point(41, 25);
            this.DefaultSoundIcon.Margin = new System.Windows.Forms.Padding(32);
            this.DefaultSoundIcon.Name = "DefaultSoundIcon";
            this.DefaultSoundIcon.Size = new System.Drawing.Size(48, 48);
            this.DefaultSoundIcon.TabIndex = 1;
            this.DefaultSoundIcon.TabStop = false;
            // 
            // Program1MuteDisabled
            // 
            this.Program1MuteDisabled.Image = global::RPI.Properties.Resources.Muted;
            this.Program1MuteDisabled.Location = new System.Drawing.Point(155, 243);
            this.Program1MuteDisabled.Name = "Program1MuteDisabled";
            this.Program1MuteDisabled.Size = new System.Drawing.Size(32, 32);
            this.Program1MuteDisabled.TabIndex = 20;
            this.Program1MuteDisabled.UseVisualStyleBackColor = true;
            // 
            // Program2MuteDisabled
            // 
            this.Program2MuteDisabled.Image = global::RPI.Properties.Resources.Muted;
            this.Program2MuteDisabled.Location = new System.Drawing.Point(267, 243);
            this.Program2MuteDisabled.Name = "Program2MuteDisabled";
            this.Program2MuteDisabled.Size = new System.Drawing.Size(32, 32);
            this.Program2MuteDisabled.TabIndex = 21;
            this.Program2MuteDisabled.UseVisualStyleBackColor = true;
            // 
            // Program3MuteDisabled
            // 
            this.Program3MuteDisabled.Image = global::RPI.Properties.Resources.Muted;
            this.Program3MuteDisabled.Location = new System.Drawing.Point(378, 243);
            this.Program3MuteDisabled.Name = "Program3MuteDisabled";
            this.Program3MuteDisabled.Size = new System.Drawing.Size(32, 32);
            this.Program3MuteDisabled.TabIndex = 22;
            this.Program3MuteDisabled.UseVisualStyleBackColor = true;
            // 
            // Program2Volume
            // 
            this.Program2Volume.Enabled = false;
            this.Program2Volume.LargeChange = 10;
            this.Program2Volume.Location = new System.Drawing.Point(268, 121);
            this.Program2Volume.Maximum = 100;
            this.Program2Volume.Name = "Program2Volume";
            this.Program2Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Program2Volume.Size = new System.Drawing.Size(45, 115);
            this.Program2Volume.SmallChange = 10;
            this.Program2Volume.TabIndex = 23;
            this.Program2Volume.TickFrequency = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.Program2Volume);
            this.Controls.Add(this.Program3MuteDisabled);
            this.Controls.Add(this.Program2MuteDisabled);
            this.Controls.Add(this.Program1MuteDisabled);
            this.Controls.Add(this.MainMuteDisabled);
            this.Controls.Add(this.Program3MuteEnabled);
            this.Controls.Add(this.Program2MuteEnabled);
            this.Controls.Add(this.Program1MuteEnabled);
            this.Controls.Add(this.MainMuteEnabled);
            this.Controls.Add(this.Program3);
            this.Controls.Add(this.Program2);
            this.Controls.Add(this.Program1);
            this.Controls.Add(this.DefaultDevice);
            this.Controls.Add(this.Program3Volume);
            this.Controls.Add(this.Program1Volume);
            this.Controls.Add(this.DefaultDeviceVolume);
            this.Controls.Add(this.Program3Icon);
            this.Controls.Add(this.Program2Icon);
            this.Controls.Add(this.Program1Icon);
            this.Controls.Add(this.DefaultSoundIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DefaultDeviceVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program1Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program3Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program3Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program2Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program1Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultSoundIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Program2Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DefaultSoundIcon;
        private System.Windows.Forms.PictureBox Program1Icon;
        private System.Windows.Forms.PictureBox Program2Icon;
        private System.Windows.Forms.PictureBox Program3Icon;
        private System.Windows.Forms.TrackBar DefaultDeviceVolume;
        private System.Windows.Forms.TrackBar Program1Volume;
        private System.Windows.Forms.TrackBar Program3Volume;
        private System.Windows.Forms.Label Program1;
        private System.Windows.Forms.Label Program2;
        private System.Windows.Forms.Label Program3;
        private System.Windows.Forms.Button MainMuteEnabled;
        private System.Windows.Forms.Button Program1MuteEnabled;
        private System.Windows.Forms.Button Program2MuteEnabled;
        private System.Windows.Forms.Button Program3MuteEnabled;
        private System.Windows.Forms.Label DefaultDevice;
        private System.Windows.Forms.Button MainMuteDisabled;
        private System.Windows.Forms.Button Program1MuteDisabled;
        private System.Windows.Forms.Button Program2MuteDisabled;
        private System.Windows.Forms.Button Program3MuteDisabled;
        private System.Windows.Forms.TrackBar Program2Volume;
    }
}