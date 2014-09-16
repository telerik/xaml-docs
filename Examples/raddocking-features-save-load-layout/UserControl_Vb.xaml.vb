Public Class Default_Vb


' #region raddocking-features-save-load-layout_3
Private Function SaveLayout() As String
 Dim xml As String
 ' Save your layout for example in the isolated storage.
 Using storage As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
  Using isoStream = storage.OpenFile("RadDocking_Layout.xml", FileMode.Create)
   Me.radDocking.SaveLayout(isoStream)
   isoStream.Seek(0, SeekOrigin.Begin)
   Dim reader As New StreamReader(isoStream)
   xml = reader.ReadToEnd()
  End Using
 End Using
 ' Return the generated XML
 Return xml
End Function
' #endregion

' #region raddocking-features-save-load-layout_3_1
Private Function SaveLayout() As String
 Dim xml As String
 ' Save your layout for example in the isolated storage.
 Using storage As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly()
  Using isoStream = storage.OpenFile("RadDocking_Layout.xml", FileMode.Create)
   Me.radDocking.SaveLayout(isoStream)
   isoStream.Seek(0, SeekOrigin.Begin)
   Dim reader As New StreamReader(isoStream)
   xml = reader.ReadToEnd()
  End Using
 End Using
 ' Return the generated XML
 Return xml
End Function
' #endregion

' #region raddocking-features-save-load-layout_6
Private Sub LoadLayout()
 ' Load your layot from the isolated storage.
 Using storage As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
  Using isoStream = storage.OpenFile("RadDocking_Layout.xml", FileMode.Open)
   Me.radDocking.LoadLayout(isoStream)
  End Using
 End Using
End Sub
' #endregion


' #region raddocking-features-save-load-layout_6_1
Private Sub LoadLayout()
 ' Load your layot from the isolated storage.
 Using storage As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly()
  Using isoStream = storage.OpenFile("RadDocking_Layout.xml", FileMode.Open)
   Me.radDocking.LoadLayout(isoStream)
  End Using
 End Using
End Sub
' #endregion

' #region raddocking-features-save-load-layout_8
Public Sub SaveLayout(ByVal destination As Stream, ByVal raiseEventsIfNoSerializationTag As Boolean)
End Sub
' #endregion
End Class
