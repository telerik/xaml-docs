---
title: Commands and Tools
page_title: Commands and Tools
description: Commands and Tools
slug: radimageeditor-features-commands-and-tools
tags: commands,and,tools
published: True
position: 0
---

# Commands and Tools



## 

The operations that __RadImageEditor__ can execute on images form two categories – Commands and Tools. With commands, you can only specify the action (e.g. Crop, Rotate) and execute it. The change is applied to the image and gets registered in the Undo/Redo history. As for tools, they offer something more – a live preview of the operation using some parameters before committing it. At the end, when you confirm the action, they create an instance of a command and a context and only then does it get registered in the history stack.
        

Available __Commands__:
        

* OpenImageCommand

* SaveImageCommand

* UndoCommand

* RedoCommand

* Rotate90ClockwiseCommand

* Rotate180Command

* Rotate90CounteclockwiseCommand

* InvertColorsCommand

* FlipVerticalCommand

* FlipHorizontalCommand

* ExecuteToolCommand

* DrawCommand

Available __Tools__:
        

* CropTool

* CanvasResizeTool

* ResizeTool

* BlurTool – uses 2 pixel shaders

* RoundCornersTool

* EffectToolBase – tools, based on pixel shaders:

* SharpenTool

* SaturationTool

* HueShiftTool

* ContrastTool

* DrawTextTool

* [DrawTool]({%slug radimageeditor-tools-drawing%})

* [ShapeTool]({%slug radimageeditor-tools-shape-tool%})


>tipAll tools are located in the Telerik.Windows.Media.Imaging.Tools namespace and can be created in XAML.<br/> __xmlns:tools="clr-namespace:Telerik.Windows.Media.Imaging.Tools;assembly=Telerik.Windows.Controls.ImageEditor"__

The effects in __RadImageEditor__ that are implemented using pixel shaders enable the use of hardware acceleration whenever the platform supports it. This result in most effects being applied almost instantly, enabling real-time preview with sliders for the parameter values. You can easily create a command using your own custom shader by implementing __EffectCommandBase__. This approach is shown in [this blog post](http://blogs.telerik.com/blogs/posts/11-07-20/under-the-hood-of-radimageeditor-for-silverlight-and-wpf.aspx) with a sample implementation of a blur command.
        
## See Also

* [History]({%slug radimageeditor-features-history%})