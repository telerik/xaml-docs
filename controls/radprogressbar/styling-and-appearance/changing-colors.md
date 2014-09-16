---
title: Changing colors
page_title: Changing colors
description: Changing colors
slug: radprogressbar-changing-colors
tags: changing,colors
publish: True
position: 2
---

# Changing colors



## 

There are two ways of changing the colors of a __RadProgressBar__ – by setting the control’s properties or by
      assigning a custom __Style__ to the control. Both methods can be used either in procedural code or in XAML. 
      The latter is the more flexible approach but requires more knowledge and generally takes a little more effort. 
      Alternatively, by simply setting the appropriate properties of the __RadProgressBar__, one can quickly and easily
      modify the coloring of the control to his liking, although there are some limitations to what can be modified.
      

Here is a list of the __RadProgressBar__ properties that affect the coloring of the control:

* __Background__ – modifies the color of the progress track.
						

#### __XAML__

{{region radprogressbar-changing-colors_0}}
	    <UserControl.Resources>
	        <Style x:Key="myStyle" TargetType="telerik:RadProgressBar">
	            <Setter Property="Background" Value="Yellow" />
	        </Style>
	    </UserControl.Resources>
	    <Grid>
	        <!-- Set Background using a Style  -->
	        <telerik:RadProgressBar Style="{StaticResource myStyle}" />
	        <!-- Set Background directly -->
	        <telerik:RadProgressBar Background="Yellow" />
	    </Grid>
	{{endregion}}



#### __C#__

{{region radprogressbar-changing-colors_1}}
				RadProgressBar myProgressBar = new RadProgressBar();
				// Set Background directly 
				myProgressBar.Background = new SolidColorBrush(Colors.Yellow);
				// Set Background using a Style
				Style myStyle = new Style(typeof(RadProgressBar));
				myStyle.Setters.Add(new Setter(RadProgressBar.BackgroundProperty, new SolidColorBrush(Colors.Yellow)));
				myProgressBar.Style = myStyle;
	{{endregion}}



#### __VB.NET__

{{region radprogressbar-changing-colors_1}}
			Dim myProgressBar As New RadProgressBar()
			' Set Background directly 
			myProgressBar.Background = New SolidColorBrush(Colors.Yellow)
			' Set Background using a Style
			Dim myStyle As New Style(GetType(RadProgressBar))
			myStyle.Setters.Add(New Setter(RadProgressBar.BackgroundProperty, New SolidColorBrush(Colors.Yellow)))
			myProgressBar.Style = myStyle
			'#End Region
	
			'#Region "radprogressbar-changing-colors_3"
			' Set Foreground directly
			myProgressBar.Foreground = New SolidColorBrush(Colors.Yellow)
			' Set Foreground using a Style
			Dim myStyle2 As New Style(GetType(RadProgressBar))
			myStyle2.Setters.Add(New Setter(RadProgressBar.ForegroundProperty, New SolidColorBrush(Colors.Yellow)))
			myProgressBar.Style = myStyle2
			'#End Region
	
			'#Region "radprogressbar-changing-colors_5"
			' Set BorderBrush  directly
			myProgressBar.BorderBrush = New SolidColorBrush(Colors.Red)
			' Set BorderBrush using a Style
			Dim myStyle3 As New Style(GetType(RadProgressBar))
			myStyle3.Setters.Add(New Setter(RadProgressBar.BorderBrushProperty, New SolidColorBrush(Colors.Red)))
			myProgressBar.Style = myStyle3
			'#End Region
		End Sub
	End Class

Here is how the control looks before and after the change of the __Background__ property:
						*Before:*![Rad Progress Bar default](images/RadProgressBar_default.png)*After:*![Rad Progress Bar yellow background](images/RadProgressBar_yellow_background.png)

* __Foreground__ – modifies the color of the progress indicator.
						

#### __XAML__

