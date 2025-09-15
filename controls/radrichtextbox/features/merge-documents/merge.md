---
title: Insert Document at Caret Position
page_title: Insert Document at Caret Position
description: Check our &quot;Insert Document at Caret Position&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-merge-insert-document
tags: raddocumentmerger, merge, insert, documents
published: True
---

# Insert Document at Caret Position

The [RadDocumentMerger]({%slug radrichtextbox-features-merge-raddocumentmerger%}) class exposes the **InsertDocument()** method that enables you to merge two [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%}) instances. The documents will be merged at the caret position of the targeted instance.

Along with the [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%}) instance, the overloads of the InsertDocument() method allow you to pass a parameter of type **InsertDocumentOptions**. You can use this parameter to customize the way merge conflicts are resolved and the new document is inserted. The available properties are as follows:

* **ConflictingStylesResolutionMode**: Determines the mode of resolving conflicts between styles with the same IDs. This property is of type ConflictingStylesResolutionMode and can have the following enum values:

	* **UseTargetStyle**: The style of the target document is used. For example, if the target and source documents have a style with a name "MyStyle", but with different properties, the one from the target is used by the merged document and the one from the source document is not added to the style repository of the target document.
	
	* **RenameSourceStyle**: The style of the source document is renamed and used. For example, if the target and source documents have a style with a name "MyStyle", but with different properties, the one from the source is renamed "MyStyle\_1", added to the style repository of the target document and used by the merged document from the source document elements. *This is the default value*.

* **InsertLastParagraphMarker**: A Boolean property that determines whether the last paragraph marker is inserted and, subsequently, whether the last paragraph's formatting is preserved. When the value is **True**, a new paragraph with the same formatting is inserted. Otherwise, only the inlines from that paragraph are inserted. *The default value is **True***.

#### **[C#] Example 1: Merge documents with InsertDocumentOptions**

```C#
 
	InsertDocumentOptions options = new InsertDocumentOptions();
	options.ConflictingStylesResolutionMode = ConflictingStylesResolutionMode.UseTargetStyle;
	options.InsertLastParagraphMarker = false;
	
	merger.InsertDocument(sourceDocument, options);
```

There is another overload of InsertDocument() that takes only a [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%}) instance. When you use this overload, the default values of InsertDocumentOptions are used when merging documents.  

## Behavior

**Table 1** describes the most common scenarios in which the InsertDocument() method can be used and what the result of a merge would be.

#### **Table 1: Behavior of the InsertDocument() method in different scenarios**
<table>
<tr>
	<th>Action </th>
	<th>Result </th>
</tr>

<tr>
	<td>Insert the source document in an empty document.</td>
	<td>All of the content from the source document is inserted in the target document. The section properties are obtained from the source document.</td>
</tr>

<tr>
	<td>Insert the source document between spans. Source document contains a single section.</td>
	<td>All of the blocks (Paragraphs and Tables) in the source document’s section are inserted at the specific location. The section properties are omitted. For example, if the target document's page orientation is portrait and the source is landscape, the result document will have portrait orientation.</td>
</tr>

<tr>
	<td>Insert the source document between spans. Source document contains multiple sections.</td>
	<td>All blocks from the source document’s first section are inserted at the current editor position. All subsequent sections from the source document are inserted as separate sections. The section properties of the last section in the result document are the ones of the section from the target document where the CaretPosition is at the time the InsertDocument() method is invoked.</td>
</tr>

<tr>
	<td>Insert the source document at the beginning of the target document. Source document contains a single section.</td>
	<td>All blocks from the source document’s section are inserted at the specific location. The section properties are omitted. If the target document's page orientation is portrait and the source is landscape, the result document will have portrait orientation.</td>
</tr>

<tr>
	<td>Insert the source document at the beginning of the target document. Source document contains multiple sections.</td>
	<td>All blocks from the source document’s first section are inserted at the specific location. All subsequent sections from the source document are inserted as separate sections. The section properties of the last section in the result document are the ones of the target document’s section in which the source was inserted.</td>
</tr>

<tr>
	<td>Insert the source document at the end of the target document. Source document contains a single section.</td>
	<td>All blocks from the source document’s section are inserted at the specific location. The section properties are omitted. If the target document's page orientation is portrait and the source document's is landscape, the result document will have portrait orientation.</td>
</tr>

<tr>
	<td>Insert the source document at the end of the target document. Source document contains multiple sections.</td>
	<td>Same as the above.</td>
</tr>

<tr>
	<td>Insert the source document in a table cell and source document contains multiple sections.</td>
	<td>An InvalidOperationException is thrown.</td>
</tr>

<tr>
	<td>Source document is empty.</td>
	<td>An ArgumentException is thrown.</td>
</tr>

</table>


## See Also

 * [RadDocumentMerger]({%slug radrichtextbox-features-merge-raddocumentmerger%})
 * [Append Document]({%slug radrichtextbox-features-merge-append-documents%})
 * [Using RadRichTextBox's formatting API ]({%slug radrichtextbox-features-formatting-api%})
