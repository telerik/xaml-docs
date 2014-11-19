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

#region radupload-how-to-personalize-the-file-storage_0
bool authorized = false;
string accountName = string.Empty;
private void PrepareAccountSession()
{
    string dataAuthorized = this.GetQueryParameter( "Authorized" );
    this.authorized = !string.IsNullOrEmpty( dataAuthorized )
        && dataAuthorized.ToLower() == "true";
    this.accountName = this.GetQueryParameter("Account");
    if ( !this.authorized || string.IsNullOrEmpty( this.accountName ) )
        this.accountName = "Anonymous";
}
#endregion

#region radupload-how-to-personalize-the-file-storage_2
public override string GetTargetFolder()
{
    string path = base.GetTargetFolder();
    if ( !string.IsNullOrEmpty( this.accountName ) )
    {
        path += Path.DirectorySeparatorChar + this.accountName;
    }
    return path;
}
#endregion

#region radupload-how-to-personalize-the-file-storage_4
private bool PrepareStorageFolder()
{
    string folderPath = this.GetTargetFolder();
    if ( !Directory.Exists( folderPath ) )
    {
        Directory.CreateDirectory( folderPath );
    }
    return Directory.Exists( folderPath );
}
#endregion

#region radupload-how-to-personalize-the-file-storage_6
public override bool SaveChunkData(string filePath, long position, byte[] buffer, int contentLength, out int savedBytes)
{
 bool result;
 this.PrepareAccountSession();
 if (!this.PrepareStorageFolder())
 {
  result = false;
 }
 string FilePath = this.GetFilePath();
 result = base.SaveChunkData(FilePath, position, buffer, contentLength, out savedBytes);
 return result;
}
#endregion
}
