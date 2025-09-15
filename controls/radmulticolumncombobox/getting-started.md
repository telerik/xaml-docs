---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadMultiColumnComboBox {{ site.framework_name }} control.
slug: multicolumncombobox-getting-started
tags: getting,started
published: True
position: 3
---

# Getting Started with {{ site.framework_name }} MultiColumnComboBox

This tutorial will walk you through the required steps for using __RadMultiColumnComboBox__. 

* [Adding Telerik Assemblies Using NuGet](#adding-telerik-assemblies-using-nuget)
* [Adding Assembly References Manually](#adding-assembly-references-manually)
* [Adding RadMultiColumnComboBox to the Project](#adding-radmulticolumncombobox-to-the-project)

## Adding Telerik Assemblies Using NuGet

To use __RadMultiColumnComboBox__ when working with NuGet packages, install the `Telerik.Windows.Controls.GridView.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.GridView__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Data__

## Adding RadMultiColumnComboBox to the Project

__Example 1: Defining RadMultiColumnComboBox Declaratively__
```XAML
	<telerik:RadMultiColumnComboBox VerticalAlignment="Top">
    </telerik:RadMultiColumnComboBox>
```

#### __Figure 1: Defining RadMultiColumnComboBox__
![RadMultiColumnComboBox](images/MultiColumnComboBox_GettingStarted_01.png)

Note, that such definition would simply result in having an AutoComplete box. In order to have the actual __RadGridView__ populated as a Content of the DropDown the __GridViewItemsSourceProvider__ needs to be set as an __ItemsSourceProvider__. Note, that the __DisplayMemberPath__ property of __RadMultiColumnComboBox__ is also set. Its purpose is to point to a property of the bound data item present in the source collection of the ItemsSourceProvider. Thus, the control will be aware what value to display in the __AutoCompleteBox__. If not set, the control would simply call the __ToString__ method of the bound item.

#### __[XAML] Example 2: Setting the GridViewItemsSourceProvider
```XAML
	 <telerik:RadMultiColumnComboBox VerticalAlignment="Top" DisplayMemberPath="Name">
            <telerik:RadMultiColumnComboBox.ItemsSourceProvider>
                <telerik:GridViewItemsSourceProvider ItemsSource="{Binding Clubs}" />
            </telerik:RadMultiColumnComboBox.ItemsSourceProvider>
        </telerik:RadMultiColumnComboBox>
```

This definition will have the following output. 

#### __Figure 2: Setting the GridViewItemsSourceProvider__
![RadMultiColumnComboBox](images/MultiColumnComboBox_GettingStarted_02.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadMultiColumnComboBox__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.GridView__
	* __Telerik.Windows.Controls.Input__

__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 3: Merge the ResourceDictionaries__  
```XAML
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.GridView.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
```

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 3__ shows a RadMultiColumnComboBox with the **Windows8** theme applied.

#### __Figure 3: RadMultiColumnComboBox with the Windows8 theme__
![RadMultiColumnComboBox with Windows8 theme](images/radmulticolumncombobox-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF MultiColumnComboBox Component](https://www.telerik.com/products/wpf/multicolumncombobox.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also

* [Overview]({%slug multicolumncombobox-overview%})
