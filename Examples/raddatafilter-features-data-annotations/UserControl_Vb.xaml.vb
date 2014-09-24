Public Class Default_Vb


' #region raddatafilter-features-data-annotations_1
Public Class Person
 <Display(AutoGenerateFilter = False)> _
 Public Property Name() As String
  Get
   Return m_Name
  End Get
  Set
   m_Name = Value
  End Set
 End Property
 Private m_Name As String
 <Display(ShortName = "Company's Name")> _
 Public Property CompanyName() As String
  Get
   Return m_CompanyName
  End Get
  Set
   m_CompanyName = Value
  End Set
 End Property
 Private m_CompanyName As String
 Public Property Title() As String
  Get
   Return m_Title
  End Get
  Set
   m_Title = Value
  End Set
 End Property
 Private m_Title As String
End Class
' #endregion
End Class
