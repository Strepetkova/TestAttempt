using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAttempt.ModelEF;

namespace TestAttempt
{
    public partial class Authorisation : TestAttempt.BasicForm
    {
        Model1 db = new Model1();
        public static Authorisation au { get; set; }
        public static Employee em { get; set; }
        public Authorisation()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (loginTB.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Внимание! Невозможно войти в систему из-за пустых полей!",
                    "Ошибка входа в систему: пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Employee employee = db.Employee.FirstOrDefault(x => x.Login == loginTB.Text.ToUpper());
                if(employee != null && employee.Password == passwordTb.Text)
                {
                    em = employee;
                    au = this;
                    if(employee.Role == "Администратор")
                    {
                        ClearTextBox();
                    }
                    if (employee.Role == "Менеджер А")
                    {
                        FormOfManagerA mc = new FormOfManagerA();
                        mc.Show();
                        ClearTextBox();
                        Hide();
                    }
                    if (employee.Role == "Менеджер С")
                    {
                        ClearTextBox();
                    }
                    if (employee.Role == "Удален")
                    {
                        MessageBox.Show("Внимание! Ваш аккаунт приобрел роль Удален, поэтому вы не можете зайти! Обратитесь к администратору!",
                            "Ошибка входа в систему: роль Удален", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Внимание! Неправильный логин или пароль! Проверьте правильность введенных данных!",
                        "Ошибка входа в систему: неправильный логин или пароль", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    passwordTb.Clear();
                }
            }
        }
        public void ClearTextBox()
        {
            loginTB.Clear();
            passwordTb.Clear();
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Registation reg = new Registation();
            reg.Show();
            Hide();
        }
    }
}
