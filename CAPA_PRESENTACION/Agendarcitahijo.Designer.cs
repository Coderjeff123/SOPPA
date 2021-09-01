
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
            this.datetimepicker2 = new CAPA_PRESENTACION.Datetimepicker();
            this.panelagenda = new CAPA_PRESENTACION.Paneldegradado();
            this.pictureboxpersonal1 = new CAPA_PRESENTACION.Pictureboxpersonal();
            this.label1 = new System.Windows.Forms.Label();
            this.panelagenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpersonal1)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimepicker2
            // 
            this.datetimepicker2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datetimepicker2.BorderSize = 0;
            this.datetimepicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datetimepicker2.Location = new System.Drawing.Point(462, 50);
            this.datetimepicker2.MinimumSize = new System.Drawing.Size(0, 35);
            this.datetimepicker2.Name = "datetimepicker2";
            this.datetimepicker2.Size = new System.Drawing.Size(277, 35);
            this.datetimepicker2.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datetimepicker2.TabIndex = 1;
            this.datetimepicker2.TextColor = System.Drawing.Color.White;
            // 
            // panelagenda
            // 
            this.panelagenda.angulo = 0F;
            this.panelagenda.Colorleft = System.Drawing.Color.Empty;
            this.panelagenda.Colorrigth = System.Drawing.Color.Empty;
            this.panelagenda.Controls.Add(this.label1);
            this.panelagenda.Controls.Add(this.pictureboxpersonal1);
            this.panelagenda.Location = new System.Drawing.Point(30, 12);
            this.panelagenda.Name = "panelagenda";
            this.panelagenda.Size = new System.Drawing.Size(353, 389);
            this.panelagenda.TabIndex = 5;
           // this.panelagenda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelagenda_Paint);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Agendarcitahijo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(751, 413);
            this.Controls.Add(this.panelagenda);
            this.Controls.Add(this.datetimepicker2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agendarcitahijo";
            this.Text = "Agendarcitahijo";
           // this.Load += new System.EventHandler(this.Agendarcitahijo_Load);
            this.panelagenda.ResumeLayout(false);
            this.panelagenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpersonal1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Datetimepicker datetimepicker2;
        private Paneldegradado panelagenda;
        private System.Windows.Forms.Label label1;
        private Pictureboxpersonal pictureboxpersonal1;
    }
}