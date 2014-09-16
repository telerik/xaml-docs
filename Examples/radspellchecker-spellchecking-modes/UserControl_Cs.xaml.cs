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

#region radspellchecker-spellchecking-modes_0
private void Button_Click( object sender, RoutedEventArgs e )
{
   RadSpellChecker.Check(this.textBox1, SpellCheckingMode.WordByWord);
}
#endregion

#region radspellchecker-spellchecking-modes_1
private void Button_Click( object sender, RoutedEventArgs e )
{
   RadSpellChecker.Check(this.textBox1, SpellCheckingMode.AllAtOnce);
}
#endregion

#region radspellchecker-spellchecking-modes_2
public MainPage()
{
    InitializeComponent();
 
    ControlSpellCheckersManager.RegisterControlSpellChecker(new TextBoxSpellChecker());
 
    ControlSpellCheckersManager.RegisterControlSpellChecker(new RadRichTextBoxSpellChecker());
    IControlSpellChecker controlSpellchecker = ControlSpellCheckersManager.GetControlSpellChecker(typeof(RadRichTextBox));
    ISpellChecker spellChecker = controlSpellchecker.SpellChecker;
    DocumentSpellChecker documentSpellChecker = (DocumentSpellChecker)spellChecker;
    documentSpellChecker.AddDictionary(new RadEn_USDictionary(), new System.Globalization.CultureInfo("en-US"));
}

#endregion
}
