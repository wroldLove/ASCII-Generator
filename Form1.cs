using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figgle;

namespace ASCII_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || textBox2.Text == string.Empty) { return; }
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Text = FiggleFonts.Graffiti.Render(textBox2.Text);
                    break;
                case 1:
                    textBox1.Text = FiggleFonts.ThreePoint.Render(textBox2.Text);
                    break;
                case 2:
                    textBox1.Text = FiggleFonts.Ogre.Render(textBox2.Text);
                    break;
                case 3:
                    textBox1.Text = FiggleFonts.Rectangles.Render(textBox2.Text);
                    break;
                case 4:
                    textBox1.Text = FiggleFonts.Slant.Render(textBox2.Text);
                    break;
                case 5:
                    textBox1.Text = FiggleFonts.Chunky.Render(textBox2.Text);
                    break;
                case 6:
                    textBox1.Text = FiggleFonts.Big.Render(textBox2.Text);
                    break;
                case 7:
                    textBox1.Text = FiggleFonts.Binary.Render(textBox2.Text);
                    break;
                case 8:
                    textBox1.Text = FiggleFonts.Doom.Render(textBox2.Text);
                    break;
                case 9:
                    textBox1.Text = FiggleFonts.Stop.Render(textBox2.Text);
                    break;
                case 10:
                    textBox1.Text = FiggleFonts.Starwars.Render(textBox2.Text);
                    break;
                case 11:
                    textBox1.Text = FiggleFonts.Standard.Render(textBox2.Text);
                    break;
                case 12:
                    textBox1.Text = FiggleFonts.Speed.Render(textBox2.Text);
                    break;
                case 13:
                    textBox1.Text = FiggleFonts.SlantSmall.Render(textBox2.Text);
                    break;
                case 14:
                    textBox1.Text = FiggleFonts.Keyboard.Render(textBox2.Text);
                    break;
                case 15:
                    textBox1.Text = FiggleFonts.Small.Render(textBox2.Text);
                    break;
                case 16:
                    textBox1.Text = FiggleFonts.Script.Render(textBox2.Text);
                    break;
                case 17:
                    textBox1.Text = FiggleFonts.Rectangles.Render(textBox2.Text);
                    break;
                case 18:
                    textBox1.Text = FiggleFonts.Pepper.Render(textBox2.Text);
                    break;
                case 19:
                    textBox1.Text = FiggleFonts.Mirror.Render(textBox2.Text);
                    break;
                case 20:
                    textBox1.Text = FiggleFonts.Larry3d.Render(textBox2.Text);
                    break;
                case 21:
                    textBox1.Text = FiggleFonts.Invita.Render(textBox2.Text);
                    break;
                case 22:
                    textBox1.Text = FiggleFonts.EftiPiti.Render(textBox2.Text);
                    break;
                case 23:
                    textBox1.Text = FiggleFonts.DRPepper.Render(textBox2.Text);
                    break;
                case 24:
                    textBox1.Text = FiggleFonts.Bulbhead.Render(textBox2.Text);
                    break;
            }
        }
    }
}
