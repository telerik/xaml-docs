---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radimageeditor-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started



## 

__RadImageEditor__ control encapsulates the entire image editing logic. In order to use it in your application you have to add references to:

* Telerik.Windows.Controls;

* Telerik.Windows.Controls.ImageEditor;

* Telerik.Windows.Controls.Input.

The control offers a set of operations you can perform on an image which has been loaded in the editor. These operations are available as Commands and Tools, which you can execute both in code-behind or XAML. [Read More]({%slug radimageeditor-features-commands-and-tools%})

Adding the above listed references will be sufficient to enable different modifications on images using RadImageEditor’s API. If you would like to provide the end users with the ability to edit the images, too, then UI backing up the different modification must be added.

__RadImageEditor__ has a good-to-go UI that comes out of the box. That is __RadImageEditorUI__, which is quite easily wired to work with the commands and tools that __RadImageEditor__ exposes. As both controls follow closely the command pattern, they can be set up to work with little to no code-behind. However, you can implement and wire custom UI, too.  [Read More]({%slug radimageeditor-features-radimageeditorui%})


# See Also

* [RadImageEditorUI]({%slug radimageeditor-features-radimageeditorui%})
* [Import and Export]({%slug radimageeditor-features-import-export%})