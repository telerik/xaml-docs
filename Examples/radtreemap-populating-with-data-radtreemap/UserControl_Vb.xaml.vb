Public Class Default_Vb


    ' #region radtreemap-populating-with-data-radtreemap_1
    Public Interface IDiskItem
        ReadOnly Property Name() As String
        ReadOnly Property Size() As Long
        ReadOnly Property Children() As IEnumerable(Of IDiskItem)
    End Interface
    ' #endregion

    ' #region radtreemap-populating-with-data-radtreemap_3
    Public Class Folder
        Implements IDiskItem
        Private _name As String
        Private _children As IEnumerable(Of IDiskItem)
        Public Sub New(ByVal name As String, ByVal children As IEnumerable(Of IDiskItem))
            Me._name = name
            Me._children = children
        End Sub
        Public ReadOnly Property Name() As String
            Get
                Return _name
            End Get
        End Property
        Public ReadOnly Property Size() As Long
            Get
                Return Me.Children.Sum(Function(child) child.Size)
            End Get
        End Property
        Public ReadOnly Property Children() As IEnumerable(Of IDiskItem)
            Get
                Return _children
            End Get
        End Property
    End Class
    Public Class File
        Implements IDiskItem
        Private _name As String
        Private _size As Long
        Public Sub New(ByVal name As String, ByVal size As Long)
            Me._name = name
            Me._size = size
        End Sub
        Public ReadOnly Property Name() As String
            Get
                Return _name
            End Get
        End Property
        Public ReadOnly Property Size() As Long
            Get
                Return _size
            End Get
        End Property
        Public ReadOnly Property Children() As IEnumerable(Of IDiskItem)
            Get
                Return Nothing
            End Get
        End Property
    End Class
    ' #endregion

    '#region radtreemap-populating-with-data-radtreemap_5
    Public Sub New() ' MainWindow in WPF
        InitializeComponent()
			Dim datasource = New List(Of IDiskItem)() From {New Folder("Windows", New List(Of IDiskItem)() With { New Folder("Fonts", New List(Of IDiskItem)() With { New File("Arial", 256), New File("Tahoma", 246)}), New Folder("Logs", New List(Of IDiskItem)() With { New File("Log1.log", 112), New File("Log2.log", 156)}) }), New Folder ("My Documents", New List(Of IDiskItem)() With { New File("Document1.txt", 88), New File("Document2.txt", 55)}), New File("pagefile.sys", 114)}
        treeMap1.ItemsSource = datasource
    End Sub
    '#endregion
End Class
