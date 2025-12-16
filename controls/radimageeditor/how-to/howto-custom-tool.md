---
title: Create a Custom Tool
page_title: Create a Custom Tool
description: Check our &quot;Create a Custom Tool&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-howto-custom-tool
tags: create,a,custom,tool
published: True
position: 2
---

# Create a Custom Tool

You can create your own custom tool for __RadImageEditor__ quite easily. You have to implement the __ITool__ interface, which will give you the ability to setup your own preview, settings UI and attach to any events of __RadImageEditor__ that are relevant to your tool.

This allows you to implement virtually any behavior you want within your tool and is the highlight of an SDK example: [Custom Watermark Tool](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/CustomWatermarkTool), where a custom tool for watermarking is available. The next tutorial will get you through the steps you need to execute to create one yourself.
        

1. __Create your tool.__<br/>Create a WatermarkTool class which implements the __ITool__ interface. The interface contains four properties and six methods which you need to implement.

	__Example 1: Create a tool__
	
	```C#
		public class WatermarkTool : ITool
	```


1. __Create a command.__<br/>The public IImageCommand GetCommand() method requires you to return a command linked with the tool. Create a custom command which implements the __IImageCommand__ interface and a field of the command's type in the WatermarkTool class.
            

	__Example 2: Create Command__
	
	```C#
		private WatermarkCommand watermarkCommand;
		public class WatermarkCommand : IImageCommand
		{
		    public RadBitmap Execute(RadBitmap source, object context)
		    {
		        WatermarkCommandContext myContext = (WatermarkCommandContext)context;
		        Grid grid = new Grid();
		        grid.Children.Add(new Image()
		        {
		            Source = source.Bitmap,
		            Stretch = Stretch.None
		        });
	
		        Image image = new Image()
		        {
		            Source = myContext.Image.Bitmap,
		            Stretch = Stretch.None,
		            Opacity = myContext.Opacity,
		        };
	
		        ScaleTransform scaleTransform = new ScaleTransform();
		        scaleTransform.ScaleX = myContext.Scale;
		        scaleTransform.ScaleY = myContext.Scale;
	
		        RotateTransform rotateTransform = new RotateTransform();
		        rotateTransform.Angle = myContext.Rotation;
	
		        TransformGroup transform = new TransformGroup();
		        transform.Children.Add(rotateTransform);
		        transform.Children.Add(scaleTransform);
	
		        image.RenderTransform = transform;
		        image.RenderTransformOrigin = new Point(0.5, 0.5);
	
		        grid.Children.Add(image);
		        return new RadBitmap(source.Width, source.Height, grid);
		    }
		}
	```



	>tip Do not forget to initialize the command in the constructor of the tool.

1. __Create command context.__<br/>Create context for your custom command. In this case we will take into account the Opacity, Rotation, Scale and Image properties.
            
	
	__Example 3: Create Command Context__
	
	```C#
		public class WatermarkCommandContext
		{
		    public double Opacity { get; private set; }
		    public double Rotation { get; private set; }
		    public double Scale { get; private set; }
		    public RadBitmap Image { get; private set; }
		    public WatermarkCommandContext(double opacity, double rotation, double scale, RadBitmap image)
		    {
		        this.Opacity = opacity;
		        this.Rotation = rotation;
		        this.Scale = scale;
		        this.Image = image;
		    }
		}
	```
	
	The context is also used in the public object GetContext() method in your tool.
	            

