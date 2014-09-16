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

#region radrichtextbox-features-import-export_0
public string ExportToXAML(RadDocument document)
{
    XamlFormatProvider provider = new XamlFormatProvider();
    return provider.Export(document);
}
#endregion

#region radrichtextbox-features-import-export_2
public void ExportToDocx(RadDocument document)
{
    DocxFormatProvider provider = new DocxFormatProvider();
    SaveFileDialog saveDialog = new SaveFileDialog();
    saveDialog.DefaultExt = ".docx";
    saveDialog.Filter = "Documents|*.docx";
    bool? dialogResult = saveDialog.ShowDialog();
    if (dialogResult == true)
    {
        using (Stream output = saveDialog.OpenFile())
        {
            provider.Export(document, output);
            MessageBox.Show("Saved Successfuly!");
        }
    }
}
#endregion

#region radrichtextbox-features-import-export_4
public RadDocument ImportXaml(string content)
{
    XamlFormatProvider provider = new XamlFormatProvider();
    return provider.Import(content);
}
#endregion

#region radrichtextbox-features-import-export_6
public RadDocument ImportDocx()
{
    RadDocument document = null;
    IDocumentFormatProvider provider = new DocxFormatProvider();
    OpenFileDialog openDialog = new OpenFileDialog();
    openDialog.Filter = "Documents|*.docx";
    openDialog.Multiselect = false;
    bool? dialogResult = openDialog.ShowDialog();
    if (dialogResult == true)
    {
        using (Stream stream = openDialog.OpenFile())
        {
            document = provider.Import(stream);
        }
    }            
    return document;
}

#endregion

#region radrichtextbox-features-import-export_8
public RadDocument ImportDocx()
{
    RadDocument document = null;
    IDocumentFormatProvider provider = new DocxFormatProvider();
    OpenFileDialog openDialog = new OpenFileDialog();
    openDialog.Filter = "Documents|*.docx";
    openDialog.Multiselect = false;
    bool? dialogResult = openDialog.ShowDialog();
    if (dialogResult == true)
    {
        using (Stream stream = openDialog.File.OpenRead())
        {
            document = provider.Import(stream);
        }
    }            
    return document;
}

#endregion
}
