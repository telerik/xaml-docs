Public Class Default_Vb


' #region raddatetimepicker-how-to-use-in-dataform_1
Public Class Club
 Public Sub New(name As String, established As DateTime, stadiumCapacity As Integer)
  Me.Name = name
  Me.Established = established
  Me.StadiumCapacity = stadiumCapacity
 End Sub
 Public Property Name() As String
  Get
   Return m_Name
  End Get
  Set
   m_Name = Value
  End Set
 End Property
 Private m_Name As String
 Public Property Established() As System.Nullable(Of DateTime)
  Get
   Return m_Established
  End Get
  Set
   m_Established = Value
  End Set
 End Property
 Private m_Established As System.Nullable(Of DateTime)
 Public Property StadiumCapacity() As Integer
  Get
   Return m_StadiumCapacity
  End Get
  Set
   m_StadiumCapacity = Value
  End Set
 End Property
 Private m_StadiumCapacity As Integer
 Public Shared Function GetClubs() As IEnumerable(Of Club)
  Dim clubs As New ObservableCollection(Of Club)()
  clubs.Add(New Club("Liverpool", New DateTime(1892, 1, 1), 45362))
  clubs.Add(New Club("Manchester Utd.", New DateTime(1878, 1, 1), 76212))
  clubs.Add(New Club("Chelsea", New DateTime(1905, 1, 1), 42055))
  clubs.Add(New Club("Arsenal", New DateTime(1886, 1, 1), 60355))
  Return clubs
 End Function
End Class
' #endregion

' #region raddatetimepicker-how-to-use-in-dataform_4
Me.radGridView.ItemsSource = Club.GetClubs()
' #endregion
End Class
