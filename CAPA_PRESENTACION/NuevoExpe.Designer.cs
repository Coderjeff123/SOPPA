
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelinfo = new System.Windows.Forms.Panel();
            this.paneldegradado2 = new CAPA_PRESENTACION.Paneldegradado();
            this.dtaexpe = new System.Windows.Forms.DataGridView();
            this.panelBuscaestu = new CAPA_PRESENTACION.paneldegra2();
            this.txtnom = new CAPA_PRESENTACION.textboxpersonal();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.paneldegradado1 = new CAPA_PRESENTACION.Paneldegradado();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnremitir = new System.Windows.Forms.Button();
            this.paneldegra21 = new CAPA_PRESENTACION.paneldegra2();
            this.txtmotivo = new CAPA_PRESENTACION.textboxpersonal();
            this.cmbxremitente = new CAPA_PRESENTACION.Combobox();
            this.datetimepicker1 = new CAPA_PRESENTACION.Datetimepicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new CAPA_PRESENTACION.Pictureboxpersonal();
            this.rbtinactivo = new CAPA_PRESENTACION.radiobuttonpersonal();
            this.rbtnactivo = new CAPA_PRESENTACION.radiobuttonpersonal();
            this.txtnombre = new CAPA_PRESENTACION.textboxpersonal();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.panelinfo.SuspendLayout();
            this.paneldegradado2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaexpe)).BeginInit();
            this.panelBuscaestu.SuspendLayout();
            this.paneldegradado1.SuspendLayout();
            this.paneldegra21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar datos";
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.Controls.Add(this.rbtinactivo);
            this.panelDatos.Controls.Add(this.rbtnactivo);
            this.panelDatos.Controls.Add(this.txtnombre);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Location = new System.Drawing.Point(162, 29);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(580, 182);
            this.panelDatos.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // panelinfo
            // 
            this.panelinfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelinfo.BackColor = System.Drawing.Color.Transparent;
            this.panelinfo.Controls.Add(this.pictureBox1);
            this.panelinfo.Controls.Add(this.label1);
            this.panelinfo.Controls.Add(this.panelDatos);
            this.panelinfo.Location = new System.Drawing.Point(0, 170);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(754, 272);
            this.panelinfo.TabIndex = 3;
            this.panelinfo.Visible = false;
            // 
            // paneldegradado2
            // 
            this.paneldegradado2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldegradado2.angulo = 0F;
            this.paneldegradado2.BackColor = System.Drawing.Color.Transparent;
            this.paneldegradado2.Colorleft = System.Drawing.Color.Transparent;
            this.paneldegradado2.Colorrigth = System.Drawing.Color.Transparent;
            this.paneldegradado2.Controls.Add(this.dtaexpe);
            this.paneldegradado2.Controls.Add(this.panelBuscaestu);
            this.paneldegradado2.Location = new System.Drawing.Point(0, 387);
            this.paneldegradado2.Name = "paneldegradado2";
            this.paneldegradado2.Size = new System.Drawing.Size(754, 78);
            this.paneldegradado2.TabIndex = 6;
            // 
            // dtaexpe
            // 
            this.dtaexpe.AllowUserToAddRows = false;
            this.dtaexpe.AllowUserToResizeColumns = false;
            this.dtaexpe.AllowUserToResizeRows = false;
            this.dtaexpe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaexpe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtaexpe.BackgroundColor = System.Drawing.Color.SkyBlue;
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
            this.dtaexpe.EnableHeadersVisualStyles = false;
            this.dtaexpe.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dtaexpe.Location = new System.Drawing.Point(0, 173);
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
            this.dtaexpe.Size = new System.Drawing.Size(754, 292);
            this.dtaexpe.TabIndex = 7;
            this.dtaexpe.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtaexpe_RowHeaderMouseDoubleClick);
            // 
            // panelBuscaestu
            // 
            this.panelBuscaestu.Colorleft = System.Drawing.Color.DodgerBlue;
            this.panelBuscaestu.Colorrigth = System.Drawing.Color.DeepSkyBlue;
            this.panelBuscaestu.Controls.Add(this.txtnom);
            this.panelBuscaestu.Controls.Add(this.label3);
            this.panelBuscaestu.Controls.Add(this.button1);
            this.panelBuscaestu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscaestu.Location = new System.Drawing.Point(0, 0);
            this.panelBuscaestu.Name = "panelBuscaestu";
            this.panelBuscaestu.Size = new System.Drawing.Size(754, 74);
            this.panelBuscaestu.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtnom.BorderColor = System.Drawing.Color.Blue;
            this.txtnom.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtnom.BorderRadius = 0;
            this.txtnom.BorderSize = 2;
            this.txtnom.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.ForeColor = System.Drawing.Color.White;
            this.txtnom.IsFocused = false;
            this.txtnom.IsPasswordChar = false;
            this.txtnom.IsPlaceholder = false;
            this.txtnom.Location = new System.Drawing.Point(116, 30);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.Multiline = false;
            this.txtnom.Name = "txtnom";
            this.txtnom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnom.PasswordChar = false;
            this.txtnom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtnom.PlaceholderText = "";
            this.txtnom.Size = new System.Drawing.Size(461, 32);
            this.txtnom.TabIndex = 4;
            this.txtnom.Texts = "";
            this.txtnom.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(290, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscar Estudiante";
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
            this.button1.Location = new System.Drawing.Point(584, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 41);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.paneldegradado1.Location = new System.Drawing.Point(0, 465);
            this.paneldegradado1.Name = "paneldegradado1";
            this.paneldegradado1.Size = new System.Drawing.Size(754, 47);
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
            this.btnlimpiar.Location = new System.Drawing.Point(3, 1);
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
            this.button2.Location = new System.Drawing.Point(638, 3);
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
            this.btnremitir.Location = new System.Drawing.Point(528, 4);
            this.btnremitir.Name = "btnremitir";
            this.btnremitir.Size = new System.Drawing.Size(104, 39);
            this.btnremitir.TabIndex = 7;
            this.btnremitir.Text = "Remitir";
            this.btnremitir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnremitir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnremitir.UseVisualStyleBackColor = false;
            this.btnremitir.Click += new System.EventHandler(this.btnremitir_Click);
            // 
            // paneldegra21
            // 
            this.paneldegra21.Colorleft = System.Drawing.Color.Empty;
            this.paneldegra21.Colorrigth = System.Drawing.Color.Empty;
            this.paneldegra21.Controls.Add(this.txtmotivo);
            this.paneldegra21.Controls.Add(this.cmbxremitente);
            this.paneldegra21.Controls.Add(this.datetimepicker1);
            this.paneldegra21.Controls.Add(this.label9);
            this.paneldegra21.Controls.Add(this.label6);
            this.paneldegra21.Controls.Add(this.label8);
            this.paneldegra21.Controls.Add(this.label7);
            this.paneldegra21.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldegra21.Location = new System.Drawing.Point(0, 0);
            this.paneldegra21.Name = "paneldegra21";
            this.paneldegra21.Size = new System.Drawing.Size(754, 132);
            this.paneldegra21.TabIndex = 7;
            // 
            // txtmotivo
            // 
            this.txtmotivo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtmotivo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtmotivo.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtmotivo.BorderRadius = 0;
            this.txtmotivo.BorderSize = 2;
            this.txtmotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmotivo.ForeColor = System.Drawing.Color.Black;
            this.txtmotivo.IsFocused = false;
            this.txtmotivo.IsPasswordChar = false;
            this.txtmotivo.IsPlaceholder = false;
            this.txtmotivo.Location = new System.Drawing.Point(492, 23);
            this.txtmotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtmotivo.Multiline = true;
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtmotivo.PasswordChar = false;
            this.txtmotivo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtmotivo.PlaceholderText = "";
            this.txtmotivo.Size = new System.Drawing.Size(250, 77);
            this.txtmotivo.TabIndex = 14;
            this.txtmotivo.Texts = "";
            this.txtmotivo.UnderlinedStyle = false;
            this.txtmotivo._TextChanged += new System.EventHandler(this.txtmotivo_Validated);
            // 
            // cmbxremitente
            // 
            this.cmbxremitente.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbxremitente.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cmbxremitente.BorderSize = 2;
            this.cmbxremitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxremitente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxremitente.ForeColor = System.Drawing.Color.Gray;
            this.cmbxremitente.IconColor = System.Drawing.Color.CornflowerBlue;
            this.cmbxremitente.Items.AddRange(new object[] {
            "Coordinador General",
            "Coordinador Social",
            "Coordinador de secundaria",
            "Coordinador Primaria"});
            this.cmbxremitente.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.cmbxremitente.ListTextColor = System.Drawing.Color.White;
            this.cmbxremitente.Location = new System.Drawing.Point(144, 70);
            this.cmbxremitente.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxremitente.Name = "cmbxremitente";
            this.cmbxremitente.Padding = new System.Windows.Forms.Padding(2);
            this.cmbxremitente.Size = new System.Drawing.Size(200, 30);
            this.cmbxremitente.TabIndex = 13;
            this.cmbxremitente.Texts = "";
            // 
            // datetimepicker1
            // 
            this.datetimepicker1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.datetimepicker1.BorderSize = 2;
            this.datetimepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datetimepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepicker1.Location = new System.Drawing.Point(144, 23);
            this.datetimepicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.datetimepicker1.Name = "datetimepicker1";
            this.datetimepicker1.Size = new System.Drawing.Size(166, 35);
            this.datetimepicker1.SkinColor = System.Drawing.Color.SkyBlue;
            this.datetimepicker1.TabIndex = 12;
            this.datetimepicker1.TextColor = System.Drawing.Color.White;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Remitente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Remision\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(336, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Motivo de remision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de remision";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Bordercapstyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBox1.Bordercolor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Bordercolor2 = System.Drawing.Color.Cyan;
            this.pictureBox1.Borderlinestyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBox1.Bordersize = 2;
            this.pictureBox1.Gradient = 50F;
            this.pictureBox1.Image = global::CAPA_PRESENTACION.Properties.Resources.avatardefault_92824;
            this.pictureBox1.Location = new System.Drawing.Point(31, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rbtinactivo
            // 
            this.rbtinactivo.AutoSize = true;
            this.rbtinactivo.BackColor = System.Drawing.Color.SkyBlue;
            this.rbtinactivo.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.rbtinactivo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtinactivo.ForeColor = System.Drawing.Color.White;
            this.rbtinactivo.Location = new System.Drawing.Point(146, 117);
            this.rbtinactivo.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtinactivo.Name = "rbtinactivo";
            this.rbtinactivo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtinactivo.Size = new System.Drawing.Size(88, 21);
            this.rbtinactivo.TabIndex = 12;
            this.rbtinactivo.TabStop = true;
            this.rbtinactivo.Text = "Inactivo";
            this.rbtinactivo.UnCheckedColor = System.Drawing.Color.SteelBlue;
            this.rbtinactivo.UseVisualStyleBackColor = false;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.BackColor = System.Drawing.Color.SkyBlue;
            this.rbtnactivo.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.rbtnactivo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnactivo.ForeColor = System.Drawing.Color.White;
            this.rbtnactivo.Location = new System.Drawing.Point(146, 79);
            this.rbtnactivo.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnactivo.Size = new System.Drawing.Size(78, 21);
            this.rbtnactivo.TabIndex = 11;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UnCheckedColor = System.Drawing.Color.SteelBlue;
            this.rbtnactivo.UseVisualStyleBackColor = false;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.SkyBlue;
            this.txtnombre.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtnombre.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtnombre.BorderRadius = 0;
            this.txtnombre.BorderSize = 2;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.IsFocused = false;
            this.txtnombre.IsPasswordChar = false;
            this.txtnombre.IsPlaceholder = false;
            this.txtnombre.Location = new System.Drawing.Point(85, 7);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnombre.PasswordChar = false;
            this.txtnombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtnombre.PlaceholderText = "";
            this.txtnombre.Size = new System.Drawing.Size(316, 31);
            this.txtnombre.TabIndex = 10;
            this.txtnombre.Texts = "";
            this.txtnombre.UnderlinedStyle = true;
            this.txtnombre.Validated += new System.EventHandler(this.txtnombre_Validated);
            // 
            // NuevoExpe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(754, 512);
            this.Controls.Add(this.paneldegradado2);
            this.Controls.Add(this.paneldegradado1);
            this.Controls.Add(this.paneldegra21);
            this.Controls.Add(this.panelinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoExpe";
            this.ShowInTaskbar = false;
            this.Text = "NuevoExpe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.panelinfo.ResumeLayout(false);
            this.panelinfo.PerformLayout();
            this.paneldegradado2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaexpe)).EndInit();
            this.panelBuscaestu.ResumeLayout(false);
            this.panelBuscaestu.PerformLayout();
            this.paneldegradado1.ResumeLayout(false);
            this.paneldegra21.ResumeLayout(false);
            this.paneldegra21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Paneldegradado paneldegradado1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnremitir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ErrorProvider epError;
        private Paneldegradado paneldegradado2;
        private paneldegra2 panelBuscaestu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtaexpe;
        private paneldegra2 paneldegra21;
        private Datetimepicker datetimepicker1;
        private Combobox cmbxremitente;
        private textboxpersonal txtmotivo;
        private System.Windows.Forms.Panel panelinfo;
        private Pictureboxpersonal pictureBox1;
        private textboxpersonal txtnombre;
        private textboxpersonal txtnom;
        private radiobuttonpersonal rbtinactivo;
        private radiobuttonpersonal rbtnactivo;
        // private radiobuttonpersonal rbtnactivo;
        // private radiobuttonpersonal rbtninactivo;
    }
}