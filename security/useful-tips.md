---
title: Useful Tips
page_title: Useful Tips
description: "Learn Telerik's best security practices, vulnerability reporting, and control-specific security guidelines, and useful tips."
slug: security-tips
tags: telerik, security, wpf, redistributing, report, tips, useful, vulnerability
published: True
position: 1
---

# Useful Security Tips

In this article, you will find helpful security tips and resources to strengthen the protection of your WPF app that uses Telerik UI for WPF controls.

## Control-Specific Security Guidelines

### RichTextBox

* __Unsafe Deserialization__: This type of vulnerability arises when untrusted data is used to abuse the logic of an application’s deserialization process, allowing an attacker to execute code, manipulate objects, or perform injection attacks. 

	In the context of RichTextBox, prior to 2024 Q3 SP1 (2024.3.924), such attack could occur when importing documents from HTML or XAML formats. The content of the document can be modified by the attacker to include malicious types that can be loaded during the deserialization process. The malicious type could execute a command on the machine where the document is loaded.
	
	To prevent unsafe serialization attacks, the [XAML]({%slug radrichtextbox-import-export-using-xamlformatprovider%}) and [HTML]({%slug radrichtextbox-import-export-html-htmlformatprovider%}) format providers (used to import the document) now force the developer to provide a list of trusted assemblies and types. If the deserialization logic reaches a type that is untrusted, the process is cancelled and an exception is thrown. Read more about the required setup for trusted types in the [XAML Verification]({%slug radrichtextbox-import-export-xaml-verification%}) article.

* __Command Injection__: This type of vulnerability targets the execution of commands on the host operating system via the vulnerable application.

	In the context of RichTextBox, prior to 2024 Q3 SP1 (2024.3.924), such attack could occur through the URIs of hyperlinks in the loaded document. The hyperlink address could point to a file on the file system, which can start an malicious process, which will start from the hyperlink click action.
	
	With 2024 Q3 SP1 (2024.3.924) of Telerik UI for WPF, all hyperlink URIs are validated. Additional measures can be taken by the developer by handling the `HyperlinkClicked` event. Read more about this in the [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%}#handling-the-hyperlink-click-navigation) article.

### PdfViewer

* __Command Injection__: This type of vulnerability targets the execution of commands on the host operating system via the vulnerable application.

	In the context of PdfViewer, prior to 2024 Q3 SP1 (2024.3.924), such attack could occur through the URIs of hyperlink annotations in the loaded document. The hyperlink address could point to a file on the file system, which can start a malicious process, which will start from the hyperlink click action.
	
	With 2024 Q3 (2024.3.924) version of Telerik UI for WPF, all hyperlink URIs are validated. Additional measures can be taken by the developer by handling the `HyperlinkClicked` or `AnnotationClicked` event. Read more about this in the [Annotations]({%slug radpdfviewer-document-model-annotations%}#handling-the-hyperlink-click-navigation) article.

### Spreadsheet

* __Command Injection__: This type of vulnerability targets the execution of commands on the host operating system via the vulnerable application.

	In the context of Spreadsheet, prior to 2024 Q3 SP1 (2024.3.924), such attack could occur through the URIs of hyperlinks in the imported workbook. The hyperlink address could point to a file on the file system, which can start an malicious process, which will start from the hyperlink click action.
	
	With 2024 Q3 (2024.3.924) version of Telerik UI for WPF, all hyperlink URIs are validated. Additional measures can be taken by the developer by handling the `HyperlinkClicked` event. Read more about this in the [Events]({%slug radspreadsheet-events%}#radworksheeteditor-events) article.

### PersistenceFramework

* __Unsafe Deserialization__: This type of vulnerability arises when untrusted data is used to abuse the logic of an application’s deserialization process, allowing an attacker to execute code, manipulate objects, or perform injection attacks. 

	In the context of PersistenceFramework, prior to 2024 Q4 SP1, such attack could occur during the deserialization of the previously saved layout (in XML format). The content of the XAML can be modified by the attacker to include malicious types that can be loaded during the deserialization process. The malicious type could execute a command on the machine where the document is loaded.
	
	To prevent unsafe serialization attacks, the PersistenceFramework forces the developer to provide a list of trusted types. If the deserialization logic reaches a type that is untrusted, the process is cancelled and an exception is thrown. Read more about the required setup for trusted types in the [Allowed Types]({%slug persistence-framework-allowed-types%}) article.

### Diagram

* __Unsafe Deserialization__: This type of vulnerability arises when untrusted data is used to abuse the logic of an application’s deserialization process, allowing an attacker to execute code, manipulate objects, or perform injection attacks. 

	In the context of Diagram, prior to 2024 Q3 SP1 (2024.3.924), such attack could occur during the deserialization of the previously [saved layout]({%slug raddiagrams-features-serialization%}) (in XML format). The content of the XAML can be modified by the attacker to include malicious types that can be loaded during the deserialization process. The malicious type could execute a command on the machine where the document is loaded.
	
	To prevent unsafe serialization attacks, the diagram forces the developer to provide a list of trusted types. If the deserialization logic reaches a type that is untrusted, the process is cancelled and an exception is thrown. Read more about the required setup for trusted types in the [Serialization]({%slug raddiagrams-features-serialization%}#allowing-safe-types-and-assemblies) article.

## Additional Resources

* __Security FAQ__: For more answers to common security-related questions, visit the [Security FAQ]({%slug security-faq%}) article.
* __Upgrade Recommendations__: Regularly updating to the latest version of Telerik UI for WPF is one of the best ways to ensure security. You can find the information on the installation approaches in the [corresponding section in the documentation]({%slug installation-installing-which-file-do-i-need%}).
