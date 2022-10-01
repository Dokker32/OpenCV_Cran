using System;
using System.Windows.Forms;
using Emgu.CV;
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
            Image<Gray, byte> imgCanny = new Image<Gray, byte>(ImgInput.Width, ImgInput.Height, new Gray(0));
            imgCanny = ImgInput.Canny(Convert.ToDouble(trackBar1.Value), Convert.ToDouble(trackBar2.Value));
            pictureBox2.Image = imgCanny.ToBitmap();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"JPG|*.jpg" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
           label2.Text = trackBar2.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
