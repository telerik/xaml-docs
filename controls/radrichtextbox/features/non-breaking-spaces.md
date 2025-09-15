---
title: Non-Breaking Spaces
page_title: Non-Breaking Spaces
description: Learn how you can work non-breaking spaces in RadRichTextBox for {{ site.framework_name }}.
slug: radrichtextbox-features-non-breaking-spaces
tags: space, nbsp, non-breaking, insert
published: True
---

# Non-Breaking Spaces

The non-breaking spaces are really useful when you need to ensure that two adjacent words won't be separated on different lines. When calculating the layout of the text, **RadRichTextBox** tries to break the line on a space and to avoid breaking a word. However, it is sometimes needed to ensure that words, separated by spaces, won't appear on different lines. Here come the non-breaking spaces to help you keep adjacent words always on the same line. **RadRichTextBox** supports non-breaking spaces and enables you to insert them through its UI or in code. 

## How to Insert a Non-Breaking Space?

### Keyboard Shortcut in the UI

When editing a document through the UI of RadRichTextBox, you can hold down the **Ctrl** and **Shift** keys as you press the **Spacebar**. This shortcut will insert a non-breaking space.

### Through Code

The API of RadRichTextBox also enables you to insert a non-breaking space. There is a simple method called **InsertNonBreakingSpace** that inserts the special character at the current position of the caret. The method is exposed by the **RadRichTextBox** and **RadDocumentEditor** classes.

#### [C#] Example 1: Insert non-breaking space

```C#

    this.radRichTextBox.InsertNonBreakingSpace();
```


## See Also

 * [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%})
