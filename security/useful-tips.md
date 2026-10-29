---
title: Security Tips
page_title: Security Tips
description: "Learn Telerik's best security practices, vulnerability reporting, and control-specific security guidelines, and useful tips."
components: ["general"]
slug: security-tips
tags: telerik, security, wpf, redistributing, report, tips, useful, vulnerability
published: True
position: 1
---

# Security Tips

In this article, you will find helpful security tips and resources to strengthen the protection of your Windows Presentation Foundation (WPF) app that uses Telerik UI for WPF controls.

## Safe Deserialization

Deserialization in WPF often means parsing Extensible Markup Language (XML) content into Common Language Runtime (CLR) objects and loading them into memory. Loading untrusted types carries a security risk because attackers can use them to abuse application logic. An attacker could use this entry point to load malicious content that executes a command on the operating system (OS).

Telerik components that support deserialization operations implement a safety method to allow loading only trusted types, thus improving the application security. This feature consists of creating a list of allowed CLR types that can be loaded during deserialization. If the deserialization process reaches a type that is not part of this list, an exception is thrown.

The following resources show which Telerik controls support safe deserialization and how to use it:

* [Diagram - Serialization article]({%slug raddiagrams-features-serialization%}#allowing-safe-types-and-assemblies)

* [PersistenceFramework - Allowed Types article]({%slug persistence-framework-allowed-types%})

* [RichTextBox - Extensible Application Markup Language (XAML) Verification article]({%slug radrichtextbox-import-export-xaml-verification%})

## Secure Hyperlink Clicks

In WPF hyperlink navigation actions can start a new process on the user machine. This can execute a malicious command untrusted by the user. Most of the time this can be controlled in the application's logic, where such addresses can be validated, thus mitigating the security risk. 

A hyperlink loaded dynamically from an unknown source may be insecure, such as a link in a document loaded in Telerik PdfViewer or RichTextBox. For these scenarios, Telerik's document hyperlink components include built-in Uniform Resource Identifier (URI) validation. If the hyperlink doesn't point to a valid address, navigation won't work and a message box will be displayed. Telerik document viewer components that support hyperlinks also expose a `HyperlinkClicked` event. Handle this event to further modify the click action and improve security.

The following resources show how to use the `HyperlinkClicked` event in the corresponding controls:

* [PdfViewer - Annotations article]({%slug radpdfviewer-document-model-annotations%})

* [RichTextBox - Hyperlink article]({%slug radrichtextbox-features-document-elements-hyperlink%}#handling-the-hyperlink-click-navigation)

* [Spreadsheet - Events article]({%slug radspreadsheet-events%}#radworksheeteditor-events)

## Additional Resources

* __Security Frequently Asked Questions (FAQ)__: For more answers to common security-related questions, visit the [Security FAQ]({%slug security-faq%}) article.
* __Upgrade Recommendations__: Regularly updating to the latest version of Telerik UI for WPF is one of the best ways to ensure security. See the [Telerik UI for WPF installation guide]({%slug installation-guide%}) for installation approaches.

## See Also  
* [RadDiagram]({%slug raddiagram-overview%})
* [RadPdfViewer]({%slug radpdfviewer-overview%})
* [RadPersistenceFramework]({%slug persistence-framework-overview%})
* [RadRichTextBox]({%slug radrichtextbox-overview%})
* [RadSpreadsheet]({%slug radspreadsheet-overview%})
