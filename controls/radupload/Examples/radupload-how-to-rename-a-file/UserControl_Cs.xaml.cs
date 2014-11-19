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

#region radupload-how-to-rename-a-file_0
private int counter = 1;
private void radUpload_FileUploadStarting( object sender, FileUploadStartingEventArgs e )
{
    string newFileName = "MyCustomFileName" + counter + e.SelectedFile.File.Extension;
    e.UploadData.FileName = newFileName;
    counter++;
}
#endregion

#region radupload-how-to-rename-a-file_2
private int counter = 1;
public override string GetFilePath( string fileName )
{
    string newFileName = "MyCustomFileName" + counter + fileName.Substring( fileName.LastIndexOf( '.' ) );
    return base.GetFilePath( newFileName );
}
#endregion
}
