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
```XAML
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinitions/>
			<RowDefinitions Height="Auto"/>
		</Grid.RowDefinitions>
		<telerik:RadImageEditor x:Name="radImageEditor"/>
        <telerik:RadButton Content="Open image" Command="{Binding ElementName=radImageEditor, Path=Commands.Open}" Grid.Row="1"/>
	</Grid>
```

__Example 2: Using an image editor command in code__
```C#
	this.radImageEditor.Commands.Open.Execute(null);
```

The following list shows the __available commands__ in the `ImageEditorCommands` class.

* __OpenImageCommand__: Opens a dialog that allows you to select an image file which will get loaded into the corresponding `RadImageEditor` element. The CommandParameter of the command is optional and it expects a string describing the [file extension filter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0) of the file dialog.

	__Example 3: Using OpenImageCommand__
	```C#
		this.radImageEditor.Commands.Open.Execute("Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*");
	```

* __SaveImageCommand__: Opens a dialog that allows you to select where on the file system the current image will get saved. The CommandParameter of the command is optional and it expects a string describing the [file extension filter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0) of the file dialog.

	__Example 4: Using SaveImageCommand__
	```C#
		this.radImageEditor.Commands.Save.Execute("Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*");
	```

* __UndoCommand__: Undo the last change applied to the image. This command doesn't use the CommandParameter.

	__Example 5: Using UndoCommand__
	```C#
		this.radImageEditor.Commands.Undo.Execute(null);
	```

* __RedoCommand__: Executes a redo action over the current image. This command doesn't use the CommandParameter.

	__Example 6: Using RedoCommand__
	```C#
		this.radImageEditor.Commands.Undo.Execute(null);
	```

* __Rotate90ClockwiseCommand__: Rotates the image by 90 degrees clockwise. This command doesn't use the CommandParameter.

	__Example 7: Using Rotate90ClockwiseCommand__
	```C#
		this.radImageEditor.Commands.Rotate90Clockwise.Execute(null);
	```
	
* __Rotate90CounterclockwiseCommand__: Rotates the image by 90 degrees clockwise. This command doesn't use the CommandParameter.

	__Example 8: Using Rotate90CounterclockwiseCommand__
	```C#
		this.radImageEditor.Commands.Rotate90Counterclockwise.Execute(null);
	```

* __Rotate180Command__: Rotates the image by 180 degrees clockwise. This command doesn't use the CommandParameter.

	__Example 9: Using Rotate180Command__
	```C#
		this.radImageEditor.Commands.Rotate180.Execute(null);
	```

* __InvertColorsCommand__: Inverts the colors in the image. This command doesn't use the CommandParameter.
	
	__Example 10: Using InvertColorsCommand__
	```C#
		this.radImageEditor.Commands.InvertColors.Execute(null);
	```

* __FlipVerticalCommand__: Flips the image vertically. This command doesn't use the CommandParameter.

	__Example 11: Using FlipVerticalCommand__
	```C#
		this.radImageEditor.Commands.FlipVertical.Execute(null);
	```

* __FlipHorizontalCommand__: Flips the image horizontally. This command doesn't use the CommandParameter.

	__Example 12: Using FlipHorizontalCommand__
	```C#
		this.radImageEditor.Commands.FlipHorizontal.Execute(null);
	``` 

* __ExecuteToolCommand__: Executes a [tool]({%slug radimageeditor-features-tools%}). The CommandParameter is required and it expects an object of type [ITool](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.tools.itool).

	__Example 13: Using ExecuteToolCommand__
	```C#
		ITool tool = new BlurTool();
		this.radImageEditor.Commands.ExecuteTool.Execute(tool);
	```
	
## ImageCommands

The `ImageCommands` class contains static commands that apply image adjustments like crop, blur, resize, draw, etc. The adjustments are executed via classes that implement the [IImageCommand](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.commands.iimagecommand) interface. 

The actions in the `ImageCommands` class are not dependent on the RadImageEditor control. Instead they work with an instance of [RadBitmap](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.radbitmap) which in the context of `RadImageEditor` holds its current picture. Each command expects a `RadBitmap` object and returns a modified copy after the corresponding adjustments are applied.

The following list shows the __available commands__ in the `ImageCommands` class.

* __FlipCommand__: Flips the image horizontally or vertically. The context expected by the command is of type `FlipCommandContext` which contains information about the flip orientation.

	__Example 14: Using ExecuteToolCommand__
	```C#
		var context = new FlipCommandContext(Orientation.Vertical);
		RadBitmap newImage = ImageCommands.Flip.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```

	The command also provide two public static methods that can be used instead of the `Execute` method.
	
	__Example 15: Using FlipCommand static methods__
	```C#		
		RadBitmap horizontallyFlippedImage = FlipCommand.FlipHorizontal(this.radImageEditor.Image);
		RadBitmap verticallyFlippedImage = FlipCommand.FlipVertical(this.radImageEditor.Image);
	```
	
* __RotateCommand__: Rotates the image by the specified degree. The context expected by the command is of type `RotateCommandContext` which contains information about the rotation degrees and the color of the background that will be shown behind the rotated image.

	__Example 16: Using RotateCommand__
	```C#
		var context = new RotateCommandContext(22, Colors.Green);
		RadBitmap newImage = ImageCommands.Rotate.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
* __ContrastCommand__: Changes the contrast and brightness of the image. The context expected by the command is of type `ContrastCommandContext` which contains information about the level of brightness and contrast that will be applied over the image. The default brightness is 0 and the allowed values are between -1 and 1. The default contrast is 1.5 and the allowed values are between 0 and 2.

	__Example 17: Using ContrastCommand__
	```C#
		var context = new ContrastCommandContext(brightness: 0.25, contrast: 0.25);
		RadBitmap newImage = ImageCommands.Contrast.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
