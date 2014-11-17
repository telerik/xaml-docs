  public partial class MainWindow : Window
    {
        private string fileName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Stream fileStream = null;
            try
            {
                var dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == true)
                {
                    fileStream = dialog.OpenFile();
                    this.fileName = dialog.FileName;
                }

                using (fileStream)
                {
                    var serializationString = this.diagram.Save();
                    var writer = new StreamWriter(fileStream);
                    writer.Write(serializationString);
                    writer.Flush();
                }
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }

        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            Stream fileStream = null;
            try
            {
                var dialog = new OpenFileDialog();
                dialog.ShowDialog();
                using (fileStream = dialog.OpenFile())
                {
                    StreamReader reader = new StreamReader(fileStream);
                    using(reader)
                    {
                        string serializedString = reader.ReadToEnd();
                        this.diagram.Load(serializedString);
                    }
                }
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
        }
    }