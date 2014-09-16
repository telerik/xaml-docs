#Region "radcoloreditor-getting-started-0"
Dim colorEditor As New RadColorEditor()
colorEditor.SelectedColor = Colors.Red
#End Region

#Region "radcoloreditor-getting-started-1"
colorEditor.SelectedColorChanged += New EventHandler(Of ColorChangeEventArgs)(colorEditor_SelectedColorChanged)

Private Sub colorEditor1_SelectedColorChanged(ByVal sender As Object, ByVal e As ColorChangeEventArgs)
	Dim selectedColor As Color = e.Color
End Sub
#End Region

