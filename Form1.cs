using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Rood__Letterfrequentie
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void bOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;

            int[] ArrayInt = new int[(int)char.MaxValue];

            string FileInfo = File.ReadAllText(textBox1.Text);
            
            foreach (char L in FileInfo)
            {
                ArrayInt[(int)L]++;
            }

            for (int i = 0; i < (int)char.MaxValue ; i++)
            {
                if (ArrayInt[i] > 0)
                {
                    string CharValueInfo = string.Format("Character: {0}            Amount: {1}", (char)i, ArrayInt[i]).ToString();
                    richTextBox1.Text += CharValueInfo + "\r\n";

                }
            }
            
            /*
            Dictionary<char, int> occurences = new Dictionary<char, int>();
            char[] aL = FileInfo.ToCharArray();

            foreach (char c in aL)
            {
                if (!occurences.ContainsKey(c))
                {
                    occurences.Add(c, 1);
                }
                else
                {
                    occurences[c]++;
                }

            }

            richTextBox1.Text = string.Format("Key = {0}, Value = {1}",occurences.Keys, occurences.Values).ToString();
            */

            //richTextBox1.Text = occurences.Values.SelectMany(c => occurences.Values).Distinct().Count().ToString();
            /*
            foreach (string letter in FileInfo)
            {
                string SmallLetter = letter.ToLower();
                switch (SmallLetter)
                {
                    case "a":
                        scoreA += 1;
                        break;
                    case "b":
                        scoreB += 1;
                        break;
                    case "c":
                        scoreC += 1;
                        break;
                    case "d":
                        scoreD += 1;
                        break;
                    case "e":
                        scoreE += 1;
                        break;
                    case "f":
                        scoreF += 1;
                        break;
                    case "g":
                        scoreG += 1;
                        break;
                    case "h":
                        scoreH += 1;
                        break;
                    case "i":
                        scoreI += 1;
                        break;
                    case "j":
                        scoreJ += 1;
                        break;
                    case "k":
                        scoreK += 1;
                        break;
                    case "l":
                        scoreL += 1;
                        break;
                    case "m":
                        scoreM += 1;
                        break;
                    case "n":
                        scoreN += 1;
                        break;
                    case "o":
                        scoreO += 1;
                        break;
                    case "p":
                        scoreP += 1;
                        break;
                    case "q":
                        scoreQ += 1;
                        break;
                    case "r":
                        scoreR += 1;
                        break;
                    case "s":
                        scoreS += 1;
                        break;
                    case "t":
                        scoreT += 1;
                        break;
                    case "u":
                        scoreU += 1;
                        break;
                    case "v":
                        scoreV += 1;
                        break;
                    case "w":
                        scoreW += 1;
                        break;
                    case "x":
                        scoreX += 1;
                        break;
                    case "y":
                        scoreX += 1;
                        break;
                    case "z":
                        scoreZ += 1;
                        break;
                    case " ":
                        break;
                }
            }*/
            RefreshScore();
        }

        private void CountToZero()
        {

        }
        private void RefreshScore()
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            CountToZero();
            richTextBox1.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            RefreshScore();
        }
    }
}
