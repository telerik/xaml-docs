---
title: Commands
page_title: Commands
description: Check our &quot;Commands&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-features-commands-and-tools
tags: commands,and,tools
published: True
position: 0
---

# {{ site.framework_name }} RadImageEditor Commands

The commands of RadImageEditor allows you to execute actions over the image element, like rotate, flip, undo and more.

The RadImageEditor commands apply an effect over the image or execute an action like undo, redo and open/save image. The commands are defined in the `ImageEditorCommands`, `ImageEditorRoutedCommands` and `ImageCommands` classes.

## ImageEditorCommands

An instance of the `ImageEditorCommands` class is created and assigned to the `Commands` property of `RadImageEditor` which can be used to access the commands. The `ImageEditorCommands` instance is associated with the corresponding `RadImageEditor` control and it executes the commands over its image.

#### __[XAML] Example 1: Using an image editor command in XAML__
{{region radimageeditor-features-commands-and-tools-0}}
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinitions/>
			<RowDefinitions Height="Auto"/>
		</Grid.RowDefinitions>
		<telerik:RadImageEditor x:Name="radImageEditor"/>
        <telerik:RadButton Content="Open image" Command="{Binding ElementName=radImageEditor, Path=Commands.Open}" Grid.Row="1"/>
	</Grid>
{{endregion}}

#### __[C#] Example 2: Using an image editor command in code__
{{region radimageeditor-features-commands-and-tools-1}}
	this.radImageEditor.Commands.Open.Execute(null);
{{endregion}}

The following list shows the __available commands__ in the `ImageEditorCommands` class.

* __OpenImageCommand__: Opens a dialog that allows you to select an image file which will get loaded into the corresponding `RadImageEditor` element. The CommandParameter of the command is optional and it expects a string describing the [file extension filter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0) of the file dialog.

	#### __[C#] Example 3: Using OpenImageCommand__
	{{region radimageeditor-features-commands-and-tools-2}}
		this.radImageEditor.Commands.Open.Execute("Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*");
	{{endregion}}

* __SaveImageCommand__: Opens a dialog that allows you to select where on the file system the current image will get saved. The CommandParameter of the command is optional and it expects a string describing the [file extension filter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0) of the file dialog.

	#### __[C#] Example 4: Using SaveImageCommand__
	{{region radimageeditor-features-commands-and-tools-3}}
		this.radImageEditor.Commands.Save.Execute("Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*");
	{{endregion}}

* __UndoCommand__: Undo the last change applied to the image. This command doesn't use the CommandParameter.

	#### __[C#] Example 5: Using UndoCommand__
	{{region radimageeditor-features-commands-and-tools-4}}
		this.radImageEditor.Commands.Undo.Execute(null);
	{{endregion}}

* __RedoCommand__: Executes a redo action over the current image. This command doesn't use the CommandParameter.

	#### __[C#] Example 6: Using RedoCommand__
	{{region radimageeditor-features-commands-and-tools-5}}
		this.radImageEditor.Commands.Undo.Execute(null);
	{{endregion}}

* __Rotate90ClockwiseCommand__: Rotates the image by 90 degrees clockwise. This command doesn't use the CommandParameter.

	#### __[C#] Example 7: Using Rotate90ClockwiseCommand__
	{{region radimageeditor-features-commands-and-tools-6}}
		this.radImageEditor.Commands.Rotate90Clockwise.Execute(null);
	{{endregion}}
	
* __Rotate90CounterclockwiseCommand__: Rotates the image by 90 degrees clockwise. This command doesn't use the CommandParameter.

	#### __[C#] Example 8: Using Rotate90CounterclockwiseCommand__
	{{region radimageeditor-features-commands-and-tools-7}}
		this.radImageEditor.Commands.Rotate90Counterclockwise.Execute(null);
	{{endregion}}

* __Rotate180Command__: Rotates the image by 180 degrees clockwise. This command doesn't use the CommandParameter.

	#### __[C#] Example 9: Using Rotate180Command__
	{{region radimageeditor-features-commands-and-tools-8}}
		this.radImageEditor.Commands.Rotate180.Execute(null);
	{{endregion}}

* __InvertColorsCommand__: Inverts the colors in the image. This command doesn't use the CommandParameter.
	
	#### __[C#] Example 10: Using InvertColorsCommand__
	{{region radimageeditor-features-commands-and-tools-9}}
		this.radImageEditor.Commands.InvertColors.Execute(null);
	{{endregion}}

