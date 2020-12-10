using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TestAttempt.ModelEF;

namespace TestAttempt
{
    public partial class FormOfManagerC : TestAttempt.BasicForm
    {
        Model1 db = new Model1();
        public FormOfManagerC()
        {
            InitializeComponent();
        }

        private void FormOfManagerC_Load(object sender, EventArgs e)
        {
            mallBindingSource.DataSource = db.Mall.ToList();
        }
    }
}
