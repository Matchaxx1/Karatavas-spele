﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Karatavas
{
    public partial class Form2 : Form
    {
        List<string> vardi = new List<string>()
        {
            "ūdens",
            "zieds",
            "sirds",
            "skats",
            "laime",
            "kaķis",
            "lauva",
            "svece",
            "zelts",
            "gulta",
            "saule",
            "tārps",
            "krāsa",
            "bumba",
            "lauks",
            "burts",
            "tilts",
            "vārds",
            "mājas",
            "pļava",
            "skola",
            "varde",
            "kurpe",
            "miegs",
            "uzvara",
            "hokejs",
            "grozs",
            "karjera",
            "karogs",            
            "čempions",
            "eiropa",
            "komanda",
            "bērns"
            


        };

        int NepareiziMeginajumi;
        Random rnd;
        string NejausaisVards;
        string IzveletaisBurts;
        char[] charVards;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NepareiziMeginajumi = 0;
            rnd = new Random();
            NejausaisVards = vardi[rnd.Next(vardi.Count)];

            charVards = new string('_', NejausaisVards.Length).ToCharArray();
            string ApakssvitraVards = string.Join(" ", charVards);
            label1.Text = ApakssvitraVards;

            #region Pogas
            butA.Click += LetterButton_Click;
            butB.Click += LetterButton_Click;
            butC.Click += LetterButton_Click;
            butD.Click += LetterButton_Click;
            butE.Click += LetterButton_Click;
            butF.Click += LetterButton_Click;
            butG.Click += LetterButton_Click;
            butH.Click += LetterButton_Click;
            butI.Click += LetterButton_Click;
            butJ.Click += LetterButton_Click;
            butK.Click += LetterButton_Click;
            butL.Click += LetterButton_Click;
            butM.Click += LetterButton_Click;
            butN.Click += LetterButton_Click;
            butO.Click += LetterButton_Click;
            butP.Click += LetterButton_Click;
            butR.Click += LetterButton_Click;
            butS.Click += LetterButton_Click;
            butT.Click += LetterButton_Click;
            butU.Click += LetterButton_Click;
            butV.Click += LetterButton_Click;
            butZ.Click += LetterButton_Click;
            #endregion
        }

        private Button SpiestaPoga;

        private void butMinet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IzveletaisBurts))
            {
                MessageBox.Show("Lūdzu izvēlieties burtu!");
                return;
            }

            string MinetaisBurts = BurtsBezGarumzimes(IzveletaisBurts);
            bool PareizsMeginajums = false;

            char[] wordArray = NejausaisVards.ToCharArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (BurtsBezGarumzimes(wordArray[i].ToString()) == MinetaisBurts)
                {
                    charVards[i] = NejausaisVards[i];
                    PareizsMeginajums = true;
                }
            }

            label1.Text = string.Join(" ", charVards);
            if (PareizsMeginajums)
            {
                SpiestaPoga.BackColor = System.Drawing.ColorTranslator.FromHtml("#74C365");
            }
            else
            {
                SpiestaPoga.BackColor = System.Drawing.ColorTranslator.FromHtml("#E34234");    
                MainitKaratavuFoto();
                NepareiziMeginajumi++;
                label6.Text = NepareiziMeginajumi.ToString() + " / 7";
            }
            if (!label1.Text.Contains('_'))
            {
                Form3 form3 = new Form3(NejausaisVards);
                form3.Show();
                this.Hide();
            }

            IzveletaisBurts = null;
            SpiestaPoga = null;
        }

        private void MainitKaratavuFoto()
        {
            switch (NepareiziMeginajumi)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.foto2;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.foto3;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.foto4;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.foto5;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.foto6;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.foto7;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.foto8;

                    Form4 form4 = new Form4(NejausaisVards);

                    form4.Show();
                    this.Hide();
                    break;
            }
        }

        private string BurtsBezGarumzimes(string burts)
        {
            switch (burts)
            {
                case "ā":
                    return "a";
                case "č":
                    return "c";
                case "ē":
                    return "e";
                case "ģ":
                    return "g";
                case "ī":
                    return "i";
                case "ķ":
                    return "k";
                case "ļ":
                    return "l";
                case "ņ":
                    return "n";
                case "š":
                    return "s";
                case "ū":
                    return "u";
                case "ž":
                    return "z";
                default:
                    return burts;
            }
        }

        


        private void butA_Click(object sender, EventArgs e)
        {
            
        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            SpiestaPoga = sender as Button;
            if (SpiestaPoga != null)
            {
                IzveletaisBurts = SpiestaPoga.Text.ToLower();
                label5.Text = IzveletaisBurts;
            }
        }

        private void butMinetVardu_Click(object sender, EventArgs e)
        {
            string teksts = textBox1.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lūdzu ievadiet vārdu!");
                return;
            }else if (teksts.Any(char.IsDigit))
            {
                MessageBox.Show("Lūdzu ievadiet vārdu, nevis ciparu!");
                return;
            }
            if (textBox1.Text == NejausaisVards)
            {
                Form3 form3 = new Form3(NejausaisVards);
                form3.Show();
                this.Hide();
            }
            else
            {
                MainitKaratavuFoto();
                NepareiziMeginajumi++;
                label6.Text = NepareiziMeginajumi.ToString() + " / 7";
            }
        }
    }
}
