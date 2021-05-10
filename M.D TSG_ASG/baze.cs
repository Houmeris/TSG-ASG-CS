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
    public partial class baze : Form
    {
        public baze()
        {
            InitializeComponent();
        }
        int eilute = 0;
        TextBox salyga = new TextBox();
        TextBox isvada = new TextBox();
        Label salyg = new Label();
        Label isvad = new Label();
        Button submit = new Button();
        Button submit2 = new Button();
        private void baze_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Form1.question.Length; i++)
            {
                lentele.Rows.Add(Form1.question[i], Form1.answer[i]);
            }
            lentele.CellClick += new DataGridViewCellEventHandler(lentele_CellClick);
            salyg.Text = "Salyga:";
            isvad.Text = "Išvada:";
            salyga.Location = new Point(388, 227);
            isvada.Location = new Point(388, 267);

            salyg.Location = new Point(340, 228);
            isvad.Location = new Point(340, 268);

            submit.Text = "Patvirtinti";
            submit.Location = new Point(400, 300);
            submit.Click += new EventHandler(submit_click);
            submit2.Text = "Patvirtinti";
            submit2.Location = new Point(400, 300);
            submit2.Click += new EventHandler(submit2_click);
        }
        private void lentele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controls.Remove(salyga);
            Controls.Remove(salyg);
            Controls.Remove(isvada);
            Controls.Remove(isvad);
            Controls.Remove(submit);
            Controls.Remove(submit2);
            Delete.Enabled = true;
            Redaguoti.Enabled = true;
            Add.Enabled = true;
            eilute = e.RowIndex;
            //label1.Text = eilute.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Form1.question = Form1.question.Where((source, index) => index != eilute).ToArray();
            Form1.answer = Form1.answer.Where((source, index) => index != eilute).ToArray();
            lentele.Rows.Clear();
            for (int i = 0; i < Form1.question.Length; i++)
            {
                lentele.Rows.Add(Form1.question[i], Form1.answer[i]);
            }
            File.WriteAllText(Form1.filename, "");
            for(int i = 0; i < Form1.question.Length; i++)
            {
                File.AppendAllText(Form1.filename, Form1.question[i] + "=" + Form1.answer[i] + Environment.NewLine);
            }
            Delete.Enabled = false;
            Redaguoti.Enabled = false;
            Add.Enabled = false;
        }

        private void Redaguoti_Click(object sender, EventArgs e)
        {
            salyga.Text = Form1.question[eilute];
            isvada.Text = Form1.answer[eilute];
            Controls.Add(salyga);
            Controls.Add(isvada);
            Controls.Add(salyg);
            Controls.Add(isvad);
            Controls.Add(submit);
            Delete.Enabled = false;
            Redaguoti.Enabled = false;
            Add.Enabled = false;
        }
        private void submit_click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(salyga.Text) && !String.IsNullOrEmpty(isvada.Text))
            {
                Form1.question[eilute] = salyga.Text;
                Form1.answer[eilute] = isvada.Text;
                Form1.question[eilute] = Form1.question[eilute].ToLower();
                Form1.answer[eilute] = Form1.answer[eilute].ToLower();
                File.WriteAllText(Form1.filename, "");
                for (int i = 0; i < Form1.question.Length; i++)
                {
                    File.AppendAllText(Form1.filename, Form1.question[i] + "=" + Form1.answer[i] + Environment.NewLine);
                }
            }
            lentele.Rows.Clear();
            for (int i = 0; i < Form1.question.Length; i++)
            {
                lentele.Rows.Add(Form1.question[i], Form1.answer[i]);
            }
            Controls.Remove(salyga);
            Controls.Remove(salyg);
            Controls.Remove(isvada);
            Controls.Remove(isvad);
            Controls.Remove(submit);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            salyga.Text = "";
            isvada.Text = "";
            Controls.Add(salyga);
            Controls.Add(isvada);
            Controls.Add(salyg);
            Controls.Add(isvad);
            Controls.Add(submit2);
            Delete.Enabled = false;
            Redaguoti.Enabled = false;
            Add.Enabled = false;
        }
        private void submit2_click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(salyga.Text) && !String.IsNullOrEmpty(isvada.Text))
            Form1.question = Form1.question.Concat(new string[] { salyga.Text }).ToArray();
            Form1.answer = Form1.answer.Concat(new string[] { isvada.Text }).ToArray();
            File.WriteAllText(Form1.filename, "");
            for (int i = 0; i < Form1.question.Length; i++)
            {
                Form1.question[i] = Form1.question[i].ToLower();
                Form1.answer[i] = Form1.answer[i].ToLower();
                File.AppendAllText(Form1.filename, Form1.question[i] + "=" + Form1.answer[i] + Environment.NewLine);
            }
            lentele.Rows.Clear();
            for (int i = 0; i < Form1.question.Length; i++)
            {
                lentele.Rows.Add(Form1.question[i], Form1.answer[i]);
            }
            Controls.Remove(salyga);
            Controls.Remove(salyg);
            Controls.Remove(isvada);
            Controls.Remove(isvad);
            Controls.Remove(submit2);
        }
    }
}
