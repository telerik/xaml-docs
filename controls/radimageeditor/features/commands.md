---
title: Commands
page_title: Commands
description: Check our &quot;Commands&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-features-commands-and-tools
tags: commands,and,tools
published: True
position: 0
---

# Commands

The commands of RadImageEditor allows you to execute actions over the image element, like rotate, flip, undo and more.

The RadImageEditor commands apply an effect over the image or execute an action like undo, redo and open/save image. The commands are defined in the `ImageEditorCommands`, `ImageEditorRoutedCommands` and `ImageCommands` classes.

## ImageEditorCommands

An instance of the `ImageEditorCommands` class is created and assigned to the `Commands` property of `RadImageEditor` which can be used to access the commands. The `ImageEditorCommands` instance is associated with the corresponding `RadImageEditor` control and it executes the commands over its image.

__Example 1: Using an image editor command in XAML__
<snippet id='radimageeditor-features-commands-example_1_using_an_image_editor_command_in_xaml-xaml' />


__Example 2: Using an image editor command in code__
<snippet id='radimageeditor-features-commands-example_2_using_an_image_editor_command_in_code-cs' />


The following list shows the __available commands__ in the `ImageEditorCommands` class.

* __OpenImageCommand__: Opens a dialog that allows you to select an image file which will get loaded into the corresponding `RadImageEditor` element. The CommandParameter of the command is optional and it expects a string describing the [file extension filter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0) of the file dialog.

	__Example 3: Using OpenImageCommand__
	<snippet id='radimageeditor-features-commands-example_3_using_openimagecommand-cs' />


* __SaveImageCommand__: Opens a dialog that allows you to select where on the file system the current image will get saved. The CommandParameter of the command is optional and it expects a string describing the [file extension filter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0) of the file dialog.

	__Example 4: Using SaveImageCommand__
	<snippet id='radimageeditor-features-commands-example_4_using_saveimagecommand-cs' />


* __UndoCommand__: Undo the last change applied to the image. This command doesn't use the CommandParameter.

	__Example 5: Using UndoCommand__
	<snippet id='radimageeditor-features-commands-example_5_using_undocommand-cs' />


* __RedoCommand__: Executes a redo action over the current image. This command doesn't use the CommandParameter.

	__Example 6: Using RedoCommand__
	<snippet id='radimageeditor-features-commands-example_6_using_redocommand-cs' />


* __Rotate90ClockwiseCommand__: Rotates the image by 90 degrees clockwise. This command doesn't use the CommandParameter.

	__Example 7: Using Rotate90ClockwiseCommand__
	<snippet id='radimageeditor-features-commands-example_7_using_rotate90clockwisecommand-cs' />

	
* __Rotate90CounterclockwiseCommand__: Rotates the image by 90 degrees clockwise. This command doesn't use the CommandParameter.

	__Example 8: Using Rotate90CounterclockwiseCommand__
	<snippet id='radimageeditor-features-commands-example_8_using_rotate90counterclockwisecommand-cs' />


* __Rotate180Command__: Rotates the image by 180 degrees clockwise. This command doesn't use the CommandParameter.

	__Example 9: Using Rotate180Command__
	<snippet id='radimageeditor-features-commands-example_9_using_rotate180command-cs' />


* __InvertColorsCommand__: Inverts the colors in the image. This command doesn't use the CommandParameter.
	
	__Example 10: Using InvertColorsCommand__
	<snippet id='radimageeditor-features-commands-example_10_using_invertcolorscommand-cs' />


* __FlipVerticalCommand__: Flips the image vertically. This command doesn't use the CommandParameter.

	__Example 11: Using FlipVerticalCommand__
	<snippet id='radimageeditor-features-commands-example_11_using_flipverticalcommand-cs' />


* __FlipHorizontalCommand__: Flips the image horizontally. This command doesn't use the CommandParameter.

	__Example 12: Using FlipHorizontalCommand__
	<snippet id='radimageeditor-features-commands-example_12_using_fliphorizontalcommand-cs' />


* __ExecuteToolCommand__: Executes a [tool]({%slug radimageeditor-features-tools%}). The CommandParameter is required and it expects an object of type [ITool](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.tools.itool).

	__Example 13: Using ExecuteToolCommand__
	<snippet id='radimageeditor-features-commands-example_13_using_executetoolcommand-cs' />

	
## ImageCommands

The `ImageCommands` class contains static commands that apply image adjustments like crop, blur, resize, draw, etc. The adjustments are executed via classes that implement the [IImageCommand](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.commands.iimagecommand) interface. 

The actions in the `ImageCommands` class are not dependent on the RadImageEditor control. Instead they work with an instance of [RadBitmap](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.radbitmap) which in the context of `RadImageEditor` holds its current picture. Each command expects a `RadBitmap` object and returns a modified copy after the corresponding adjustments are applied.

The following list shows the __available commands__ in the `ImageCommands` class.

* __FlipCommand__: Flips the image horizontally or vertically. The context expected by the command is of type `FlipCommandContext` which contains information about the flip orientation.

	__Example 14: Using ExecuteToolCommand__
	<snippet id='radimageeditor-features-commands-example_14_using_executetoolcommand-cs' />


	The command also provide two public static methods that can be used instead of the `Execute` method.
	
	__Example 15: Using FlipCommand static methods__
	<snippet id='radimageeditor-features-commands-example_15_using_flipcommand_static_methods-cs' />

	
