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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR_CompanyDataSet.Отчетная_таблица". При необходимости она может быть перемещена или удалена.
            this.отчетная_таблицаTableAdapter.Fill(this.pR_CompanyDataSet.Отчетная_таблица);

        }

        private void FindButton4_Click(object sender, EventArgs e)
        {
            BindingSource no = new BindingSource();
            no.DataSource = dataGridView1.DataSource;
            no.Filter = "[Организация] Like '%" + FindBox4.Text + "%'";
            dataGridView1.DataSource = no;
        }
    }
}
