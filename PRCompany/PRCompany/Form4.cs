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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR_CompanyDataSet.Сфера_работы_организации_направления". При необходимости она может быть перемещена или удалена.
            this.сфера_работы_организации_направленияTableAdapter.Fill(this.pR_CompanyDataSet.Сфера_работы_организации_направления);

        }
    }
}
