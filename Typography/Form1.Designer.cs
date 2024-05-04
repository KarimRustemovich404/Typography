namespace Typography
{
    partial class mainForm
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
            inputTextBox = new RichTextBox();
            outputTextBox = new RichTextBox();
            refreshButton = new Button();
            memeLabel1 = new Label();
            memeLabel2 = new Label();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.BorderStyle = BorderStyle.FixedSingle;
            inputTextBox.Cursor = Cursors.IBeam;
            inputTextBox.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            inputTextBox.Location = new Point(16, 71);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(380, 490);
            inputTextBox.TabIndex = 0;
            inputTextBox.Text = "";
            // 
            // outputTextBox
            // 
            outputTextBox.BackColor = SystemColors.Window;
            outputTextBox.BorderStyle = BorderStyle.FixedSingle;
            outputTextBox.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            outputTextBox.Location = new Point(442, 71);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(380, 490);
            outputTextBox.TabIndex = 1;
            outputTextBox.Text = "";
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.White;
            refreshButton.Cursor = Cursors.Hand;
            refreshButton.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.Location = new Point(313, 567);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(216, 37);
            refreshButton.TabIndex = 2;
            refreshButton.Text = "Оттипографировать";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += Refresh;
            // 
            // memeLabel1
            // 
            memeLabel1.AutoSize = true;
            memeLabel1.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            memeLabel1.Location = new Point(169, 9);
            memeLabel1.Name = "memeLabel1";
            memeLabel1.Size = new Size(184, 21);
            memeLabel1.TabIndex = 3;
            memeLabel1.Text = "- Это \"Типограф\"?";
            // 
            // memeLabel2
            // 
            memeLabel2.AutoSize = true;
            memeLabel2.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            memeLabel2.Location = new Point(169, 33);
            memeLabel2.Name = "memeLabel2";
            memeLabel2.Size = new Size(304, 21);
            memeLabel2.TabIndex = 4;
            memeLabel2.Text = "- Да, но это не сайт Лебедева. ";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(834, 631);
            Controls.Add(memeLabel2);
            Controls.Add(memeLabel1);
            Controls.Add(refreshButton);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            MaximizeBox = false;
            Name = "mainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Типограф";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox inputTextBox;
        private RichTextBox outputTextBox;
        private Button refreshButton;
        private Label memeLabel1;
        private Label memeLabel2;
    }
}
