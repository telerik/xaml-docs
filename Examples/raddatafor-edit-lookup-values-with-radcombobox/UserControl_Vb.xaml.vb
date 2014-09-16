Public Class Default_Vb


' #region raddatafor-edit-lookup-values-with-radcombobox_1
Public Class Person
 Public Property FirstName() As String
  Get
   Return m_FirstName
  End Get
  Set
   m_FirstName = Value
  End Set
 End Property
 Private m_FirstName As String
 Public Property LastName() As String
  Get
   Return m_LastName
  End Get
  Set
   m_LastName = Value
  End Set
 End Property
 Private m_LastName As String
 Public Property CountryID() As Integer
  Get
   Return m_CountryID
  End Get
  Set
   m_CountryID = Value
  End Set
 End Property
 Private m_CountryID As Integer
End Class
Public Class Country
 Public Property ID() As Integer
  Get
   Return m_ID
  End Get
  Set
   m_ID = Value
  End Set
 End Property
 Private m_ID As Integer
 Public Property Name() As String
  Get
   Return m_Name
  End Get
  Set
   m_Name = Value
  End Set
 End Property
 Private m_Name As String
End Class
' #endregion

' #region raddatafor-edit-lookup-values-with-radcombobox_4
Public Sub New()
 InitializeComponent()
 Dim persons As New List(Of Person)()
 ' A sample list of source objects for the RadDataForm. 
 persons.Add(New Person() With { _
  Key .FirstName = "John", _
  Key .LastName = "Smith", _
  Key .CountryID = 1 _
 })
 persons.Add(New Person() With { _
  Key .FirstName = "Angelo", _
  Key .LastName = "Romano", _
  Key .CountryID = 2 _
 })
 persons.Add(New Person() With { _
  Key .FirstName = "Jean", _
  Key .LastName = "Michel", _
  Key .CountryID = 3 _
 })
 Me.RadDataForm1.ItemsSource = persons
End Sub
' #endregion

' #region raddatafor-edit-lookup-values-with-radcombobox_6
Private Function GetCountries() As List(Of Country)
 Dim countries As New List(Of Country)()
 countries.Add(New Country() With { _
  Key .ID = 1, _
  Key .Name = "USA" _
 })
 countries.Add(New Country() With { _
  Key .ID = 2, _
  Key .Name = "Italy" _
 })
 countries.Add(New Country() With { _
  Key .ID = 3, _
  Key .Name = "France" _
 })
 countries.Add(New Country() With { _
  Key .ID = 4, _
  Key .Name = "Canada" _
 })
 Return countries
End Function
' #endregion

' #region raddatafor-edit-lookup-values-with-radcombobox_8
Private Sub RadDataForm_AutoGeneratingField(sender As Object, e As Telerik.Windows.Controls.Data.DataForm.AutoGeneratingFieldEventArgs)
 If e.PropertyName = "CountryID" Then
  e.DataField = New DataFormComboBoxField() With { _
   Key .ItemsSource = Me.GetCountries(), _
   Key .SelectedValuePath = "ID", _
   Key .DisplayMemberPath = "Name", _
   Key .DataMemberBinding = New Binding("CountryID") With { _
   Key .Mode = BindingMode.TwoWay _
   } _
  }
 End If
End Sub
' #endregion
End Class
