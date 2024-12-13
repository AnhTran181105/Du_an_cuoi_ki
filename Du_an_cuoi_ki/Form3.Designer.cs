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
            this.Player3 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Thua = new System.Windows.Forms.PictureBox();
            this.RacDichuyen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thua)).BeginInit();
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
            // Player3
            // 
            this.Player3.Image = ((System.Drawing.Image)(resources.GetObject("Player3.Image")));
            this.Player3.Location = new System.Drawing.Point(265, 374);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(60, 66);
            this.Player3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player3.TabIndex = 2;
            this.Player3.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.Image = ((System.Drawing.Image)(resources.GetObject("Player2.Image")));
            this.Player2.Location = new System.Drawing.Point(265, 374);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(60, 66);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.Image = ((System.Drawing.Image)(resources.GetObject("Player1.Image")));
            this.Player1.Location = new System.Drawing.Point(265, 374);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(60, 66);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // Thua
            // 
            this.Thua.Image = global::Du_an_cuoi_ki.Properties.Resources.Game_over;
            this.Thua.Location = new System.Drawing.Point(215, 150);
            this.Thua.Name = "Thua";
            this.Thua.Size = new System.Drawing.Size(156, 156);
            this.Thua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Thua.TabIndex = 3;
            this.Thua.TabStop = false;
            // 
            // RacDichuyen
            // 
            this.RacDichuyen.Enabled = true;
            this.RacDichuyen.Interval = 50;
            this.RacDichuyen.Tick += new System.EventHandler(this.RacDichuyen_Tick_1);
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.Thua);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gameplay";
            this.Text = "EcoQuest UEH";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gameplay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Gameplay_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.Timer LeftMove;
        private System.Windows.Forms.Timer RightMove;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox Player3;
        private System.Windows.Forms.PictureBox Thua;
        private System.Windows.Forms.Timer RacDichuyen;
    }
}