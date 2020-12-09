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
    public partial class InterfaceOfManagerA : TestAttempt.BasicForm
    {
        public Model1 db { get; set; }
        public Renter renter { get; set; }
        public InterfaceOfManagerA()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(FormOfManagerA.add == false)
            {
                renter.Name = nameTb.Text;
                renter.Phone = phoneMaskTb.Text;
                renter.Address = addressRichTb.Text;
                try
                {
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
            else if(FormOfManagerA.add == true)
            {
                if (nameTb.Text == "" || phoneMaskTb.Text == "" || addressRichTb.Text == "")
                {
                    MessageBox.Show("Внимание! Сохранение невозможно! Заполните все поля!",
                        "Ошибка сохранения: пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Renter renter = new Renter();
                    renter.Name = nameTb.Text;
                    renter.Phone = phoneMaskTb.Text;
                    renter.Address = addressRichTb.Text;
                    db.Renter.Add(renter);
                    try
                    {
                        db.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.InnerException.Message);
                    }
                }
            }
        }

        private void InterfaceOfManagerA_Load(object sender, EventArgs e)
        {
            if(FormOfManagerA.add == false)
            {
                changeLb.Text = "Редактирование арендатора";
                nameTb.Text = renter.Name;
                phoneMaskTb.Text = renter.Phone;
                addressRichTb.Text = renter.Address;
            }
            else if(FormOfManagerA.add == true)
            {
                changeLb.Text = "Добавление арендатора";
            }
        }
    }
}
