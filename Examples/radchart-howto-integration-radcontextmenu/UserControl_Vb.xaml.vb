Public Class Default_Vb


' #region radchart-howto-integration-radcontextmenu_1
Public Class MenuItem
    Implements INotifyPropertyChanged
    Private m_isChecked As Boolean
    Private m_isEnabled As Boolean = True
    Private m_text As String
    Private m_groupName As String
    Private m_isCheckable As Boolean
    Private m_isSeparator As Boolean
    Private m_imageUrl As String
    Private m_staysOpenOnClick As Boolean
    Private m_items As MenuItemsCollection
    Private m_parent As MenuItem
    Public Sub New()
        Me.m_items = New MenuItemsCollection(Me)
    End Sub
    Public Event PropertyChanged As PropertyChangedEventHandler
    Public Property Text() As String
        Get
            Return Me.m_text
        End Get
        Set(ByVal value As String)
            Me.m_text = value
        End Set
    End Property
    Public Property GroupName() As String
        Get
            Return Me.m_groupName
        End Get
        Set(ByVal value As String)
            Me.m_groupName = value
        End Set
    End Property
    Public Property IsCheckable() As Boolean
        Get
            Return Me.m_isCheckable
        End Get
        Set(ByVal value As Boolean)
            Me.m_isCheckable = value
        End Set
    End Property
    Public Property IsSeparator() As Boolean
        Get
            Return Me.m_isSeparator
        End Get
        Set(ByVal value As Boolean)
            Me.m_isSeparator = value
        End Set
    End Property
    Public Property ImageUrl() As String
        Get
            Return Me.m_imageUrl
        End Get
        Set(ByVal value As String)
            Me.m_imageUrl = value
        End Set
    End Property
    Public Property StaysOpenOnClick() As Boolean
        Get
            Return Me.m_staysOpenOnClick
        End Get
        Set(ByVal value As Boolean)
            Me.m_staysOpenOnClick = value
        End Set
    End Property
    Public ReadOnly Property Items() As MenuItemsCollection
        Get
            Return Me.m_items
        End Get
    End Property
    Public Property Parent() As MenuItem
        Get
            Return Me.m_parent
        End Get
        Set(ByVal value As MenuItem)
            Me.m_parent = value
        End Set
    End Property
    Public Property IsEnabled() As Boolean
        Get
            Return Me.m_isEnabled
        End Get
        Set(ByVal value As Boolean)
            If value <> Me.m_isEnabled Then
                Me.m_isEnabled = value
                Me.OnPropertyChanged("IsEnabled")
            End If
        End Set
    End Property
    Public Property IsChecked() As Boolean
        Get
            Return Me.m_isChecked
        End Get
        Set(ByVal value As Boolean)
            If value <> Me.m_isChecked Then
                Me.m_isChecked = value
                Me.OnPropertyChanged("IsChecked")
                If Not String.IsNullOrEmpty(Me.GroupName) Then
                    If Me.IsChecked Then
                        Me.UncheckOtherItemsInGroup()
                    Else
                        Me.IsChecked = True
                    End If
                End If
            End If
        End Set
    End Property
    Public ReadOnly Property Image() As Image
        Get
            If String.IsNullOrEmpty(Me.ImageUrl) Then
                Return Nothing
            End If
            Return New Image()
        End Get
    End Property
    Private Sub UncheckOtherItemsInGroup()
        Dim groupItems As IEnumerable(Of MenuItem) = Me.Parent.Items.Where(Function(ByVal item As MenuItem) item.GroupName = Me.GroupName)
        For Each item As MenuItem In groupItems
            If item <> Me Then
                item.isChecked = False
                item.OnPropertyChanged("IsChecked")
            End If
        Next
    End Sub
    Private Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
' #endregion

' #region radchart-howto-integration-radcontextmenu_3
Public Class MenuItemsCollection
    Inherits ObservableCollection(Of MenuItem)
    Private m_parent As MenuItem
    Public Sub New()
        Me.New(Nothing)
    End Sub
    Public Sub New(ByVal parent As MenuItem)
        Me.m_parent = parent
    End Sub
    Public Property Parent() As MenuItem
        Get
            Return Me.m_parent
        End Get
        Set(ByVal value As MenuItem)
            Me.m_parent = value
        End Set
    End Property
    Protected Overloads Overrides Sub InsertItem(ByVal index As Integer, ByVal item As MenuItem)
        item.Parent = Me.Parent
        MyBase.InsertItem(index, item)
    End Sub
End Class
' #endregion

' #region radchart-howto-integration-radcontextmenu_5
Public Class ChartDataItem
    Implements INotifyPropertyChanged
    Private m_yValue As Double
    Private m_menuItems As MenuItemsCollection
    Public Event PropertyChanged As PropertyChangedEventHandler
    Public Property YValue() As Double
        Get
            Return Me.m_yValue
        End Get
        Set(ByVal value As Double)
            If Me.m_yValue <> value Then
                Me.m_yValue = value
                Me.OnPropertyChanged("YValue")
            End If
        End Set
    End Property
    Public ReadOnly Property MenuItems() As MenuItemsCollection
        Get
            If Me.m_menuItems Is Nothing Then
                Me.m_menuItems = New MenuItemsCollection()
            End If
            Return Me.m_menuItems
        End Get
    End Property
    Private Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
' #endregion

' #region radchart-howto-integration-radcontextmenu_7
Public Class ChartDataCollection
    Inherits ObservableCollection(Of ChartDataItem)
End Class
' #endregion

' #region radchart-howto-integration-radcontextmenu_9
Public Class ChartViewModel
    Private rand As New Random(DateTime.Now.Millisecond)
    Private m_data As ChartDataCollection
    Public ReadOnly Property Data() As ChartDataCollection
        Get
            If m_data Is Nothing Then
                m_data = New ChartDataCollection()
                m_data.Add(CreateChartDataItem("Test {0}"))
                m_data.Add(CreateChartDataItem("Foo {0}"))
                m_data.Add(CreateChartDataItem("Bar {0}"))
            End If
            Return m_data
        End Get
    End Property
    Private Function CreateChartDataItem(ByVal menuItemTextFormat As String) As ChartDataItem
        Dim item As New ChartDataItem()
        item.YValue = rand.[Next](10, 100)
        For i As Integer = 0 To rand.[Next](2, 5) - 1
            item.MenuItems.Add(New MenuItem())
        Next
        Return item
    End Function
End Class
' #endregion

' #region radchart-howto-integration-radcontextmenu_14
Me.DataContext = New ChartViewModel()
private void OnContextMenuClick(Object sender, Telerik.Windows.RadRoutedEventArgs e)
   ' Get the clicked item
   Dim menuItem As MenuItem = TryCast((TryCast(e.OriginalSource, RadMenuItem)).Header, MenuItem)
   If menuItem.Text = "Foo 0" Then
         '...
   End If
    ' #endregion

    ' #region radchart-howto-integration-radcontextmenu_20
    Dim menu As RadContextMenu = CType(sender, RadContextMenu)
    Dim clickedBar As Bar = menu.GetClickedElement(Of Bar)()
    Dim clickedBarYValue As Double = clickedBar.DataPoint.YValue
    ' #endregion
End Class