* __RotateCommand__: Rotates the image by the specified degree. The context expected by the command is of type `RotateCommandContext` which contains information about the rotation degrees and the color of the background that will be shown behind the rotated image.

	__Example 16: Using RotateCommand__
	<snippet id='radimageeditor-features-commands-example_16_using_rotatecommand-cs' />

	
* __ContrastCommand__: Changes the contrast and brightness of the image. The context expected by the command is of type `ContrastCommandContext` which contains information about the level of brightness and contrast that will be applied over the image. The default brightness is 0 and the allowed values are between -1 and 1. The default contrast is 1.5 and the allowed values are between 0 and 2.

	__Example 17: Using ContrastCommand__
	<snippet id='radimageeditor-features-commands-example_17_using_contrastcommand-cs' />

	
* __BlurCommand__: Applies a blur effect over the image. The context expected by the command is of type `BlurCommandContext` which contains information about the blur amount and the input size.

	__Example 18: Using BlurCommand__
	<snippet id='radimageeditor-features-commands-example_18_using_blurcommand-cs' />

	
* __SharpenCommand__: Sharpens the image. The context expected by the command is of type `SharpenCommandContext` which contains information about the blur amount and the input size.

	__Example 19: Using SharpenCommand__
	<snippet id='radimageeditor-features-commands-example_19_using_sharpencommand-cs' />

	
* __HueShiftCommand__: Applies a hue shift effect over the image. The context expected by the command is of type `HueShiftCommandContext` which contains information about hue offset.

	__Example 20: Using HueShiftCommand__
	<snippet id='radimageeditor-features-commands-example_20_using_hueshiftcommand-cs' />

	
* __InvertColorsCommand__: Inverts the colors in the image. This command doesn't use a context object.

	__Example 21: Using InvertColorsCommand__
	<snippet id='radimageeditor-features-commands-example_21_using_invertcolorscommand-cs' />

	
* __SaturationCommand__: Applies saturation to the image. The context expected by the command is of type `SaturationCommandContext` which contains information about saturation.

	__Example 22: Using SaturationCommand__
	<snippet id='radimageeditor-features-commands-example_22_using_saturationcommand-cs' />

	
* __CropCommand__: Crops the image. The context expected by the command is of type `CropCommandContext` which contains information about the top left position where the crop starts and the final size of the cropped image.

	__Example 23: Using CropCommand__
	<snippet id='radimageeditor-features-commands-example_23_using_cropcommand-cs' />


* __ResizeCommand__: Resizes the image. The context expected by the command is of type `ResizeCommandContext` which contains information about the new width and height of the image.

	__Example 24: Using ResizeCommand__
	<snippet id='radimageeditor-features-commands-example_24_using_resizecommand-cs' />

	
* __CanvasResizeCommand__: Resizes the canvas. The context expected by the command is of type `CanvasResizeCommandContext` which contains information about the image alignment, the new size of the canvas and the background color.

	__Example 25: Using CanvasResizeCommand__
	<snippet id='radimageeditor-features-commands-example_25_using_canvasresizecommand-cs' />

	
	
* __RoundCornersCommand__: Adds round corners around the image. The context expected by the command is of type `RoundCornersCommandContext` which contains information about the corner radius, the border and the background.

	__Example 26: Using RoundCornersCommandd__
	<snippet id='radimageeditor-features-commands-example_26_using_roundcornerscommandd-cs' />

	
	
* __DrawTextCommand__: Draws text over the image. The context expected by the command is of type `DrawTextCommandContext` which contains information about text and its position.

	__Example 27: Using DrawTextCommand__
	<snippet id='radimageeditor-features-commands-example_27_using_drawtextcommand-cs' />

	
	
* __DrawCommand__: Draws a shape path over the image. The context expected by the command is of type `DrawCommandContext` which contains information about the drawn path.

	__Example 28: Using DrawCommand__
	<snippet id='radimageeditor-features-commands-example_28_using_drawcommand-cs' />

	
## ImageEditorRoutedCommands

The __ImageEditorRoutedCommands__ class contains static [RoutedCommands](https://docs.microsoft.com/en-us/dotnet/api/system.windows.input.routedcommand?view=net-5.0) which wrap few of the commands of the [ImageEditorCommands](#imageeditorcommands) class.

The following list shows the __available commands__ in the `ImageEditorRoutedCommands` class.

* __FlipHorizontal__

* __FlipVertical__

* __Rotate90Clockwise__

* __Rotate90Counterclockwise__

* __InvertColors__

* __ExecuteTool__

* __Undo__

* __Redo__

* __Open__

* __Save__

__Example 29: Using the ImageEditorRoutedCommands__
<snippet id='radimageeditor-features-commands-example_29_using_the_imageeditorroutedcommands-xaml' />


The __commands__ namespace declaration points to the following namespace: `xmlns:commands="clr-namespace:Telerik.Windows.Media.Imaging.ImageEditorCommands.RoutedCommands;assembly=Telerik.Windows.Controls.ImageEditor"`.

## See Also  
* [ImageEditorCommandBase](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.imageeditorcommands.imageeditorcommandbase)
* [Tools]({%slug radimageeditor-features-tools%})
