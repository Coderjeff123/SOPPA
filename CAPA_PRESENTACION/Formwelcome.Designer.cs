
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.paneldegradado3 = new CAPA_PRESENTACION.Paneldegradado();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.paneldegradado2 = new CAPA_PRESENTACION.Paneldegradado();
            this.paneldegradado4 = new CAPA_PRESENTACION.Paneldegradado();
            this.paneldegradado1 = new CAPA_PRESENTACION.Paneldegradado();
            this.label1 = new System.Windows.Forms.Label();
            this.paneldegradado3.SuspendLayout();
            this.paneldegradado2.SuspendLayout();
            this.paneldegradado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // paneldegradado3
            // 
            this.paneldegradado3.angulo = 0F;
            this.paneldegradado3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.paneldegradado3.Colorleft = System.Drawing.Color.Empty;
            this.paneldegradado3.Colorrigth = System.Drawing.Color.Empty;
            this.paneldegradado3.Controls.Add(this.circularProgressBar1);
            this.paneldegradado3.Controls.Add(this.label2);
            this.paneldegradado3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldegradado3.Location = new System.Drawing.Point(321, 57);
            this.paneldegradado3.Name = "paneldegradado3";
            this.paneldegradado3.Size = new System.Drawing.Size(479, 400);
            this.paneldegradado3.TabIndex = 2;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseOut;
            this.circularProgressBar1.AnimationSpeed = 600;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.Window;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(285, 98);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.SteelBlue;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(148, 136);
            this.circularProgressBar1.StartAngle = 200;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(8, 25, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 6;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome";
            // 
            // paneldegradado2
            // 
            this.paneldegradado2.angulo = 0F;
            this.paneldegradado2.BackColor = System.Drawing.Color.Black;
            this.paneldegradado2.Colorleft = System.Drawing.Color.Black;
            this.paneldegradado2.Colorrigth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paneldegradado2.Controls.Add(this.paneldegradado4);
            this.paneldegradado2.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldegradado2.Location = new System.Drawing.Point(0, 57);
            this.paneldegradado2.Name = "paneldegradado2";
            this.paneldegradado2.Size = new System.Drawing.Size(321, 400);
            this.paneldegradado2.TabIndex = 1;
            // 
            // paneldegradado4
            // 
            this.paneldegradado4.angulo = 0F;
            this.paneldegradado4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.paneldegradado4.BackgroundImage = global::CAPA_PRESENTACION.Properties.Resources.pngtree_brain_technology_code_digital_image_6990;
            this.paneldegradado4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paneldegradado4.Colorleft = System.Drawing.Color.Empty;
            this.paneldegradado4.Colorrigth = System.Drawing.Color.Empty;
            this.paneldegradado4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldegradado4.Location = new System.Drawing.Point(0, 0);
            this.paneldegradado4.Name = "paneldegradado4";
            this.paneldegradado4.Size = new System.Drawing.Size(321, 400);
            this.paneldegradado4.TabIndex = 0;
            // 
            // paneldegradado1
            // 
            this.paneldegradado1.angulo = 0F;
            this.paneldegradado1.BackColor = System.Drawing.Color.Transparent;
            this.paneldegradado1.Colorleft = System.Drawing.Color.Black;
            this.paneldegradado1.Colorrigth = System.Drawing.Color.DimGray;
            this.paneldegradado1.Controls.Add(this.label1);
            this.paneldegradado1.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldegradado1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldegradado1.Location = new System.Drawing.Point(0, 0);
            this.paneldegradado1.Name = "paneldegradado1";
            this.paneldegradado1.Size = new System.Drawing.Size(800, 57);
            this.paneldegradado1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Psychology System";
            // 
            // Formwelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.paneldegradado3);
            this.Controls.Add(this.paneldegradado2);
            this.Controls.Add(this.paneldegradado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formwelcome";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formwelcome";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Formwelcome_Load);
            this.paneldegradado3.ResumeLayout(false);
            this.paneldegradado3.PerformLayout();
            this.paneldegradado2.ResumeLayout(false);
            this.paneldegradado1.ResumeLayout(false);
            this.paneldegradado1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Paneldegradado paneldegradado1;
        private Paneldegradado paneldegradado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private Paneldegradado paneldegradado3;
        private Paneldegradado paneldegradado4;
    }
}