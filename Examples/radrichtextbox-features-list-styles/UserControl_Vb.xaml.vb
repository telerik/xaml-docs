Public Class Default_Vb


    ' #region radrichtextbox-features-list-styles_1
    Dim upperRomanHierarchical As New ListStyle()
			upperRomanHierarchical.StyleLink = "Style1"

			For i As Integer = 0 To ListStyle.ListLevels - 1
    Dim levelText As New StringBuilder()
				For j As Integer = 0 To i
					levelText.Append("{" & j & "}.")
				Next j

				upperRomanHierarchical.Levels.Add(New ListLevelStyle() With {.StartingIndex = 1, .NumberingFormat = ListNumberingFormat.UpperRoman, .LevelText = levelText.ToString(), .Indent = 48 + i * 24})
			Next i
    ' #endregion

    ' #region radrichtextbox-features-list-styles_3
    Dim paragraph As Paragraph = Me.radRichTextBox.Document.CaretPosition.GetCurrentParagraphBox().AssociatedParagraph
    ' #endregion

    ' #region radrichtextbox-features-list-styles_5
    Dim newListStyle As ListStyle = Me.radRichTextBox.Document.AddCustomListStyle(upperRomanHierarchical)
    Dim documentList As New DocumentList(newListStyle, Me.radRichTextBox.Document)
    ' #endregion
End Class
