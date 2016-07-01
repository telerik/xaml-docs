---
title: Events
page_title: Events
description: Events
slug: radrichtextbox-events-overview
tags: events
published: True
position: 14
---

# Events



This topic covers the specific events exposed by the __RadRichTextBox__ control.
        

The __RadRichTextBox__ control raises the following specific events:
        

* __CommandError__ - occurs when an error gets thrown while executing a command. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * A __CommandErrorEventArgs__ object.
              

* __CommandExecuted__ - occurs after a command gets executed. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * A __CommandExecutedEventArgs__ object. This arguments allows you to access the command to be executed and its command parameter.
    
* __CommandExecuting__ - occurs before a command gets executed. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * A __CommandExecutingEventArgs__ object. This arguments allows you to access the command to be executed and its command parameter and to cancel the command execution.

* __CurrentEditingStyleChanged__ - occurs when the current editing style changes. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * An __EventArgs__ object

* __CurrentParagraphStyleChanged__ - occurs when the position of the caret goes to another paragraph. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * An __EventArgs__ object.
              

* __CurrentSpanStyleChanged__ - occurs when the position of the caret goes to another word. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * An __EventArgs__ object.

* __CurrentVisiblePageChanged__ - occurs when the current page has changed. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * An __EventArgs__ object.
              

* __DocumentArranged__ - occurs when the current document has been arranged. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * An __EventArgs__ object.

* __DocumentChanged__ - occurs when the current document has been changed. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * An __EventArgs__ object.
       
* __DocumentChanging__ - occurs before the current document gets changed. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * An __EventArgs__ object.
              

* __DocumentContentChanged__ - occurs when the content of the current document has changed. This is aggregated event, which is raised not more frequently than the value specified in RadDocument.DocumentContentChangedInterval property for performance reasons. The default value of DocumentContentChangedInterval is 30ms. 
The event handler receives two arguments:

	* The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
	* An __EventArgs__ object.

* __DocumentLayoutModeChanged__ - occurs when the layout mode of the current document has changed. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * An __EventArgs__ object.

* __HyperlinkClicked__ - occurs when the current page has changed. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * A __HyperlinkClickedEventArgs__ object. This argument allows you to access the URL and the target of the hyperlink.

* __IsReadOnlyChanged__ - occurs when __IsReadOnly__ value has changed. The event handler receives two arguments:
     * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
     * An __EventArgs__ object.
              

* __ScaleFactorChanged__ - occurs when the __ScaleFactor__ value has changed. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.
    * An __EventArgs__ object.

* __SelectedLayoutBoxChanged__ - occurs when the current layout box gets changed. The event handler receives two arguments:
    * The sender argument contains the __RadRichTextBox__. This argument is of type object, but can be cast to the __RadRichTextBox__ type.

    * A __SelectedLayoutBoxChangedEventArgs__ object.

# See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})

 * [Styles and Templates]({%slug radrichtextbox-styles-and-tempaltes-overview%})
