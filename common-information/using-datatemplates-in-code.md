---
title: Using DataTemplate in Code
page_title: Using DataTemplate in Code
description: This article shows how to get or create a DataTemplate in code using few different approaches.
slug: using-datatemplate-in-code
tags: xamlreader,parse,datatemplate,resources
position: 14
---

# Using DataTemplate in Code

This article shows how to get or create a DataTemplate in code using few different approaches.

## Defining the Template in XAML

The most conveninent approach is to define the DataTemplate in XAML and get it in code when needed.

__Example 1: Defining the DataTemplate in XAML__
```XAML
	<UserControl.Resources>
		<DataTemplate x:Key="MyDataTemplate">
			<TextBlock Text="{Binding MyProperty}" />
		</DataTemplate>
	</UserControl.Resources>
```

__Example 2: Getting the DataTemplate in code__
```C#
	public partial class MyUserControl : UserControl
	{
		public MyUserControl()
		{
			InitializeComponent();
			
			DataTemplate template = (DataTemplate)this.Resources["MyDataTemplate"];
		}
	}
```

## Defining the Template in Code as a String

If you don't have access to XAML you can define the DataTemplate as a string and use the [XamlReader.Parse](https://docs.microsoft.com/en-us/dotnet/api/system.windows.markup.xamlreader.parse?view=netframework-4.7.2) static method to parse the string to a DataTemplate object. 

> When using this approach you need to add all the namespaces required by the elements in the DataTemplate manually in the string or the parser context.

__Example 3: Parsing a string containing a DataTemplate__
```C#
	var dataTemplateString = 
		@"<DataTemplate>" +
			@"<StackPanel>" +
				@"<telerik:RadButton Content=""Button Content"" />" +
				@"<TextBlock Text=""{Binding }"" />" +
				@"<local:MyCustomControl />" +
			@"</StackPanel>" +
		@"</DataTemplate>";

	ParserContext parserContext = new ParserContext();

	// This namespace is required for all the default elements that don't require a prefix, like DataTemplate, TextBlock, StackPanel, etc.
	parserContext.XmlnsDictionary.Add("", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
	// This is the telerik namespace required by the RadButton in this case.
	parserContext.XmlnsDictionary.Add("telerik", "http://schemas.telerik.com/2008/xaml/presentation");
	// This is a local namespace pointing to a namespace from your application. The same approach is used for any other namespaces.
	parserContext.XmlnsDictionary.Add("local", "clr-namespace:MyNamespace;assembly=MyAssemblyName");

	DataTemplate template = (DataTemplate)XamlReader.Parse(dataTemplateString, parserContext);
```

## Using FrameworkElementFactory 

Creating a DataTemplate in code is not as simple as creating a visual element, like аn heir of UIelement for example. To do so you will need to use the __FrameworkElementFactory__ class. As this is the least recommended approach for creating a DataTemplate in code there won't be example for it. But, if you need to use it check the [FrameworkElementFactory](https://docs.microsoft.com/en-us/dotnet/api/system.windows.frameworkelementfactory?view=netframework-4.7.2) documentation in MSDN.

## See Also 
* [Introduction]({%slug introduction%})
* [Getting Started with XAML]({%slug common-faq%})
