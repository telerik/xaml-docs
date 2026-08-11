---
title: Templates Structure
page_title: Templates Structure
description: Check our &quot;Templates Structure&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-styles-and-templates-templates-structure
tags: templates,structure
published: True
position: 1
---

# Templates Structure

Like most UI controls, RadPropertyGrid allows you to template it in order to change the control from inside. Except for templating the whole control, you can template parts of it or even independent controls related to it. This topic will make you familiar with: 

* [RadPropertyGrid Template Structure](#radpropertygrid-template)

* [PropertyGridField Template Structure](#propertygridfield-template)

>tip For more information about templating and how to modify the default templates read the common topic on [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}).

Using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to easily extract and edit the default ControlTemplates of the controls. You can follow [this article]({%slug styling-apperance-editing-control-templates%}) on two different approaches on how to extract the ControlTemplates.

## RadPropertyGrid Template

* __PART_RootElement__ - hosts the elements of the template. It represents the border of the RadPropertyGrid and is of type Border;

* __PART_PropertyGridContainer__- hosts the description panel, the items scroll viewer and the header;

* __PART_DescriptionPanel__- hosts the elements of RadPropertyGrid’s DescriptionPanel. It represents the border of this panel and is of type Border;

* __StackPanel__ - represents the DescriptionPanel and is of type StackPanel;

* __TextBlock__- represents the DisplayName of the Selected property definition;

* __TextBlock__ – represents the Description of the Selected property definition;

* __[Border]__ - represents the outer border of the ScrollViewer and is of type Border;

* __PART_ItemsScrollViewer__ - represents the control that handles the different types of presenters and is of type Border;

* __PropertyGridPresenter__-responsible for displaying PropertyGridFields and is of type PropertyGridPresenter;

* __Header__ - represents the outer border of the header and is of type Border;

* __[Border]__ - represents the inner border of the header and is of type Border;

* __[Grid]__ - hosts the elements of the Header of the header and is of type Grid;

* __[Path]__

* __SearchAsYouTypeTextBox__- represents the RadPropertyGrid’s SearchBox and is of type TextBox.

* __SortButton__- represents the RadPropertyGrid’s Sort Button and is of type RadRadioButton

* __GroupButton__- represents the RadPropertyGrid’s Group Button and is of type RadRadioButton
![{{ site.framework_name }} RadPropertyGrid Template Structure](images/RadPropertyGrid_RadProperyGridTemplate.png)

## PropertyGridField Template

* __PART_RootElement__ - hosts the elements of the template. It represents the border of the DataFormDataField and is of type Border;

* __PART_PropertyGridFieldGrid__ - provides columns for the template elements. It represents the background of the DataFormDataField and is of type Grid;

* __ColumnResizer__ - represents the PropertyGridField’s resizer and is of type Thumb;

* __[Border]__- represents the border around PropertyGridFields’s editor and is of type Border;

* __[ContentPresener]__ - displays the content and is of type ContentPresenter;

* __[Border]__- represents the border around PropertyGridFields’s TextBlock and is of type Border;

* __[TextBlock]__- displays the PropertyGridField’s DisplayName and is of type TextBlock;

* __[Border]__- represents the outer border of PropertyGridFields’s Indent and is of type Border;

* __[Border]__- represents the background of PropertyGrid’s Indent and is of type Border;

* __Background_Over__ - represents the outer border of the field, when the mouse is over it and is of type Border;

* __[Border]__ - represents the inner border and the background of the row, when the mouse is over it and is of type Border;

* __SelectionBackground__- represents the outer border of the field, when it is selected and is of type Border;

* __[Border]__ - represents the inner border and the background of the row, when the mouse is over it and is of type Border.

![{{ site.framework_name }} RadPropertyGrid PropertyGridField Template Structure](images/RadPropertyGrid_PropertyGridFieldTemplate.png)

## Modifying RadPropertyGrid Template with Blend

When extracting the control template with MS Blend some dependency properties of controls that are defined in DataTemplates, does not have their values extracted correctly. You have two options:

* Manually extract the template template from the Themes.Implicit files we ship with every installation. You can find it together with all the other templates used for the PropertyGrid inside "Telerik.Windows.Controls.Data.xaml" file browsing to "C:\Program Files (x86)\Progress\Telerik UI for [product][version]\Themes.Implicit\OfficeBlack\Themes" folder. Please note there is a different folder for each Theme and you should browse to the one you use.
            
*  Extract the template with Blend and manually add the missing __ItemsSource Bindings__ for the ItemsControl defined for the four templates.
You can find instructions on how to fix the missing Bindings bellow:
              
*  Under __FlatRenderingTemplate__:

<snippet id='radpropertygrid-styles-and-templates-templates-structure-block_1-xaml' />

*   Under __FlatTemplate__:

<snippet id='radpropertygrid-styles-and-templates-templates-structure-block_2-xaml' />

*  Under __GroupTemplate__:

<snippet id='radpropertygrid-styles-and-templates-templates-structure-block_3-xaml' />

*  Under __VirtualizedFlatTemplate__:

<snippet id='radpropertygrid-styles-and-templates-templates-structure-block_4-xaml' />

Using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to easily extract and edit the default ControlTemplates of the controls. You can follow [this article]({%slug styling-apperance-editing-control-templates%}) on two different approaches on how to extract the ControlTemplates.