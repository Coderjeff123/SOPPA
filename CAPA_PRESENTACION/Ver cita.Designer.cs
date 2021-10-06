
namespace CAPA_PRESENTACION
{
    partial class Ver_cita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtacita = new System.Windows.Forms.DataGridView();
            this.Titulo1 = new System.Windows.Forms.Label();
            this.monthfechaactu = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texthoraA = new System.Windows.Forms.TextBox();
            this.selecion = new System.Windows.Forms.Label();
            this.fecha3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paneldegradado1 = new CAPA_PRESENTACION.Paneldegradado();
            this.texfecha2 = new System.Windows.Forms.TextBox();
            this.textfecha = new System.Windows.Forms.TextBox();
            this.textremision = new System.Windows.Forms.TextBox();
            this.textidcita = new System.Windows.Forms.TextBox();
            this.btnposponer = new CAPA_PRESENTACION.Buttonpersolizado();
            ((System.ComponentModel.ISupportInitialize)(this.dtacita)).BeginInit();
            this.paneldegradado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtacita
            // 
            this.dtacita.AllowUserToAddRows = false;
            this.dtacita.AllowUserToResizeColumns = false;
            this.dtacita.AllowUserToResizeRows = false;
            this.dtacita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtacita.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtacita.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dtacita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtacita.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtacita.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtacita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtacita.ColumnHeadersHeight = 30;
            this.dtacita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtacita.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtacita.EnableHeadersVisualStyles = false;
            this.dtacita.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dtacita.Location = new System.Drawing.Point(35, 62);
            this.dtacita.Name = "dtacita";
            this.dtacita.ReadOnly = true;
            this.dtacita.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtacita.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtacita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtacita.ShowCellErrors = false;
            this.dtacita.ShowCellToolTips = false;
            this.dtacita.ShowEditingIcon = false;
            this.dtacita.ShowRowErrors = false;
            this.dtacita.Size = new System.Drawing.Size(683, 207);
            this.dtacita.TabIndex = 8;
            this.dtacita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtacita_CellContentClick);
            this.dtacita.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtacita_RowHeaderMouseClick);
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.ForeColor = System.Drawing.Color.White;
            this.Titulo1.Location = new System.Drawing.Point(32, 25);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(77, 16);
            this.Titulo1.TabIndex = 9;
            this.Titulo1.Text = "Ver Citas";
            // 
            // monthfechaactu
            // 
            this.monthfechaactu.Location = new System.Drawing.Point(470, 281);
            this.monthfechaactu.Name = "monthfechaactu";
            this.monthfechaactu.TabIndex = 12;
            this.monthfechaactu.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selecione nueva fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Selecione nueva hora:";
            // 
            // texthoraA
            // 
            this.texthoraA.Location = new System.Drawing.Point(174, 341);
            this.texthoraA.Name = "texthoraA";
            this.texthoraA.Size = new System.Drawing.Size(100, 20);
            this.texthoraA.TabIndex = 15;
            // 
            // selecion
            // 
            this.selecion.AutoSize = true;
            this.selecion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selecion.Location = new System.Drawing.Point(297, 340);
            this.selecion.Name = "selecion";
            this.selecion.Size = new System.Drawing.Size(0, 19);
            this.selecion.TabIndex = 16;
            // 
            // fecha3
            // 
            this.fecha3.AutoSize = true;
            this.fecha3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha3.Location = new System.Drawing.Point(303, 330);
            this.fecha3.Name = "fecha3";
            this.fecha3.Size = new System.Drawing.Size(0, 19);
            this.fecha3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(330, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // paneldegradado1
            // 
            this.paneldegradado1.angulo = 0F;
            this.paneldegradado1.Colorleft = System.Drawing.Color.Aqua;
            this.paneldegradado1.Colorrigth = System.Drawing.Color.DodgerBlue;
            this.paneldegradado1.Controls.Add(this.texfecha2);
            this.paneldegradado1.Controls.Add(this.textfecha);
            this.paneldegradado1.Controls.Add(this.textremision);
            this.paneldegradado1.Controls.Add(this.textidcita);
            this.paneldegradado1.Controls.Add(this.btnposponer);
            this.paneldegradado1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldegradado1.Location = new System.Drawing.Point(0, 448);
            this.paneldegradado1.Name = "paneldegradado1";
            this.paneldegradado1.Size = new System.Drawing.Size(768, 57);
            this.paneldegradado1.TabIndex = 11;
            // 
            // texfecha2
            // 
            this.texfecha2.Location = new System.Drawing.Point(587, 25);
            this.texfecha2.Name = "texfecha2";
            this.texfecha2.Size = new System.Drawing.Size(100, 20);
            this.texfecha2.TabIndex = 19;
            this.texfecha2.Visible = false;
            // 
            // textfecha
            // 
            this.textfecha.Location = new System.Drawing.Point(481, 25);
            this.textfecha.Name = "textfecha";
            this.textfecha.Size = new System.Drawing.Size(100, 20);
            this.textfecha.TabIndex = 18;
            this.textfecha.Visible = false;
            // 
            // textremision
            // 
            this.textremision.Location = new System.Drawing.Point(358, 25);
            this.textremision.Name = "textremision";
            this.textremision.Size = new System.Drawing.Size(100, 20);
            this.textremision.TabIndex = 17;
            this.textremision.Visible = false;
            // 
            // textidcita
            // 
            this.textidcita.Location = new System.Drawing.Point(230, 25);
            this.textidcita.Name = "textidcita";
            this.textidcita.Size = new System.Drawing.Size(100, 20);
            this.textidcita.TabIndex = 16;
            this.textidcita.Visible = false;
            // 
            // btnposponer
            // 
            this.btnposponer.BackColor = System.Drawing.Color.Transparent;
            this.btnposponer.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnposponer.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnposponer.BorderRadius = 5;
            this.btnposponer.BorderSize = 1;
            this.btnposponer.FlatAppearance.BorderSize = 0;
            this.btnposponer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnposponer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnposponer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnposponer.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnposponer.ForeColor = System.Drawing.Color.Black;
            this.btnposponer.Image = global::CAPA_PRESENTACION.Properties.Resources.priority_low_icon_136291;
            this.btnposponer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnposponer.Location = new System.Drawing.Point(20, 7);
            this.btnposponer.Name = "btnposponer";
            this.btnposponer.Size = new System.Drawing.Size(150, 40);
            this.btnposponer.TabIndex = 10;
            this.btnposponer.Text = "Posponer cita";
            this.btnposponer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnposponer.TextColor = System.Drawing.Color.Black;
            this.btnposponer.UseVisualStyleBackColor = false;
            this.btnposponer.Click += new System.EventHandler(this.btnposponer_Click);
            // 
            // Ver_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(768, 505);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha3);
            this.Controls.Add(this.selecion);
            this.Controls.Add(this.texthoraA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthfechaactu);
            this.Controls.Add(this.paneldegradado1);
            this.Controls.Add(this.Titulo1);
            this.Controls.Add(this.dtacita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_cita";
            this.Text = "Ver_cita";
            this.Load += new System.EventHandler(this.Ver_cita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtacita)).EndInit();
            this.paneldegradado1.ResumeLayout(false);
            this.paneldegradado1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtacita;
        private System.Windows.Forms.Label Titulo1;
        private Buttonpersolizado btnposponer;
        private Paneldegradado paneldegradado1;
        private System.Windows.Forms.MonthCalendar monthfechaactu;
        private System.Windows.Forms.TextBox textfecha;
        private System.Windows.Forms.TextBox textremision;
        private System.Windows.Forms.TextBox textidcita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texthoraA;
        private System.Windows.Forms.TextBox texfecha2;
        private System.Windows.Forms.Label selecion;
        private System.Windows.Forms.Label fecha3;
        private System.Windows.Forms.Label label3;
    }
}