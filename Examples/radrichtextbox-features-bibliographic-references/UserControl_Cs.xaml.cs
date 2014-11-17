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



#region radrichtextbox-features-bibliographic-references_1
BibliographicSource bibliographicSource = new BibliographicSource("test");
bibliographicSource.Author = "authorTest";
bibliographicSource.Title = "titleTest";
bibliographicSource.Editor = "editorTest";
bibliographicSource.SourceType = BibliographicSourceType.Book;
this.editor.Document.BibliographicSources.Add(bibliographicSource);
#endregion

#region radrichtextbox-features-bibliographic-references_2
APAFifthEditionStyle APAFifthEdition = new APAFifthEditionStyle();
this.BibliographicStyles.Add(APAFifthEdition.Key, APAFifthEdition);
 
HarvardAnglia2008Style HarvardAnglia2008 = new HarvardAnglia2008Style();
this.BibliographicStyles.Add(HarvardAnglia2008.Key, HarvardAnglia2008);
 
ISO690_FirstElementAndDateStyle ISO690_FirstElementAndDate = 
new ISO690_FirstElementAndDateStyle();
this.BibliographicStyles.Add(ISO690_FirstElementAndDate.Key, 
ISO690_FirstElementAndDate);
#endregion

#region radrichtextbox-features-bibliographic-references_3
CitationField citationField = new CitationField();
citationField.SourceName = "test";
this.editor.Document.InsertField(citationField, FieldDisplayMode.Result);
#endregion

#region radrichtextbox-features-bibliographic-references_4
BibliographyField bibliographyField = new BibliographyField();
this.editor.Document.InsertField(bibliographyField, FieldDisplayMode.Result);
#endregion

#region radrichtextbox-features-bibliographic-references_5
this.editor.ChangeBibliographicStyle(new HarvardAnglia2008Style());
#endregion

}
