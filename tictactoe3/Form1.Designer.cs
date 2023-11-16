namespace tictactoe3
{
    partial class Form1
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
            pannelchessboard = new Panel();
            textBoxrobot = new TextBox();
            textBoxplayer = new TextBox();
            progressBarrobot = new ProgressBar();
            progressBarplayer = new ProgressBar();
            pictureBoxrobottick = new PictureBox();
            pictureBoxrobot = new PictureBox();
            pictureBoxplayertick = new PictureBox();
            pictureBoxplayer = new PictureBox();
            paneloption = new Panel();
            Playagain = new Button();
            Exit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxrobottick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxrobot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxplayertick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxplayer).BeginInit();
            paneloption.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pannelchessboard
            // 
            pannelchessboard.BackColor = SystemColors.ActiveCaption;
            pannelchessboard.Location = new Point(260, 101);
            pannelchessboard.Name = "pannelchessboard";
            pannelchessboard.Size = new Size(300, 300);
            pannelchessboard.TabIndex = 0;
            pannelchessboard.Paint += panel1_Paint;
            // 
            // textBoxrobot
            // 
            textBoxrobot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxrobot.Location = new Point(81, 34);
            textBoxrobot.Name = "textBoxrobot";
            textBoxrobot.Size = new Size(100, 27);
            textBoxrobot.TabIndex = 9;
            textBoxrobot.TextChanged += textBoxrobot_TextChanged;
            // 
            // textBoxplayer
            // 
            textBoxplayer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxplayer.Location = new Point(19, 34);
            textBoxplayer.Name = "textBoxplayer";
            textBoxplayer.Size = new Size(100, 27);
            textBoxplayer.TabIndex = 8;
            // 
            // progressBarrobot
            // 
            progressBarrobot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            progressBarrobot.Location = new Point(81, 67);
            progressBarrobot.Name = "progressBarrobot";
            progressBarrobot.Size = new Size(100, 27);
            progressBarrobot.TabIndex = 7;
            // 
            // progressBarplayer
            // 
            progressBarplayer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            progressBarplayer.Location = new Point(19, 67);
            progressBarplayer.Name = "progressBarplayer";
            progressBarplayer.Size = new Size(100, 27);
            progressBarplayer.TabIndex = 6;
            // 
            // pictureBoxrobottick
            // 
            pictureBoxrobottick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxrobottick.Image = Properties.Resources._1998595;
            pictureBoxrobottick.Location = new Point(32, 85);
            pictureBoxrobottick.Name = "pictureBoxrobottick";
            pictureBoxrobottick.Size = new Size(25, 22);
            pictureBoxrobottick.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxrobottick.TabIndex = 5;
            pictureBoxrobottick.TabStop = false;
            // 
            // pictureBoxrobot
            // 
            pictureBoxrobot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxrobot.Image = Properties.Resources._222887_200;
            pictureBoxrobot.Location = new Point(12, 34);
            pictureBoxrobot.Name = "pictureBoxrobot";
            pictureBoxrobot.Size = new Size(63, 45);
            pictureBoxrobot.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxrobot.TabIndex = 4;
            pictureBoxrobot.TabStop = false;
            // 
            // pictureBoxplayertick
            // 
            pictureBoxplayertick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxplayertick.Image = Properties.Resources._3515278;
            pictureBoxplayertick.Location = new Point(144, 85);
            pictureBoxplayertick.Name = "pictureBoxplayertick";
            pictureBoxplayertick.Size = new Size(25, 22);
            pictureBoxplayertick.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxplayertick.TabIndex = 2;
            pictureBoxplayertick.TabStop = false;
            // 
            // pictureBoxplayer
            // 
            pictureBoxplayer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxplayer.Image = Properties.Resources._2062361_200__1_;
            pictureBoxplayer.Location = new Point(125, 34);
            pictureBoxplayer.Name = "pictureBoxplayer";
            pictureBoxplayer.Size = new Size(63, 45);
            pictureBoxplayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxplayer.TabIndex = 1;
            pictureBoxplayer.TabStop = false;
            pictureBoxplayer.Click += pictureBox2_Click;
            // 
            // paneloption
            // 
            paneloption.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paneloption.BackColor = SystemColors.ActiveCaption;
            paneloption.Controls.Add(Playagain);
            paneloption.Controls.Add(Exit);
            paneloption.Location = new Point(54, 12);
            paneloption.Name = "paneloption";
            paneloption.Size = new Size(720, 75);
            paneloption.TabIndex = 12;
            // 
            // Playagain
            // 
            Playagain.Location = new Point(19, 19);
            Playagain.Name = "Playagain";
            Playagain.Size = new Size(124, 34);
            Playagain.TabIndex = 1;
            Playagain.Text = "Play again";
            Playagain.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Exit.Location = new Point(569, 19);
            Exit.Name = "Exit";
            Exit.Size = new Size(124, 34);
            Exit.TabIndex = 0;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBoxplayer);
            panel1.Controls.Add(textBoxplayer);
            panel1.Controls.Add(progressBarplayer);
            panel1.Controls.Add(pictureBoxplayertick);
            panel1.Location = new Point(54, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 300);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(progressBarrobot);
            panel2.Controls.Add(textBoxrobot);
            panel2.Controls.Add(pictureBoxrobot);
            panel2.Controls.Add(pictureBoxrobottick);
            panel2.Location = new Point(566, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 300);
            panel2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 469);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(paneloption);
            Controls.Add(pannelchessboard);
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxrobottick).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxrobot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxplayertick).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxplayer).EndInit();
            paneloption.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pannelchessboard;
        private PictureBox pictureBoxrobot;
        private PictureBox pictureBoxplayertick;
        private PictureBox pictureBoxplayer;
        private TextBox textBoxrobot;
        private TextBox textBoxplayer;
        private ProgressBar progressBarrobot;
        private ProgressBar progressBarplayer;
        private PictureBox pictureBoxrobottick;
        private Panel paneloption;
        private Button Exit;
        private Panel panel1;
        private Panel panel2;
        private Button Playagain;
    }
}