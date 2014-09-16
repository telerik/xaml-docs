Public Class Default_Vb


' #region radtabcontrol-populating-data-binding_2
Dim radTabControl As New RadTabControl()
radTabControl.DataContext = New Collection(Of WordDocument)()
' #endregion

' #region radtabcontrol-populating-data-binding_5
Dim radTabControl As New RadTabControl()
radTabControl.DataContext = New Collection(Of Person)()
radTabControl.DisplayMemberPath = "Name"
' #endregion
End Class
