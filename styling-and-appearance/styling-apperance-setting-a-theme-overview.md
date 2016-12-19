---
title: Setting a Theme
page_title: Setting a Theme 
description: Setting a Theme 
slug: styling-apperance-implicit-styles-overview
tags: setting,a,theme,(using,,implicit,styles)
published: True
position: 0
---

# Setting a Theme

**Setting a theme** is the preferred way of styling the controls that come with the **Telerik UI for WPF** suite. Apart from the default **Office_Black**, you have the option to choose from variety of other themes to achieve outstanding visual appearance and great user experience. Before choosing what theme to apply and what approach to take in order to do so, you might find useful to familiarize with the [Themes concept](#what-is-a-theme) and their [distribution](#themes-distribution).

## What is a theme?

A theme contains all styles and resources needed for the visualization of the Telerik controls. Each theme consists of multiple **XAML** files. The files names are similar to the binary files that you need to reference in your application. With this in mind, for each binary reference in your application, you need to merge the respective XAML file in the application's resource dictionaries. You can think of a certain theme as a collection of compliant Styles which are implicitly applied to the controls. 

## Does it affect all WPF Controls?

Алл Themes are specifically designed to style **Telerik** controls. However, there are some **native {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}** controls which are affected by the theming mechanism as well. You can find a list of these controls in the [Setting a Theme on MS Controls]({%slug styling-apperance-themes-mscontrols%}) article.

## Where can each theme's resources be found?

After installing the __UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}__ suite, you will find the following structure in the installation folder (usually C://Program Files/Telerik/ UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} [version]/)
    

* __Binaries__: The standard binaries including the themes dlls.

* __Binaries.NoXaml__: Binaries without XAML, even the default **Office_Black** theme is not included.

* __Themes.Implicit__: The XAML code for all the controls.

## Applying a Theme for Your Application

Now that you have an idea of the concepts behind the theming mechanism, it is time to set up your project so that it is correctly applied. 

There are two main approaches which you can choose:


* [Reference the **theme DLL**](#reference-the-theme-dll) which includes *all XAML files* for the respective theme and merge only the needed **XAML** files in the **MergedDictionaries** of your application.

* [Copy the different **XAML** files of the controls](#copy-the-xaml-files-in-a-dedicated-folder-in-your-application) which you will use in your application(from the respective theme`s folder) into a dedicated folder in your application and merge them in the application's **MergedDictionaries**. This approach is preferred in case you need to directly modify the default styles and resources of the theme.

The approaches are shown in details below:

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


>If you copy the XAML files in your project, please make sure that they are with the proper build action. Generally it should be __Resource__, but for the __Telerik.Windows.Controls.RibbonView.xaml__ file the build action should be __Page__. __Telerik.Windows.Controls.RichTextBoxUI.xaml__ also should be with build action __Page__ since it includes all RibbonView styles. This is caused by several x:Shared setters, which cannot be set in loose XAML. More information can be found in [MSDN](http://msdn.microsoft.com/en-us/library/aa970778%28v=vs.110%29.aspx).

>tip You should not set Application Theme using the __StyleManager__ when using implicit styles. 

