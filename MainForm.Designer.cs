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
            fileListView = new ListView();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.Location = new Point(95, 305);
            openButton.Name = "openButton";
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 1;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            // 
            // fileListView
            // 
            fileListView.Location = new Point(45, 20);
            fileListView.Name = "fileListView";
            fileListView.Size = new Size(400, 275);
            fileListView.TabIndex = 2;
            fileListView.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(fileListView);
            Controls.Add(openButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HAR-DATA Convertor";
            ResumeLayout(false);
        }

        #endregion
        private Button openButton;
        private ListView fileListView;
    }
}
