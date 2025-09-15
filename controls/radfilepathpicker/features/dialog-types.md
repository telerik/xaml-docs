---
title: Dialog Types
page_title: Dialog Types
description: This article will demonstrate the DialogTypes property of the RadFilePathPicker control.
slug: radfilepathpicker-dialog-types
tags: radfilepathpicker, dialog, types
position: 0
---

# Dialog Types

__RadFilePathPicker__ comes with a predefined set of dialog types. The available types are determined by the __DialogType__ enumeration and the chosen option can be set to the __DialogType__ property of the control. Depending on the DialogType, one of the [RadFileDialog]({%slug radfiledialogs-getting-started%}#using-the-dialogs) controls is opened when the show dialog button is clicked. 

## OpenFile

__OpenFile__ is the default value of the __DialogType__ property and in that case a [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%}) is opened.

## OpenFolder

When the __DialogType__ is __OpenFolder__, a [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%}) is opened.

## SaveFile

When the __DialogType__ is __SaveFile__, a [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%}) is opened.

## Showing a Custom Dialog

In order to open a native windows dialog instead of the RadFileDialogs, you can handle the __DialogOpening__ event as demonstrated in __Example 1__.

__Example 1: Defining RadFilePathPicker__
```C#
    private void RadFilePathPicker_DialogOpening(object sender, Telerik.Windows.Controls.FileDialogs.DialogOpeningEventArgs e)
    {
        e.Cancel = true;

        OpenFileDialog dialog = new OpenFileDialog();
        if (dialog.ShowDialog() == true)
        {
            RadFilePathPicker picker = sender as RadFilePathPicker;

            if (picker != null)
            {
                picker.FilePath = dialog.FileName;
            }
        }
    }
```

## See Also 

* [Commands]({%slug radfilepathpicker-commands%})
* [WatermarkTextbox Properties]({%slug radfilepathpicker-watermarktextbox-properties%})
