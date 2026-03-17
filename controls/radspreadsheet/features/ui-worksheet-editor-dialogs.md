---
title: Worksheet Editor Dialogs
page_title: Worksheet Editor Dialogs
description: Check our &quot;Worksheet Editor Dialogs&quot; documentation article for the RadSpreadsheet WPF control.
slug: radspreadsheet-worksheet-editor-dialogs
tags: worksheet,dialogs
published: True
position: 15
---

# Worksheet Editor Dialogs

The `RadWorksheetEditor` class provides the `Dialog` property, which is of the type of `WorksheetEditorDialogs`. This class contains properties for each of the dialogs used in the `RadSpreadsheet` control.

The `WorksheetEditorDialogs` class contains the following properties:

* `HeaderFooterDialog`&mdash;Gets or sets the header/footer dialog. To set a custom header/footer dialog, extend the `HeaderFooterDialogContent` class.
* `FormatShapesDialog`&mdash;Gets or sets the format shapes dialog. To set a custom format shapes dialog, extend the `FormatShapesDialogContent` class.
* `SortingDialog`&mdash;Gets or sets the sorting dialog. To set a custom sorting dialog, extend the `SortingDialogContent` class.
* `TopFilterDialog`&mdash;Gets or sets the top10 filter dialog. To set a custom top10 filter dialog, extend the `TopFilterDialogContent` class.
* `CustomFilterDialog`&mdash;Gets or sets the custom filter dialog. To set a custom custom filter dialog, extend the `CustomFilterDialogContent` class.
* `CustomSortListsDialog`&mdash;Gets or sets the custom sort lists dialog. To set a custom custom sort lists dialog, extend the `CustomSortListsDialogContent` class.
* `DataValidationDialog`&mdash;Gets or sets the data validation dialog. To set a custom data validation dialog, extend the `DataValidationDialogContent` class.
* `AlertDialog`&mdash;Gets or sets the alert dialog. To set a custom alert dialog, extend the `AlertDialogContent` class.
* `ConfirmDialog`&mdash;Gets or sets the confirm dialog. To set a custom confirm dialog, extend the `ConfirmDialogContent` class.   
* `StopDialog`&mdash;Gets or sets the stop dialog. To set a custom stop dialog, extend the `StopDialogContent` class.
* `WarningDialog`&mdash;Gets or sets the warning dialog. To set a custom warning dialog, extend the `WarningDialogContent` class.
* `InformationDialog`&mdash;Gets or sets the information dialog. To set a custom information dialog, extend the `InformationDialogContent` class.
* `UnhideSheetDialog`&mdash;Gets or sets the unhide sheet dialog. To set a custom unhide sheet dialog, extend the `UnhideSheetDialogContent` class.
* `InsertChartDialog`&mdash;Gets or sets the insert chart dialog. To set a custom insert chart dialog, extend the `InsertChartDialogContent` class.
* `ManageConditionalFormattingDialog`&mdash;Gets or sets the manage conditional formatting dialog. To set a custom manage conditional formatting dialog, extend the `ManageConditionalFormattingDialogContent` class.
* `FormatFontDialog`&mdash;Gets or sets the Format Font dialog. To set a custom Format Font dialog, extend the `FormatFontDialogContent` class.
* `ConditionalFormattingDialog`&mdash;Gets or sets the new/edit conditional formatting dialog. To set a custom new/edit conditional formatting dialog, extend the `ConditionalFormattingDialogContent` class.
* `PageSetupDialog`&mdash;Gets or sets the page setup dialog. To set a custom page setup dialog, extend the `PageSetupDialogContent` class.
* `NameManagerDialog`&mdash;Gets or sets the name manager dialog. To set a custom name manager dialog, extend the `NameManagerDialogContent` class.
* `DecimalNumberPromptDialog`&mdash;Gets or sets the decimal number prompt dialog. To set a custom decimal number prompt dialog, extend the `DecimalNumberPromptDialogContent` class.
* `FormatCellsDialog`&mdash;Gets or sets the format cells dialog. To set a custom format cells dialog, extend the `FormatCellsDialogContent` class.
* `InsertCellsDialog`&mdash;Gets or sets the insert cells dialog. To set a custom insert cells dialog, extend the `InsertCellsDialogContent` class.
* `RemoveCellsDialog`&mdash;Gets or sets the remove cells dialog. To set a custom remove cells dialog, extend the `RemoveCellsDialogContent` class.
* `ScaleFactorDialog`&mdash;Gets or sets the scale factor dialog. To set a custom scale factor dialog, extend the `ScaleFactorDialogContent` class.
* `SelectColorDialog`&mdash;Gets or sets the select color dialog. To set a custom select color dialog, extend the `SelectColorDialogContent` class.
* `InsertFunctionDialog`&mdash;Gets or sets the insert function dialog. To set a custom insert function dialog, extend the `InsertFunctionDialogContent` class.
* `StyleDialog`&mdash;Gets or sets the style dialog. To set a custom style dialog, extend the `StyleDialogContent` class.
* `CreateNewThemeColorsDialog`&mdash;Gets or sets the create new theme colors dialog. To set a custom create new theme colors dialog, extend the `CreateNewThemeColorsDialogContent` class.
* `ProtectDialog`&mdash;Gets or sets the protect dialog. To set a custom protect dialog, extend the `ProtectDialogContent` class.
* `UnprotectDialog`&mdash;Gets or sets the unprotect dialog. To set a custom unprotect dialog, extend the `UnprotectDialogContent` class.
* `CreateNewThemeFontsDialog`&mdash;Gets or sets the create new theme fonts dialog. To set a custom create new theme fonts dialog, extend the `CreateNewThemeFontsDialogContent` class.
* `SeriesDialog`&mdash;Gets or sets the series dialog. To set a custom series dialog, extend the `SeriesDialogContent` class.
* `HyperlinkDialog`&mdash;Gets or sets the hyperlink dialog. To set a custom hyperlink dialog, extend the `HyperlinkDialogContent` class.
* `FindAndReplaceDialog`&mdash;Gets or sets the find and replace dialog. To set a custom find and replace dialog, extend the `FindAndReplaceDialogContent` class.
* `CreateUpdateSpreadsheetNameDialog`&mdash;Gets or sets the create update spreadsheet name dialog. To set a custom create update spreadsheet name dialog, extend the `CreateUpdateSpreadsheetNameDialogContent` class.
* `SimpleConditionalFormattingDialog`&mdash;Gets or sets the simple conditional formatting dialog. To set a custom simple conditional formatting dialog, extend the `SimpleConditionalFormattingDialogContent` class.

