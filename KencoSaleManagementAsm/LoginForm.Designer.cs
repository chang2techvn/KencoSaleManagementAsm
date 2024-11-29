namespace KencoSaleManagementAsm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLoginMain = new System.Windows.Forms.Panel();
            this.lblSignin = new System.Windows.Forms.Label();
            this.lblLoginAskSignin = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.lbLoginName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbLoginEmail = new System.Windows.Forms.TextBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.ptLoginform = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelLoginMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLoginform)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panelLoginMain);
            this.panel1.Location = new System.Drawing.Point(513, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 564);
            this.panel1.TabIndex = 0;
            // 
            // panelLoginMain
            // 
            this.panelLoginMain.BackColor = System.Drawing.Color.White;
            this.panelLoginMain.Controls.Add(this.lblSignin);
            this.panelLoginMain.Controls.Add(this.lblLoginAskSignin);
            this.panelLoginMain.Controls.Add(this.lblFor);
            this.panelLoginMain.Controls.Add(this.lbLoginName);
            this.panelLoginMain.Controls.Add(this.btnLogin);
            this.panelLoginMain.Controls.Add(this.txtbPassword);
            this.panelLoginMain.Controls.Add(this.txtbLoginEmail);
            this.panelLoginMain.Controls.Add(this.labelWelcome);
            this.panelLoginMain.Location = new System.Drawing.Point(68, 38);
            this.panelLoginMain.Name = "panelLoginMain";
            this.panelLoginMain.Size = new System.Drawing.Size(373, 465);
            this.panelLoginMain.TabIndex = 2;
            // 
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblSignin.Location = new System.Drawing.Point(231, 393);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(32, 12);
            this.lblSignin.TabIndex = 8;
            this.lblSignin.Text = "Sign in";
            // 
            // lblLoginAskSignin
            // 
            this.lblLoginAskSignin.AutoSize = true;
            this.lblLoginAskSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAskSignin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoginAskSignin.Location = new System.Drawing.Point(122, 393);
            this.lblLoginAskSignin.Name = "lblLoginAskSignin";
            this.lblLoginAskSignin.Size = new System.Drawing.Size(109, 12);
            this.lblLoginAskSignin.TabIndex = 7;
            this.lblLoginAskSignin.Text = "Do you have an account?";
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFor.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblFor.Location = new System.Drawing.Point(52, 284);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(81, 12);
            this.lblFor.TabIndex = 6;
            this.lblFor.Text = "Forget Password?";
            // 
            // lbLoginName
            // 
            this.lbLoginName.AllowDrop = true;
            this.lbLoginName.AutoSize = true;
            this.lbLoginName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginName.Location = new System.Drawing.Point(155, 92);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(51, 23);
            this.lbLoginName.TabIndex = 5;
            this.lbLoginName.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(54, 314);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(269, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(54, 219);
            this.txtbPassword.Multiline = true;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(269, 41);
            this.txtbPassword.TabIndex = 3;
            // 
            // txtbLoginEmail
            // 
            this.txtbLoginEmail.Location = new System.Drawing.Point(54, 144);
            this.txtbLoginEmail.Multiline = true;
            this.txtbLoginEmail.Name = "txtbLoginEmail";
            this.txtbLoginEmail.Size = new System.Drawing.Size(269, 41);
            this.txtbLoginEmail.TabIndex = 2;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(99, 25);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(174, 33);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome Back";
            // 
            // ptLoginform
            // 
            this.ptLoginform.Image = ((System.Drawing.Image)(resources.GetObject("ptLoginform.Image")));
            this.ptLoginform.Location = new System.Drawing.Point(-1, 1);
            this.ptLoginform.Name = "ptLoginform";
            this.ptLoginform.Size = new System.Drawing.Size(514, 564);
            this.ptLoginform.TabIndex = 1;
            this.ptLoginform.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 566);
            this.Controls.Add(this.ptLoginform);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panelLoginMain.ResumeLayout(false);
            this.panelLoginMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLoginform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptLoginform;
        private System.Windows.Forms.Panel panelLoginMain;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label lbLoginName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbLoginEmail;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblLoginAskSignin;
        private System.Windows.Forms.Label lblSignin;
    }
}