* __FlipVerticalCommand__: Flips the image vertically. This command doesn't use the CommandParameter.

	#### __[C#] Example 11: Using FlipVerticalCommand__
	{{region radimageeditor-features-commands-and-tools-10}}
		this.radImageEditor.Commands.FlipVertical.Execute(null);
	{{endregion}}

* __FlipHorizontalCommand__: Flips the image horizontally. This command doesn't use the CommandParameter.

	#### __[C#] Example 12: Using FlipHorizontalCommand__
	{{region radimageeditor-features-commands-and-tools-11}}
		this.radImageEditor.Commands.FlipHorizontal.Execute(null);
	{{endregion}} 

* __ExecuteToolCommand__: Executes a [tool]({%slug radimageeditor-features-tools%}). The CommandParameter is required and it expects an object of type [ITool](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.tools.itool).

	#### __[C#] Example 13: Using ExecuteToolCommand__
	{{region radimageeditor-features-commands-and-tools-12}}
		ITool tool = new BlurTool();
		this.radImageEditor.Commands.ExecuteTool.Execute(tool);
	{{endregion}}
	
## ImageCommands

The `ImageCommands` class contains static commands that apply image adjustments like crop, blur, resize, draw, etc. The adjustments are executed via classes that implement the [IImageCommand](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.commands.iimagecommand) interface. 

The actions in the `ImageCommands` class are not dependent on the RadImageEditor control. Instead they work with an instance of [RadBitmap](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.radbitmap) which in the context of `RadImageEditor` holds its current picture. Each command expects a `RadBitmap` object and returns a modified copy after the corresponding adjustments are applied.

The following list shows the __available commands__ in the `ImageCommands` class.

* __FlipCommand__: Flips the image horizontally or vertically. The context expected by the command is of type `FlipCommandContext` which contains information about the flip orientation.

	#### __[C#] Example 14: Using ExecuteToolCommand__
	{{region radimageeditor-features-commands-and-tools-13}}
		var context = new FlipCommandContext(Orientation.Vertical);
		RadBitmap newImage = ImageCommands.Flip.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}

	The command also provide two public static methods that can be used instead of the `Execute` method.
	
	#### __[C#] Example 15: Using FlipCommand static methods__
	{{region radimageeditor-features-commands-and-tools-14}}		
		RadBitmap horizontallyFlippedImage = FlipCommand.FlipHorizontal(this.radImageEditor.Image);
		RadBitmap verticallyFlippedImage = FlipCommand.FlipVertical(this.radImageEditor.Image);
	{{endregion}}
	
* __RotateCommand__: Rotates the image by the specified degree. The context expected by the command is of type `RotateCommandContext` which contains information about the rotation degrees and the color of the background that will be shown behind the rotated image.

	#### __[C#] Example 16: Using RotateCommand__
	{{region radimageeditor-features-commands-and-tools-15}}
		var context = new RotateCommandContext(22, Colors.Green);
		RadBitmap newImage = ImageCommands.Rotate.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
* __ContrastCommand__: Changes the contrast and brightness of the image. The context expected by the command is of type `ContrastCommandContext` which contains information about the level of brightness and contrast that will be applied over the image. The default brightness is 0 and the allowed values are between -1 and 1. The default contrast is 1.5 and the allowed values are between 0 and 2.

	#### __[C#] Example 17: Using ContrastCommand__
	{{region radimageeditor-features-commands-and-tools-16}}
		var context = new ContrastCommandContext(brightness: 0.25, contrast: 0.25);
		RadBitmap newImage = ImageCommands.Contrast.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
* __BlurCommand__: Applies a blur effect over the image. The context expected by the command is of type `BlurCommandContext` which contains information about the blur amount and the input size.

	#### __[C#] Example 18: Using BlurCommand__
	{{region radimageeditor-features-commands-and-tools-17}}
		var context = new BlurCommandContext(0.5, new Size(500, 500));
		RadBitmap newImage = ImageCommands.Blur.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
