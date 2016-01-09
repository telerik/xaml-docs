---
title: Disable IEditableObject Support
page_title: Disable IEditableObject Support
description: Disable IEditableObject Support
slug: radgridview-managing-data-how-to-disable-ieditableobject-support
tags: disable,ieditableobject,support,data,engine
published: True
position: 1
---

# Disable IEditableObject Support in the RadGridView Data Engine
<<Comment: If the property you are introducing is called ShouldRespectIEditableObject, why doesn't this name appear in the title, description or the heading 1 for the page? I think the SEO would be better if you did. Also, for better SEO, RadGridView and data engine should also appear in the description. Finally, for SEO, I think you should try to avoid using 's to make a key SEO word posessive. More people will type RadGridView Data Engine into a search query than RadGridView's Data Engine.>> 
As of Q1 2016, we've introduced the **ShouldRespectIEditableObject** property. The default value is **True**. Setting it to false will prevent the RadGridView Data Engine from calling the [**IEditableObject**](https://msdn.microsoft.com/en-us/library/system.componentmodel.ieditableobject(v=vs.110).aspx) methods - **BeginEdit()**, **CancelEdit()** and **EndEdit()**.
<<Comment: I assume Data Engine is two words because you used it that way earlier. If it is one word, change the tag and the H1 to match. Also, why do you have **True** for one value and false (not capitalized, not bold) elsewhere? Generally the doumentation should standardize on one and then discuss it with the team and write the convention down somewhere that others will look. >>
>Setting **ShouldRespectIEditableObject** to false will only prevent the IEditableObject methods of the object implementing the interface. RadGridView's **BeginEdit()**, **CancelEdit()** and **EndEdit()** methods will still be executed and the respective [events]({%slug gridview-events-edit%}) will be raised.

#### __[XAML] Example 1: Setting ShouldRespectIEditableObject__

{{region gridview-disable-ieditableobject-support_0}}

	<telerik:RadGridView Name="gridView" ShouldRespectIEditableObject="False">
{{endregion}}

## See Also

 * [Events - Edit]({%slug gridview-events-edit%})

 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})
