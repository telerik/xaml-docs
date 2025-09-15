---
title: Hide Selection Range Title
page_title: Hide Selection Range Title
description: Check our &quot;Hide Selection Range Title&quot; documentation article for the RadTimeBar {{ site.framework_name }} control.
slug: radtimebar-hide-selection-range-title
tags: hide,selection,range,title
published: True
position: 1
---

# Hide Selection Range Title

Since __Q1 2012 SP1__ we are providing new binaries for our controls, the so-called NoXAML binaries. In the normal assemblies you have all the XAML for all components for all themes included in the dll and the styling is done with explicitly set styles. This unfortunately affected the size of the binaries. With the NoXaml assemblies you will get completely clean assembly with absolutely no XAML included and you can add manually only needed resources for your application.

>The purpose of this topic is to demonstrate how you may hide the range title that is visible with selection range.
This will be achieved with completely implicit styles instead of the old way of styling which was used in [Styling the Items and Groups]({%slug radtimebar-styling-the-items-and-groups%}) topic for example.

Here are the steps that you should follow to create a RadTimeBar with implicit Windows8 style:

2. Add reference to RadTimeBar related assemblies from __NoXaml__ folder (under your controls local installation path) - these are as usual Telerik.Windows.Controls, Telerik.Windows.Data and Telerik.Windows.Controls.DataVisualization. 

2. Copy from __Themes.Implicit__ folder the Timebar related XAML from desired Theme (Windows8 in our case).
  Similar to dlls the related resources are: Telerik.Windows.Controls.xaml, Telerik.Windows.Data.xaml and Telerik.Windows.Controls.DataVisualization.xaml. While you do not have XAML
  for the Data assembly you have here one additional resource for standard WPF components - System.Windows.xaml.

3. Declare the XAML resources that you will use. In our case this is Telerik.Windows.Controls.DataVisualization.xaml:

	#### __XAML__

	```XAML
			<Application.Resources>
				<ResourceDictionary>
					<ResourceDictionary.MergedDictionaries>
						<ResourceDictionary Source="Telerik.Windows.Controls.DataVisualization.xaml" />
					</ResourceDictionary.MergedDictionaries>
				</ResourceDictionary>
			</Application.Resources>
		```

4. Set *Telerik.Windows.Controls.StyleManager.IsEnabled* to false in your application constructor.

Now let's add a sample TimeBar:

#### __XAML__

```XAML
	<telerik:RadTimeBar Width="950" Height="250"
	        Margin="0,30,0,0" 
	        PeriodStart="01-01-2012"
	        PeriodEnd="01-01-2013"
	        VisiblePeriodStart="01/01/2012"
	        VisiblePeriodEnd="06/01/2012"
	        SelectionStart="02/01/2012"
	        SelectionEnd="03/01/2012"                          
	        IsSnapToIntervalEnabled="True">
	    <telerik:RadTimeBar.Intervals>
	        <telerik:YearInterval />
	        <telerik:MonthInterval />
	        <telerik:WeekInterval />
	    </telerik:RadTimeBar.Intervals>
	</telerik:RadTimeBar>
	```



![{{ site.framework_name }} RadTimeBar with Selection Rectangle](images/radtimebar_hide_selection_range_title.PNG)

To hide the range selection title you'll need to remove it from the SelectionRange Style, which can be found in *Telerik.Windows.Controls.DataVisualization.xaml*:

#### __XAML__

```XAML
	  <Style x:Key="SelectionRangeStyle" TargetType="Thumb">
	    <Setter Property="BorderBrush" Value="{StaticResource TimeBar_SelectionThumb_Range_OuterBorder}" />
	    <Setter Property="BorderThickness" Value="{StaticResource TimeBar_SelectionThumb_Range_OuterBorder_BorderThickness}" />
	    <Setter Property="Background" Value="#01FFFFFF" />
	    <Setter Property="IsTabStop" Value="False" />
	    <Setter Property="Margin" Value="{StaticResource TimeBar_SelectionThumb_Range_Margin}" />
	    <Setter Property="Cursor" Value="Hand" />
	    <Setter Property="FontSize" Value="{StaticResource TimeBar_SelectionThumb_Range_Title_FontSize}" />
	    <Setter Property="Foreground" Value="{StaticResource TimeBar_SelectionThumb_Range_Title_Foreground}" />
	    <Setter Property="Template">
	      <Setter.Value>
	        <ControlTemplate TargetType="Thumb">
	          <Grid>
	            <Grid.InputBindings>
	              <MouseBinding MouseAction="LeftDoubleClick" Command="timeBars:RadTimeBarCommands.SelectGroupInterval" />
	            </Grid.InputBindings>
	            <VisualStateManager.VisualStateGroups>
	              <VisualStateGroup x:Name="CommonStates">
	                <VisualState x:Name="Normal" />
	                <VisualState x:Name="MouseOver">
	                  <Storyboard>
	                    <ObjectAnimationUsingKeyFrames Storyboard.TargetName="BackgroundAnimation" Storyboard.TargetProperty="Background" Duration="0.00:00:00.05">
	                      <DiscreteObjectKeyFrame KeyTime="0.00:00:00.0" Value="{StaticResource TimeBar_SelectionThumb_Range_Background_MouseOver}" />
	                    </ObjectAnimationUsingKeyFrames>
	                  </Storyboard>
	                </VisualState>
	              </VisualStateGroup>
	            </VisualStateManager.VisualStateGroups>
	            <Grid>
	              <!--<Grid.RowDefinitions>
	                <RowDefinition Height="*" />
	                <RowDefinition Height="14" />
	              </Grid.RowDefinitions>-->
	              <Border x:Name="BackgroundAnimation" Grid.Row="0" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="1" Background="{TemplateBinding Background}" Style="{StaticResource BorderWithActualWidth}" SnapsToDevicePixels="True"></Border>
	              <!--<Canvas Grid.Row="1">
	                <Border Height="14" MinWidth="{Binding ElementName=Title,Path=(timeBars:ActualSizeProxy.ActualWidth)}"
					Width="{Binding ElementName=BackgroundAnimation,Path=(timeBars:ActualSizeProxy.ActualWidth)}"
					Background="{StaticResource TimeBar_SelectionThumb_Range_Title_Background}" BorderThickness="1,0,1,1" BorderBrush="{TemplateBinding BorderBrush}" SnapsToDevicePixels="True">
	                  <TextBlock x:Name="Title" Text="{Binding ElementName=PART_SelectionThumb, Path=Title}" Padding="{StaticResource TimeBar_SelectionThumb_Range_Title_Padding}" MinHeight="12" HorizontalAlignment="Left" VerticalAlignment="Center"
					  Style="{StaticResource TextBlockWithActualWidth}" />
	                </Border>
	              </Canvas>-->
	            </Grid>
	          </Grid>
	        </ControlTemplate>
	      </Setter.Value>
	    </Setter>
	  </Style>
	```



Run the application and check the result:

![radtimebar hide selection range title 1](images/radtimebar_hide_selection_range_title1.PNG)
