namespace TestSQL
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeClick = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.RegistrBuuton = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UserSerNameBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.UserSerNameBox);
            this.panel1.Controls.Add(this.UserNameBox);
            this.panel1.Controls.Add(this.RegistrBuuton);
            this.panel1.Controls.Add(this.checkPass);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 310);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPass.Location = new System.Drawing.Point(414, 244);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(117, 17);
            this.checkPass.TabIndex = 4;
            this.checkPass.Text = "Показать пароль";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.passwordBox.Location = new System.Drawing.Point(329, 203);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(202, 30);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.closeClick);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 100);
            this.panel2.TabIndex = 0;
            // 
            // closeClick
            // 
            this.closeClick.AutoSize = true;
            this.closeClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeClick.Location = new System.Drawing.Point(506, 9);
            this.closeClick.Name = "closeClick";
            this.closeClick.Size = new System.Drawing.Size(25, 24);
            this.closeClick.TabIndex = 3;
            this.closeClick.Text = "X";
            this.closeClick.Click += new System.EventHandler(this.closeClick_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.loginBox.Location = new System.Drawing.Point(54, 197);
            this.loginBox.Multiline = true;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(202, 36);
            this.loginBox.TabIndex = 0;
            // 
            // RegistrBuuton
            // 
            this.RegistrBuuton.AutoSize = true;
            this.RegistrBuuton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrBuuton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrBuuton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.RegistrBuuton.ForeColor = System.Drawing.SystemColors.Menu;
            this.RegistrBuuton.Location = new System.Drawing.Point(184, 269);
            this.RegistrBuuton.Name = "RegistrBuuton";
            this.RegistrBuuton.Size = new System.Drawing.Size(191, 23);
            this.RegistrBuuton.TabIndex = 5;
            this.RegistrBuuton.Text = "Зарегистрироваться";
            this.RegistrBuuton.Click += new System.EventHandler(this.RegistrBuuton_Click);
            this.RegistrBuuton.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.RegistrBuuton.MouseLeave += new System.EventHandler(this.RegistrBuuton_MouseLeave);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.UserNameBox.Location = new System.Drawing.Point(54, 144);
            this.UserNameBox.Multiline = true;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(202, 36);
            this.UserNameBox.TabIndex = 6;
            this.UserNameBox.Enter += new System.EventHandler(this.UserNameBox_Enter);
            this.UserNameBox.Leave += new System.EventHandler(this.UserNameBox_Leave);
            // 
            // UserSerNameBox
            // 
            this.UserSerNameBox.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.UserSerNameBox.Location = new System.Drawing.Point(329, 144);
            this.UserSerNameBox.Multiline = true;
            this.UserSerNameBox.Name = "UserSerNameBox";
            this.UserSerNameBox.Size = new System.Drawing.Size(202, 36);
            this.UserSerNameBox.TabIndex = 7;
            this.UserSerNameBox.Enter += new System.EventHandler(this.UserSerNameBox_Enter);
            this.UserSerNameBox.Leave += new System.EventHandler(this.UserSerNameBox_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestSQL.Properties.Resources._299105_lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(287, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestSQL.Properties.Resources._628290_avatar_male_man_mature_old_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 310);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox UserSerNameBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label RegistrBuuton;
    }
}