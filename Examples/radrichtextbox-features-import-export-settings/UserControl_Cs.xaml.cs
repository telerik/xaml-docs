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

#region radrichtextbox-features-import-export-settings_0
public void SetupDefaultHtmlFormatProvider()
{
    //Obtain a reference to the format provider used by the default UI - RadRichTextBoxRibbonUI
    HtmlFormatProvider htmlFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension("html") as HtmlFormatProvider;

    HtmlExportSettings htmlExportSettings = new HtmlExportSettings();
    htmlExportSettings.DocumentExportLevel = DocumentExportLevel.Fragment;
    htmlExportSettings.StylesExportMode = StylesExportMode.Inline;
    htmlExportSettings.StyleRepositoryExportMode = StyleRepositoryExportMode.DontExportStyles;
    htmlExportSettings.ExportFontStylesAsTags = true;

    htmlFormatProvider.ExportSettings = htmlExportSettings;
}
#endregion

#region radrichtextbox-features-import-export-settings_1
RtfFormatProvider rtfFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension("rtf") as RtfFormatProvider;
RtfImportSettings rtfImportSettings = new RtfImportSettings();
rtfImportSettings.FontSubstituting += rtfImportSettings_FontSubstituting;
rtfFormatProvider.ImportSettings = rtfImportSettings;

void rtfImportSettings_FontSubstituting(object sender, FontSubstitutingEventArgs e) 
{ 
    if(e.OriginalFontName.Equals("Cambria")
    {
        e.SubstitutionFontFamily = new FontFamily("Calibri");
    }
}
#endregion

#region radrichtextbox-features-import-export-settings_2
public void SetupDefaultDocxFormatProvider()
{
    //Obtain a reference to the format provider used by the default UI - RadRichTextBoxRibbonUI
    DocxFormatProvider docxFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension("docx") as DocxFormatProvider;

    DocxExportSettings docxExportSettings = new DocxExportSettings();
    docxExportSettings.FieldResultMode = FieldDisplayMode.DisplayName;

    docxFormatProvider.ExportSettings = docxExportSettings;
}
#endregion

#region radrichtextbox-features-import-export-settings_3
    HtmlExportSettings htmlExportSettings =new HtmlExportSettings();
    htmlExportSettings.PropertiesToIgnore["span"].Add("color");
    htmlExportSettings.PropertiesToIgnore["span"].Add("text-decoration");
    htmlExportSettings.PropertiesToIgnore["span"].Add("font-weight");
    htmlExportSettings.PropertiesToIgnore["span"].Add("font-style");
    htmlExportSettings.PropertiesToIgnore["span"].Add("font-family");
    htmlExportSettings.PropertiesToIgnore["span"].Add("font-size");
    htmlExportSettings.PropertiesToIgnore["span"].Add("dir");

    htmlExportSettings.PropertiesToIgnore["p"].Add("margin-top");
    htmlExportSettings.PropertiesToIgnore["p"].Add("margin-bottom");
    htmlExportSettings.PropertiesToIgnore["p"].Add("margin-left");
    htmlExportSettings.PropertiesToIgnore["p"].Add("margin-right");
    htmlExportSettings.PropertiesToIgnore["p"].Add("line-height");
    htmlExportSettings.PropertiesToIgnore["p"].Add("text-indent");
    htmlExportSettings.PropertiesToIgnore["p"].Add("text-align");
    htmlExportSettings.PropertiesToIgnore["p"].Add("direction");

    htmlExportSettings.PropertiesToIgnore["table"].Add("border-top");
    htmlExportSettings.PropertiesToIgnore["table"].Add("border-bottom");
    htmlExportSettings.PropertiesToIgnore["table"].Add("border-left");
    htmlExportSettings.PropertiesToIgnore["table"].Add("border-right");
    htmlExportSettings.PropertiesToIgnore["table"].Add("table-layout");
    htmlExportSettings.PropertiesToIgnore["table"].Add("margin-left");
    htmlExportSettings.PropertiesToIgnore["table"].Add("border-spacing");

    htmlExportSettings.PropertiesToIgnore["td"].Add("border-top");
    htmlExportSettings.PropertiesToIgnore["td"].Add("border-bottom");
    htmlExportSettings.PropertiesToIgnore["td"].Add("border-left");
    htmlExportSettings.PropertiesToIgnore["td"].Add("border-right");
    htmlExportSettings.PropertiesToIgnore["td"].Add("padding");
    htmlExportSettings.PropertiesToIgnore["td"].Add("vertical-align");
#endregion
}
