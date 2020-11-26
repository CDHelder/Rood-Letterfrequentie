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

namespace Rood__Letterfrequentie
{

    public partial class Form1 : Form
    {
        int scoreA;
        int scoreB;
        int scoreC;
        int scoreD;
        int scoreE;
        int scoreF;
        int scoreG;
        int scoreH;
        int scoreI;
        int scoreJ;
        int scoreK;
        int scoreL;
        int scoreM;
        int scoreN;
        int scoreO;
        int scoreP;
        int scoreQ;
        int scoreR;
        int scoreS;
        int scoreT;
        int scoreU;
        int scoreV;
        int scoreW;
        int scoreX;
        int scoreY;
        int scoreZ;

        public Form1()
        {
            InitializeComponent();

        }

        private void bOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;

            string[] FileInfo = File.ReadAllLines(textBox1.Text);

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
            }
            RefreshScore();
        }

        private void CountToZero()
        {
            scoreA = 0;
            scoreB = 0;
            scoreC = 0;
            scoreD = 0;
            scoreE = 0;
            scoreF = 0;
            scoreG = 0;
            scoreH = 0;
            scoreI = 0;
            scoreJ = 0;
            scoreK = 0;
            scoreL = 0;
            scoreM = 0;
            scoreN = 0;
            scoreO = 0;
            scoreP = 0;
            scoreQ = 0;
            scoreR = 0;
            scoreS = 0;
            scoreT = 0;
            scoreU = 0;
            scoreV = 0;
            scoreW = 0;
            scoreX = 0;
            scoreY = 0;
            scoreZ = 0;
        }
        private void RefreshScore()
        {
            labelA.Text = scoreA.ToString();
            labelB.Text = scoreB.ToString();
            labelC.Text = scoreC.ToString();
            labelD.Text = scoreD.ToString();
            labelE.Text = scoreE.ToString();
            labelF.Text = scoreF.ToString();
            labelG.Text = scoreG.ToString();
            labelH.Text = scoreH.ToString();
            labelI.Text = scoreI.ToString();
            labelJ.Text = scoreJ.ToString();
            labelK.Text = scoreK.ToString();
            labelL.Text = scoreL.ToString();
            labelM.Text = scoreM.ToString();
            labelN.Text = scoreN.ToString();
            labelO.Text = scoreO.ToString();
            labelP.Text = scoreP.ToString();
            labelQ.Text = scoreQ.ToString();
            labelR.Text = scoreR.ToString();
            labelS.Text = scoreS.ToString();
            labelT.Text = scoreT.ToString();
            labelU.Text = scoreU.ToString();
            labelV.Text = scoreV.ToString();
            labelW.Text = scoreW.ToString();
            labelX.Text = scoreX.ToString();
            labelY.Text = scoreY.ToString();
            labelZ.Text = scoreZ.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            CountToZero();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            RefreshScore();
        }
    }
}
