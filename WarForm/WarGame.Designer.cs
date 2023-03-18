namespace WarForm
{
    partial class WarGame
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelPlayerName1 = new System.Windows.Forms.Label();
            this.labelPlayer1NumCards = new System.Windows.Forms.Label();
            this.labelPlayerName2 = new System.Windows.Forms.Label();
            this.labelPlayer2NumCards = new System.Windows.Forms.Label();
            this.picturePlayer1 = new System.Windows.Forms.PictureBox();
            this.picturePlayer2 = new System.Windows.Forms.PictureBox();
            this.labelCards = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelWinner = new System.Windows.Forms.Label();
            this.labelInactive1 = new System.Windows.Forms.Label();
            this.labelInactive2 = new System.Windows.Forms.Label();
            this.labelInactiveCards1 = new System.Windows.Forms.Label();
            this.labelInactiveCards2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(204, 206);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(78, 20);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelPlayerName1
            // 
            this.labelPlayerName1.AutoSize = true;
            this.labelPlayerName1.Location = new System.Drawing.Point(33, 47);
            this.labelPlayerName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerName1.Name = "labelPlayerName1";
            this.labelPlayerName1.Size = new System.Drawing.Size(47, 15);
            this.labelPlayerName1.TabIndex = 1;
            this.labelPlayerName1.Text = "-name-";
            // 
            // labelPlayer1NumCards
            // 
            this.labelPlayer1NumCards.AutoSize = true;
            this.labelPlayer1NumCards.Location = new System.Drawing.Point(80, 155);
            this.labelPlayer1NumCards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayer1NumCards.Name = "labelPlayer1NumCards";
            this.labelPlayer1NumCards.Size = new System.Drawing.Size(52, 15);
            this.labelPlayer1NumCards.TabIndex = 2;
            this.labelPlayer1NumCards.Text = "player1#";
            // 
            // labelPlayerName2
            // 
            this.labelPlayerName2.AutoSize = true;
            this.labelPlayerName2.Location = new System.Drawing.Point(398, 47);
            this.labelPlayerName2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerName2.Name = "labelPlayerName2";
            this.labelPlayerName2.Size = new System.Drawing.Size(47, 15);
            this.labelPlayerName2.TabIndex = 3;
            this.labelPlayerName2.Text = "-name-";
            // 
            // labelPlayer2NumCards
            // 
            this.labelPlayer2NumCards.AutoSize = true;
            this.labelPlayer2NumCards.Location = new System.Drawing.Point(428, 155);
            this.labelPlayer2NumCards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayer2NumCards.Name = "labelPlayer2NumCards";
            this.labelPlayer2NumCards.Size = new System.Drawing.Size(52, 15);
            this.labelPlayer2NumCards.TabIndex = 4;
            this.labelPlayer2NumCards.Text = "player2#";
            // 
            // picturePlayer1
            // 
            this.picturePlayer1.Image = global::WarForm.Properties.Resources.CardImage;
            this.picturePlayer1.Location = new System.Drawing.Point(27, 77);
            this.picturePlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.picturePlayer1.Name = "picturePlayer1";
            this.picturePlayer1.Size = new System.Drawing.Size(63, 70);
            this.picturePlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayer1.TabIndex = 5;
            this.picturePlayer1.TabStop = false;
            // 
            // picturePlayer2
            // 
            this.picturePlayer2.Image = global::WarForm.Properties.Resources.CardImage;
            this.picturePlayer2.Location = new System.Drawing.Point(384, 77);
            this.picturePlayer2.Margin = new System.Windows.Forms.Padding(2);
            this.picturePlayer2.Name = "picturePlayer2";
            this.picturePlayer2.Size = new System.Drawing.Size(63, 70);
            this.picturePlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayer2.TabIndex = 6;
            this.picturePlayer2.TabStop = false;
            // 
            // labelCards
            // 
            this.labelCards.AutoSize = true;
            this.labelCards.Location = new System.Drawing.Point(2, 155);
            this.labelCards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCards.Name = "labelCards";
            this.labelCards.Size = new System.Drawing.Size(76, 15);
            this.labelCards.TabIndex = 7;
            this.labelCards.Text = "Active Cards:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Active Cards:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(152, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(265, 77);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Location = new System.Drawing.Point(209, 38);
            this.labelWinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(68, 15);
            this.labelWinner.TabIndex = 11;
            this.labelWinner.Text = "Draw cards!";
            // 
            // labelInactive1
            // 
            this.labelInactive1.AutoSize = true;
            this.labelInactive1.Location = new System.Drawing.Point(1, 184);
            this.labelInactive1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInactive1.Name = "labelInactive1";
            this.labelInactive1.Size = new System.Drawing.Size(84, 15);
            this.labelInactive1.TabIndex = 12;
            this.labelInactive1.Text = "Inactive Cards:";
            // 
            // labelInactive2
            // 
            this.labelInactive2.AutoSize = true;
            this.labelInactive2.Location = new System.Drawing.Point(344, 184);
            this.labelInactive2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInactive2.Name = "labelInactive2";
            this.labelInactive2.Size = new System.Drawing.Size(84, 15);
            this.labelInactive2.TabIndex = 13;
            this.labelInactive2.Text = "Inactive Cards:";
            // 
            // labelInactiveCards1
            // 
            this.labelInactiveCards1.AutoSize = true;
            this.labelInactiveCards1.Location = new System.Drawing.Point(94, 184);
            this.labelInactiveCards1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInactiveCards1.Name = "labelInactiveCards1";
            this.labelInactiveCards1.Size = new System.Drawing.Size(13, 15);
            this.labelInactiveCards1.TabIndex = 14;
            this.labelInactiveCards1.Text = "0";
            // 
            // labelInactiveCards2
            // 
            this.labelInactiveCards2.AutoSize = true;
            this.labelInactiveCards2.Location = new System.Drawing.Point(445, 184);
            this.labelInactiveCards2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInactiveCards2.Name = "labelInactiveCards2";
            this.labelInactiveCards2.Size = new System.Drawing.Size(13, 15);
            this.labelInactiveCards2.TabIndex = 15;
            this.labelInactiveCards2.Text = "0";
            this.labelInactiveCards2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WarGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 233);
            this.Controls.Add(this.labelInactiveCards2);
            this.Controls.Add(this.labelInactiveCards1);
            this.Controls.Add(this.labelInactive2);
            this.Controls.Add(this.labelInactive1);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCards);
            this.Controls.Add(this.picturePlayer2);
            this.Controls.Add(this.picturePlayer1);
            this.Controls.Add(this.labelPlayer2NumCards);
            this.Controls.Add(this.labelPlayerName2);
            this.Controls.Add(this.labelPlayer1NumCards);
            this.Controls.Add(this.labelPlayerName1);
            this.Controls.Add(this.buttonDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WarGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WarGame";
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDraw;
        private Label labelPlayerName1;
        private Label labelPlayer1NumCards;
        private Label labelPlayerName2;
        private Label labelPlayer2NumCards;
        private PictureBox picturePlayer1;
        private PictureBox picturePlayer2;
        private Label labelCards;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelWinner;
        private Label labelInactive1;
        private Label labelInactive2;
        private Label labelInactiveCards1;
        private Label labelInactiveCards2;
    }
}