{{region radprogressbar-changing-colors_2}}
	    <Style x:Key="myStyle2" TargetType="telerik:RadProgressBar">
	        <Setter Property="Foreground" Value="Yellow" />
	    </Style>
	    <!--  Set Foreground using a Style  -->
	    <telerik:RadProgressBar Style="{StaticResource myStyle2}" />
	    <!--  Set Foreground directly  -->
	    <telerik:RadProgressBar Foreground="Yellow" />
	{{endregion}}



#### __C#__

{{region radprogressbar-changing-colors_3}}
				// Set Foreground directly
				myProgressBar.Foreground = new SolidColorBrush(Colors.Yellow);
				// Set Foreground using a Style
				Style myStyle2 = new Style(typeof(RadProgressBar));
				myStyle2.Setters.Add(new Setter(RadProgressBar.ForegroundProperty, new SolidColorBrush(Colors.Yellow)));
				myProgressBar.Style = myStyle2;
	{{endregion}}



#### __VB.NET__

{{region radprogressbar-changing-colors_3}}
			' Set Foreground directly
			myProgressBar.Foreground = New SolidColorBrush(Colors.Yellow)
			' Set Foreground using a Style
			Dim myStyle2 As New Style(GetType(RadProgressBar))
			myStyle2.Setters.Add(New Setter(RadProgressBar.ForegroundProperty, New SolidColorBrush(Colors.Yellow)))
			myProgressBar.Style = myStyle2
			'#End Region
	
			'#Region "radprogressbar-changing-colors_5"
			' Set BorderBrush  directly
			myProgressBar.BorderBrush = New SolidColorBrush(Colors.Red)
			' Set BorderBrush using a Style
			Dim myStyle3 As New Style(GetType(RadProgressBar))
			myStyle3.Setters.Add(New Setter(RadProgressBar.BorderBrushProperty, New SolidColorBrush(Colors.Red)))
			myProgressBar.Style = myStyle3
			'#End Region
		End Sub
	End Class

Here is how the control looks before and after the change of the __Foreground__ property:
						*Before:*![Rad Progress Bar default](images/RadProgressBar_default.png)*After:*![Rad Progress Bar yellow foreground](images/RadProgressBar_yellow_foreground.png)

* __BorderBrush__ – modifies the color of the
							RadProgressBar outer border.
						

#### __XAML__

{{region radprogressbar-changing-colors_4}}
	    <Style x:Key="myStyle3" TargetType="telerik:RadProgressBar">
	        <Setter Property="BorderBrush" Value="Red" />
	    </Style>
	    <!--  Set BorderBrush using a Style  -->
	    <telerik:RadProgressBar Style="{StaticResource myStyle3}" />
	    <!--  Set BorderBrush directly  -->
	    <telerik:RadProgressBar BorderBrush="Red" />
	{{endregion}}



#### __C#__

{{region radprogressbar-changing-colors_5}}
				// Set BorderBrush  directly
				myProgressBar.BorderBrush = new SolidColorBrush(Colors.Red);
				// Set BorderBrush using a Style
				Style myStyle3 = new Style(typeof(RadProgressBar));
				myStyle3.Setters.Add(new Setter(RadProgressBar.BorderBrushProperty, new SolidColorBrush(Colors.Red)));
				myProgressBar.Style = myStyle3;
	{{endregion}}



#### __VB.NET__

{{region radprogressbar-changing-colors_5}}
			' Set BorderBrush  directly
			myProgressBar.BorderBrush = New SolidColorBrush(Colors.Red)
			' Set BorderBrush using a Style
			Dim myStyle3 As New Style(GetType(RadProgressBar))
			myStyle3.Setters.Add(New Setter(RadProgressBar.BorderBrushProperty, New SolidColorBrush(Colors.Red)))
			myProgressBar.Style = myStyle3
			'#End Region
		End Sub
	End Class

Here is how the control looks before and after the change of the
							__BorderBrush__ property:
						*Before:*![Rad Progress Bar default](images/RadProgressBar_default.png)*After:*![Rad Progress Bar red border](images/RadProgressBar_red_border.png)
