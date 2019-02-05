using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        DataBAseQuizEntities db = new DataBAseQuizEntities();
        public Form1()
        {

            
            InitializeComponent();
            panel1.Location = new Point(74, 32);
            panel2.Location = new Point(74, 32);
            
            btnAdd.Click += Add;
            btnaddsual.Click += AddSual;
        }

        private void AddSual(object sender, EventArgs e)
        {
            QuestionType tip = new QuestionType();
            tip.TypeName = tbxFenn.Text;
            tip.TypePoint = Convert.ToInt32(tbxToplam.Text.ToString());
            db.QuestionTypes.Add(tip);
            db.SaveChanges();
            
        }

        private void Add(object sender, EventArgs e)
        {
            Question sual = new Question();
            sual.QuestionTitle = tbxSual.Text;
            sual.AnswerA = tbxA.Text;
            sual.AnswerB = tbxB.Text;
            sual.AnswerC = tbxC.Text;
            sual.AnswerD = tbxD.Text;
            sual.RightAnswer = tbxDuzCavab.Text;
            sual.QuestionTypeId = Convert.ToInt32(tbxFenntipi.Text.ToString());
            db.Questions.Add(sual);
            db.SaveChanges();
            this.Hide();
            
            
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaddsual_Click(object sender, EventArgs e)
        {
            
            panel1.Show();
            panel2.Hide();
        }
    }
}
