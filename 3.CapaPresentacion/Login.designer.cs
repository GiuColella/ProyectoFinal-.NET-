namespace _3.CapaPresentacion
{
    partial class Login
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
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLinkOlvPass = new System.Windows.Forms.LinkLabel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInvisible = new System.Windows.Forms.PictureBox();
            this.btnVisible = new System.Windows.Forms.PictureBox();
            this.lblLinkUser = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInvisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisible)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(623, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 12;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(644, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(15, 15);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 11;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblLinkOlvPass);
            this.panel3.Controls.Add(this.btnAcceder);
            this.panel3.Location = new System.Drawing.Point(215, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 76);
            this.panel3.TabIndex = 10;
            // 
            // lblLinkOlvPass
            // 
            this.lblLinkOlvPass.AutoSize = true;
            this.lblLinkOlvPass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkOlvPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLinkOlvPass.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLinkOlvPass.Location = new System.Drawing.Point(137, 42);
            this.lblLinkOlvPass.Name = "lblLinkOlvPass";
            this.lblLinkOlvPass.Size = new System.Drawing.Size(168, 18);
            this.lblLinkOlvPass.TabIndex = 1;
            this.lblLinkOlvPass.TabStop = true;
            this.lblLinkOlvPass.Text = "¿Olvidaste tu contraseña?";
            this.lblLinkOlvPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkOlvPass_LinkClicked);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Gray;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.btnAcceder.FlatAppearance.BorderSize = 3;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Location = new System.Drawing.Point(15, 14);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(408, 25);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblErrorMessage);
            this.panel2.Controls.Add(this.btnInvisible);
            this.panel2.Controls.Add(this.btnVisible);
            this.panel2.Controls.Add(this.lblLinkUser);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBoxPass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBoxUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(215, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 174);
            this.panel2.TabIndex = 9;
            // 
            // btnInvisible
            // 
            this.btnInvisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvisible.Image = global::_3.CapaPresentacion.Properties.Resources.eyeVisible;
            this.btnInvisible.Location = new System.Drawing.Point(400, 75);
            this.btnInvisible.Name = "btnInvisible";
            this.btnInvisible.Size = new System.Drawing.Size(23, 26);
            this.btnInvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInvisible.TabIndex = 10;
            this.btnInvisible.TabStop = false;
            this.btnInvisible.Visible = false;
            this.btnInvisible.Click += new System.EventHandler(this.btnInvisible_Click);
            // 
            // btnVisible
            // 
            this.btnVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisible.Image = global::_3.CapaPresentacion.Properties.Resources.eyeInvisible;
            this.btnVisible.Location = new System.Drawing.Point(400, 75);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(23, 26);
            this.btnVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVisible.TabIndex = 9;
            this.btnVisible.TabStop = false;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // lblLinkUser
            // 
            this.lblLinkUser.AutoSize = true;
            this.lblLinkUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLinkUser.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLinkUser.Location = new System.Drawing.Point(170, 131);
            this.lblLinkUser.Name = "lblLinkUser";
            this.lblLinkUser.Size = new System.Drawing.Size(88, 18);
            this.lblLinkUser.TabIndex = 4;
            this.lblLinkUser.TabStop = true;
            this.lblLinkUser.Text = "Crear Cuenta";
            this.lblLinkUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkUser_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(81, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Por favor, presione aqui para crear una Cuenta";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BackColor = System.Drawing.Color.Black;
            this.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxPass.Location = new System.Drawing.Point(15, 75);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(378, 26);
            this.txtBoxPass.TabIndex = 3;
            this.txtBoxPass.Text = "123456";
            this.txtBoxPass.UseSystemPasswordChar = true;
            this.txtBoxPass.Enter += new System.EventHandler(this.txtBoxPass_Enter);
            this.txtBoxPass.Leave += new System.EventHandler(this.txtBoxPass_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contraseña";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BackColor = System.Drawing.Color.Black;
            this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxUser.Location = new System.Drawing.Point(15, 21);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(408, 26);
            this.txtBoxUser.TabIndex = 2;
            this.txtBoxUser.Text = "Username";
            this.txtBoxUser.Enter += new System.EventHandler(this.txtBoxUser_Enter);
            this.txtBoxUser.Leave += new System.EventHandler(this.txtBoxUser_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(375, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Teal;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(200, 315);
            this.panelLogin.TabIndex = 7;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblErrorMessage.Location = new System.Drawing.Point(108, 158);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(29, 13);
            this.lblErrorMessage.TabIndex = 11;
            this.lblErrorMessage.Text = "Error";
            this.lblErrorMessage.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(665, 315);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInvisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisible)).EndInit();
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel lblLinkOlvPass;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnInvisible;
        private System.Windows.Forms.PictureBox btnVisible;
        private System.Windows.Forms.LinkLabel lblLinkUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}