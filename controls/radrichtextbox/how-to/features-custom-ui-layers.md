---
title: Customize Presentation through UI Layers
page_title: Customize Presentation through UI Layers
description: Customize Presentation through UI Layers
slug: radrichtextbox-features-custom-ui-layers
tags: customize,presentation,through,ui,layers
published: True
position: 0
---

# Customize Presentation through UI Layers



__UILayers__ provide an extensible approach to showing different parts of __RadRichTextBox__’s Document. For example, there are separate layers showing the comments, the selection, the table borders, etc.
      

The existing layers can be removed and additional ones can be defined to customize the presentation of different parts of the document.
      

## 

All UILayers implement the __IUILayer__ interface. There is an abstract class, which implements this interface - __DecorationUILayerBase__, and by inheriting it, you can easily define a new layer for custom representations of your document’s layout. The main method to contain your logic is:
        

#### __C#__

{{region radrichtextbox-features-custom-ui-layers_0}}
	public override void UpdateUIViewPortOverride(UILayerUpdateContext context)
{{endregion}}



You can use the context which is passed as a parameter to the method to get all visible layout boxes and perform your decorations and customizations on them. You can also use the __Document__ property that your decoration layer inherits from __DecorationUILayerBase__ and everything that comes with it (like the current CaretPosition).
        

Last but not least, you should not forget to override the Name property of the layer like this:

#### __C#__

{{region radrichtextbox-features-custom-ui-layers_1}}
	public override string Name
	{
	    get
	    {
	        return this.customLayerName;
	    }
	}
{{endregion}}



After having implemented the logic of your custom UI layer, you can plug it in the editor by creating a __CustomUILayerBuilder__ and marking it with the __CustomUILayerAttribute__ like this:
        

#### __C#__

{{region radrichtextbox-features-custom-ui-layers_2}}
	[CustomUILayersBuilder]
	public class CustomLayersBuilder : UILayersBuilder
{{endregion}}



In this way, your custom layer will be utilized in all instances of __RadRichTextBox__ in your project. In case you want your layer to be visible only in a few RadRichTextBoxes, you can remove the CustomUILayersBuilder attribute and assign the builder only to the specific instances you want to use it with like this:
        

#### __C#__

{{region radrichtextbox-features-custom-ui-layers_3}}
	this.editor.UILayersBuilder = new CustomLayersBuilder();
{{endregion}}



All that is left is to specify the place of your layer, i.e. which layers should be shown above and which - below your layer. This is done in the __BuildUILayersOverride__ method. For example, a layer can be shown under the selection, after the highlighting layer in the following way:
        

#### __C#__

{{region radrichtextbox-features-custom-ui-layers_4}}
	protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
	{
	    uiLayerContainer.UILayers.AddAfter(DefaultUILayers.HighlightDecoration, new MyCustomLayer());
	}
{{endregion}}



There is a demo where all these steps have been implemented at:{% if site.site_name == 'Silverlight' %}[https://demos.telerik.com/silverlight/#RichTextBox/CustomizePresentation](https://demos.telerik.com/silverlight/#RichTextBox/CustomizePresentation){% endif %}{% if site.site_name == 'WPF' %}[Click-once demos](https://demos.telerik.com/wpf/){% endif %}.
     
