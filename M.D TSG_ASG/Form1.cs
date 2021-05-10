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

namespace M.D_TSG_ASG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button Submit = new Button();
        TextBox tekstas = new TextBox();
        public static RadioButton TSG = new RadioButton();
        public static RadioButton ASG = new RadioButton();
        private void Form1_Load(object sender, EventArgs e)
        {
            tekstas.Location = new Point(100, 100);
            tekstas.Size = new Size(200, 50);

            Submit.Text = "Submit";
            Submit.Location = new Point(320, 99);
            Submit.Click += new EventHandler(Submit_Click);

            TSG.Text = "TSG";
            ASG.Text = "ASG";
            TSG.Checked = true;
            TSG.Location = new Point(500, 100);
            ASG.Location = new Point(500, 150);
        }
        static public string filename;
        static public string input;
        static public string[] question;
        static public string[] answer;
        private void Selectfile_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            bool ok = false;
            //File select
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ok = true;
                filename = FD.FileName;
            }
            //After file select
            if(ok == true)
            {
                Controls.Add(tekstas);
                Label notice = new Label();
                notice.Location = new Point(100, 80);
                notice.Text = "Iveskite salyga";
                Controls.Add(notice);
                Controls.Add(Submit);
                Controls.Add(TSG);
                Controls.Add(ASG);
                //Nuskaitome faila
                string[] text = System.IO.File.ReadAllLines(filename);
                int[] index = new int[text.Length];
                question = new string[text.Length];
                answer = new string[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    index[i] = text[i].IndexOf("=");
                    if (index[i] > 0)
                    {
                        question[i] = text[i].Substring(0, index[i]);
                        answer[i] = text[i].Substring(index[i] + 1);
                    }
                }
            }
            ziniubaze.Enabled = true;
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            //Nuskaitome faila
             string[] text = System.IO.File.ReadAllLines(filename);
             int[] index = new int[text.Length];
             question = new string[text.Length];
             answer = new string[text.Length];
             for (int i = 0; i < text.Length; i++)
             {
                index[i] = text[i].IndexOf("=");
                if (index[i] > 0)
                {
                    question[i] = text[i].Substring(0, index[i]);
                    answer[i] = text[i].Substring(index[i] + 1);
                }
             }

            label1.Text = "";
            int count = 0;
            input = tekstas.Text;
            input = input.ToLower();
            string[] inputas = new string[question.Length];
            inputas[0] = input;
            for (int i = 0; i < question.Length; i++)
            {
                if(TSG.Checked == true)
                {
                    for(int j = 0; j < question.Length; j++)
                    {
                        if(inputas[i] == question[j])
                        {
                            count++;
                            label1.Text += question[j] + ": " + answer[j] + Environment.NewLine;
                            inputas[i + count] = answer[j];
                        }
                    }
                }
                if(ASG.Checked == true)
                {
                    for(int j = 0; j < question.Length; j++)
                    {
                        if(inputas[i] == answer[j])
                        {
                            count++;
                            label1.Text += question[j] + ": " + answer[j] + Environment.NewLine;
                            inputas[i + count] = question[j];
                        }
                    }
                }
            }
            if(count == 0)
            {
                Popup_window window = new Popup_window();
                window.FormClosed += new FormClosedEventHandler(Popup_window_FormClosed);
                window.Show(this);
            }
        }
        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Popup_window_FormClosed(Object sender, FormClosedEventArgs e)
        {
            if(Popup_window.uzdaryti == true)
            {
                label1.Text = input + ": " + Popup_window.op;
            }
        }

        private void ziniubaze_Click(object sender, EventArgs e)
        {
            baze window = new baze();
            window.Show(this);
        }
    }
}
