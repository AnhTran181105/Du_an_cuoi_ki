using MediaPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Du_an_cuoi_ki
{
    public partial class Gameplay : Form
    {
        //Các biến
        bool pause = false;
        // Them reference
        WindowsMediaPlayer An_diem;
        WindowsMediaPlayer Tru_diem_nhe;
        WindowsMediaPlayer Tru_diem_nang;
        WindowsMediaPlayer Nhac_nen;
        int player_speed = 4;
        int td_roi=4;
        int diem = 30;
        int diem_max = 0;
        string[,] bang_xep_hang = new string[10, 10];
        string Ten_nguoi_choi;
        Image Rac1 = Properties.Resources.rac1;
        Image Rac2 = Properties.Resources.rac2;
        Image Rac3 = Properties.Resources.rac3;
        private List<PictureBox> racList = new List<PictureBox>();
        private Random rnd = new Random();
        // Gioi han duoi
        Label bottomBorder = new Label();
        int level = 1; // Cấp độ hiện tại
        int pointsToNextLevel = 30; // Số điểm cần để lên cấp
        Image[] RacDanhMuc1 = { Properties.Resources.rac1, Properties.Resources.rac2, Properties.Resources.rac3, Properties.Resources.rac4, Properties.Resources.rac5 };
        Image[] RacDanhMuc2 = { Properties.Resources.rac6, Properties.Resources.rac7, Properties.Resources.rac8, Properties.Resources.rac9, Properties.Resources.rac10 };
        Image[] RacDanhMuc3 = { Properties.Resources.rac11, Properties.Resources.rac12, Properties.Resources.rac13, Properties.Resources.rac14, Properties.Resources.rac15 };
        public Gameplay(string ten)
        {
            InitializeComponent();
            //Ten nguoi choi
            Ten_nguoi_choi = ten;
            // Them am thanh
            An_diem = new WindowsMediaPlayer();
            Tru_diem_nhe = new WindowsMediaPlayer();
            Tru_diem_nang = new WindowsMediaPlayer();
            Nhac_nen = new WindowsMediaPlayer();
            // Tao duong dan
            An_diem.URL = "Sound\\Trừ điểm nhẹ.mp3";
            Tru_diem_nhe.URL = "Sound\\Trừ điểm nhẹ.mp3";
            Tru_diem_nang.URL = "Sound\\Trừ điểm nặng.mp3";
            Nhac_nen.URL = "Sound\\Nhạc nền.mp3";
            // Setting 
            Nhac_nen.settings.setMode("", true);
            Nhac_nen.settings.volume = 15;
            Player2.Visible = false;
            Player3.Visible = false;
            UpdateLevelDisplay();
            SpawnRac();
        }
        void Thanh_tich(string file)
        {
            try
            {
                string [] bang_phu = File.ReadAllLines(file);
                for (int i = 0; i < bang_phu.Length;i++)
                {
                    string[] columns = bang_phu[i].Split('\t');
                    for (int j = 0; j < columns.Length; j++)
                    {
                        bang_xep_hang[i, j] = columns[j].Trim(); 
                    }
                }
            }
            catch (Exception ex) {MessageBox.Show("Đã xảy ra lỗi"); }
        }
        void Ghi_nhan(string file)
        {
            File.Delete(file);
            for(int i = 0;i<bang_xep_hang.GetLength(0);i++)
            {
                string[] row = new string[bang_xep_hang.GetLength(1)];
                for (int j = 0; j < bang_xep_hang.GetLength(1); j++) // Số cột
                {
                    row[j] = bang_xep_hang[i, j];
                }
                File.AppendAllText(file, string.Join("\t", row) + "\n");
            }    
        }

        private void GameOver()
        {
            RacDichuyen.Stop();
            Nhac_nen.controls.stop();
            label1.Visible = true;
            exit.Visible = true;
            REPLAY.Visible = true;
            for (int i = 0; i <10; i++)
            {
                if (bang_xep_hang[i, 1] == "") bang_xep_hang[i, 1] = "0";
                if (diem_max > int.Parse(bang_xep_hang[i,1]))
                {
                    bang_xep_hang[i, 1] = diem_max.ToString();
                    bang_xep_hang[i,0] = Ten_nguoi_choi;
                }
            }
            Ghi_nhan("ThanhTich.txt");

        }

        private void RightMove_Tick(object sender, EventArgs e)
        {
            if (Player1.Visible == true)
            {
                if (Player1.Right < this.Width - 30) Player1.Left += player_speed;
            }
            else if (Player2.Visible == true)
            {
                if (Player2.Right < this.Width - 30) Player2.Left += player_speed;
            }
            else if (Player3.Visible == true)
            {
                if (Player3.Right < this.Width - 30) Player3.Left += player_speed;
            }
        }

        private void LeftMove_Tick(object sender, EventArgs e)
        {
            if (Player1.Visible == true)
            {
                if (Player1.Left > 10) Player1.Left -= player_speed;
            }
            else if (Player2.Visible == true)
            {
                if (Player2.Left > 10) Player2.Left -= player_speed;
            }
            else if (Player3.Visible == true)
            {
                if (Player3.Left > 10) Player3.Left -= player_speed;
            }
        }

        private void Gameplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) RightMove.Start();
            if (e.KeyCode == Keys.Left) LeftMove.Start();
            if (e.KeyCode == Keys.Z)
            {
                if (Player2.Visible == true) Player1.Location = Player2.Location;
                else if (Player3.Visible == true) Player1.Location = Player3.Location;
                Player1.Visible = true;
                Player2.Visible = false;
                Player3.Visible = false;
            }
            else if (e.KeyCode == Keys.X)
            {
                if (Player1.Visible == true) Player2.Location = Player1.Location;
                else if (Player3.Visible == true) Player2.Location = Player3.Location;
                Player1.Visible = false;
                Player2.Visible = true;
                Player3.Visible = false;
            }
            else if (e.KeyCode == Keys.C)
            {
                if (Player1.Visible == true) Player3.Location = Player1.Location;
                else if (Player2.Visible == true) Player3.Location = Player2.Location;
                Player1.Visible = false;
                Player2.Visible = false;
                Player3.Visible = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (!pause)
                {
                    PauseGame();
                }
                else
                {
                    ResumeGame();
                }
            }
        }

            private void PauseGame()
        {
            pause = true;
            RacDichuyen.Stop(); // Dừng Timer rác di chuyển
            RightMove.Stop();   // Dừng Timer di chuyển nhân vật sang phải
            LeftMove.Stop();    // Dừng Timer di chuyển nhân vật sang trái
            Nhac_nen.controls.pause(); // Tạm dừng nhạc nền

            // Hiển thị thông báo Pause (nếu cần)
            label1.Visible = true;
            label1.Text = "PAUSE - PRESS SPACE";
        }

        private void ResumeGame()
        {
            pause = false;
            RacDichuyen.Start(); // Tiếp tục Timer rác di chuyển
            Nhac_nen.controls.play(); // Tiếp tục nhạc nền

            // Ẩn thông báo Pause
            label1.Visible = false;
        }
        

        private void Gameplay_KeyUp(object sender, KeyEventArgs e)
        {
            LeftMove.Stop();
            RightMove.Stop();
        }

        private void SpawnRac()
        {
            int danhMuc = rnd.Next(1, 4); // Chọn danh mục ngẫu nhiên: 1, 2 hoặc 3
            Image selectedImage = null;
            switch (danhMuc)
            {
                case 1:
                    selectedImage = RacDanhMuc1[rnd.Next(0, RacDanhMuc1.Length)]; // Chọn rác từ danh mục 1
                    break;
                case 2:
                    selectedImage = RacDanhMuc2[rnd.Next(0, RacDanhMuc2.Length)]; // Chọn rác từ danh mục 2
                    break;
                case 3:
                    selectedImage = RacDanhMuc3[rnd.Next(0, RacDanhMuc3.Length)]; // Chọn rác từ danh mục 3
                    break;
            }

            int vitriX;
            bool isValidPosition;

            // Đảm bảo rác không trùng vị trí
            do
            {
                isValidPosition = true;
                vitriX = rnd.Next(10, this.ClientSize.Width - 50); // Vị trí ngang ngẫu nhiên

                // Kiểm tra khoảng cách với các rác khác
                foreach (var existingRac in racList)
                {
                    if (Math.Abs(existingRac.Location.X - vitriX) < 50) // Khoảng cách tối thiểu giữa các rác
                    {
                        isValidPosition = false;
                        break;
                    }
                }
            } while (!isValidPosition);

            // Tạo và thêm rác vào danh sách
            PictureBox rac = new PictureBox
            {
                Size = new Size(40, 40),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None,
                Location = new Point(vitriX, -50) // Đặt vị trí ban đầu của rác ở trên cùng, cách đáy màn hình một khoảng
            };

            // Gán hình ảnh rác theo loại và danh mục
            rac.Image = selectedImage;

            // Lưu danh mục của rác vào Tag (1, 2, hoặc 3)
            rac.Tag = danhMuc;

            // Thêm rác vào danh sách và giao diện
            racList.Add(rac);
            this.Controls.Add(rac);
        }

        public void Tang_diem()
        {
            if (diem == null) return;
            diem = diem + 5;
            if (diem > diem_max) diem_max = diem;
            An_diem.controls.play();
            An_diem.settings.volume = 20;
            Scorelabel.Visible = true;
            Scorelabel.Text = $"Score: {diem}";
            if (diem-30 >= pointsToNextLevel)
            {
                level++; // Tăng cấp độ
                pointsToNextLevel += 30; // Tăng ngưỡng điểm cho cấp độ tiếp theo
                td_roi+=level; // Tăng tốc độ rơi rác
                UpdateLevelDisplay(); // Cập nhật giao diện cấp độ
            }

        }
        private void UpdateLevelDisplay()
        {
            LevelLabel.Visible = true;
            LevelLabel.Text = $"Level: {level}";
        }
        public void Tru_nhe()
        {
            diem = diem - 3;
            
            Tru_diem_nhe.controls.play();
            Tru_diem_nhe.settings.volume = 50;
            Scorelabel.Visible = true;
            Scorelabel.Text = $"Score: {diem}";

        }
        public void Tru_nang()
        {
            diem = diem - 1;

            Tru_diem_nang.controls.play();
            Tru_diem_nang.settings.volume = 50;
            Scorelabel.Visible = true;
            Scorelabel.Text = $"Score: {diem}";

        }


        private void RacDichuyen_Tick_1(object sender, EventArgs e)
        {
            bottomBorder.Height = 390;
            bottomBorder.Width = this.Width;
            bottomBorder.Location = new Point(0, this.ClientSize.Height - bottomBorder.Height);
            this.Controls.Add(bottomBorder);

            foreach (var rac in racList.ToList())
            {
                rac.Top += td_roi; // Di chuyển rác xuống với tốc độ thay đổi

                // Kiểm tra nếu rác chạm đáy
                if (rac.Top > bottomBorder.Height)
                {
                    this.Controls.Remove(rac); // Xóa khỏi giao diện
                    racList.Remove(rac);      // Xóa khỏi danh sách
                }

                // Kiểm tra va chạm với từng nhân vật
                if (rac.Bounds.IntersectsWith(Player1.Bounds))
                {
                    HandleCollision(rac, Player1);
                }
                else if (rac.Bounds.IntersectsWith(Player2.Bounds))
                {
                    HandleCollision(rac, Player2);
                }
                else if (rac.Bounds.IntersectsWith(Player3.Bounds))
                {
                    HandleCollision(rac, Player3);
                }
            }

            if (diem <= 0) GameOver();
            if (racList.Count < 3)
            {
                SpawnRac(); // Tạo thêm rác khi số lượng ít
            }
        }

        // Hàm xử lý va chạm giữa rác và nhân vật
        private void HandleCollision(PictureBox rac, PictureBox player)
        {
            int danhMuc = (int)rac.Tag;  // Lấy danh mục của rác từ Tag

            // Kiểm tra nếu nhân vật có thể bắt được loại rác này
            bool isValid = false;

            // Dựa vào danh mục và nhân vật để kiểm tra
            if (player == Player1 && danhMuc == 1) // Player1 có thể bắt loại rác danh mục 1
                isValid = true;
            else if (player == Player2 && danhMuc == 2) // Player2 có thể bắt loại rác danh mục 2
                isValid = true;
            else if (player == Player3 && danhMuc == 3) // Player3 có thể bắt loại rác danh mục 3
                isValid = true;

            if (isValid)
            {
                Tang_diem(); // Truyền vào danh mục để có thể xử lý các điểm khác nhau cho từng loại
            }
            else
            {
                // Logic trừ điểm khi bắt sai loại rác
                Tru_nhe();
            }

            // Xóa rác sau khi va chạm
            this.Controls.Remove(rac);
            racList.Remove(rac);
        }

        private void Gameplay_Load(object sender, EventArgs e)
        {
            label3.Text = Ten_nguoi_choi;
            Thanh_tich("ThanhTich.txt");
        }

        private void REPLAY_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Application.Restart();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        
    }
}
