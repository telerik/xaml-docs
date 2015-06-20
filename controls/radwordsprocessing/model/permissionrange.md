---
title: PermissionRange
page_title: PermissionRange
description: PermissionRange
slug: radwordsprocessing-model-permissionrange
tags: permission,range
published: True
position: 15
---

# PermissionRange


A __PermissionRange__ object holds annotation markers which specify for which range of document elements it refers. Every permission has a corresponding __PermissionRangeStart__ and __PermissionRangeEnd__, which are inline elements. These two elements specify the range's location as follows.


* __PermissionRangeStart__: Specifies the start of a permission annotation.

* __PermissionRangeEnd__: Specifies the end of a permission annotation.


## Inserting a PermissionRange


Creating a __PermissionRange__ requires to pass an instance of the __PermissionRangeCredentials__ class to the constructor which can be created in either one of the following ways:

* __PermissionRangeCredentials(EditingGroup editingGroup):__ Initialize credentials with a type of user group. The enumeration exposes the following members:
	* __None:__ Specifies that none of the users that open the document shall be allowed to edit range permissions using this editing group when document protection is enforced.
	* __Everyone:__ Specifies that all users that open the document shall be allowed to edit range permissions using this editing group when document protection is enforced.
	* __Administrators:__ Specifies that only user(s) who the viewing application associates with the Administrators group shall be allowed to edit the contents between the start and end permission ranges when document protection is enforced.
	* __Contributors:__  Specifies that only user(s) who the viewing application associates with the Contributors group shall be allowed to edit the contents between the start and end permission ranges when document protection is enforced.
	* __Editors:__ Specifies that only user(s) who the viewing application associates with the Editors group shall be allowed to edit the contents between the start and end permission ranges when document protection is enforced.
	* __Owners:__ Specifies that only user(s) who the viewing application associates with the Owners group shall be allowed to edit the contents between the start and end permission ranges when document protection is enforced.
	* __Current:__ Specifies that only user(s) who the viewing application associates with the Current group shall be allowed to edit the contents between the start and end permission ranges when document protection is enforced.
* __PermissionRangeCredentials(string editor):__ Initialize credentials by passing the single user's name, email or domain credentials.


>importantThe credentials you specify to a permission range are used by the consumer of the generated document and it is responsible for making sure they are enforced when the document is protected. A protected document can still be edited with the API of __RadWordsProcessing__.

__Example 1__ demonstrates how to create permission credentials for a single user specified by email and a permission range in a [Paragraph]({%slug radwordsprocessing-model-paragraph%}).


#### __[C#] Example 1: Add PermissionRange to Paragraph__

{{region radwordsprocessing-model-permissionranget_0}}
	PermissionRangeCredentials jane = new PermissionRangeCredentials("Jane.Doe@telerik.com");
	PermissionRange range = new PermissionRange(document, jane);
	
	paragraph.Inlines.Add(range.Start);
	paragraph.Inlines.Add(new Run(document) { Text = "protected text" });
	paragraph.Inlines.Add(range.End);
{{endregion}}

The paragraph should belong to the same document that is passed to the constructor of the __PermissionRange__ object, otherwise an exception is thrown.


Inserting a __PermissionRange__ in the document can be achieved through [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}) as well. Since a permission range refers to a specific document element or a range of elements, there are several overloads for the __InsertPermissionRange()__ method - accepting a __TableCell__, __TableRow__ or two inline elements representing the start and end of the range.

__Example 2__ demonstrates how to specify that a __TableCell__ can be edited by everyone when protection is enforced.

__[C#] Example 2: Insert PermissionRange for TableCell__

{{region radwordsprocessing-model-permissionranget_0}}
    Table table = editor.InsertTable();
    TableRow row = table.Rows.AddTableRow();
    TableCell cell = row.Cells.AddTableCell();
    cell.Blocks.AddParagraph().Inlines.AddRun("Hello");

    PermissionRangeCredentials everyone = new PermissionRangeCredentials(EditingGroup.Everyone);
    PermissionRange range = editor.InsertPermissionRange(everyone, cell);
{{endregion}}


## Operating with Permission Ranges

### Enforcing Protection

Including permission ranges in a document is not enough to protect them from editing, you also need to enforce the protection. Protecting and un-protecting a document is achieved with the __Protect()__ and __Unprotect()__ method of __RadFlowDocumentEditor__ respectively. When enforcing and stopping the protection you have the option to pass a string password to the methods and specify the type of editing restrictions using the __ProtectionMode__ enumeration.

__ProtectionMode__ exposes the following members:

* __NoProtection:__ Specifies that no editing restrictions are applied.
* __AllowComments:__ Specifies that working with comments is allowed in addition to editing in permission ranges.
* __ReadOnly:__ Specifies that editing is allowed only in permission regions by the users or groups that have permissions for edition. This mode is applied when __ProtectionMode__ parameter is not passed to the __Protect()__ method.

__Example 3__ shows how to protect and un-protect a document using the various overloads of the methods.

#### __[C#] Example 3: Protect and Unprotect Document Through RadFlowDocumentEditor__

{{region radwordsprocessing-model-permissionranget_2}}
    editor.Protect(String.Empty);
    if (editor.Unprotect(string.Empty))
    {
        editor.Protect("p4ssw0rd", ProtectionMode.AllowComments);
    }
    editor.Unprotect();
{{endregion}}


>The last call to the __Unprotect()__ method in __Example 3__ will enforce protection of type __NoProtection__ to the document. Protecting a document is intended to notify the user that changes are unadvised, but stopping the protection is still possible. The __Unprotect(string password)__ overload is introduced for your convenience to use in your applications and returns a *Boolean* result of the action. 

### Modifying Document Protection Settings

__RadFlowDocument__ exposes a property of type __ProtectionSettings__ - ProtectionSettings. Enforcing protection directly through the document is possible by setting the  __Enforced__ property as demonstrated in __Example 4__.

#### __[C#] Example 4: Enforce Protection Through RadFlowDocument__

{{region radwordsprocessing-model-permissionranget_3}}
    document.ProtectionSettings.Enforced = true;
{{endregion}}

The settings provide a number of other modification options, including changing the algorithm used to protect the document with one of the predefined in the __ProtectionAlgorithmNames__ enumeration.



## See Also

* [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%})
* [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%})



          
