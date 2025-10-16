---
title: Security Tips
page_title: Security Tips
description: "Learn Telerik's best security practices, vulnerability reporting, and control-specific security guidelines, and useful tips."
slug: security-tips
tags: telerik, security, wpf, redistributing, report, tips, useful, vulnerability
published: True
position: 1
---

# Security Tips

In this article, you will find helpful security tips and resources to strengthen the protection of your WPF app that uses Telerik UI for WPF controls.

## Safe Deserialization

Deserialization in the context of WPF often means that XML content gets parsed to CLR objects which are loaded in memory. This carries a security risk related to loading untrusted types, which can be used to abuse the logic of the application. An attacker could use this entry point to deserialize and load malicious content that executes a command on the OS.

Telerik components that support deserialization operations implement a safety method to allow loading only trusted types, thus improving the application security. This feature consists of creating a list of allowed CLR types that can be loaded during deserialization. If the deserialization process reaches a type that is not part of this list, an exception is thrown.

<br />  
__The following resources show which Telerik controls support safe deserialization and how to use it:__

* [Diagram - Serialization article]({%slug raddiagrams-features-serialization%}#allowing-safe-types-and-assemblies)

* [PersistenceFramework - Allowed Types article]({%slug persistence-framework-allowed-types%})

* [RichTextBox - XAML Verification article]({%slug radrichtextbox-import-export-xaml-verification%})

## Secure Hyperlink Clicks

In WPF hyperlink navigation actions can start a new process on the user machine. This can execute a malicious command untrusted by the user. Most of the time this can be controlled in the application's logic, where such addresses can be validated, thus mitigating the security risk. 

In cases when the hyperlink is loaded dynamically from an unknown source, like from a document loaded in Telerik PdfViewer or RichTexBox, the link may be insecure. For such scenarios the Telerik's document hyperlink components come with a built-in URI validation logic. If the hyperlink doesn't point to a valid address, the navigation won't work and a message box will be displayed. Additional to that, the Telerik document viewer components that support hyperlinks expose a `HyperlinkClicked` event that can be handled in order to further modify the click action, thus improving the security even more.

<br />  
__The following resources show how to use the `HyperlinkClicked` event in the corresponding controls:__

* [PdfViewer - Annotations article]({%slug radpdfviewer-document-model-annotations%})

* [RichTextBox - Hyperlink article]({%slug radrichtextbox-features-document-elements-hyperlink%}#handling-the-hyperlink-click-navigation)

* [Spreadsheet - Events article]({%slug radspreadsheet-events%}#radworksheeteditor-events)

## Additional Resources

* __Security FAQ__: For more answers to common security-related questions, visit the [Security FAQ]({%slug security-faq%}) article.
* __Upgrade Recommendations__: Regularly updating to the latest version of Telerik UI for WPF is one of the best ways to ensure security. You can find the information on the installation approaches in the [corresponding section in the documentation]({%slug installation-installing-which-file-do-i-need%}).

## See Also  
* [RadDiagram]({%slug raddiagram-overview%})
* [RadPdfViewer]({%slug radpdfviewer-overview%})
* [RadPersistenceFramework]({%slug persistence-framework-overview%})
* [RadRichTextBox]({%slug radrichtextbox-overview%})
* [RadSpreadsheet]({%slug radspreadsheet-overview%})
