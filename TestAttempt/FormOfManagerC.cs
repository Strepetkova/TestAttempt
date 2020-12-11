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
        List<Mall> mall = new List<Mall>();
        public FormOfManagerC()
        {
            InitializeComponent();
        }

        private void FormOfManagerC_Load(object sender, EventArgs e)
        {
            mallBindingSource.DataSource = db.Mall.ToList();
            mall = db.Mall.ToList();

            var cityCmb = (from p in db.Mall
                           select p.City).Distinct();
            filterCityCmb.DataSource = cityCmb.ToList();

            var statusCmb = (from p in db.Mall
                             select p.Status).Distinct();
            filterStatusCmb.DataSource = statusCmb.ToList();
        }

        private void filterCityCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (filterCityCmb.SelectedValue == null) return;
            var filterCity = from p in db.Mall
                             where p.City == (string)filterCityCmb.SelectedValue
                             select p;
            mallBindingSource.DataSource = filterCity.ToList();
        }

        private void filterStatusCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (filterStatusCmb.SelectedValue == null) return;
            var filterStatus = from p in db.Mall
                               where p.Status == (string)filterStatusCmb.SelectedValue
                               select p;
            mallBindingSource.DataSource = filterStatus.ToList();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mallBindingSource.DataSource = null;
            mallBindingSource.DataSource = mall;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Authorisation.au.Show();
            Close();
        }

        private void sortCityButton_Click(object sender, EventArgs e)
        {
            List<Mall> mall = (List<Mall>)mallBindingSource.List;
            mall.Sort(SortCity);
            mallBindingSource.DataSource = null;
            mallBindingSource.DataSource = mall;
        }
        int SortCity(Mall m1, Mall m2)
        {
            int MallSort = m1.City.CompareTo(m2.City);
            return MallSort;
        }

        private void sortStatusButton_Click(object sender, EventArgs e)
        {
            List<Mall> mall = (List<Mall>)mallBindingSource.List;
            mall.Sort(SortStatus);
            mallBindingSource.DataSource = null;
            mallBindingSource.DataSource = mall;
        }
        int SortStatus(Mall m1, Mall m2)
        {
            int MallSort2 = m1.Status.CompareTo(m2.Status);
            return MallSort2;
        }
    }
}
