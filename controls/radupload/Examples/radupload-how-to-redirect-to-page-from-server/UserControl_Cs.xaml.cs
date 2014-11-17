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

#region radupload-how-to-redirect-to-page-from-server_0
public override Dictionary<string, object> GetAssociatedData()
{
 Dictionary<string, object> associatedData = base.GetAssociatedData();
 if (this.IsFinalFileRequest())
 {
  associatedData.Add(RadUploadConstants.RedirectPage, "http://www.google.com");
 }
  return associatedData;
}
#endregion
}
