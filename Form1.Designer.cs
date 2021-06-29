
namespace FlappyBirdGame
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
            this.scoreLB = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.floor = new System.Windows.Forms.PictureBox();
            this.pipeFloor = new System.Windows.Forms.PictureBox();
            this.pipUp = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeFloor2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeFloor2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLB
            // 
            this.scoreLB.AutoSize = true;
            this.scoreLB.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.scoreLB.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLB.Location = new System.Drawing.Point(12, 411);
            this.scoreLB.Name = "scoreLB";
            this.scoreLB.Size = new System.Drawing.Size(197, 56);
            this.scoreLB.TabIndex = 4;
            this.scoreLB.Text = "score:0";
            this.scoreLB.Click += new System.EventHandler(this.scoreLB_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.floor.Location = new System.Drawing.Point(-40, 370);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(1325, 180);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 3;
            this.floor.TabStop = false;
            // 
            // pipeFloor
            // 
            this.pipeFloor.BackColor = System.Drawing.Color.Transparent;
            this.pipeFloor.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipeFloor.Location = new System.Drawing.Point(269, 314);
            this.pipeFloor.Name = "pipeFloor";
            this.pipeFloor.Size = new System.Drawing.Size(77, 150);
            this.pipeFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeFloor.TabIndex = 2;
            this.pipeFloor.TabStop = false;
            // 
            // pipUp
            // 
            this.pipUp.BackColor = System.Drawing.Color.Transparent;
            this.pipUp.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pipUp.Location = new System.Drawing.Point(507, -147);
            this.pipUp.Name = "pipUp";
            this.pipUp.Size = new System.Drawing.Size(77, 214);
            this.pipUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipUp.TabIndex = 1;
            this.pipUp.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::FlappyBirdGame.Properties.Resources.bird2;
            this.bird.Location = new System.Drawing.Point(87, 85);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(109, 90);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeFloor2
            // 
            this.pipeFloor2.BackColor = System.Drawing.Color.Transparent;
            this.pipeFloor2.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipeFloor2.Location = new System.Drawing.Point(874, 264);
            this.pipeFloor2.Name = "pipeFloor2";
            this.pipeFloor2.Size = new System.Drawing.Size(77, 150);
            this.pipeFloor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeFloor2.TabIndex = 5;
            this.pipeFloor2.TabStop = false;
            this.pipeFloor2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1032, 476);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.scoreLB);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.pipeFloor);
            this.Controls.Add(this.pipUp);
            this.Controls.Add(this.pipeFloor2);
            this.Name = "Form1";
            this.Text = "FlappY Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeFloor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipUp;
        private System.Windows.Forms.PictureBox pipeFloor;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Label scoreLB;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeFloor2;
    }
}

