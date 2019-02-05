using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form2 : Form
    {
        int suallar = 0;
        int point = 0;
        DataBAseQuizEntities db = new DataBAseQuizEntities();

        List<Question> QuestionsList = new List<Question>();

        public Form2()
        {
            InitializeComponent();

            var newlist = db.Questions.ToList();
            
            
                //textBox1.Text = newlist[suallar].QuestionTitle;
                //btnA.Text = newlist[suallar].AnswerA;
                //btnB.Text = newlist[suallar].AnswerB;
                //btnC.Text = newlist[suallar].AnswerC;
                //btnD.Text = newlist[suallar].AnswerD;
                lblNext.Click += Next;
                lblPrev.Click += Prev;

            foreach (var item in Controls)
            {
                if (item is Button)
                {
                    var btn = item as Button; // ancaq buttonlari goturur
                    //if (btn.Text == newlist[suallar].RightAnswer)
                    //{
                    //    btn.Click += MakeGreen;
                    //}
                    //else
                    //{
                    //    btn.Click += MakeRed;
                    //}
                    btn.Click += NextQuestion;
                }
            }

            
            

        }

        private void Prev(object sender, EventArgs e)
        {
            //var newlist = db.Questions.ToList();
            //suallar--;
            //textBox1.Text = newlist[suallar].QuestionTitle;
            //btnA.Text = newlist[suallar].AnswerA;
            //btnB.Text = newlist[suallar].AnswerB;
            //btnC.Text = newlist[suallar].AnswerC;
            //btnD.Text = newlist[suallar].AnswerD;
            try
            {
                if (suallar != db.Questions.Count())
                { 

                    var newlist = db.Questions.ToList();
                    suallar--;
                    textBox1.Text = newlist[suallar].QuestionTitle;
                    btnA.Text = newlist[suallar].AnswerA;
                    btnB.Text = newlist[suallar].AnswerB;
                    btnC.Text = newlist[suallar].AnswerC;
                    btnD.Text = newlist[suallar].AnswerD;

                }
            }
            catch
            {
                this.Close();
            }
        }

        private void Next(object sender, EventArgs e)
        {
            try
            {
                if (suallar != db.Questions.Count())
                {
                    var newlist = db.Questions.ToList();
                    suallar++;
                    textBox1.Text = newlist[suallar].QuestionTitle;
                    btnA.Text = newlist[suallar].AnswerA;
                    btnB.Text = newlist[suallar].AnswerB;
                    btnC.Text = newlist[suallar].AnswerC;
                    btnD.Text = newlist[suallar].AnswerD;

                }
            }
            catch
            {
                this.Close();
            }
            

        }

        public void NextQuestion(object sender, EventArgs e)
        {
            MessageBox.Show(point.ToString());
            var newlist = db.Questions.ToList();

            var thisButton = sender as Button;

            if (thisButton.Text==newlist[suallar].RightAnswer)
            {
                AnswerBool.answer = true;
                point += 10;
                

            }
            else
            {
                AnswerBool.answer = false;
                point -= 5;
            }

             if (AnswerBool.answer == true)
             {
                 suallar++;
                 textBox1.Text = newlist[suallar].QuestionTitle;
                 btnA.Text = newlist[suallar].AnswerA;
                 btnB.Text = newlist[suallar].AnswerB;
                 btnC.Text = newlist[suallar].AnswerC;
                 btnD.Text = newlist[suallar].AnswerD;
                 AnswerBool.answer = false;
                 
            }
             else
             {
                 MessageBox.Show("Wrong Answer!");
             }
            
        }

        //private void Prev(object sender, EventArgs e)
        //{
        //    suallar--;
        //    btnA.BackColor = Color.White;
        //    btnB.BackColor = Color.White;
        //    btnC.BackColor = Color.White;
        //    btnD.BackColor = Color.White;
        //    var newlist = db.Questions.ToList();


        //    if (suallar == newlist.Count)
        //    {
        //        this.Close();
        //    }
        //    textBox1.Text = newlist[suallar].QuestionTitle;
        //    btnA.Text = newlist[suallar].AnswerA;
        //    btnB.Text = newlist[suallar].AnswerB;
        //    btnC.Text = newlist[suallar].AnswerC;
        //    btnD.Text = newlist[suallar].AnswerD;
        //    foreach (var item in Controls)
        //    {
        //        if (item is Button)
        //        {
        //            var btn = item as Button; // ancaq buttonlari goturur
        //            if (btn.Text == newlist[suallar].RightAnswer)
        //            {
        //                btn.Click += MakeGreen;
        //                btn.Click += Next;


        //            }
        //            else
        //            {
        //                btn.Click += MakeRed;
        //            }
        //        }
        //    }
        //}

        //private void Next(object sender, EventArgs e)
        //{

        //    //MessageBox.Show(point.ToString());
        //    btnA.BackColor = Color.White;
        //    btnB.BackColor = Color.White;
        //    btnC.BackColor = Color.White;
        //    btnD.BackColor = Color.White;
        //    var newlist = db.Questions.ToList();

        //    suallar++;
        //    if (suallar== newlist.Count)
        //    {
        //        this.Close();
        //    }
        //    textBox1.Text = newlist[suallar].QuestionTitle;
        //    btnA.Text = newlist[suallar].AnswerA;
        //    btnB.Text = newlist[suallar].AnswerB;
        //    btnC.Text = newlist[suallar].AnswerC;
        //    btnD.Text = newlist[suallar].AnswerD;
        //    foreach (var item in Controls)
        //    {
        //        if (item is Button)
        //        {
        //            var btn = item as Button; // ancaq buttonlari goturur
        //            if (btn.Text == newlist[suallar].RightAnswer)
        //            {
        //                btn.Click += MakeGreen;
        //                btn.Click += Next;
        //                //point += 10;
        //            }
        //            else
        //            {
        //                btn.Click += MakeRed;
        //            }
        //        }
        //    }


        //}

        private void MakeRed(object sender, EventArgs e)
        {
            var thisButton = sender as Button;
            thisButton.BackColor = Color.Red;
        }

        private void MakeGreen(object sender, EventArgs e)
        {
            var thisButton = sender as Button;
            thisButton.BackColor = Color.Green;
            

        }

        public void Wait()
        {
            Thread.Sleep(2000);
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in db.Quizs)
            {
                comboBox1.Items.Add(item.QuizName);

            }
        }

        private void lblBasla_Click(object sender, EventArgs e)
        {
            

            var quizid = (from Quiz in db.Quizs
                           where Quiz.QuizName == comboBox1.SelectedItem.ToString()
                           select Quiz.QuizId).First();

            MessageBox.Show(quizid.ToString());


            var suallarquiz = (from item in db.QuestionQuizs
                              where item.QuizId == quizid
                              select item.QuestionId).ToList();
            foreach (var item in suallarquiz)
            {

                var newlist = db.Questions.ToList();
                suallar++;
                textBox1.Text = newlist[suallar].QuestionTitle;
                btnA.Text = newlist[suallar].AnswerA;
                btnB.Text = newlist[suallar].AnswerB;
                btnC.Text = newlist[suallar].AnswerC;
                btnD.Text = newlist[suallar].AnswerD;
            }



        }
    }
}
