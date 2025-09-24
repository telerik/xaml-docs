---
title: Setting Default Startup Language
page_title: Setting Default Startup Language
description: Learn how to use the CustomLocalization Manager in order to translate Telerik's {{ site.framework_name }} DataGrid in another language.
slug: gridview-localization-setting-default-startup-language3
tags: setting,default,startup,language
published: True
position: 1
---

# Setting Default Startup Language

The built-in localization mechanism in {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} provides the possibility to set your controls in whichever language you need. Up to now the supported languages are **English**, **German**, **Spanish**, **French**, **Dutch**, **Italian** and **Turkish**.

If you want to translate your control in another language, you should use the CustomLocalization Manager, as it is described in the common [Localization]({%slug common-localization%}).

You can also learn more on [RadGridView Localization]({%slug gridview-localization2%}).

{% if site.site_name == 'Silverlight' %}
However, in case you aim at loading the right resources automatically by means of culture settings, a couple of things need to be done. Firstly, your project file should be opened in text – mode. So, go to Visual Studio, right – click on the project and unload it.

![Telerik {{ site.framework_name }} DataGrid-Localization Default Language 1](images/Localization_DefaultLanguage1.png)

Here, under the section of &lt;Property Group&gt; is the element &lt;Supported Cultures&gt;. This is the place, where every language you want your application to support is defined. In case the desired default language is Spanish, for example, the code will be:



```XAML
	  <SupportedCultures>es</SupportedCultures>
```

Thus the framework is notified about the supported cultures and will include the satellite resource assemblies for all Telerik controls.

{% endif %}{% if site.site_name == 'WPF' %}

The thing that you must do for defining the language settings of the application, is to change the current culture of the application. Locate the application initialization logic and add some code in the method for Startup in App.xaml.cs:



```C#
	Thread.CurrentThread.CurrentCulture = new CultureInfo("es");
	Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");
```



```VB.NET
	Thread.CurrentThread.CurrentCulture = New CultureInfo("es")
	Thread.CurrentThread.CurrentUICulture = New CultureInfo("es")
```

{% endif %}

Note that, the resource folders are supposed to be placed along with the binaries you have referenced.

![Telerik {{ site.framework_name }} DataGrid localization defaultlanguage3png](images/RadGridView_localization_defaultlanguage3png.PNG)

Thus, after setting the startup language, all controls will be translated automatically and the application will initialize in the specified language.

![Telerik {{ site.framework_name }} DataGrid-Localization Default Language 2](images/Localization_DefaultLanguage2.png)

## See Also

 * [RadGridView Localization]({%slug gridview-localization2%})
