#region radziplibrary-protect-ziparchive_0
using (Stream stream = File.Open("test.zip", FileMode.Create)) 
{
    DefaultEncryptionSettings encryptionSettings = new DefaultEncryptionSettings(); 
    encryptionSettings.Password = "password"; 
    using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, false, null, null, encryptionSettings)) 
    { 
        using (ZipArchiveEntry entry = archive.CreateEntry("text.txt"))
        { 
            StreamWriter writer = new StreamWriter(entry.Open()); 
            writer.WriteLine("Hello world!"); writer.Flush();
        }
    }
}
#endregion

#region radziplibrary-protect-ziparchive_1
using (Stream stream = File.Open("test.zip", FileMode.Open)) 
{ 
    DefaultEncryptionSettings encryptionSettings = new DefaultEncryptionSettings(); 
    encryptionSettings.Password = "password"; 
    using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Read, false, null,null, encryptionSettings))
    {
        {
            // Display the list of the files in the selected zip file using the ZipArchive.Entries property. 
        }
    }
#endregion