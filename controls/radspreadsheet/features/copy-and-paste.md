---
title: Copy and Paste
page_title: Copy and Paste
description: Check our &quot;Copy and Paste&quot; documentation article for the RadSpreadsheet control.
slug: radspreadsheet-copy-and-paste
tags: copy, paster, clipboard, radspreadsheet
published: True
---

# Copy and Paste

The `RadSpreadSheet` control uses the [SpreadProcessing library](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview) as its document model. This library allows you to copy the selected cell or a cells region and paste it in the same/other worksheet.

>tip More information about the copy and paste functionality of the SpreadProcessing library can be found in this [article](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/clipboard-support).

The following example shows how to copy cells and paste them:

__Defining the Radspreadsheet and the UI elements for the copy and paste logic__
```XAML
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <StackPanel Orientation="Horizontal">
            <telerik:RadButton Content="Copy cells from this worksheet"
                               Click="OnCopyCellsButtonClicked"/>
            <telerik:RadButton Content="Paste copied cells in the second worksheet"
                               Click="OnPasteCellsButtonClicked"/>
        </StackPanel>
        <telerik:RadSpreadsheet x:Name="spreadsheet" Grid.Row="1"/>
    </Grid>
```

__Defining the copy and paste logic for the added UI elements__
```C#
    private void OnCopyCellsButtonClicked(object sender, RoutedEventArgs e)
    {
        Selection selection = this.spreadsheet.ActiveWorksheetEditor.Selection;
    
        this.spreadsheet.CommandDescriptors.Copy.Command.Execute(selection);
    }
    
    private void OnPasteCellsButtonClicked(object sender, RoutedEventArgs e)
    {
        this.spreadsheet.ActiveWorksheetEditor.Paste();
    }
```

## RadSpreadsheetRibbon

The copy and paste functionality is also present in the [RadSpreadsheetRibbon]({%slug radspreadsheet-getting-started-spreadsheet-ui%}) element, which is a UI component that you can use together with RadSpreadsheet. Via the copy and paste buttons on the left side of the RadspreadsheetRibbon element, you can execute this logic through the UI.