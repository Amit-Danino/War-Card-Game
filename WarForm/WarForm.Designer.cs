namespace WarForm
{
    partial class WarForm
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
            this.DoneButton = new System.Windows.Forms.Button();
            this.LabelPlayer1 = new System.Windows.Forms.Label();
            this.LabelPlayer2 = new System.Windows.Forms.Label();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.LabelChooseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(110, 96);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(78, 20);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // LabelPlayer1
            // 
            this.LabelPlayer1.AutoSize = true;
            this.LabelPlayer1.Location = new System.Drawing.Point(18, 33);
            this.LabelPlayer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPlayer1.Name = "LabelPlayer1";
            this.LabelPlayer1.Size = new System.Drawing.Size(51, 15);
            this.LabelPlayer1.TabIndex = 1;
            this.LabelPlayer1.Text = "Player 1:";
            // 
            // LabelPlayer2
            // 
            this.LabelPlayer2.AutoSize = true;
            this.LabelPlayer2.Location = new System.Drawing.Point(18, 59);
            this.LabelPlayer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPlayer2.Name = "LabelPlayer2";
            this.LabelPlayer2.Size = new System.Drawing.Size(51, 15);
            this.LabelPlayer2.TabIndex = 2;
            this.LabelPlayer2.Text = "Player 2:";
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(83, 33);
            this.tbPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(106, 23);
            this.tbPlayer1.TabIndex = 3;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(83, 59);
            this.tbPlayer2.Margin = new System.Windows.Forms.Padding(2);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(106, 23);
            this.tbPlayer2.TabIndex = 4;
            // 
            // LabelChooseName
            // 
            this.LabelChooseName.AutoSize = true;
            this.LabelChooseName.Location = new System.Drawing.Point(57, 5);
            this.LabelChooseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelChooseName.Name = "LabelChooseName";
            this.LabelChooseName.Size = new System.Drawing.Size(90, 15);
            this.LabelChooseName.TabIndex = 5;
            this.LabelChooseName.Text = "Choose Names:";
            // 
            // WarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 128);
            this.Controls.Add(this.LabelChooseName);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.Controls.Add(this.LabelPlayer2);
            this.Controls.Add(this.LabelPlayer1);
            this.Controls.Add(this.DoneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DoneButton;
        private Label LabelPlayer1;
        private Label LabelPlayer2;
        private TextBox tbPlayer1;
        private TextBox tbPlayer2;
        private Label LabelChooseName;
    }
}