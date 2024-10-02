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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void таблицаДоговорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 contracts = new Form2();
            contracts.ShowDialog();
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void таблицаГородаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 city =new Form3();
            city.ShowDialog();
        }

        private void таблицаСфераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 directions = new Form4();
            directions.ShowDialog();
        }

        private void отчетнаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 reports = new Form5();
            reports.ShowDialog();
        }

        private void таблицаУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 services = new Form6();
            services.ShowDialog();
        }

        private void таблицаРаспределительныйЛистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 distributionList = new Form7();
            distributionList.ShowDialog();
        }

        private void поискПоГородуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 sc = new Form8();
            sc.ShowDialog();
        }

        private void поискПоНазваниюОрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 so = new Form9();
            so.ShowDialog();
        }

        private void поискПоНаправлениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 sr = new Form10();
            sr.ShowDialog();
        }

        private void поискПоТипуУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 ss = new Form11();
            ss.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
