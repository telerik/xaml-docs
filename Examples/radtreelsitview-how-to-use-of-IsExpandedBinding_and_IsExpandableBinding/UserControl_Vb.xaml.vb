Public Class Default_Vb


    ' #region radtreelsitview-how-to-use-of-IsExpandedBinding_and_IsExpandableBinding_1
    Dim radTreeListView As New RadTreeListView()
' #endregion

    ' #region radtreelsitview-how-to-use-of-IsExpandedBinding_and_IsExpandableBinding_3
    Public Class WarehouseItem
        Implements INotifyPropertyChanged
        Public Event PropertyChanged As PropertyChangedEventHandler

        Private m_isExpanded As Boolean
        Private m_name As String
        Private count As Integer

        Public Sub New(name As String, count As Integer, Optional isExpanded As Boolean = True)
            Me.Name = name
            Me.IsExpanded = isExpanded
        End Sub

        Public Property Name() As String
            Get
                Return Me.m_name
            End Get
            Set(value As String)
                If value <> Me.m_name Then
                    Me.m_name = value
                    Me.OnPropertyChanged("Name")
                End If
            End Set
        End Property

        Public Property IsExpanded() As Boolean
            Get
                Return Me.m_isExpanded
            End Get
            Set(value As Boolean)
                If value <> Me.m_isExpanded Then
                    Me.m_isExpanded = value
                    Me.OnPropertyChanged("IsExpanded")
                End If
            End Set
        End Property
        Protected Overridable Sub OnPropertyChanged(args As PropertyChangedEventArgs)
            Dim handler As PropertyChangedEventHandler = Me.PropertyChanged
            RaiseEvent handler(Me, args)
        End Sub

        Private Sub OnPropertyChanged(propertyName As String)
            Me.OnPropertyChanged(New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
' #endregion
End Class
