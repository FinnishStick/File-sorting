
namespace Slutprojekt
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RunProgram = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.GroupBoxSettings = new System.Windows.Forms.GroupBox();
            this.GroupBoxDone = new System.Windows.Forms.GroupBox();
            this.LabelTotalImages = new System.Windows.Forms.Label();
            this.LabelFailedImages = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.LabelCompleted = new System.Windows.Forms.Label();
            this.LabelSortByDay = new System.Windows.Forms.Label();
            this.LabelSortByMonth = new System.Windows.Forms.Label();
            this.CheckBoxSortByDay = new System.Windows.Forms.CheckBox();
            this.LabelSortByYear = new System.Windows.Forms.Label();
            this.InfoIcon = new System.Windows.Forms.PictureBox();
            this.CheckBoxSortByMonth = new System.Windows.Forms.CheckBox();
            this.CheckBoxSortByYear = new System.Windows.Forms.CheckBox();
            this.ButtonExtractFile = new System.Windows.Forms.Button();
            this.ButtonSortFile = new System.Windows.Forms.Button();
            this.GroupBoxSettings.SuspendLayout();
            this.GroupBoxDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // RunProgram
            // 
            this.RunProgram.Location = new System.Drawing.Point(631, 365);
            this.RunProgram.Name = "RunProgram";
            this.RunProgram.Size = new System.Drawing.Size(75, 30);
            this.RunProgram.TabIndex = 0;
            this.RunProgram.Text = "Run";
            this.RunProgram.UseVisualStyleBackColor = true;
            this.RunProgram.Click += new System.EventHandler(this.RunProgram_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(631, 329);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(75, 30);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // GroupBoxSettings
            // 
            this.GroupBoxSettings.Controls.Add(this.LabelSortByDay);
            this.GroupBoxSettings.Controls.Add(this.LabelSortByMonth);
            this.GroupBoxSettings.Controls.Add(this.CheckBoxSortByDay);
            this.GroupBoxSettings.Controls.Add(this.LabelSortByYear);
            this.GroupBoxSettings.Controls.Add(this.InfoIcon);
            this.GroupBoxSettings.Controls.Add(this.CheckBoxSortByMonth);
            this.GroupBoxSettings.Controls.Add(this.CheckBoxSortByYear);
            this.GroupBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxSettings.Name = "GroupBoxSettings";
            this.GroupBoxSettings.Size = new System.Drawing.Size(613, 234);
            this.GroupBoxSettings.TabIndex = 1;
            this.GroupBoxSettings.TabStop = false;
            this.GroupBoxSettings.Text = "Settings";
            this.GroupBoxSettings.Visible = false;
            // 
            // GroupBoxDone
            // 
            this.GroupBoxDone.Controls.Add(this.LabelTotalImages);
            this.GroupBoxDone.Controls.Add(this.LabelFailedImages);
            this.GroupBoxDone.Controls.Add(this.ButtonOK);
            this.GroupBoxDone.Controls.Add(this.LabelCompleted);
            this.GroupBoxDone.Location = new System.Drawing.Point(2, 12);
            this.GroupBoxDone.Name = "GroupBoxDone";
            this.GroupBoxDone.Size = new System.Drawing.Size(778, 234);
            this.GroupBoxDone.TabIndex = 5;
            this.GroupBoxDone.TabStop = false;
            this.GroupBoxDone.Text = "Done";
            // 
            // LabelTotalImages
            // 
            this.LabelTotalImages.AutoSize = true;
            this.LabelTotalImages.Location = new System.Drawing.Point(158, 147);
            this.LabelTotalImages.Name = "LabelTotalImages";
            this.LabelTotalImages.Size = new System.Drawing.Size(0, 17);
            this.LabelTotalImages.TabIndex = 7;
            // 
            // LabelFailedImages
            // 
            this.LabelFailedImages.AutoSize = true;
            this.LabelFailedImages.Location = new System.Drawing.Point(158, 126);
            this.LabelFailedImages.Name = "LabelFailedImages";
            this.LabelFailedImages.Size = new System.Drawing.Size(0, 17);
            this.LabelFailedImages.TabIndex = 6;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(662, 190);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelCompleted
            // 
            this.LabelCompleted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCompleted.Location = new System.Drawing.Point(158, 93);
            this.LabelCompleted.Name = "LabelCompleted";
            this.LabelCompleted.Size = new System.Drawing.Size(420, 30);
            this.LabelCompleted.TabIndex = 4;
            this.LabelCompleted.Text = "Your transfer has been completed";
            // 
            // LabelSortByDay
            // 
            this.LabelSortByDay.AutoSize = true;
            this.LabelSortByDay.Location = new System.Drawing.Point(130, 105);
            this.LabelSortByDay.Name = "LabelSortByDay";
            this.LabelSortByDay.Size = new System.Drawing.Size(271, 17);
            this.LabelSortByDay.TabIndex = 17;
            this.LabelSortByDay.Text = "<- Will sort your pictures in folders by Day";
            // 
            // LabelSortByMonth
            // 
            this.LabelSortByMonth.AutoSize = true;
            this.LabelSortByMonth.Location = new System.Drawing.Point(130, 76);
            this.LabelSortByMonth.Name = "LabelSortByMonth";
            this.LabelSortByMonth.Size = new System.Drawing.Size(285, 17);
            this.LabelSortByMonth.TabIndex = 16;
            this.LabelSortByMonth.Text = "<- Will sort your pictures in folders by Month";
            // 
            // CheckBoxSortByDay
            // 
            this.CheckBoxSortByDay.AutoSize = true;
            this.CheckBoxSortByDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxSortByDay.Location = new System.Drawing.Point(6, 104);
            this.CheckBoxSortByDay.Name = "CheckBoxSortByDay";
            this.CheckBoxSortByDay.Size = new System.Drawing.Size(104, 21);
            this.CheckBoxSortByDay.TabIndex = 15;
            this.CheckBoxSortByDay.Text = "Sort by Day";
            this.CheckBoxSortByDay.UseVisualStyleBackColor = true;
            // 
            // LabelSortByYear
            // 
            this.LabelSortByYear.AutoSize = true;
            this.LabelSortByYear.Location = new System.Drawing.Point(130, 49);
            this.LabelSortByYear.Name = "LabelSortByYear";
            this.LabelSortByYear.Size = new System.Drawing.Size(276, 17);
            this.LabelSortByYear.TabIndex = 11;
            this.LabelSortByYear.Text = "<- Will sort your pictures in folders by Year";
            // 
            // InfoIcon
            // 
            this.InfoIcon.Image = ((System.Drawing.Image)(resources.GetObject("InfoIcon.Image")));
            this.InfoIcon.Location = new System.Drawing.Point(577, 190);
            this.InfoIcon.Name = "InfoIcon";
            this.InfoIcon.Size = new System.Drawing.Size(30, 30);
            this.InfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoIcon.TabIndex = 10;
            this.InfoIcon.TabStop = false;
            this.InfoIcon.Click += new System.EventHandler(this.InfoIcon_Click);
            // 
            // CheckBoxSortByMonth
            // 
            this.CheckBoxSortByMonth.AutoSize = true;
            this.CheckBoxSortByMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxSortByMonth.Location = new System.Drawing.Point(6, 75);
            this.CheckBoxSortByMonth.Name = "CheckBoxSortByMonth";
            this.CheckBoxSortByMonth.Size = new System.Drawing.Size(118, 21);
            this.CheckBoxSortByMonth.TabIndex = 9;
            this.CheckBoxSortByMonth.Text = "Sort by Month";
            this.CheckBoxSortByMonth.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSortByYear
            // 
            this.CheckBoxSortByYear.AutoSize = true;
            this.CheckBoxSortByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxSortByYear.Location = new System.Drawing.Point(6, 48);
            this.CheckBoxSortByYear.Name = "CheckBoxSortByYear";
            this.CheckBoxSortByYear.Size = new System.Drawing.Size(109, 21);
            this.CheckBoxSortByYear.TabIndex = 5;
            this.CheckBoxSortByYear.Text = "Sort by Year";
            this.CheckBoxSortByYear.UseVisualStyleBackColor = true;
            // 
            // ButtonExtractFile
            // 
            this.ButtonExtractFile.Location = new System.Drawing.Point(18, 329);
            this.ButtonExtractFile.Name = "ButtonExtractFile";
            this.ButtonExtractFile.Size = new System.Drawing.Size(607, 30);
            this.ButtonExtractFile.TabIndex = 2;
            this.ButtonExtractFile.Text = "Choose the folder you wish to extract your files from.";
            this.ButtonExtractFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExtractFile.UseVisualStyleBackColor = true;
            this.ButtonExtractFile.Click += new System.EventHandler(this.ButtonExtractFile_Click);
            // 
            // ButtonSortFile
            // 
            this.ButtonSortFile.Location = new System.Drawing.Point(18, 365);
            this.ButtonSortFile.Name = "ButtonSortFile";
            this.ButtonSortFile.Size = new System.Drawing.Size(607, 30);
            this.ButtonSortFile.TabIndex = 3;
            this.ButtonSortFile.Text = "Choose your folder you wish to sort to.";
            this.ButtonSortFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSortFile.UseVisualStyleBackColor = true;
            this.ButtonSortFile.Click += new System.EventHandler(this.ButtonSortFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.GroupBoxDone);
            this.Controls.Add(this.ButtonSortFile);
            this.Controls.Add(this.ButtonExtractFile);
            this.Controls.Add(this.GroupBoxSettings);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.RunProgram);
            this.Name = "Form1";
            this.GroupBoxSettings.ResumeLayout(false);
            this.GroupBoxSettings.PerformLayout();
            this.GroupBoxDone.ResumeLayout(false);
            this.GroupBoxDone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunProgram;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.GroupBox GroupBoxSettings;
        private System.Windows.Forms.CheckBox CheckBoxSortByMonth;
        private System.Windows.Forms.CheckBox CheckBoxSortByYear;
        private System.Windows.Forms.PictureBox InfoIcon;
        private System.Windows.Forms.Label LabelSortByYear;
        private System.Windows.Forms.Button ButtonExtractFile;
        private System.Windows.Forms.Button ButtonSortFile;
        private System.Windows.Forms.Label LabelSortByMonth;
        private System.Windows.Forms.CheckBox CheckBoxSortByDay;
        private System.Windows.Forms.Label LabelSortByDay;
        private System.Windows.Forms.Label LabelCompleted;
        private System.Windows.Forms.GroupBox GroupBoxDone;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label LabelFailedImages;
        private System.Windows.Forms.Label LabelTotalImages;
    }
}

