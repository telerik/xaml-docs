Public Class Default_Vb


' #region gridview-cell-style-selector_1
Public Class StadiumCapacityStyle
 Inherits StyleSelector
 Public Overrides Function SelectStyle(item As Object, container As DependencyObject) As Style
  If TypeOf item Is Club Then
   Dim club As Club = TryCast(item, Club)
   If club.StadiumCapacity > 50000 Then
    Return BigStadiumStyle
   Else
    Return SmallStadiumStyle
   End If
  End If
  Return Nothing
 End Function
 Public Property BigStadiumStyle() As Style
  Get
   Return m_BigStadiumStyle
  End Get
  Set
   m_BigStadiumStyle = Value
  End Set
 End Property
 Private m_BigStadiumStyle As Style
 Public Property SmallStadiumStyle() As Style
  Get
   Return m_SmallStadiumStyle
  End Get
  Set
   m_SmallStadiumStyle = Value
  End Set
 End Property
 Private m_SmallStadiumStyle As Style
End Class
' #endregion
End Class
