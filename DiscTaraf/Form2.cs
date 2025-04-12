using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace DiscTaraf
{

    public partial class Form2 : Form
    {
        private Dictionary<string, string> obiecteImagini = new Dictionary<string, string>();
        private Dictionary<string, string> obiecteSunet = new Dictionary<string, string>();
        private SoundPlayer currentPlayer = null;
        StreamReader streamReader = new StreamReader(path: "fisier1.txt");
        private int currentIndex = 0;
        private WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        private double currentPosition = 0;
        private Timer progressTimer = new Timer();
        private Timer rotateTimer = new Timer();
        private float angle = 0;
        private Image originalImage = null;


        public Form2()
        {
            InitializeComponent();
            play_btn.Text = ("▶");
            rotateTimer.Interval = 50;
            rotateTimer.Tick += RotateCD;
            rotateTimer.Start();
            if (!File.Exists("fisier1.txt"))
            {
                MessageBox.Show("Fișierul nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (File.Exists("fisier1.txt"))
            {
                string[] line = File.ReadAllLines("fisier1.txt");
                listaPiese.Items.AddRange(line);
            }
            obiecteImagini.Add("Deti Iuga", "D:\\Download\\Deti iuga.jpg");
            obiecteImagini.Add("Ghita Munteanu", "D:\\Download\\Ghita munteanu.jpg");

            obiecteSunet.Add("Nu is om rau da ma pot face", "D:\\Download\\Deti Iuga și Ioan Marcu - Nu-s om rău, dar mă pot face ｜｜ Videoclip Oficial.wav");
            obiecteSunet.Add("Tinere cu par carunt", "D:\\Download\\1742145801.9533477_ytshorts.savetube.me.wav");
            obiecteSunet.Add("La manastire de lemn", "D:\\Download\\La Mânăstire De Lemn.wav");
            obiecteSunet.Add("Diamantul vietii mele", "D:\\Download\\Ghita Munteanu - Diamantul vietii mele  - DVD - Diamantul vietii mele.wav");
            progressTimer.Interval = 500;
            progressTimer.Tick += timer1_Tick;
            mediaPlayer.settings.volume = volume_Control.Value;

        }



        private void listaPiese_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLine = listaPiese.SelectedItem.ToString();
            if (listaPiese.SelectedItem != null)
            {
                numePiesasiArtist.Text = listaPiese.SelectedItem.ToString();
            }
            string[] selectedParts = selectedLine.Split('-');
            if (selectedParts.Length == 2)
            {
                string artistSelectat = selectedParts[0].Trim();
                string piesaSelectata = selectedParts[1].Trim();

                if (obiecteImagini.ContainsKey(artistSelectat))
                {
                    string imaginePath = obiecteImagini[artistSelectat];
                    if (File.Exists(imaginePath))
                    {
                        pozaCover.SizeMode = PictureBoxSizeMode.Zoom;
                        originalImage = CropToCircle(Image.FromFile(imaginePath)); // Stocăm imaginea originală
                        pozaCover.Image = originalImage;
                    }
                    else
                    {
                        MessageBox.Show("Nu a fost gasita imaginea");


                    }
                }
            }
        }

        private void pozaCover_Click(object sender, EventArgs e)
        {

        }

        private void numePiesasiArtist_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            currentPosition = 0;

            if (listaPiese.SelectedIndex != -1)
            {
                int prevIndex = listaPiese.SelectedIndex - 1;
                if (prevIndex < 0)
                {
                    prevIndex = listaPiese.Items.Count - 1;

                }
                listaPiese.SelectedIndex = prevIndex;
                play_btn_Click(sender, e);

            }
        }
        private void MediaPlayer_PlayStateChange(int newState)
        {

            if (newState == (int)WMPPlayState.wmppsStopped)
            {
                currentPosition = 0;
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {

            string selectedLine = listaPiese.SelectedItem.ToString();
            string[] selectedParts = selectedLine.Split('-');
            if (selectedParts.Length == 2)
            {
                string piesaSelectata = selectedParts[1].Trim();
                if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
                {
                    rotateTimer.Stop();
                    currentPosition = mediaPlayer.controls.currentPosition;
                    mediaPlayer.controls.pause();
                    play_btn.Text = ("▶");
                    progressTimer.Stop();

                }
                else
                {
                    if ((obiecteSunet.ContainsKey(piesaSelectata)))
                    {
                        string soundPath = obiecteSunet[piesaSelectata];
                        if (File.Exists(soundPath))
                        {
                            if (mediaPlayer.URL != soundPath)
                            {
                                currentPosition = 0;
                                progressBar.Value = 0;
                            }
                            rotateTimer.Start();
                            mediaPlayer.URL = soundPath;
                            mediaPlayer.controls.currentPosition = currentPosition;
                            mediaPlayer.controls.play();
                            play_btn.Text = ("||");
                            progressTimer.Start();
                              
                        }
                        else
                        {
                            MessageBox.Show("Nu a fost gasita piesa");

                        }


                    }
                }
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            play_btn.Text = ("||");
            currentPosition = 0;
            progressBar.Value = 0;
            if (listaPiese.SelectedIndex != -1)
            {

                int nextIndex = listaPiese.SelectedIndex + 1;


                if (nextIndex >= listaPiese.Items.Count)
                {
                    nextIndex = 0;
                }
                listaPiese.SelectedIndex = nextIndex;
                play_btn_Click(sender, e);


            }
        }




        private void volume_Control_Scroll(object sender, EventArgs e)
        {
            mediaPlayer.settings.volume = volume_Control.Value;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StyleButton(back_btn);
            StyleButton(play_btn);
            StyleButton(next_btn);
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                currentPosition = mediaPlayer.controls.currentPosition;
                double duration = mediaPlayer.currentMedia?.duration ?? 0;

                if (duration > 0)
                {
                    int progress = (int)((currentPosition / duration) * 100);
                    progressBar.Value = progress;
                }
            }

        }

        private void progressBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (mediaPlayer.currentMedia != null)
            {
                double duration = mediaPlayer.currentMedia.duration;
                if (duration > 0)
                {
                    double clickPosition = (double)e.X / progressBar.Width;
                    double newTime = duration * clickPosition;
                    mediaPlayer.controls.currentPosition = newTime;
                    progressBar.Value = (int)((newTime / duration) * 100);
                }
            }
        }
        private Bitmap CropToCircle(Image srcImage)
        {
            int size = Math.Min(srcImage.Width, srcImage.Height);
            Bitmap bmp = new Bitmap(size, size);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, size, size);
                    g.SetClip(path);
                    g.DrawImage(srcImage, 0, 0, size, size);
                }
            }
            return bmp;
        }
        private void RotateCD(object sender, EventArgs e)
        {
            if (pozaCover.Image != null)
            {
                angle += (float)0.1; // Crește unghiul de rotație
                if (angle >= 360) angle = 0; // Resetare unghi

                Bitmap rotatedImage = new Bitmap(pozaCover.Image.Width, pozaCover.Image.Height);
                using (Graphics g = Graphics.FromImage(rotatedImage))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.TranslateTransform(rotatedImage.Width / 2, rotatedImage.Height / 2);
                    g.RotateTransform(angle);
                    g.TranslateTransform(-rotatedImage.Width / 2, -rotatedImage.Height / 2);
                    g.DrawImage(originalImage, new Point(0, 0));
                }

                pozaCover.Image = rotatedImage;
            }
        }
        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(70, 70, 70);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
       
}
