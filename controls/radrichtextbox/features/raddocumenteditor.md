---
title: RadDocumentEditor
page_title: RadDocumentEditor
description: Check our &quot;RadDocumentEditor&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-raddocumenteditor
tags: raddocumenteditor
published: True
---

# RadDocumentEditor



__RadDocument__ has an [API](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.raddocument) of its own, but using it has a set of limitations. First of all, adding and removing Blocks and Inlines from the document can be done only before the document has been measured – a procedure that calculates the desired size of the spans, paragraphs and the document altogether in order to calculate its layout. These operations are usually invoked by the framework when the document in shown in a __RadRichTextBox__. However, some of the methods of __RadDocument__ and __RadRichTextBox__ require that the document be measured before their execution, so if such a method is invoked, the document will be measured. Then, adding Paragraphs, Tables, Sections and Spans will break the structure of the document.
      

Another issue that the use of the methods of __RadDocument__ causes is due to the fact that they are not registered in the undo/redo stack. Thus, once such a method is used, the history stack is cleared and users will no longer be able to undo and redo their previous changes.
      

## What is RadDocumentEditor

On the other hand, __RadRichTextBox__ provides a much richer [API](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.radrichtextbox) for editing the __RadDocument__ instance in it. All respective methods from that API are located in the [IDocumentEditor](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.idocumenteditor) interface which defines all method that edit fields, annotation ranges, document elements, history, headers and footers and so on and is inherited from __RadRichTextBox__. In that regard, if you are modifying the document in a class that knows of the existence of __RadRichTextBox__, you can use the methods of __RadRichTextBox__ in order to manipulate the document in a way transparent to the end user.
        

The appropriate API, however, should be available in cases when you want to modify a document from code without having a __RadRichTextBox__. For this purpose, a __RadDocumentEditor__ class has been introduced. It also implements the __IDocumentEditor__ interface and includes all relevant methods of __RadRichTextBox__ for manipulating the document programmatically.
        

## How to use RadDocumentEditor

When a __RadDocument__ instance was for some reason created from code – built using the elements hierarchy or imported, it can be passed to a __RadDocumentEditor__ like this:
        

#### __C#__

{{region radrichtextbox-features-raddocumenteditor_0}}
	RadDocumentEditor documentEditor = new RadDocumentEditor(document);
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-raddocumenteditor_0}}
	Dim documentEditor As New RadDocumentEditor(document)
{{endregion}}



The newly created *documentEditor* instance now provides all capabilities that a __RadRichTextBox__ provides. Moreover, you can group several methods so that they are added to the Undo/Redo stack as a single item. This can be achieved like this:
        

#### __C#__

{{region radrichtextbox-features-raddocumenteditor_1}}
	documentEditor.BeginUndoGroup();

	if (documentEditor.Document.CaretPosition.IsPositionInsideTable)
	{
		documentEditor.InsertTableRow();
		documentEditor.InsertTableRow();
		documentEditor.InsertTableRow();
		documentEditor.Document.Selection.Clear();
	}
	
	documentEditor.EndUndoGroup("Insert three table rows");
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-raddocumenteditor_1}}
	documentEditor.BeginUndoGroup()
	
	If documentEditor.Document.CaretPosition.IsPositionInsideTable Then
		documentEditor.InsertTableRow()
		documentEditor.InsertTableRow()
		documentEditor.InsertTableRow()
		documentEditor.Document.Selection.Clear()
	End If
	
	documentEditor.EndUndoGroup("Insert three table rows")
{{endregion}}



You can also cancel the execution of the undo group, and it won't be recorded in the history:

#### __C#__

{{region radrichtextbox-features-raddocumenteditor_2}}
	documentEditor.BeginUndoGroup();

	if (documentEditor.Document.CaretPosition.IsPositionInsideTable)
	{
		documentEditor.InsertTableRow();
		documentEditor.InsertTableRow();
		documentEditor.InsertTableRow();
		documentEditor.Document.Selection.Clear();
	}
	
	documentEditor.CancelUndoGroup();
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-raddocumenteditor_2}}
	documentEditor.BeginUndoGroup()
	
	If documentEditor.Document.CaretPosition.IsPositionInsideTable Then
		documentEditor.InsertTableRow()
		documentEditor.InsertTableRow()
		documentEditor.InsertTableRow()
		documentEditor.Document.Selection.Clear()
	End If
	
	documentEditor.CancelUndoGroup()
{{endregion}}



One thing to note here is that it is not possible to remove some actions from the undo history altogether, i.e. you cannot perform an action without it getting registered in the Undo/Redo stack. In most cases, however, this is sufficient, as you can group the operations that you do not want to name and show explicitly to the end user with the ones that have been user-initiated and are expected by the person modifying the content of __RadRichTextBox__.
    
## RadDocuemtnEditor methods

### Annotations realated

