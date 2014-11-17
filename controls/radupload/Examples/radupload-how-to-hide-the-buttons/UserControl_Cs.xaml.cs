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

#region radupload-how-to-hide-the-buttons_0
private void radUpload_FilesSelected( object sender, Telerik.Windows.Controls.FilesSelectedEventArgs e )
{
    Button uploadButton = this.radUpload.ChildrenOfType<Button>().Where( b => b.Name.Equals( "UploadButton" ) ).FirstOrDefault();
    Button cancelButton = this.radUpload.ChildrenOfType<Button>().Where( b => b.Name.Equals( "CancelButton" ) ).FirstOrDefault();
    if ( uploadButton != null )
    {
        uploadButton.Opacity = 0;
        uploadButton.IsHitTestVisible = false;
    }
    if ( cancelButton != null )
    {
        cancelButton.Opacity = 0;
        cancelButton.IsHitTestVisible = false;
    }
}
#endregion
}
