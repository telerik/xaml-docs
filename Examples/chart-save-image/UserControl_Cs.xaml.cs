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

#region chart-save-image_0
MemoryStream chartStream = (MemoryStream)RadChart1.Save();
FileStream outStream = File.OpenWrite(@"C:\MyChart.png");
chartStream.WriteTo(outStream);
outStream.Close();
#endregion

#region chart-save-image_2
chartStream = (MemoryStream)RadChart1.Save(120, 120);
outStream = File.OpenWrite(@"C:\MyChart.png");
chartStream.WriteTo(outStream);
outStream.Close();
#endregion

#region chart-save-image_4
chartStream = (MemoryStream)RadChart1.Save(120, 120, new System.Windows.Media.Imaging.JpegBitmapEncoder());
outStream = File.OpenWrite(@"C:\MyChart.jpg");
chartStream.WriteTo(outStream);
outStream.Close();
#endregion
}
