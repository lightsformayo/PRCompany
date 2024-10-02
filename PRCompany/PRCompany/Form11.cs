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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR_CompanyDataSet.Отчетная_таблица". При необходимости она может быть перемещена или удалена.
            this.отчетная_таблицаTableAdapter.Fill(this.pR_CompanyDataSet.Отчетная_таблица);

        }

        private void FindButton6_Click(object sender, EventArgs e)
        {
            BindingSource ns = new BindingSource();
            ns.DataSource = dataGridView1.DataSource;
            ns.Filter = "[Название] Like '%" + FindBox6.Text + "%'";
            dataGridView1.DataSource = ns;
        }
    }
}
