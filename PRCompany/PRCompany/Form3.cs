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
    public partial class Form3 : Form
    {
        public Form3()=> InitializeComponent();

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR_CompanyDataSet.Города". При необходимости она может быть перемещена или удалена.
            this.городаTableAdapter.Fill(this.pR_CompanyDataSet.Города);

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Cancel) { e.Cancel = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
