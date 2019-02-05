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
    public partial class Form3 : Form
    {
        DataBAseQuizEntities db = new DataBAseQuizEntities();
        public Form3()
        {
            InitializeComponent();
            btnSignUp.Click += SignUp;
            
        }

        private void SignUp(object sender, EventArgs e)
        {
            
            var useremail = tbxEmail.Text;
            var userpassword= tbxPass.Text;

            if (db.Users.Any(item => item.UserEmail == useremail && item.UserPassword == userpassword))
            {
                var userindiki = db.Users.Where(ayqam => ayqam.UserEmail == useremail).First().UserId;
                if (db.Users.Where(b => b.UserId == userindiki).First().UserTypeId == 1)
                {
                    Form1 mellim = new Form1();
                    mellim.Show();
                }else if(db.Users.Where(b => b.UserId == userindiki).First().UserTypeId == 2)
                {
                    Form2 sagird = new Form2();
                    sagird.Show();
                }
                this.Hide();
            }
        }
    }
}
