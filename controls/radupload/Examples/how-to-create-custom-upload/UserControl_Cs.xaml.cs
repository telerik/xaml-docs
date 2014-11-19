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

#region how-to-create-custom-upload_0
//create a RadUpload to handle the upload
RadUpload upload = new RadUpload;
// get a collection of files from the local system
List<FileInfo> files = new List<FileInfo>();
// add files 
// . . . 
// insert files in the RadUpload
if (files.Count > 0)
{
 foreach (FileInfo file in files)
 {
  RadUploadSelectedFile f = new RadUploadSelectedFile(file);
  upload.CurrentSession.SelectedFiles.Add(f);
 }
//prepare for upload
...
}
#endregion

#region how-to-create-custom-upload_2
// prepare for upload
 this.upload.PrepareSelectedFilesForUpload();
#endregion

#region how-to-create-custom-upload_4
this.upload.StartUpload();
#endregion
}
