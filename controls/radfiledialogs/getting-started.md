---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radfiledialogs-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started

This article will provide you with the knowledge required to use the file dialogs in a basic scenario.

## Assembly References

In order to use the file dialog controls, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.GridView__
* __Telerik.Windows.Controls.FileDialogs__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the Telerik UI for WPF suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Using the dialogs

There are few dialogs that you can use in a similar way. __Example 1__ shows how to show a __RadOpenFileDialog__. You can use this code to also show the __open folder__ and __save file__ dialogs.

#### __[C#] Example 1: Opening a dialog__ 
{{regiond radfiledialogs-getting-started-0}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();	
	openFileDialog.Owner = theHostWindowInstance;	
	openFileDialog.ShowDialog();
	if (openFileDialog.DialogResult == true)
	{
		string selectedFileName = openFileDialog.FileName;
	}
{{endregiond}}

You can see how to define and show the different dialogs in the corresponding articles.

* [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%})

* [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%})

* [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%})

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:
* Choose between the [themes]({%slug common-styling-appearance-available-themes%}) and add reference to the corresponding theme assembly (for example: Telerik.Windows.Themes.VisualStudio2013.dll). You see the different themes applied in the Theming examples from our [demos application](http://demos.telerik.com/wpf/).

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For __RadTreeView__, you will need to merge the following resources:
	* __System.Windows.xaml__
	* __Telerik.Windows.Controls.xaml__
	* __Telerik.Windows.Controls.Input.xaml__
	* __Telerik.Windows.Controls.Navigation.xaml__
	* __Telerik.Windows.Controls.GridView.xaml__
	* __Telerik.Windows.Controls.FileDialogs.xaml__	

	__Example 2__ demonstrates where you can merge the ResourceDictionaries so they are applied globally in the application.
	
	#### __[XAML] Example 2: Merging the ResourceDictionaries__  
	{{region radfiledialogs-getting-started-1}}
		<Application x:Class="MyTestApplication.App"
				 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
				 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
				 StartupUri="MainWindow.xaml">
			<Application.Resources>
				<ResourceDictionary>
					<ResourceDictionary.MergedDictionaries>
						<ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2013;component/Themes/Telerik.Windows.Controls.xaml" />
						<ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2013;component/Themes/Telerik.Windows.Controls.Input.xaml" />
						<ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2013;component/Themes/Telerik.Windows.Controls.Navigation.xaml" />
						<ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2013;component/Themes/Telerik.Windows.Controls.GridView.xaml" />
						<ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2013;component/Themes/Telerik.Windows.Controls.FileDialogs.xaml" />
					</ResourceDictionary.MergedDictionaries>
				</ResourceDictionary>
			</Application.Resources>
		</Application>
	{{endregion}}

#### __Figure 1: File dialog with VisualStudio2013 theme applied__
![File dialog with VisualStudio2013 theme applied](images/radfiledialogs-getting-started-01.png)

## See Also
* [Visual Structure]({%slug radfiledialogs-visual-structure%})
* [Events]({%slug radfiledialogs-events%})
