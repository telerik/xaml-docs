---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadSpellChecker {{ site.framework_name }} control.
slug: radspellchecker-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} SpellChecker

__RadSpellChecker__ is a control that allows you to spellcheck a number of controls including __TextBox__, __RichTextBox__, __RadRichTextBox__, __RadGridView__, __DataGrid__ or any other control that complies with certain requirements.

>tip__RadRichTextBox__ has a built-in spell checker (RadDocumentSpellChecker) that provides similar functionality and the benefit of underlining the incorrect words with a red curly line. If you would like to use __RadSpellChecker__ instead of the default spell checker you should disable the document spell checker by setting the property __IsSpellCheckingEnabled__ = ”False”. This can be done, for example, in order to create a similar look of the RadRichTextBoxes and the TextBoxes in your application.

## Adding Telerik Assemblies Using NuGet

To use __RadSpellChecker__ when working with NuGet packages, install the `Telerik.Windows.Documents.Proofing.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Documents.Proofing__
* __Telerik.Windows.Documents.Proofing.Dictionaries.En-US__
* __Telerik.Windows.Documents__
* __Telerik.Windows.Documents.Core__
* __Telerik.Windows.Documents.FormatProviders.MsRichTextBoxXaml__

After adding reference to the aforementioned dlls, you can use the static class RadSpellChecker and its Check(Control controlToSpellCheck, SpellCheckingMode mode) method.

```C#
	private void Button_Click(object sender, RoutedEventArgs e)
	{
	   RadSpellChecker.Check(this.textBox1, SpellCheckingMode.WordByWord);
	}
```

For the RadSpellChecker to work properly there is just one more thing you need to provide: a class deriving from RadDictionary which loads a .TDF file containing a dictionary for a specific language. Such a class is defined in “__Telerik.Windows.Documents.Proofing.Dictionaries.En-US__” included in Telerik UI. It contains a dictionary you can use in order to spell check in English. If you reference it in your project, it will be loaded automatically by MEF. 

## Using RadSpellChecker with RadGridView or DataGrid

>In order to use __RadSpellChecker__ on a __RadGridView__ or a __DataGrid__, you need to reference __Telerik.Windows.Documents.Proofing.RadGridView__  or __Telerik.Windows.Documents.Proofing.DataGrid__ respectively.

You can use RadSpellChecker for those controls by adding an attached property to the RadGridView (or DataGrid) itself and to the column you wish to have spellchecked.

>To use the RadSpellChecker in XAML you have to declare the following namespace:

```XAML
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
```

The attached property for Telerik RadGridView is `telerik:RadGridViewSpellCheckHelper.IsSpellCheckingEnabled`:

```XAML
	<telerik:RadGridView x:Name="radGridView" telerik:RadGridViewSpellCheckHelper.IsSpellCheckingEnabled="True">
	   <telerik:RadGridView.Columns>
	      <telerik:GridViewDataColumn telerik:RadGridViewSpellCheckHelper.IsSpellCheckingEnabled="True">
	         ...
	      </telerik:GridViewDataColumn>
	   </telerik:RadGridView.Columns>
	</telerik:RadGridView>
```

And the one for DataGrid is telerik:DataGridSpellCheckHelper.IsSpellCheckingEnabled:

```XAML
	<sdk:DataGrid x:Name="dataGrid" telerik:DataGridSpellCheckHelper.IsSpellCheckingEnabled="True">
	   <sdk:DataGrid.Columns>
	      <sdk:DataGridTemplateColumn telerik:DataGridSpellCheckHelper.IsSpellCheckingEnabled="True">
	         ...
	      </sdk:DataGridTemplateColumn>
	   </sdk:DataGrid.Columns>
	</sdk:DataGrid>
```


Of course the GridViewDataColumn (or DataGridTemplateColumn) should contain a single control that can be spellchecked (implements IControlSpellChecker interface). [ReadMore]({%slug radspellchecker-spellchecking-gridcell%})


## Using RadSpellChecker with Implicit Styles

When the theme is [implictly set]({%slug styling-apperance-implicit-styles-overview%}) in your application, you should merge the required dictionaries. The full list of dictionaries needed for RadSpellChecker is available in the following snippet:

```XAML
    <ResourceDictionary Source="/Telerik.Windows.Themes.Office2019;component/Themes/Telerik.Windows.Controls.xaml"/>
    <ResourceDictionary Source="/Telerik.Windows.Themes.Office2019;component/Themes/Telerik.Windows.Documents.xaml"/>
    <ResourceDictionary Source="/Telerik.Windows.Themes.Office2019;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
    <ResourceDictionary Source="/Telerik.Windows.Themes.Office2019;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
    <ResourceDictionary Source="/Telerik.Windows.Themes.Office2019;component/Themes/Telerik.Windows.Documents.Proofing.xaml"/>
```

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF SpellChecker Component](https://www.telerik.com/products/wpf/spellchecker.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

