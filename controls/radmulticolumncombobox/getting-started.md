---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadMultiColumnComboBox {{ site.framework_name }} control.
slug: multicolumncombobox-getting-started
tags: getting,started
published: True
position: 1
---

# {{ site.framework_name }} RadMultiColumnComboBox Getting Started

This tutorial will walk you through the required steps for using __RadMultiColumnComboBox__. 

* [Assembly References](#assembly-references)
* [Adding RadMultiColumnComboBox to the Project](#adding-radmulticolumncombobox-to-the-project)

## Assembly References

In order to use __RadMultiColumnComboBox__ in your application, you need to add references to the following assemblies:

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.GridView__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Data__

## Adding RadMultiColumnComboBox to the Project

#### __[XAML] Example 1: Defining RadMultiColumnComboBox Declaratively__
{{region radmulticolumncombobox-gettingstarted_0}}
	<telerik:RadMultiColumnComboBox VerticalAlignment="Top">
    </telerik:RadMultiColumnComboBox>
{{endregion}}

#### __Figure 1: Defining RadMultiColumnComboBox__
![RadMultiColumnComboBox](images/MultiColumnComboBox_GettingStarted_01.png)

Note, that such definition would simply result in having an AutoComplete box. In order to have the actual __RadGridView__ populated as a Content of the DropDown the __GridViewItemsSourceProvider__ needs to be set as an __ItemsSourceProvider__. Note, that the __DisplayMemberPath__ property of __RadMultiColumnComboBox__ is also set. Its purpose is to point to a property of the bound data item present in the source collection of the ItemsSourceProvider. Thus, the control will be aware what value to display in the __AutoCompleteBox__. If not set, the control would simply call the __ToString__ method of the bound item.

#### __[XAML] Example 2: Setting the GridViewItemsSourceProvider
{{region radmulticolumncombobox-gettingstarted_1}}
	 <telerik:RadMultiColumnComboBox VerticalAlignment="Top" DisplayMemberPath="Name">
            <telerik:RadMultiColumnComboBox.ItemsSourceProvider>
                <telerik:GridViewItemsSourceProvider ItemsSource="{Binding Clubs}" />
            </telerik:RadMultiColumnComboBox.ItemsSourceProvider>
        </telerik:RadMultiColumnComboBox>
{{endregion}}

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

#### __[XAML] Example 3: Merge the ResourceDictionaries__  
{{region radmulticolumncombobox-setting-theme-getting-started_6}}
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
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 3__ shows a RadMultiColumnComboBox with the **Windows8** theme applied.

#### __Figure 3: RadMultiColumnComboBox with the Windows8 theme__
![RadMultiColumnComboBox with Windows8 theme](images/radmulticolumncombobox-setting-theme.png)

## See Also

* [Overview]({%slug multicolumncombobox-overview%})