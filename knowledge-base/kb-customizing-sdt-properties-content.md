---
title: Customizing the Document Content of Sdt Element in RadRichTextBox
description: Learn how to create a custom content for a content controls (structured document tags) in RadRichTextBox.
type: how-to
page_title: Creating Custom Sdt Properties in RichTextBox for WPF
meta_title: Implementing Custom RadDocument Content for Sdt Properties Element
slug: kb-customizing-sdt-properties-content
tags: radrichtextbox,content-controls,styling,visual-issues,font-synchronization
res_type: kb
ticketid: 1711196
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadRichTextBox for UI for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2026.1.211</td>
</tr>
</tbody>
</table>

## Description

How to customize or replace the document content of a content control ([structured document tag]({%slug radrichtextbox-features-content-controls%})) in RadRichTextBox for WPF.

## Solution

To replace or customize the default DocumentFragment that is created for a Sdt element (like `DateProperties` or `CheckBoxProperties`), the content builder of the associated SdtProperties class can be overridden. To do this, override the `GetBuilder` method of the properties class. Then. you can create a custom `SdtContentGenerator` and use it in the `GetBuilder` method override.

```C#
  public class CustomDateProperties : DateProperties
  {
      protected override ISdtBuilder GetBuilder(SdtRangeStart associatedSdt)
      {
          var builder = base.GetBuilder(associatedSdt);
          typeof(SdtDateBuilder)
              .GetField("contentGenerator", BindingFlags.NonPublic | BindingFlags.Instance)
              .SetValue(builder, new CustomSdtDateContentGenerator(this));
          return builder;
      }
  }

  public class CustomSdtDateContentGenerator : SdtDateContentGenerator
  {
      public CustomSdtDateContentGenerator(DateProperties properties) : base(properties)
      {
      }

      public override DocumentFragment GetContentFragmentOverride()
      {
          var fragment = base.GetContentFragmentOverride();
          var span = fragment.EnumerateChildrenOfType<Span>().FirstOrDefault();
          if (span != null)
          {
               //adjust the span font settings
          }
          return fragment;
      }
  }
```

