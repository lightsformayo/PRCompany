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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR_CompanyDataSet.Отчетная_таблица". При необходимости она может быть перемещена или удалена.
            this.отчетная_таблицаTableAdapter.Fill(this.pR_CompanyDataSet.Отчетная_таблица);

        }

        private void FindButton2_Click(object sender, EventArgs e)
        {
            BindingSource nr = new BindingSource();
            nr.DataSource = dataGridView1.DataSource;
            nr.Filter = "[Номер договора] Like '%" + FindBox2.Text + "%'";
            dataGridView1.DataSource = nr;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
    }

