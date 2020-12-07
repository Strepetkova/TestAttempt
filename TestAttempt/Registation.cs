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
using System.Text.RegularExpressions;

namespace TestAttempt
{
    public partial class Registation : TestAttempt.BasicForm
    {
        Model1 db = new Model1();
        public Registation()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(nameTb.Text==""||surnameTb.Text==""||middleNameTb.Text==""||
                loginTb.Text==""||passwordTb.Text==""||repeatPassTb.Text==""||
                roleCmb.Text==""||phoneMaskTb.Text==""||genderTb.Text==""||
                photoPic.Image == null)
            {
                MessageBox.Show("Внимание! Вы не можете зарегистрироваться, так как заполнили не все поля!" +
                    "Проверьте, что вы заполнили все поля!", "Ошибка регистрации: пустые поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(passwordTb.Text != repeatPassTb.Text)
                {
                    MessageBox.Show("Внимание! Пароли не совпадают!", "Ошибка регистрации: пароли не совпадают",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Employee employee = db.Employee.Find(loginTb.Text);
                    if (employee != null)
                    {
                        MessageBox.Show("Внимание! Пользователь с таким логином уже существует!",
                            "Ошибка регистрации: данный логин есть в системе", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        employee = new Employee();
                        employee.Name = nameTb.Text;
                        employee.Surname = surnameTb.Text;
                        employee.MiddleName = middleNameTb.Text;
                        employee.Login = loginTb.Text;
                        employee.Password = passwordTb.Text;
                        employee.Role = roleCmb.Text;
                        employee.Phone = phoneMaskTb.Text;
                        employee.Gender = genderTb.Text;
                        if(photoPic.Image == null)
                        {
                            employee.Photo = null;
                        }
                        else
                        {
                            ImageConverter ic = new ImageConverter();
                            byte[] b = (byte[])ic.ConvertTo(photoPic.Image, typeof(byte[]));
                            employee.Photo = b;
                        }
                        db.Employee.Add(employee);
                        try
                        {
                            db.SaveChanges();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.InnerException.InnerException.Message);
                        }
                        MessageBox.Show($"Пользователь {surnameTb.Text} успешно зарегистрирован!",
                            "Успешная регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Authorisation.au.Show();
                        Close();
                    }
                }
            }
        }

        private void Registation_Load(object sender, EventArgs e)
        {
            /*привязка значений - Ролей
             в список roleCmb через запросы Linq*/
            var role = (from p in db.Employee
                        select p.Role).Distinct();
            roleCmb.DataSource = role.ToList();
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите свое фото";
            ofd.Filter = "Файл jpd, gif, png| *.jpd; *.gif; *.png;";
            DialogResult dr = ofd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                photoPic.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Authorisation.au.Show();
            Close();
        }
    }
}
