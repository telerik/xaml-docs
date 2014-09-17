---
title: FieldCharacter
page_title: FieldCharacter
description: FieldCharacter
slug: radwordsprocessing-model-fieldcharacter
tags: fieldcharacter
published: True
position: 10
---

# FieldCharacter



__FieldCharacter__ is an inline element. It is a special character which delimits the start and end of a field or separates
        its field codes from its current field result.
      

## Inserting a FieldCharacter

__FieldCharacter__ element is created when InsertField(string code, string result) method of
          [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}) is called.
        

These are the possible __FieldCharacterTypes__

* __Start__: Specifies that the character is a start character, which defines the start of a complex field.
            

* __End__: Specifies that the character is an end character, which defines the end of a complex field.
            

* __Separator__: Specifies that the character is a separator character, which defines the end of the field codes
              and the start of the field result for a complex field.
            

__FieldCharacter__ has a __FieldInfo__ property which points to its associated
          [FieldInfo]({%slug radwordsprocessing-concepts-fields%}) object.
        

# See Also[FieldCharacter API Reference](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_documents_flow_model_fields_fieldcharacter.html)

 * [Fields]({%slug radwordsprocessing-concepts-fields%})

 * [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%})
