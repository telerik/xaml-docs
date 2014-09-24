Public Class Default_Vb


' #region gridview-sorting-custom_1
Public Sub New()
    InitializeComponent()       
    AddHandler Me.radGridView.Sorting, AddressOf Me.radGridView_Sorting
End Sub
Private Sub radGridView_Sorting(ByVal sender As Object, ByVal e As GridViewSortingEventArgs)
End Sub
' #endregion

' #region gridview-sorting-custom_3
Private Sub radGridView_Sorting(ByVal sender As Object, ByVal e As GridViewSortingEventArgs)
    'Gets the value of the ItemsSource property as IEnumerable.
    Dim employees As IEnumerable(Of Employee) = TryCast(e.DataControl.ItemsSource, IEnumerable(Of Employee))
    'Checks if the value of the collection is null.
    If employees Is Nothing Then
        e.Cancel = True
        Exit Sub
    End If
End Sub
' #endregion

' #region gridview-sorting-custom_5
'If the sorting state is none, sort the items ascending.
If e.OldSortingState = SortingState.None Then
    e.NewSortingState = SortingState.Ascending
'If the sorting state is none, sort the items descending.
ElseIf e.OldSortingState = SortingState.Ascending Then
    e.NewSortingState = SortingState.Descending
'If the sorting state is descending, apply default sorting to the items.
Else
    e.NewSortingState = SortingState.None
End If
' #endregion

' #region gridview-sorting-custom_7
'Via the SortPropertyName value get 
'the value of the property to sort your data by.
employees = employees.OrderBy(Function(employee) employee.[GetType]()
                                                         .GetProperty(TryCast(e.Column, GridViewDataColumn).GetDataMemberName())
                                                         .GetValue(employee, Nothing))
' #endregion

' #region gridview-sorting-custom_9
e.DataControl.ItemsSource = employees.ToList()
e.Cancel = True
' #endregion

' #region gridview-sorting-custom_11
Private Sub radGridView_Sorting(ByVal sender As Object, ByVal e As GridViewSortingEventArgs)
    'Gets the value of the ItemsSource property as IEnumerable.
    Dim employees As IEnumerable(Of Employee) = TryCast(e.DataControl.ItemsSource, IEnumerable(Of Employee))
    'Checks if the value of the collection is null.
    If employees Is Nothing Then
        e.Cancel = True
        Exit Sub
    End If
    'If the sorting state is none, sort the items ascending.
    If e.OldSortingState = SortingState.None Then
        e.NewSortingState = SortingState.Ascending
        employees = employees.OrderBy(Function(employee) employee.[GetType]().GetProperty(TryCast(e.Column, GridViewDataColumn).GetDataMemberName()).GetValue(employee, Nothing))
    'If the sorting state is none, sort the items descending.
    ElseIf e.OldSortingState = SortingState.Ascending Then
        e.NewSortingState = SortingState.Descending
        employees = employees.OrderByDescending(Function(employee) employee.[GetType]().GetProperty(TryCast(e.Column, GridViewDataColumn).GetDataMemberName()).GetValue(employee, Nothing))
    Else
        'If the sorting state is descending, apply default sorting to the items.
        e.NewSortingState = SortingState.None
        employees = employees.OrderBy(Function(employee) employee.EmployeeID)
    End If
    'Set the sorted collection as source of the RadGridView
    e.DataControl.ItemsSource = employees.ToList()
    e.Cancel = True
End Sub
' #endregion
End Class
