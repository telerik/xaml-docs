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

#region radpdfviewer-troubleshooting-common-problems_0
    pdfViewer.Print(new PrintSettings() { ForceVector = false});
#endregion

#region radpdfviewer-troubleshooting-common-problems_1
    public PdfViewerControl()  
    {  
        if (Application.Current == null)  
        {  
            new Application();  
        }  
        InitializeComponent();  
    }
#endregion

}
