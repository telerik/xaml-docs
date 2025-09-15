---
title: Sheet Selector
page_title: Sheet (Page) Selector
description: Check our &quot;Sheet Selector&quot; documentation article for the RadSpreadsheet WPF control.
slug: radspreadsheet-sheet-selector
tags: selector,sheet, pages
published: True
position: 11
---

# Sheet Selector

The [sheet selector]({%slug radspreadsheet-visual-structure%}#radspreadsheet-visual-structure) is a pager displayed under the spreadsheet document that allows you to switch between the different [worksheets]({%slug radspreadsheet-model%}).

The sheet selector is represented by the `RadSpreadsheetSheetSelector` control, which is integrated in the ControlTemplate of the `RadSpreadsheet`. This article describes how to access and customize the selector.

![A picture showing the WPF RadSpreadsheet with its RadSpreadsheetSheetSelector](images/radspreadsheet-sheet-selector-overview.png)

The `RadSpreadsheetSheetSelector` control is located in the `Telerik.Windows.Controls.Spreadsheet.Controls` namespace. To access it in XAML, use the following namespace: `xmlns:spreadsheetControls="clr-namespace:Telerik.Windows.Controls.Spreadsheet.Controls;assembly=Telerik.Windows.Controls.Spreadsheet" `

## Hiding the Sheet Selector

By default the sheet selector component is displayed. To hide it, set the `RadSpreadsheetSheetSelector.IsSheetSelectorVisible` [attached property](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/properties/attached-properties-overview?view=netdesktop-9.0) on the `RadSpreadsheet` control to `false`.

__Setting the IsSheetSelectorVisible property__
```XAML
	<telerik:RadSpreadsheet spreadsheetControls:RadSpreadsheetSheetSelector.IsSheetSelectorVisible="False"/>
```

__RadSpreadsheet with hidden sheet selector__  

![A picture showing WPF RadSpreadsheet with hidden sheet selector](images/radspreadsheet-sheet-selector-hidden-selector.png)

## Hiding the Add Sheet Button

By default the sheet selector has a button displayed next to the worksheeet tabs that allows to add new worksheets in the document. To hide the button, set the `RadSpreadsheetSheetSelector.IsAddButtonVisible` [attached property](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/properties/attached-properties-overview?view=netdesktop-9.0) on the `RadSpreadsheet` control to `false`.

__Setting the IsAddButtonVisible property__
```XAML
	<telerik:RadSpreadsheet spreadsheetControls:RadSpreadsheetSheetSelector.IsAddButtonVisible="False"/>
```

__RadSpreadsheet with hidden add button__  

![A picture showing WPF RadSpreadsheetSheetSelector with hidden add button](images/radspreadsheet-sheet-selector-hidden-add-button.png)

## Using the Tabs Context Menu

The worksheet tabs in the `RadSpreadsheetSheetSelector` have a built-in context menu which allows you to apply few different settings on the tab - rename, insert, delete, hide, etc.

__Sheet selector's context menu__  

![A picture showing WPF RadSpreadsheetSheetSelector's context menu](images/radspreadsheet-sheet-selector-context-menu.png)

The context menu can be modified or accessed via the `SheetSelectorContextMenu` property of `RadSpreadsheet`.

__Customizing the existing context menu__
```C#
	private void RadSpreadsheet_Loaded(object sender, RoutedEventArgs e)
	{
		var spreadsheet = (RadSpreadsheet)sender;
		
		// remove the last two options
		spreadsheet.SheetSelectorContextMenu.Items.RemoveAt(spreadsheet.SheetSelectorContextMenu.Items.Count - 1);
		spreadsheet.SheetSelectorContextMenu.Items.RemoveAt(spreadsheet.SheetSelectorContextMenu.Items.Count - 1);

		// add a new option
		var newMenuItem = new RadMenuItem();
		newMenuItem.Header = "My option";
		newMenuItem.Click += (s, args) =>
		{
			// implement the click logic here
		};
		spreadsheet.SheetSelectorContextMenu.Items.Add(newMenuItem);
	}
```

__Replacing the context menu__
```XAML
	<telerik:RadSpreadsheet>
		<telerik:RadSpreadsheet.SheetSelectorContextMenu>
			<telerik:RadContextMenu>
				<telerik:RadMenuItem Header="Option A" Click="OnOptionAClick"/>
				<telerik:RadMenuItem Header="Option B" Click="OnOptionBClick"/>
			</telerik:RadContextMenu>
		</telerik:RadSpreadsheet.SheetSelectorContextMenu>
	</telerik:RadSpreadsheet>
```

Additional to that, the menu can be accessed with the `GetContextMenu` and `SetContextMenu` methods of `RadSpreadsheetSheetSelector`.

__Using the GetContextMenu and SetContextMenu methods__
```C#
	private void RadSpreadsheet_Loaded(object sender, RoutedEventArgs e)
	{
		var spreadsheet = (RadSpreadsheet)sender;
		var sheetSelector = spreadsheet.FindChildByType<RadSpreadsheetSheetSelector>();

		// getting the menu
		RadContextMenu contextMenu = sheetSelector.GetContextMenu();

		// setting the menu
		sheetSelector.SetContextMenu(newRadContextMenuInstance);
	}
```