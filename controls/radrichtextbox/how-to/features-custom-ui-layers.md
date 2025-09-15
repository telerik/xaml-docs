---
title: Customize Presentation through UI Layers
page_title: Customize Presentation through UI Layers
description: Check our &quot;Customize Presentation through UI Layers&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-custom-ui-layers
tags: customize,presentation,through,ui,layers
published: True
position: 0
---

# Customize Presentation through UI Layers



__UILayers__ provide an extensible approach to showing different parts of __RadRichTextBox__’s Document. For example, there are separate layers showing the comments, the selection, the table borders, etc. 

>note Information about all the different built-in layers you can find in the [UI Layers]({%slug radrichtextbox-features-ui-layers%}) help topic. 
      

The existing layers can be removed and additional ones can be defined to customize the presentation of different parts of the document.
      

## 

All UILayers implement the __IUILayer__ interface. There is an abstract class, which implements this interface - __DecorationUILayerBase__, and by inheriting it, you can easily define a new layer for custom representations of your document’s layout. The main method to contain your logic is:
        

#### __C#__

```C#
	public override void UpdateUIViewPortOverride(UILayerUpdateContext context)
```



You can use the context which is passed as a parameter to the method to get all visible layout boxes and perform your decorations and customizations on them. You can also use the __Document__ property that your decoration layer inherits from __DecorationUILayerBase__ and everything that comes with it (like the current CaretPosition).
        

Last but not least, you should not forget to override the Name property of the layer like this:

#### __C#__

```C#
	public override string Name
	{
	    get
	    {
	        return this.customLayerName;
	    }
	}
```



After having implemented the logic of your custom UI layer, you can plug it in the editor by creating a __CustomUILayerBuilder__ and marking it with the __CustomUILayerAttribute__ like this:
        

#### __C#__

```C#
	[CustomUILayersBuilder]
	public class CustomLayersBuilder : UILayersBuilder
```



In this way, your custom layer will be utilized in all instances of __RadRichTextBox__ in your project. In case you want your layer to be visible only in a few RadRichTextBoxes, you can remove the CustomUILayersBuilder attribute and assign the builder only to the specific instances you want to use it with like this:
        

#### __C#__

```C#
	this.editor.UILayersBuilder = new CustomLayersBuilder();
```



All that is left is to specify the place of your layer, i.e. which layers should be shown above and which - below your layer. This is done in the __BuildUILayersOverride__ method. For example, a layer can be shown under the selection, after the highlighting layer in the following way:
        

#### __C#__

```C#
	protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
	{
	    uiLayerContainer.UILayers.AddAfter(DefaultUILayers.HighlightDecoration, new MyCustomLayer());
	}
```



All these steps have been implemented {% if site.site_name == 'Silverlight' %}at [https://demos.telerik.com/silverlight/#RichTextBox/CustomizePresentation](https://demos.telerik.com/silverlight/#RichTextBox/CustomizePresentation){% endif %}{% if site.site_name == 'WPF' %}in the [ClickOnce demos](https://demos.telerik.com/wpf/) (Inside the application, choose RichTextBox / Customize Presentation){% endif %}, and in a developer-focused [CustomLayerAndCustomAnnotation](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomLayerAndCustomAnnotation) example in our [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser/).
     
## See Also 

* [Built-in UI Layers]({%slug radrichtextbox-features-ui-layers%})