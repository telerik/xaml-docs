---
title: Styling the Column Headers
page_title: Styling the Column Headers
description: Styling the Column Headers
slug: gridview-styling-column-headers
tags: styling,the,column,headers
publish: True
position: 6
---

# Styling the Column Headers



>tipBefore reading this topic, you might find useful to get familiar with the 
      [Template Structure of the GridViewHeaderCell control](2CD6EAA0-C735-4FA2-B921-A0D1A4452C10#GridViewHeaderCell).

The __RadGridView Header Cells__can be styled by creating an appropriate __Style__ and setting it to the __HeaderCellStyle__ property of the __GridViewColumns__. 

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

>

The __GridViewHeaderCell__ control is located in the __Telerik.Windows.Controls.GridView__ namespace of the __Telerik.Windows.Controls.GridView__ assembly. 

When working in Expression Blend, the namespaces that are needed will be added automatically.

Load your project in Expression Blend and open the User Control that holds the __RadGridView__. You have to use a dummy control in order to get the default style. To create one find the __GridViewHeaderCell__ control in the 'Assets' and draw one on the art board. In the 'Objects and Timeline' pane select the __GridViewHeaderCell__that you've drawn and from the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __GridViewHeaderCell__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __GridViewHeaderCell.__Their names indicate to which part of the __GridViewHeaderCell__appearance they are assigned.{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadGridView_Styles_and_Templates_Styling_GridViewHeaderCell_01.png){% endif %}

* __GridView_HeaderInnerBorder__ - a brush that represents the outer border color of the header.

* __GridView_HeaderOuterBorder_Over__ - a brush that represents the outer border color of the header, when the mouse is over it.

* __GridView_HeaderBackground_Over__ - a brush that represents the background color of the header, when the mouse is over it.

* __GridView_HeaderInnerBorder_Over__ - a brush that represents the inner border color of the header, when the mouse is over it.

* __GridView_HeaderOuterBorder_Selected__- a brush that represents the outer border color of the header, when it is selected.

* __GridView_HeaderBackground_Selected__ - a brush that represents the background color of the header, when it is selected.

* __GridView_HeaderInnerBorder_Selected__ - a brush that represents the inner border color of the header, when it is selected.

* __GridView_SortIndicatorColor__ - a brush that represents the background color of the sort indicator.

* __ColumnHeaderGripperStyle__ - the __Style__ applied to the __ColumnHeaderGripper__ control.

* __GridView_HeaderForeground_Selected__ - a brush that represents the foreground color of the header, when the mouse is over it and when it is selected.

* __GridViewHeaderCellTemplate__ - the __ControlTemplate__, applied to the __GridViewCell__.

* __GridView_HeaderBackground__ - a brush that represents the background color of the header.

* __GridView_HeaderOuterBorder__ - a brush that represents the outer border color of the header.

* __GridView_HeaderForeground__ - a brush that represents the foreground color of the header.

* __GridViewHeaderCellStyle__ - the __Style__, applied to the __GridViewHeaderCell__ control.

To apply the style to the real headers, set it to the __HeaderCellStyle__ property of the __RadGridView__ columns.

#### __XAML__

{{region gridview-styling-column-headers_1}}
	<telerik:GridViewDataColumn Header="ID"
	                                DataMemberBinding="{Binding EmployeeID}"
	                                HeaderCellStyle="{StaticResource GridViewHeaderCellStyle}" />
	{{endregion}}



>

Don't forget to delete the dummy __GridViewHeaderCell__ control, when you finish editing the style.{% if site.site_name == 'Silverlight' %}

Here is an example of the described resources modified.{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadGridView_Styles_and_Templates_Styling_GridViewHeaderCell_02.png){% endif %}

And here is a snapshot of the result.{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadGridView_Styles_and_Templates_Styling_GridViewHeaderCell_03.png){% endif %}

# See Also

 * [Styling a Cell]({%slug gridview-styling-cell%})

 * [Styling the Column Footers]({%slug gridview-styling-column-footers%})
