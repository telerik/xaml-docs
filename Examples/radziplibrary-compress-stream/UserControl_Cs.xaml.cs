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

#region radziplibrary-compress-stream_0
ZipOutputStream zipOutputStream = new ZipOutputStream(memoryStream);
#endregion

#region radziplibrary-compress-stream_2
ZipOutputStream zipOutputStream = new ZipOutputStream(memoryStream, ZipCompression.Deflate64);
#endregion

#region radziplibrary-compress-stream_4
ZipInputStream inputStream = new ZipInputStream(compressedStream);
#endregion
}