|__Method__|__Description__|
|---|---|
|InsertAnnotationRange(AnnotationRangeStart rangeStart, AnnotationRangeEnd rangeEnd)| Inserts an annotation range over the current selection. If the selection is empty, the annotation range is inserted at the caret position.|
|SplitAnnotationRange(AnnotationRangeStart rangeStart)|Splits an annotation range at the caret position, resulting in two new ranges.|
|SplitAnnotationRange(AnnotationRangeStart rangeStart, DocumentPosition position)|Splits an annotation range at the specified position, resulting in two new ranges.|
|DeleteAnnotationRange(AnnotationRangeStart rangeStart)|Deletes an annotation range.|
|InsertBookmark(string bookmarkName)|Inserts a bookmark around the current selection. If the selection is empty, the bookmark is inserted at the caret position.|
|InsertBookmark(string bookmarkName)|Deletes the bookmark with the specifies name.|
|DeleteBookmark(BookmarkRangeStart bookmarkRangeStart)|Deletes the bookmark with the specifies start range|
|InsertComment(Comment comment)|Inserts a comment around the current selection. If the selection is empty, the comment is inserted at the caret position.|
|DeleteComment()|Deletes the comment at the caret postion.|
|DeleteAllComments()|Deletes all comments in the document.|
|InsertPermissionRange(IEnumerable<PermissionRangeInfo> permissionInfos)|Inserts a new permission range over the current selection. If the selection is empty, the permission range is inserted at the caret position.|
|DeletePermissionRange(PermissionRangeStart permissionRangeStart)|Deletes a permission range.|
|UpdatePermissionRanges(IEnumerable<PermissionRangeInfo> permissionsToAdd, IEnumerable<PermissionRangeInfo> permissionsToRemove)|Updates the permissions inside the current selection.|
|InsertReadOnlyRange()|Inserts a read only range over the current selection. If the selection is empty noting is inserted.|
|DeleteReadOnlyRange()|Deletes the read only range at the current caret position or inside the current selection.|
|DeleteReadOnlyRange(ReadOnlyRangeStart readOnlyRangeStart)|Deletes read only range.|
|InsertFootnote()|Inserts footnote at the current position.|
|InsertFootnote(Note footnote)|Inserts the passed footnode.|
|InsertEndnote()|Inserts endnote at the current position.|
|InsertEndnote(Note endnote)|Inserts the passed endnode.|
|InsertHyperlink(HyperlinkInfo hyperlinkInfo)|Inserts a hyperlink in the document. The hyperlink will be created around the current selection.|
|InsertHyperlink(HyperlinkInfo hyperlinkInfo, string hyperlinkText)|Inserts a hyperlink with spesific text into the document.|
|DeleteHyperlink()|Deletes the current hyperlink.|
|DeleteHyperlink(HyperlinkRangeStart hyperlinkRangeStart)|Deletes a hyperlink with the specifies start element.|
|PreviewFirstMailMergeDataRecord()|Updates all fields in the document with the values evaluated using the first data record.|
|PreviewLastMailMergeDataRecord()|Updates all fields in the document with the values evaluated using the last data record.|
|PreviewPreviousMailMergeDataRecord()|Updates all fields in the document with the values evaluated using the previous data record.|
|PreviewNextMailMergeDataRecord()|Updates all fields in the document with the values evaluated using the next data record.|
|PreviewMailMergeDataRecordAtIndex(int index)| Updates all fields in the document with the values evaluated using a specified data record.|
|MailMergeCurrentRecord()|Creates a new RadDocument" containing the result of merging the template with the values of the current data record.|
|MailMerge(bool startEachRecordOnNewPage)|Produces a mail merged document containing the results for all data records.|
|AcceptRevision(Revision revision)|Accepts a revision.|
|RejectRevision(Revision revision)|Rejects a revision.|
|AcceptAllRevisions()|Accepts all revisions in the document.|
|RejectAllRevisions()|Rejects all revisions in the document.|


### Editing realated

|Method|Description|
|---|---|
| InsertFragment(DocumentFragment documentFragment) | Inserts a fragment at the current caret position. |
| InsertFragment(DocumentFragment documentFragment, DocumentPosition documentPosition) | Inserts a fragment at a specified position. Document selection should be cleared in advance. |
| Insert(string text) | Inserts text into the document at the current caret position. |
| InsertImage(Stream imageStream, string extension) | Inserts an inline image into the document at the current caret position. |
| InsertInline(Inline inline) | Inserts inline element into the document at the current caret position. |
| InsertInline(Inline inline, DocumentPosition documentPosition) | Inserts inline element into the document at a specified caret position. Document selection should be cleared in advance. |
| InsertParagraph() | Inserts a new paragraph at the current caret position. |
| InsertLine(string text) | Inserts text at the current caret position and adds a new paragraph after it. |
| InsertLineBreak() | Inserts a line break into the document at the current caret position. |
| InsertPageBreak() | Inserts a page break into the document at the current caret position. |
| InsertColumnBreak() | Inserts a column break into the document at the current caret position. |
| InsertNonBreakingSpace() | Inserts a non-breaking space into the document at the current caret position. |
| InsertSectionBreak() | Inserts a section break into the document at the current caret position. |
| InsertSectionBreak(SectionBreakType sectionBreakType) | Inserts a section break of the specified type into the document at the current caret position. |
| InsertCodeBlock(string code, CodeFormattingSettings settings) | Inserts a code block at the caret position. If the caret position is in code block, replaces the current code block. |
| Delete(bool deletePrevious) | Deletes content from the document. If the Selection is not empty, deletes the selected content. Otherwise, deletes the character next to the CaretPosition. |
| DeleteTable() | Deletes the table the current caret position is in. |
| DeleteTable(Table table) | Deletes a passed table instance. |
| DeleteTableRow(TableRow row) | Deletes a table row. |
| DeleteCodeBlock(CodeAnnotationRangeStart rangeStart) | Deletes a code block. |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |

### Fields realated

|Method|Description|
|---|---|
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |

### SDT realated

|Method|Description|
|---|---|
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |

### Shapes realated

|Method|Description|
|---|---|
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |

### Styles realated

|Method|Description|
|---|---|
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |
|   |   |


## See Also

 * [History]({%slug radrichtextbox-features-history%})

 * [Using RadRichTextBox's formatting API ]({%slug radrichtextbox-features-formatting-api%})

 * [Merge Documents]({%slug radrichtextbox-features-merge-raddocumentmerger%})
