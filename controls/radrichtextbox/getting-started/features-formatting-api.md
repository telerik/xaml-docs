---
title: Formatting API
page_title: Formatting API
description: Check our &quot;Formatting API&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-formatting-api
tags: formatting,api
published: True
position: 4
---

# Formatting API



If you want to format the content of __RadRichTextBox__ at run time, you have to use the API exposed by __RadRichTextBox__. This is essential, as the main purpose of __RadRichTextBox__ is to allow the users to format their input via UI. The UI should call the respective API methods of the control.
      

>To learn more about the methods exposed by the API take a look at {% if site.site_name == 'WPF' %}[this topic](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_controls_radrichtextbox.html){% endif %}{% if site.site_name == 'Silverlight' %}[this topic](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_controls_radrichtextbox.html){% endif %}.
        

## Changing the text formatting

The __RadRichTextBox__ exposes methods that change the style of the selected text or the paragraph. When a method is called, the respective style is applied to the selected text. If there is no selection available, the style is applied to the word in which the caret is located.
        

>tip RadRichTextBox provides a fully functional formatting UI out of the box. To learn more about it read the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) topic.
          

Here is an example of a toggle button that upon checking should make the selection or the current word bold. In the handler of the __Click__ event of the __RadToggleButton__, the __ToggleBold()__ method of __RadRichTextBox__ is called.
        



<snippet id='radrichtextbox-getting-started-features-formatting-api-block_1-xaml' />





<snippet id='radrichtextbox-getting-started-features-formatting-api-block_2-cs' />
<snippet id='radrichtextbox-getting-started-features-formatting-api-block_3-vb' />

![{{ site.framework_name }} RadRichTextBox Bolded Text](images/RadRichTextBox_Formatting_01.png)

## Using the active editor

__RadRichTextBox__ supports headers and footers. They are represented through separate instances of  __RadRichTextBox__. When a document has headers and footers you can use the __ActiveDocumentEditor__ property           of __RadRichTextBox__ to get the editor instance where the caret is currently situated.
        

>tip You can find more about the Header and Footer functionality in [this article]({%slug radrichtextbox-features-headers-and-footers%}).
          

The following example inserts the word "text" at the CaretPosition.



<snippet id='radrichtextbox-getting-started-features-formatting-api-block_4-cs' />
<snippet id='radrichtextbox-getting-started-features-formatting-api-block_5-vb' />



## Creating a DocumentFragment

One of the common uses of the API is creating and inserting a __DocumentFragment__. Currently you can create a fragment in two ways:
        

* through __DocumentFragment__'s constructor;
            

* through selection.
            

Both approaches can be used to insert content at the caret position with the __InsertFragment__ method:
        



<snippet id='radrichtextbox-getting-started-features-formatting-api-block_6-cs' />

### Using the constructor of DocumentFragment

If you create a fragment in this way, it will end with a new paragraph. This is convenient when you want to separate the inserted fragment and end it with a new line. Furthermore, in this way if the last paragraph is in a list, it will appear properly in the new document.



<snippet id='radrichtextbox-getting-started-features-formatting-api-block_7-cs' />
<snippet id='radrichtextbox-getting-started-features-formatting-api-block_8-vb' />



This is also the suggested approach when merging several documents into one.

### Using the selection

If you choose to use the document selection when creating a __DocumentFragment__, there will be no additional paragraph after the fragment.
            



<snippet id='radrichtextbox-getting-started-features-formatting-api-block_9-cs' />
<snippet id='radrichtextbox-getting-started-features-formatting-api-block_10-vb' />


>For merging RadDocument instances, you can use the [RadDocumentMerger class]({%slug radrichtextbox-features-merge-raddocumentmerger%}).

## See Also

 * [Import/Export]({%slug radrichtextbox-features-import-export%})
 * [RadDocumentMerger]({%slug radrichtextbox-features-merge-raddocumentmerger%})