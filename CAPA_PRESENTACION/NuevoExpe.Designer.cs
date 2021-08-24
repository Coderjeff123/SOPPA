
namespace CAPA_PRESENTACION
{
    partial class NuevoExpe
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
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtninactivo = new System.Windows.Forms.RadioButton();
            this.rbtnactivo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbxremitente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.dtmfecharemi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.paneldegradado1 = new CAPA_PRESENTACION.Paneldegradado();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnremitir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltitulo.SuspendLayout();
            this.panelinfo.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paneldegradado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.paneltitulo.Controls.Add(this.Titulo);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(754, 37);
            this.paneltitulo.TabIndex = 0;
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
            this.Titulo.Size = new System.Drawing.Size(149, 19);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Nuevo Expediente";
            // 
            // panelinfo
            // 
            this.panelinfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelinfo.BackColor = System.Drawing.Color.White;
            this.panelinfo.Controls.Add(this.pictureBox1);
            this.panelinfo.Controls.Add(this.label1);
            this.panelinfo.Controls.Add(this.panelDatos);
            this.panelinfo.Location = new System.Drawing.Point(0, 170);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(754, 272);
            this.panelinfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(304, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar datos";
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.Controls.Add(this.groupBox1);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.txtnombre);
            this.panelDatos.Location = new System.Drawing.Point(162, 29);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(580, 182);
            this.panelDatos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtninactivo);
            this.groupBox1.Controls.Add(this.rbtnactivo);
            this.groupBox1.Location = new System.Drawing.Point(20, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Estado";
            // 
            // rbtninactivo
            // 
            this.rbtninactivo.AutoSize = true;
            this.rbtninactivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtninactivo.Location = new System.Drawing.Point(65, 53);
            this.rbtninactivo.Name = "rbtninactivo";
            this.rbtninactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtninactivo.TabIndex = 1;
            this.rbtninactivo.Text = "Inactivo";
            this.rbtninactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Checked = true;
            this.rbtnactivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnactivo.Location = new System.Drawing.Point(65, 14);
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Size = new System.Drawing.Size(55, 17);
            this.rbtnactivo.TabIndex = 0;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(122, 11);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(316, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbxremitente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtmotivo);
            this.panel1.Controls.Add(this.dtmfecharemi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 121);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Remitente";
            // 
            // cmbxremitente
            // 
            this.cmbxremitente.FormattingEnabled = true;
            this.cmbxremitente.Items.AddRange(new object[] {
            "Coordinador General",
            "Coordinador Social",
            "Coordinador Secundaria",
            "Coordinador Primaria"});
            this.cmbxremitente.Location = new System.Drawing.Point(146, 74);
            this.cmbxremitente.Name = "cmbxremitente";
            this.cmbxremitente.Size = new System.Drawing.Size(121, 21);
            this.cmbxremitente.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(379, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Motivo de remision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de remision";
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(504, 30);
            this.txtmotivo.Multiline = true;
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(200, 70);
            this.txtmotivo.TabIndex = 7;
            // 
            // dtmfecharemi
            // 
            this.dtmfecharemi.Location = new System.Drawing.Point(146, 30);
            this.dtmfecharemi.Name = "dtmfecharemi";
            this.dtmfecharemi.Size = new System.Drawing.Size(200, 20);
            this.dtmfecharemi.TabIndex = 6;
            this.dtmfecharemi.Value = new System.DateTime(2021, 8, 24, 10, 8, 13, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Remision\r\n";
            // 
            // paneldegradado1
            // 
            this.paneldegradado1.angulo = 0F;
            this.paneldegradado1.Colorleft = System.Drawing.Color.Aqua;
            this.paneldegradado1.Colorrigth = System.Drawing.Color.DodgerBlue;
            this.paneldegradado1.Controls.Add(this.btnlimpiar);
            this.paneldegradado1.Controls.Add(this.button2);
            this.paneldegradado1.Controls.Add(this.btnremitir);
            this.paneldegradado1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldegradado1.Location = new System.Drawing.Point(0, 461);
            this.paneldegradado1.Name = "paneldegradado1";
            this.paneldegradado1.Size = new System.Drawing.Size(754, 51);
            this.paneldegradado1.TabIndex = 6;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.Image = global::CAPA_PRESENTACION.Properties.Resources.edit_clear_all_icon_180807;
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpiar.Location = new System.Drawing.Point(3, 3);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(104, 39);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::CAPA_PRESENTACION.Properties.Resources.canceltheapplication_cancelar_2901;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(606, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnremitir
            // 
            this.btnremitir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnremitir.BackColor = System.Drawing.Color.Transparent;
            this.btnremitir.FlatAppearance.BorderSize = 0;
            this.btnremitir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnremitir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnremitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremitir.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremitir.ForeColor = System.Drawing.Color.Black;
            this.btnremitir.Image = global::CAPA_PRESENTACION.Properties.Resources.ok_accept_3523;
            this.btnremitir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnremitir.Location = new System.Drawing.Point(496, 3);
            this.btnremitir.Name = "btnremitir";
            this.btnremitir.Size = new System.Drawing.Size(104, 39);
            this.btnremitir.TabIndex = 7;
            this.btnremitir.Text = "Remitir";
            this.btnremitir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnremitir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnremitir.UseVisualStyleBackColor = false;
            this.btnremitir.Click += new System.EventHandler(this.btnremitir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CAPA_PRESENTACION.Properties.Resources.avatardefault_92824;
            this.pictureBox1.Location = new System.Drawing.Point(41, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NuevoExpe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(754, 512);
            this.Controls.Add(this.paneldegradado1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelinfo);
            this.Controls.Add(this.paneltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoExpe";
            this.ShowInTaskbar = false;
            this.Text = "NuevoExpe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.panelinfo.ResumeLayout(false);
            this.panelinfo.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneldegradado1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtninactivo;
        private System.Windows.Forms.RadioButton rbtnactivo;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtmfecharemi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbxremitente;
        private Paneldegradado paneldegradado1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnremitir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlimpiar;
    }
}