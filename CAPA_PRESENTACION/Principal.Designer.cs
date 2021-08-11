
namespace CAPA_PRESENTACION
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnresform = new System.Windows.Forms.Button();
            this.btnminform = new System.Windows.Forms.Button();
            this.btnmaxform = new System.Windows.Forms.Button();
            this.btncloseform = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panelsubmenuinformes = new System.Windows.Forms.Panel();
            this.btngenerarinfo = new System.Windows.Forms.Button();
            this.btnverinformes = new System.Windows.Forms.Button();
            this.btninforme = new System.Windows.Forms.Button();
            this.panelsubmenucita = new System.Windows.Forms.Panel();
            this.btnposponercita = new System.Windows.Forms.Button();
            this.btnagendarcitas = new System.Windows.Forms.Button();
            this.btnvercitas = new System.Windows.Forms.Button();
            this.btncita = new System.Windows.Forms.Button();
            this.panelsubmenuconsulta = new System.Windows.Forms.Panel();
            this.btniniciarconsulta = new System.Windows.Forms.Button();
            this.btnnuevaconsulta = new System.Windows.Forms.Button();
            this.btnverconsulta = new System.Windows.Forms.Button();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.panelsubmenuexpe = new System.Windows.Forms.Panel();
            this.btnbaja = new System.Windows.Forms.Button();
            this.btnnuevoexpe = new System.Windows.Forms.Button();
            this.btnverexpe = new System.Windows.Forms.Button();
            this.btnexpediente = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelFormhijo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.panelsubmenuinformes.SuspendLayout();
            this.panelsubmenucita.SuspendLayout();
            this.panelsubmenuconsulta.SuspendLayout();
            this.panelsubmenuexpe.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 44);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnresform);
            this.panel2.Controls.Add(this.btnminform);
            this.panel2.Controls.Add(this.btnmaxform);
            this.panel2.Controls.Add(this.btncloseform);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(869, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 44);
            this.panel2.TabIndex = 7;
            // 
            // btnresform
            // 
            this.btnresform.FlatAppearance.BorderSize = 0;
            this.btnresform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresform.Image = global::CAPA_PRESENTACION.Properties.Resources.window_restore_icon_144027;
            this.btnresform.Location = new System.Drawing.Point(44, 2);
            this.btnresform.Name = "btnresform";
            this.btnresform.Size = new System.Drawing.Size(38, 41);
            this.btnresform.TabIndex = 4;
            this.btnresform.UseVisualStyleBackColor = true;
            this.btnresform.Click += new System.EventHandler(this.btnresform_Click);
            // 
            // btnminform
            // 
            this.btnminform.FlatAppearance.BorderSize = 0;
            this.btnminform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminform.Image = global::CAPA_PRESENTACION.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.btnminform.Location = new System.Drawing.Point(6, 0);
            this.btnminform.Name = "btnminform";
            this.btnminform.Size = new System.Drawing.Size(38, 41);
            this.btnminform.TabIndex = 6;
            this.btnminform.UseVisualStyleBackColor = true;
            this.btnminform.Click += new System.EventHandler(this.btnminform_Click);
            // 
            // btnmaxform
            // 
            this.btnmaxform.FlatAppearance.BorderSize = 0;
            this.btnmaxform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaxform.Image = global::CAPA_PRESENTACION.Properties.Resources.gui_form_checkbox_icon_157650;
            this.btnmaxform.Location = new System.Drawing.Point(44, 2);
            this.btnmaxform.Name = "btnmaxform";
            this.btnmaxform.Size = new System.Drawing.Size(38, 36);
            this.btnmaxform.TabIndex = 5;
            this.btnmaxform.UseVisualStyleBackColor = true;
            this.btnmaxform.Visible = false;
            this.btnmaxform.Click += new System.EventHandler(this.btnmaxform_Click);
            // 
            // btncloseform
            // 
            this.btncloseform.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncloseform.FlatAppearance.BorderSize = 0;
            this.btncloseform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseform.Image = global::CAPA_PRESENTACION.Properties.Resources.delete_remove_close_icon_1815331;
            this.btncloseform.Location = new System.Drawing.Point(88, 0);
            this.btncloseform.Name = "btncloseform";
            this.btncloseform.Size = new System.Drawing.Size(35, 44);
            this.btncloseform.TabIndex = 1;
            this.btncloseform.UseVisualStyleBackColor = true;
            this.btncloseform.Click += new System.EventHandler(this.btncloseform_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelmenu.AutoScroll = true;
            this.panelmenu.BackColor = System.Drawing.Color.White;
            this.panelmenu.Controls.Add(this.panelsubmenuinformes);
            this.panelmenu.Controls.Add(this.btninforme);
            this.panelmenu.Controls.Add(this.panelsubmenucita);
            this.panelmenu.Controls.Add(this.btncita);
            this.panelmenu.Controls.Add(this.panelsubmenuconsulta);
            this.panelmenu.Controls.Add(this.btnconsulta);
            this.panelmenu.Controls.Add(this.panelsubmenuexpe);
            this.panelmenu.Controls.Add(this.btnexpediente);
            this.panelmenu.Controls.Add(this.panel3);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 44);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(224, 741);
            this.panelmenu.TabIndex = 1;
            // 
            // panelsubmenuinformes
            // 
            this.panelsubmenuinformes.BackColor = System.Drawing.Color.White;
            this.panelsubmenuinformes.Controls.Add(this.btngenerarinfo);
            this.panelsubmenuinformes.Controls.Add(this.btnverinformes);
            this.panelsubmenuinformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenuinformes.Location = new System.Drawing.Point(0, 698);
            this.panelsubmenuinformes.Name = "panelsubmenuinformes";
            this.panelsubmenuinformes.Size = new System.Drawing.Size(207, 118);
            this.panelsubmenuinformes.TabIndex = 9;
            // 
            // btngenerarinfo
            // 
            this.btngenerarinfo.BackColor = System.Drawing.Color.White;
            this.btngenerarinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngenerarinfo.FlatAppearance.BorderSize = 0;
            this.btngenerarinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarinfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btngenerarinfo.Image = global::CAPA_PRESENTACION.Properties.Resources._3700408_archive_document_education_exam_file_test_108771;
            this.btngenerarinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngenerarinfo.Location = new System.Drawing.Point(0, 35);
            this.btngenerarinfo.Name = "btngenerarinfo";
            this.btngenerarinfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btngenerarinfo.Size = new System.Drawing.Size(207, 35);
            this.btngenerarinfo.TabIndex = 1;
            this.btngenerarinfo.Text = "Generar Informes";
            this.btngenerarinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngenerarinfo.UseVisualStyleBackColor = false;
            // 
            // btnverinformes
            // 
            this.btnverinformes.BackColor = System.Drawing.Color.White;
            this.btnverinformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnverinformes.FlatAppearance.BorderSize = 0;
            this.btnverinformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverinformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverinformes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnverinformes.Image = global::CAPA_PRESENTACION.Properties.Resources._3844476_eye_see_show_view_watch_110339;
            this.btnverinformes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnverinformes.Location = new System.Drawing.Point(0, 0);
            this.btnverinformes.Name = "btnverinformes";
            this.btnverinformes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnverinformes.Size = new System.Drawing.Size(207, 35);
            this.btnverinformes.TabIndex = 0;
            this.btnverinformes.Text = "Ver Informes";
            this.btnverinformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnverinformes.UseVisualStyleBackColor = false;
            // 
            // btninforme
            // 
            this.btninforme.BackColor = System.Drawing.Color.White;
            this.btninforme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninforme.FlatAppearance.BorderSize = 0;
            this.btninforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninforme.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninforme.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btninforme.Location = new System.Drawing.Point(0, 655);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(207, 43);
            this.btninforme.TabIndex = 8;
            this.btninforme.Text = "Informes";
            this.btninforme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninforme.UseVisualStyleBackColor = false;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // panelsubmenucita
            // 
            this.panelsubmenucita.BackColor = System.Drawing.Color.White;
            this.panelsubmenucita.Controls.Add(this.btnposponercita);
            this.panelsubmenucita.Controls.Add(this.btnagendarcitas);
            this.panelsubmenucita.Controls.Add(this.btnvercitas);
            this.panelsubmenucita.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenucita.Location = new System.Drawing.Point(0, 537);
            this.panelsubmenucita.Name = "panelsubmenucita";
            this.panelsubmenucita.Size = new System.Drawing.Size(207, 118);
            this.panelsubmenucita.TabIndex = 7;
            // 
            // btnposponercita
            // 
            this.btnposponercita.BackColor = System.Drawing.Color.White;
            this.btnposponercita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnposponercita.FlatAppearance.BorderSize = 0;
            this.btnposponercita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnposponercita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnposponercita.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnposponercita.Image = global::CAPA_PRESENTACION.Properties.Resources.twocirclingarrows_120593;
            this.btnposponercita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnposponercita.Location = new System.Drawing.Point(0, 70);
            this.btnposponercita.Name = "btnposponercita";
            this.btnposponercita.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnposponercita.Size = new System.Drawing.Size(207, 35);
            this.btnposponercita.TabIndex = 2;
            this.btnposponercita.Text = "Posponer Cita";
            this.btnposponercita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnposponercita.UseVisualStyleBackColor = false;
            // 
            // btnagendarcitas
            // 
            this.btnagendarcitas.BackColor = System.Drawing.Color.White;
            this.btnagendarcitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnagendarcitas.FlatAppearance.BorderSize = 0;
            this.btnagendarcitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagendarcitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagendarcitas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnagendarcitas.Image = global::CAPA_PRESENTACION.Properties.Resources.appointment_icon_179680;
            this.btnagendarcitas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagendarcitas.Location = new System.Drawing.Point(0, 35);
            this.btnagendarcitas.Name = "btnagendarcitas";
            this.btnagendarcitas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnagendarcitas.Size = new System.Drawing.Size(207, 35);
            this.btnagendarcitas.TabIndex = 1;
            this.btnagendarcitas.Text = "Agendar Citas";
            this.btnagendarcitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagendarcitas.UseVisualStyleBackColor = false;
            // 
            // btnvercitas
            // 
            this.btnvercitas.BackColor = System.Drawing.Color.White;
            this.btnvercitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvercitas.FlatAppearance.BorderSize = 0;
            this.btnvercitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvercitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvercitas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnvercitas.Image = ((System.Drawing.Image)(resources.GetObject("btnvercitas.Image")));
            this.btnvercitas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvercitas.Location = new System.Drawing.Point(0, 0);
            this.btnvercitas.Name = "btnvercitas";
            this.btnvercitas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnvercitas.Size = new System.Drawing.Size(207, 35);
            this.btnvercitas.TabIndex = 0;
            this.btnvercitas.Text = "Ver Citas";
            this.btnvercitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvercitas.UseVisualStyleBackColor = false;
            // 
            // btncita
            // 
            this.btncita.BackColor = System.Drawing.Color.White;
            this.btncita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncita.FlatAppearance.BorderSize = 0;
            this.btncita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncita.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncita.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btncita.Location = new System.Drawing.Point(0, 494);
            this.btncita.Name = "btncita";
            this.btncita.Size = new System.Drawing.Size(207, 43);
            this.btncita.TabIndex = 6;
            this.btncita.Text = "Cita";
            this.btncita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncita.UseVisualStyleBackColor = false;
            this.btncita.Click += new System.EventHandler(this.btncita_Click);
            // 
            // panelsubmenuconsulta
            // 
            this.panelsubmenuconsulta.BackColor = System.Drawing.Color.White;
            this.panelsubmenuconsulta.Controls.Add(this.btniniciarconsulta);
            this.panelsubmenuconsulta.Controls.Add(this.btnnuevaconsulta);
            this.panelsubmenuconsulta.Controls.Add(this.btnverconsulta);
            this.panelsubmenuconsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenuconsulta.Location = new System.Drawing.Point(0, 376);
            this.panelsubmenuconsulta.Name = "panelsubmenuconsulta";
            this.panelsubmenuconsulta.Size = new System.Drawing.Size(207, 118);
            this.panelsubmenuconsulta.TabIndex = 5;
            // 
            // btniniciarconsulta
            // 
            this.btniniciarconsulta.BackColor = System.Drawing.Color.White;
            this.btniniciarconsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btniniciarconsulta.FlatAppearance.BorderSize = 0;
            this.btniniciarconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciarconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarconsulta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btniniciarconsulta.Image = global::CAPA_PRESENTACION.Properties.Resources.login_square_arrow_button_outline_icon_icons_com_73220;
            this.btniniciarconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btniniciarconsulta.Location = new System.Drawing.Point(0, 70);
            this.btniniciarconsulta.Name = "btniniciarconsulta";
            this.btniniciarconsulta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btniniciarconsulta.Size = new System.Drawing.Size(207, 35);
            this.btniniciarconsulta.TabIndex = 2;
            this.btniniciarconsulta.Text = "Iniciar Consulta";
            this.btniniciarconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniniciarconsulta.UseVisualStyleBackColor = false;
            // 
            // btnnuevaconsulta
            // 
            this.btnnuevaconsulta.BackColor = System.Drawing.Color.White;
            this.btnnuevaconsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnuevaconsulta.FlatAppearance.BorderSize = 0;
            this.btnnuevaconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevaconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevaconsulta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnnuevaconsulta.Image = global::CAPA_PRESENTACION.Properties.Resources.newfile_85903;
            this.btnnuevaconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevaconsulta.Location = new System.Drawing.Point(0, 35);
            this.btnnuevaconsulta.Name = "btnnuevaconsulta";
            this.btnnuevaconsulta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnnuevaconsulta.Size = new System.Drawing.Size(207, 35);
            this.btnnuevaconsulta.TabIndex = 1;
            this.btnnuevaconsulta.Text = "Nueva Consulta";
            this.btnnuevaconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevaconsulta.UseVisualStyleBackColor = false;
            // 
            // btnverconsulta
            // 
            this.btnverconsulta.BackColor = System.Drawing.Color.White;
            this.btnverconsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnverconsulta.FlatAppearance.BorderSize = 0;
            this.btnverconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverconsulta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnverconsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnverconsulta.Image")));
            this.btnverconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnverconsulta.Location = new System.Drawing.Point(0, 0);
            this.btnverconsulta.Name = "btnverconsulta";
            this.btnverconsulta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnverconsulta.Size = new System.Drawing.Size(207, 35);
            this.btnverconsulta.TabIndex = 0;
            this.btnverconsulta.Text = "Ver Expediente";
            this.btnverconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnverconsulta.UseVisualStyleBackColor = false;
            // 
            // btnconsulta
            // 
            this.btnconsulta.BackColor = System.Drawing.Color.White;
            this.btnconsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconsulta.FlatAppearance.BorderSize = 0;
            this.btnconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsulta.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnconsulta.Location = new System.Drawing.Point(0, 333);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(207, 43);
            this.btnconsulta.TabIndex = 4;
            this.btnconsulta.Text = "Consulta";
            this.btnconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsulta.UseVisualStyleBackColor = false;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // panelsubmenuexpe
            // 
            this.panelsubmenuexpe.BackColor = System.Drawing.Color.White;
            this.panelsubmenuexpe.Controls.Add(this.btnbaja);
            this.panelsubmenuexpe.Controls.Add(this.btnnuevoexpe);
            this.panelsubmenuexpe.Controls.Add(this.btnverexpe);
            this.panelsubmenuexpe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenuexpe.Location = new System.Drawing.Point(0, 215);
            this.panelsubmenuexpe.Name = "panelsubmenuexpe";
            this.panelsubmenuexpe.Size = new System.Drawing.Size(207, 118);
            this.panelsubmenuexpe.TabIndex = 3;
            // 
            // btnbaja
            // 
            this.btnbaja.BackColor = System.Drawing.Color.White;
            this.btnbaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnbaja.FlatAppearance.BorderSize = 0;
            this.btnbaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaja.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnbaja.Image = global::CAPA_PRESENTACION.Properties.Resources.download_arrow_icon_143023;
            this.btnbaja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbaja.Location = new System.Drawing.Point(0, 70);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnbaja.Size = new System.Drawing.Size(207, 35);
            this.btnbaja.TabIndex = 2;
            this.btnbaja.Text = "Dar de baja";
            this.btnbaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbaja.UseVisualStyleBackColor = false;
            // 
            // btnnuevoexpe
            // 
            this.btnnuevoexpe.BackColor = System.Drawing.Color.White;
            this.btnnuevoexpe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnuevoexpe.FlatAppearance.BorderSize = 0;
            this.btnnuevoexpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevoexpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevoexpe.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnnuevoexpe.Image = global::CAPA_PRESENTACION.Properties.Resources.newfile_85903;
            this.btnnuevoexpe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevoexpe.Location = new System.Drawing.Point(0, 35);
            this.btnnuevoexpe.Name = "btnnuevoexpe";
            this.btnnuevoexpe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnnuevoexpe.Size = new System.Drawing.Size(207, 35);
            this.btnnuevoexpe.TabIndex = 1;
            this.btnnuevoexpe.Text = "Nuevo Expediente";
            this.btnnuevoexpe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevoexpe.UseVisualStyleBackColor = false;
            this.btnnuevoexpe.Click += new System.EventHandler(this.btnnuevoexpe_Click);
            // 
            // btnverexpe
            // 
            this.btnverexpe.BackColor = System.Drawing.Color.White;
            this.btnverexpe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnverexpe.FlatAppearance.BorderSize = 0;
            this.btnverexpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverexpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverexpe.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnverexpe.Image = global::CAPA_PRESENTACION.Properties.Resources._3844476_eye_see_show_view_watch_110339;
            this.btnverexpe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnverexpe.Location = new System.Drawing.Point(0, 0);
            this.btnverexpe.Name = "btnverexpe";
            this.btnverexpe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnverexpe.Size = new System.Drawing.Size(207, 35);
            this.btnverexpe.TabIndex = 0;
            this.btnverexpe.Text = "Ver expediente";
            this.btnverexpe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnverexpe.UseVisualStyleBackColor = false;
            this.btnverexpe.Click += new System.EventHandler(this.btnverexpe_Click);
            // 
            // btnexpediente
            // 
            this.btnexpediente.BackColor = System.Drawing.Color.White;
            this.btnexpediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnexpediente.FlatAppearance.BorderSize = 0;
            this.btnexpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexpediente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexpediente.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnexpediente.Location = new System.Drawing.Point(0, 172);
            this.btnexpediente.Name = "btnexpediente";
            this.btnexpediente.Size = new System.Drawing.Size(207, 43);
            this.btnexpediente.TabIndex = 2;
            this.btnexpediente.Text = "Expediente";
            this.btnexpediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexpediente.UseVisualStyleBackColor = false;
            this.btnexpediente.Click += new System.EventHandler(this.btnexpediente_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::CAPA_PRESENTACION.Properties.Resources.human_brain_psychiatrist_icon_131296;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 172);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.monthCalendar1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(224, 571);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 214);
            this.panel4.TabIndex = 2;
            this.panel4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(248, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // panelFormhijo
            // 
            this.panelFormhijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormhijo.AutoScroll = true;
            this.panelFormhijo.AutoScrollMargin = new System.Drawing.Size(450, 450);
            this.panelFormhijo.AutoScrollMinSize = new System.Drawing.Size(450, 450);
            this.panelFormhijo.AutoSize = true;
            this.panelFormhijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFormhijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFormhijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormhijo.ForeColor = System.Drawing.Color.White;
            this.panelFormhijo.Location = new System.Drawing.Point(224, 44);
            this.panelFormhijo.Name = "panelFormhijo";
            this.panelFormhijo.Size = new System.Drawing.Size(768, 521);
            this.panelFormhijo.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 785);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelFormhijo);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelmenu.ResumeLayout(false);
            this.panelsubmenuinformes.ResumeLayout(false);
            this.panelsubmenucita.ResumeLayout(false);
            this.panelsubmenuconsulta.ResumeLayout(false);
            this.panelsubmenuexpe.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncloseform;
        private System.Windows.Forms.Button btnresform;
        private System.Windows.Forms.Button btnmaxform;
        private System.Windows.Forms.Button btnminform;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelsubmenuconsulta;
        private System.Windows.Forms.Button btniniciarconsulta;
        private System.Windows.Forms.Button btnnuevaconsulta;
        private System.Windows.Forms.Button btnverconsulta;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Panel panelsubmenuexpe;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.Button btnnuevoexpe;
        private System.Windows.Forms.Button btnverexpe;
        private System.Windows.Forms.Button btnexpediente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelsubmenuinformes;
        private System.Windows.Forms.Button btngenerarinfo;
        private System.Windows.Forms.Button btnverinformes;
        private System.Windows.Forms.Button btninforme;
        private System.Windows.Forms.Panel panelsubmenucita;
        private System.Windows.Forms.Button btnposponercita;
        private System.Windows.Forms.Button btnagendarcitas;
        private System.Windows.Forms.Button btnvercitas;
        private System.Windows.Forms.Button btncita;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelFormhijo;
    }
}