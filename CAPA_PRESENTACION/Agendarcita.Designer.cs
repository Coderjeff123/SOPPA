
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
            this.paneldegra21 = new CAPA_PRESENTACION.paneldegra2();
            this.label1 = new System.Windows.Forms.Label();
            this.textagendar = new System.Windows.Forms.TextBox();
            this.dtaagendar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.paneldegra21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaagendar)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldegra21
            // 
            this.paneldegra21.Colorleft = System.Drawing.Color.Teal;
            this.paneldegra21.Colorrigth = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.paneldegra21.Controls.Add(this.label1);
            this.paneldegra21.Controls.Add(this.button1);
            this.paneldegra21.Controls.Add(this.textagendar);
            this.paneldegra21.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldegra21.Location = new System.Drawing.Point(0, 0);
            this.paneldegra21.Name = "paneldegra21";
            this.paneldegra21.Size = new System.Drawing.Size(769, 73);
            this.paneldegra21.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(299, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Expediente";
            // 
            // textagendar
            // 
            this.textagendar.Location = new System.Drawing.Point(144, 36);
            this.textagendar.Name = "textagendar";
            this.textagendar.Size = new System.Drawing.Size(415, 20);
            this.textagendar.TabIndex = 1;
            // 
            // dtaagendar
            // 
            this.dtaagendar.AllowUserToAddRows = false;
            this.dtaagendar.AllowUserToResizeColumns = false;
            this.dtaagendar.AllowUserToResizeRows = false;
            this.dtaagendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaagendar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtaagendar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtaagendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaagendar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtaagendar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtaagendar.ColumnHeadersHeight = 30;
            this.dtaagendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaagendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtaagendar.EnableHeadersVisualStyles = false;
            this.dtaagendar.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dtaagendar.Location = new System.Drawing.Point(0, 73);
            this.dtaagendar.Name = "dtaagendar";
            this.dtaagendar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtaagendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaagendar.ShowCellErrors = false;
            this.dtaagendar.ShowCellToolTips = false;
            this.dtaagendar.ShowEditingIcon = false;
            this.dtaagendar.ShowRowErrors = false;
            this.dtaagendar.Size = new System.Drawing.Size(769, 390);
            this.dtaagendar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CAPA_PRESENTACION.Properties.Resources.search_locate_find_icon_icons_com_67287;
            this.button1.Location = new System.Drawing.Point(585, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 44);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agendarcita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(769, 463);
            this.Controls.Add(this.dtaagendar);
            this.Controls.Add(this.paneldegra21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agendarcita";
            this.Text = "Agendarcita";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.paneldegra21.ResumeLayout(false);
            this.paneldegra21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaagendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private paneldegra2 paneldegra21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textagendar;
        private System.Windows.Forms.DataGridView dtaagendar;
    }
}