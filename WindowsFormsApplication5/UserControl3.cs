using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WMPLib;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace WindowsFormsApplication5
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3*|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.axWindowsMediaPlayer1.URL = ofd.FileName;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }

                button1.Hide();

                label2.Text = "Title: " +  axWindowsMediaPlayer1.currentMedia.name;// name of video

                var player = new WindowsMediaPlayer();
                var clip = player.newMedia(ofd.FileName);
                label3.Text = "Length: " + TimeSpan.FromSeconds(clip.duration).ToString(); // length of video

                var ffMpeg = new NReco.VideoConverter.FFMpegConverter();

                string namepicture = axWindowsMediaPlayer1.currentMedia.name + ".jpg";
                ffMpeg.GetVideoThumbnail(ofd.FileName, namepicture); // using FFMPEG to take first photo of video

              
                pictureBox1.Image = Image.FromFile(namepicture); // saving picture into pictureBox

            }

            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
        }

    }
}
