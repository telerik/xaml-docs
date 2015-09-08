---
title: Settings
page_title: Settings
description: Settings
slug: radpdfprocessing-formats-and-conversion-plain-text-settings
tags: using,textformatprovider, settings
published: True
position: 2
---


# Settings

TextFormatProvider allows for export of RadFixedDocument to txt. Additionally, the export settings provide modification options. The current article outlines the available settings.

Through the __TextFormatProviderSettings__ class you could specify the following:

The export settings which you can specify are as follows:

* **LinesSeparator**: Determines the string used to separate the lines in the document. The default value is __Environment.NewLine__.


* **PagesSeparator**: Determines the string, which will be used to separate the pages in the document. The default value is __*"----------- Page{0} ------------"*__.


## Create TextFormatProviderSettings

The constructor of the **TextFormatProviderSettings** class has two overloads:

* **TextFormatProviderSettings()**: Initializes a new instance of the class and sets the default values for its properties.

* **TextFormatProviderSettings(string linesSeparator, string pagesSeparator)**: Initializes a new instance of the class and sets the specified values for its properties.

**Example 1** shows how to create and specify particular setting.

#### **[C#] Example 1: Create TextFormatProviderSettings**
{{region radpdfprocessing-formats-and-conversion-plain-text-settings_0}}

	TextFormatProviderSettings settings = new TextFormatProviderSettings("/r/n","*Page {0}*");
{{endregion}}


## Using TextFormatProviderSettings

The Export() method of **TextFormatProvider** allows you to pass a **TextFormatProviderSettings** instance. In **Example 2** is illustrated how to apply the settings, created in **Example 1**, when exporting a **RadFixedDocument** to string.


#### **[C#] Example 2: Apply TextFormatProviderSettings**

{{region radpdfprocessing-formats-and-conversion-plain-text-settings_1}}

	RadFixedDocument document = CreateRadFixedDocument();

    TextFormatProvider provider = new TextFormatProvider();
    string text = provider.Export(document, settings);
{{endregion}}


# See Also

* [Using TextFormatProvider]({%slug radpdfprocessing-formats-and-conversion-plain-text-textformatprovider%})