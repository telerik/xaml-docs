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

#region radupload-how-to-implement-simple-authentication_0
public override bool SaveChunkData( string filePath, long position, byte[] buffer, int contentLength, out int savedBytes )
{
    return base.SaveChunkData( filePath, position, buffer, contentLength, out savedBytes );
}
#endregion

#region radupload-how-to-implement-simple-authentication_2
public override bool SaveChunkData( string filePath, long position, byte[] buffer, int contentLength, out int savedBytes )
{
    string authorized = this.GetQueryParameter("Authorized");
    bool isAuthorized = !string.IsNullOrEmpty( authorized ) && authorized.ToLower() == "true";
    if ( !isAuthorized )
    {
    }
    return base.SaveChunkData( filePath, position, buffer, contentLength, out savedBytes );
}
#endregion

#region radupload-how-to-implement-simple-authentication_4
public override bool SaveChunkData( string filePath, long position, byte[] buffer, int contentLength, out int savedBytes )
{
    string authorized = this.GetQueryParameter( "Authorized" );
    bool isAuthorized = !string.IsNullOrEmpty( authorized ) && authorized.ToLower() == "true";
    if ( !isAuthorized )
    {
        this.AddReturnParam( RadUploadConstants.ParamNameMessage, "Security token is required. Please login." );
        string fileName = this.GetQueryParameter( RadUploadConstants.ParamNameFileName );
        this.AddReturnFileParam( RadUploadConstants.ParamNameSuccess, false );
        this.AddReturnFileParam( RadUploadConstants.ParamNameFileName, fileName );
        this.AddReturnFileParam( RadUploadConstants.ParamNameFinalFileRequest, true );
        savedBytes = 0;
        return false;
    }
    return base.SaveChunkData( filePath, position, buffer, contentLength, out savedBytes );
}
#endregion
}
