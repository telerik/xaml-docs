using System;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using Telerik.Windows.Zip;

namespace RadZipLibraryDocumentationSourceCode.Examples.GettingStarted
{
    public partial class Default_Cs : UserControl
    {
        private void OpenArchive()
        {
            #region radziplibrary-gettingstarted_16
            using (Stream stream = File.Open("test.zip", FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(stream))
                {
                    // Display the list of the files in the selected zip file using the ZipArchive.Entries property.
                }
            }
            #endregion
        }

        private void CreateArchive()
        {
            #region radziplibrary-gettingstarted_17
            using (Stream stream = File.Open("test.zip", FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, false, null))
                {
                    using (ZipArchiveEntry entry = archive.CreateEntry("text.txt"))
                    {
                        StreamWriter writer = new StreamWriter(entry.Open());
                        writer.WriteLine("Hello world!");
                        writer.Flush();
                    }
                }
            }
            #endregion
        }
    }
}