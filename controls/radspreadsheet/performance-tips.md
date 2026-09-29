---
title: Performance Tips
page_title: Performance Tips
description: Check our &quot;Performance Tips&quot; documentation article for the RadSpreadsheet WPF control.
components: ["spreadsheet"]
slug: spreadsheet-performance-tips
tags: ui,performance,tips,tricks
published: True
position: 11
---

# Performance Tips

The RadSpreadsheet control is optimized to bring a great performance, but this can be improved even further by keeping in mind the following tips and tricks.

* __RadSpreadsheet__ supports __UI Virtualization__ (enabled by default), which enables it to process only the information that is loaded in the viewable area. In this way, UI elements are created only for the parts of the document actually shown on screen, reducing the memory footprint of the application and speeding up the loading time. Avoid placing RadSpreadsheet in a container that measures it with infinity (for example, __ScrollViewer__, __StackPanel__, or a __Grid__ with a row/column set to `Auto`), because in that case RadSpreadsheet cannot determine what part of the document is shown in the viewport and virtualization turns off.

* The  RadSpreadsheet control uses the document model of [RadSpreadProcesing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview). Check the [Performance Tips and Tricks](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/performance) article of the library to see how to optimize the document model.

* Use the [NoXaml]({%slug xaml-vs-noxaml%}) Telerik dlls. This will improve the initial loading performance. 

* The usability of the control can be improved also by preloading the view that will display the RadSpreadsheet. This won't boost the general performance, but will move the WPF resources loading behavior before the view is displayed, thus improving the later interactions with the application. To preload the control, you should add it (but hidden) to the visual tree of the application at some point around startup. The exact place will depend on the specific application setup. The [following KB article]({%slug kb-spreadsheet-preload-resources%}) shows one way to do this.

* If using [RadSpreadsheetRibbon]({%slug radspreadsheet-getting-started-spreadsheet-ui%}), remove the tabs or other elements that are not necessary in the application. To do this, you can use the [ChildrenOfType]({%slug common-visual-tree-helpers%}) extension method, or you can [modify the ControlTemplate]({%slug styling-apperance-editing-control-templates%}) of RadSpreadsheetRibbon.

	__Using the ChildrenOfType method to remove the first tab from the ribbon control__
	<snippet id='radspreadsheet-performance-tips-block_1-cs' />

* If using [RadSpreadsheetRibbon]({%slug radspreadsheet-getting-started-spreadsheet-ui%}), set its `IsMinimized` property to `true`.
	
	__Minimizing the ribbon control__
	<snippet id='radspreadsheet-performance-tips-block_2-xaml' />

* Use .NET 8 or later, instead of .NET Framework, because the general WPF performance there is improved.

## See Also  

* [Visual Structure]({%slug radspreadsheet-visual-structure%})
* [Working with UI Selection]({%slug radspreadsheet-ui-working-with-selection%})