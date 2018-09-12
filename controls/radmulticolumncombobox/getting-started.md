---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: multicolumncombobox-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

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
                <telerik:GridViewItemsSourceProvider ItemsSource="{Binding Clubs, Source={StaticResource MyViewModel}}" />
            </telerik:RadMultiColumnComboBox.ItemsSourceProvider>
        </telerik:RadMultiColumnComboBox>
{{endregion}}

This definition will have the following output. 

#### __Figure 2: Setting the GridViewItemsSourceProvider__
![RadMultiColumnComboBox](images/MultiColumnComboBox_GettingStarted_02.png)

## See Also

* [Overview]({%slug multicolumncombobox-overview%})