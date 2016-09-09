---
title: Spellcheck
page_title: Spellcheck
description: Spellcheck
slug: radrichtextbox-features-spellcheck
tags: spellcheck
published: True
---

# Spellcheck


The __RadRichTextBox__ control is designed to support "spell checking as you type" by setting a single property and specifying a proper dictionary to it. This topic will explain you the following:

* [Enabling SpellCheck](#enabling-spellcheck)

* [Dictionaries](#dictionaries)

* [Custom Dictionaries](#custom-dictionaries)

* [Adding a Word](#adding-a-word)

* [Internationalization](#internationalization)

## Enabling SpellCheck

To enable or disable the spell checking functionality (present as red wavy underlines below unrecognized words), you can use the __IsSpellCheckingEnabled__ property on the __RadRichTextBox__. When the property is __False__, no dictionaries are loaded and no overhead is incurred for spell checking. 

As the default value is true, the only thing you need to do in order to get a fully functioning spell checking is to add a reference to the __Telerik.Windows.Documents.Proofing.Dictionaries.En-US.dll__ assembly. It contains a built-in dictionary for English, which gets automatically added to the __RadRichTextBox__ thanks to the usage of MEF. 

You can customize the spell checker by using the __SpellChecker__ property of __RadRichTextBox__. It’s of type __ISpellChecker__. By default an object of type DocumentSpellChecker that implements the interface, is used for this property. You can either use it or provide your custom class that implements the __ISpellChecker__ interface.

## Dictionaries

The dictionaries in __RadRichTextBox__ implement the __IWordDictionary__ interface. Easy interoperability with dictionaries from __RadSpell__ for ASP.NET is achieved through the __RadDictionary__ class, which supports the loading of a dictionary directly from the *.tdf files, used with __RadSpell__. You can find TDF dictionaries for some languages [here](http://www.telerik.com/community/forums/aspnet-ajax/spell/147971-radspell-dictionaries.aspx#576503).
        

Here is an example of a __RadDictionary__ loaded from a TDF file.

>When adding a __RadDictionary__ or similar object use the __AddDictionary(IWordDictionary dictionary, CultureInfo culture)__ method of the __DocumentSpellChecker__. You can also associate a dictionary with a specific culture. The method to remove this dictionary is __RemoveDictionary(CultureInfo culture)__.


#### __[C#] Example 1: Load a dictionary__

{{region radrichtextbox-features-spellcheck_0}}
	private void LoadDictionary(Stream tdfFileStream)
	{
	    RadDictionary dictionary = new RadDictionary();
	    dictionary.Load(tdfFileStream);
	    ((DocumentSpellChecker)this.radRichTextBox.SpellChecker).AddDictionary(dictionary, CultureInfo.InvariantCulture);
	}
{{endregion}}



#### __[VB.NET] Example 1: Load a dictionary__

{{region radrichtextbox-features-spellcheck_1}}
	Private Sub LoadDictionary(ByVal tdfFileStream As Stream)
	 Dim dictionary As New RadDictionary()
	 dictionary.Load(tdfFileStream)
	 CType(Me.radRichTextBox.SpellChecker, DocumentSpellChecker).AddDictionary(dictionary, CultureInfo.InvariantCulture)
	End Sub
{{endregion}}

>The given example doesn't contain the logic used to read the __TDF__ file as a __Stream__.


## RadWordsDictionary

**RadWordsDictionary** implements the __IWordDictionary__ interface and is capable of reading the words from text files containing one word per line. An example of such files are the **.dic** dictionaries. **Example 2** shows you how to create a RadWordsDictionary instance from a stream.

#### **[C#] Example 2: Load stream in RadWordsDictionary**
{{region radrichtextbox-features-spellcheck_8}}
	RadWordsDictionary dictionary = new RadWordsDictionary();
	dictionary.Load(stream);
{{endregion}}

#### **[VB.NET] Example 2: Load stream in RadWordsDictionary**
{{region radrichtextbox-features-spellcheck_9}}
	Dim dictionary As New RadWordsDictionary()
	dictionary.Load(stream)
{{endregion}}

One of the constructor overloads of the RadWordsDictionary class enables you to pass a parameter of type **IEnumerable&lt;string&gt;**, which can help you to create your own dictionary with a custom set of words.

#### **[C#] Example 3: Create RadWordsDictionary from strings**
{{region radrichtextbox-features-spellcheck_10}}
	List<string> words = new List<string>();
	words.Add("Test");
	words.Add("Teacher");
	words.Add("Sister");
	
	RadWordsDictionary dictionary = new RadWordsDictionary();
	dictionary.Load(words);
{{endregion}}

#### **[VB.NET] Example 3: Create RadWordsDictionary from strings**
{{region radrichtextbox-features-spellcheck_11}}
    Dim words As New List(Of String)()
    words.Add("Test")
    words.Add("Teacher")
    words.Add("Sister")

    Dim dictionary As New RadWordsDictionary()
    dictionary.Load(words)
{{endregion}}


## Custom Dictionaries

One feature of the __SpellChecker__ in __RadRichTextBox__ is to add a word to a user-defined custom dictionary to enable domain-specific applications. Such dictionary should implement the __IWordCustomDictionary__ interface. For that purpose, the __RadRichTextBox__ provides you with the __RadIsolatedStorageCustomDictionary__ class out of the box. It allows you to persist the word list in a file located in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}’s Isolated Storage.

Here is an example of such dictionary which adds the words in the "CustomDictionary.txt" marked as a Site-scoped IsolatedSotrageFile.

>The __IsolatedStorageScope__ enumeration has the following values: 
>  *  __Site__ - the dictionary defined in this scope is available for each application hosted on the same site.
>  *  __Application__ - the dictionary is available only for the particular application.


>tipWhen adding a dictionary that implements the __ICustomWordDictionary__ interface object use __AddCustomDictionary(ICustomWordDictionary customDictionary, CultureInfo culture)__ method of the __DocumentSpellChecker__ class. You can also associate a custom dictionary to a specific culture. The method to remove it is __RemoveCustomDictionary(ICustomWordDictionary customDictionary, CultureInfo culture)__.

#### __[C#] Example 4: Creating a custom dictionary__

{{region radrichtextbox-features-spellcheck_2}}
	private void CreateCustomDictionary()
	{
	    RadIsolatedStorageCustomDictionary dictionary = new RadIsolatedStorageCustomDictionary(IsolatedStorageScope.Site, "CustomDictionary.txt");
	    DocumentSpellChecker spellchecker = new DocumentSpellChecker(dictionary);
	    this.radRichTextBox.SpellChecker = spellchecker;
	}
{{endregion}}



#### __[VB.NET] Example 4: Creating a custom dictionary__

{{region radrichtextbox-features-spellcheck_3}}
	Private Sub CreateCustomDictionary()
	 Dim dictionary As New RadIsolatedStorageCustomDictionary(IsolatedStorageScope.Site, "CustomDictionary.txt")
	 Dim spellchecker As New DocumentSpellChecker(dictionary)
	 Me.radRichTextBox.SpellChecker = spellchecker
	End Sub
{{endregion}}



If you want to have a temporary custom dictionary, that will only be available for a single application session, you can use the __RadNonPersistentCustomDictionary__ object.

## Adding a Word

To add a word to a dictionary you can either use the __AddWord()__ method of the __DocumentSpellChecker__ or of the dictionary itself. Using the first one you can add a word to multiple dictionaries associated to the same culture. This is done by passing the desired culture as a parameter to the method.

>Using the overload of the __AddWord()__ method that takes only the word as an argument is equal to using the second overload and passing __CultureInfo.InvariantCulture__ as an argument.

Using the __AddWord()__ method of the dictionary itself will add the word only to the respective dictionary.


#### __[C#] Example 5: Adding a word to a dictionary__

{{region radrichtextbox-features-spellcheck_4}}
	this.radRichTextBox.SpellChecker.AddWord("RadRichTextBox", CultureInfo.InvariantCulture);
{{endregion}}



#### __[VB.NET] Example 5: Adding a word to a dictionary__

{{region radrichtextbox-features-spellcheck_5}}
	Me.radRichTextBox.SpellChecker.AddWord("RadRichTextBox", CultureInfo.InvariantCulture)
{{endregion}}



## Internationalization

The spell checking component is designed to suit scenarios where different cultures take place in the same application. Internationalization is achieved through associating each dictionary and custom dictionary with a specific culture (or the __InvariantCulture__ as the default one). 

Here is an example.

>The given example doesn't contain the logic used to read the __TDF__ file as a __Stream__.

#### __[C#] Example 6: Loading a dictionary and associating it with a culture__

{{region radrichtextbox-features-spellcheck_6}}
    private void LoadDictionaryWithCulture(Stream tdfFileStream)
    {
        RadDictionary dictionary = new RadDictionary();
        dictionary.Load(tdfFileStream);
        ((DocumentSpellChecker)this.radRichTextBox.SpellChecker).AddDictionary(dictionary, new CultureInfo("de-DE"));
    }
{{endregion}}



#### __[VB.NET] Example 6: Loading a dictionary and associating it with a culture__

{{region radrichtextbox-features-spellcheck_7}}
	 Private Sub LoadDictionaryWithCulture(ByVal tdfFileStream As Stream)
	 Dim dictionary As New RadDictionary()
	 dictionary.Load(tdfFileStream)
	 CType(Me.radRichTextBox.SpellChecker, DocumentSpellChecker).AddDictionary(dictionary, New CultureInfo("de-DE")
{{endregion}}


