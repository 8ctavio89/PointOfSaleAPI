
namespace PoS
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.lbl_username = new System.Windows.Forms.Label();
			this.lbl_password = new System.Windows.Forms.Label();
			this.txt_username = new System.Windows.Forms.TextBox();
			this.txt_password = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_username
			// 
			this.lbl_username.AutoSize = true;
			this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_username.Location = new System.Drawing.Point(34, 45);
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(197, 30);
			this.lbl_username.TabIndex = 0;
			this.lbl_username.Text = "Nombre de usuario:";
			// 
			// lbl_password
			// 
			this.lbl_password.AutoSize = true;
			this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_password.Location = new System.Drawing.Point(34, 105);
			this.lbl_password.Name = "lbl_password";
			this.lbl_password.Size = new System.Drawing.Size(123, 30);
			this.lbl_password.TabIndex = 1;
			this.lbl_password.Text = "Contraseña:";
			// 
			// txt_username
			// 
			this.txt_username.Location = new System.Drawing.Point(237, 54);
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(183, 23);
			this.txt_username.TabIndex = 2;
			// 
			// txt_password
			// 
			this.txt_password.Location = new System.Drawing.Point(237, 114);
			this.txt_password.Name = "txt_password";
			this.txt_password.PasswordChar = '•';
			this.txt_password.Size = new System.Drawing.Size(183, 23);
			this.txt_password.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(252, 186);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Log In";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(-6, 149);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(261, 107);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
			this.ClientSize = new System.Drawing.Size(505, 268);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_password);
			this.Controls.Add(this.txt_username);
			this.Controls.Add(this.lbl_password);
			this.Controls.Add(this.lbl_username);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Super del Sur - Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

