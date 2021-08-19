
namespace CAPA_PRESENTACION
{
    partial class Formwelcome
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
            this.paneldegradado1 = new CAPA_PRESENTACION.Paneldegradado();
            this.paneldegradado2 = new CAPA_PRESENTACION.Paneldegradado();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paneldegradado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldegradado1
            // 
            this.paneldegradado1.angulo = 0F;
            this.paneldegradado1.BackColor = System.Drawing.Color.Transparent;
            this.paneldegradado1.Colorleft = System.Drawing.Color.Teal;
            this.paneldegradado1.Colorrigth = System.Drawing.Color.Navy;
            this.paneldegradado1.Controls.Add(this.label1);
            this.paneldegradado1.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldegradado1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldegradado1.Location = new System.Drawing.Point(0, 0);
            this.paneldegradado1.Name = "paneldegradado1";
            this.paneldegradado1.Size = new System.Drawing.Size(800, 109);
            this.paneldegradado1.TabIndex = 0;
            // 
            // paneldegradado2
            // 
            this.paneldegradado2.angulo = 0F;
            this.paneldegradado2.BackgroundImage = global::CAPA_PRESENTACION.Properties.Resources.pensando;
            this.paneldegradado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paneldegradado2.Colorleft = System.Drawing.Color.Empty;
            this.paneldegradado2.Colorrigth = System.Drawing.Color.Empty;
            this.paneldegradado2.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldegradado2.Location = new System.Drawing.Point(0, 109);
            this.paneldegradado2.Name = "paneldegradado2";
            this.paneldegradado2.Size = new System.Drawing.Size(339, 348);
            this.paneldegradado2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Psychology System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(519, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome";
            // 
            // Formwelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paneldegradado2);
            this.Controls.Add(this.paneldegradado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formwelcome";
            this.Text = "Formwelcome";
            this.TransparencyKey = System.Drawing.Color.White;
            this.paneldegradado1.ResumeLayout(false);
            this.paneldegradado1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Paneldegradado paneldegradado1;
        private Paneldegradado paneldegradado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}