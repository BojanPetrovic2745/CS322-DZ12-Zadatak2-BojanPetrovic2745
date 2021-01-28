using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ12_Zadatak2_BojanPetrovic2745
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if(open.ShowDialog() == DialogResult.OK)
            {
                TextReader r1 = new StreamReader(open.FileName);

                try
                {
                    string s1;
                    while ((s1 = r1.ReadLine()) != null)
                    {
                        richTextBox1.Text += s1 + "\r\n";
                    }
                }
                finally
                {
                    r1.Close();
                }
            }

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());

                for (int i = 0; i < richTextBox1.SelectedText.Length; i++)

                {

                    writer.WriteLine(richTextBox1.SelectedText[i].ToString());

                }

                writer.Dispose();

                writer.Close();

            }
        }
    }
}
