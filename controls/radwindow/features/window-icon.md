---
title: Window Icon
page_title: Window Icon
description: Check our &quot;Window Icon&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-features-window-icon
tags: window,icon
published: True
position: 4
---

# Window Icon

`RadWindow` allows you to display a custom icon in its top-left corner. To specify the icon you can use either the `Icon` or the `IconTemplate` properties.

## Icon Property

If you have a window-specific icon, use the `Icon` property.

>tip As the Icon property is of type `object` you can set it to any control that you like. If you want to have a more complex icon content that consists of more than one control, be sure to wrap them inside a layout control and pass the layout control as content.

>important `RadWindow` is declared and opened from the code behind by default. The only way to use the RadWindow as a visual element in XAML is when it represents the entire UserControl. To learn more about that read [Use RadWindow as User Control]({%slug radwindow-how-to-use-radwindow-as-user-control%}) article.

#### __[C#] Setting the Icon property__

{{region cs-radwindow-features-window-icon_0}}
	RadWindow radWindow = new RadWindow();
	radWindow.Icon = new Image()
	{
	    Source = new BitmapImage(new Uri("../../Images/WindowIcon.png", UriKind.Relative))
	};
{{endregion}}

#### __[VB.NET] Setting the Icon property__

{{region vb-radwindow-features-window-icon_1}}
	Dim radWindow As New RadWindow()
	Dim image As New Image()
	image.Source = New BitmapImage(New Uri("../../Images/WindowIcon.png", UriKind.Relative))
	radWindow.Icon = image
{{endregion}}

This will be the final result:

![Rad Window Features Window Icon 01](images/RadWindow_Features_Window_Icon_01.png)

## IconTemplate Property

If you want to share a common icon layout structure for the content of multiple windows, define an appropriate `DataTemplate` and set it to the `IconTemplate` property of the RadWindow.

#### __[XAML] Setting the IconTemplate property in XAML__

{{region xaml-radwindow-features-window-icon_2}}
	<UserControl.Resources>
	    <DataTemplate x:Key="WindowIconTemplate">
	        <Image Source="/Images/WindowIcon.png" Stretch="None" />
	    </DataTemplate>
	</UserControl.Resources>
{{endregion}}

#### __[C#] Setting the IconTemplate property in code-behind__

{{region cs-radwindow-features-window-icon_3}}
	RadWindow radWindow = new RadWindow();
	radWindow.IconTemplate = this.Resources["WindowIconTemplate"] as DataTemplate;
{{endregion}}

#### __[VB.NET] Setting the IconTemplate property in code-behind__

{{region vb-radwindow-features-window-icon_4}}
	Dim radWindow As New RadWindow()
	radWindow.IconTemplate = TryCast(Me.Resources("WindowIconTemplate"), DataTemplate)
{{endregion}}

## IconMargin Property

Through the `IconMargin` property of the `RadWindow`, you can control the `Margin` that is applied to the chosen `Icon`.

#### __[XAML] Setting the IconMargin property in XAML__

{{region xaml-radwindow-features-window-icon-5}}
	<telerik:RadWindow x:Name="radWindow" IconMargin="5 0 0 0"/>
{{endregion}}

#### __[C#] Setting the IconMargin property in code-behind__

{{region cs-radwindow-features-window-icon-6}}
	this.radWindow.IconMargin = new Thickness(5, 0, 0, 0);
{{endregion}}

#### __[VB.NET] Setting the IconMargin property in code-behind__

{{region vb-radwindow-features-window-icon-7}}
	Me.radWindow.IconMargin = New Thickness(5, 0, 0, 0)
{{endregion}}