## Accessing the Dialogs

The RadSpreadsheet control provides the `ActiveWorksheetEditor` property that gives you access to the active worksheet editor. You can use this property to access the `Dialogs` property of the active worksheet editor and utilize the dialogs as needed.

__Accessing the Dialogs__
```C#
var findAndReplaceDialog = this.radSpreadsheet.ActiveWorksheetEditor.Dialogs.FindAndReplaceDialog;
```

## Customizing the Dialogs

You can customize the dialogs by creating a new class that inherits from the dialog that you want to customize and override the necessary methods to implement your custom logic.

The following example showcases how to customize one of the properties provided by the WorksheetEditorDialogs class. It showcases how to introduce a custom `FindAndReplaceDialogContent` type for the `FindAndReplaceDialog` property. In the example, the `OnKeyDown` method is overridden to add custom logic for handling the Escape and Enter keys.

__Extending the FindAndReplaceDialogContent__
```C#
public class CustomFindAndReplaceDialogContent : FindAndReplaceDialogContent
{
    public CustomFindAndReplaceDialogContent()
    {
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (e.Key == Key.Escape)
        {
            this.Close();
        }
        else if (e.Key == Key.Enter)
        {
            FindNextCommand.Execute(null);
        }
    }
}
```

__Setting the CustomFindAndReplaceDialogContent__
```C#
this.radSpreadsheet.ActiveWorksheetEditor.Dialogs.FindAndReplaceDialog = new CustomFindAndReplaceDialogContent();
```