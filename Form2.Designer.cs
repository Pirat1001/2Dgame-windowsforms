namespace _2D_game_with_windowsform
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.obstacle3 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.hole1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScore)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // txtScore
            // 
            
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Cyan;
            this.txtScore.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(-4, -1);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(167, 36);
            this.txtScore.TabIndex = 9;
            this.txtScore.Tag = "txtScore";
            this.txtScore.Text = "Score: 0";
            this.txtScore.UseMnemonic = false;
            
            // 
            // player
            // 
            this.player.Image = global::_2D_game_with_windowsform.Properties.Resources.tumblr_mafg8kpjQZ1rfjowdo1_r1_500;
            this.player.Location = new System.Drawing.Point(28, 326);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(72, 76);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 11;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.Cyan;
            this.platform.Location = new System.Drawing.Point(-4, 389);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(1048, 82);
            this.platform.TabIndex = 10;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // obstacle3
            // 
            this.obstacle3.BackColor = System.Drawing.Color.Red;
            this.obstacle3.Location = new System.Drawing.Point(562, 369);
            this.obstacle3.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.obstacle3.Name = "obstacle3";
            this.obstacle3.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.obstacle3.Size = new System.Drawing.Size(74, 33);
            this.obstacle3.TabIndex = 14;
            this.obstacle3.TabStop = false;
            this.obstacle3.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.BackColor = System.Drawing.Color.Red;
            this.obstacle2.Location = new System.Drawing.Point(848, 326);
            this.obstacle2.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.obstacle2.Size = new System.Drawing.Size(37, 72);
            this.obstacle2.TabIndex = 15;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // hole1
            // 
            this.hole1.Enabled = false;
            this.hole1.Location = new System.Drawing.Point(265, 389);
            this.hole1.Name = "hole1";
            this.hole1.Size = new System.Drawing.Size(194, 75);
            this.hole1.TabIndex = 16;
            this.hole1.TabStop = false;
            this.hole1.Tag = "hole";
            this.hole1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(664, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "hole";
            this.pictureBox1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(972, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle3);
            this.Controls.Add(this.hole1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtScore);
            this.Name = "Form2";
            this.Text = "Geemo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox obstacle3;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox hole1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}