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

#region radrichtextbox-features-spellcheck_0
private void LoadDictionary( Stream tdfFileStream )
{
    RadDictionary dictionary = new RadDictionary();
    dictionary.Load( tdfFileStream );
    ( ( DocumentSpellChecker )this.radRichTextBox.SpellChecker ).AddDictionary( dictionary, CultureInfo.InvariantCulture );
}
#endregion

#region radrichtextbox-features-spellcheck_2
private void CreateCustomDictionary()
{
    RadIsolatedStorageCustomDictionary dictionary = new RadIsolatedStorageCustomDictionary( IsolatedStorageScope.Site, "CustomDictionary.txt" );
    DocumentSpellChecker spellchecker = new DocumentSpellChecker( dictionary );
    this.radRichTextBox.SpellChecker = spellchecker;
}
#endregion

#region radrichtextbox-features-spellcheck_4
this.radRichTextBox.SpellChecker.AddWord( "RadRichTextBox", CultureInfo.InvariantCulture );
#endregion

#region radrichtextbox-features-spellcheck_6
private void LoadDictionary( Stream tdfFileStream )
{
    RadDictionary dictionary = new RadDictionary();
    dictionary.Load( tdfFileStream );
    ( ( DocumentSpellChecker )this.radRichTextBox.SpellChecker ).AddDictionary( dictionary, new CultureInfo( "de-DE" );
}
#endregion
}
