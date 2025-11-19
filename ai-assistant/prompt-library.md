---
title: Prompt Library
page_title: Telerik UI for WPF Prompt Library
description: Explore the collection of prompts that you can use with the Telerik UI for WPF AI Coding Assistant.
slug: ai-prompt-library
tags: telerik,wpf,ai,coding assistant,prompt,library
position: 3
---

# Telerik UI for WPF Prompt Library

The prompts provided here are intended and optimized for use with the Telerik UI for WPF AI Coding Assistant [MCP Server]({%slug ai-mcp-server%}). They can help you kick start your app development and speed up the component configuration process.

This collection of prompts is not exhaustive and the Telerik UI for WPF team is constantly working on adding more prompts to the library.

## How to Use the Prompts

All prompts in this library target the [MCP Server]({%slug ai-mcp-server%}) via the `#telerikwpf` handle. Make sure that you have installed and enabled the MCP Server before attempting to run the prompts.

1. Browse the prompt library to find a prompt that suits your needs.
2. Copy the prompt text (including the `#telerikwpf` handle).
3. (Optional) Customize the prompt as needed for your specific use case but keep the `#telerikwpf` handle.<br/>When modifying the prompts, make sure the changes comply with the [recommendations]({%slug ai-overview%}#recommendations) for the AI Coding Assistant.
4. Run the prompt against the [MCP Server]({%slug ai-mcp-server%}).

>Always double-check the code and solutions proposed by any AI-powered tool before applying them to your project.

## Component Specific Prompts

This section provides prompt ideas for the [currently supported components]({%slug ai-overview%}#supported-components).

### ListBox

[RadListBox for WPF]({%slug radlistbox-overview%}) allows you to display a list of selectable items.

* `#telerikwpf Add a RadListBox data bound to a collection of business objects. Each object should have Id and Name properties. Use the Name as the display value in each item.`

* `#telerikwpf Add a RadListBox for countries bound to 500 items in the view model. Sort the data by date founded property and group the data by continent. Apply styling to the countries.`

* `#telerikwpf Add an example with the RadListBox control bound to a collection of 200 items. The items should contain name, address, city and id. Preselect the second item and apply custom ui for the items. The UI should also include an image and a checkbox.`

### GridView

[RadGridView for WPF]({%slug gridview-overview2%}) enables you to create fully customizable and highly interactive interfaces for display and management of large data.

* `#telerikwpf Create a RadGridView with 100 records each having Id, Name and Company. Group the data by Company. Sort by name. Add aggregate count function for the company column.`

* `#telerikwpf Data bind the RadGridView control to a collection of items. Add columns for stocks data manually where one of the columns should use a combobox.`

* `#telerikwpf Create a RadGridView with 3 columns - Name, Country, City. Add the corresponding business object in the code behind and populate is with sample data. Add 20 entries to the data. How to automatically force the columns to fill the grid area?`

* `#telerikwpf Add custom controls in the cells of each RadGridView column. One of the column should have a context menu with options for adding, removing, deleting row.`

* `#telerikwpf Create a RadGridView with 3 columns - Name, Country, City. Add the corresponding business object in the code behind and populate is with sample data. Add 20 entries to the data. Add filter in RadGridView on load of the control. Filter by Name member. Show me how to preselect distinct values in the column filter of RadGridView.`

### Docking

[RadDocking for WPF]({%slug raddocking-overview2%}) can be used to introduce a docking system similar to the panes layout in Microsoft Visual Studio.

* `#telerikwpf Create a basic RadDocking layout with two panes docked on the left, one on the right and two on the bottom of the control.`

* `#telerikwpf Save and load the RadDocking layout.`

* `#telerikwpf Prevent a RadDocking pane from floating.`

### RichTextBox 

[RadRichTextBox for WPF]({%slug radrichtextbox-overview%}) allows you to display and edit rich-text documents.

* `#telerikwpf Define a text editor using RadRichTextBox and load document. Add RadRichTextBox toolbar or a ribbon with button settings for the editor (formatting, open/save document, insert images, etc).`

* `#telerikwpf How to import and export different formats in the RadRichTextBox. Add toolbar items for import and export options.`

### ComboxBox

[RadComboBox for WPF]({%slug radcombobox-overview%}) is a drop-down list component with a number of advanced features.

* `#telerikwpf Add RadComboBox data bound to a collection of business objects. Each object should have a Name, Address, City and Country property. Use the Name to display the items in the UI.`

* `#telerikwpf Define RadComboBox with its ItemsSource set to collection of custom CLR objects. Each object should have a Name, Address, City and Country property. Use the Name to display the items in the UI. Show all of the properties in the drop down and allow multipe selection.`
