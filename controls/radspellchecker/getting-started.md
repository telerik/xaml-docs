---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radspellchecker-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started



__RadSpellChecker__ is a control that allows you to spellcheck a number of controls including __TextBox__, __RichTextBox__, __RadRichTextBox__, __RadGridView__, __DataGrid__ or any other control that complies with certain requirements.

>tip__RadRichTextBox__ has a built-in spell checker (RadDocumentSpellChecker) that provides similar functionality and the benefit of underlining the incorrect words with a red curly line. If you would like to use __RadSpellChecker__ instead of the default spell checker you should disable the document spell checker by setting the property __IsSpellCheckingEnabled__ = ”False”. This can be done, for example, in order to create a similar look of the RadRichTextBoxes and the TextBoxes in your application.
          

* [Using RadSpellChecker with TextBox, RichTextBox or RadRichTextBox ](#using-radspellchecker-with-textbox,-richtextbox-or-radrichtextbox)

* [Using RadSpellChecker with RadGridView or DataGrid ](#using-radspellchecker-with-radgridview-or-datagrid)

## Using RadSpellChecker with TextBox, RichTextBox or RadRichTextBox

>In order to use __RadSpellChecker__ in your project, you need to add a reference to the __Telerik.Windows.Documents.Proofing__ assembly.

After adding reference to the aforementioned dlls, you can use the static class RadSpellChecker and its Check(Control controlToSpellCheck, SpellCheckingMode mode) method.

#### __C#__

{{region radspellchecker-getting-started_0}}
	private void Button_Click(object sender, RoutedEventArgs e)
	{
	   RadSpellChecker.Check(this.textBox1, SpellCheckingMode.WordByWord);
	}
{{endregion}}



For the RadSpellChecker to work properly there is just one more thing you need to provide: a class deriving from RadDictionary which loads a .TDF file containing a dictionary for a specific language. Such a class is defined in “__Telerik.Windows.Documents.Proofing.Dictionaries.En-US__” included in Telerik UI. It contains a dictionary you can use in order to spell check in English. If you reference it in your project, it will be loaded automatically by MEF. 

## Using RadSpellChecker with RadGridView or DataGrid

>In order to use __RadSpellChecker__ on a __RadGridView__ or a __DataGrid__, you need to reference __Telerik.Windows.Documents.Proofing.RadGridView__  or __Telerik.Windows.Documents.Proofing.DataGrid__ respectively.

You can use RadSpellChecker for those controls by adding an attached property to the RadGridView (or DataGrid) itself and to the column you wish to have spellchecked.

>To use the RadSpellChecker in XAML you have to declare the following namespace:

#### __XAML__

{{region radspellchecker-getting-started_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
{{endregion}}



The attached property for Telerik RadGridView is telerik:RadGridViewSpellCheckHelper.IsSpellCheckingEnabled:

#### __XAML__

{{region radspellchecker-getting-started_1}}
	<telerik:RadGridView x:Name="radGridView" telerik:RadGridViewSpellCheckHelper.IsSpellCheckingEnabled="True">
	   <telerik:RadGridView.Columns>
	      <telerik:GridViewDataColumn telerik:RadGridViewSpellCheckHelper.IsSpellCheckingEnabled="True">
	         ...
	      </telerik:GridViewDataColumn>
	   </telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}



And the one for DataGrid is telerik:DataGridSpellCheckHelper.IsSpellCheckingEnabled:

#### __XAML__

{{region radspellchecker-getting-started_2}}
	<sdk:DataGrid x:Name="dataGrid" telerik:DataGridSpellCheckHelper.IsSpellCheckingEnabled="True">
	   <sdk:DataGrid.Columns>
	      <sdk:DataGridTemplateColumn telerik:DataGridSpellCheckHelper.IsSpellCheckingEnabled="True">
	         ...
	      </sdk:DataGridTemplateColumn>
	   </sdk:DataGrid.Columns>
	</sdk:DataGrid>
	{{endregion}}



Of course the GridViewDataColumn (or DataGridTemplateColumn) should contain a single control that can be spellchecked (implements IControlSpellChecker interface). [ReadMore]({%slug radspellchecker-spellchecking-gridcell%})
