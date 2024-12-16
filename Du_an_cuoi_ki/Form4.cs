using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Du_an_cuoi_ki
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        void TaoBang()
        {
            var STT = new DataGridViewTextBoxColumn();
            var Ten = new DataGridViewTextBoxColumn();
            var Thanh_tich = new DataGridViewTextBoxColumn();
            STT.HeaderText = "STT";
            Ten.HeaderText = "Ten";
            Thanh_tich.HeaderText = "Thành tích";
            bang_xep_hang.Columns.AddRange(new DataGridViewColumn[] { STT, Ten, Thanh_tich });
        }
        void Doc_File(string duong_dan)
        {
            try
            {
                if (File.Exists(duong_dan))
                {
                    var lines = File.ReadAllLines(duong_dan);
                    for (int i = 0; i < lines.Length; i++)
                    { 
                        var line = lines[i];
                        var column = line.Split(    );
                        if (column.Length == 3)
                        {
                            bang_xep_hang.Rows.Add(i + 1, column[0], column[1]);
                        }
                    }
                }
                else { MessageBox.Show("File khong ton tai"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi đọc file");
            }

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            TaoBang();
            Doc_File("ThanhTich.txt");
        }
    }
}
