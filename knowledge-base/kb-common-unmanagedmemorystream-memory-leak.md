---
title: Release UnmanagedMemoryStream Resources 
description: Learn how to fix the issue of steady memory growth in RadGridView for WPF caused by font references leading to UnmanagedMemoryStream accumulation.
type: troubleshooting
page_title: UnmanagedMemoryStream Resources are not Released When Using Glyphs
slug: kb-common-unmanagedmemorystream-memory-leak
tags: wpf, memory leak, unmanaged memorystream, font reference, workaround
res_type: kb
ticketid: 1659703
---

## Environment

| Product | Telerik UI for WPF |
| --- | --- |
| Version | 2023.3.1010 |

## Description

`UnmanagedMemoryStream` objects are stacking up in memory and never released on refresh of Telerik controls. For example, when resetting the ItemsSource of RadGridView. The issues occurs in newer Telerik themes - Material and later.

This happens because of a [memory leak in WPF](https://stackoverflow.com/questions/31452443/wpf-textblock-memory-leak-when-using-font). In the Telerik's context this manifests when using the RadGlyph controls, which registers the custom Telerik font (TelerikWebUI) which holds the glyph icons.

## Solution

To prevent the memory leak, unregister the TelerikWebUI font using the RadGlyph API and then re-register again in the App class. Make sure to use the absolute path to the .ttf file when registering the font. 

#### __[C#]__
{{region kb-common-unmanagedmemorystream-memory-leak-0}}
	public App() 
	{
		var glyphType = typeof(RadGlyph);
		var unregisterMethod = glyphType.GetMethod("UnregisterFont", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
		unregisterMethod.Invoke(null, new object[1] { "TelerikWebUI" });

		ParserContext parserContext = new ParserContext();
		parserContext.XmlnsDictionary.Add("", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
		parserContext.XmlnsDictionary.Add("x", "http://schemas.microsoft.com/winfx/2006/xaml");
		string processDirPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
		string projectRootDir = System.IO.Path.GetFullPath(processDirPath + @"\..\..\..");
		var telerikFontString = string.Format("<FontFamily>{0}\\TelerikWebUI.ttf#TelerikWebUI</FontFamily>", projectRootDir);
		var telerikFont = (FontFamily)System.Windows.Markup.XamlReader.Parse(telerikFontString, parserContext);
		RadGlyph.RegisterFont(telerikFont, "TelerikWebUI");
	}
{{endregion}}

The TelerikWebUI.ttf file can be found in the Telerik UI for WPF source code that can download from the product page. The file is under the following directory:

__\Core\Controls\Themes\Fonts\old\TelerikWebUI.ttf__
