using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_Video_Mp3
{
    public partial class Form1 : Form
    {
        int vl = 50;
        public OpenFileDialog archivo = new OpenFileDialog();
        int play = 0;
        private string ruta = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Play_Pause_Click(object sender, EventArgs e)
        {
            if (play == 1)
            {
                AbrirMusica();
                play = 2;
            }
            else if (play == 2)
            {
                VideoPlay.Ctlcontrols.pause();
                tmSlider.Stop();

                Play_Pause.BackgroundImage = Properties.Resources.Play;
                play = 3;
            }
            else if (play == 3)
            {
                VideoPlay.Ctlcontrols.play();
                tmSlider.Start();

                Play_Pause.BackgroundImage = Properties.Resources.Pausa;
                play = 2;
            }
        }
        
        public void AbrirMusica()
        {

            try
            {

                VideoPlay.URL = @"" + ruta;
                VideoPlay.Ctlcontrols.play();

                this.Visible = true;
                tmSlider.Start();

                trackBar1Duracion.Enabled = true;

                Play_Pause.BackgroundImage = Properties.Resources.Pausa;

            }
            catch
            {


            }


        }

        private void trackBar2Volumen_Scroll(object sender, EventArgs e)
        {

        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            trackBar2Volumen.Visible = true;
        }

        private void trackBar2Volumen_MouseLeave(object sender, EventArgs e)
        {
            trackBar2Volumen.Visible = true;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if ((trackBar1Duracion.Value = trackBar1Duracion.Value - 15) < 0)
            {
                trackBar1Duracion.Value = 0;
            }
            else
            {
                trackBar1Duracion.Value = trackBar1Duracion.Value - 15;
            }
        }

        private void trackBar1Duracion_ValueChanged(object sender, EventArgs e)
        {
            trackBar1Duracion.Maximum = (int)VideoPlay.currentMedia.duration;

            if (trackBar1Duracion.Value == (int)VideoPlay.Ctlcontrols.currentPosition)
            {

            }
            else
            {

                VideoPlay.Ctlcontrols.currentPosition = trackBar1Duracion.Value;

            }
        }

        private void tmSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                trackBar1Duracion.Value = (int)VideoPlay.Ctlcontrols.currentPosition;
                label1.Text = VideoPlay.Ctlcontrols.currentPositionString;
                label2.Text = VideoPlay.currentMedia.durationString;
            }
            catch
            {


            }
        }

        public void AbrirArchivo()
        {

            archivo.Filter = "Archivo files|*.mp3;*.mp4;.*;";
            DialogResult dres1 = archivo.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            ruta = archivo.FileName;
            label4.Text = archivo.SafeFileName;


        }

        private void btnR_Click(object sender, EventArgs e)
        {
            trackBar1Duracion.Value = trackBar1Duracion.Value + 10;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirArchivo();

                if (ruta != "")
                {
                    play = 2;
                    AbrirMusica();

                }
                else
                {

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void trackBar2Volumen_ValueChanged(object sender, EventArgs e)
        {
            VideoPlay.settings.volume = trackBar2Volumen.Value;



            label3.Text = VideoPlay.settings.volume.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = (trackBar2Volumen.Value = VideoPlay.settings.volume = vl).ToString();
            this.VideoPlay.uiMode = "none";
        }
    }
}
