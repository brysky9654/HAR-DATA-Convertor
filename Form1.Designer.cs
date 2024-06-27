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
            HarFileList = new ListBox();
            SuspendLayout();
            // 
            // HarFileList
            // 
            HarFileList.FormattingEnabled = true;
            HarFileList.ItemHeight = 15;
            HarFileList.Location = new Point(40, 30);
            HarFileList.Margin = new Padding(5);
            HarFileList.Name = "HarFileList";
            HarFileList.Size = new Size(400, 244);
            HarFileList.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(HarFileList);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HAR-DATA Convertor";
            ResumeLayout(false);
        }

        #endregion

        private ListBox HarFileList;
    }
}
