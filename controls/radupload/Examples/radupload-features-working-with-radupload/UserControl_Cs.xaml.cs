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

#region radupload-features-working-with-radupload_1
RadUpload radUpload = new RadUpload();
#endregion

#region radupload-features-working-with-radupload_3
public class SampleUploadHandler : RadUploadHandler
{
}
#endregion
}
