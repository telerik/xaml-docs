---
title: Setting a Theme (Using  Implicit Styles)
page_title: Setting a Theme (Using  Implicit Styles)
description: Setting a Theme (Using  Implicit Styles)
slug: styling-apperance-implicit-styles-overview
tags: setting,a,theme,(using,,implicit,styles)
published: True
position: 0
---

# Setting a Theme (Using  Implicit Styles)

**Setting a theme** is the preferred way of styling the controls provided by the __Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}__ suite. This article covers the following topics:

* [Implicit Styles Benefits](#implicit-styles-benefits)

* [Themes Distribution](#themes-distribution)
      
* [Applying a Theme Globally in Your Application](#applying-a-theme-globally-in-your-application)

* [Basing a Custom Style on a Theme Default Style](#basing-a-custom-style-on-a-theme-default-style)

* [Example: How To Apply Custom Styles to Controls](#how-to-apply-custom-style-to-controls  )

* [Styling Custom Controls](#styling-custom-controls)

* [Control Styles Dependencies](#control-styles-dependencies)

## Implicit Styles Benefits

Using **Implicit Styles** provides a number of advantages over the __StyleManager__. Some of them are listed below:

* Custom themes are easy - created only via Merged Dictionaries

* Basing styles on a theme is extremely simple

* Assemblies have a smaller size

* Improved Blend support

> You can find more information on what  made the **Implicit Styles** approach the preferred one on the following blog post - [XAML Theming - Implicit Styles versus StyleManager](http://www.telerik.com/blogs/xaml-theming-implicit-styles-versus-stylemanager)

## Themes Distribution

After installing the __UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}__ suite, you will find the following folders in your installation folder (usually C://Program Files/Telerik/ UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} [version]/)
    

* __Binaries__: The standard binaries including the themes dlls.

* __Binaries.NoXaml__: Binaries without XAML, even the default **Office_Black** theme is not included.

* __Themes.Implicit__: The XAML code for all the controls.


>important Styling RadChart - __Telerik.Windows.Controls.Charting.dll__ and the old (pre Q2 2012) RadGauge - __Telerik.Windows.Controls.Gauge__ with implicit styles is not supported! 	  

## Applying a Theme Globally in Your Application

There are two main approaches for applying a theme in your application:

* [Copy the different **XAML** files of the controls](#copy-the-xaml-files-in-a-dedicated-folder-in-your-application) which you will use in your application(from the respective theme`s folder) into a dedicated folder in your application and merge them in the application's **MergedDictionaries**. This approach is preferred in case you need to directly modify the default styles and resources of the theme.

* [Reference the **theme DLL**](#reference-the-theme-dll) which includes *all XAML files* for the respective theme and merge only the needed **XAML** files in the **MergedDictionaries** of your application.

The approaches are shown in details below:

### Copy the XAML files in a dedicated folder in your application

The default styles and resources for each theme are shipped in the **Themes.Implicit** folder. In order to apply a certain theme for your application you need to merge all the required **XAML** files from the respective theme's folder(depends on the set of controls you are using) in the application's **MergedDictionaries**. You should merge all **XAML** files corresponding to each assembly reference you have in your project, as shown in **Example 1** and **Figure 1 and 2**. 

#### __Figure 1: The binary references in your application:__

![implicit styles 3](images/implicit-styles-references.png)

>important The references should point to the binary files from the __Binaries.NoXAML__ folder.

#### __Figure 2: Copy the needed XAML files in a separate folder in your application:__

![implicit styles 3](images/implicit-styles-themes-folder.PNG)

#### __[XAML] Example 1: The MergedDictionaries in your application resources:__

	<Application.Resources>
        <ResourceDictionary>
		    <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="/Themes/System.Windows.xaml"/>
                <ResourceDictionary Source="/Themes/Telerik.Windows.Controls.xaml"/>
                <ResourceDictionary Source="/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
                <ResourceDictionary Source="/Themes/Telerik.Windows.Controls.GridView.xaml"/>
                <ResourceDictionary Source="/Themes/Telerik.Windows.Controls.Input.xaml"/>
                <ResourceDictionary Source="/Themes/Telerik.Windows.Controls.Data.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
	</Application.Resources>

### Reference the Theme DLL

 All XAML files are included in a separate __Theme DLL__ located in the **Binaries.NoXaml** folder (Telerik.Windows.Themes.Expression_Dark.dll, Telerik.Windows.Themes.Windows8.dll, etc.). So instead of copying all the XAML files in your project(as in Figure 2), you can just merge them directly from the theme assembly. For example, if you are using the **Office_Black** theme, you should add a reference to the **Telerik.Windows.Themes.Office_Black.dll** and then merge the needed .xaml files as shown in **Figure 3** and **Example 3** .

#### __Figure 3: Add reference to the theme binary file:__

![implicit styles 3](images/implicit-styles-theme-dll.PNG)

#### __[XAML] Example 2: After you add a reference, you should merge the needed .xaml files__

	 <Application.Resources>
			<ResourceDictionary>
	    		<ResourceDictionary.MergedDictionaries>
	       	 	    <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.GridView.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Data.xaml"/>              
	    	</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>	
	 </Application.Resources>

>If you copy the XAML files in your project, please make sure that they are with the proper build action. Generally it should be __Resource__, but for the __Telerik.Windows.Controls.RibbonView.xaml__ file the build action should be __Page__. __Telerik.Windows.Controls.RichTextBoxUI.xaml__ also should be with build action __Page__ since it includes all RibbonView styles. This is caused by several x:Shared setters, which cannot be set in loose XAML. More information can be found in [MSDN](http://msdn.microsoft.com/en-us/library/aa970778%28v=vs.110%29.aspx).

>tip You should not set Application Theme using the __StyleManager__ when using implicit styles. 

## Basing a Custom Style on a Theme Default Style

When you create a style that targets a specific control, you should base it on the default style that the theme provides. This way you will make sure that all properties, apart from the changed ones, are inherited from the default style.

We have followed a naming convention where the key for every control`s default style consists of **the name of the control followed by a "Style" suffix**. This would mean that the default style applied for the **RadGridView** control is with **x:Key="RadGridViewStyle"**, the default one for the **RadComboBox** with **x:Key="RadComboBoxStyle"**, etc. **Example 3** shows how to create custom styles based on the default one for the **RadComboBox** control:

#### __[XAML] Example 3: Custom styles for RadComboBox__

{{region styling-apperance-implicit-styles-overview_5}}

    <Style x:Key="CustomStyle" TargetType="telerik:RadComboBox" BasedOn="{StaticResource RadComboBoxStyle}">
        <Setter Property="Foreground" Value="Green" />
    </Style>

    <Style TargetType="telerik:RadComboBox" BasedOn="{StaticResource RadComboBoxStyle}">
        <Setter Property="Foreground" Value="Red" />
    </Style>

{{endregion}}

## How To Apply Custom Style to Controls  

The following example shows how to apply a custom style to a control in an application that uses the **Windows8** Theme. The control used is **RadComboBox** but the approach is identical for all controls and themes.
        
* First, add references to the required assemblies from the **Binaries.NoXaml** folder.

* Next, create a **Themes** folder in your project and copy the corresponding .xaml files from __Themes.Implicit/../Windows8/../Themes/ folder__ as shown in **Figure 4**.
        
#### __Figure 4: Copy the needed .xaml in the project__
![implicit styles 1](images/implicit_styles_1.png)

* The next step is to merge these **ResourceDictionaries** in the App.xaml file as shown in __Example 4__.          
            
#### __[XAML] Example 4: Merging the Resource Dictionaries__

{{region styling-apperance-implicit-styles-overview_0}}

		<Application xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
		             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
		             x:Class="RadControlsSilverlightNoXaml.App"
		             >
		    <Application.Resources>
				<ResourceDictionary>
					<ResourceDictionary.MergedDictionaries>
						<ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
						<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Input.xaml" />
					</ResourceDictionary.MergedDictionaries>
				</ResourceDictionary>
			</Application.Resources>
		</Application>
{{endregion}}

* And here is the result:

#### **Figure 5: RadComboBox default appearance**
![implicit styles 2](images/implicit_styles_2.png)

In order to modify the appearance of **RadComboBox**, simply base your custom style on the default style for the control as shown in **Example 5**.

**Example 5** shows how to create two custom styles for **RadComboBox** based on the  default styles from the **Windows8** theme.  
        
#### __[XAML] Example 5: Add custom styles for RadComboBox__

{{region styling-apperance-implicit-styles-overview_1}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Input.xaml" />
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
		<Style x:Key="CustomStyle" TargetType="telerik:RadComboBox" BasedOn="{StaticResource RadComboBoxStyle}">
			<Setter Property="Foreground" Value="Green" />
		</Style>
		<Style TargetType="telerik:RadComboBox" BasedOn="{StaticResource RadComboBoxStyle}">
			<Setter Property="Foreground" Value="Red" />
		</Style>
	</Application.Resources>
{{endregion}}

If you have three __RadComboBoxes__ as shown in __Example 6__.          
        
#### __[XAML] Example 6: RadComboBoxes with custom styling__

{{region styling-apperance-implicit-styles-overview_2}}
	<StackPanel>
		<telerik:RadComboBox ItemsSource="{Binding}" Width="200" Margin="2" Style="{StaticResource CustomStyle}" />
		<telerik:RadComboBox ItemsSource="{Binding}" Width="200" Margin="2" />
		<telerik:RadComboBox ItemsSource="{Binding}" Width="200" Margin="2" />
	</StackPanel>
{{endregion}}

The __RadComboBox__ instances will be displayed as shown in __Figure 6__.
        
#### **Figure 6: RadComboBox instances with custom styles.**
![implicit styles 3](images/implicit_styles_3.png)


## Styling Custom Controls

If you're using Implicit Styles for custom controls, note that they will not automatically receive the inherited control style. You will have to base your custom style on the default style of the control that is inherited.

#### __[XAML] Example 7: Adding Style for styling custom control__

{{region styling-apperance-implicit-styles-overview_7}}
	<Application.Resources>
	  <ResourceDictionary>
	    <ResourceDictionary.MergedDictionaries>
	      <ResourceDictionary Source="Themes/System.Windows.xaml" />
	      <ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
	      <ResourceDictionary Source="Themes/Telerik.Windows.Controls.GridView.xaml" />
	      <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Input.xaml" />
	    </ResourceDictionary.MergedDictionaries>
		<Style TargetType="local:MyCustomGrid" BasedOn="{StaticResource RadGridViewStyle}" />
	  </ResourceDictionary>
	</Application.Resources>
{{endregion}}

You will then need to set the control's **DefaultStyleKey**.

#### __[C#] Example 8: Setting the DefaultStyleKey for styling custom control__

{{region styling_customstyles}}
	public class MyCustomGrid : RadGridView
	{
		public MyCustomGrid()
        {
            this.DefaultStyleKey = typeof(MyCustomGrid);
        }
	}
{{endregion}}

#### __[VB.NET] Example 8: Setting the DefaultStyleKey for styling custom control__

{{region styling_customstyles-2}}
	Public Class MyCustomGrid
		Inherits RadGridView
		Public Sub New()
			Me.DefaultStyleKey = GetType(MyCustomGrid)
		End Sub
	End Class
{{endregion}}

>You might also have a look at the [Setting a Theme on a Custom Control](http://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/styling-apperance-custom-control) article.

## Control Styles Dependencies

**Example 9** lists the XAML files corresponding to the Telerik assemblies and the dependencies between them.
        
#### __[XAML] Example 9: All XAML files corresponding to the Telerik assemblies__

{{region styling-apperance-implicit-styles-overview_3}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
	
				<!-- Telerik.Windows.Controls is used by all assemblies -->			
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
	
				<ResourceDictionary Source="Themes/System.Windows.xaml" />	
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Input.xaml" />
	
				<!-- Requires: System.Windows.xaml -->
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Navigation.xaml" />
	
		 		<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Chart.xaml" />
	
				<!-- Requires: Telerik.Windows.Controls.Input -->	
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Data.xaml" />
	
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.DataVisualization.xaml" />
	
				<!-- Requires: Telerik.Windows.Controls.Navigation -->
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Docking.xaml" />
	
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Expressions.xaml" />
	
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.FixedDocumentViewers.xaml" />
	
				<!-- Requires: Telerik.Windows.Controls.Input -->
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.GridView.xaml" />
	
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.ImageEditor.xaml" />
	
				<!-- Requires: Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation -->
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.RibbonView.xaml" />
	
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.RichTextBoxUI.xaml" />
	
				<!-- Requires: System.Windows, Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation -->
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.ScheduleView.xaml" />
	
				<!-- Requires: Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation -->
				<ResourceDictionary Source="Themes/Telerik.Windows.Documents.xaml" />
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}


## See Also

* [Switching Custom Styles with Themes at Runtime]({%slug styling-apperance-custom-styles-themes-runtime%})

* [Switching Themes at Design-Time]({%slug styling-apperance-swiching-themes-design-time%})

* [Setting a Theme on MS Controls]({%slug styling-apperance-themes-mscontrols%})