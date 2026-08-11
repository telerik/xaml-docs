---
title: Styles and Templates
page_title: Styles and Templates
description: Check our &quot;Styles and Templates&quot; documentation article for the RadFileDialogs {{ site.framework_name }} control.
slug: radfiledialogs-styles-and-templates
tags: styles,templates
published: True
position: 8
---

# Styles and Templates

This article is intended to give you a general understanding of how to change the visual appearance of the file dialogs and their elements. There is also comprehensive information about their control templates.

Using [implicit styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to style the controls per your liking. You can also follow [this article]({%slug styling-apperance-editing-control-templates%}) for two different approaches on how to extract and edit control templates.
        
>tip Note that when changing a __ControlTemplate__ you should include all required parts. Even if your code compiles, some of the functionality may be impacted due to the omission of the required parts. The required parts are usually marked with the prefix "__PART___".

## Template Structure

Here is the template structure for each of the dialogs:

* **OpenFileDialogControl**, **SaveFileDialogControl**, **OpenFolderDialogControl**: The controls holding the **ExplorerControl** and the operations pane. All controls inherit the appearance from **DialogWindowBase**.

* **ExplorerControl**: It holds all other elements apart from the operations pane and the dialog's header.

* **HistoryNavigationPaneControl**: Holds the controls used to navigate through the browse history. It consists of two **RadPathButtons** for navigating back and forward a **RadDropDownButton** which displays the history and another **RadPathButton** used to navigate up one directory.

* **FileDialogsBreadcrumb**: The control which handles the path navigation. It inherits its visual appearance from **RadBreadcrumb**.

* **FileDialogSearchPane**: The control used for executing search queries. Consists of a **RadWatermarkTextBox**, search icon and a clear **RadButon**.

* **FileBrowserTabControl**: Used for displaying all files and/or folders in the current directory after the search filters (if any) have been applied. Either a **FileBrowserListBox** or a **FileBrowserGridView** is displayed based on the selected layout in the layout configurator combobox - through its **ContentTemplateSelector**.

## Styling the Controls

To modify the appearance of each of the individual elements, you should first create an appropriate style targeting the specific control. You can then customize it by setting the available visual properties or modify its control template altogether.

**Example 1** demonstrates how to add a Favorites title to the **Custom Places Pane**.

#### [XAML] Example 1: Add title to the Custom Places Pane

<snippet id='radfiledialogs-styles-and-templates-block_1-xaml' />


>tip If you're using [the NoXaml binaries]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __ExplorerControlStyle__.

> Note that we've added a new **RowDefinition** to the **PART&#95;TreeNavigationPane** and modified the Grid.Row attached properties of the **PART&#95;MainNavigationPane** and **PART&#95;CustomPlacesPane** elements. Additionally, we've defined the following namespaces:
* **xmlns:fileDialogs="clr-namespace:Telerik.Windows.Controls.FileDialogs;assembly=Telerik.Windows.Controls.FileDialogs"**
* **xmlns:telerik1="clr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls"**
* **xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"**

**Figure 1** displays the resulting dialog:

#### Figure 1: RadOpenFileDialog with modified Custom Places Pane

![RadOpenFileDialog with modified Custom Places Pane](images/FileDialogs_Modified_CustomPlacesPane.png)

## See Also

* [Visual Structure]({%slug radfiledialogs-visual-structure%})
* [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
* [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})