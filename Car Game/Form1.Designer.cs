namespace Car_Game
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pause = new System.Windows.Forms.Button();
            this.sound = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.distance = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.vatcan3 = new System.Windows.Forms.PictureBox();
            this.vatcan2 = new System.Windows.Forms.PictureBox();
            this.vatcan1 = new System.Windows.Forms.PictureBox();
            this.cup = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.main = new System.Windows.Forms.PictureBox();
            this.KhungChoi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatcan3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatcan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatcan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            this.KhungChoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.distance);
            this.panel1.Controls.Add(this.start);
            this.panel1.Location = new System.Drawing.Point(530, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 305);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pause);
            this.panel2.Controls.Add(this.sound);
            this.panel2.Controls.Add(this.play);
            this.panel2.Location = new System.Drawing.Point(452, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 63);
            this.panel2.TabIndex = 8;
            // 
            // pause
            // 
            this.pause.Image = global::Car_Game.Properties.Resources.Pause_Hot_icon;
            this.pause.Location = new System.Drawing.Point(4, 3);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(24, 24);
            this.pause.TabIndex = 10;
            this.pause.TabStop = false;
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // sound
            // 
            this.sound.Image = global::Car_Game.Properties.Resources.Volume_Pressed_icon;
            this.sound.Location = new System.Drawing.Point(4, 33);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(24, 24);
            this.sound.TabIndex = 9;
            this.sound.TabStop = false;
            this.sound.UseVisualStyleBackColor = true;
            // 
            // play
            // 
            this.play.Image = global::Car_Game.Properties.Resources.Knob_Play_Green_icon;
            this.play.Location = new System.Drawing.Point(3, 3);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(24, 24);
            this.play.TabIndex = 11;
            this.play.TabStop = false;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Location = new System.Drawing.Point(68, 109);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(35, 13);
            this.distance.TabIndex = 1;
            this.distance.Text = "label1";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(38, 42);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 24);
            this.start.TabIndex = 0;
            this.start.Text = "button1";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::Car_Game.Properties.Resources.background;
            this.roadTrack1.Location = new System.Drawing.Point(0, 0);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(495, 632);
            this.roadTrack1.TabIndex = 5;
            this.roadTrack1.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::Car_Game.Properties.Resources.background;
            this.roadTrack2.Location = new System.Drawing.Point(0, -416);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(495, 632);
            this.roadTrack2.TabIndex = 6;
            this.roadTrack2.TabStop = false;
            // 
            // vatcan3
            // 
            this.vatcan3.Image = global::Car_Game.Properties.Resources.carYellow;
            this.vatcan3.Location = new System.Drawing.Point(368, 63);
            this.vatcan3.Name = "vatcan3";
            this.vatcan3.Size = new System.Drawing.Size(50, 101);
            this.vatcan3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vatcan3.TabIndex = 1;
            this.vatcan3.TabStop = false;
            // 
            // vatcan2
            // 
            this.vatcan2.Image = global::Car_Game.Properties.Resources.carGreen;
            this.vatcan2.Location = new System.Drawing.Point(236, 63);
            this.vatcan2.Name = "vatcan2";
            this.vatcan2.Size = new System.Drawing.Size(50, 101);
            this.vatcan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vatcan2.TabIndex = 1;
            this.vatcan2.TabStop = false;
            // 
            // vatcan1
            // 
            this.vatcan1.Image = global::Car_Game.Properties.Resources.carPink;
            this.vatcan1.Location = new System.Drawing.Point(68, 63);
            this.vatcan1.Name = "vatcan1";
            this.vatcan1.Size = new System.Drawing.Size(50, 101);
            this.vatcan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vatcan1.TabIndex = 1;
            this.vatcan1.TabStop = false;
            // 
            // cup
            // 
            this.cup.Image = global::Car_Game.Properties.Resources.bronze;
            this.cup.Location = new System.Drawing.Point(147, 250);
            this.cup.Name = "cup";
            this.cup.Size = new System.Drawing.Size(250, 100);
            this.cup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cup.TabIndex = 1;
            this.cup.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Silver;
            this.explosion.Image = global::Car_Game.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(222, 433);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 7;
            this.explosion.TabStop = false;
            // 
            // main
            // 
            this.main.Image = global::Car_Game.Properties.Resources.carGrey;
            this.main.Location = new System.Drawing.Point(226, 466);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(50, 101);
            this.main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.main.TabIndex = 1;
            this.main.TabStop = false;
            // 
            // KhungChoi
            // 
            this.KhungChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.KhungChoi.Controls.Add(this.panel2);
            this.KhungChoi.Controls.Add(this.main);
            this.KhungChoi.Controls.Add(this.explosion);
            this.KhungChoi.Controls.Add(this.cup);
            this.KhungChoi.Controls.Add(this.vatcan1);
            this.KhungChoi.Controls.Add(this.vatcan2);
            this.KhungChoi.Controls.Add(this.vatcan3);
            this.KhungChoi.Controls.Add(this.roadTrack2);
            this.KhungChoi.Controls.Add(this.roadTrack1);
            this.KhungChoi.Location = new System.Drawing.Point(12, 12);
            this.KhungChoi.Name = "KhungChoi";
            this.KhungChoi.Size = new System.Drawing.Size(497, 649);
            this.KhungChoi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(694, 652);
            this.Controls.Add(this.KhungChoi);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars Game";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatcan3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatcan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatcan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            this.KhungChoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox vatcan3;
        private System.Windows.Forms.PictureBox vatcan2;
        private System.Windows.Forms.PictureBox vatcan1;
        private System.Windows.Forms.PictureBox cup;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox main;
        private System.Windows.Forms.Panel KhungChoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button sound;
        private System.Windows.Forms.Button play;
    }
}

