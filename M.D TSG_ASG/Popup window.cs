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
    public partial class Popup_window : Form
    {
        public Popup_window()
        {
            InitializeComponent();
        }
        static public bool uzdaryti = false;
        static public string op;
        private void Popup_window_Load(object sender, EventArgs e)
        {
            if (Form1.TSG.Checked == true)
            {
                label1.Text = "Salyga: " + Form1.input;
                label2.Text = "Išvada";
            }
            else if(Form1.ASG.Checked == true)
            {
                label1.Text = "Išvada: " + Form1.input;
                label2.Text = "Salyga";
            }

        }
        public void Submit_Click(object sender, EventArgs e)
        {
            //static public string ewq = 
            if(!String.IsNullOrEmpty(textBox1.Text))
            {
                op = textBox1.Text;
                op = op.ToLower();
                if(Form1.TSG.Checked == true)
                {
                    File.AppendAllText(Form1.filename, Form1.input + "=" + op + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(Form1.filename, Form1.input + "=" + op + Environment.NewLine);
                }
                uzdaryti = true;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
