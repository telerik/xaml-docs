---
title: Custom Places
page_title: Custom Places
description: Check our &quot;Custom Places&quot; documentation article for the RadFileDialogs {{ site.framework_name }} control.
slug: radfiledialogs-features-customplaces
tags: custom,places,favorites
published: True
position: 1
---

# Custom Places

The file dialogs provide you with the option the specify a list of directories to be displayed to the left of the **Main Pane** above the **Tree Navigation Pane** similarly to Windows' **Quick Access** view.

To enable this functionality, you should add a list of directories to the control's **CustomPlaces** collection. It is of type **IList<string>**.

#### [C#] Example 1: Add custom places  
<snippet id='radfiledialogs-features-custom-places-block_1-cs' />


> Note that this collection is read-only - you can only add and/or remove items from it but you cannot replace it with another collection.

The specified folders will then appear in the dialogs navigation pane.

#### Figure 1: Custom directories shown in the navigation pane

![Custom directories shown in the navigation pane](images/FileDialogs_CustomPlaces.png)

## See Also

* [Common Features]({%slug radfiledialogs-features-common%})
* [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%})
* [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%})
* [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%})