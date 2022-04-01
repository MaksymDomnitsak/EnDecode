using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnDecrypt
{
    
    public partial class Form1 : Form
    {
        Dictionary<string,string> shannoncodes = new Dictionary<string,string>();
        Dictionary<string,string> huffmancodes = new Dictionary<string,string>();
        public static string[] symbcodes;
        public static int[] counts;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShannon_Click(object sender, EventArgs e)
        {
            listBoxShannon.Items.Clear();
            shannoncodes.Clear();
            string text=txtText.Text;
            string symbols = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (!symbols.Contains(text[i]))
                {
                    symbols += text[i];
                }
            }
            int[] countsymbs = new int[symbols.Length];
            for(int i = 0;i< symbols.Length; i++)
            {
                for(int j = 0; j < text.Length; j++)
                {
                    if(symbols[i] == text[j])
                    {
                        countsymbs[i]++;
                    }
                }
            }
            char[] charset=symbols.ToCharArray();
            for(int i = 0;i< charset.Length; i++)
            {
                for(int j = i + 1; j < charset.Length; j++)
                {
                    if(countsymbs[i] < countsymbs[j])
                    {
                        int temp = countsymbs[i];
                        countsymbs[i]=countsymbs[j];
                        countsymbs[j] = temp;
                        char tmp = charset[i];
                        charset[i]=charset[j];
                        charset[j]=tmp;
                    }
                }
            }
            counts = new int[countsymbs.Length];
            countsymbs.CopyTo(counts, 0);
            symbcodes = new string[charset.Length];
            double averageset = countsymbs.Sum() / 2.0;
            CodeBuilder(countsymbs, averageset,0);
            for(int i = 0; i < countsymbs.Length; i++)
            {
                shannoncodes.Add(charset[i].ToString(), symbcodes[i]);
                text=text.Replace(charset[i].ToString(), symbcodes[i]);
                listBoxShannon.Items.Add(charset[i].ToString() + " - " + symbcodes[i]);
            }
            txtShannon.Text = "";
            txtShannon.Text = text;
            btnChars.Enabled = true;
        }
        public void CodeBuilder(int[] countsymbs,double averageset,int startIndex)
        {
            if(countsymbs.Length == 0)
            {
                return;
            }
            int sum = 0, it = 1;
            if (countsymbs.Length != 2 && countsymbs.Length !=3)
            {
                it = 0;
                while ((sum > averageset+(sum*0.3) || sum < averageset-(sum*0.3)) && it<countsymbs.Length)
                {
                    sum += countsymbs[it++];
                }
            }
            for(int i = 0; i < countsymbs.Length; i++)
            {
                if (i < it)
                {
                    symbcodes[startIndex + i] += "0";
                }
                else symbcodes[startIndex + i] += "1";
            }
            int[] vs;
            if (it != 1)
            {
                vs = new int[it];
                Array.Copy(countsymbs, vs, it);
                CodeBuilder(vs, vs.Sum() / 2.0,startIndex);
            }
            if (countsymbs.Length - it != 1)
            {
                vs = new int[countsymbs.Length - it];
                Array.Copy(countsymbs, it, vs, 0, countsymbs.Length - it);
                CodeBuilder(vs, vs.Sum() / 2.0, startIndex + it);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filepath = "";
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files(*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filepath = openFile.FileName;

                Stream fileStream = openFile.OpenFile();

                using (StreamReader reader = new StreamReader(filepath))
                {
                    if (radiotxtLoad.Checked == true)
                    {
                        string text = reader.ReadLine();
                        txtText.Text = text;
                    }
                    else if(radioHuffman.Checked== true)
                    {
                        string code = reader.ReadLine();
                        txtHuffman.Text = code;
                        btnHuffDecrypt.Enabled = true;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text files(*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            filename = saveFile.FileName;
            if (radioText.Checked == true)
            {
                File.WriteAllText(filename, txtText.Text);
            }
            else if (radioShannonSave.Checked)
            {
                File.WriteAllText(filename, txtShannon.Text);
            }
            else File.WriteAllText(filename, txtHuffman.Text);
        }

        private void btnHuffman_Click(object sender, EventArgs e)
        {
            huffmancodes.Clear();
            listBoxHuffman.Items.Clear();
            Dictionary<string,string> dict = new Dictionary<string,string>();
            string text = txtText.Text;
            string symbols = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (!symbols.Contains(text[i]))
                {
                    symbols += text[i];
                }
            }
            int[] countsymbs = new int[symbols.Length];
            for (int i = 0; i < symbols.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (symbols[i] == text[j])
                    {
                        countsymbs[i]++;
                    }
                }
            }
            char[] charset = symbols.ToCharArray();
            for (int i = 0; i < charset.Length; i++)
            {
                for (int j = i + 1; j < charset.Length; j++)
                {
                    if (countsymbs[i] < countsymbs[j])
                    {
                        int temp = countsymbs[i];
                        countsymbs[i] = countsymbs[j];
                        countsymbs[j] = temp;
                        char tmp = charset[i];
                        charset[i] = charset[j];
                        charset[j] = tmp;
                    }
                }
            }
            string[] symbs = new string[countsymbs.Length];
            for(int i = 0; i < charset.Length; i++)
            {
                symbs[i] = charset[i].ToString();
                dict.Add(charset[i].ToString(), "");
            }
            int k = charset.Length-1;
            counts = new int[countsymbs.Length];
            countsymbs.CopyTo(counts, 0);
            while (symbs[1] != String.Empty)
            {
                if (symbs[k].Length > 1)
                {
                    for (int i = 0; i < symbs[k].Length; i++)
                    {
                        dict[symbs[k][i].ToString()] = "1" + dict[symbs[k][i].ToString()];
                    }
                }
                else dict[symbs[k]] = "1" + dict[symbs[k]];
                if (symbs[k - 1].Length > 1)
                {
                    for (int i = 0; i < symbs[k - 1].Length; i++)
                    {
                        dict[symbs[k - 1][i].ToString()] = "0" + dict[symbs[k - 1][i].ToString()];
                    }
                }
                else dict[symbs[k-1]] = "0" + dict[symbs[k - 1]];
                symbs[k - 1] += symbs[k];
                countsymbs[k - 1] += countsymbs[k];
                symbs[k] = String.Empty;
                countsymbs[k] = 0;
                for (int i = k-1; i > 0; i--)
                {
                    if (countsymbs[i] > countsymbs[i - 1])
                    {
                        int temp = countsymbs[i];
                        countsymbs[i] = countsymbs[i - 1];
                        countsymbs[i - 1] = temp;
                        string tmp = symbs[i];
                        symbs[i] = symbs[i - 1];
                        symbs[i - 1] = tmp;
                    }
                    else break;
                }
                k--;
            }
            foreach(KeyValuePair<string,string> entry in dict)
            {
                listBoxHuffman.Items.Add(entry.Key + " - " + entry.Value);
                text=text.Replace(entry.Key, entry.Value);   
            }
            btnHuffDecrypt.Enabled = true;
            huffmancodes = dict;
            txtHuffman.Text = "";
            txtHuffman.Text = text;
            btnChars.Enabled = true;
        }

        private void btnChars_Click(object sender, EventArgs e)
        {
            int i = 0;
            double shentropy=0.0;
            double hafentropy=0.0;
            double avgshen=0.0;
            double avghaff=0.0;
            if (Check(shannoncodes))
            {
                foreach(KeyValuePair<string,string> entry in shannoncodes)
                {
                    avgshen += entry.Value.Length * ((double)counts[i]/(double)txtText.Text.Length);
                    shentropy += -((double)counts[i] / (double)txtText.Text.Length) * Math.Log(((double)counts[i] / (double)txtText.Text.Length), 2);
                    i++;
                }
                ShannonAvg.Text = "Середня довжина коду - " + Math.Round(avgshen,4);
                Entropy.Text = "Ентропія - " + Math.Round(shentropy,4);
                ShannonEffect.Text = "Ефективність коду - " + Math.Round((shentropy / avgshen),4);
            }
            i = 0;
            if (Check(huffmancodes))
            {
                foreach (KeyValuePair<string, string> entry in huffmancodes)
                {
                    avghaff += entry.Value.Length * ((double)counts[i] / (double)txtText.Text.Length);
                    hafentropy += -((double)counts[i] / (double)txtText.Text.Length) * Math.Log(((double)counts[i] / (double)txtText.Text.Length), 2);
                    i++;
                }
                HuffmanAvg.Text = "Середня довжина коду - " + Math.Round(avghaff,4);
                Entropy.Text = "Ентропія - " + Math.Round(hafentropy,4);
                HuffmanEffect.Text = "Ефективність коду - " + Math.Round((hafentropy / avghaff),4);
            }
        }

        public bool Check(Dictionary<string,string> dict)
        {
            if(dict.Count == 0)
            {
                return false;
            }
            return true;

        }

        private void btnHuffDecrypt_Click(object sender, EventArgs e)
        {
            int changed=0;
            string code = txtHuffman.Text;
            int length = code.Length;
            string symbcode="";
            for(int i = 0; i < length; i++)
            {
                symbcode += code[i];
                if (huffmancodes.Values.Contains(symbcode))
                {
                    code=code.Remove(changed, symbcode.Length);
                    code=code.Insert(changed, huffmancodes.Keys.ToArray<string>().ElementAt<string>(Array.IndexOf(huffmancodes.Values.ToArray<string>(), symbcode)));
                    changed++;
                    i = changed-1;
                    symbcode = "";
                    length=code.Length;
                }

            }
            richHuffman.Text = code;
        }

    }
}
