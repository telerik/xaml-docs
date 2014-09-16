Public Class Default_Vb

    ' #region radrichtextbox-features-style-sheets_2
    Dim ofd As New OpenFileDialog()
    ofd.Filter = "Xaml Files|*.xaml"
    If ofd.ShowDialog() = True Then
	    Using stream = ofd.OpenFile()
    Dim stylesheet As Stylesheet = XamlFormatProvider.LoadStylesheet(stream)
		    stylesheet.ApplyStylesheetToDocument(Me.editor.Document)
	    End Using
    End If
    ' #endregion

    ' #region radrichtextbox-features-style-sheets_4
    Dim ofd As New OpenFileDialog()
    ofd.Filter = "Xaml Files|*.xaml"
    If ofd.ShowDialog() = True Then
	    Using stream = ofd.File.OpenRead()
    Dim stylesheet As Stylesheet = XamlFormatProvider.LoadStylesheet(stream)
		    stylesheet.ApplyStylesheetToDocument(Me.editor.Document)
	    End Using
    End If
    ' #endregion

    ' #region radrichtextbox-features-style-sheets_6
    Dim sfd As New SaveFileDialog()
    sfd.Filter = "Xaml Files|*.xaml"
    If sfd.ShowDialog() = True Then
	    Using stream = sfd.OpenFile()
    Dim stylesheet As New Stylesheet()
		    stylesheet.ExtractStylesheetFromDocument(Me.editor.Document)
		    XamlFormatProvider.SaveStylesheet(stylesheet, stream)
	    End Using
    End If
    ' #endregion

End Class
