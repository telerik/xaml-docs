---
title: Editing
page_title: Editing
description: The article describes the editing feature of RadCardView.
slug: radcardview-features-editing
tags: editing,cardview
published: True
position: 1
---

# Editing

The data fields in RadCardView's cards can be edited via the UI.

Clicking onto a card will select it and start the edit mode of the first data field. This displays an editor for the data bound value. The editing is started also by clicking on the corresponding data field in the card.

#### Figure 1: Data field in edit mode
![{{ site.framework_name }} RadCardView Data field in edit mode](images/radcardview-features-editing-0.png)

The editing action fires several events that can be used to interfere with the process. Read more in the [Events]({%slug radcardview-events%}#editing) article.

The data fields editor visual element can be customized using the __EditorTemplate__ property of the [CardDataFieldDescriptor]({%slug radcardview-features-datafielddescriptors%}). To customize the entire card while a data field is in edit mode, use the __CardEditTemplate__ property of RadCardView. Read more in the [Customizing Cards]({%slug radcardview-appearance-customizing-cards%}) article.

## See Also
* [Getting Started]({%slug radcardview-getting-started%})
* [Events]({%slug radcardview-events%})
* [Visual Structure]({%slug radcardview-visual-structure%})