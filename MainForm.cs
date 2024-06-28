namespace HAR_DATA_Convertor
{
    public partial class MainForm : Form
    {
        private List<string> filePaths;
        private List<string> fileNames;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Data files (*.har)|*.har|All files (*.*)|*.*";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePaths = openFileDialog.FileNames.ToList();
                    fileNames = filePaths.Select(System.IO.Path.GetFileName).ToList();

                    foreach (var fileName in fileNames)
                    {
                        fileList.Items.Add(fileName);
                    }
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }
    }
}
