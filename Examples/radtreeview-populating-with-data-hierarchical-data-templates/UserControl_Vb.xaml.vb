Public Class Default_Vb


' #region radtreeview-populating-with-data-hierarchical-data-templates_1
Public Class MyViewModel
    Implements INotifyPropertyChanged
    Private m_title As [String]
    Private m_dateCreated As DateTime
    Private m_price As Double
    Public Sub New()
        RelatedItems = New ObservableCollection(Of Object)()
    End Sub
    Public Property Price() As Double
        Get
            Return Me.m_price
        End Get
        Set(ByVal value As Double)
            If Me.Price = value Then
                Return
            End If
            Me.m_price = value
            OnPropertyChanged("Price")
        End Set
    End Property
    Public Property DateCreated() As DateTime
        Get
            Return Me.m_dateCreated
        End Get
        Set(ByVal value As DateTime)
            If Me.DateCreated = value Then
                Return
            End If
            Me.m_dateCreated = value
            OnPropertyChanged("DateCreated")
        End Set
    End Property
    Public Property Title() As [String]
        Get
            Return Me.m_title
        End Get
        Set(ByVal value As [String])
            If Me.Title = value Then
                Return
            End If
            Me.m_title = value
            OnPropertyChanged("Title")
        End Set
    End Property
Private _RelatedItems As IList(Of Object)
    Public Property RelatedItems() As IList(Of Object)
        Get
            Return _RelatedItems
        End Get
        Set(ByVal value As IList(Of Object))
            _RelatedItems = value
        End Set
    End Property
    Public Event PropertyChanged As PropertyChangedEventHandler
    Protected Overridable Sub OnPropertyChanged(ByVal info As String)
        Dim temp As PropertyChangedEventHandler = Me.PropertyChanged
        RaiseEvent temp(Me, New PropertyChangedEventArgs(info))
    End Sub
End Class
' #endregion

' #region radtreeview-populating-with-data-hierarchical-data-templates_3
Public Shared Function GetItems(ByVal name As String) As IList(Of Object)
    Dim result = New ObservableCollection(Of Object)()
    For Each num In Enumerable.Range(1, 5)
        Dim item = New MyViewModel()
        item.DateCreated = DateTime.Today.AddDays(-num Mod 15)
        item.Price = num * 100 + Convert.ToDouble(num) / 100
        item.Title = [String].Format("{0} {1}", name, num)
        For i As Integer = 0 To 4
            Dim child = New MyViewModel()
            child.DateCreated = DateTime.Today.AddDays(-num Mod 5 - i)
            child.Price = num * 100 + Convert.ToDouble(num + i) / 100
            child.Title = [String].Format("{0} {1}'s {2}", name, num, i)
            item.RelatedItems.Add(child)
            For j As Integer = 0 To 2
                Dim grandChild = New MyViewModel()
                grandChild.DateCreated = DateTime.Today.AddDays(-num Mod 5 - i + 2)
                grandChild.Price = num * 100 + Convert.ToDouble(num + i) / 100
                grandChild.Title = [String].Format("{0} {1} : {2}'s {3}", name, num, i, j)
                child.RelatedItems.Add(grandChild)
            Next
        Next
        result.Add(item)
    Next
    Return result
End Function
' #endregion

' #region radtreeview-populating-with-data-hierarchical-data-templates_6
Me.radTreeView.ItemsSource = MyViewModel.GetItems("Item")
' #endregion
End Class
