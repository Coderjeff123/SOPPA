
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.paneldegradado1 = new CAPA_PRESENTACION.Paneldegradado();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblerror = new System.Windows.Forms.Label();
            this.paneldegradado2 = new CAPA_PRESENTACION.Paneldegradado();
            this.lblnot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.paneldegradado1.SuspendLayout();
            this.paneldegradado2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(131, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(131, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 10);
            this.panel3.TabIndex = 2;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Location = new System.Drawing.Point(131, 96);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(286, 18);
            this.txtuser.TabIndex = 2;
            this.txtuser.Text = "User";
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.Location = new System.Drawing.Point(131, 165);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(286, 18);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Password";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
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
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(242)))), ((int)(((byte)(200)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(140, 249);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(277, 33);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Acceder";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            this.btnlogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnlogin_KeyDown);
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
            this.paneldegradado1.Colorleft = System.Drawing.Color.Teal;
            this.paneldegradado1.Colorrigth = System.Drawing.Color.Aqua;
            this.paneldegradado1.Controls.Add(this.panel1);
            this.paneldegradado1.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldegradado1.Location = new System.Drawing.Point(0, 0);
            this.paneldegradado1.Name = "paneldegradado1";
            this.paneldegradado1.Size = new System.Drawing.Size(186, 336);
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
            this.paneldegradado2.Colorrigth = System.Drawing.Color.Teal;
            this.paneldegradado2.Controls.Add(this.lblnot);
            this.paneldegradado2.Controls.Add(this.pictureBox2);
            this.paneldegradado2.Controls.Add(this.pictureBox1);
            this.paneldegradado2.Controls.Add(this.label1);
            this.paneldegradado2.Controls.Add(this.btnlogin);
            this.paneldegradado2.Controls.Add(this.txtpass);
            this.paneldegradado2.Controls.Add(this.txtuser);
            this.paneldegradado2.Controls.Add(this.panel2);
            this.paneldegradado2.Controls.Add(this.panel3);
            this.paneldegradado2.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldegradado2.Location = new System.Drawing.Point(186, 0);
            this.paneldegradado2.Name = "paneldegradado2";
            this.paneldegradado2.Size = new System.Drawing.Size(533, 336);
            this.paneldegradado2.TabIndex = 10;
            // 
            // lblnot
            // 
            this.lblnot.AutoSize = true;
            this.lblnot.BackColor = System.Drawing.Color.Transparent;
            this.lblnot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnot.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnot.ForeColor = System.Drawing.Color.Red;
            this.lblnot.Location = new System.Drawing.Point(131, 211);
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
            this.ClientSize = new System.Drawing.Size(719, 336);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblerror;
        private Paneldegradado paneldegradado2;
        private System.Windows.Forms.Label lblnot;
    }
}