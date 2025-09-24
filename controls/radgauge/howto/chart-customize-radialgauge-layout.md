---
title: Create Compass
page_title: Create Compass
description: Check our &quot;Create Compass&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: chart-customize-radialgauge-layout
tags: create,compass
published: True
position: 1
---

# Create Compass

This example will demonstrate how to customize a __Radial Gauge__ to create compass.

For the purpose we'll create a Radial Gauge with the following parameters that define the radial scale range: __StartAngle__, __SweepAngle__, __Radius__ and several properties for the layout of the Minor and Major Ticks. The __StartAngle__ and __SweepAngle__ are specified in degrees (0 to 360), starting from the right side of the gauge, going clockwise (note, that positive angle direction starts from positive X and goes to the positive Y. Since the screen coordinates start from top-left, the Y axis points downwards, instead of upwards, the positive direction of the angle is clockwise instead of the mathematically accepted counter-clockwise). The scale __Radius__ and __Center__ are measured as a fraction (0.0 to 1.0) of the space available for scale in the surrounding container.
Here is the XAML code:


```XAML
	<telerik:RadRadialGauge Width="250" Height="250" telerik:StyleManager.Theme="Windows8">
	    <telerik:RadialScale StartAngle="270"
									SweepAngle="360"
									Min="0"  
									Max="360"    
	                                Radius="0.95"
									MajorTickStep="90" 
	                                ShowLastLabel="False"                                 
									LabelRotationMode="None"
	                                LabelLocation="Outside"
									MajorTickLocation="Inside"
	                                MajorTickOffset="0.05*"
									MiddleTickLocation="Inside"
	                                MiddleTickRelativeHeight="0.03*"
									MinorTicks="1"
									MiddleTicks="6"
	                                MiddleTickRelativeWidth="0.01*" 
	                                MiddleTickOffset="0.05*" >
	        <telerik:RadialScale.Indicators>
	            <telerik:Needle x:Name="needle" Value="0"/>
	            <telerik:Pinpoint Background="White" BorderBrush="#FF767676" BorderThickness="1" />
	        </telerik:RadialScale.Indicators>
	    </telerik:RadialScale>
	</telerik:RadRadialGauge>
```

Our gauge looks like this:

![{{ site.framework_name }} RadGauge Compass](images/gauge_customize_radialgauge.png)

To make it look more like compass we'll need to customize the labels so that they are the four cardinal directions - N(North), E(east), S(south) and W(west). To remove the default gauge labels we'll use *LabelTemplate*. We'll also need to customize the needle. All this will be done via Styles:


```XAML
	<UserControl.Resources>
		<telerik:Windows8Colors x:Key="Windows8Colors" />
		<SolidColorBrush x:Key="AccentBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.AccentColor}" />
		<SolidColorBrush x:Key="ValidationBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.ValidationColor}" />
		<SolidColorBrush x:Key="BasicBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.BasicColor}" />
		<SolidColorBrush x:Key="StrongBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.StrongColor}" />
		<SolidColorBrush x:Key="MarkerBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.MarkerColor}" />

		<DataTemplate x:Key="TickLabelEmpty">
			<Grid />
		</DataTemplate>

		<Style x:Key="CustomNeedle" TargetType="telerik:Needle" >
			<Setter Property="telerik:ScaleObject.Location" Value="Inside" />
			<Setter Property="telerik:ScaleObject.RelativeWidth" Value="0.03\*" />
			<Setter Property="Background">
				<Setter.Value>
					<LinearGradientBrush EndPoint="0.5,1" StartPoint="0.5,0">
						<GradientStop Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.ValidationColor}" Offset="0"/>
						<GradientStop Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.ValidationColor}" Offset="0.5"/>
						<GradientStop Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.MarkerColor}" Offset="0.51"/>
						<GradientStop Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.MarkerColor}" Offset="1"/>
					</LinearGradientBrush>
				</Setter.Value>
			</Setter>
			<Setter Property="TailHeight" Value="0.7" />
		</Style>

	</UserControl.Resources>
	<Grid >
		<telerik:RadRadialGauge Width="250" Height="250" telerik:StyleManager.Theme="Windows8">
			<telerik:RadialScale StartAngle="270"
								SweepAngle="360"
								Min="0"  
								Max="360"    
								Radius="0.95"
								MajorTickStep="90"     
								LabelTemplate="{StaticResource TickLabelEmpty}"
								LabelRotationMode="None"
								LabelLocation="Outside"
								MajorTickLocation="Inside"
								MajorTickOffset="0.05\*"
								MiddleTickLocation="Inside"
								MiddleTickRelativeHeight="0.03*"
								MinorTicks="1"
								MiddleTicks="6"
								MiddleTickRelativeWidth="0.01\*" 
								MiddleTickOffset="0.05\*" >
				<telerik:RadialScale.Indicators>
					<telerik:Needle x:Name="needle" Value="0"  Style="{StaticResource CustomNeedle}"/>
					<telerik:Pinpoint Background="White" BorderBrush="#FF767676" BorderThickness="1" />
				</telerik:RadialScale.Indicators>

				<telerik:RadialScale.CustomItems>
					<TextBlock Text="N" telerik:ScaleObject.Value="0" />
					<TextBlock Text="E" telerik:ScaleObject.Value="90" />
					<TextBlock Text="S" telerik:ScaleObject.Value="180" />
					<TextBlock Text="W" telerik:ScaleObject.Value="270" />
					<Ellipse telerik:ScaleObject.Value="0" />
					<Ellipse telerik:ScaleObject.Value="90" />
					<Ellipse telerik:ScaleObject.Value="180" />
					<Ellipse telerik:ScaleObject.Value="270" />
				</telerik:RadialScale.CustomItems>
			</telerik:RadialScale>
		</telerik:RadRadialGauge>
	</Grid>
```

