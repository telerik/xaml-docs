---
title: CustomCodeField
page_title: CustomCodeField
description: CustomCodeField
slug: radwordsprocessing-concepts-customcodefield
tags: customcodefield
publish: True
position: 2
---

# CustomCodeField



__Fields__ in __RadFlowDocument__ consist of code fragment and result fragment as explained in the
        [Fields]({%slug radwordsprocessing-concepts-fields%}) article. Some fields have direct representation in the document model – for example
        [Hyperlinks]({%slug radwordsprocessing-concepts-hyperlinks%}). For all other fields you can use the __CustomCodeField__ class –
        however you will need some knowledge of how to correctly form the code of the field.
      

## Syntax

Here is the basic syntax of a field code:
        

field-type [field-argument] [switches]

* field-type: The type of the field. For example: HYPERINK.
            

* argument: The argument of the field. This is optional as some of the fields do not require an argument.
            

* switches: Switches define additional properties of the field. The syntax of a switch is the following:
            \switch-character [switch-argument]

* switch-character: Character defining the switch. For example the "\o" switch for HYPERINK fields
                  defines the tooltip switch.
                

* switch-argument: The argument of the switch. The argument is optional as not all switches require an argument.
                

Below is an example of field code:
        ![Rad Words Processing Concepts Custom Code Field 01](images/RadWordsProcessing_Concepts_CustomCodeField_01.png)

## Inserting

The suggested approach for inserting code fields is by using [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}). The
          __InsertField()__ method accepts code as a first argument and the result as a second argument.
        

Here are some commonly used fields. The complete list of field codes and the switches for each of them can be found in the
          [Docx specification](http://www.ecma-international.org/publications/standards/Ecma-376.htm).
        

>In all examples the result fragment is also inserted. However, if you export the document to
            [Docx format]({%slug radwordsprocessing-formats-and-conversion-docx%}), you can make use of the __AutoUpdateFields__
            property. It forces all fields to be updated when the document is opened in MS Word or another editor.
          

### Inserting PAGE Field

Here is how to insert __PAGE__ field representing the current page number in the document:
            

#### __C#__

{{region radwordsprocessing-concepts-customcodefield_0}}
	            editor.InsertField("PAGE  \\* ROMAN", "VII");
	{{endregion}}



The __\* ROMAN__ is general formatting switch that formats a numeric result using uppercase Roman numerals.
            

### Inserting NUMPAGE Field

Here is how a combination of __PAGE__ and __NUMPAGES__ fields can be inserted to show which is
              the current page as well as the total page count in the document:
            

#### __C#__

{{region radwordsprocessing-concepts-customcodefield_1}}
	            editor.InsertText("Page ");
	            editor.InsertField("PAGE", "3");
	            editor.InsertText(" of ");
	            editor.InsertField("NUMPAGES", "5");
	{{endregion}}



### Inserting AUTHOR Field

Here is how to insert __AUTHOR__ field showing the name of the author of the document.
            

#### __C#__

{{region radwordsprocessing-concepts-customcodefield_3}}
	            editor.InsertField("AUTHOR  \\* Upper", "JOHN DOE");
	{{endregion}}



The __\* Upper__ switch will convert all letters in the result to uppercase.
            

### Inserting Table of Contents Field

Here is how to insert table of contents (TOC) field:
            

#### __C#__

{{region radwordsprocessing-concepts-customcodefield_4}}
	            FieldInfo tocField = editor.InsertField("TOC \\o \"1-3\" \\h \\z \\u", "result");
	            tocField.IsDirty = true;
	{{endregion}}



There are several switches which can be used for this field:
            

* __\o "1-3"__: Specifies that the first 3 heading levels should be included in the table of contents.
                

* __\h__: Makes the table of contents entries hyperlinks.
                

* __\z__: Hides tab leader and page numbers in Web layout view.
                

* __\u__: Uses the applied paragraph outline level.
                

The __IsDirty__ property is set so that the TOC field is updated when the document is loaded inside an editor like Microsoft Word.
            

# See Also

 * [Fields]({%slug radwordsprocessing-concepts-fields%})

 * [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%})

 * [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%})
