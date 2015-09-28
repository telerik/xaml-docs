---
title: Import Document Element
page_title: Import Document Element
description: Import Document Element
slug: radwordsprocessing-editing-import-document-element
tags: import, document, element
published: True
position: 3
---

# Import Document Element

This article explains how you could import a document element from one document into another using the API of **RadWordsProcessing**.


## DocumentElementImporter Class

**DocumentElementImporter** class represents a utility class, which is used to import document elements from one document to another. It also handles the style repository merging. 

### Create a DocumentElementImporter

The constructor of the **DocumentElementImporter** class accepts three parameters:

* **targetDocument**: The **RadFlowDocument** instance for which the elements will be prepared for inserting.
* **sourceDocument**: The **RadFlowDocument** from where the elements will be imported.
* **conflictingStylesResolutionMode**: Represents the resolution mode, which will be used if a style conflict appears during the style repositories merging. Could be set to one of the values of the [ConflictingStylesResolutionMode enumeration]( http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Flow_Model_ConflictingStylesResolutionMode.htm).

<a name="example1"><a/>
#### __[C#] Example 1: Create DocumentElementImporter__

{{region radwordsprocessing-editing-import-document-element_0}}

	DocumentElementImporter importer = new DocumentElementImporter(targetDocument, sourceDocument, ConflictingStylesResolutionMode.UseTargetStyle);
{{endregion}}

### Use DocumentElementImporter

The **DocumentElementImporter** class exposes the Import&lt;T&gt;() method, which is used to prepare a document element from the source document for import into the target document. **Example 2** demonstrates how you could work with this method, using the **DocumentElementImporter** instance, created in [Example 1](#example1).

#### __[C#] Example 2: Import a Document Element__

{{region radwordsprocessing-editing-import-document-element_1}}

	Run run = targetDocument.EnumerateChildrenOfType<Run>().First();
	Run importedRun = importer.Import<Run>(run);
{{endregion}}

Now you could insert the imported document element into the target document through the RadFlowDocumentEditor class. How this could be achieved is described [here]({% slug radwordsprocessing-editing-radflowdocumenteditor%}#inserting-document-elements).

### Style Repositories Merging

The merging of the styles between the two documents (target and source) is executed when the Import() method is invoked for the first time.

### Use Cases

In **Table 1** is described the behavior of the Import&lt;T&gt;() method of **DocumentElementImporter** in different scenarios.

#### Table 1
<table>

	<tr>
		<th>Action</th>
		<th>Result</th>
	</tr>

	<tr>
		<td>Invoke Import() method with a document element.</td>
		<td>Returns the document element cloned.</td>
	</tr>

	<tr>
		<td>Invoke Import() method with a paragraph, which contains unpaired annotation marker <i>(e.g. there is a Bookmark, which is spanned between two paragraphs, one of which is passed as a parameter)</i>.</td>
		<td>Returns the paragraph and all its inlines cloned. <b>The unpaired annotation marker is cleared.</b></td>
	</tr>

	<tr>
		<td>Invoke Import() method with a section, which contains paragraphs which contain by their side unpaired annotations <i>(e.g. there is a Bookmark, which is spanned between two paragraphs and their parent section is passed as a parameter)</i>.</td>
		<td>Returns the section and all its children cloned. The annotation markers are not cleared.</td>
	</tr>

	<tr>
		<td>Invoke Import() method with a paragraph, which has a style, renamed during the styles merging.</td>
		<td>Returns the paragraph and all its children cloned with the correctly renamed StyleId property.</td>
	</tr>

	<tr>
		<td>Invoke Import() method with a paragraph, which has a style, renamed during the styles merging multiple times.</td>
		<td>Returns the paragraph and all its children cloned with the correctly renamed StyleId property.</td>
	</tr>

	<tr>
		<td>Invoke Import() method with a document element, which is not a child of the source document.</td>
		<td>Throws an <b> InvalidOperationException</b>.</td>
	</tr>

</table>

# See Also

* [Document Model]({%slug radwordsprocessing-model%})

* [Clone and Merge]({%slug radwordsprocessing-editing-clone-and-merge%})