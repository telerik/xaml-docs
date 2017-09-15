---
title: Declaratively
page_title: Declaratively
description: Declaratively
slug: radcombobox-populating-with-data-declaratively
tags: declaratively
published: True
position: 1
---

# Declaratively

This tutorial will walk you through the common task of populating __RadComboBox__ with __RadComboBoxItems__ declaratively. 

Here is a regular __RadComboBox__ declaration without items:

#### __XAML__

{{region radcombobox-populating-with-data-declaratively_0}}
	<telerik:RadComboBox x:Name="radComboBox" Width="200">
	</telerik:RadComboBox>
{{endregion}}

![](images/RadComboBox_PopulatingWithData_Declaratively_010.png)

In order to add combobox items you need to use the __RadComboBox__'s __Items__ property. The __Items__ property is an __ItemCollection__ which contains your __RadComboBoxItems__. For example, insert the following lines to the declaration of your __RadComboBox__ and see how it will change.

#### __XAML__

{{region radcombobox-populating-with-data-declaratively_1}}
	<telerik:RadComboBox x:Name="radComboBox" Width="200">
	    <telerik:RadComboBoxItem Content="Alapattah" />
	    <telerik:RadComboBoxItem Content="Brickell Avenue" />
	    <telerik:RadComboBoxItem Content="Downtown Miami" />
	    <telerik:RadComboBoxItem Content="El Portal" />
	    <telerik:RadComboBoxItem Content="Cutler Ridge" />
	    <telerik:RadComboBoxItem Content="Florida City" />
	    <telerik:RadComboBoxItem Content="Homestead" />
	    <telerik:RadComboBoxItem Content="Kendall" />
	    <telerik:RadComboBoxItem Content="Leisure City" />
	    <telerik:RadComboBoxItem Content="Medley" />
	    <telerik:RadComboBoxItem Content="Pinecrest" />
	</telerik:RadComboBox>
{{endregion}}

![](images/RadComboBox_PopulatingWithData_Declaratively_020.png)

>tipConsider declaring combobox items in XAML instead of adding them by code whenever it's possible. This includes situations when you know what items you need at design time.

## See Also

 * [Binding to Object]({%slug radcombobox-populating-with-data-binding-to-object%})

 * [Binding to WCF Service]({%slug radcombobox-populating-with-data-binding-to-wcf%})

 * [Binding to ADO.NET Data Service]({%slug radcombobox-populating-with-data-binding-adonet%})
