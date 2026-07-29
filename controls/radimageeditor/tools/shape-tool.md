---
title: Shape Tool
page_title: Shape Tool
description: Check our &quot;Shape Tool&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-tools-shape-tool
tags: shape, tool
published: True
position: 
---

# Shape Tool

The Shape Tool is one of the tools, which come out-of-the-box with the __RadImageEditor__ and allow you to draw different shapes over an image.

The tool could be added to the UI of __RadImageEditor__ as shown in __Example 1__.

__Example 1: Add Shape Tool__
<snippet id='radimageeditor-tools-shape-tool-example_1_add_shape_tool-xaml' />


The namespaces that should be registered are as follows:

__Example 2: Register namespaces__
<snippet id='radimageeditor-tools-shape-tool-example_2_register_namespaces-xaml' />


By default, the __ShapeTool__ provides three predefined shapes:

* __Line__: Allows to draw lines only with dragging.

![Rad Image Editor Draw Line Shape](images/RadImageEditor_ShapeTool-01.png)

* __Rectangle__: Draws rectangles or squares (when the __LockRatio__ property is set to true)

![Rad Image Editor Draw Rectangle Shape](images/RadImageEditor_ShapeTool-02.png) 

* __Ellipse__: Allows you to create ellipses or circles (when the __LockRatio__ property is set to true)

![Rad Image Editor Draw Ellipse Shape](images/RadImageEditor_ShapeTool-03.png)

The __Shape Tool__ provides an options to easily customize your shape – you can choose if the shape will be filled with some color or it will consist only of borders, which color and thickness also depends on your preferences. You could take advantage of the __LockRatio__ property, which will ensure that the proportions of the shape will be always the same when resizing.


## How to Create a Custom Shape

You could customize the shapes in the __ShapeTool__ to fit specific requirements. To create a custom shape, the simple __IShape__ interface should be implemented. 


__Example 3: Inherit the IShape interface__
<snippet id='radimageeditor-tools-shape-tool-example_3_inherit_the_ishape_interface-cs' />


__Example 3: Inherit the IShape interface__
<snippet id='radimageeditor-tools-shape-tool-example_3_inherit_the_ishape_interface-vb' />


It exposes two members:

* __string DisplayName__: Тhe name, which will be displayed in the dropdown list.
* __Geometry GetShapeGeometry__: Тhe exact figure.

Example 4 shows a sample implementation of a custom shape.

__Example 4: Implement custom shape__
<snippet id='radimageeditor-tools-shape-tool-example_4_implement_custom_shape-cs' />



__Example 4: Implement custom shape__
<snippet id='radimageeditor-tools-shape-tool-example_4_implement_custom_shape-vb' />


>tip You could download runnable project with Custom Shape from our [SDK repository](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/Drawing)


## Add Custom Shape 

After creating a custom shape, it should be registered in the tool. This could be achieved declaratively as well as in the code behind as shown in __Examples 5 and 6__. You could get or set the shapes in the __ShapeTool__ trough the __Shapes__ collection. 

__Example 5: Add custom shape to the shape tool__
<snippet id='radimageeditor-tools-shape-tool-example_5_add_custom_shape_to_the_shape_tool-cs' />


__Example 5: Add custom shape to the shape tool__
<snippet id='radimageeditor-tools-shape-tool-example_5_add_custom_shape_to_the_shape_tool-vb' />


__Example 5: Add custom shape to the shape tool__
<snippet id='radimageeditor-tools-shape-tool-example_5_add_custom_shape_to_the_shape_tool-xaml' />


## See also

* [Draw Tool]({%slug radimageeditor-tools-drawing%})
* [Crop Tool]({%slug radimageeditor-tools-crop%})