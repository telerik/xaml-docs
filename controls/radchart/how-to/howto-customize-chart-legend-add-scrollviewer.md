---
title: Customize Chart Legend - Add ScrollViewer
page_title: Customize Chart Legend - Add ScrollViewer
description: Check our &quot;Customize Chart Legend - Add ScrollViewer&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-howto-customize-chart-legend-add-scrollviewer
tags: customize,chart,legend,-,add,scrollviewer
published: True
position: 17
---

# Customize Chart Legend - Add ScrollViewer



## 

There are scenarios in which you have too much Items in the Chart Legend. Since the Legend is trying to visualize all of them this causes to reduced space for the Chart. Even if you set a Width for the Chart Legend the items maybe chopped off (not quite visible).
One possible solution is to decrease FontSize value of text and retemplate the LegendItemMarker to decreaze it's size too. This help topic will demonstrate another approach - how to add *ScrollViewer* (horizontal or/and vertical) in order to be able to show large number of chart legend items in a limited space.
For the purpose you should retemplate the default Legend Style and add ScrollViewer in it:

#### __XAML__

```XAML
	<UserControl.Resources>
	        <telerik:TextToVisibilityConverter x:Key="textToVisibilityConverter" />
	
	        <SolidColorBrush x:Key="LegendForeground" Color="#FF000000" />
	        <LinearGradientBrush x:Key="LegendBackground" EndPoint="1.96,0.5" StartPoint="-0.96,0.5">
	            <GradientStop Color="#FFB5B5B5"/>
	            <GradientStop Color="#FFF0F0F0" Offset="0.5"/>
	        </LinearGradientBrush>
	        <SolidColorBrush x:Key="LegendBorderBrush" Color="#FF848484" />
	        <Thickness x:Key="LegendBorderThickness">1</Thickness>
	
	        <system:Double x:Key="LegendItemMarkerMaskStrokeThickness">1</system:Double>
	        <SolidColorBrush x:Key="LegendItemMarkerMaskStroke" Color="White" />
	        <LinearGradientBrush x:Key="LegendItemMarkerMask" EndPoint="0.5,1" StartPoint="0.5,0">
	            <GradientStop Color="#D8FFFFFF" Offset="0.009"/>
	            <GradientStop Color="#66FFFFFF" Offset="1"/>
	            <GradientStop Color="Transparent" Offset="0.43"/>
	            <GradientStop Color="#7FFFFFFF" Offset="0.42"/>
	        </LinearGradientBrush>
	        <SolidColorBrush x:Key="LegendItemMarkerMaskOpacityMask" Color="#FF000000" />
	        <SolidColorBrush x:Key="LegendItemMarkerMask2" Color="Transparent" />
	
	        <telerik:MarkerShape x:Key="LegendItemMarkerShape">SquareRounded</telerik:MarkerShape>
	
	        <Style x:Key="ChartLegendStyle"
	        TargetType="telerik:ChartLegend">
	            <Setter Property="Foreground" Value="{StaticResource LegendForeground}" />
	            <Setter Property="Background" Value="{StaticResource LegendBackground}" />
	            <Setter Property="Padding" Value="10,10,10,5" />
	            <Setter Property="Margin" Value="0"/>
	            <Setter Property="BorderBrush" Value="{StaticResource LegendBorderBrush}" />
	            <Setter Property="BorderThickness" Value="{StaticResource LegendBorderThickness}" />
	            <Setter Property="HeaderFontWeight" Value="Bold" />
	            <Setter Property="HorizontalContentAlignment" Value="Stretch" />
	            <Setter Property="VerticalContentAlignment" Value="Stretch" />
	            <Setter Property="LegendItemMarkerShape" Value="{StaticResource LegendItemMarkerShape}" />
	            <Setter Property="Template" >
	                <Setter.Value>
	                    <ControlTemplate TargetType="telerik:ChartLegend">
	                        <Border 
	                            Background="{TemplateBinding Background}"
	                            BorderBrush="{TemplateBinding BorderBrush}"
	                            BorderThickness="{TemplateBinding BorderThickness}" >
	                            <Grid Margin="{TemplateBinding Padding}">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition Height="*" />
	                                </Grid.RowDefinitions>
	                                <ContentControl Foreground="{TemplateBinding Foreground}"
	                                            HorizontalAlignment="Stretch"
	                                            HorizontalContentAlignment="Stretch"
	                                            FontWeight="{TemplateBinding HeaderFontWeight}" 
	                                            Content="{TemplateBinding Header}" 
	                                            ContentTemplate="{TemplateBinding HeaderTemplate}"/>
	                                <ScrollViewer Grid.Row="1" VerticalScrollBarVisibility="Visible" >  
	                                    <ItemsPresenter/>
	                                </ScrollViewer>
	                            </Grid>
	                        </Border>
	                    </ControlTemplate>
	                </Setter.Value>
	            </Setter>
	            <Setter Property="ItemsPanel">
	                <Setter.Value>
	                    <ItemsPanelTemplate>
	                        <telerik:RadWrapPanel/>
	                    </ItemsPanelTemplate>
	                </Setter.Value>
	            </Setter>
	            <Setter Property="HeaderTemplate">
	                <Setter.Value>
	                    <DataTemplate>
	                        <Grid>
	                            <TextBlock FontSize="12"
	                                   Padding="0,0,0,2"  
	                                   Width="Auto" 
	                                   Height="Auto" 
	                                   Text="{Binding}"
	                                   Visibility="{Binding Converter={StaticResource textToVisibilityConverter}}"
	                                   TextWrapping="Wrap" />
	                        </Grid>
	                    </DataTemplate>
	                </Setter.Value>
	            </Setter>
	        </Style>
	    </UserControl.Resources>
```



The sample Chart shown below has [LegendDisplayMode](http://www.telerik.com/help/silverlight/radchart-features-chart-legend.html) set to DataPointLabel so that all Items in the Chart has LegendLabels:

#### __C#__

```C#
	public MainPage()
	        {
	            InitializeComponent();
	            Random r = new Random();
	            int[] myArray = new int[100];
	            for (int i = 0; i < myArray.Length; i++)
	            {
	                myArray[i] = r.Next(0, 100);
	            }
	            RadChart1.ItemsSource = myArray;
	            RadChart1.DefaultView.ChartArea.EnableAnimations = false;
	            RadChart1.DefaultView.ChartLegend.Width = 200;
	            RadChart1.DefaultSeriesDefinition.LegendDisplayMode = LegendDisplayMode.DataPointLabel;
	            RadChart1.DefaultView.ChartLegend.Style = (Style)this.Resources["ChartLegendStyle"];
	        }
```


#### __VB.NET__

```VB.NET
	Public Sub New()
	    InitializeComponent()
	    Dim r As New Random()
	    Dim myArray(99) As Integer
	    For i As Integer = 0 To myArray.Length - 1
	        myArray(i) = r.Next(0, 100)
	    Next i
	    RadChart1.ItemsSource = myArray
	    RadChart1.DefaultView.ChartArea.EnableAnimations = False
	    RadChart1.DefaultView.ChartLegend.Width = 200
	    RadChart1.DefaultSeriesDefinition.LegendDisplayMode = LegendDisplayMode.DataPointLabel
	    RadChart1.DefaultView.ChartLegend.Style = CType(Me.Resources("ChartLegendStyle"), Style)
	End Sub
```



The result can be seen on the following picture:
![{{ site.framework_name }} RadChart  ](images/RadChart_HowTo_ScrollViewer.PNG)