Here's the result:

![gauge customize radialgauge compass](images/gauge_customize_radialgauge_compass.PNG)

You may additionally customize the appearance of the compass. For example we can add an outer border and some custom ticks. The full source code for our compass is shown below:


```XAML
	<UserControl.Resources>
		<telerik:Windows8Colors x:Key="Windows8Colors" />
		<SolidColorBrush x:Key="AccentBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.AccentColor}" />
		<SolidColorBrush x:Key="ValidationBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.ValidationColor}" />
		<SolidColorBrush x:Key="BasicBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.BasicColor}" />
		<SolidColorBrush x:Key="StrongBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.StrongColor}" />
		<SolidColorBrush x:Key="MarkerBrush" Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.MarkerColor}" />

		<DataTemplate x:Key="TickLabelEmpty">
			<Grid />
		</DataTemplate>

		<Style x:Key="CustomNeedle" TargetType="telerik:Needle" >
			<Setter Property="telerik:ScaleObject.Location" Value="Inside" />
			<Setter Property="telerik:ScaleObject.RelativeWidth" Value="0.03\*" />
			<Setter Property="Background">
				<Setter.Value>
					<LinearGradientBrush EndPoint="0.5,1" StartPoint="0.5,0">
						<GradientStop Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.ValidationColor}" Offset="0"/>
						<GradientStop Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.ValidationColor}" Offset="0.5"/>
						<GradientStop Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.MarkerColor}" Offset="0.51"/>
						<GradientStop Color="{Binding Source={StaticResource Windows8Colors}, Path=Palette.MarkerColor}" Offset="1"/>
					</LinearGradientBrush>
				</Setter.Value>
			</Setter>
			<Setter Property="TailHeight" Value="0.7" />
		</Style>

		<Style x:Key="CustomTick" TargetType="Ellipse">
			<Setter Property="Width" Value="7" />
			<Setter Property="Height" Value="7" />
			<Setter Property="Stroke" Value="#FF767676" />
			<Setter Property="Fill" Value="White" />
			<Setter Property="telerik:ScaleObject.Location" Value="Outside" />
			<Setter Property="telerik:ScaleObject.Offset" Value="0.01\*" />
		</Style>
	</UserControl.Resources>
	<Grid >
		<telerik:RadRadialGauge Width="250" Height="250" 
								telerik:StyleManager.Theme="Windows8" OuterBorderThickness="2" OuterBorderBrush="{StaticResource StrongBrush}">
			<telerik:RadialScale StartAngle="270"
								SweepAngle="360"
								Min="0"  
								Max="360"    
								Radius="0.95"
								MajorTickStep="90"     
								LabelTemplate="{StaticResource TickLabelEmpty}"
								LabelRotationMode="None"
								LabelLocation="Outside"
								MajorTickLocation="Inside"
								MajorTickOffset="0.05\*"
								MiddleTickLocation="Inside"
								MiddleTickRelativeHeight="0.03\*"
								MinorTicks="1"
								MiddleTicks="6"
								MiddleTickRelativeWidth="0.01\*" 
								MiddleTickOffset="0.05\*" >
				<telerik:RadialScale.Indicators>
					<telerik:Needle x:Name="needle" Value="0"  Style="{StaticResource CustomNeedle}"/>
					<telerik:Pinpoint Background="White" BorderBrush="#FF767676" BorderThickness="1" />
				</telerik:RadialScale.Indicators>

				<telerik:RadialScale.CustomItems>
					<TextBlock Text="N" telerik:ScaleObject.Value="0" />
					<TextBlock Text="E" telerik:ScaleObject.Value="90" />
					<TextBlock Text="S" telerik:ScaleObject.Value="180" />
					<TextBlock Text="W" telerik:ScaleObject.Value="270" />
					
					<Ellipse telerik:ScaleObject.Value="0"
							  Style="{StaticResource CustomTick}"/>
					<Ellipse telerik:ScaleObject.Value="90" 
							  Style="{StaticResource CustomTick}"/>
					<Ellipse telerik:ScaleObject.Value="180"
							  Style="{StaticResource CustomTick}"/>
					<Ellipse telerik:ScaleObject.Value="270" 
							  Style="{StaticResource CustomTick}"/>
				</telerik:RadialScale.CustomItems>
			</telerik:RadialScale>
		</telerik:RadRadialGauge>
	</Grid>
```

![gauge customize radialgauge compass final](images/gauge_customize_radialgauge_compass_final.PNG)
