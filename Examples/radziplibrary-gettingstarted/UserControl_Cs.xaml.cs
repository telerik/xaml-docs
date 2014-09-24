using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radziplibrary-gettingstarted_1
private void buttonOpen_Click(object sender, RoutedEventArgs e)
{
    OpenFileDialog dialog = new OpenFileDialog();
    dialog.Filter = "Zip File | *.zip";
    bool? dialogResult = dialog.ShowDialog();
}
#endregion

#region radziplibrary-gettingstarted_3
if (dialogResult == true)
{
    Stream stream = dialog.File.OpenRead();
    using (ZipPackage zipPackage = ZipPackage.Open(stream, FileAccess.Read))
    {
        //display the list of files compressed in the selected zip file using the zipPackage.ZipPackageEntries
    }
}
#endregion

#region radziplibrary-gettingstarted_5
private void buttonOpen_Click(object sender, RoutedEventArgs e)
{
    OpenFileDialog dialog = new OpenFileDialog();
    dialog.Filter = "Zip File | *.zip";
    bool? dialogResult = dialog.ShowDialog();
    if (dialogResult == true)
    {
        Stream stream = dialog.OpenFile();
        using (ZipPackage zipPackage = ZipPackage.Open(stream, FileAccess.Read))
        {
            //display the list of files compressed in the selected zip file using the zipPackage.ZipPackageEntries
        }
    }
}
#endregion

#region radziplibrary-gettingstarted_8
private void buttonOpen_Click(object sender, RoutedEventArgs e)
{
    OpenFileDialog dialog = new OpenFileDialog();
    dialog.Filter = "Zip File | *.zip";
    bool? dialogResult = dialog.ShowDialog();
    if (dialogResult == true)
    {
        Stream stream = dialog.File.OpenRead();
        using (ZipPackage zipPackage = ZipPackage.Open(stream, FileAccess.Read))
        {
            FileList.ItemsSource = zipPackage.ZipPackageEntries;
        }
    }
}
#endregion

#region radziplibrary-gettingstarted_10
private void buttonOpen_Click(object sender, RoutedEventArgs e)
{
    OpenFileDialog dialog = new OpenFileDialog();
    dialog.Filter = "Zip File | *.zip";
    bool? dialogResult = dialog.ShowDialog();
    if (dialogResult == true)
    {
        Stream stream = dialog.OpenFile();
        using (ZipPackage zipPackage = ZipPackage.Open(stream, FileAccess.Read))
        {
            FileList.ItemsSource = zipPackage.ZipPackageEntries;
        }
    }
}
#endregion

#region radziplibrary-gettingstarted_12
public class DataFile
{
 public MemoryStream FileStream { get; set; }
 public string FileName { get; set; }
}
#endregion

#region radziplibrary-gettingstarted_15
private void buttonSave_Click(object sender, RoutedEventArgs e)
{
    SaveFileDialog dialog = new SaveFileDialog();                
    dialog.Filter = "Zip File | *.zip";              
    bool? dialogResult = dialog.ShowDialog();
    if (dialogResult == true)
    {
        using (ZipPackage zipPackage = ZipPackage.Create(dialog.OpenFile()))
        {
            foreach (DataFile file in SelectedFiles)
            {
                zipPackage.AddStream(file.FileName, file.FileStream);
            }
        }
    }
}
#endregion


#region radziplibrary-gettingstarted_16
using (Stream stream = File.Open("test.zip", FileMode.Open))
{
    using (ZipArchive archive = new ZipArchive(stream))
    {
        // Display the list of the files in the selected zip file using the ZipArchive.Entries property.
    }
}
#endregion

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
