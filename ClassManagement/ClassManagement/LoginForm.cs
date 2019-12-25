using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassManagement {
	public partial class LoginForm : Form {
		StepSchedulerEntities db = null; // наша модель
		public string userLogin = null;
		public LoginForm() {
			InitializeComponent();
			txtBox_password.PasswordChar = '*';
			db = new StepSchedulerEntities();// инициализация 
			//События
			
            

            txtBox_password.KeyDown += TxtBox_password_KeyDown;
            txtBox_login.KeyDown += TxtBox_password_KeyDown;
        }

        private void TxtBox_password_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) { LogIn(); }
            
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Test");
            LogIn();
        }

		

		public void LogIn() {
            //if (txtBox_login.Text == "0") {
            //    MainFormAdmin form = new MainFormAdmin();
            //    form.Show();
            //}
            //if (txtBox_login.Text == "1") {
            //    MainFormTeacher form = new MainFormTeacher();
            //    form.Show();
            //}

            Regex regex = new Regex("^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+){2}$");

            string input_login = txtBox_login.Text;
            string input_password = txtBox_password.Text;

            //Если логин и пароль прошли валидацию
            if (regex.Match(input_login).Success && regex.Match(input_password).Success) {
                txtBox_password.BackColor = Color.White;
                txtBox_login.BackColor = Color.White;
                //ADMIN
                int corect_login = db.Users.Where(user => user.Login == input_login).Count();
                if (corect_login == 1) {
                    var corect_password = db.Users.Where(user => user.Login == input_login).Where(user => user.Password == input_password.ToString()).Count();
                    var isAdmin = db.Users.Where(u => u.Login == input_login).Select(u => u.IsAdmin).FirstOrDefault();
                    if (corect_password == 1) {
                        this.DialogResult = DialogResult.OK;
                        userLogin = input_login;
                        if (Convert.ToBoolean(isAdmin)) {
                            MainFormAdmin form = new MainFormAdmin(/*input_login*/);
                            form.Show();
                            this.Visible = false;
                        }
                        else {
                            MainFormTeacher form = new MainFormTeacher(/*input_login*/);
                            form.Show();
                            this.Visible = false;
                        }
                    }
                    else {
                        txtBox_password.BackColor = Color.PaleVioletRed;
                        MessageBox.Show("Incorrect password");
                    }
                }
                else {
                    txtBox_login.BackColor = Color.PaleVioletRed;
                    MessageBox.Show("Incorrect username");
                }
            }
            else {
                if (!regex.Match(input_password).Success) {
                    txtBox_password.BackColor = Color.PaleVioletRed;
                }
                if (!regex.Match(input_login).Success) {
                    txtBox_login.BackColor = Color.PaleVioletRed;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            
            LogIn();
        }
    }
}
