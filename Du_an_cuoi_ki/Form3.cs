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

namespace Du_an_cuoi_ki
{
    public partial class Gameplay : Form
    {
        // Them reference
        WindowsMediaPlayer An_diem;
        WindowsMediaPlayer Tru_diem_nhe;
        WindowsMediaPlayer Tru_diem_nang;
        WindowsMediaPlayer Nhac_nen;
        int player_speed = 4;
        int td_roi=4;
        int diem = 3;
        string[,] bang_xep_hang = new string[10, 10];
        Image Rac1 = Image.FromFile("Picture\\Rác 1.png");
        Image Rac2 = Image.FromFile("Picture\\Rác 2.png");
        Image Rac3 = Image.FromFile("Picture\\Rác 3.png");
        private List<PictureBox> racList = new List<PictureBox>();
        private Random rnd = new Random();
        // Gioi han duoi
        Label bottomBorder = new Label();
        public Gameplay()
        {
            InitializeComponent();
            // Them am thanh
            An_diem = new WindowsMediaPlayer();
            Tru_diem_nhe = new WindowsMediaPlayer();
            Tru_diem_nang = new WindowsMediaPlayer();
            Nhac_nen = new WindowsMediaPlayer();
            // Tao duong dan
            An_diem.URL = "Sound\\Ăn điểm.mp3";
            Tru_diem_nhe.URL = "Sound\\Trừ điểm nhẹ.mp3";
            Tru_diem_nang.URL = "Sound\\Trừ điểm nặng.mp3";
            Nhac_nen.URL = "Sound\\Nhạc nền.mp3";
            // Setting 
            Nhac_nen.settings.setMode("", true);
            Nhac_nen.settings.volume = 15;
            Player2.Visible = false;
            Player3.Visible = false;
            Thua.Visible = false;
            SpawnRac();
        }

        private void GameOver()
        {
            RacDichuyen.Stop();
            Nhac_nen.controls.stop();
            Thua.Visible = true;
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
        }

        private void Gameplay_KeyUp(object sender, KeyEventArgs e)
        {
            LeftMove.Stop();
            RightMove.Stop();
        }

        private void SpawnRac()
        {
            int loaiRac = rnd.Next(1, 4); // Giá trị 1, 2, hoặc 3
            int vitriX;
            // Đảm bảo rác không trùng vị trí
            bool isValidPosition;
            do
            {
                isValidPosition = true;
                vitriX = rnd.Next(10, this.ClientSize.Width - 50); // Vị trí ngang ngẫu nhiên
                if (racList == null)
                {
                    racList = new List<PictureBox>(); // Initialize the racList
                }
                // Kiểm tra khoảng cách với các rác khác
                foreach (var existingRac in racList) // Đổi tên biến trong foreach
                {
                    if (Math.Abs(existingRac.Location.X - vitriX) < 50) // Khoảng cách tối thiểu
                    {
                        isValidPosition = false;
                        break;
                    }
                }
            } while (!isValidPosition);
            PictureBox rac = new PictureBox
            {
                Size = new Size(40, 40),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None,
                Location = new Point(vitriX, -50) // Đặt vị trí ban đầu của rác
            };
            // Gán hình ảnh theo loại rác
            if (loaiRac == 1) rac.Image = Rac1;
            else if (loaiRac == 2) rac.Image = Rac2;
            else rac.Image = Rac3;
            racList.Add(rac); // Thêm rác vào danh sách quản lý
            this.Controls.Add(rac); // Thêm rác vào giao diện
        }


        public void Tang_diem()
        {
            if (diem == null) return;
            diem = diem + 5;
            diem1.Text = $"Diem:{diem}";
            An_diem.controls.play();
            An_diem.settings.volume = 20;
        }
        public void Tru_nhe()
        {
            diem = diem - 3;
            diem1.Text = $"Diem:{diem}";
            Tru_diem_nhe.controls.play();
            Tru_diem_nhe.settings.volume = 50;
        }
        public void Tru_nang()
        {
            diem = diem - 5;
            diem1.Text = $"Diem:{diem}";
            Tru_diem_nang.controls.play();
            Tru_diem_nang.settings.volume = 50;
        }

        private void RacDichuyen_Tick_1(object sender, EventArgs e)
        {
            bottomBorder.Height = 390;
            bottomBorder.Width = this.Width;
            bottomBorder.Location = new Point(0, this.ClientSize.Height - bottomBorder.Height);
            this.Controls.Add(bottomBorder);
            foreach (var rac in racList.ToList())
            {
                rac.Top += td_roi; // Di chuyển rác xuống

                // Kiểm tra nếu rác chạm đáy
                if (rac.Top > bottomBorder.Height)
                {
                    this.Controls.Remove(rac); // Xóa khỏi giao diện
                    racList.Remove(rac);      // Xóa khỏi danh sách
                    Tru_nang();               // Trừ điểm
                }

                // Kiểm tra va chạm với nhân vật (Player)
                if (rac.Bounds.IntersectsWith(Player1.Bounds))
                {
                    // Logic tăng/giảm điểm
                    if (Player1.Visible == true && rac.Image == Rac1) Tang_diem();
                    else Tru_nhe();
                    // Xóa rác sau va chạm
                    this.Controls.Remove(rac);
                    racList.Remove(rac);
                }
                else if (rac.Bounds.IntersectsWith(Player2.Bounds))
                {
                    if (Player2.Visible == true && rac.Image == Rac2) Tang_diem();
                    else Tru_nhe();
                    this.Controls.Remove(rac);
                    racList.Remove(rac);
                }
                else if (rac.Bounds.IntersectsWith(Player3.Bounds))
                {
                    if (Player3.Visible == true && rac.Image == Rac3) Tang_diem();
                    Tru_nhe();
                    this.Controls.Remove(rac);
                    racList.Remove(rac);
                }
            }
            if (diem < 0) GameOver();
            if (racList.Count <3)
            {
                SpawnRac();
            }

        }
    }
}
