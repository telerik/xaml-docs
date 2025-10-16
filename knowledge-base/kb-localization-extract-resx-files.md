---
title: Extract the Default Telerik Localization Resources
page_title: Extract the default Telerik .resx files containing the localization strings and save them to files.
description: Get the Telerik .resx Files Values
type: how-to
slug: kb-localization-extract-resx-files
position: 0
tags: localization,language,extract,resx
ticketid: 1630913
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2023.3.1010</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to extract the default Telerik `.resx` files containing the localization strings and save them to files. This will allow you to replace values from the original files and extend the localization with a new language.

An alternative approach than the one shown in this topic is to create a custom `LocalizationManager` and override its `GetStringOverride` method, as shown in the [Localization]({%slug common-localization%}) article.

## Solution

The Telerik's default `.resx` files can be accessed by loading the __Telerik.Windows.Controls__ `Assembly` and then creating a new `ResourceManager` that loads resource file by name. Then, you can read the resources for the different cultures and save them in new `.resx` files.

To create new `.resx` files, you can use the [ResXResourceWriter](https://learn.microsoft.com/en-us/dotnet/api/system.resources.resxresourcewriter?view=windowsdesktop-7.0) class from the `System.Windows.Forms` assembly.


```C#
	private void ExtractTelerikDefaultLocalizationResources()
	{            
		string newResourceFileNameFormat = @".\TelerikStrings{0}.resx";
		string defaultLanguageTag = "us-US";
		var supportedCultures = new List<CultureInfo>()
		{
			new CultureInfo(defaultLanguageTag),
			new CultureInfo("de-DE"),
			new CultureInfo("es-ES"),
			new CultureInfo("fr-FR"),
			new CultureInfo("it-IT"),
			new CultureInfo("nl-NL"),
			new CultureInfo("tr-TR"),
		};

		var telerikAssembly = Assembly.Load("Telerik.Windows.Controls");
		var resourceManager = new ResourceManager("Telerik.Windows.Controls.Strings", telerikAssembly);

		foreach (CultureInfo culture in supportedCultures)
		{
			ResourceSet resourceSet = resourceManager.GetResourceSet(culture, true, true);
			string languageTag = culture.IetfLanguageTag != defaultLanguageTag ? "." + culture.IetfLanguageTag.Substring(0, 2) : string.Empty;
			string resourceFileName = string.Format(newResourceFileNameFormat, languageTag);

			using (ResXResourceWriter resx = new ResXResourceWriter(resourceFileName))
			{
				foreach (DictionaryEntry res in resourceSet)
				{
					resx.AddResource(res.Key.ToString(), res.Value);
				}
			}
		}
	}
```

## See Also
* [Localization]({%slug common-localization%}) 