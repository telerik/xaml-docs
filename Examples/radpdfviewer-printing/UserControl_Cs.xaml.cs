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

    #region radpdfviewer-printing_0
    PrintSettings settings = new PrintSettings()
    {
        DocumentName = "My document",
        PageMargins = new Thickness(50),
        ForceVector = true
    };
    this.pdfViewer.Print(settings);
    #endregion

    #region radpdfviewer-printing_1
    PrintSettings settings = new PrintSettings()
    {
        DocumentName = "My document",
        PageMargins = new Thickness(50),
        UseDefaultPrinter = true
    };
    this.pdfViewer.Print(settings);
    #endregion

}
