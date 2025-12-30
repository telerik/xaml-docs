---
title: Spellcheck
page_title: Spellcheck
description: Check our &quot;Spellcheck&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-spellcheck
tags: spellcheck
published: True
---

# Spellcheck


The __RadRichTextBox__ control is designed to support "spell checking as you type" by setting a single property and specifying a proper dictionary to it. This topic explains you the following:

* [Enabling SpellCheck](#enabling-spellcheck)

* [Dictionaries](#dictionaries)

* [Custom Dictionaries](#custom-dictionaries)

* [Adding a Word](#adding-a-word)

* [Internationalization](#internationalization)

## Enabling SpellCheck

To enable or disable the spell-checking functionality, you can use the **IsSpellCheckingEnabled** property on the **RadRichTextBox**. When the property is enabled, you see red wavy underlines below unrecognized words. When the property is *False*, no dictionaries are loaded and no overhead is incurred for spell checking.

As the default value is *True*, the only thing you need to do in order to get a fully functioning spell checker is to add a reference in your project to the __Telerik.Windows.Documents.Proofing.Dictionaries.En-US.dll__ assembly. It contains a built-in English dictionary, which gets automatically added to the __RadRichTextBox__ thanks to the usage of [MEF]({%slug radrichtextbox-mef%}). 

You can customize the spell checker by using the __SpellChecker__ property of __RadRichTextBox__. It is of type __ISpellChecker__. By default an object of type DocumentSpellChecker, which implements the interface, is used for this property. You can either use it or provide your custom class that implements the __ISpellChecker__ interface.

>When spell checking is enabled using **IsSpellCheckingEnabled** property, spell checker is asynchronously invoked in a background thread and marks the words in the document as valid or invalid. If you need to invalidate the words currently marked, you can use RadRichTextBox.**InvalidateProofingErrors(bool)** method.

## Dictionaries

The dictionaries in __RadRichTextBox__ implement the __IWordDictionary__ interface. Easy interoperability with dictionaries from __RadSpell__ for ASP.NET is achieved through the __RadDictionary__ class, which supports the loading of a dictionary directly from the *.tdf files, used with __RadSpell__. You can find TDF dictionaries for some languages [here](https://www.telerik.com/forums/147971-radspell-dictionaries).
        

Here is an example of a __RadDictionary__ loaded from a TDF file.

>When adding a __RadDictionary__ or similar object, use the __AddDictionary(IWordDictionary dictionary, CultureInfo culture)__ method of the __DocumentSpellChecker__. You can also associate a dictionary with a specific culture. The method to remove this dictionary is __RemoveDictionary(CultureInfo culture)__.


__Example 1: Load a dictionary__

```C#
	private void LoadDictionary(Stream tdfFileStream)
	{
	    RadDictionary dictionary = new RadDictionary();
	    dictionary.Load(tdfFileStream);
	    ((DocumentSpellChecker)this.radRichTextBox.SpellChecker).AddDictionary(dictionary, CultureInfo.InvariantCulture);
	}
```
```VB.NET
	Private Sub LoadDictionary(ByVal tdfFileStream As Stream)
	 Dim dictionary As New RadDictionary()
	 dictionary.Load(tdfFileStream)
	 CType(Me.radRichTextBox.SpellChecker, DocumentSpellChecker).AddDictionary(dictionary, CultureInfo.InvariantCulture)
	End Sub
```

>The given example doesn't contain the logic used to read the __TDF__ file as a __Stream__.


## RadWordsDictionary

**RadWordsDictionary** implements the __IWordDictionary__ interface and is capable of reading words from text files that contain one word per line. An example of such files are the **.dic** dictionaries. **Example 2** shows you how to create a RadWordsDictionary instance from a stream.

#### **[C#] Example 2: Load stream in RadWordsDictionary**
```C#
	RadWordsDictionary dictionary = new RadWordsDictionary();
	dictionary.Load(stream);
```

#### **[VB.NET] Example 2: Load stream in RadWordsDictionary**
```VB.NET
	Dim dictionary As New RadWordsDictionary()
	dictionary.Load(stream)
```

One of the constructor overloads of the RadWordsDictionary class enables you to pass a parameter of type **IEnumerable&lt;string&gt;**, which can help you create your own dictionary with a custom set of words.

#### **[C#] Example 3: Create RadWordsDictionary from strings**
```C#
	List<string> words = new List<string>();
	words.Add("Test");
	words.Add("Teacher");
	words.Add("Sister");
	
	RadWordsDictionary dictionary = new RadWordsDictionary();
	dictionary.Load(words);
```

#### **[VB.NET] Example 3: Create RadWordsDictionary from strings**
```VB.NET
    Dim words As New List(Of String)()
    words.Add("Test")
    words.Add("Teacher")
    words.Add("Sister")

    Dim dictionary As New RadWordsDictionary()
    dictionary.Load(words)
```


## Custom Dictionaries

One feature of the __SpellChecker__ in __RadRichTextBox__ is the ability to add a word to a user-defined custom dictionary to enable domain-specific applications. Such a dictionary should implement the __IWordCustomDictionary__ interface. For that, the __RadRichTextBox__ provides you with the __RadIsolatedStorageCustomDictionary__ class out of the box. It allows you to persist the word list in a file located in the {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}’s Isolated Storage.

Here is an example of such a dictionary that adds the words in the "CustomDictionary.txt" marked as a Site-scoped IsolatedSotrageFile.

>The __IsolatedStorageScope__ enumeration has the following values: 
>  *  __Site__: The dictionary defined in this scope is available for each application hosted on the same site.
>  *  __Application__: The dictionary is available only for the particular application.


>tip When adding a dictionary that implements the __ICustomWordDictionary__ interface object use the __AddCustomDictionary(ICustomWordDictionary customDictionary, CultureInfo culture)__ method of the __DocumentSpellChecker__ class. You can also associate a custom dictionary to a specific culture. The method to remove it is __RemoveCustomDictionary(ICustomWordDictionary customDictionary, CultureInfo culture)__.

__Example 4: Creating a custom dictionary__

```C#
	private void CreateCustomDictionary()
	{
	    RadIsolatedStorageCustomDictionary dictionary = new RadIsolatedStorageCustomDictionary(IsolatedStorageScope.Site, "CustomDictionary.txt");
	    DocumentSpellChecker spellchecker = new DocumentSpellChecker(dictionary);
	    this.radRichTextBox.SpellChecker = spellchecker;
	}
```
```VB.NET
	Private Sub CreateCustomDictionary()
	 Dim dictionary As New RadIsolatedStorageCustomDictionary(IsolatedStorageScope.Site, "CustomDictionary.txt")
	 Dim spellchecker As New DocumentSpellChecker(dictionary)
	 Me.radRichTextBox.SpellChecker = spellchecker
	End Sub
```



If you want to have a temporary custom dictionary, which will only be available for a single application session, you can use the __RadNonPersistentCustomDictionary__ object.

## Adding a Word

To add a word to a dictionary you can either use the __AddWord()__ method of the __DocumentSpellChecker__ or of the dictionary itself. Using the AddWord() method, you can add a word to multiple dictionaries associated to the same culture. You can do this by passing the desired culture as a parameter to the method.

>Using the overload of the __AddWord()__ method, which takes only the word as an argument, is equal to using the second overload and passing __CultureInfo.InvariantCulture__ as an argument.

Using the __AddWord()__ method of the dictionary itself adds the word only to the respective dictionary.


__Example 5: Adding a word to a dictionary__

```C#
	this.radRichTextBox.SpellChecker.AddWord("RadRichTextBox", CultureInfo.InvariantCulture);
```
```VB.NET
	Me.radRichTextBox.SpellChecker.AddWord("RadRichTextBox", CultureInfo.InvariantCulture)
```



## Internationalization

The spell-checking component is designed to suit scenarios where different cultures take place in the same application. Internationalization is achieved through associating each dictionary and custom dictionary with a specific culture (or the __InvariantCulture__ as the default one). 

Here is an example.

>The given example doesn't contain the logic used to read the __TDF__ file as a __Stream__.

__Example 6: Loading a dictionary and associating it with a culture__

```C#
    private void LoadDictionaryWithCulture(Stream tdfFileStream)
    {
        RadDictionary dictionary = new RadDictionary();
        dictionary.Load(tdfFileStream);
        ((DocumentSpellChecker)this.radRichTextBox.SpellChecker).AddDictionary(dictionary, new CultureInfo("de-DE"));
    }
```
```VB.NET
	 Private Sub LoadDictionaryWithCulture(ByVal tdfFileStream As Stream)
	 Dim dictionary As New RadDictionary()
	 dictionary.Load(tdfFileStream)
	 CType(Me.radRichTextBox.SpellChecker, DocumentSpellChecker).AddDictionary(dictionary, New CultureInfo("de-DE")
```


