
namespace CAPA_PRESENTACION
{
    partial class VerExpediente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.panelbusqueda = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtaexpe = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbaja = new System.Windows.Forms.Button();
            this.paneldegradado1 = new CAPA_PRESENTACION.Paneldegradado();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelbusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaexpe)).BeginInit();
            this.panel2.SuspendLayout();
            this.paneldegradado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 37);
            this.panel1.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Black;
            this.Titulo.Location = new System.Drawing.Point(303, 8);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(125, 19);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Ver Expediente";
            // 
            // panelbusqueda
            // 
            this.panelbusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelbusqueda.BackColor = System.Drawing.Color.White;
            this.panelbusqueda.Controls.Add(this.button1);
            this.panelbusqueda.Controls.Add(this.label1);
            this.panelbusqueda.Controls.Add(this.textBox1);
            this.panelbusqueda.Location = new System.Drawing.Point(24, 69);
            this.panelbusqueda.Name = "panelbusqueda";
            this.panelbusqueda.Size = new System.Drawing.Size(717, 56);
            this.panelbusqueda.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CAPA_PRESENTACION.Properties.Resources.search_locate_find_icon_icons_com_67287;
            this.button1.Location = new System.Drawing.Point(513, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 41);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Expediente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dtaexpe
            // 
            this.dtaexpe.AllowUserToAddRows = false;
            this.dtaexpe.AllowUserToResizeColumns = false;
            this.dtaexpe.AllowUserToResizeRows = false;
            this.dtaexpe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaexpe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtaexpe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtaexpe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaexpe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtaexpe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaexpe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaexpe.ColumnHeadersHeight = 30;
            this.dtaexpe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaexpe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtaexpe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtaexpe.EnableHeadersVisualStyles = false;
            this.dtaexpe.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dtaexpe.Location = new System.Drawing.Point(0, 0);
            this.dtaexpe.Name = "dtaexpe";
            this.dtaexpe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaexpe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtaexpe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaexpe.ShowCellErrors = false;
            this.dtaexpe.ShowCellToolTips = false;
            this.dtaexpe.ShowEditingIcon = false;
            this.dtaexpe.ShowRowErrors = false;
            this.dtaexpe.Size = new System.Drawing.Size(717, 265);
            this.dtaexpe.TabIndex = 1;
            this.dtaexpe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaexpe_CellClick);
            this.dtaexpe.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtaexpe_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtaexpe);
            this.panel2.Location = new System.Drawing.Point(30, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 265);
            this.panel2.TabIndex = 2;
            // 
            // btnbaja
            // 
            this.btnbaja.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnbaja.FlatAppearance.BorderSize = 0;
            this.btnbaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnbaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnbaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaja.Image = global::CAPA_PRESENTACION.Properties.Resources.priority_low_icon_136291;
            this.btnbaja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbaja.Location = new System.Drawing.Point(12, 14);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(108, 34);
            this.btnbaja.TabIndex = 3;
            this.btnbaja.Text = "Dar de baja";
            this.btnbaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbaja.UseVisualStyleBackColor = false;
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // paneldegradado1
            // 
            this.paneldegradado1.angulo = 0F;
            this.paneldegradado1.Colorleft = System.Drawing.Color.Empty;
            this.paneldegradado1.Colorrigth = System.Drawing.Color.Empty;
            this.paneldegradado1.Controls.Add(this.txtestado);
            this.paneldegradado1.Controls.Add(this.id);
            this.paneldegradado1.Controls.Add(this.btnbaja);
            this.paneldegradado1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldegradado1.Location = new System.Drawing.Point(0, 445);
            this.paneldegradado1.Name = "paneldegradado1";
            this.paneldegradado1.Size = new System.Drawing.Size(768, 60);
            this.paneldegradado1.TabIndex = 3;
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(656, 14);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(100, 20);
            this.txtestado.TabIndex = 5;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(537, 14);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 4;
            this.id.Visible = false;
            // 
            // VerExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(768, 505);
            this.Controls.Add(this.paneldegradado1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelbusqueda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VerExpediente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VerExpediente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelbusqueda.ResumeLayout(false);
            this.panelbusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaexpe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.paneldegradado1.ResumeLayout(false);
            this.paneldegradado1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridView dtaexpe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbaja;
        private Paneldegradado paneldegradado1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox txtestado;
    }
}