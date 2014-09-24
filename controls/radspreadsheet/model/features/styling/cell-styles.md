---
title: Cell Styles
page_title: Cell Styles
description: Cell Styles
slug: radspreadsheet-model-features-styling-cell-styles
tags: cell,styles
published: False
position: 0
---

# Cell Styles



A cell style is a predefined set of formatting options, such as cell borders, fonts, font sizes and number formats. Using cell styles allows you to
        apply multiple format options in one step and also offers an easy approach to achieve consistency in cell formatting.
        __RadSpreadsheet__ has a number of built-in cell styles that you can modify or apply directly. Its API allows you to duplicate
        an existing style or create a new one according to your preferences.
      

>You can create cell styles that are dependent on the current document theme. Such styles are updated automatically when you change the selected
          document theme. You can read more about document themes and dependent cell styles in the   [Document Themes]({%slug radspreadsheet-model-features-styling-document-themes%}) article.
        

* [Cell Style Properties](#cell-style-properties)

* [Create Cell Style](#create-cell-style)

* [Modify Cell Style](#modify-cell-style)

* [Remove Cell Style](#remove-cell-style)

## Cell Style Properties

A cell style in RadSpreadsheet is represented by the __CellStyle__ class. The properties of the class can be categorized in five
          groups: number, alignment, font, border and fill. Following are all properties distributed in their corresponding groups:
        

* Number group

* Format

* Alignment group

* HorizontalAlignment

* VerticalAlignment

* Indent

* IsWrapped

* Font group

* FontFamily

* FontSize

* IsBold

* IsItalic

* Underline

* ForeColor

* Border group

* LeftBorder

* TopBorder

* RightBorder

* BottomBorder

* DiagonalUpBorder

* DiagonalDownBorder

* Fill group

* Fill

In addition to the property above, the __CellStyle__ class exposes five Boolean properties that indicate whether the groups
          above will be applied:
        

* IncludeNumber

* IncludeAlignment

* IncludeFont

* IncludeBorder

* IncludeFill

When you apply a style to a cell with locally set properties, the end result is an addition of the style properties to the cell's local
          properties. What the end result of such an addition of styles is depends on which elements (groups) of the style have been selected as being part
          of the style. You can select a group to be part of the style by setting the appropriate property to true. For example, including the
          __Number__ group looks like this:
        

#### __C#__

{{region radspreadsheet-model-features-styling-cell-styles_0}}
	            Workbook workbook = new Workbook();
	            CellStyle tempStyle = workbook.Styles["Bad"];
	            tempStyle.IncludeNumber = true;
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-features-styling-cell-styles_0}}
	        Dim workbook As New Workbook()
	        Dim tempStyle As CellStyle = workbook.Styles("Bad")
	        tempStyle.IncludeNumber = True
	        '#End Region
	    End Sub
	
	    Public Sub CreateCellStyle()
	        '#Region radspreadsheet-model-features-styling-cell-styles_1
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim cellStyle As CellStyle = workbook.Styles.Add("My style", CellStyleCategory.[Custom])
	
	        cellStyle.BeginUpdate()
	
	        Dim border As New CellBorder(CellBorderStyle.DashDotDot, New ThemableColor(Colors.Red))
	        cellStyle.LeftBorder = border
	        cellStyle.TopBorder = border
	        cellStyle.RightBorder = border
	        cellStyle.BottomBorder = border
	
	        Dim patternColor As New ThemableColor(ThemeColorType.Accent1)
	
	        Dim shadeType As System.Nullable(Of ColorShadeType)
	        shadeType = ColorShadeType.Shade2
	        Dim backgroundColor As New ThemableColor(ThemeColorType.Accent5, shadeType)
	
	        Dim fill As IFill = New PatternFill(PatternType.Gray75Percent, patternColor, backgroundColor)
	        cellStyle.Fill = fill
	
	        cellStyle.HorizontalAlignment = RadHorizontalAlignment.Left
	        cellStyle.VerticalAlignment = RadVerticalAlignment.Center
	
	        cellStyle.EndUpdate()
	
	        workbook.ActiveWorksheet.Cells(0, 0).SetStyleName("My style")
	        '#End Region
	    End Sub
	
	    Public Sub ModifyCellStyle()
	        '#Region radspreadsheet-model-features-styling-cell-styles_2
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim style As CellStyle = workbook.Styles("Bad")
	
	        style.BeginUpdate()
	
	        style.Fill = New PatternFill(PatternType.DiagonalCrosshatch, Colors.Red, Colors.Transparent)
	        style.FontSize = UnitHelper.PointToDip(20)
	        style.ForeColor = New ThemableColor(Colors.Black)
	
	        style.EndUpdate()
	        '#End Region
	    End Sub
	
	    Public Sub RemoveCellStyle()
	        '#Region  radspreadsheet-model-features-styling-cell-styles_3
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        If workbook.Styles.Remove("Bad") Then
	            Debug.WriteLine("Style removed")
	        Else
	            Debug.WriteLine("The style do not exist")
	        End If
	        '#End Region
	    End Sub
	
	End Class



Using __RadSpreadsheet__'s API you can add, modify or remove styles from the __Styles__ collection
          residing in the worksheet.
        

## Create Cell Style

Creating a new style is pretty straight-forward. All you have to do is use the __Add()__ method of workbook's
          __Styles__ collection. The method returns an object of type __CellStyle__ which you can manipulate. Note
          that setting several properties raises multiple UI updates. To avoid the additional overhead you can enclose the code blocks that set the properties
          with the __BeginUpdate()__ and __EndUpdate()__ methods.
        

The following example creates a new style and applies it to cell *A1*.
        

#### __C#__

{{region radspreadsheet-model-features-styling-cell-styles_1}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add();
	
	            CellStyle cellStyle = workbook.Styles.Add("My style", CellStyleCategory.Custom);
	
	            cellStyle.BeginUpdate();
	
	            CellBorder border = new CellBorder(CellBorderStyle.DashDotDot, new ThemableColor(Colors.Red));
	            cellStyle.LeftBorder = border;
	            cellStyle.TopBorder = border;
	            cellStyle.RightBorder = border;
	            cellStyle.BottomBorder = border;
	
	            ThemableColor patternColor = new ThemableColor(ThemeColorType.Accent1);
	            ThemableColor backgroundColor = new ThemableColor(ThemeColorType.Accent5, ColorShadeType.Shade2);
	            IFill fill = new PatternFill(PatternType.Gray75Percent, patternColor, backgroundColor);
	            cellStyle.Fill = fill;
	
	            cellStyle.HorizontalAlignment = RadHorizontalAlignment.Left;
	            cellStyle.VerticalAlignment = RadVerticalAlignment.Center;
	
	            cellStyle.EndUpdate();
	
	            workbook.ActiveWorksheet.Cells[0, 0].SetStyleName("My style");
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-features-styling-cell-styles_1}}
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim cellStyle As CellStyle = workbook.Styles.Add("My style", CellStyleCategory.[Custom])
	
	        cellStyle.BeginUpdate()
	
	        Dim border As New CellBorder(CellBorderStyle.DashDotDot, New ThemableColor(Colors.Red))
	        cellStyle.LeftBorder = border
	        cellStyle.TopBorder = border
	        cellStyle.RightBorder = border
	        cellStyle.BottomBorder = border
	
	        Dim patternColor As New ThemableColor(ThemeColorType.Accent1)
	
	        Dim shadeType As System.Nullable(Of ColorShadeType)
	        shadeType = ColorShadeType.Shade2
	        Dim backgroundColor As New ThemableColor(ThemeColorType.Accent5, shadeType)
	
	        Dim fill As IFill = New PatternFill(PatternType.Gray75Percent, patternColor, backgroundColor)
	        cellStyle.Fill = fill
	
	        cellStyle.HorizontalAlignment = RadHorizontalAlignment.Left
	        cellStyle.VerticalAlignment = RadVerticalAlignment.Center
	
	        cellStyle.EndUpdate()
	
	        workbook.ActiveWorksheet.Cells(0, 0).SetStyleName("My style")
	        '#End Region
	    End Sub
	
	    Public Sub ModifyCellStyle()
	        '#Region radspreadsheet-model-features-styling-cell-styles_2
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim style As CellStyle = workbook.Styles("Bad")
	
	        style.BeginUpdate()
	
	        style.Fill = New PatternFill(PatternType.DiagonalCrosshatch, Colors.Red, Colors.Transparent)
	        style.FontSize = UnitHelper.PointToDip(20)
	        style.ForeColor = New ThemableColor(Colors.Black)
	
	        style.EndUpdate()
	        '#End Region
	    End Sub
	
	    Public Sub RemoveCellStyle()
	        '#Region  radspreadsheet-model-features-styling-cell-styles_3
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        If workbook.Styles.Remove("Bad") Then
	            Debug.WriteLine("Style removed")
	        Else
	            Debug.WriteLine("The style do not exist")
	        End If
	        '#End Region
	    End Sub
	
	End Class



## Modify Cell Style

Modifying a style is even easier than creating one. All you need to do is retrieve the style from the __Styles__ collection
          and set the properties you need.
        

The following example obtains the Bad style from the styles collection of a workbook and modifies it.
        

#### __C#__

{{region radspreadsheet-model-features-styling-cell-styles_2}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add();
	
	            CellStyle style = workbook.Styles["Bad"];
	
	            style.BeginUpdate();
	
	            style.Fill = new PatternFill(PatternType.DiagonalCrosshatch, Colors.Red, Colors.Transparent);
	            style.FontSize = UnitHelper.PointToDip(20);
	            style.ForeColor = new ThemableColor(Colors.Black);
	
	            style.EndUpdate();
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-features-styling-cell-styles_2}}
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim style As CellStyle = workbook.Styles("Bad")
	
	        style.BeginUpdate()
	
	        style.Fill = New PatternFill(PatternType.DiagonalCrosshatch, Colors.Red, Colors.Transparent)
	        style.FontSize = UnitHelper.PointToDip(20)
	        style.ForeColor = New ThemableColor(Colors.Black)
	
	        style.EndUpdate()
	        '#End Region
	    End Sub
	
	    Public Sub RemoveCellStyle()
	        '#Region  radspreadsheet-model-features-styling-cell-styles_3
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        If workbook.Styles.Remove("Bad") Then
	            Debug.WriteLine("Style removed")
	        Else
	            Debug.WriteLine("The style do not exist")
	        End If
	        '#End Region
	    End Sub
	
	End Class



## Remove Cell Style

You can remove a style from the __Styles__ collection. It is as easy as removing an object from a list, you simply use the
          __Remove()__ method which return a Bolean value. When there is such style to be removed the method returns true.
        

#### __C#__

{{region radspreadsheet-model-features-styling-cell-styles_3}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add();
	
	            if (workbook.Styles.Remove("Bad"))
	            {
	                Debug.WriteLine("Style removed");
	            }
	            else
	            {
	                Debug.WriteLine("The style do not exist");
	            }
	{{endregion}}



#### __VB__





# See Also
