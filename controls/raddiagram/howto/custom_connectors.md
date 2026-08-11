---
title: Using custom connectors in MVVM
page_title: Using custom connectors in MVVM
description: Using custom connectors in MVVM.
slug: raddiagram-using-custom-connectors-in-mvvm
tags: create,custom,shape,connectors,mvvm,graphsource
published: True
position: 18
---

# Using custom connectors in MVVM

This tutorial will guide you through the task of populating RadDiagramShape with custom connectors in MVVM scenario.

To populate the __RadDiagramShape__ with custom connectors in MVVM scenario you can create an attached property. Then bind the value of this property to a collection from your view model. In the property changed callback of the attached property you have access to the shape and its __Connectors__ collection. Using this you can add new connectors to the collection. 

To implement this scenario you can create a collection which holds the custom connectors in your view model.

__Example 1: Creating collection with custom connectors__
<snippet id='raddiagram-howto-custom-connectors-example_1_creating_collection_with_custom_connectors-cs' />


The next step is to create the attached property.

__Example 2: Creating attached property__
<snippet id='raddiagram-howto-custom-connectors-example_2_creating_attached_property-cs' />


Finally, you can create an implicit style and bind the attached property to the custom collection and define a RadDiagram control in the view.

__Example 3: Setting the attached property in XAML__

<snippet id='raddiagram-howto-custom-connectors-example_3_setting_the_attached_property_in_xaml-cs' />


#### __Figure 1: Custom connectors in RadDiagramShape__
![Custom Connectos](images/raddiagram-howto-custom-connectors.PNG)

## See Also
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Use MVVM in RadDiagram]({%slug raddiagrams-howto-mvvm%})
 * [Iterate Over the Diagram Items]({%slug raddiagrams-howto-iterate-over-the-diagram-items%})
