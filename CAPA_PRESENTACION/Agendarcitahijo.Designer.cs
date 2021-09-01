
namespace CAPA_PRESENTACION
{
    partial class Agendarcitahijo
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
            this.panelagenda = new CAPA_PRESENTACION.Paneldegradado();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureboxpersonal1 = new CAPA_PRESENTACION.Pictureboxpersonal();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datetimepicker1 = new CAPA_PRESENTACION.Datetimepicker();
            this.panelagenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpersonal1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelagenda
            // 
            this.panelagenda.angulo = 0F;
            this.panelagenda.Colorleft = System.Drawing.Color.Empty;
            this.panelagenda.Colorrigth = System.Drawing.Color.Empty;
            this.panelagenda.Controls.Add(this.datetimepicker1);
            this.panelagenda.Controls.Add(this.label6);
            this.panelagenda.Controls.Add(this.label5);
            this.panelagenda.Controls.Add(this.label4);
            this.panelagenda.Controls.Add(this.label2);
            this.panelagenda.Controls.Add(this.label1);
            this.panelagenda.Controls.Add(this.pictureboxpersonal1);
            this.panelagenda.Location = new System.Drawing.Point(30, 12);
            this.panelagenda.Name = "panelagenda";
            this.panelagenda.Size = new System.Drawing.Size(386, 389);
            this.panelagenda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.label1.Location = new System.Drawing.Point(109, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agendas de citas";
            // 
            // pictureboxpersonal1
            // 
            this.pictureboxpersonal1.Bordercapstyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureboxpersonal1.Bordercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureboxpersonal1.Bordercolor2 = System.Drawing.Color.Cyan;
            this.pictureboxpersonal1.Borderlinestyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pictureboxpersonal1.Bordersize = 5;
            this.pictureboxpersonal1.Gradient = 50F;
            this.pictureboxpersonal1.Image = global::CAPA_PRESENTACION.Properties.Resources.medical_42_icon_icons_com_73897;
            this.pictureboxpersonal1.Location = new System.Drawing.Point(3, 3);
            this.pictureboxpersonal1.Name = "pictureboxpersonal1";
            this.pictureboxpersonal1.Size = new System.Drawing.Size(100, 106);
            this.pictureboxpersonal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxpersonal1.TabIndex = 0;
            this.pictureboxpersonal1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de cita:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombres:";
            // 
            // datetimepicker1
            // 
            this.datetimepicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datetimepicker1.BorderSize = 0;
            this.datetimepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datetimepicker1.Location = new System.Drawing.Point(105, 214);
            this.datetimepicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.datetimepicker1.Name = "datetimepicker1";
            this.datetimepicker1.Size = new System.Drawing.Size(268, 35);
            this.datetimepicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datetimepicker1.TabIndex = 7;
            this.datetimepicker1.TextColor = System.Drawing.Color.White;
            // 
            // Agendarcitahijo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(751, 413);
            this.Controls.Add(this.panelagenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agendarcitahijo";
            this.Text = "Agendarcitahijo";
            this.panelagenda.ResumeLayout(false);
            this.panelagenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpersonal1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Paneldegradado panelagenda;
        private System.Windows.Forms.Label label1;
        private Pictureboxpersonal pictureboxpersonal1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Datetimepicker datetimepicker1;
    }
}