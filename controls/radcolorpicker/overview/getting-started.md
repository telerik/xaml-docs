---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radcolorpicker-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started



## Selection

__RadColorPicker__ is a control that displays  a set of palettes from which the user can select a single color.
		

>In order to use __RadColorPicker__ in your projects you have to add references to the following two assemblies
		  

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.Input__

It has a __SelectedColor__ property, which is of __Color__ type and it is used to store selected color value.
		

#### __XAML__

{{region radcolorpicker-getting-started_1}}
	<telerik:RadColorPicker SelectedColor="Red" />
	{{endregion}}



where the __telerik__ alias point to the following namespace:
		

	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"



#### __C#__

{{region radcolorpicker-getting-started_0}}
	RadColorPicker colorPicker = new RadColorPicker();
	colorPicker.SelectedColor = Colors.Red;
	{{endregion}}



#### __VB.NET__

{{region radcolorpicker-getting-started_0}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.SelectedColor = Colors.Red
	#End Region
	#Region "radcolorpicker-getting-started_2"
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	#Region "radcolorpicker-getting-started_3"
		Dim colorPicker As New RadColorPicker()
		colorPicker.MainPalette = ColorPreset.Grayscale
	#End Region
	
	#Region "radcolorpicker-getting-started_5"
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPalette = ColorPreset.Office
	#End Region
	
	#Region "radcolorpicker-getting-started_7"
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPalette = ColorPreset.Standard
	#End Region
	
	#Region "radcolorpicker-getting-started_9"
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.StandardPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_11"
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.HeaderPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_13"
		Dim colorPicker As New RadColorPicker()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.MainPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_15"
		Dim colorPicker As New RadColorPicker()
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_17"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownClosed += New EventHandler(colorPicker_DropDownClosed)
	
		Private Sub colorPicker_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownClosed event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_19"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownOpened += New EventHandler(colorPicker_DropDownOpened)
	
		Private Sub colorPicker_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownOpened event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_21"
		Dim colorPicker As New RadColorPicker()
		colorPicker.Click += New EventHandler(colorPicker_Click)
	
		Private Sub colorPicker_Click(ByVal sender As Object, ByVal e As EventArgs)
			' handle the Click event
		End Sub
	#End Region
	
	
	End Class



Whenever a color is selected the __SelectedColorChanged__ event is raised:
		

#### __C#__

{{region radcolorpicker-getting-started_2}}
	colorPicker.SelectedColorChanged += new EventHandler(RadColorPicker_SelectedColorChanged1);
	
	void RadColorPicker_SelectedColorChanged1(object sender, EventArgs e)
	{
	   RadColorPicker colorPicker = sender as RadColorPicker;
	   Color selectedColor = colorPicker.SelectedColor;
	}
	{{endregion}}



#### __VB.NET__

{{region radcolorpicker-getting-started_2}}
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	#Region "radcolorpicker-getting-started_3"
		Dim colorPicker As New RadColorPicker()
		colorPicker.MainPalette = ColorPreset.Grayscale
	#End Region
	
	#Region "radcolorpicker-getting-started_5"
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPalette = ColorPreset.Office
	#End Region
	
	#Region "radcolorpicker-getting-started_7"
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPalette = ColorPreset.Standard
	#End Region
	
	#Region "radcolorpicker-getting-started_9"
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.StandardPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_11"
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.HeaderPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_13"
		Dim colorPicker As New RadColorPicker()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.MainPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_15"
		Dim colorPicker As New RadColorPicker()
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_17"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownClosed += New EventHandler(colorPicker_DropDownClosed)
	
		Private Sub colorPicker_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownClosed event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_19"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownOpened += New EventHandler(colorPicker_DropDownOpened)
	
		Private Sub colorPicker_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownOpened event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_21"
		Dim colorPicker As New RadColorPicker()
		colorPicker.Click += New EventHandler(colorPicker_Click)
	
		Private Sub colorPicker_Click(ByVal sender As Object, ByVal e As EventArgs)
			' handle the Click event
		End Sub
	#End Region
	
	
	End Class



## Populating

You can populate the __RadColorSelector__  with any of the built-in palettes using the __ColorPreset__ enum . It has __HeaderPalette__, __MainPalette__ and __StandardPalette__ properties, which represent the corresponding parts of the selector.
		

* __MainPalette__ property:
			

#### __XAML__

{{region radcolorpicker-getting-started_4}}
	<telerik:RadColorPicker MainPalette="Grayscale" />
	{{endregion}}



#### __C#__

{{region radcolorpicker-getting-started_3}}
	RadColorPicker colorPicker = new RadColorPicker();
	colorPicker.MainPalette = ColorPreset.Grayscale;
	{{endregion}}



#### __VB.NET__

{{region radcolorpicker-getting-started_3}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.MainPalette = ColorPreset.Grayscale
	#End Region
	
	#Region "radcolorpicker-getting-started_5"
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPalette = ColorPreset.Office
	#End Region
	
	#Region "radcolorpicker-getting-started_7"
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPalette = ColorPreset.Standard
	#End Region
	
	#Region "radcolorpicker-getting-started_9"
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.StandardPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_11"
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.HeaderPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_13"
		Dim colorPicker As New RadColorPicker()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.MainPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_15"
		Dim colorPicker As New RadColorPicker()
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_17"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownClosed += New EventHandler(colorPicker_DropDownClosed)
	
		Private Sub colorPicker_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownClosed event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_19"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownOpened += New EventHandler(colorPicker_DropDownOpened)
	
		Private Sub colorPicker_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownOpened event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_21"
		Dim colorPicker As New RadColorPicker()
		colorPicker.Click += New EventHandler(colorPicker_Click)
	
		Private Sub colorPicker_Click(ByVal sender As Object, ByVal e As EventArgs)
			' handle the Click event
		End Sub
	#End Region
	
	
	End Class



* __HeaderPalette__ property:
			

#### __XAML__

{{region radcolorpicker-getting-started_6}}
	<telerik:RadColorPicker HeaderPalette="Office" />
	{{endregion}}



#### __C#__

{{region radcolorpicker-getting-started_5}}
	RadColorPicker colorPicker = new RadColorPicker();
	colorPicker.HeaderPalette = ColorPreset.Office;
	{{endregion}}



#### __VB.NET__

{{region radcolorpicker-getting-started_5}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPalette = ColorPreset.Office
	#End Region
	
	#Region "radcolorpicker-getting-started_7"
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPalette = ColorPreset.Standard
	#End Region
	
	#Region "radcolorpicker-getting-started_9"
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.StandardPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_11"
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.HeaderPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_13"
		Dim colorPicker As New RadColorPicker()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.MainPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_15"
		Dim colorPicker As New RadColorPicker()
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_17"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownClosed += New EventHandler(colorPicker_DropDownClosed)
	
		Private Sub colorPicker_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownClosed event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_19"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownOpened += New EventHandler(colorPicker_DropDownOpened)
	
		Private Sub colorPicker_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownOpened event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_21"
		Dim colorPicker As New RadColorPicker()
		colorPicker.Click += New EventHandler(colorPicker_Click)
	
		Private Sub colorPicker_Click(ByVal sender As Object, ByVal e As EventArgs)
			' handle the Click event
		End Sub
	#End Region
	
	
	End Class



* __StandardPalette__ property:
			

#### __XAML__

{{region radcolorpicker-getting-started_8}}
	<telerik:RadColorPicker StandardPalette="Standard" />
	{{endregion}}



#### __C#__

{{region radcolorpicker-getting-started_7}}
	RadColorPicker colorPicker = new RadColorPicker();
	colorPicker.StandardPalette = ColorPreset.Standard;
	{{endregion}}



#### __VB.NET__

{{region radcolorpicker-getting-started_7}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPalette = ColorPreset.Standard
	#End Region
	
	#Region "radcolorpicker-getting-started_9"
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.StandardPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_11"
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.HeaderPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_13"
		Dim colorPicker As New RadColorPicker()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.MainPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_15"
		Dim colorPicker As New RadColorPicker()
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_17"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownClosed += New EventHandler(colorPicker_DropDownClosed)
	
		Private Sub colorPicker_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownClosed event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_19"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownOpened += New EventHandler(colorPicker_DropDownOpened)
	
		Private Sub colorPicker_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownOpened event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_21"
		Dim colorPicker As New RadColorPicker()
		colorPicker.Click += New EventHandler(colorPicker_Click)
	
		Private Sub colorPicker_Click(ByVal sender As Object, ByVal e As EventArgs)
			' handle the Click event
		End Sub
	#End Region
	
	
	End Class



If you prefer to use your own collection of Colors you can always use __HeaderPaletteItemsSource__, __MainPaletteItemsSource__ and __StandardPaletteItemsSource__.
		

* __StandardPaletteItemSource__ property
			

#### __XAML__

{{region radcolorpicker-getting-started_10}}
	<telerik:RadColorPicker StandardPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
	{{endregion}}



#### __C#__

{{region radcolorpicker-getting-started_9}}
	RadColorPicker colorPicker = new RadColorPicker();
	colorPicker.StandardPaletteVisibility = Visibility.Visible;
	Collection<Color> colors = new Collection<Color>();
	colors.Add(Colors.Red);
	colors.Add(Colors.Green);
	colors.Add(Colors.Blue);
	colorPicker.StandardPaletteItemsSource = colors;
	{{endregion}}



#### __VB.NET__

{{region radcolorpicker-getting-started_9}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.StandardPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_11"
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.HeaderPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_13"
		Dim colorPicker As New RadColorPicker()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.MainPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_15"
		Dim colorPicker As New RadColorPicker()
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_17"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownClosed += New EventHandler(colorPicker_DropDownClosed)
	
		Private Sub colorPicker_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownClosed event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_19"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownOpened += New EventHandler(colorPicker_DropDownOpened)
	
		Private Sub colorPicker_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownOpened event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_21"
		Dim colorPicker As New RadColorPicker()
		colorPicker.Click += New EventHandler(colorPicker_Click)
	
		Private Sub colorPicker_Click(ByVal sender As Object, ByVal e As EventArgs)
			' handle the Click event
		End Sub
	#End Region
	
	
	End Class



* __HeaderPaletteItemSource__ property
			

#### __XAML__

{{region radcolorpicker-getting-started_12}}
	<telerik:RadColorPicker HeaderPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
	{{endregion}}



#### __C#__

{{region radcolorpicker-getting-started_11}}
	RadColorPicker colorPicker = new RadColorPicker();
	colorPicker.HeaderPaletteVisibility = Visibility.Visible;
	Collection<Color> colors = new Collection<Color>();
	colors.Add(Colors.Red);
	colors.Add(Colors.Green);
	colors.Add(Colors.Blue);
	colorPicker.HeaderPaletteItemsSource = colors;
	{{endregion}}



#### __VB.NET__

{{region radcolorpicker-getting-started_11}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.HeaderPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_13"
		Dim colorPicker As New RadColorPicker()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.MainPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_15"
		Dim colorPicker As New RadColorPicker()
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_17"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownClosed += New EventHandler(colorPicker_DropDownClosed)
	
		Private Sub colorPicker_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownClosed event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_19"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownOpened += New EventHandler(colorPicker_DropDownOpened)
	
		Private Sub colorPicker_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownOpened event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_21"
		Dim colorPicker As New RadColorPicker()
		colorPicker.Click += New EventHandler(colorPicker_Click)
	
		Private Sub colorPicker_Click(ByVal sender As Object, ByVal e As EventArgs)
			' handle the Click event
		End Sub
	#End Region
	
	
	End Class



* __MainPaletteItemSource__ property
			

#### __XAML__

{{region radcolorpicker-getting-started_14}}
	<telerik:RadColorPicker MainPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
	{{endregion}}



#### __C#__

{{region radcolorpicker-getting-started_13}}
	RadColorPicker colorPicker = new RadColorPicker();
	Collection<Color> colors = new Collection<Color>();
	colors.Add(Colors.Red);
	colors.Add(Colors.Green);
	colors.Add(Colors.Blue);
	colorPicker.MainPaletteItemsSource = colors;
	{{endregion}}



#### __VB.NET__

{{region radcolorpicker-getting-started_13}}
		Dim colorPicker As New RadColorPicker()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.MainPaletteItemsSource = colors1
	#End Region
	
	#Region "radcolorpicker-getting-started_15"
		Dim colorPicker As New RadColorPicker()
		colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)
	
		Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
			Dim selectedColor As Color = colorPicker.SelectedColor
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_17"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownClosed += New EventHandler(colorPicker_DropDownClosed)
	
		Private Sub colorPicker_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownClosed event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_19"
		Dim colorPicker As New RadColorPicker()
		colorPicker.DropDownOpened += New EventHandler(colorPicker_DropDownOpened)
	
		Private Sub colorPicker_DropDownOpened(ByVal sender As Object, ByVal e As EventArgs)
			' handle the DropDownOpened event
		End Sub
	#End Region
	
	#Region "radcolorpicker-getting-started_21"
		Dim colorPicker As New RadColorPicker()
		colorPicker.Click += New EventHandler(colorPicker_Click)
	
		Private Sub colorPicker_Click(ByVal sender As Object, ByVal e As EventArgs)
			' handle the Click event
		End Sub
	#End Region
	
	
	End Class







## Events

* __SelectedColorChanged____RadColorPicker__ has __SelectedColor__ property which is of __Color__ type and is used to store selected color value. Whenever a color is selected __SelectedColorChanged__ event is raised.
			

* __DropDownClosed__Raised when the SplitButton is closed.
			

* __DropDownOpening__Raised when the SplitButton is about to be opened.
			

* __DropDownOpened__Raised when the SplitButton is opened.
			

* __Click__Raised when the left part of the SplitButton is clicked.
			

## Properties

* __IsDropDownOpen__ - Opens or closes the drop down content.
			

* __DropDownPlacement__ - Sets the DropDownPlacement of the drop down content
			

* __ContentTemplate__ - Should be used to define the custom Content of the RadColorPicker. Content property should not be used for this purpose
			

* __PaletteItemsTemplate__ - Should be used in MVVM scenarios to get or set the ContentTemplate of the RadColorPaletteViewItems from the MainPalette, HeaderPalette, StandartPalette. It is not applied to RecentPalette items.
			

* __ColorPropertyPath__ - the control uses this path to find the property of type __System.Windows.Media.Color__ in the DataContext of the RadColorPaletteViewItems. The behavior of this property mimics the behavior of the __ItemsControl.DisplayMemberPath__ property. 
			

* __SelectedItem__ - should be used in MVVM scenarios and it holds the selected ViewModel - the DataContext of the selected RadColorPaletteViewItem.
			

* __IsRecentColorsActive__ - defines wether a customized color, not existing in the MainPalette, HeaderPalette, StandartPalette or RecentPalette should be added in the RecentColorsPaletteView. If there is such a color this palette will be visible.
			

* __AdditionalContent__ - can be used to add customized content under RadColorPicker control.
			
