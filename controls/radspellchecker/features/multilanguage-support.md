---
title: Multilanguage Support
page_title: Multilanguage Support
description: Check our &quot;Multilanguage Support&quot; documentation article for the RadSpellChecker {{ site.framework_name }} control.
slug: radspellchecker-multilanguage-support
tags: multilanguage,support
published: True
position: 3
---

# Multilanguage Support



## 

__RadSpellChecker__ spell checks words by comparing them to a predefined list, hosted in a dictionary (a .TDF file) associated with a specific language. In __Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}__ you can find the assembly __Telerik.Windows.Documents.Proofing.Dictionaries.En-US__ which contains a class deriving from __RadDicitonary__  that can be used for en-US culture.
        

If you want to use __RadSpellChecker__ with another culture, you need to write your own class implementing __RadDictionary__, in which you have to load the corresponding .TDF file. You can find some available dictionaries [here](http://www.telerik.com/community/forums/aspnet-ajax/spell/147971-radspell-dictionaries.aspx ) or you can write one of your own following the steps described in [this blog post](http://blogs.telerik.com/aspnet-ajax/posts/10-04-29/creating-a-custom-radspell-dictionary.aspx).
        



## __Loading a dictionary through MEF__

>As __RadSpellChecker__ instantiates and loads the classes implementing __RadDictionary__ through __MEF__, when you write your class do not forget to mark it with the __[WordDictionaryMetadata("<associatedCulture>")]__ attribute, providing as argument the appropriate culture.
          

To use RadSpellChecker in Spanish for example, load the corresponding .TDF file and mark the class with __[WordDictionaryMetadata("es-ES")]__ attribute.
        

RadSpellChecker matches every type it supports to an instance of a class deriving from __IControlSpellChecker__. This class contains a property of type __DocumentSpellChecker__, which in turn contains __SpellCheckingCulture__ property of type __CultureInfo__. The __DocumentSpellChecker__ class holds a dictionary matching a CultureInfo to a RadDictionary. By setting __SpellCheckingCulture__ property you simply tell the DocumentSpellChecker to use the dictionary corresponding to that culture.
        

To retrieve the corresponding __IControlSpellChecker__ for your control (in our case TextBox) you can use the static class __ControlSpellCheckersManager__. Here is the code to set the spellchecking culture of RadSpellChecker for the TextBox Control to Spanish:
        

#### __C#__

```C#
	//Here we take the IControlSpellChecker instance for the TextBox Control
	IControlSpellChecker controlSpellchecker = ControlSpellCheckersManager.GetControlSpellChecker(typeof(TextBox));
	//We get the SpellChecker property and cast it to DocumentSpellChecker (which inherits from ISpellChecker) 
	DocumentSpellChecker documentSpellChecker = (DocumentSpellChecker) controlSpellchecker.SpellChecker; 
	//Then we set the SpellCheckingCulture of DocumentSpellChecker to Spanish
	documentSpellChecker.SpellCheckingCulture = new System.Globalization.CultureInfo("es-ES");
```



As __IcontrolSpellChecker.SpellChecker__ property is of type ISpellChecker you need to cast it to DocumentSpellChecker.
        

So, to summarize, thanks to MEF you can load an instance of a class, containing a dictionary for any language, and by setting the SpellCheckingCulture property you switch to that language.



## __Loading a dictionary explicitly__

There is another way to load a dictionary explicitly (without MEF). To achieve that you need to use the __SpellChecker__ property of __IControlSpellChecker__ and cast it to __DocumentSpellChecker__. The cast is needed because DocumentSpellChecker contains a method called __AddDictionary__(__IWordsDictionary__ dictionary, __CultureInfo__ culture) which we can use to add a CultureInfo – RadDictionary pair to the __DocumentSpellChecker__ and thus when we set the SpellCheckingCulture property, it will find the appropriate RadDictionary and use it to generate suggestions.
        

In fact the code here is pretty much the same as the code above:

#### __C#__

```C#
	//Here we take the IControlSpellChecker instance for the TextBoxControl
	IControlSpellChecker controlSpellchecker = ControlSpellCheckersManager.GetControlSpellChecker(typeof(TextBox));
	//We get the SpellChecker property and cast it to DocumentSpellChecker(which inherits from ISpellChecker) 
	DocumentSpellChecker documentSpellChecker = (DocumentSpellChecker) controlSpellchecker.SpellChecker; 
	//Then we add the class deriving from RadDictionary and the Culture info to the DocumentSpellChecker(we are using Spanish again for the example)
	documentSpellChecker.AddDictionary(new RadEs_ESDictionary(), new System.Globalization.CultureInfo("es-ES"));
```



In this case the RadEs_ESDictionary class is located in another assembly and inherits RadDictionary:
        

#### __C#__

```C#
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
```




