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
    #region radrichtextbox-features-watermark_0
		this.editor.SetWatermark(Telerik.Windows.Documents.Model.PredefinedWatermarkType.Confidential);
    #endregion
	
    #region radrichtextbox-features-watermark_1
		WatermarkTextSettings textSettings = new WatermarkTextSettings();
		textSettings.Text = "Purple Watermark";
		textSettings.RotateAngle = 30;
		textSettings.Opacity = 1;
		textSettings.ForegroundColor = Colors.Purple;

		this.editor.SetWatermarkText(textSettings);
	#endregion
	
	#region radrichtextbox-features-watermark_2
		WatermarkImageSettings imageSettings = new WatermarkImageSettings();
		imageSettings.UriSource = uri; 
		imageSettings.Size = new Size(500, 665);

		this.editor.SetWatermarkImage(imageSettings);
	#endregion
}
