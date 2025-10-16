---
title: Selection
page_title: Selection
description: This article demonstrates the Selection functionality of the RadPropertyGrid.
slug: radpropertygrid-selection
tags: selection
published: True
position: 9
---

# Selection

**RadPropertyGrid** provides you with a selection functionality, which allows the user to select one or more items from the data displayed by the control.

## Selection Modes

RadPropertyGrid provides three selection modes, which allow you to manipulate the type of selection. This is controlled by the **SelectionMode** enumeration property which has the following entries:

* __Single__: Only one item can be selected at a time. __(default value)__

* __Multiple__: Items are added to the selection when they get clicked and get removed when they get clicked again.

* __Extended__: Items are added to the selection only by combining the mouse clicks with the __Ctrl__ or __Shift__ key.

__Example 1: Setting the SelectionMode to Multiple__

```XAML
	 <telerik:RadPropertyGrid x:Name="propertyGrid"
                              SelectionMode="Multiple"
                              RenderMode="Flat" />
```

__Example 2: Setting the SelectionMode to Multiple__

```C#
	this.propertyGrid.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
```
```VB.NET
	Me.propertyGrid.SelectionMode = System.Windows.Controls.SelectionMode.Multiple
```

>tip Pressing __Ctrl+A__ will select all items.

## Selected items

RadPropertyGrid provides two properties to get the data behind the selected items - __SelectedPropertyDefinition__ and __SelectedPropertyDefinitions__.
        
* __SelectedPropertyDefinition__: The business object that sits behind the selected Property Definition.

* __SelectedPropertyDefinitions__: A collection of the business objects that sits behind the selected Property Definitions. It will contain more than one item when the __SelectionMode__ is either __Multiple__ or __Extended__.

__Example 3: Binding to SelectedPropertyDefinition__
```XAML
	 <telerik:RadPropertyGrid x:Name="propertyGrid"
                              RenderMode="Flat"           
                              SelectedPropertyDefinition="{Binding SelectedDefinition, Mode=TwoWay}" />
```

__Example 4: The viewmodel's SelectedDefinition property__
```C#
    public class ViewModel : ViewModelBase
    {
        private object selectedDefinition;

        public object SelectedDefinition
        {
            get { return selectedDefinition; }
            set
            {
                if (value != this.selectedDefinition)
                {
                    this.selectedDefinition = value;
                    this.OnPropertyChanged("SelectedDefinition");
                }
            }
        }
    }
```
```VB.NET
    Public Class ViewModel
	Inherits ViewModelBase

		Private _selectedDefinition As Object

		Public Property SelectedDefinition() As Object
			Get
				Return _selectedDefinition
			End Get
			Set(ByVal value As Object)
				If value IsNot Me._selectedDefinition Then
					Me._selectedDefinition = value
					Me.OnPropertyChanged("SelectedDefinition")
				End If
			End Set
		End Property
End Class
```

>cautionAs of R2 2016, the **SelectedField** property, previously marked as obsolete, has officially been removed.

## Events

There is a single event relevant to the selection in RadPropertyGrid - __SelectionChanged__. As suggested by its name, it occurs when the selected property definition has changed.

__Example 5: Adding a handler for the SelectionChanged event__
```XAML
    <telerik:RadPropertyGrid x:Name="propertyGrid"
                             RenderMode="Flat"
                             SelectionChanged="propertyGrid_SelectionChanged">
```

__Example 6: SelectionChanged event handler__

```C#
	private void propertyGrid_SelectionChanged(object sender, SelectionChangeEventArgs e)
    {
        var propertyDefinition = e.AddedItems[0] as PropertyDefinition;
        MessageBox.Show($"You selected property definition with DisplayName: {propertyDefinition.DisplayName}");
    }
```
```VB.NET
	Private Sub propertyGrid_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangeEventArgs)
		Dim propertyDefinition = TryCast(e.AddedItems(0), PropertyDefinition)
		MessageBox.Show($"You selected property definition with DisplayName: {propertyDefinition.DisplayName}")
    End Sub
```

>cautionAs of R2 2016, the **SelectedFieldChanged** event, previously marked as obsolete, has officially been removed.
