---
title: Styling the Column Footers
page_title: Styling the Column Footers
description: Styling the Column Footers
slug: gridview-styling-column-footers
tags: styling,the,column,footers
published: True
position: 9
---

# Styling the Column Footers


>tipBefore reading this topic, you might find useful to get familiar with the [Template Structure of the GridViewFooterCell control]({%slug radgridview-styles-and-templates-templates-structure%}).

__RadGridView's Footer Cells__can be styled by creating an appropriate __Style__ and setting it to the __FooterCellStyle__ property of the __GridViewColumns__. 

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

>__GridViewFooterCell__ control is located in the __Telerik.Windows.Controls.GridView__ namespace of the __Telerik.Windows.Controls.GridView__ assembly. 

When working in Expression Blend, the namespaces that are needed will be added automatically.

Load your project in Expression Blend and open the User Control that holds the __RadGridView__. You have to use a dummy control in order to get the default style. To create one find the __GridViewFooterCell__ control in the 'Assets' and draw one on the art board. In the 'Objects and Timeline' pane select the __GridViewFooterCell,__you've drawn and from the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __GridViewFooterCell__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __GridViewFooterCell.__Their names indicate to which part of the __GridViewFooterCell__appearance they are assigned.{% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadGridView_Styles_and_Templates_Styling_GridViewColumnFooterCell_01.png){% endif %}

* __GridViewFooterCellTemplate__ - the __ControlTemplate__, applied to the __GridViewFooterCell__ control.

* __ControlOuterBorder__ - a brush that represents the color of the outer border of the footer.

* __GridViewFooterCellStyle__ - the __Style__, applied to the __GridViewFooterCell__ control.

To apply the style to the real footers, set it to the __FooterCellStyle__ property of __RadGridView's__ columns.

#### __XAML__

{{region gridview-styling-column-footers_1}}

	<telerik:GridViewDataColumn Header="ID"
                                DataMemberBinding="{Binding EmployeeID}"
                                Footer="ID"
                                FooterCellStyle="{StaticResource GridViewFooterCellStyle}" />
{{endregion}}


>Don't forget to delete the dummy __GridViewFooterCell__ control, when you finish editing the style.{% if site.site_name == 'Silverlight' %}

Here is an example of the described resources modified.{% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadGridView_Styles_and_Templates_Styling_GridViewColumnFooterCell_02.png){% endif %}{% if site.site_name == 'Silverlight' %}

And here is a snapshot of the result.{% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadGridView_Styles_and_Templates_Styling_GridViewColumnFooterCell_03.png){% endif %}

# See Also

 * [Styling a Cell]({%slug gridview-styling-cell%})

 * [Styling the Column Headers]({%slug gridview-styling-column-headers%})
