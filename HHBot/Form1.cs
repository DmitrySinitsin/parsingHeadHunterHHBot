using HHLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HHBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HHModel model = new HHModel();


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Vacancy> vacancies = model.JsonParseStringItems(model.RequestGet("http://api.hh.ru/vacancies?text="+searchBox.Text));
            labelCount.Text = vacancies.Count()+" вакансий всего.";
            GridView.Rows.Clear();

            foreach (Vacancy v in vacancies)
            {
                DataGridViewRow row = (DataGridViewRow)GridView.Rows[0].Clone();
                row.Cells[0].Value = v.id;
                row.Cells[1].Value = v.name;
                row.Cells[2].Value = v.salary_from;
                row.Cells[3].Value = v.salary_to;
                row.Cells[4].Value = v.employer_name;
                row.Cells[5].Value = v.address;
                row.Cells[6].Value = v.info;
                GridView.Rows.Add(row);
            }
        }
    }
}
