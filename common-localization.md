---
title: Localization
page_title: Localization
description: Localization
slug: common-localization
tags: localization
published: True
position: 17
---

# Localization

When you limit your product's availability to only one language, you limit your potential customer base to a fraction of the world population. If you want your application to reach a global audience, cost-effective __localization__ of your product is one of the best and most economical ways to reach more customers.

>__Localization__ is the translation of application resources into localized versions for the specific cultures that the application supports.

This article will show you how to localize any resource string used by Telerik UI controls. We will discuss the following topics:

* [Localization using built-in resources](#localization-using-built-in-resources)

* [Resource keys](#resource-keys)

* [Localization using ResourceManager](#localization-using-resourcemanager)

* [Localization using custom localization manager](#localization-using-custom-localization-manager)

>All examples in this article are demonstrated in the context of the Telerik __RadGridView__ control. However, the techniques and principles used for the localization of the string resources are valid for all the other Telerik __{% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls__.

## Localization Using Built-in Resources

The built-in localization mechanism in {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} provides the possibility to easily set the used Telerik {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls in one of the following supported languages:

* **English**

* **German**

* **Spanish**

* **French**

* **Italian**

* **Dutch**

* **Turkish**

The default is English, but you can find a separate file for each of the other languages in a corresponding folder together with the other binaries in your local installation.

>If you need to translate your control into a different language, you should use a [Custom Localization Manager](#localization-using-custom-localization-manager).

To localize your controls using the built-in localization mechanism, you first have to place the resource folders along with the binaries you have referenced as shown in **Figure 3**.

#### __Figure 1: Placing the resource folders in your project__

![Common Localization 050](images/Common_Localization_050.PNG)

{% if site.site_name == 'Silverlight' %}
Then, you must define your preferred languages in the **&lt;Supported Cultures&gt;** tag of your project file in order to notify the framework about the supported cultures. To do so, open the project file with a text editor and insert the code below into the __&lt;PropertyGroup&gt;__ section.

#### __[XAML] Example 1: Setting supported cultures__

{{region common-localization_4}}
	<SupportedCultures>en;nl</SupportedCultures>
{{endregion}}

The next step for defining the language settings of the application is changing the __Current Culture__ of the application.
            
#### __[C#] Example 2: Setting the current culture of the application__

{{region common-localization_11}}
	private void Application_Startup(object sender, StartupEventArgs e)
	{
	    Thread.CurrentThread.CurrentCulture = new CultureInfo("de");
	    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
	
	    this.RootVisual = new MainPage();
	}
{{endregion}}

#### __[VB.NET] Example 2: Setting the current culture of the application__

{{region common-localization_12}}
	Private Sub Application_Startup(sender As Object, e As StartupEventArgs)
	    Thread.CurrentThread.CurrentCulture = New CultureInfo("de")
	    Thread.CurrentThread.CurrentUICulture = New CultureInfo("de")
	
	    Me.RootVisual = New MainPage()
	End Sub
{{endregion}}

{% endif %}

{% if site.site_name == 'WPF' %}
The next step for defining the language settings of the application is changing the __Current Culture__ of the application:
         
#### __[C#] Example 1: Setting the current culture of the application__

{{region common-localization_9}}
	public App()
	{
	    Thread.CurrentThread.CurrentCulture = new CultureInfo("de");
	    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
	}
{{endregion}}

#### __[VB.NET] Example 1: Setting the current culture of the application__

{{region common-localization_10}}
	Public Sub New()
	    Thread.CurrentThread.CurrentCulture = New CultureInfo("de")
	    Thread.CurrentThread.CurrentUICulture = New CultureInfo("de")
	End Sub
{{endregion}}

{% endif %}

That's it. Your controls should now be localized in the preferred language.

#### __Figure 2: RadGridView localized in German__

![Common_Localization_070](images/Common_Localization_070.png)

## Resource Keys

Some of the controls are complex user interface controls (e.g., __RadGridView__, __RadScheduleView__) and their strings for localization are numerous. In order to be able to distinguish these resources, a unique identifier called __resource key__ is assigned to each localizable string.

In Figure 3 you can see some resource keys and the strings they are associated with.

#### __Figure 3: Some of RadGridView's resource keys and their values__

![Common_Localization_060](images/Common_Localization_060.png)

>tipFor a full list of __resource keys__, check out the __Localization__ topic for the specific control.

## Localization Using ResourceManager

If you need to modify the default strings for a chosen language, you can base your localization on the standard resource files. For that purpose, you will have to create a separate __.resx__ file for each of the languages that your application will support.
        
Imagine that you want to translate your control, RadGridView for example, into English, German and Dutch. You will have to add three new resource files to your project:

* __GridViewResources.resx__ - this resource file will store the __English(default)__ resources for the grid control. Set the __AccessModifier__ property to __Public__.
          
* __GridViewResources.de.resx__ - this resource file will store the __German__ resources for the grid control. Set the __AccessModifier__ property to  __No code generation__.
          
* __GridViewResources.nl.resx__ - this resource file will store the __Dutch__ resources for the grid control. Set the __AccessModifier__ property to __No code generation__.

#### __Figure 4: Creating separate .resx files for each of the supported languages__
          
![Common Localization 030](images/Common_Localization_030.png)

Now that you have the needed files, it's time to localize only the text for the group panel. For that purpose, you need to create a single resource string in each one of the three resource files and translate it to the appropriate language.
      
>Note that the name of the resource string should be the same as the resource key for the string that you are localizing. The resource key for RadGridView's group panel is __GridViewGroupPanelText__.
          
>tipFor a full list of __resource keys__, check out the __Localization__ topic for the specific control.
<Comment: This is a repeat of the same tip in the last section. Is it important to repeat it?>

Figure 5 shows the content of the __GridViewResources.de.resx__ file. The resource __Name__ (**GridViewGroupPanelText**) of the other two files should be the same. The __Value__ column will contain the translation for the appropriate language.

#### __Figure 5: The content of GridViewResources.de.resx__

![Common Localization 040](images/Common_Localization_040.png)

The last step is to instantiate the __LocalizationManager__ class, which allows you to easily localize any Telerik UI controls, by going through all resource keys and returning the appropriate translation. You then set its __ResourceManager__ to the resources that have just  been created (you can do this in the default constructor of the Application class).

{% if site.site_name == 'WPF' %}
#### __[C#] Example 2: Setting the LocalizationManager's ResourceManager__
{% endif %}
{% if site.site_name == 'Silverlight' %}
#### __[C#] Example 3: Setting the LocalizationManager's ResourceManager__
{% endif %}

{{region common-localization_2}}
	LocalizationManager.Manager = new LocalizationManager()
	{
	   ResourceManager = GridViewResources.ResourceManager
	};
{{endregion}}

{% if site.site_name == 'WPF' %}
#### __[VB.NET] Example 2: Setting the LocalizationManager's ResourceManager__
{% endif %}
{% if site.site_name == 'Silverlight' %}
#### __[VB.NET] Example 3: Setting the LocalizationManager's ResourceManager__
{% endif %}

{{region common-localization_3}}
	LocalizationManager.Manager = New LocalizationManager()
	LocalizationManager.Manager.ResourceManager = GridViewResources.ResourceManager
{{endregion}}

{% if site.site_name == 'WPF' %}

>If you rely on culture settings to load the right resources automatically, you have to write some code inside your application's project file. For example, if you have to support English and Dutch languages, you can store the localized strings in __Resources.resx__ and __Resources.nl.resx__ files. For the __Resources.resx__ file, you can set __ResXFileCodeGenerator__ to __Internal__ or __Public__ and for others, to __No code generation__.         
{% endif %}

{% if site.site_name == 'Silverlight' %}
>If you rely on culture settings to load the right resources automatically, you have to write some code inside your application's project file. For example, if you have to support English and Dutch languages, you can store the localized strings in __Resources.resx__ and __Resources.nl.resx__ files. For the __Resources.resx__ file, you can set __ResXFileCodeGenerator__ to __Internal__ or __Public__ and for others, to __No code generation__. Then, open the project file in a text-mode and insert the code below into the __&lt;PropertyGroup&gt;__ section. In this way you notify the framework about the supported cultures.

#### __[XAML] Example 4: Setting the project's supported cultures__

{{region common-localization_4}}
	<SupportedCultures>en;nl</SupportedCultures>
{{endregion}}
{% endif %}

## Localization Using Custom Localization Manager

If you want to translate your controls to a language different from the default available ones, you will need to create a custom **LocalizationManager**. To do so, create a class that derives from __LocalizationManager__ and override its __GetStringOverride()__ method. The logic is pretty simple - you just have to create a switch statement and return the correct translation for each resource key, as shown below:
        
{% if site.site_name == 'WPF' %}
#### __[C#] Example 3: Overriding the LocalizationManager's GetStringOverride() method__
{% endif %}
{% if site.site_name == 'Silverlight' %}
#### __[C#] Example 5: Overriding the LocalizationManager's GetStringOverride() method__
{% endif %}

{{region common-localization_5}}
	public class CustomLocalizationManager : LocalizationManager
	{
	  public override string GetStringOverride(string key)
	  {
	      switch( key )
	      {
	          case "GridViewGroupPanelText":
	              return "Zum gruppieren ziehen Sie den Spaltenkopf in diesen Bereich.";
	          //---------------------- RadGridView Filter Dropdown items texts:
	          case "GridViewClearFilter":
	              return "Filter löschen";
	          case "GridViewFilterShowRowsWithValueThat":
	              return "Anzeigen der Werte mit Bedingung:";
	          case "GridViewFilterSelectAll":
	              return "Alles anzeigen";
	          case "GridViewFilterContains":
	              return "Enthält";
	          case "GridViewFilterEndsWith":
	              return "Endet mit";
	          case "GridViewFilterIsContainedIn":
	              return "Enthalten in";
	          case "GridViewFilterIsEqualTo":
	              return "Gleich";
	          case "GridViewFilterIsGreaterThan":
	              return "Grösser als ";
	          case "GridViewFilterIsGreaterThanOrEqualTo":
	              return "Grösser oder gleich";
	          case "GridViewFilterIsLessThan":
	              return "Kleiner als";
	          case "GridViewFilterIsLessThanOrEqualTo":
	              return "Kleiner oder gleich";
	          case "GridViewFilterIsNotEqualTo":
	              return "Ungleich";
	          case "GridViewFilterStartsWith":
	              return "Beginnt mit";
	          case "GridViewFilterAnd":
	              return "Und";
	          case "GridViewFilter":
	              return "Filter";
	      }
	      return base.GetStringOverride(key);
	  }
{{endregion}}

{% if site.site_name == 'WPF' %}
#### __[VB.NET] Example 3: Overriding the LocalizationManager's GetStringOverride() method__
{% endif %}
{% if site.site_name == 'Silverlight' %}
#### __[VB.NET] Example 5: Overriding the LocalizationManager's GetStringOverride() method__
{% endif %}

{{region common-localization_6}}
	Public Class CustomLocalizationManager
	 Inherits LocalizationManager
	 Public Overrides Function GetStringOverride(key As String) As String
	  Select Case key
	   Case "GridViewGroupPanelText"
	    Return "Zum gruppieren ziehen Sie den Spaltenkopf in diesen Bereich."
	   '---------------------- RadGridView Filter Dropdown items texts:'
	   Case "GridViewClearFilter"
	    Return "Filter löschen"
	   Case "GridViewFilterShowRowsWithValueThat"
	    Return "Anzeigen der Werte mit Bedingung:"
	   Case "GridViewFilterSelectAll"
	    Return "Alles anzeigen"
	   Case "GridViewFilterContains"
	    Return "Enthält"
	   Case "GridViewFilterEndsWith"
	    Return "Endet mit"
	   Case "GridViewFilterIsContainedIn"
	    Return "Enthalten in"
	   Case "GridViewFilterIsEqualTo"
	    Return "Gleich"
	   Case "GridViewFilterIsGreaterThan"
	    Return "Grösser als "
	   Case "GridViewFilterIsGreaterThanOrEqualTo"
	    Return "Grösser oder gleich"
	   Case "GridViewFilterIsLessThan"
	    Return "Kleiner als"
	   Case "GridViewFilterIsLessThanOrEqualTo"
	    Return "Kleiner oder gleich"
	   Case "GridViewFilterIsNotEqualTo"
	    Return "Ungleich"
	   Case "GridViewFilterStartsWith"
	    Return "Beginnt mit"
	   Case "GridViewFilterAnd"
	    Return "Und"
	   Case "GridViewFilter"
	    Return "Filter"
	  End Select
	  Return MyBase.GetStringOverride(key)
	 End Function
	End Class
{{endregion}} 

Of course, if you don't want to hard-code your translation inside your source code, you can always use resource files:

{% if site.site_name == 'WPF' %}
#### __[C#] Example 4: Using resource files in the GetStringOverride() method__
{% endif %}
{% if site.site_name == 'Silverlight' %}
#### __[C#] Example 6: Using resource files in the GetStringOverride() method__
{% endif %}

{{region common-localization_7}}
	public override string GetStringOverride(string key)
	{
	   switch( key )
	   {
	       //----------------------
	       case "GridViewClearFilter":
	           return GridViewResources.GridViewClearFilter;
	       //----------------------
	   }
	   return base.GetStringOverride(key);
	}
{{endregion}}

{% if site.site_name == 'WPF' %}
#### __[VB.NET] Example 4: Using resource files in the GetStringOverride() method__
{% endif %}
{% if site.site_name == 'Silverlight' %}
#### __[VB.NET] Example 6: Using resource files in the GetStringOverride() method__
{% endif %}

{{region common-localization_8}}
	Public Overloads Overrides Function GetStringOverride(ByVal key As String) As String
	    Select Case key
	        '----------------------'
	        Case "GridViewClearFilter"
	            Return GridViewResources.GridViewClearFilter
	        '----------------------'
	    End Select
	    Return MyBase.GetStringOverride(key)
	End Function
{{endregion}}

All that's left to do is to set our CustomLocalizationManager to the static Manager property of the LocalizationManager:

{% if site.site_name == 'WPF' %}
#### __[C#] Example 5: Applying the custom LocalizationManager__
{% endif %}
{% if site.site_name == 'Silverlight' %}
#### __[C#] Example 7: Applying the custom LocalizationManager__
{% endif %}

{{region common-localization_0}}
	LocalizationManager.Manager = new CustomLocalizationManager();
{{endregion}}

{% if site.site_name == 'WPF' %}
#### __[VB.NET] Example 5: Applying the custom LocalizationManager__
{% endif %}
{% if site.site_name == 'Silverlight' %}
#### __[VB.NET] Example 7: Applying the custom LocalizationManager__
{% endif %}

{{region common-localization_1}}
	LocalizationManager.Manager = New CustomLocalizationManager()
{{endregion}}

# See Also

* [Consuming Data - Overview]({%slug consuming-data-overview%})
