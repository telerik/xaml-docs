' #region raddiagram-data-databinding-0
Public Interface IGraphSource
    ReadOnly Property Links() As IEnumerable(Of ILink)
    ReadOnly Property Items() As IEnumerable
End Interface

Public Interface IGraphSource(Of T)
    Inherits IGraphSource
    Shadows ReadOnly Property Links() As IEnumerable(Of ILink(Of T))
    Shadows ReadOnly Property Items() As IEnumerable(Of T)
End Interface
' #endregion

' #region raddiagram-data-databinding-1
Public Class PascalNode
    Public Property Position() As Point
    Public Property PascalNumber() As Integer
End Class
' #endregion

' #region raddiagram-data-databinding-2
Public Class PascalEdge
    Implements ILink(Of PascalNode)
    Public Property Source() As PascalNode

    Public Property Target() As PascalNode

    Private Property ILink_Source() As Object Implements ILink.Source
        Get
            Return Me.Source
        End Get
        Set(ByVal value As Object)
        End Set

    End Property

    Private Property ILink_Target() As Object Implements ILink.Target
        Get
            Return Me.Target
        End Get
        Set(ByVal value As Object)
        End Set
    End Property
End Class
' #endregion

' #region raddiagram-data-databinding-3
Public Class PascalTriangleGraphSource
    Implements IGraphSource
    Public Sub New()
        Me.InternalItems = New ObservableCollection(Of PascalNode)()
        Me.InternalEdges = New ObservableCollection(Of PascalEdge)()
    End Sub

    Private privateInternalItems As ObservableCollection(Of PascalNode)
    Public Property InternalItems() As ObservableCollection(Of PascalNode)
        Get
            Return privateInternalItems
        End Get
        Private Set(ByVal value As ObservableCollection(Of PascalNode))
            privateInternalItems = value
        End Set
    End Property

    Private privateInternalEdges As ObservableCollection(Of PascalEdge)
    Public Property InternalEdges() As ObservableCollection(Of PascalEdge)
        Get
            Return privateInternalEdges
        End Get
        Private Set(ByVal value As ObservableCollection(Of PascalEdge))
            privateInternalEdges = value
        End Set
    End Property

    Private ReadOnly Property Links() As IEnumerable(Of ILink) Implements IGraphSource.Links
        Get
            Return Me.InternalEdges
        End Get
    End Property

    Private ReadOnly Property Items() As System.Collections.IEnumerable Implements IGraphSource.Items
        Get
            Return Me.InternalItems
        End Get
    End Property
End Class
' #endregion

' #region raddiagram-data-databinding-4
Private Const ROOT_X_Position As Integer = 400
Private Const ROOT_Y_Position As Integer = 20
Private Const X_DELIMITER_WIDTH As Integer = 80
Private Const Y_DELIMITER_HEIGHT As Integer = 60
Private Const X_START_NEGATIVE_OFFSET As Integer = 40

Private Function CreatePascalTriangleGraphSource(ByVal levels As Integer) As IGraphSource
    Dim graph As New PascalTriangleGraphSource()
    For i As Integer = 0 To levels - 1
        For j As Integer = 0 To i
            Dim node As New PascalNode() With {.Position = New Point() With {.Y = ROOT_Y_Position + i * Y_DELIMITER_HEIGHT, .X = ROOT_X_Position - i * X_START_NEGATIVE_OFFSET + j * X_DELIMITER_WIDTH}, .PascalNumber = Binom(i, j)}
            graph.InternalItems.Add(node)
            Dim currIndex As Integer = i * (i + 1) / 2 + j
            If j = 0 Then
                graph.InternalEdges.Add(New PascalEdge() With {.Source = graph.InternalItems(currIndex - i), .Target = node})
            End If
            If j = i AndAlso i <> 0 Then
                graph.InternalEdges.Add(New PascalEdge() With {.Source = graph.InternalItems(currIndex - i - 1), .Target = node})
            End If
            If 0 < j AndAlso j < i Then
                graph.InternalEdges.Add(New PascalEdge() With {.Source = graph.InternalItems(currIndex - i - 1), .Target = node})
                graph.InternalEdges.Add(New PascalEdge() With {.Source = graph.InternalItems(currIndex - i), .Target = node})
            End If
        Next j
    Next i
    Return graph
End Function

Private Function Binom(ByVal n As Integer, ByVal k As Integer) As Integer
    Return FactN(n) / (FactN(k) * FactN(n - k))
End Function

Private Function FactN(ByVal n As Integer) As Integer
    If n = 0 OrElse n = 1 Then
        Return 1
    End If
    Dim res As Integer = 1
    For i As Integer = 1 To n
        res = res * i
    Next i
    Return res
End Function
' #endregion
' #region raddiagram-data-databinding-5
Public Class Person
	Inherits NodeViewModelBase
	Public Sub New(name As String)
		Me.Name = name
	End Sub

	Public Property Name() As String
		Get
			Return Me.Content.ToString()
		End Get
		Set
			Me.Content = value
			Me.OnPropertyChanged("Name")
		End Set
	End Property

	Public Overrides Function ToString() As String
		Return Me.Name
	End Function
End Class
' #endregion
' #region raddiagram-data-databinding-6
Public Class DataStore
	Inherits ObservableGraphSourceBase(Of NodeViewModelBase, LinkViewModelBase(Of NodeViewModelBase))
	Public Sub New()
		Me.AddNode(New Person("Johnny Carter"))
		Me.AddNode(New Person("Alexandra Morgan"))
		Me.AddNode(New Person("Jeff Kadensky"))
	End Sub

	Public Overrides Sub AddNode(node As NodeViewModelBase)
		If Not (TypeOf node Is Person) Then
			node = New Person("New Person!")
		End If
		MyBase.AddNode(node)
	End Sub
End Class
' #endregion
