---
title: Document Variables
page_title: Document Variables
description: Check our &quot;Document Variables&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-document-variables
tags: document,variables
published: True
position: 2
---

# Document Variables



Document variables provide a mechanism to store information in the document. They also provide a convenient way to define more complicated field constructions (nested fields) and can be used as the backbone of master-detail mail merge.
      

## 

Each RadDocument instance has a dictionary of variables exposed by the __DocumentVariables__ property:
        



```C#
	this.editor.Document.DocumentVariables
```



This collection maps string keys to object values (most often strings). The values of the fields most often are strings again and contain the text that will be inserted in the document when the variable is inserted in the document and is evaluated. Variables can be added to this collection in one of the following ways:
        



```C#
	this.editor.Document.DocumentVariables.Add("Name", "Andrew Fuller");
	this.editor.Document.DocumentVariables["Job"] = "Software Engineer";
```



This code will add two variables to the document – “Name”, which will be evaluated to “Andrew Fuller” and “Job” with a value “Software Engineer”. The second syntax can also be used to modify the value of a variable that has already been added to the collection.

Removing variables from the collection can be done like this:



```C#
	this.editor.Document.DocumentVariables.Remove("Name");
```



Document variables can be inserted in the document using DocumentVariableField. Here is an example how the above created Name variable can be inserted in the current document of the editor:



```C#
	DocumentVariableField docVariable = new DocumentVariableField() { VariableName = "Name" };
	this.editor.InsertField(docVariable);	
```


