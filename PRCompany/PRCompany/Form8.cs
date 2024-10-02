using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRCompany
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR_CompanyDataSet.Отчетная_таблица". При необходимости она может быть перемещена или удалена.
            this.отчетная_таблицаTableAdapter.Fill(this.pR_CompanyDataSet.Отчетная_таблица);

        }

        private void FindButton3_Click(object sender, EventArgs e)
        {
            BindingSource city = new BindingSource();
            city.DataSource = dataGridView1.DataSource;
            city.Filter = "[Город] Like '%" + FindBox3.Text + "%'";
            dataGridView1.DataSource = city;
        }
    }
}