1. __Create UI settings for the tool.__
	
	>tip __ToolSettingsHeader__ is a content control located in the Telerik.Windows.Controls.ImageEditor assembly.
	              
	
	__Example 4: Create Custom Tool Settings__
	
	```XAML
		<toolSettingsHeader:ToolSettingsHeader 
		                            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
		                            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
		                            xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
		                            xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
		                            xmlns:toolSettingsHeader="clr-namespace:Telerik.Windows.Media.Imaging.Tools.UI;assembly=Telerik.Windows.Controls.ImageEditor"
		                            xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
		                            mc:Ignorable="d"
		                            d:DesignHeight="300" d:DesignWidth="400">
		    <Grid x:Name="LayoutRoot">
		        <Grid.RowDefinitions>
		            <RowDefinition Height="Auto "/>
		            <RowDefinition Height="Auto "/>
		            <RowDefinition Height="Auto "/>
		            <RowDefinition Height="Auto "/>
		            <RowDefinition Height="Auto "/>
		        </Grid.RowDefinitions>
		        <Grid.ColumnDefinitions>
		            <ColumnDefinition Width="*" />
		            <ColumnDefinition Width="Auto" />
		        </Grid.ColumnDefinitions>
		        <TextBlock Text="Open image" Grid.Row="0" Grid.Column="0" Margin="9" VerticalAlignment="Center" Foreground="#FF1E395B"/>
		        <telerik:RadButton x:Name="open" Content="Open" Height="23" Width="60" Margin="9" Grid.Column="1" />
		        <telerik:NumericPropertyEditor PropertyName="Opacity" x:Name="opacity" Grid.Row="2" MinimumValue="0" MaximumValue="1" Grid.ColumnSpan="2" Margin="5" />
		        <telerik:NumericPropertyEditor PropertyName="Rotation" x:Name="rotation" Grid.Row="3" MinimumValue="0" MaximumValue="360" Grid.ColumnSpan="2" Margin="5"/>
		        <telerik:NumericPropertyEditor PropertyName="Scale" x:Name="scale" MinimumValue="0.1" MaximumValue="5" Grid.Row="4" Grid.ColumnSpan="2" Margin="5" />
		    </Grid>
		</toolSettingsHeader:ToolSettingsHeader>
	```
	
	
	
	__Example 5: Interaction logic for tool settings__
	
	```C#
		public partial class WatermarkToolSettings : ToolSettingsHeader
		{
		    public WatermarkToolSettings()
		    {
		        InitializeComponent();
		        this.opacity.Value = WatermarkTool.DefaultOpacity;
		        this.scale.Value = WatermarkTool.DefaultScale;
		        this.rotation.Value = WatermarkTool.DefaultRotation;
		    }
		    //...
	```



1. Implement the __AttachUI()__, __DetachUI()__ and __ResetSettings()__ methods.
	            
	
	__Example 6: Implement UI settings related methods__
	
	```C#
		public void AttachUI(ToolInitInfo previewInitInfo)
		{
		    this.currnetEditor = previewInitInfo.ImageEditor;
		    this.previewPanel = previewInitInfo.PreviewPanel;
		    this.currnetEditor.ScaleFactorChanged += currnetEditor_ScaleFactorChanged;
		    this.previewPanel.SizeChanged += currnetEditor_ScaleFactorChanged;
		    this.previewPanel.Children.Add(this.watermarkImage);
		    this.UpdateScaleFactor();
		}
		public void DetachUI()
		{
		    this.currnetEditor.ScaleFactorChanged -= currnetEditor_ScaleFactorChanged;
		    this.previewPanel.SizeChanged -= currnetEditor_ScaleFactorChanged;
		    this.previewPanel.Children.Clear();
		    this.currnetEditor = null;
		    this.previewPanel = null;
		}
		public void ResetSettings()
		{
		    this.isDirty = false;
		    this.settings.opacity.Value = DefaultOpacity;
		    this.settings.rotation.Value = DefaultRotation;
		    this.settings.scale.Value = DefaultScale;
		}
	```
	
	
	
	>The __IsDirty__ property is used in the commiting logic of tools. Make sure to set it to true when a change in the settings has occured and to false when the settings are reset.
	              
	
	>tip The complete code is available in the XAML SDK repository: [Custom Watermark Tool](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/CustomWatermarkTool).
	          

## See Also

* [Implement ToolBase Class]({%slug radimageeditor-howto-implement-toolbase%})
* [Implement DrawToolBase Class]({%slug radimageeditor-howto-implement-drawtoolbase%})