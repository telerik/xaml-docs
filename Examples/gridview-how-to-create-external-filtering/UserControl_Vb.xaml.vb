Public Class Default_Vb


' #region gridview-how-to-create-external-filtering_1
Public Class CustomFilterDescriptor
    Inherits FilterDescriptorBase
    Private m_filterValue As String
    Private compositeFilter As CompositeFilterDescriptor
    Public Sub New(ByVal filterValue As String, ByVal filterPropertyNames As IEnumerable(Of String))
        compositeFilter = New CompositeFilterDescriptor()
        compositeFilter.LogicalOperator = FilterCompositionLogicalOperator.[Or]
        For Each propertyName As String In filterPropertyNames
            Me.compositeFilter.FilterDescriptors.Add(New FilterDescriptor(propertyName, FilterOperator.Contains, filterValue))
        Next
    End Sub
    Public Property FilterValue() As String
        Get
            Return m_filterValue
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                Return
            End If
            m_filterValue = value
            Me.UpdateCompositeFilterValues()
            Me.OnPropertyChanged("FilterValue")
        End Set
    End Property
    Protected Overloads Overrides Function CreateFilterExpression(ByVal parameterExpression As System.Linq.Expressions.ParameterExpression) As System.Linq.Expressions.Expression
        If String.IsNullOrEmpty(Me.FilterValue) Then
            Return System.Linq.Expressions.Expression.Constant(True)
        End If
        Return Me.compositeFilter.CreateFilterExpression(parameterExpression)
    End Function
    Private Sub UpdateCompositeFilterValues()
        For Each descriptor As FilterDescriptor In Me.compositeFilter.FilterDescriptors
            descriptor.Value = Me.FilterValue
        Next
    End Sub
End Class
' #endregion

' #region gridview-how-to-create-external-filtering_4
Public Partial Class ExternalFiltering
    Inherits UserControl
    Private customFilter As CustomFilterDescriptor
    Public Sub New()
        InitializeComponent()
        textBoxSearchFor.Focus()
        Me.radGridView.ItemsSource = RadGridViewSampleData.GetEmployees()
        Me.radGridView.FilterDescriptors.Add(Me.CustomFilterDescriptor)
    End Sub
    Public ReadOnly Property CustomFilterDescriptor() As CustomFilterDescriptor
        Get
            If customFilter Is Nothing Then
                Dim propertyNames As IEnumerable(Of String) = From column In Me.radGridView.Columns _ 
                    Select column.UniqueName
                customFilter = New CustomFilterDescriptor(textBoxSearchFor.Text, propertyNames)
            End If
            Return customFilter
        End Get
    End Property
    Private Sub textBoxSearchFor_TextChanged(ByVal sender As Object, ByVal e As TextChangedEventArgs)
        Me.CustomFilterDescriptor.FilterValue = textBoxSearchFor.Text
        textBoxSearchFor.Focus()
    End Sub
End Class
' #endregion
End Class
