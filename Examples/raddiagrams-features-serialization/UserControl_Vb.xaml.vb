' #region raddiagrams_features_serialization_0
Private diagramXMLString As String

Public MainWindow()
	StyleManager.ApplicationTheme = New Windows8Theme()
	InitializeComponent()
End Sub

Private Sub CommandBinding_Executed_Save(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs)
	diagramXMLString = Me.diagram.Save()
End Sub

Private Sub CommandBinding_Executed_Open(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs)
	If diagramXMLString IsNot Nothing Then
		Me.diagram.Load(diagramXMLString)
	End If
End Sub

Private Sub CommandBinding_CanExecute(ByVal sender As Object, ByVal e As CanExecuteRoutedEventArgs)
	e.CanExecute = Me.diagram.Items.Count > 0
End Sub
' #endregion
