Public Class Default_Vb

' #region radrichtextbox-features-raddocumenteditor_0
Dim documentEditor As New RadDocumentEditor(document)
' #endregion

' #region radrichtextbox-features-raddocumenteditor_1
documentEditor.BeginUndoGroup()

If documentEditor.Document.CaretPosition.IsPositionInsideTable Then
	documentEditor.InsertTableRow()
	documentEditor.InsertTableRow()
	documentEditor.InsertTableRow()
	documentEditor.Document.Selection.Clear()
End If

documentEditor.EndUndoGroup("Insert three table rows")
' #endregion

    ' #region radrichtextbox-features-raddocumenteditor_2
documentEditor.BeginUndoGroup()

If documentEditor.Document.CaretPosition.IsPositionInsideTable Then
	documentEditor.InsertTableRow()
	documentEditor.InsertTableRow()
	documentEditor.InsertTableRow()
	documentEditor.Document.Selection.Clear()
End If

documentEditor.CancelUndoGroup()
' #endregion

End Class
