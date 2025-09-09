---
title: EnumDataSource
page_title: EnumDataSource
description: The EnumDataSource utility provides an easy way to bind a control to an Enum.
slug: consuming-data-enumdatasource
tags: enumdatasource
published: True
position: 12
---

# EnumDataSource

This article will describe and show you how to use the **EnumDataSource utility**.

* [Overview](#overview)
* [EnumMemberViewModel](#enummemberviewmodel)
* [Setting up a GridViewComboBoxColumn](#setting-up-a-gridviewcomboboxcolumn)

## Overview

The EnumDataSource utility provides an easy way to bind a [RadComboBox]({%slug radcombobox-getting-started%}) or a [GridViewComboBoxColumn]({%slug radgridview-columns-column-types-combobox-column%}) to an **Enum**.
It will return a collection of viewmodels based on the Enum type supplied. Attributes such as **DisplayAttribute** and **DescriptionAttribute** will be read and stored in the viewmodels, so that friendly names can be displayed in the combo-boxes.

For the purposes of this article, we will use the following enumeration:

#### __[C#] Example 1: The Position enumeration__

```C#
public enum Position
{
	[Display(Name = "Goalkeeper", ShortName = "Goalie")]
	[Description("The player responsible for protecting his team's goal.")]
	GK = 0,
	DF = 1,
	MF = 2,
	FW = 3
}
```
```VB.NET
{{region vb-common-enumdatasource-1}}
Public Enum Position
	<Display(Name := "Goalkeeper", ShortName := "Goalie"), Description("The player responsible for protecting his team's goal.")>
	GK = 0
	DF = 1
	MF = 2
	FW = 3
End Enum
{{endregion}}
```

## EnumMemberViewModel

Calling the generic **FromType<T>** method will return an **IEnumerable** of **EnumMemberViewModel** - one for each [browsable](https://msdn.microsoft.com/en-us/library/system.componentmodel.browsableattribute.browsable) member of the enumeration.

#### __[C#] Example 2: Calling the FromType method__
{{region cs-common-enumdatasource-2}}
	IEnumerable<Telerik.Windows.Data.EnumMemberViewModel> positions;
    public IEnumerable<Telerik.Windows.Data.EnumMemberViewModel> Positions
    {
        get
        {
            if (positions == null)
            {
                positions = Telerik.Windows.Data.EnumDataSource.FromType<Position>();
            }

            return positions;
        }
    }
{{endregion}}

#### __[VB.NET] Example 2: Calling the FromType method__

{{region vb-common-enumdatasource-2}}
	Private _positions As IEnumerable(Of Telerik.Windows.Data.EnumMemberViewModel)
	Public ReadOnly Property Positions() As IEnumerable(Of Telerik.Windows.Data.EnumMemberViewModel)
		Get
			If _positions Is Nothing Then
				_positions = Telerik.Windows.Data.EnumDataSource.FromType(Of Position)()
			End If

			Return _positions
		End Get
	End Property
{{endregion}}

The following list describes the public properties the EnumMemberViewModel class provides as well as the evaluated values for the **Position.GK** member of the enumeration:

* **Description**: Returns the **Description** of the **DescriptionAttribute**, if present. (**"The player responsible for protecting his team's goal."**)
* **DisplayShortName**: Returns the **ShortName** of the **DisplayAttribute**, if present. (**"Goalie"**)
* **Name**: Gets the name of the Enum member. (**"GK"**)
* **Value**: Gets the actual Enum value. (**Position.GK**)
* **DisplayName**: Returns the first of the following properties that is **not null** - **DisplayShortName**, **Description**, **Name**. ("**"Goalie"**")

## Setting up a GridViewComboBoxColumn

A typical use case would be to bind the **DisplayMemberPath** of the combo to the viewmodel's **DisplayName** and **SelectedValueMemberPath** to be equal to **Value**, as demonstrated in **Example 3**.

#### __[XAML] Example 3: Defining the GridViewComboBoxColumn__

{{region xaml-common-enumdatasource-3}}
	<telerik:GridViewComboBoxColumn DataMemberBinding="{Binding Position}"
									ItemsSource="{Binding Positions, Source={StaticResource MyViewModel}}"
									DisplayMemberPath="DisplayName"
									SelectedValueMemberPath="Value" />
{{endregion}}

>A practical example of how to use the EnumDataSource utility can be found in the respective demo of the {% if site.site_name == 'WPF'%}[WPF Controls Samples](https://demos.telerik.com/wpf/){% endif %}{% if site.site_name == 'Silverlight' %}[Silverlight Controls Samples](https://demos.telerik.com/silverlight/#GridView/EnumDataSource){% endif %}.

## See Also

* [RadComboBox]({%slug radcombobox-getting-started%})
* [GridViewComboBoxColumn]({%slug radgridview-columns-column-types-combobox-column%})
