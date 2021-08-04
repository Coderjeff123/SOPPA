
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminform = new System.Windows.Forms.Button();
            this.btnresform = new System.Windows.Forms.Button();
            this.btnmaxform = new System.Windows.Forms.Button();
            this.btncloseform = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnminform);
            this.panel1.Controls.Add(this.btnresform);
            this.panel1.Controls.Add(this.btnmaxform);
            this.panel1.Controls.Add(this.btncloseform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnminform
            // 
            this.btnminform.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnminform.FlatAppearance.BorderSize = 0;
            this.btnminform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminform.Image = global::CAPA_PRESENTACION.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.btnminform.Location = new System.Drawing.Point(703, 0);
            this.btnminform.Name = "btnminform";
            this.btnminform.Size = new System.Drawing.Size(38, 41);
            this.btnminform.TabIndex = 6;
            this.btnminform.UseVisualStyleBackColor = true;
            this.btnminform.Visible = false;
            // 
            // btnresform
            // 
            this.btnresform.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnresform.FlatAppearance.BorderSize = 0;
            this.btnresform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresform.Image = global::CAPA_PRESENTACION.Properties.Resources.window_restore_icon_144027;
            this.btnresform.Location = new System.Drawing.Point(741, 0);
            this.btnresform.Name = "btnresform";
            this.btnresform.Size = new System.Drawing.Size(38, 41);
            this.btnresform.TabIndex = 4;
            this.btnresform.UseVisualStyleBackColor = true;
            this.btnresform.Visible = false;
            // 
            // btnmaxform
            // 
            this.btnmaxform.FlatAppearance.BorderSize = 0;
            this.btnmaxform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaxform.Image = global::CAPA_PRESENTACION.Properties.Resources.gui_form_checkbox_icon_157650;
            this.btnmaxform.Location = new System.Drawing.Point(727, 0);
            this.btnmaxform.Name = "btnmaxform";
            this.btnmaxform.Size = new System.Drawing.Size(38, 36);
            this.btnmaxform.TabIndex = 5;
            this.btnmaxform.UseVisualStyleBackColor = true;
            this.btnmaxform.Visible = false;
            // 
            // btncloseform
            // 
            this.btncloseform.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncloseform.FlatAppearance.BorderSize = 0;
            this.btncloseform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseform.Image = global::CAPA_PRESENTACION.Properties.Resources.closewindowapplication_cerca_ventan_2874;
            this.btncloseform.Location = new System.Drawing.Point(779, 0);
            this.btncloseform.Name = "btncloseform";
            this.btncloseform.Size = new System.Drawing.Size(35, 41);
            this.btncloseform.TabIndex = 1;
            this.btncloseform.UseVisualStyleBackColor = true;
            this.btncloseform.Click += new System.EventHandler(this.btncloseform_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 612);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncloseform;
        private System.Windows.Forms.Button btnresform;
        private System.Windows.Forms.Button btnmaxform;
        private System.Windows.Forms.Button btnminform;
    }
}