
namespace CAPA_PRESENTACION
{
    partial class Agendarcita
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
            this.panelagendar = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.dtmfechaini = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodiagen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtfechafin = new System.Windows.Forms.DateTimePicker();
            this.btnagen = new System.Windows.Forms.Button();
            this.panelagendar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelagendar
            // 
            this.panelagendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelagendar.Controls.Add(this.Titulo);
            this.panelagendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelagendar.Location = new System.Drawing.Point(0, 0);
            this.panelagendar.Name = "panelagendar";
            this.panelagendar.Size = new System.Drawing.Size(800, 37);
            this.panelagendar.TabIndex = 3;
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Black;
            this.Titulo.Location = new System.Drawing.Point(312, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(105, 19);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Agendar cita";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtfechafin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtcodiagen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtnombre2);
            this.panel1.Controls.Add(this.dtmfechaini);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 107);
            this.panel1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(51, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre del estudiante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(98, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha inicial: ";
            // 
            // txtnombre2
            // 
            this.txtnombre2.Location = new System.Drawing.Point(191, 25);
            this.txtnombre2.Multiline = true;
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(200, 23);
            this.txtnombre2.TabIndex = 7;
            // 
            // dtmfechaini
            // 
            this.dtmfechaini.Location = new System.Drawing.Point(191, 59);
            this.dtmfechaini.Name = "dtmfechaini";
            this.dtmfechaini.Size = new System.Drawing.Size(200, 20);
            this.dtmfechaini.TabIndex = 6;
            this.dtmfechaini.Value = new System.DateTime(2021, 8, 24, 10, 8, 13, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Agenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(406, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo:";
            // 
            // txtcodiagen
            // 
            this.txtcodiagen.Location = new System.Drawing.Point(462, 25);
            this.txtcodiagen.Multiline = true;
            this.txtcodiagen.Name = "txtcodiagen";
            this.txtcodiagen.Size = new System.Drawing.Size(78, 23);
            this.txtcodiagen.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(399, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha inicial: ";
            // 
            // dtfechafin
            // 
            this.dtfechafin.Location = new System.Drawing.Point(492, 59);
            this.dtfechafin.Name = "dtfechafin";
            this.dtfechafin.Size = new System.Drawing.Size(200, 20);
            this.dtfechafin.TabIndex = 14;
            this.dtfechafin.Value = new System.DateTime(2021, 8, 24, 10, 8, 13, 0);
            // 
            // btnagen
            // 
            this.btnagen.BackColor = System.Drawing.SystemColors.Info;
            this.btnagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagen.FlatAppearance.BorderSize = 0;
            this.btnagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagen.Image = global::CAPA_PRESENTACION.Properties.Resources.calendar_10823__1_;
            this.btnagen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagen.Location = new System.Drawing.Point(307, 150);
            this.btnagen.Name = "btnagen";
            this.btnagen.Size = new System.Drawing.Size(95, 34);
            this.btnagen.TabIndex = 7;
            this.btnagen.Text = "Agendar";
            this.btnagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagen.UseVisualStyleBackColor = false;
            // 
            // Agendarcita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnagen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelagendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agendarcita";
            this.Text = "Agendarcita";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelagendar.ResumeLayout(false);
            this.panelagendar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelagendar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtfechafin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodiagen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.DateTimePicker dtmfechaini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnagen;
    }
}