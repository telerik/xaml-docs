Public Class Default_Vb


' #region raddatafilter-features-unbound-mode_2
    Public Sub New()
        InitializeComponent()
        Dim nameDefinition As New ItemPropertyDefinition("Name", GetType(String), "Employee's Name")
        Me.radDataFilter.ItemPropertyDefinitions.Add(nameDefinition)
        AddHandler Me.radDataFilter.FilterDescriptors.CollectionChanged, AddressOf FilterDescriptors_CollectionChanged
        Me.radGridView.ItemsSource = RadGridViewSampleData.GetEmployees()
    End Sub
    Private Sub FilterDescriptors_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
        If e.Action = NotifyCollectionChangedAction.Add Then
            Me.radGridView.FilterDescriptors.AddRange(e.NewItems.OfType(Of IFilterDescriptor)())
        ElseIf e.Action = NotifyCollectionChangedAction.Remove Then
            For Each item In e.OldItems.OfType(Of IFilterDescriptor)()
                Me.radGridView.FilterDescriptors.Remove(item)
            Next item
        End If
    End Sub
' #endregion

' #region raddatafilter-features-unbound-mode_4
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
        Set(value As String)
            m_Name = Value
        End Set
    End Property
    Private m_Name As String
    Public Property CompanyName() As String
        Get
            Return m_CompanyName
        End Get
        Set(value As String)
            m_CompanyName = Value
        End Set
    End Property
    Private m_CompanyName As String
    Public Property Title() As String
        Get
            Return m_Title
        End Get
        Set(value As String)
            m_Title = Value
        End Set
    End Property
    Private m_Title As String
End Class
' #endregion
End Class
