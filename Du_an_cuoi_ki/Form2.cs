using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_an_cuoi_ki
{
    public partial class Dang_nhap : Form
    {
        public Dang_nhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ten=textBox1.Text;
            if (ten.Length > 10)
            {
                MessageBox.Show("Vui long nhap ten khong qua 10 ki tu", "Loi", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Gameplay();
            form.ShowDialog();
        }
    }
}
