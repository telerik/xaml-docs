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


#region radpdfviewer-customize-pdf-rendering_0
public class CustomFilter : IPdfFilter
{
    public byte[] Encode(PdfObject encodedObject, byte[] inputData)
    {
        throw new NotImplementedException();
    }

    public byte[] Decode(PdfObject decodedObject, byte[] inputData, DecodeParameters parms)
    {
        throw new NotImplementedException();
    }

    public string Name { get { return PdfFilterNames.CCITTFaxDecode; } }
}
#endregion
    
#region radpdfviewer-customize-pdf-rendering_1
private PDFAndTiffFilter _filter;

public MainPage()
{
    _filter = new PDFAndTiffFilter();
    FiltersManager.RegisterFilter(_filter);
    InitializeComponent();
}
#endregion

#region radpdfviewer-customize-pdf-rendering_2
private PDFAndTiffFilter _filter;

public MainWindow()
{
    _filter = new PDFAndTiffFilter();
    FiltersManager.RegisterFilter(_filter);
    InitializeComponent();
}
#endregion

}
