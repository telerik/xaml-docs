public partial class MainPage : UserControl
    {
        static string folderName = "Diagrams";
        static string fileName = "StoreDiagram";
        private static string FullName
        {
            get
            {
                return folderName + "\\" + fileName;
            }
        }
        public MainPage()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            using (var store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (!store.DirectoryExists(folderName))
                {
                    store.CreateDirectory(folderName);
                }

                using (var isoStream = store.OpenFile(FullName, FileMode.OpenOrCreate))
                {
                    var serializationString = this.diagram.Save();
                    var writer = new StreamWriter(isoStream);
                    writer.Write(serializationString);
                    writer.Flush();
                }
            }
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            using (var store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (store.FileExists(FullName))
                {
                    using (var isoStream = store.OpenFile(FullName, FileMode.Open))
                    {
                        if (isoStream != null)
                        {
                            var reader = new StreamReader(isoStream);
                            var stringRead = reader.ReadToEnd();
                            this.diagram.Load(stringRead);
                        }
                    }
                }
            }
        }
    }