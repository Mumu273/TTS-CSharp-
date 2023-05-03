using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer speech;
        public Form1()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                speech.SpeakAsync(richTextBox1.Text);
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                speech.SpeakAsync("Escape");   
            }

            if (e.KeyCode == Keys.Tab)
            {
                speech.SpeakAsync("Tab");
            }

            if (e.KeyCode == Keys.CapsLock)
            {
                speech.SpeakAsync("CapsLock");
            }

            if (e.KeyCode == Keys.ShiftKey) 
            {
                speech.SpeakAsync("Shift");
            }

            if (e.KeyCode == Keys.ControlKey)
            {
                speech.SpeakAsync("Control");
            }

            if (e.KeyCode == Keys.LWin)
            {
                speech.SpeakAsync("Windows");
            }

            if (e.KeyCode == Keys.Menu)
            {
                speech.SpeakAsync("Alt");
            }

            if (e.KeyCode == Keys.Space)
            {
                speech.SpeakAsync("Space");
            }

            if (e.KeyCode == Keys.Back)
            {
                speech.SpeakAsync("BackSpace");
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (Char)Keys.A)
            {
                speech.SpeakAsync("A");
            }

            if (e.KeyChar == (Char)Keys.B)
            {
                speech.SpeakAsync("B");
            }

            if (e.KeyChar == (Char)Keys.C)
            {
                speech.SpeakAsync("C");
            }

            if (e.KeyChar == (Char)Keys.D)
            {
                speech.SpeakAsync("D");
            }

            if (e.KeyChar == (Char)Keys.E)
            {
                speech.SpeakAsync("E");
            }

            if (e.KeyChar == (Char)Keys.F)
            {
                speech.SpeakAsync("F");
            }

            if (e.KeyChar == (Char)Keys.G)
            {
                speech.SpeakAsync("G");
            }

            if (e.KeyChar == (Char)Keys.H)
            {
                speech.SpeakAsync("H");
            }

            if (e.KeyChar == (Char)Keys.I)
            {
                speech.SpeakAsync("I");
            }

            if (e.KeyChar == (Char)Keys.J)
            {
                speech.SpeakAsync("J");
            }

            if (e.KeyChar == (Char)Keys.K)
            {
                speech.SpeakAsync("K");
            }

            if (e.KeyChar == (Char)Keys.L)
            {
                speech.SpeakAsync("L");
            }

            if (e.KeyChar == (Char)Keys.M)
            {
                speech.SpeakAsync("M");
            }

            if (e.KeyChar == (Char)Keys.N)
            {
                speech.SpeakAsync("N");
            }

            if (e.KeyChar == (Char)Keys.O)
            {
                speech.SpeakAsync("O");
            }

            if (e.KeyChar == (Char)Keys.P)
            {
                speech.SpeakAsync("P");
            }

            if (e.KeyChar == (Char)Keys.Q)
            {
                speech.SpeakAsync("Q");
            }

            if (e.KeyChar == (Char)Keys.R)
            {
                speech.SpeakAsync("R");
            }

            if (e.KeyChar == (Char)Keys.S)
            {
                speech.SpeakAsync("S");
            }

            if (e.KeyChar == (Char)Keys.T)
            {
                speech.SpeakAsync("T");
            }

            if (e.KeyChar == (Char)Keys.U)
            {
                speech.SpeakAsync("U");
            }

            if (e.KeyChar == (Char)Keys.V)
            {
                speech.SpeakAsync("V");
            }

            if (e.KeyChar == (Char)Keys.W)
            {
                speech.SpeakAsync("W");
            }

            if (e.KeyChar == (Char)Keys.X)
            {
                speech.SpeakAsync("X");
            }

            if (e.KeyChar == (Char)Keys.Y)
            {
                speech.SpeakAsync("Y");
            }

            if (e.KeyChar == (Char)Keys.Z)
            {
                speech.SpeakAsync("Z");
            }

        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            

        }
    }
}
