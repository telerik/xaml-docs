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
#region radrichtextbox-features-style-sheets_1
    OpenFileDialog ofd = new OpenFileDialog();
    ofd.Filter = "Xaml Files|*.xaml";
    if (ofd.ShowDialog() == true)
    {
        using (var stream = ofd.OpenFile())
        {
            Stylesheet stylesheet = XamlFormatProvider.LoadStylesheet(stream);
            stylesheet.ApplyStylesheetToDocument(this.editor.Document);
        }
    }
#endregion

#region radrichtextbox-features-style-sheets_3
    OpenFileDialog ofd = new OpenFileDialog();
    ofd.Filter = "Xaml Files|*.xaml";
    if (ofd.ShowDialog() == true)
    {
        using (var stream = ofd.File.OpenRead())
        {
            Stylesheet stylesheet = XamlFormatProvider.LoadStylesheet(stream);
            stylesheet.ApplyStylesheetToDocument(this.editor.Document);
        }
    }
#endregion

#region radrichtextbox-features-style-sheets_5
    SaveFileDialog sfd = new SaveFileDialog();
    sfd.Filter = "Xaml Files|*.xaml";
    if (sfd.ShowDialog() == true)
    {
        using (var stream = sfd.OpenFile())
        {
            Stylesheet stylesheet = new Stylesheet();
            stylesheet.ExtractStylesheetFromDocument(this.editor.Document);
            XamlFormatProvider.SaveStylesheet(stylesheet, stream);
        }
    }
#endregion


}
