---
title: How to left align the text of the ComboBoxItem when it is too long
page_title: How to align to the left the text of the ComboBoxItem when it is too long
description: How to align to the left the text of the ComboBoxItem when it is too long.
slug: radcombobox-how-to-align-to-the-left-the-text-of-the-comboboxitem-when-it-is-too-long2
tags: how,to,align,to,the,left,the,text,of,the,comboboxitem,when,it,is,too,long
published: True
position: 10
---

# {{ site.framework_name }} RadComboBox How to left align the text of the ComboBoxItem when it is too long

If the text in a __RadComboBoxItem__ is longer than the width of the ComboBox itself and the ComboBox is in editable mode, when you focus __RadComboBox__ it selects all of its text and the cursor is at the end of the word for easy edition. 

![{{ site.framework_name }} RadComboBox with Cursor at End](images/ComboSelection.jpg)

To make it left aligned and remove the selection you can set the __SelectAllTextEvent__ property of the ComboBox to __None__.

>The described approach is only available if the selection is done via mouse click or keyboard navigation. If an item is selected by the __AutoComplete__ functionality of the control the text will not be aligned to the left.

![{{ site.framework_name }} RadComboBox with Cursor at Beginning](images/ComboSelection_2.jpg)

## See Also

 * [Setting up AutoComplete]({%slug radcombobox-setting-up-autocomplete%})

 * [Set MaxLength Property of the Input Area]({%slug radcombobox-howto-set-max-length-input-area%})
