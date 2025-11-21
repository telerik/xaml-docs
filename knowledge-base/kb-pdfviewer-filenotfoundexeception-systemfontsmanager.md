---
title: FileNotFoundException Thrown in RadPdfViewer when PDF Document gets Loaded
description: Resolving an error shown when the Telerik UI for WPF PDF Viewer an assembly used in the SystemFontsManager class cannot be found .
type: troubleshooting
page_title: System.Drawing.Common Assembly not Found Error When the Telerik WPF PdfViewer is Displayed
meta_title: FileNotFoundException When the Telerik WPF PdfViewer is Arranged
slug: kb-pdfviewer-filenotfoundexeception-systemfontsmanager
tags: pdfviewer, ui for wpf, exception, systemfontsmanager, wpf publishing, self-contained
res_type: kb
ticketid: 1704306
---

## Environment 
<table>
<tbody>
<tr>
<td> Product </td>
<td> RadPdfViewer for WPF </td>
</tr>
<tr>
<td> Version </td>
<td> 2025.4.1111 </td>
</tr>
</tbody>
</table>

## Description

`FileNotFoundException` is thrown when a document is loaded in RadPdfViewer (often at startup of the app). The error occurs only with some documents and only when the application is published as `self-contained` app. It doesn't occur during debug or release configurations, until the app is published.

The file that cannot be found is the `System.Drawing.Common.dll` which is used in the `Telerik.Windows.Documents.Core.Fonts.SystemFontsManager.IsMonospaced` static method.

The exception trace is the following:

```stacktrace
 at Telerik.Windows.Documents.Core.Fonts.SystemFontsManager.IsMonospaced(String fontFamily)
   at Telerik.Windows.Documents.Core.Fonts.FontProperties..ctor(FontFamily fontFamily, FontStyle fontStyle, FontWeight fontWeight)
   at Telerik.Windows.Documents.Fixed.Utilities.Rendering.TextRenderingContext..ctor(TextFragment textFragment, Rect currentContainerBounds, IContentRenderingContext parentContext)
   at Telerik.Windows.Documents.Fixed.Utilities.Rendering.Helpers.TextRenderingHelper.RenderTextFragment(IFixedContentRenderer renderer, TextFragment textFragment, Rect currentContainerBounds, ITextPropertiesOwner textProperties, IContentRenderingContext parentContext)
   at Telerik.Windows.Documents.Fixed.Utilities.Rendering.ContentRootRenderingHelper.RenderContentElement(IFixedContentRenderer renderer, Rect viewport, ContentElementBase element, IContentRenderingContext parentContext)
   at Telerik.Windows.Documents.Fixed.Utilities.Rendering.ContentRootRenderingHelper.RenderContentElementHierarchy(IFixedContentRenderer renderer, Rect viewport, ContentElementsGraph contentElementsGraph, ContentElementBase parent, IContentRenderingContext parentContext)
   at Telerik.Windows.Documents.Fixed.Utilities.Rendering.ContentRootRenderingHelper.RenderContentElements(IFixedContentRenderer renderer, Rect viewport, IContentRootElement element, Rect elementBounds, IContentRenderingContext parentContext)
   at Telerik.Windows.Documents.Fixed.Utilities.Rendering.FixedPageContentRenderingHelper.RenderContentElements(IFixedContentRenderer renderer, Rect viewport)
   at Telerik.Windows.Documents.Fixed.UI.ParallelContentElementsPainter.DrawContentElements(Rect lastViewport)
   at Telerik.Windows.Documents.Fixed.UI.ContentElementsCanvas.PrepareVisuals(Int32 pageNumber)
   at Telerik.Windows.Documents.Fixed.UI.ContentElementsCanvas.RenderAsync(Int32 pageNumber)
   at Telerik.Windows.Documents.Fixed.UI.ContentElementsCanvas.RenderAsync()
   at Telerik.Windows.Documents.Fixed.UI.ContentElementsCanvas.OnRender(DrawingContext dc)
```
## Solution

This happens because the `System.Drawing.Common.dll` is not automatically copied to the `\publish` folder by the Visual Studio tooling. 

To work this around, you can add a framework reference that points to `Microsoft.WindowsDesktop.App` in the `.csproj` file of the project.

 ```xml
    <ItemGroup>
        <FrameworkReference Include="Microsoft.WindowsDesktop.App" />
    </ItemGroup>
```
