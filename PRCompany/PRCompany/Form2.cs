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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR_CompanyDataSet.Договоры". При необходимости она может быть перемещена или удалена.
            this.договорыTableAdapter.Fill(this.pR_CompanyDataSet.Договоры);

        }

        private void FindButton1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "[Номер договора] Like '%" + FindBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }
    }
}
