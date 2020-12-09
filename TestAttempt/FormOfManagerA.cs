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
            renterBindingSource.DataSource = db.Rent.ToList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
