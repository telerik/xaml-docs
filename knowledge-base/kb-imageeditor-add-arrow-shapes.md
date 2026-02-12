---
title: Adding Custom Arrow Shapes to RadImageEditor
description: Learn how to integrate custom arrow shapes in the ImageEditor dialog accessed from the RadRichTextBox context menu in UI for WPF.
type: how-to
page_title: How to Add Custom Arrow Shapes to RadImageEditor
meta_title: How to Add Custom Arrow Shapes to RadImageEditorUI
slug: kb-imageeditor-add-arrow-shapes
tags: imageeditor, richtextbox, imageeditordialog, custom-shapes, arrow-shapes, radimageeditorui, shape-tool
res_type: kb
ticketid: 1674511
---

## Environment
<table>
<tbody>
<tr>
<td> Product </td>
<td>
UI for WPF ImageEditor
</td>
</tr>
<tr>
<td> Version </td>
<td> 2023.1.315 </td>
</tr>
</tbody>
</table>

## Description

How to add custom arrow shapes (or other shapes) to the list of shapes of the ShapeTool in RadImageEditor.

## Solution

To add arrows, you can first create custom classes that implement the `IShape` interface. 

```C#
public class DiagonalArrowShape : IShape
{
	public string DisplayName => "Diag. Arrow";

	public Geometry GetShapeGeometry()
	{
		return null;
	}
}

public class HorizontalArrowShape : IShape
{
	public string DisplayName => "Horiz. Arrow";

	public Geometry GetShapeGeometry()
	{
		return null;
	}
}

public class VerticalArrowShape : IShape
{
	public string DisplayName => "Vert. Arrow";

	public Geometry GetShapeGeometry()
	{
		return null;
	}
}
```

Then, create a custom class that derives from 'ShapeTool'. In the class, you can implement the shapes creation and drawing.

```C#
public class CustomDefaultShapeTool : ShapeTool
{
	private Point drawOrigin;
	private DrawCommandContext commandContext;
	private ShapeToolSettings settingsUI;
	private bool isDragging;

	public override UIElement GetSettingsUI()
	{
		this.settingsUI  = (ShapeToolSettings)base.GetSettingsUI();
		return this.settingsUI;
	}

	protected override void StartDraw(Point currentPoint)
	{
		this.isDragging = true;
		this.commandContext = (DrawCommandContext)this.GetContext();
		this.drawOrigin = currentPoint;
		base.StartDraw(currentPoint);
	}

	protected override void Draw(Point currentPoint)
	{
		if (IsCustomShapeSelected())
		{
			if (this.isDragging)
			{
				this.commandContext.DrawnPath.Data = this.GetShapeGeometry(currentPoint, this.settingsUI.SelectedShape);
			}
		}
		else
		{
			base.Draw(currentPoint);
		}
	}

	private bool IsCustomShapeSelected()
	{
		return this.settingsUI.SelectedShape is DiagonalArrowShape ||
						this.settingsUI.SelectedShape is HorizontalArrowShape ||
						this.settingsUI.SelectedShape is VerticalArrowShape;
	}

	protected override void EndDraw(Point currentPoint)
	{
		this.isDragging = false;
		base.EndDraw(currentPoint);
	}

	public override void ResetSettings()
	{
		this.settingsUI.StrokeColor = Colors.Green;
		this.settingsUI.StrokeSize = 2;
		base.ResetSettings();
	}

	private Geometry GetShapeGeometry(Point currentPoint, IShape selectedShape)
	{
		if (selectedShape is DiagonalArrowShape)
		{
			return this.CreateDiagonalArrowShape(currentPoint);
		}
		else if (selectedShape is HorizontalArrowShape)
		{
			return this.CreateHorizontalArrowShape(currentPoint);
		}
		else if (selectedShape is VerticalArrowShape)
		{
			return this.CreateVerticalArrowShape(currentPoint);
		}
		return null;
	}

	private Geometry CreateVerticalArrowShape(Point currentPoint)
	{
		return CreateArrowGeometry(this.drawOrigin.X, this.drawOrigin.X, this.drawOrigin.Y, currentPoint.Y, 3, 3);
	}

	private Geometry CreateHorizontalArrowShape(Point currentPoint)
	{
		return CreateArrowGeometry(this.drawOrigin.X, currentPoint.X, this.drawOrigin.Y, this.drawOrigin.Y, 3, 3);
	}

	private Geometry CreateDiagonalArrowShape(Point currentPoint)
	{
		return CreateArrowGeometry(this.drawOrigin.X, currentPoint.X, this.drawOrigin.Y, currentPoint.Y, 3, 3);
	}

	private StreamGeometry CreateArrowGeometry(double x1, double x2, double y1, double y2, double headWidth, double headHeight)
	{
		StreamGeometry geometry = new StreamGeometry();
		using (StreamGeometryContext context = geometry.Open())
		{
			double theta = Math.Atan2(y1 - y2, x1 - x2);
			double sint = Math.Sin(theta);
			double cost = Math.Cos(theta);

			Point pt1 = new Point(x1, y1);
			Point pt2 = new Point(x2, y2);

			Point pt3 = new Point(
				x2 + (headWidth * cost - headHeight * sint),
				y2 + (headWidth * sint + headHeight * cost));

			Point pt4 = new Point(
				x2 + (headWidth * cost + headHeight * sint),
				y2 - (headHeight * cost - headWidth * sint));

			context.BeginFigure(pt1, true, false);
			context.LineTo(pt2, true, true);
			context.LineTo(pt3, true, true);
			context.LineTo(pt2, false, true);
			context.LineTo(pt4, true, true);
		}        

		geometry.Freeze();
		return geometry;
	}
}
```

To use the customization, you can execute the `CustomDefaultShapeTool` or use it in the `RadImageEditorUI` as in the example below. The custom arrow shapes should be added to the `Shapes` collection of the tool.

```XAML
<telerik:RadImageEditorUI xmlns:tools="clr-namespace:Telerik.Windows.Media.Imaging.Tools;assembly=Telerik.Windows.Controls.ImageEditor"
						  xmlns:commands="clr-namespace:Telerik.Windows.Media.Imaging.ImageEditorCommands.RoutedCommands;assembly=Telerik.Windows.Controls.ImageEditor">
	<telerik:RadImageEditorUI.ImageToolsSections>
		<telerik:ImageToolsSection telerik:LocalizationManager.ResourceKey="ImageEditor_Transform">
			<telerik:ImageToolItem ImageKey="Shape" Text="Custom Arrows" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
				<telerik:ImageToolItem.CommandParameter>
					<local:CustomDefaultShapeTool>
						<tools:ShapeTool.Shapes>
							<local:DiagonalArrowShape />
							<local:HorizontalArrowShape />
							<local:VerticalArrowShape />
						</tools:ShapeTool.Shapes>
					</local:CustomDefaultShapeTool>
				</telerik:ImageToolItem.CommandParameter>
			</telerik:ImageToolItem>
		</telerik:ImageToolsSection>
	</telerik:RadImageEditorUI.ImageToolsSections>
</telerik:RadImageEditorUI>
```
