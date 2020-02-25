using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace TryTryTry_
{
    public partial class Alphabet : Form
    {
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();

        public Alphabet()
        {
            InitializeComponent();
            SpeechSynthesizer reader = new SpeechSynthesizer();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Alphabet_Load(object sender, EventArgs e)
        {

        }

        private void PlayBttn_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaPictureBox1_Click_1(object sender, EventArgs e)
        {
            
                
        }

        private void BttnA_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer A = new SpeechSynthesizer();
            A.Speak("A is for Apple");
        }

        private void BttnB_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer B = new SpeechSynthesizer();
            B.Speak("B is for Ball");
        }
    }
}
