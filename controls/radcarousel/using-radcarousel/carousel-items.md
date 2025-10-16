---
title: Carousel Items
page_title: Carousel Items
description: Check our &quot;Carousel Items&quot; documentation article for the RadCarousel {{ site.framework_name }} control.
slug: carousel-items
tags: carousel,items
published: True
position: 0
---

# Carousel Items

## Overview

RadCarousel tries to mimic the familiar API of a standard WPF __ItemsControl__. When displaying data, the control will wrap visible data items in a __CarouselItem__ control that provides the visual representation of carousel items. In addition to providing the visual representation of data items, __CarouselItem__ controls are also the entry point for data-related properties such as the ones supporting item selection.

## Customization

Using the fact that all data items are automatically wrapped inside a __CarouselItem__ you can change an item's appearance by using WPF styles targeting __CarouselItem__ controls. Here is how to do that and present your carousel items inside two nested Border elements:



```XAML
	<Style TargetType="{x:Type telerik:CarouselItem}">
	  <Setter Property="Template" >
	    <Setter.Value>
	      <ControlTemplate TargetType="{x:Type telerik:CarouselItem}">
	        <Border >
	          <Border x:Name="CarouselItemMainBorder"
	                  ClipToBounds="False" Height="175" Width="150" RenderTransformOrigin="0.5, 1"
	                  Opacity="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=ReflectionSettings.Opacity}"
	                  Visibility="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=ReflectionSettings.Visibility}"
	                  BorderBrush="#FF91B3FF" BorderThickness="1,1,1,1" CornerRadius="5,5,5,5" SnapsToDevicePixels="True">
	            <Border.Background>
	              <LinearGradientBrush EndPoint="108,472" StartPoint="108,23" MappingMode="Absolute">
	                <GradientStop Color="#FF2C3A68" Offset="0"/>
	                <GradientStop Color="#FF000000" Offset="1"/>
	                <GradientStop Color="#FF0F224C" Offset="0.045"/>
	                <GradientStop Color="#FF000000" Offset="0.0451"/>
	              </LinearGradientBrush>
	            </Border.Background>
	            <Border Opacity="1" BorderBrush="#3F000000" BorderThickness="1,1,1,1" CornerRadius="5,5,5,5" Margin="10,10,10,10" x:Name="CarouselItemInnerBorder" SnapsToDevicePixels="True">
	              <Border.Background>
	                <LinearGradientBrush EndPoint="101,462" StartPoint="101,13" MappingMode="Absolute">
	                  <GradientStop Color="#FF2C3A68" Offset="0"/>
	                  <GradientStop Color="#FF000000" Offset="1"/>
	                  <GradientStop Color="#FF0F224C" Offset="0.045"/>
	                  <GradientStop Color="#FF000000" Offset="0.0451"/>
	                </LinearGradientBrush>
	              </Border.Background>
	              <!-- The ContentPresenter below will display the CarouselItem data -->
	              <ContentPresenter IsHitTestVisible="True" />
	            </Border>
	          </Border>
	        </Border>
	      </ControlTemplate>
	    </Setter.Value>
	  </Setter>
	</Style>
```

## Displaying Visual Cues for Selected Items

The above style will make all carousel items look identical. If you need selection logic in your RadCarousel control, you will most certainly want selected items to appear different than the rest. To implement that, you need to use a trigger in your __CarouselItem__ style and modify your appearance according to the __IsSelected__ property value. The example below adds a trigger to the __CarouselItem__ control template to change the two Border elements' background color when the respective __CarouselItem__ has been selected:



```XAML
	<ControlTemplate.Triggers>
	  <Trigger Property="IsSelected" Value="True" >
	    <Setter TargetName="CarouselItemMainBorder" Property="Background">
	      <Setter.Value>
	        <LinearGradientBrush EndPoint="108,472" StartPoint="108,23" MappingMode="Absolute">
	          <GradientStop Color="#FF344B97" Offset="0"/>
	          <GradientStop Color="#FF000000" Offset="1"/>
	          <GradientStop Color="#FF233F7E" Offset="0.045"/>
	          <GradientStop Color="#FF000000" Offset="0.0451"/>
	        </LinearGradientBrush>
	      </Setter.Value>
	    </Setter>
	    <Setter TargetName="CarouselItemInnerBorder" Property="Background">
	      <Setter.Value>
	        <LinearGradientBrush  EndPoint="101,462" StartPoint="101,13" MappingMode="Absolute">
	          <GradientStop Color="#FF344B97" Offset="0"/>
	          <GradientStop Color="#FF000000" Offset="1"/>
	          <GradientStop Color="#FF233F7E" Offset="0.045"/>
	          <GradientStop Color="#FF000000" Offset="0.0451"/>
	        </LinearGradientBrush>
	      </Setter.Value>
	    </Setter>
	  </Trigger>
	</ControlTemplate.Triggers>
```

##  Data Record Presenters

Remember the __ContentPresenter__ control that we used in our __CarouselItem__ control template? It will not display the data items directly, but will use a __CarouselDataRecordPresenter__ control to do its job. The data record presenter works closely with the RadCarousel data engine and wraps a data item object. You Here is how you can create a custom style to modify the __CarouselDataRecordPresenter__ template and customize the way your data is presented:



```XAML
	<Style TargetType="{x:Type telerik:CarouselDataRecordPresenter}">
	  <Setter Property="Template">
	    <Setter.Value>
	      <ControlTemplate TargetType="{x:Type telerik:CarouselDataRecordPresenter}">
	        <Grid IsHitTestVisible="False" HorizontalAlignment="Stretch" VerticalAlignment="Stretch">
	          <Grid.RowDefinitions>
	            <RowDefinition Height="30" />
	            <RowDefinition Height="100" />
	            <RowDefinition Height="Auto" />
	          </Grid.RowDefinitions>
	          <StackPanel Grid.Row="0" Orientation="Horizontal" VerticalAlignment="Center" >
	            <Label Content="{Binding Path=[FirstName]}" Foreground="#ff8FB3FF" FontSize="12" />
	            <Label  Content="{Binding Path=[LastName]}" Foreground="#ff8FB3FF" FontSize="12" />
	          </StackPanel>
	          <Rectangle Grid.Row="1" RadiusX="3" RadiusY="3" Width="110" Height="80">
	            <Rectangle.Fill>
	              <ImageBrush x:Name="brush" ImageSource="{Binding Path=[Picture]}"/>
	            </Rectangle.Fill>
	          </Rectangle>
	          <StackPanel Grid.Row="2"  Orientation="Horizontal" VerticalAlignment="Center">
	            <Label Content="Phone: " Foreground="#ff8FB3FF" FontSize="12"/>
	            <Label Content="{Binding Path=[Phone]}" FontSize="12" Foreground="#ff8FB3FF"/>
	          </StackPanel>
	        </Grid>
	      </ControlTemplate>
	    </Setter.Value>
	  </Setter>
	</Style>
```