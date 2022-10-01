using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace OpenCV_Cran
{
    public partial class Form1 : Form
    {
        Image<Bgra, byte> ImgInput;
        public Form1()
        {
            InitializeComponent();
           

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImgInput = new Image<Bgra, byte>(ofd.FileName);
                pictureBox1.Image = ImgInput.ToBitmap();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> _imgCanny = new Image<Gray, byte>(ImgInput.Width, ImgInput.Height, new Gray(0));
            _imgCanny = ImgInput.Canny(20, 50);
            pictureBox2.Image = _imgCanny.ToBitmap();

        }
    }
}