* __SharpenCommand__: Sharpens the image. The context expected by the command is of type `SharpenCommandContext` which contains information about the blur amount and the input size.

	#### __[C#] Example 19: Using SharpenCommand__
	{{region radimageeditor-features-commands-and-tools-18}}
		var originalImage = this.radImageEditor.Image;
		var context = new SharpenCommandContext(0.5, new Size(originalImage.Width, originalImage.Height));
		RadBitmap newImage = ImageCommands.Sharpen.Execute(originalImage, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
* __HueShiftCommand__: Applies a hue shift effect over the image. The context expected by the command is of type `HueShiftCommandContext` which contains information about hue offset.

	#### __[C#] Example 20: Using HueShiftCommand__
	{{region radimageeditor-features-commands-and-tools-19}}
		var context = new HueShiftCommandContext(40);
		RadBitmap newImage = ImageCommands.HueShift.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
* __InvertColorsCommand__: Inverts the colors in the image. This command doesn't use a context object.

	#### __[C#] Example 21: Using InvertColorsCommand__
	{{region radimageeditor-features-commands-and-tools-20}}
		RadBitmap newImage = ImageCommands.InvertColors.Execute(this.radImageEditor.Image, null);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
* __SaturationCommand__: Applies saturation to the image. The context expected by the command is of type `SaturationCommandContext` which contains information about saturation.

	#### __[C#] Example 22: Using SaturationCommand__
	{{region radimageeditor-features-commands-and-tools-21}}
		var context = new SaturationCommandContext(40);
		RadBitmap newImage = ImageCommands.Saturation.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
* __CropCommand__: Crops the image. The context expected by the command is of type `CropCommandContext` which contains information about the top left position where the crop starts and the final size of the cropped image.

	#### __[C#] Example 23: Using CropCommand__
	{{region radimageeditor-features-commands-and-tools-22}}
		var context = new CropCommandContext(10, 10, 250, 250);
		RadBitmap newImage = ImageCommands.Crop.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}

* __ResizeCommand__: Resizes the image. The context expected by the command is of type `ResizeCommandContext` which contains information about the new width and height of the image.

	#### __[C#] Example 24: Using ResizeCommand__
	{{region radimageeditor-features-commands-and-tools-23}}
		var context = new ResizeCommandContext(250, 250);
		RadBitmap newImage = ImageCommands.Resize.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
* __CanvasResizeCommand__: Resizes the canvas. The context expected by the command is of type `CanvasResizeCommandContext` which contains information about the image alignment, the new size of the canvas and the background color.

	#### __[C#] Example 25: Using CanvasResizeCommand__
	{{region radimageeditor-features-commands-and-tools-24}}
		var context = new CanvasResizeCommandContext(Colors.Green, HorizontalAlignment.Left, VerticalAlignment.Top, 250, 250);
		RadBitmap newImage = ImageCommands.CanvasResize.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
	
* __RoundCornersCommand__: Adds round corners around the image. The context expected by the command is of type `RoundCornersCommandContext` which contains information about the corner radius, the border and the background.

	#### __[C#] Example 26: Using RoundCornersCommandd__
	{{region radimageeditor-features-commands-and-tools-25}}
		var context = new RoundCornersCommandContext(10, Colors.Green, 2, Colors.Black);
		RadBitmap newImage = ImageCommands.RoundCorners.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
	
* __DrawTextCommand__: Draws text over the image. The context expected by the command is of type `DrawTextCommandContext` which contains information about text and its position.

	#### __[C#] Example 27: Using DrawTextCommand__
	{{region radimageeditor-features-commands-and-tools-26}}
		var context = new DrawTextCommandContext(16, Colors.Green, "My text", new Point(100, 100), 0);
		RadBitmap newImage = ImageCommands.DrawText.Execute(this.radImageEditor.Image, context);
		this.radImageEditor.Image = newImage;
	{{endregion}}
	
	
* __DrawCommand__: Draws a shape path over the image. The context expected by the command is of type `DrawCommandContext` which contains information about the drawn path.

	#### __[C#] Example 28: Using DrawCommand__
	{{region radimageeditor-features-commands-and-tools-27}}
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
	{{endregion}}
	
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

#### __[XAML] Example 29: Using the ImageEditorRoutedCommands__
{{region radimageeditor-features-commands-and-tools-28}}
	<Grid>
        <telerik:RadImageEditor x:Name="radImageEditor" />
        <telerik:RadButton Content="Invert Colors" 
						   Command="commands:ImageEditorRoutedCommands.InvertColors"
                           CommandTarget="{Binding ElementName=radImageEditor}"/>
    </Grid>
{{endregion}}

The __commands__ namespace declaration points to the following namespace: `xmlns:commands="clr-namespace:Telerik.Windows.Media.Imaging.ImageEditorCommands.RoutedCommands;assembly=Telerik.Windows.Controls.ImageEditor"`.

## See Also  
* [ImageEditorCommandBase](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.imageeditorcommands.imageeditorcommandbase)
* [Tools]({%slug radimageeditor-features-tools%})
