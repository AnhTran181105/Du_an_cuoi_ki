namespace Du_an_cuoi_ki
{
    partial class Gameplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
            this.LeftMove = new System.Windows.Forms.Timer(this.components);
            this.RightMove = new System.Windows.Forms.Timer(this.components);
            this.RacDichuyen = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.REPLAY = new System.Windows.Forms.Button();
            this.Scorelabel = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player3 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMove
            // 
            this.LeftMove.Interval = 5;
            this.LeftMove.Tick += new System.EventHandler(this.LeftMove_Tick);
            // 
            // RightMove
            // 
            this.RightMove.Interval = 5;
            this.RightMove.Tick += new System.EventHandler(this.RightMove_Tick);
            // 
            // RacDichuyen
            // 
            this.RacDichuyen.Enabled = true;
            this.RacDichuyen.Interval = 50;
            this.RacDichuyen.Tick += new System.EventHandler(this.RacDichuyen_Tick_1);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(141, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "GAME OVER";
            this.label1.Visible = false;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(192, 156);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(221, 47);
            this.exit.TabIndex = 4;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // REPLAY
            // 
            this.REPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REPLAY.Location = new System.Drawing.Point(192, 210);
            this.REPLAY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.REPLAY.Name = "REPLAY";
            this.REPLAY.Size = new System.Drawing.Size(221, 48);
            this.REPLAY.TabIndex = 5;
            this.REPLAY.Text = "REPLAY";
            this.REPLAY.UseVisualStyleBackColor = true;
            this.REPLAY.Visible = false;
            this.REPLAY.Click += new System.EventHandler(this.REPLAY_Click);
            // 
            // Scorelabel
            // 
            this.Scorelabel.AutoSize = true;
            this.Scorelabel.BackColor = System.Drawing.Color.DarkGreen;
            this.Scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Scorelabel.Location = new System.Drawing.Point(17, 5);
            this.Scorelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Scorelabel.Name = "Scorelabel";
            this.Scorelabel.Size = new System.Drawing.Size(96, 29);
            this.Scorelabel.TabIndex = 6;
            this.Scorelabel.Text = "Score: ";
            this.Scorelabel.Visible = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.message.Location = new System.Drawing.Point(16, 433);
            this.message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(171, 18);
            this.message.TabIndex = 7;
            this.message.Text = "QUY TAC PHAN LOAI";
            this.message.Visible = false;
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LevelLabel.Location = new System.Drawing.Point(456, 17);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(86, 25);
            this.LevelLabel.TabIndex = 8;
            this.LevelLabel.Text = "LEVEL:";
            this.LevelLabel.Visible = false;
            // 
            // Player1
            // 
            this.Player1.Image = global::Du_an_cuoi_ki.Properties.Resources.recycle_bin;
            this.Player1.Location = new System.Drawing.Point(252, 358);
            this.Player1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(84, 81);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // Player3
            // 
            this.Player3.Image = global::Du_an_cuoi_ki.Properties.Resources.trash_can;
            this.Player3.Location = new System.Drawing.Point(252, 358);
            this.Player3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(84, 79);
            this.Player3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player3.TabIndex = 2;
            this.Player3.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.Image = global::Du_an_cuoi_ki.Properties.Resources.organic_waste;
            this.Player2.Location = new System.Drawing.Point(252, 358);
            this.Player2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(80, 81);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Score: ";
            this.label3.Visible = false;
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(581, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Scorelabel);
            this.Controls.Add(this.REPLAY);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gameplay";
            this.Text = "EcoQuest UEH";
            this.Load += new System.EventHandler(this.Gameplay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gameplay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Gameplay_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.Timer LeftMove;
        private System.Windows.Forms.Timer RightMove;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox Player3;
        private System.Windows.Forms.Timer RacDichuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button REPLAY;
        private System.Windows.Forms.Label Scorelabel;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label label3;
    }
}