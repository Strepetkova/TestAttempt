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
    public partial class FormOfManagerA : TestAttempt.BasicForm
    {
        public static bool add = false;
        Model1 db = new Model1();
        public FormOfManagerA()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Authorisation.au.Show();
            Close();
        }

        private void FormOfManagerA_Load(object sender, EventArgs e)
        {
            helloLb.Text = "Добро пожаловать," + Authorisation.em.Surname + " " + Authorisation.em.Name + " " + Authorisation.em.MiddleName + "!";
            renterBindingSource.DataSource = db.Renter.ToList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Renter renter = (Renter)renterBindingSource.Current;
            DialogResult dr = MessageBox.Show("Внимание! Вы действительно хотите удалить арендатора - " 
                + renter.Name.ToString(), "Удаление арендатора", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                db.Renter.Remove(renter);
                try
                {
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                renterBindingSource.DataSource = db.Renter.ToList();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            add = true;
            InterfaceOfManagerA ima = new InterfaceOfManagerA();
            ima.db = db;
            DialogResult dr = ima.ShowDialog();
            if(dr == DialogResult.OK)
            {
                renterBindingSource.DataSource = db.Renter.ToList();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            add = false;
            Renter renter = (Renter)renterBindingSource.Current;
            InterfaceOfManagerA ima = new InterfaceOfManagerA();
            ima.db = db;
            ima.renter = renter;
            DialogResult dr = ima.ShowDialog();
            if(dr == DialogResult.OK)
            {
                renterBindingSource.DataSource = db.Renter.ToList();
            }
        }
    }
}
