#region radziplibrary-update-ziparchive_0
using (Stream stream = File.Open("test.zip", FileMode.Open))
{
    using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Update, false, null))
    {               
        // Display the list of the files in the selected zip file using the ZipArchive.Entries property.
    }
}
#endregion


#region radziplibrary-update-ziparchive_1
using (ZipArchiveEntry entry = archive.CreateEntry("text.txt"))
{
    StreamWriter writer = new StreamWriter(entry.Open());
    writer.WriteLine("Hello world!");
    writer.Flush();
}
#endregion

#region radziplibrary-update-ziparchive_2
ZipArchiveEntry entry = archive.GetEntry("text.txt");
if (entry != null)
{
    entry.Delete();
}
#endregion

#region radziplibrary-update-ziparchive_3
ZipArchiveEntry entry = archive.GetEntry("text.txt");
if (entry != null)
{
    Stream entryStream = entry.Open();
    StreamReader reader = new StreamReader(entryStream);
    string content = reader.ReadToEnd();

    entryStream.Seek(0, SeekOrigin.End);
    StreamWriter writer = new StreamWriter(entryStream);
    writer.WriteLine("Updated line.");
    writer.Flush();
}
#endregion