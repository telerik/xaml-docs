---
title: Switching Custom Styles with Themes at Runtime
page_title: Switching Custom Styles with Themes at Runtime
description: Switching Custom Styles with Themes at Runtime
slug: styling-apperance-custom-styles-themes-runtime
tags: switching,custom,styles,with,themes,at,runtime
published: True
position: 10
---

# Switching Custom Styles with Themes at Runtime

Setting a theme using [implicit styles]({%slug styling-apperance-implicit-styles-overview%}), you have the option to change the theme of the controls at runtime without recreating the UI.

The resources in a merged dictionary occupy a location in the resource lockup scope that is just after the scope of the main resource dictionary they are merged into. What you can do is to isolate your custom styles in a separate resource dictionary and add it as the last one each time you change the theme.

As an example, you can follow the steps bellow:

**1.** Create a new application and add the required assemblies from the **Binaries.NoXaml** folder located in the Telerik UI for {{ site.framework_name }} installation folder as well as the theme assemblies:

* **Telerik.Windows.Controls.dll**

* **Telerik.Windows.Controls.Input.dll**

* **Telerik.Windows.Themes.Office_Black.dll**

* **Telerik.Windows.Themes.Office_Blue.dll**

**2.** Add the respective resource dictionaries for the default theme in **App.xaml**:

#### __[XAML] Example 1: Merge resource dictionaries__

{{region xaml-styling-apperance-custom-styles-themes-runtime_1}}
	<ResourceDictionary>
		<ResourceDictionary.MergedDictionaries>
			<ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml"/>
			<ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml"/>
	 		<ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
	    	<!-- ... -->
		</ResourceDictionary.MergedDictionaries>
	</ResourceDictionary>
	
	{{endregion}}

>Initially we merge the resource dictionaries for the **Office_Black** theme.

**3.** Add a few controls of your choice to the layout root of your application. And also two buttons which will be used to switch between the themes. 

#### __[XAML] Example 2: Add buttons to switch between the themes__

{{region xaml-styling-apperance-custom-styles-themes-runtime_2}}
	<Grid x:Name="LayoutRoot" Background="White">
		<Grid.RowDefinitions>
			<RowDefinition Height="\*"/>
			<RowDefinition Height="auto"/>
		</Grid.RowDefinitions>
        <telerik:RadButton Content="Button" VerticalAlignment="Center" Width="100"/>
        <StackPanel Grid.Row="1" Orientation="Horizontal">
            <Button x:Name="Office_Black" Margin="5" Content="Office_Black" Click="Office_Black_Click"/>
            <Button x:Name="Office_Blue" Margin="5" Content="Office_Blue" Click="Office_Blue_Click"/>
		</StackPanel>
	</Grid>
{{endregion}}

**4.** Now add your custom styles in a separate resource dictionary called **CustomStyles.xaml**, for example, contained in the **Themes** folder of your project. This custom resource dictionary will have the following content:

#### __[XAML] Example 3: Add custom styles in separate resource dictionary__

{{region xaml-styling-apperance-custom-styles-themes-runtime_3}}
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
			    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
			    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
		<Style TargetType="telerik:RadButton" BasedOn="{StaticResource RadButtonStyle}">
			<Setter Property="Background" Value="Red"/>
		</Style>
	</ResourceDictionary>
{{endregion}}

**5.** Then, in the buttons **Click** handlers, we will clear the merged dictionaries from the application resources and merge the new resource dictionaries from the theme assemblies along with our custom styles contained in **CustomStyles.xaml**:

#### __[C#] Example 4: Clear and merge dictionaries upon button click__

{{region cs-styling-apperance-custom-styles-themes-runtime_4}}
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

The result based on the above code is illustrated in **Figure 1**.

#### Figure 1: RadButtons with Office_Black and Office_Blue themes

![RadButtons with Office_Black and Office_Blue themes](images/styling-apperance-custom-style.png)

## See Also

* [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
* [Switching Icons at Runtime]({%slug styling-apperance-switching-icons-at-runtime%})
* [Setting a Theme on MS Controls]({%slug styling-apperance-themes-mscontrols%})
