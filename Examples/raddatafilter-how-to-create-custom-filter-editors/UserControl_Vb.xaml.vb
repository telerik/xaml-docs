Public Class Default_Vb


' #region raddatafilter-how-to-create-custom-filter-editors_1
Public Class EditorTemplateRule
 Public Property PropertyName() As String
  Get
   Return m_PropertyName
  End Get
  Set
   m_PropertyName = Value
  End Set
 End Property
 Private m_PropertyName As String
 Public Property DataTemplate() As DataTemplate
  Get
   Return m_DataTemplate
  End Get
  Set
   m_DataTemplate = Value
  End Set
 End Property
 Private m_DataTemplate As DataTemplate
End Class
' #endregion

' #region raddatafilter-how-to-create-custom-filter-editors_3
Public Class EditorTemplateSelector
 Inherits DataTemplateSelector
 Private m_editorTemplateRules As List(Of EditorTemplateRule)
 Public Overrides Function SelectTemplate(item As Object, container As DependencyObject) As DataTemplate
  Dim info As ItemPropertyDefinition = DirectCast(item, ItemPropertyDefinition)
  For Each rule As EditorTemplateRule In Me.EditorTemplateRules
   If rule.PropertyName = info.PropertyName Then
    Return rule.DataTemplate
   End If
  Next
  Return MyBase.SelectTemplate(item, container)
 End Function
 Public ReadOnly Property EditorTemplateRules() As List(Of EditorTemplateRule)
  Get
   If Me.m_editorTemplateRules Is Nothing Then
    Me.m_editorTemplateRules = New List(Of EditorTemplateRule)()
   End If
   Return Me.m_editorTemplateRules
  End Get
 End Property
End Class
' #endregion

' #region raddatafilter-how-to-create-custom-filter-editors_6
Public Partial Class CustomFilterEditorsSample
 Inherits UserControl
 Public Sub New()
  InitializeComponent()
  Me.radDataFilter.Source = SampleData.GetEmployees()
 End Sub
 Private Sub radDataFilter_EditorCreated(sender As Object, e As EditorCreatedEventArgs)
  Select Case e.ItemPropertyDefinition.PropertyName
   Case "Title"
    DirectCast(e.Editor, RadComboBox).ItemsSource = Me.GetTitles()
    Exit Select
  End Select
 End Sub
 Public Function GetTitles() As List(Of String)
  Return New List(Of String)() With { _
   "Owner", _
   "Sales Representative", _
   "Sales Associate", _
   "Sales Agent", _
   "Marketing Assistent" _
  }
 End Function
End Class
' #endregion

' #region raddatafilter-how-to-create-custom-filter-editors_8
Public Class Employee
 Public Sub New(name As String, companyName As String, title As String)
  Me.Name = name
  Me.CompanyName = companyName
  Me.Title = title
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

' #region raddatafilter-how-to-create-custom-filter-editors_10
Dim employees As New ObservableCollection(Of Employee)()
employees.Add(New Employee("Maria Anders", "Alfreds Futterkiste", "Sales Representative"))
employees.Add(New Employee("Ana Trujillo", "Ana Trujillo Emparedados y helados", "Owner"))
employees.Add(New Employee("Antonio Moreno", "Antonio Moreno Taqueria", "Owner"))
employees.Add(New Employee("Thomas Hardy", "Around the Horn", "Sales Representative"))
employees.Add(New Employee("Hanna Moos", "Blauer See Delikatessen", "Sales Representative"))
employees.Add(New Employee("Frederique Citeaux", "Blondesddsl pere et fils", "Marketing Manager"))
employees.Add(New Employee("Martin Sommer", "Bolido Comidas preparadas", "Owner"))
employees.Add(New Employee("Laurence Lebihan", "Bon app'", "Owner"))
employees.Add(New Employee("Elizabeth Lincoln", "Bottom-Dollar Markets", "Accounting manager"))
employees.Add(New Employee("Victoria Ashworth", "B's Beverages", "Sales representative"))
' #endregion
End Class