* __BlurCommand__: Applies a blur effect over the image. The context expected by the command is of type `BlurCommandContext` which contains information about the blur amount and the input size.

	__Example 18: Using BlurCommand__
	```C#
		var context = new BlurCommandContext(0.5, new Size(500, 500));
		RadBitmap newImage = ImageCommands.Blur.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
* __SharpenCommand__: Sharpens the image. The context expected by the command is of type `SharpenCommandContext` which contains information about the blur amount and the input size.

	__Example 19: Using SharpenCommand__
	```C#
		var originalImage = this.radImageEditor.Image;
		var context = new SharpenCommandContext(0.5, new Size(originalImage.Width, originalImage.Height));
		RadBitmap newImage = ImageCommands.Sharpen.Execute(originalImage, context);
		this.radImageEditor.Image = newImage;
	```
	
* __HueShiftCommand__: Applies a hue shift effect over the image. The context expected by the command is of type `HueShiftCommandContext` which contains information about hue offset.

	__Example 20: Using HueShiftCommand__
	```C#
		var context = new HueShiftCommandContext(40);
		RadBitmap newImage = ImageCommands.HueShift.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
* __InvertColorsCommand__: Inverts the colors in the image. This command doesn't use a context object.

	__Example 21: Using InvertColorsCommand__
	```C#
		RadBitmap newImage = ImageCommands.InvertColors.Execute(this.radImageEditor.Image, null);
		this.radImageEditor.Image = newImage;
	```
	
* __SaturationCommand__: Applies saturation to the image. The context expected by the command is of type `SaturationCommandContext` which contains information about saturation.

	__Example 22: Using SaturationCommand__
	```C#
		var context = new SaturationCommandContext(40);
		RadBitmap newImage = ImageCommands.Saturation.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
* __CropCommand__: Crops the image. The context expected by the command is of type `CropCommandContext` which contains information about the top left position where the crop starts and the final size of the cropped image.

	__Example 23: Using CropCommand__
	```C#
		var context = new CropCommandContext(10, 10, 250, 250);
		RadBitmap newImage = ImageCommands.Crop.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```

* __ResizeCommand__: Resizes the image. The context expected by the command is of type `ResizeCommandContext` which contains information about the new width and height of the image.

	__Example 24: Using ResizeCommand__
	```C#
		var context = new ResizeCommandContext(250, 250);
		RadBitmap newImage = ImageCommands.Resize.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
* __CanvasResizeCommand__: Resizes the canvas. The context expected by the command is of type `CanvasResizeCommandContext` which contains information about the image alignment, the new size of the canvas and the background color.

	__Example 25: Using CanvasResizeCommand__
	```C#
		var context = new CanvasResizeCommandContext(Colors.Green, HorizontalAlignment.Left, VerticalAlignment.Top, 250, 250);
		RadBitmap newImage = ImageCommands.CanvasResize.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
	
* __RoundCornersCommand__: Adds round corners around the image. The context expected by the command is of type `RoundCornersCommandContext` which contains information about the corner radius, the border and the background.

	__Example 26: Using RoundCornersCommandd__
	```C#
		var context = new RoundCornersCommandContext(10, Colors.Green, 2, Colors.Black);
		RadBitmap newImage = ImageCommands.RoundCorners.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
	
* __DrawTextCommand__: Draws text over the image. The context expected by the command is of type `DrawTextCommandContext` which contains information about text and its position.

	__Example 27: Using DrawTextCommand__
	```C#
		var context = new DrawTextCommandContext(16, Colors.Green, "My text", new Point(100, 100), 0);
		RadBitmap newImage = ImageCommands.DrawText.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
	
* __DrawCommand__: Draws a shape path over the image. The context expected by the command is of type `DrawCommandContext` which contains information about the drawn path.

	__Example 28: Using DrawCommand__
	```C#
		var path = new Path();
		path.Data = new EllipseGeometry(new Point(100, 100), 10, 10);
		path.Fill = Brushes.Green;
		path.Stroke = Brushes.Red;
		path.StrokeThickness = 3;
		var requiredParent = new Grid();
		requiredParent.Children.Add(path);
		var context = new DrawCommandContext(path);
		RadBitmap newImage = ImageCommands.Draw.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	```
	
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
```XAML
	<Grid>
        <telerik:RadImageEditor x:Name="radImageEditor" />
        <telerik:RadButton Content="Invert Colors" 
						   Command="commands:ImageEditorRoutedCommands.InvertColors"
                           CommandTarget="{Binding ElementName=radImageEditor}"/>
    </Grid>
```

The __commands__ namespace declaration points to the following namespace: `xmlns:commands="clr-namespace:Telerik.Windows.Media.Imaging.ImageEditorCommands.RoutedCommands;assembly=Telerik.Windows.Controls.ImageEditor"`.

## See Also  
* [ImageEditorCommandBase](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.imageeditorcommands.imageeditorcommandbase)
* [Tools]({%slug radimageeditor-features-tools%})
