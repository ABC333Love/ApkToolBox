namespace AutoAPKTool
{
    partial class AppInfoUI
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
            this.icon = new System.Windows.Forms.PictureBox();
            this.AppNameBox = new System.Windows.Forms.TextBox();
            this.AppVersionBox = new System.Windows.Forms.TextBox();
            this.SignHashMd5Box = new System.Windows.Forms.TextBox();
            this.SignHashBox = new System.Windows.Forms.TextBox();
            this.AppPkgNameBox = new System.Windows.Forms.TextBox();
            this.SignCharStringBox = new System.Windows.Forms.TextBox();
            this.SignByteArrayBox = new System.Windows.Forms.TextBox();
            this.appName = new System.Windows.Forms.Label();
            this.AppPkgLable = new System.Windows.Forms.Label();
            this.AppVersionLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PermissionLabel = new System.Windows.Forms.Label();
            this.PermissionsList = new System.Windows.Forms.TextBox();
            this.AppSignLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(30, 15);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(100, 100);
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // AppNameBox
            // 
            this.AppNameBox.BackColor = System.Drawing.Color.White;
            this.AppNameBox.Location = new System.Drawing.Point(213, 28);
            this.AppNameBox.Name = "AppNameBox";
            this.AppNameBox.ReadOnly = true;
            this.AppNameBox.Size = new System.Drawing.Size(161, 21);
            this.AppNameBox.TabIndex = 1;
            // 
            // AppVersionBox
            // 
            this.AppVersionBox.BackColor = System.Drawing.Color.White;
            this.AppVersionBox.Location = new System.Drawing.Point(213, 69);
            this.AppVersionBox.Name = "AppVersionBox";
            this.AppVersionBox.ReadOnly = true;
            this.AppVersionBox.Size = new System.Drawing.Size(161, 21);
            this.AppVersionBox.TabIndex = 2;
            // 
            // SignHashMd5Box
            // 
            this.SignHashMd5Box.BackColor = System.Drawing.Color.White;
            this.SignHashMd5Box.Location = new System.Drawing.Point(95, 170);
            this.SignHashMd5Box.Name = "SignHashMd5Box";
            this.SignHashMd5Box.ReadOnly = true;
            this.SignHashMd5Box.Size = new System.Drawing.Size(590, 21);
            this.SignHashMd5Box.TabIndex = 3;
            // 
            // SignHashBox
            // 
            this.SignHashBox.BackColor = System.Drawing.Color.White;
            this.SignHashBox.Location = new System.Drawing.Point(95, 210);
            this.SignHashBox.Name = "SignHashBox";
            this.SignHashBox.ReadOnly = true;
            this.SignHashBox.Size = new System.Drawing.Size(590, 21);
            this.SignHashBox.TabIndex = 4;
            // 
            // AppPkgNameBox
            // 
            this.AppPkgNameBox.BackColor = System.Drawing.Color.White;
            this.AppPkgNameBox.Location = new System.Drawing.Point(463, 28);
            this.AppPkgNameBox.Name = "AppPkgNameBox";
            this.AppPkgNameBox.ReadOnly = true;
            this.AppPkgNameBox.Size = new System.Drawing.Size(221, 21);
            this.AppPkgNameBox.TabIndex = 5;
            // 
            // SignCharStringBox
            // 
            this.SignCharStringBox.BackColor = System.Drawing.Color.White;
            this.SignCharStringBox.Location = new System.Drawing.Point(95, 251);
            this.SignCharStringBox.Name = "SignCharStringBox";
            this.SignCharStringBox.ReadOnly = true;
            this.SignCharStringBox.Size = new System.Drawing.Size(590, 21);
            this.SignCharStringBox.TabIndex = 6;
            // 
            // SignByteArrayBox
            // 
            this.SignByteArrayBox.BackColor = System.Drawing.Color.White;
            this.SignByteArrayBox.Location = new System.Drawing.Point(95, 290);
            this.SignByteArrayBox.Name = "SignByteArrayBox";
            this.SignByteArrayBox.ReadOnly = true;
            this.SignByteArrayBox.Size = new System.Drawing.Size(589, 21);
            this.SignByteArrayBox.TabIndex = 7;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Location = new System.Drawing.Point(148, 31);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(59, 12);
            this.appName.TabIndex = 9;
            this.appName.Text = "App名称：";
            // 
            // AppPkgLable
            // 
            this.AppPkgLable.AutoSize = true;
            this.AppPkgLable.Location = new System.Drawing.Point(389, 31);
            this.AppPkgLable.Name = "AppPkgLable";
            this.AppPkgLable.Size = new System.Drawing.Size(59, 12);
            this.AppPkgLable.TabIndex = 10;
            this.AppPkgLable.Text = "App包名：";
            // 
            // AppVersionLable
            // 
            this.AppVersionLable.AutoSize = true;
            this.AppVersionLable.Location = new System.Drawing.Point(148, 72);
            this.AppVersionLable.Name = "AppVersionLable";
            this.AppVersionLable.Size = new System.Drawing.Size(59, 12);
            this.AppVersionLable.TabIndex = 11;
            this.AppVersionLable.Text = "App版本：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "HashCodeMd5:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "HashCode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "CharString:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "ByteArray:";
            // 
            // PermissionLabel
            // 
            this.PermissionLabel.AutoSize = true;
            this.PermissionLabel.Location = new System.Drawing.Point(18, 331);
            this.PermissionLabel.Name = "PermissionLabel";
            this.PermissionLabel.Size = new System.Drawing.Size(41, 12);
            this.PermissionLabel.TabIndex = 16;
            this.PermissionLabel.Text = "权限：";
            // 
            // PermissionsList
            // 
            this.PermissionsList.BackColor = System.Drawing.Color.White;
            this.PermissionsList.Location = new System.Drawing.Point(95, 331);
            this.PermissionsList.Multiline = true;
            this.PermissionsList.Name = "PermissionsList";
            this.PermissionsList.ReadOnly = true;
            this.PermissionsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PermissionsList.Size = new System.Drawing.Size(590, 224);
            this.PermissionsList.TabIndex = 17;
            // 
            // AppSignLabel
            // 
            this.AppSignLabel.AutoSize = true;
            this.AppSignLabel.Location = new System.Drawing.Point(12, 143);
            this.AppSignLabel.Name = "AppSignLabel";
            this.AppSignLabel.Size = new System.Drawing.Size(59, 12);
            this.AppSignLabel.TabIndex = 18;
            this.AppSignLabel.Text = "App签名：";
            // 
            // AppInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 581);
            this.Controls.Add(this.AppSignLabel);
            this.Controls.Add(this.PermissionsList);
            this.Controls.Add(this.PermissionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppVersionLable);
            this.Controls.Add(this.AppPkgLable);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.SignByteArrayBox);
            this.Controls.Add(this.SignCharStringBox);
            this.Controls.Add(this.AppPkgNameBox);
            this.Controls.Add(this.SignHashBox);
            this.Controls.Add(this.SignHashMd5Box);
            this.Controls.Add(this.AppVersionBox);
            this.Controls.Add(this.AppNameBox);
            this.Controls.Add(this.icon);
            this.MaximumSize = new System.Drawing.Size(776, 620);
            this.MinimumSize = new System.Drawing.Size(776, 620);
            this.Name = "AppInfoUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App信息";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.TextBox AppNameBox;
        private System.Windows.Forms.TextBox AppVersionBox;
        private System.Windows.Forms.TextBox SignHashMd5Box;
        private System.Windows.Forms.TextBox SignHashBox;
        private System.Windows.Forms.TextBox AppPkgNameBox;
        private System.Windows.Forms.TextBox SignCharStringBox;
        private System.Windows.Forms.TextBox SignByteArrayBox;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label AppPkgLable;
        private System.Windows.Forms.Label AppVersionLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PermissionLabel;
        private System.Windows.Forms.TextBox PermissionsList;
        private System.Windows.Forms.Label AppSignLabel;
    }
}