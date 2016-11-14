---
title: Customize Selection
page_title: Customize Selection
description: Customize Selection
slug: radspreadsheet-howto-customize-selection
tags: customize,selection
published: True
position: 0
---

# Customize Selection

RadSpreadsheet exposes several properties that enable you to control the way the selection in the control is rendered. This article describes the available properties and shows you how to work with them.

* **SelectionStroke**: A *dependency property* of type *Brush* that gets or sets the stroke of the selection.

* **SelectionStrokeThickness**: A *dependency property* of type *double* that gets or sets the stroke thickness of the selection.

* **SelectionFill**: A *dependency property* of type *Brush* that gets or sets the fill of the selection. 

* **FillHandleSelectionStroke**: A *dependency property* of type *Brush* that gets or sets the fill handle selection stroke.

**Figure 1** shows an example of a customized selection.

#### **Figure 1: Customized selection in RadSpreadsheet**
![Customized Selection](images/RadSpreadsheet_HowTo_Customize_Selection_01.png)


**Example 1** and **Example 2** demonstrate how you could customize the properties of the selection in XAML and in code respectively to achieve the result shown in **Figure 1**. 

#### **[XAML] Example 1: Customizing selection**
{{region xaml-radspreadsheet-howto-customize-selection_0}}

	<telerik:RadSpreadsheet x:Name="radSpreadsheet" SelectionStrokeThickness="2" SelectionStroke="Green">
	    <telerik:RadSpreadsheet.SelectionFill>
	        <SolidColorBrush Color="GreenYellow" Opacity="0.5" />
	    </telerik:RadSpreadsheet.SelectionFill>
	</telerik:RadSpreadsheet>
{{endregion}}

#### **[C#] Example 2: Customizing selection**
{{region cs-radspreadsheet-howto-customize-selection_1}}

	Brush strokeBrush = new SolidColorBrush(Colors.Green);
	Brush fillBrush = new SolidColorBrush(Colors.GreenYellow);
	fillBrush.Opacity = 0.5;
	
	this.radSpreadsheet.SelectionFill = fillBrush;
	this.radSpreadsheet.SelectionStroke = strokeBrush;
	this.radSpreadsheet.SelectionStrokeThickness = 2;
{{endregion}}

#### **[VB.NET] Example 2: Customizing selection**
{{region vb-radspreadsheet-howto-customize-selection_2}}

	Dim strokeBrush As Brush = New SolidColorBrush(Colors.Green)
	Dim fillBrush As Brush = New SolidColorBrush(Colors.GreenYellow)
	fillBrush.Opacity = 0.5
	
	Me.radSpreadsheet.SelectionFill = fillBrush
	Me.radSpreadsheet.SelectionStroke = strokeBrush
	Me.radSpreadsheet.SelectionStrokeThickness = 2
{{endregion}}


## See Also

 * [Customize Row and Column Headers]({%slug radspreadsheet-howto-customize-row-column-headers%})
