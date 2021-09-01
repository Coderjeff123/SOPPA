
namespace CAPA_PRESENTACION
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.paneldegradado1 = new CAPA_PRESENTACION.Paneldegradado();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblerror = new System.Windows.Forms.Label();
            this.paneldegradado2 = new CAPA_PRESENTACION.Paneldegradado();
            this.btnlogin = new CAPA_PRESENTACION.Buttonpersolizado();
            this.txtpass = new CAPA_PRESENTACION.textboxpersonal();
            this.txtuser = new CAPA_PRESENTACION.textboxpersonal();
            this.lblnot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.paneldegradado1.SuspendLayout();
            this.paneldegradado2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CAPA_PRESENTACION.Properties.Resources.closewindowapplication_cerca_ventan_2874;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(499, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::CAPA_PRESENTACION.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(454, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 34);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // paneldegradado1
            // 
            this.paneldegradado1.angulo = 0F;
            this.paneldegradado1.Colorleft = System.Drawing.Color.SkyBlue;
            this.paneldegradado1.Colorrigth = System.Drawing.Color.DodgerBlue;
            this.paneldegradado1.Controls.Add(this.panel1);
            this.paneldegradado1.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldegradado1.Location = new System.Drawing.Point(0, 0);
            this.paneldegradado1.Name = "paneldegradado1";
            this.paneldegradado1.Size = new System.Drawing.Size(186, 310);
            this.paneldegradado1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CAPA_PRESENTACION.Properties.Resources.human_brain_psychiatrist_icon_131296;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 158);
            this.panel1.TabIndex = 0;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblerror.Location = new System.Drawing.Point(314, 211);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 15);
            this.lblerror.TabIndex = 9;
            this.lblerror.Visible = false;
            // 
            // paneldegradado2
            // 
            this.paneldegradado2.angulo = 0F;
            this.paneldegradado2.Colorleft = System.Drawing.Color.LightSkyBlue;
            this.paneldegradado2.Colorrigth = System.Drawing.Color.LightSkyBlue;
            this.paneldegradado2.Controls.Add(this.btnlogin);
            this.paneldegradado2.Controls.Add(this.txtpass);
            this.paneldegradado2.Controls.Add(this.txtuser);
            this.paneldegradado2.Controls.Add(this.lblnot);
            this.paneldegradado2.Controls.Add(this.pictureBox2);
            this.paneldegradado2.Controls.Add(this.pictureBox1);
            this.paneldegradado2.Controls.Add(this.label1);
            this.paneldegradado2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldegradado2.Location = new System.Drawing.Point(186, 0);
            this.paneldegradado2.Name = "paneldegradado2";
            this.paneldegradado2.Size = new System.Drawing.Size(443, 310);
            this.paneldegradado2.TabIndex = 10;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnlogin.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnlogin.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnlogin.BorderRadius = 20;
            this.btnlogin.BorderSize = 1;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(131, 229);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(150, 40);
            this.btnlogin.TabIndex = 12;
            this.btnlogin.Text = "Acceder";
            this.btnlogin.TextColor = System.Drawing.Color.Black;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.SkyBlue;
            this.txtpass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtpass.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtpass.BorderRadius = 0;
            this.txtpass.BorderSize = 2;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.IsFocused = true;
            this.txtpass.IsPasswordChar = false;
            this.txtpass.IsPlaceholder = false;
            this.txtpass.Location = new System.Drawing.Point(86, 125);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Multiline = false;
            this.txtpass.Name = "txtpass";
            this.txtpass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtpass.PasswordChar = true;
            this.txtpass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtpass.PlaceholderText = "";
            this.txtpass.Size = new System.Drawing.Size(290, 31);
            this.txtpass.TabIndex = 11;
            this.txtpass.Texts = "";
            this.txtpass.UnderlinedStyle = true;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.SkyBlue;
            this.txtuser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtuser.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtuser.BorderRadius = 0;
            this.txtuser.BorderSize = 2;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.IsFocused = true;
            this.txtuser.IsPasswordChar = false;
            this.txtuser.IsPlaceholder = false;
            this.txtuser.Location = new System.Drawing.Point(86, 60);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtuser.PasswordChar = false;
            this.txtuser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtuser.PlaceholderText = "";
            this.txtuser.Size = new System.Drawing.Size(286, 31);
            this.txtuser.TabIndex = 10;
            this.txtuser.Texts = "User";
            this.txtuser.UnderlinedStyle = true;
            // 
            // lblnot
            // 
            this.lblnot.AutoSize = true;
            this.lblnot.BackColor = System.Drawing.Color.Transparent;
            this.lblnot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnot.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnot.ForeColor = System.Drawing.Color.Red;
            this.lblnot.Location = new System.Drawing.Point(86, 174);
            this.lblnot.Name = "lblnot";
            this.lblnot.Size = new System.Drawing.Size(50, 19);
            this.lblnot.TabIndex = 9;
            this.lblnot.Text = "label2";
            this.lblnot.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(629, 310);
            this.Controls.Add(this.paneldegradado2);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.paneldegradado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.paneldegradado1.ResumeLayout(false);
            this.paneldegradado2.ResumeLayout(false);
            this.paneldegradado2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Paneldegradado paneldegradado1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblerror;
        private Paneldegradado paneldegradado2;
        private System.Windows.Forms.Label lblnot;
        private textboxpersonal txtuser;
        private textboxpersonal txtpass;
        private Buttonpersolizado btnlogin;
        // private ShapeContainer shapeContainer1;
        //private LineShape lineShape2;
        //private LineShape lineShape1;
    }
}