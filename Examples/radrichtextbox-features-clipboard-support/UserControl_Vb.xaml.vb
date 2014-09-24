Public Class Default_Vb


    ' #region radrichtextbox-features-clipboard-support_0
Me.radRichTextBox.Copy()
Me.radRichTextBox.Cut()
Me.radRichTextBox.Paste()
' #endregion

    ' #region radrichtextbox-features-clipboard-support_1
    ClipboardEx.ClipboardHandlers.Clear()

    Dim clipboardHandler As New ClipboardHandler()
    clipboardHandler.ClipboardDataFormat = DataFormats.Text
    clipboardHandler.DocumentFormatProvider = New TxtFormatProvider()

    ClipboardEx.ClipboardHandlers.Add(clipboardHandler)
' #endregion


End Class
