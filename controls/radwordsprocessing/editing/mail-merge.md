---
title: Mail Merge
page_title: Mail Merge
description: Mail Merge
slug: radwordsprocessing-editing-mail-merge
tags: mail,merge
published: True
position: 4
---

# Mail Merge



[Mail merge](http://en.wikipedia.org/wiki/Mail_merge) is functionality allowing to produce personalized documents from a template holding fixed content and variables. The variables are called [Merge Fields]({%slug radwordsprocessing-concepts-merge-field%}) and are replaced through the merge process with content from a specified data source.
      

## Inserting Merge Fields

Merge fields are a type of [Fields]({%slug radwordsprocessing-concepts-fields%}) and can be added in a template document via [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%})'s __InsertFIeld()__ method. The method requires the code representation of the field and the result which is shown in the template before the document is mail-merged.
        

The code snippet in __Example 1__ shows how to initialize a RadFlodDocumentEditor instance and insert a merge field.
        

#### __[C#] Example 1: Insert Merge Field__

{{region radwordsprocessing-editing-mail-merge_0}}
    RadFlowDocument document = new RadFlowDocument();
    RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);
    editor.InsertField("MERGEFIELD FirstName", "");
{{endregion}}



Additionally, a field can be added to a Paragraph manually by creating a __FieldInfo__ instance and placing its start, code, separator, result and end in the block. __Example 2__ shows the manual approach for adding a merge field.
        

#### __[C#] Example 2: Add Merge Field Manually__

{{region radwordsprocessing-editing-mail-merge_1}}
    FieldInfo field = new FieldInfo(document);

    paragraph.Inlines.Add(field.Start);
    paragraph.Inlines.AddRun("MERGEFIELD LastName");
    paragraph.Inlines.Add(field.Separator);
    paragraph.Inlines.AddRun("");
    paragraph.Inlines.Add(field.End);
{{endregion}}



## Performing Mail Merge

Mail merge can be performed over a template document containing merge fields. For this action the __MailMerge()__ method of [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%}) needs to be used. The method accepts a collection of elements as a parameter.
        

During the operation each MergeField is replaced with the corresponding information from the data source record in a new __RadFlowDocument__ instance. Every subsequent entry in the data source is appended to a single resulting document which is returned by the method. The original template stays unmodified.
        

Example 3 shows a simple example data source.
        

#### __[C#] Example 3: Sample Data Source__

{{region radwordsprocessing-editing-mail-merge_2}}
    List<MailMergeRecord> mailMergeDataSource = new List<MailMergeRecord>()
    {
        new MailMergeRecord()
        {
            FirstName = "Andrew",
            LastName = "Fuller"
        },
        new MailMergeRecord()
        {
            FirstName = "Nancy",
            LastName = "Davolio"
        },
    };
{{endregion}}



__Example 4__ performs the mail merge operation over a previously defined template document using the data source from __Example 3__.
        

#### __[C#] Example 4: Perform Mail Merge__

{{region radwordsprocessing-editing-mail-merge_3}}
    RadFlowDocument mailMergeResult = document.MailMerge(mailMergeDataSource);
{{endregion}}



# See Also

 * [Fields]({%slug radwordsprocessing-concepts-fields%})

 * [Merge Field]({%slug radwordsprocessing-concepts-merge-field%})

 * [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%})
