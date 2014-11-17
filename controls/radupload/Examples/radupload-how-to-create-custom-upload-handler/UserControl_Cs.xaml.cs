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

#region radupload-how-to-create-custom-upload-handler_0
public class SampleUploadHandler : RadUploadHandler
{
    public override string GetTargetFolder()
    {
        string targetFolder = base.GetTargetFolder();
        //Modify targetFolder
        return targetFolder;
    }
    public override Dictionary<string, object> GetAssociatedData()
    {
        Dictionary<string, object> associatedData = base.GetAssociatedData();
        if ( this.IsFinalFileRequest() )
        {
            associatedData.Add( "MyReturnParam", "MyValue" );
        }
        return associatedData;
    }
}
#endregion
}
