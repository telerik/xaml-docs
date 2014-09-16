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

#region radspellchecker-multilanguage-support_0
//Here we take the IControlSpellChecker instance for the TextBox Control
IControlSpellChecker controlSpellchecker = ControlSpellCheckersManager.GetControlSpellChecker(typeof(TextBox));
//We get the SpellChecker property and cast it to DocumentSpellChecker (which inherits from ISpellChecker) 
DocumentSpellChecker documentSpellChecker = (DocumentSpellChecker) controlSpellchecker.SpellChecker; 
//Then we set the SpellCheckingCulture of DocumentSpellChecker to Spanish
documentSpellChecker.SpellCheckingCulture = new System.Globalization.CultureInfo("es-ES");
#endregion

#region radspellchecker-multilanguage-support_1
//Here we take the IControlSpellChecker instance for the TextBoxControl
IControlSpellChecker controlSpellchecker = ControlSpellCheckersManager.GetControlSpellChecker(typeof(TextBox));
//We get the SpellChecker property and cast it to DocumentSpellChecker(which inherits from ISpellChecker) 
DocumentSpellChecker documentSpellChecker = (DocumentSpellChecker) controlSpellchecker.SpellChecker; 
//Then we add the class deriving from RadDictionary and the Culture info to the DocumentSpellChecker(we are using Spanish again for the example)
documentSpellChecker.AddDictionary(new RadEs_ESDictionary(), new System.Globalization.CultureInfo("es-ES"));
#endregion

#region radspellchecker-multilanguage-support_2
public class RadEs_ESDictionary : RadDictionary
{
   public RadEs_ESDictionary()
   {
   }
   protected override void EnsureDictionaryLoadedOverride()
   {
        Stream stream = Application.GetResourceStream(new Uri("SpellCheckingInSpanishRRTB;component/es-ES.tdf", UriKind.Relative)).Stream;
        this.Load(stream);
   }
}
#endregion
}
