using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private SoundPlayer hohoho;
        private SoundPlayer meow;
        private SoundPlayer purr;
        private SoundPlayer knock;

        public Form1()
        {
            InitializeComponent();

            media.URL = @"christmas.wav";
            media.settings.playCount = 9999;
            media.Ctlcontrols.play();
            media.Visible = false;
            media.settings.volume = 1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hohoho = new SoundPlayer(@"hohoho.wav");
            hohoho.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            meow = new SoundPlayer(@"meow.wav");
            meow.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            purr = new SoundPlayer(@"purr.wav");
            purr.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            knock = new SoundPlayer(@"knock.wav");
            knock.Play();
        }
    }
}
