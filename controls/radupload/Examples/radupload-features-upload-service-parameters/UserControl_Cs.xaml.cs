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

#region radupload-features-upload-service-parameters_0
this.radUpload.AdditionalPostFields.Add( "MyParameter", "MyValue" );
#endregion

#region radupload-features-upload-service-parameters_3
private void radUpload_FileUploadStarting( object sender, FileUploadStartingEventArgs e )
{
    e.FileParameters.Add( "MyFileParameter", "MyFileValue" );
}
#endregion

#region radupload-features-upload-service-parameters_5
public override bool SaveChunkData( string filePath, long position, byte[] buffer, int contentLength, out int savedBytes )
{
    string myParam = this.GetQueryParameter( "MyParameter" );
    return base.SaveChunkData( filePath, position, buffer, contentLength, out savedBytes );
}
#endregion

#region radupload-features-upload-service-parameters_7
public override Dictionary<string, object> GetAssociatedData()
{
    Dictionary<string, object> associatedData = base.GetAssociatedData();
    if ( this.IsFinalFileRequest() )
    {
        associatedData.Add( "MyReturnParam", "MyValue" );
    }
    return associatedData;
}
#endregion

#region radupload-features-upload-service-parameters_10
private void radUpload_FileUploaded( object sender, FileUploadedEventArgs e )
{
    var value = e.HandlerData.CustomData[ "MyReturnParam" ];
}
#endregion
}
