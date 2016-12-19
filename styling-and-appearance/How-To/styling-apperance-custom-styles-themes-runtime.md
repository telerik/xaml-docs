---
title: Switching Custom Styles with Themes at Runtime
page_title: Switching Custom Styles with Themes at Runtime
description: Switching Custom Styles with Themes at Runtime
slug: styling-apperance-custom-styles-themes-runtime
tags: switching,custom,styles,with,themes,at,runtime
published: True
position: 3
---

# Switching Custom Styles with Themes at Runtime

Setting a theme using  [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you have the option to change the theme of the controls at runtime without recreating the UI. 

Generally the resources in a merged dictionary occupy a location in the resource lockup scope that is just after the scope of the main resource dictionary they are merged into. What you may do is to isolate your custom styles in a separate resource dictionary and add it as the last one each time you change the theme.
        

As an example, you can follow the steps bellow:
        

1 Create a new application and add the required assemblies from the Binaries.NoXaml folder located in the Telerik UI installation folder. You should also include the theme assemblies:
        

* Telerik.Windows.Controls.dll
            

* Telerik.Windows.Controls.Input.dll
            

* Telerik.Windows.Themes.Office_Black.dll
            

* Telerik.Windows.Themes.Office_Blue.dll
            

2 Add the needed resource dictionaries for the default theme in App.xaml:

#### __XAML__

{{region styling-apperance-custom-styles-themes-runtime_1}}
	<ResourceDictionary>
		<ResourceDictionary.MergedDictionaries>
		 <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml"/>
		 <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml"/>
	 	 <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
	                ......
	</ResourceDictionary.MergedDictionaries>
	</ResourceDictionary>
	
	{{endregion}}



>Initially we merge the ResourceDictionaries for the "Office_Black" Theme.

3 Add few controls of your choice to the layout root of your application. And also two buttons which we will use to switch between two of the themes. 

#### __XAML__

{{region styling-apperance-custom-styles-themes-runtime_2}}
	<Grid x:Name="LayoutRoot" Background="White">
    <Grid.RowDefinitions>
        <RowDefinition Height="*"/>
        <RowDefinition Height="auto"/>
    </Grid.RowDefinitions>
        <telerik:RadButton Content="Button" VerticalAlignment="Center" Width="100"/>
        <StackPanel Grid.Row="1" Orientation="Horizontal">
            <Button x:Name="Office_Black" Margin="5" Content="Office_Black" Click="Office_Black_Click"/>
            <Button x:Name="Office_Blue" Margin="5" Content="Office_Blue" Click="Office_Blue_Click"/>
		</StackPanel>
	</Grid>
	
	{{endregion}}



4 Now we need to add our custom styles in a separate resource dictionary with name CustomStyles.xaml, contained in Themes folder of your project with name CustomStyles_SL (CustomStyles_WPF). This custom ResourceDictionary will have the following content:

#### __XAML__

{{region styling-apperance-custom-styles-themes-runtime_3}}
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
	    <Style TargetType="telerik:RadButton" BasedOn="{StaticResource RadButtonStyle}">
	        <Setter Property="Background" Value="Red"/>
	    </Style>
	</ResourceDictionary>
	
	{{endregion}}



5 In our example we will use the simplest way to change the theme at runtime – using the Click event of each of these Buttons. Upon click, we will clear merged dictionaries from the application resources and merge new resource dictionaries from the theme assemblies with our custom styles contained in Custom Styles.xaml:

#### __C#__

{{region styling-apperance-custom-styles-themes-runtime_4}}
	private void Office_Black_Click(object sender, RoutedEventArgs e)
	{
	    Application.Current.Resources.MergedDictionaries.Clear();
	    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
	    {
	        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
	    });
	    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
	    {
	        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
	    });
	    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
	    {
	        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.RelativeOrAbsolute)
	    });
	    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
	    {
	        Source = new Uri("/CustomStyles;component/Themes/CustomStyles.xaml", UriKind.RelativeOrAbsolute)
	    });
	}
	
	private void Office_Blue_Click(object sender, RoutedEventArgs e)
	{
	    Application.Current.Resources.MergedDictionaries.Clear();
	    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
	    {
	        Source = new Uri("/Telerik.Windows.Themes.Office_Blue;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
	    });
	    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
	    {
	        Source = new Uri("/Telerik.Windows.Themes.Office_Blue;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
	    });
	    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
	    {
	        Source = new Uri("/Telerik.Windows.Themes.Office_Blue;component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.RelativeOrAbsolute)
	    });
	    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
	    {
	        Source = new Uri("/CustomStyles;component/Themes/CustomStyles.xaml", UriKind.RelativeOrAbsolute)
	    });
	
	}
	
	{{endregion}}



The result based on the above code will the one illustrated on the image below:
![styling-apperance-custom-style](images/styling-apperance-custom-style.png)

# See Also
