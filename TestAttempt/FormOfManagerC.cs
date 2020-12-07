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
    public partial class FormOfManagerC : TestAttempt.BasicForm
    {
        public FormOfManagerC()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Authorisation.au.Show();
            Close();
        }

        private void FormOfManagerC_Load(object sender, EventArgs e)
        {
            helloLb.Text = "Добро пожаловать," + Authorisation.em.Surname + " " + Authorisation.em.Name + " " + Authorisation.em.MiddleName + "!";
        }
    }
}
