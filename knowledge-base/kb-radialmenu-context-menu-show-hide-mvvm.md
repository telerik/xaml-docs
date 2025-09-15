---
title: Show/Hide RadRadialMenu When Used As a Context Menu In an MVVM Scenario
page_title: Change Visibility of RadRadialMenu When Used As a Context Menu Using The MVVM Pattern
description: How to how to show/hide the RadRadialMenu in an MVVM scenario
type: how-to
slug: kb-radialmenu-show-hide-mvvm
tags: radialmenu, mvvm, show, hide, visibility
ticketid: 1612070
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2023.2.606</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadRadialMenu for WPF</td>
	</tr>
</table>

## Description

Show or hide the RadRadialMenu control when it is used as a context menu for an element in an MVVM scenario.

## Solution

1. Create a property of type __bool__ inside your view model.

__Creating a view model with a bool property__
```C#
	public class MainViewModel : ViewModelBase
	{
	    private bool shouldOpenRadialMenu;

	    public bool ShouldOpenRadialMenu
	    {
	        get { return shouldOpenRadialMenu; }
	        set { shouldOpenRadialMenu = value; this.OnPropertyChanged(nameof(this.ShouldOpenRadialMenu)); }
	    }
	}
```
```VB.NET
	Public Class MainViewModel
	    Inherits ViewModelBase

	    Private shouldOpenRadialMenu As Boolean

	    Public Property ShouldOpenRadialMenu As Boolean
	        Get
	            Return shouldOpenRadialMenu
	        End Get
	        Set(ByVal value As Boolean)
	            shouldOpenRadialMenu = value
	            Me.OnPropertyChanged(NameOf(Me.ShouldOpenRadialMenu))
	        End Set
	    End Property
	End Class
```

2. Create an [attached property]({%slug common-mvvm-attached-behavior%}) that will be bound to the __bool__ property from the view model.

__Creating an attached property__
```C#
	public class RadialMenuExtensions
	{
	    public static int GetShouldOpenRadialMenu(DependencyObject obj)
	    {
	        return (int)obj.GetValue(ShouldOpenRadialMenuProperty);
	    }

	    public static void SetShouldOpenRadialMenu(DependencyObject obj, int value)
	    {
	        obj.SetValue(ShouldOpenRadialMenuProperty, value);
	    }

	    public static readonly DependencyProperty ShouldOpenRadialMenuProperty =
	        DependencyProperty.RegisterAttached("ShouldOpenRadialMenu", typeof(bool), typeof(RadialMenuExtensions), new PropertyMetadata(false, OnShouldOpenRadialMenuChanged));

	    private static void OnShouldOpenRadialMenuChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	    {
	    }
	}
```
```VB.NET
	Public Class RadialMenuExtensions
	    Public Shared Function GetShouldOpenRadialMenu(ByVal obj As DependencyObject) As Integer
	        Return CInt(obj.GetValue(ShouldOpenRadialMenuProperty))
	    End Function

	    Public Shared Sub SetShouldOpenRadialMenu(ByVal obj As DependencyObject, ByVal value As Integer)
	        obj.SetValue(ShouldOpenRadialMenuProperty, value)
	    End Sub

	    Public Shared ReadOnly ShouldOpenRadialMenuProperty As DependencyProperty = DependencyProperty.RegisterAttached("ShouldOpenRadialMenu", GetType(Boolean), GetType(RadialMenuExtensions), New PropertyMetadata(False, AddressOf 	OnShouldOpenRadialMenuChanged))

	    Private Shared Sub OnShouldOpenRadialMenuChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
	    End Sub
	End Class
```

3. Retrieve the RadRadialMenu instance that is set on the element as a context menu in the property callback method. To do so, use the `RadRadialMenu.GetRadialContextMenu` method. Depending on the value of the __bool__ property from the view model, execute the `RadRadialMenuCommands.Show` and `RadRadialMenuCommands.Hide` commands.

__Showing/Hiding the RadRadialMenu in the property callback method__
```C#
	private static void OnShouldOpenRadialMenuChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
	    FrameworkElement frameworkElement = d as FrameworkElement;

	    if (frameworkElement != null)
	    {
	        RadRadialMenu radRadialMenu = RadRadialMenu.GetRadialContextMenu(frameworkElement);

	        if (radRadialMenu != null )
	        {
	            bool shouldOpen = (bool)e.NewValue;

	            if (shouldOpen)
	            {
	                RadialMenuCommands.Show.Execute(null, frameworkElement);
	            }
	            else
	            {
	                RadialMenuCommands.Hide.Execute(null, frameworkElement);
	            }
	        }
	    }
	}
```
```VB.NET
	Private Shared Sub OnShouldOpenRadialMenuChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
	    Dim frameworkElement As FrameworkElement = TryCast(d, FrameworkElement)

	    If frameworkElement IsNot Nothing Then
	        Dim radRadialMenu As RadRadialMenu = RadRadialMenu.GetRadialContextMenu(frameworkElement)

	        If radRadialMenu IsNot Nothing Then
	            Dim shouldOpen As Boolean = CBool(e.NewValue)

	            If shouldOpen Then
	                RadialMenuCommands.Show.Execute(Nothing, frameworkElement)
	            Else
	                RadialMenuCommands.Hide.Execute(Nothing, frameworkElement)
	            End If
	        End If
	    End If
	End Sub
```

4. Set the attached property on the element that has the RadRadialMenu set as its context menu and bind it to the __bool__ property from the view model.

The following example shows the RadRadialMenu control as a context menu for a TextBox element instance:

__Binding the attached property__
```XAML
	<Grid>
	    <Grid.DataContext>
	        <local:MainViewModel/>
	    </Grid.DataContext>
	    <TextBox local:RadialMenuExtensions.ShouldOpenRadialMenu="{Binding ShouldOpenRadialMenu, Mode=TwoWay}">
	        <telerik:RadRadialMenu.RadialContextMenu>
	            <telerik:RadRadialMenu>
	                <telerik:RadRadialMenuItem Header="Item 1" />
	                <telerik:RadRadialMenuItem Header="Item 2" />
	                <telerik:RadRadialMenuItem Header="Item 3" />
	            </telerik:RadRadialMenu>
	        </telerik:RadRadialMenu.RadialContextMenu>
	    </TextBox>
	</Grid>
```