---
title: Prompt Library
page_title: Telerik UI for WPF Prompt Library
description: Explore the collection of prompts that you can use with the Telerik UI for WPF AI Coding Assistant.
slug: ai-prompt-library
tags: telerik,wpf,ai,coding assistant,prompt,library
position: 30
---

# Telerik UI for WPF Prompt Library

Welcome to the Telerik UI for WPF Prompt Library.

The prompts provided here are intended and optimized for use with the Telerik UI for WPF AI Coding Assistant [MCP Server]({%slug ai-mcp-server%}). They can help you kick start your app development and speed up the component configuration process.

This collection of prompts is not exhaustive and the Telerik UI for WPF team is constantly working on adding more prompts to the library.

## How to Use the Prompts

All prompts in this library target the [MCP Server]({%slug ai-mcp-server%}) via the `#telerikwpf` handle. Make sure that you have installed and enabled the MCP Server before attempting to run the prompts.

1. Browse the prompt library to find a prompt that suits your needs.
2. Copy the prompt text (including the `#telerikwpf` handle).
3. (Optional) Customize the prompt as needed for your specific use case but keep the `#telerikwpf` handle.<br/>When modifying the prompts, make sure the changes comply with the [recommendations]({%slug ai-overview%}#recommendations) for the AI Coding Assistant.
4. Run the prompt against the [MCP Server]({%slug ai-mcp-server%}).

>warning Always double-check the code and solutions proposed by any AI-powered tool before applying them to your project.

>caption Use with the Copilot Extension

To run the provided prompts in the Telerik UI for WPF GitHub Copilot Extension (without the MCP Server installed), modify the prompts to use the `@telerikwpf` handle instead.

## Assembly-Specific Prompts

This section provides prompt ideas for the [currently supported assemblies]({%slug ai-overview%}#supported-assemblies).

### Controls Assembly

The __Telerik.Windows.Controls__ assembly exposes many components. One of them is the [Telerik UI for WPF RadListBox]({%slug radlistbox-overview%}) control, which allows you to display a list of items from which the user can choose.

<div style="display: grid; gap: 10px; grid-template-columns: 1fr 1fr;">

```prompt
#telerikwpf Add a RadListBox data bound to a collection of business objects. Each object should have Id and Name properties. Use the Name as the display value in each item.
```
```ts
```

```prompt
#telerikwpf Add a RadListBox for countries bound to 500 items in the view model. Sort the data by date founded property and group the data by continent. Apply styling to the countries.
```
```ts
```

```prompt
#telerikwpf Add an example with the RadListBox control bound to a collection of 200 items. The items should contain name, address, city and id. Preselect the second item and apply custom ui for the items. The UI should also include an image and a checkbox. 
```
```ts
```

</div>

### Input Assembly

The __Telerik.Windows.Controls.Input__ assembly exposes many input controls. One of them is the [Telerik UI for WPF RadComboBox]({%slug radcombobox-overview%}), which is a drop-down list component with a number of advanced features.

<div style="display: grid; gap: 10px; grid-template-columns: 1fr 1fr;">

```prompt
#telerikwpf Add RadComboBox data bound to a collection of business objects. Each object should have a Name, Address, City and Country property. Use the Name to display the items in the UI.
```
```ts
```

</div>

### GridView Assembly

The __Telerik.Windows.Controls.GridView__ assembly provides the [Telerik UI for WPF RadGridView]({%slug gridview-overview2%}) component, which enables you to create fully customizable and highly interactive interfaces for display and management of large data.

<div style="display: grid; gap: 10px; grid-template-columns: 1fr 1fr;">

```prompt
#telerikwpf Create a RadGridView with 100 records each having Id, Name and Company. Group the data by Company. Sort by name. Add aggregate count function for the company column.
```
```ts
```

```prompt
#telerikwpf Data bind the RadGridView control to a collection of items. Add columns for stocks data manually where one of the columns should use a combobox.
```
```ts
```

```prompt
#telerikwpf Create a RadGridView with 3 columns - Name, Country, City. Add the corresponding business object in the code behind and populate is with sample data. Add 20 entries to the data. How to automatically force the columns to fill the grid area?
```
```ts
```

```prompt
#telerikwpf Add custom controls in the cells of each RadGridView column. One of the column should have a context menu with options for adding, removing, deleting row.
```
```ts
```

```prompt
#telerikwpf Create a RadGridView with 3 columns - Name, Country, City. Add the corresponding business object in the code behind and populate is with sample data. Add 20 entries to the data. Add filter in RadGridView on load of the control. Filter by Name member. Show me how to preselect distinct values in the column filter of RadGridView.
```
```ts
```

</div>

### Docking Assembly

The __Telerik.Windows.Controls.Docking__ assembly provides the [Telerik UI for WPF RadDocking]({%slug raddocking-overview2%}), which you can use to introduce a docking system like the Microsoft Visual Studio.

The following prompt requests are follow-up ones that you can use to setup a RadDocking control instance.

<div style="display: grid; gap: 10px; grid-template-columns: 1fr 1fr;">

```prompt
#telerikwpf Create a basic RadDocking layout with two panes docked on the left, one on the right and two on the bottom of the control.
```
```ts
```

```prompt
#telerikwpf Save and load the RadDocking layout.
```
```ts
```

```prompt
#telerikwpf Prevent a RadDocking pane from floating.
```
```ts
```

</div>

### RichTextBox/Documents Assemblies

The __Telerik.Windows.Controls.RichTextBox__ and __Telerik.Windows.Documents__ assemblies allow you to use the [Telerik UI for WPF RadRichTextBox]({%slug radrichtextbox-overview%}) component depending on, in which framework version the control is used. It allows you to display and edit rich-text content.

<div style="display: grid; gap: 10px; grid-template-columns: 1fr 1fr;">

```prompt
#telerikwpf How to import and export different formats in the RadRichTextBox. Add toolbar items for import and export options.
```
```ts
```

</div>