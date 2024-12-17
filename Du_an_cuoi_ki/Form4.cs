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

        // Hàm tạo bảng với các cột: STT, Tên, Thành tích
        void TaoBang()
        {
            var STT = new DataGridViewTextBoxColumn
            {
                HeaderText = "STT",
                Name = "STT",
                ReadOnly = true
            };

            var Ten = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên",
                Name = "Ten",
                ReadOnly = true
            };

            var Thanh_tich = new DataGridViewTextBoxColumn
            {
                HeaderText = "Thành tích",
                Name = "Thanh_tich",
                ReadOnly = true
            };
            
            // Thêm các cột vào DataGridView
            bang_xep_hang.Columns.AddRange(new DataGridViewColumn[] { STT, Ten, Thanh_tich });
            bang_xep_hang.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            bang_xep_hang.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
        }

        // Hàm đọc dữ liệu từ file và hiển thị lên DataGridView
        void Doc_File(string duong_dan)
        {
            try
            {
                bang_xep_hang.Rows.Clear(); // Xóa dữ liệu cũ trong bảng

                if (File.Exists(duong_dan))
                {
                    var lines = File.ReadAllLines(duong_dan);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        var line = lines[i];
                        var columns = line.Split(','); // Sử dụng ký tự tab làm dấu phân tách

                        if (columns.Length >= 2) // Kiểm tra đủ 2 cột: Tên và Thành tích
                        {
                            bang_xep_hang.Rows.Add(i + 1, columns[0], columns[1]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File không tồn tại. Vui lòng kiểm tra đường dẫn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi đọc file: {ex.Message}");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TaoBang(); // Tạo cấu trúc bảng
            Doc_File("Resources\\ThanhTich.txt"); // Đọc dữ liệu từ file
           
        }
        
    }
}