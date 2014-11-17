using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication2
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radpdfviewer-rotation_1
    this.viewer.SetRotationAngle(RotationAngle.Degrees180);
#endregion

#region radpdfviewer-rotation_2
    RotationAngle currentAngle = this.viewer.RotationAngle;
#endregion
}
