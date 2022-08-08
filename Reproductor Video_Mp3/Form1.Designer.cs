namespace Reproductor_Video_Mp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2Volumen = new System.Windows.Forms.TrackBar();
            this.trackBar1Duracion = new System.Windows.Forms.TrackBar();
            this.btnVolumen = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.Play_Pause = new System.Windows.Forms.Button();
            this.tmSlider = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.VideoPlay = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2Volumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1Duracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproductorToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // reproductorToolStripMenuItem
            // 
            this.reproductorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pausaToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.reproductorToolStripMenuItem.Name = "reproductorToolStripMenuItem";
            this.reproductorToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.reproductorToolStripMenuItem.Text = "Reproductor";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // pausaToolStripMenuItem
            // 
            this.pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            this.pausaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pausaToolStripMenuItem.Text = "Pausa";
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar2Volumen);
            this.panel1.Controls.Add(this.trackBar1Duracion);
            this.panel1.Controls.Add(this.btnVolumen);
            this.panel1.Controls.Add(this.btnL);
            this.panel1.Controls.Add(this.btnR);
            this.panel1.Controls.Add(this.Play_Pause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 133);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(887, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(959, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "0:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "0:00";
            // 
            // trackBar2Volumen
            // 
            this.trackBar2Volumen.Location = new System.Drawing.Point(887, 1);
            this.trackBar2Volumen.Maximum = 100;
            this.trackBar2Volumen.Name = "trackBar2Volumen";
            this.trackBar2Volumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2Volumen.Size = new System.Drawing.Size(45, 104);
            this.trackBar2Volumen.TabIndex = 5;
            this.trackBar2Volumen.Visible = false;
            this.trackBar2Volumen.Scroll += new System.EventHandler(this.trackBar2Volumen_Scroll);
            this.trackBar2Volumen.ValueChanged += new System.EventHandler(this.trackBar2Volumen_ValueChanged);
            this.trackBar2Volumen.MouseLeave += new System.EventHandler(this.trackBar2Volumen_MouseLeave);
            // 
            // trackBar1Duracion
            // 
            this.trackBar1Duracion.Location = new System.Drawing.Point(0, 0);
            this.trackBar1Duracion.Name = "trackBar1Duracion";
            this.trackBar1Duracion.Size = new System.Drawing.Size(1008, 45);
            this.trackBar1Duracion.TabIndex = 4;
            this.trackBar1Duracion.ValueChanged += new System.EventHandler(this.trackBar1Duracion_ValueChanged);
            // 
            // btnVolumen
            // 
            this.btnVolumen.BackgroundImage = global::Reproductor_Video_Mp3.Properties.Resources.Volumen;
            this.btnVolumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolumen.FlatAppearance.BorderSize = 0;
            this.btnVolumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumen.Location = new System.Drawing.Point(823, 71);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(58, 51);
            this.btnVolumen.TabIndex = 3;
            this.btnVolumen.UseVisualStyleBackColor = true;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // btnL
            // 
            this.btnL.BackgroundImage = global::Reproductor_Video_Mp3.Properties.Resources.BotonL;
            this.btnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnL.FlatAppearance.BorderSize = 0;
            this.btnL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Location = new System.Drawing.Point(395, 58);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(62, 55);
            this.btnL.TabIndex = 2;
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnR
            // 
            this.btnR.BackgroundImage = global::Reproductor_Video_Mp3.Properties.Resources.BotonR;
            this.btnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnR.FlatAppearance.BorderSize = 0;
            this.btnR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Location = new System.Drawing.Point(559, 57);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(62, 55);
            this.btnR.TabIndex = 1;
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // Play_Pause
            // 
            this.Play_Pause.BackgroundImage = global::Reproductor_Video_Mp3.Properties.Resources.Play;
            this.Play_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_Pause.FlatAppearance.BorderSize = 0;
            this.Play_Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Play_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_Pause.Location = new System.Drawing.Point(463, 48);
            this.Play_Pause.Name = "Play_Pause";
            this.Play_Pause.Size = new System.Drawing.Size(90, 73);
            this.Play_Pause.TabIndex = 0;
            this.Play_Pause.UseVisualStyleBackColor = true;
            this.Play_Pause.Click += new System.EventHandler(this.Play_Pause_Click);
            // 
            // tmSlider
            // 
            this.tmSlider.Tick += new System.EventHandler(this.tmSlider_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // VideoPlay
            // 
            this.VideoPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoPlay.Enabled = true;
            this.VideoPlay.Location = new System.Drawing.Point(0, 24);
            this.VideoPlay.Name = "VideoPlay";
            this.VideoPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlay.OcxState")));
            this.VideoPlay.Size = new System.Drawing.Size(1008, 420);
            this.VideoPlay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VideoPlay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2Volumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1Duracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2Volumen;
        private System.Windows.Forms.TrackBar trackBar1Duracion;
        private System.Windows.Forms.Button btnVolumen;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button Play_Pause;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlay;
        private System.Windows.Forms.Timer tmSlider;
        private System.Windows.Forms.Label label4;
    }
}

