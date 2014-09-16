'#region raddiagrams-howto-serialize-databound-diagram-0
Public Class OrgItem
    Inherits HierarchicalNodeViewModel
    Public Sub New()
    End Sub

    Public Sub New(title As String)
        Me.Title = title
    End Sub

    Private m_title As String
    Public Property Title() As String
        Get
            Return Me.m_title
        End Get
        Set(value As String)
            If Me.m_title <> value Then
                Me.m_title = value
                Me.OnPropertyChanged("Title")
            End If
        End Set
    End Property

    Public Property Id() As String
        Get
            Return m_Id
        End Get
        Set(value As String)
            m_Id = Value
        End Set
    End Property
    Private m_Id As String
End Class

Public Class OrgLink
    Inherits LinkViewModelBase(Of OrgItem)
    Public Sub New()
    End Sub

    Public Sub New(source As OrgItem, target As OrgItem)
        MyBase.New(source, target)
    End Sub

    Public Property Id() As String
        Get
            Return m_Id
        End Get
        Set(value As String)
            m_Id = Value
        End Set
    End Property
    Private m_Id As String
End Class
'#endregion
'#region raddiagrams-howto-serialize-databound-diagram-1
Public Class GraphSource
    Inherits SerializableGraphSourceBase(Of OrgItem, OrgLink)

    Public Overrides Function GetNodeUniqueId(node As OrgItem) As String
        Return node.Id
    End Function

    Public Overrides Sub SerializeNode(node As OrgItem, info As Telerik.Windows.Diagrams.Core.SerializationInfo)
        MyBase.SerializeNode(node, info)
        info("Title") = node.Title
    End Sub

    Public Overrides Function DeserializeNode(shape As Telerik.Windows.Diagrams.Core.IShape, info As Telerik.Windows.Diagrams.Core.SerializationInfo) As OrgItem
        MyBase.DeserializeNode(shape, info)
        If info("Title") IsNot Nothing Then
            Return New OrgItem(info("Title").ToString())
        End If
        Return Nothing
    End Function
End Class
'#endregion
'#region raddiagrams-howto-serialize-databound-diagram-2
Public Sub New()
    InitializeComponent()
    BindGraphSource()
End Sub
Private Sub BindGraphSource()
    Dim uniqueIdCounter As Integer = 0
    Dim source As New GraphSource()
    Dim rootItem As New OrgItem() With {
         .Title = "CEO",
         .Position = New Point(200, 20),
         .Id = (System.Math.Max(System.Threading.Interlocked.Increment(uniqueIdCounter), uniqueIdCounter - 1)).ToString()
    }
    source.AddNode(rootItem)

    Dim unitOne As New OrgItem() With {
         .Title = "Unit Manager USA",
         .Position = New Point(100, 100),
         .Id = (System.Math.Max(System.Threading.Interlocked.Increment(uniqueIdCounter), uniqueIdCounter - 1)).ToString()
    }
    source.AddNode(unitOne)
    source.AddLink(New OrgLink(rootItem, unitOne) With {
         .Id = (System.Math.Max(System.Threading.Interlocked.Increment(uniqueIdCounter), uniqueIdCounter - 1)).ToString()
    })

    Dim unitTwo As New OrgItem() With {
         .Title = "Unit Manager Europe",
         .Position = New Point(300, 100),
         .Id = (System.Math.Max(System.Threading.Interlocked.Increment(uniqueIdCounter), uniqueIdCounter - 1)).ToString()
    }
    source.AddNode(unitTwo)
    source.AddLink(New OrgLink(rootItem, unitTwo) With {
         .Id = (System.Math.Max(System.Threading.Interlocked.Increment(uniqueIdCounter), uniqueIdCounter - 1)).ToString()
    })

    Me.xDiagram.GraphSource = source
End Sub
'#endregion
'#region raddiagrams-howto-serialize-databound-diagram-3
Private diagramXMLString As String
Private Sub CommandBinding_Executed_Save(sender As Object, e As ExecutedRoutedEventArgs)
    diagramXMLString = Me.xDiagram.Save()
End Sub

Private Sub CommandBinding_Executed_Open(sender As Object, e As ExecutedRoutedEventArgs)
    If diagramXMLString IsNot Nothing Then
        Me.xDiagram.Load(diagramXMLString)
    End If
End Sub

Private Sub CommandBinding_CanExecute(sender As Object, e As CanExecuteRoutedEventArgs)
    e.CanExecute = Me.xDiagram.Items.Count > 0
End Sub
'#endregion