---
title: Insert Documents
page_title: Insert Documents
description: Insert Documents
slug: radwordsprocessing-editing-insert-documents
tags: insert, document, position
published: True
position: 1
---

# Insert Documents

With **RadWordsProcessing**, you have the ability to insert a document into another document at specified position. 

## Inserting Documents at a Specific Position

You could merge documents at a specific position using the InsertDocument() method of the [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}) class. When called, this method inserts the source document at the current editor position. 

* **public void InsertDocument(RadFlowDocument sourceDocument)**

* **public void InsertDocument(RadFlowDocument sourceDocument, InsertDocumentOptions insertOptions)**

	* The *sourceDocument* variable represents the document, which should be inserted (merged) at the specified location.
	
	* [**InsertDocumentOptions**](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Flow_Model_Editing_InsertDocumentOptions.htm): Represents the options, which should be used while inserting is performed. This class contains information about: 
	
		* [**ConflictingStylesResolutionMode**](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Flow_Model_ConflictingStylesResolutionMode.htm): Determines how conflicts between styles should be resolved (rename the style of the source or keep the target settings). The default value is *RenameSourceStyle*.

		* **InsertLastParagraphMarker**: Determines whether the last paragraph marker (last paragraph formatting) should be inserted. If the value is *true*, then a new paragraph with same formatting will be inserted. Otherwise, only the inlines from that paragraph will be inserted. The default value is *true*.

**Example 1** demonstrates how to use the InsertDocument() method.

#### __[C#] Example 1: Insert Source Document into Target Document__

{{region radwordsprocessing-editing-insert-documents_0}}

	InsertDocumentOptions options = new InsertDocumentOptions();
	options.ConflictingStylesResolutionMode = ConflictingStylesResolutionMode.UseTargetStyle;
	options.InsertLastParagraphMarker = true;
	
	RadFlowDocumentEditor editor = new RadFlowDocumentEditor(targetDocument);
	editor.InsertDocument(sourceDocument, options);
{{endregion}}

## Behavior

**Table 1** lists some scenarios where the InsertDocument() method could be used. 

#### Table 1
<table>
	<tr>
		<th>Action</th>
		<th>Result</th>
	</tr>
	<tr>
		<td>Insert the source document in an empty document (without any sections).</td>
		<td>All of the content of the source document will be inserted in the target one. The section properties will be obtained from the source document. </td>
	</tr>
	<tr>
		<td>Insert the source document between runs. Source document contains a single section.</td>
		<td>All of the blocks (Paragraphs and Tables) in the source document’s section will be inserted at the specific location. The section properties will be omitted. This means if the target document page orientation is <i>portrait</i> and the source is <i>landscape</i>, the result document will have <i>portrait</i> orientation. </td>
	</tr>
	<tr>
		<td>Insert the source document between runs. Source document contains multiple sections.</td>
		<td>All of the blocks in the source document’s first section will be inserted at the current editor position. All the next sections from the source document will be inserted as well as separate sections. The last section in the result document will have section properties of the section from the target document where the editor position is when the InsertDocument() method is invoked.</td>
	</tr>
	<tr>
		<td>Insert the source document at the beginning of the target document. Source document contains single section.</td>
		<td>All of the blocks in the source document’s section will be inserted at the specific location. The section properties will be omitted. This means if the target document page orientation is <i>portrait</i> and the source is <i>landscape</i>, the result document will have <i>portrait</i> orientation.</td>
	</tr>
	<tr>
		<td>Insert the source document at the beginning of the target document. Source document contains multiple sections.</td>
		<td>All of the blocks in the source document’s first section will be inserted at the specific location. The whole next sections from the source document will be inserted as well as separate sections. The last section in the result document will have section properties of the insert target section.</td>
	</tr>
	<tr>
		<td>Insert the source document at the end of the target document. Source document contains single section.</td>
		<td>All of the blocks in the source document’s section will be inserted at the specific location. The section properties will be omitted. This means if the target document page orientation is <i>portrait</i> and the source is <i>landscape</i>, the result document will have <i>portrait</i> orientation.</td>
	</tr>
	<tr>
		<td>Insert the source document at the end of the target document. Source document contains multiple sections.</td>
		<td>Same as the above.</td>
	</tr>
	<tr>
		<td>Insert the source document in a table cell.</td>
		<td>An <b>InvalidOperationException</b> is thrown.</td>
	</tr>
	<tr>
		<td>Source document contains no Sections.</td>
		<td>An <b>ArgumentException</b> is thrown.</td>
	</tr>
</table>

# See Also

* [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%})

* [Clone and Merge]({%slug radwordsprocessing-editing-clone-and-merge%})

* [Section]({%slug radwordsprocessing-model-section%})

* [Paragraph]({%slug radwordsprocessing-model-paragraph%})
