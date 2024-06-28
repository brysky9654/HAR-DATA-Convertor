namespace HAR_DATA_Convertor
{
    partial class MainForm
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
            openButton = new Button();
            startButton = new Button();
            fileList = new ListBox();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.Location = new Point(140, 310);
            openButton.Name = "openButton";
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 1;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += btn_Open_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(275, 310);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 4;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // fileList
            // 
            fileList.FormattingEnabled = true;
            fileList.ItemHeight = 15;
            fileList.Location = new Point(40, 35);
            fileList.Name = "fileList";
            fileList.Size = new Size(400, 244);
            fileList.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(fileList);
            Controls.Add(startButton);
            Controls.Add(openButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HAR-DATA Convertor";
            ResumeLayout(false);
        }

        #endregion
        private Button openButton;
        private Button startButton;
        private ListBox fileList;
    }
}
