namespace HAR_DATA_Convertor
{
    public partial class MainForm : Form
    {
        private List<string> filePaths = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Data files (*.data)|*.data|All files (*.*)|*.*";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePaths = openFileDialog.FileNames.ToList();
                    fileNames = filePaths.Select(System.IO.Path.GetFileName).ToList();
                    FileTextBox.Text = string.Join("\r\n", fileNames);
                    string baseDirectory = Path.GetDirectoryName(filePaths[0]);
                    hashCodesFilePath = Path.Combine(baseDirectory, @"..\..\HashCode") + "\\hashCodes.hc";
                }
            }
        }
    }
}
