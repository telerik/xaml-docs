Public Class Default_Vb


' #region radtreeview-populating-with-data-data-binding-to-xml_2
Public Class XmlNodeItem
    Public Sub New()
        Me.Items = New ObservableCollection(Of XmlNodeItem)()
    End Sub
Private _Header As String
    <XmlAttribute(AttributeName = "Header")> _
    Public Property Header() As String
        Get
            Return _Header
        End Get
        Set(ByVal value As String)
            _Header = value
        End Set
    End Property
Private _Items As ObservableCollection(Of XmlNodeItem)
    Public Property Items() As ObservableCollection(Of XmlNodeItem)
        Get
            Return _Items
        End Get
        Set(ByVal value As ObservableCollection(Of XmlNodeItem))
            _Items = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-populating-with-data-data-binding-to-xml_4
<XmlRoot(ElementName = "Items")> _
Public Class XmlNodeItemList
    Inherits ObservableCollection(Of XmlNodeItem)
    Public Sub AddRange(ByVal range As IEnumerable(Of XmlNodeItem))
        For Each node As XmlNodeItem In range
            Me.Add(node)
        Next
    End Sub
End Class
' #endregion

' #region radtreeview-populating-with-data-data-binding-to-xml_7
Public Class RadTreeViewXmlDataSource
    Inherits XmlNodeItemList
    Private m_source As String
    Public Property Source() As String
        Get
            Return Me.m_source
        End Get
        Set(ByVal value As String)
            Me.m_source = value
            AddRange(RetrieveData(Application.GetResourceStream(New Uri(value, UriKind.Relative)).Stream))
        End Set
    End Property
    Private Function RetrieveData(ByVal xmlStream As Stream) As XmlNodeItemList
        Dim serializer As New XmlSerializer(GetType(XmlNodeItemList))
        Dim reader As New StreamReader(xmlStream)
        Dim list As XmlNodeItemList = DirectCast(serializer.Deserialize(reader), XmlNodeItemList)
        Return list
    End Function
End Class
' #endregion

' #region radtreeview-populating-with-data-data-binding-to-xml_8
Public Class RadTreeViewXmlDataSource
    Inherits XmlNodeItemList
    Private m_source As String
    Public Property Source() As String
        Get
            Return Me.m_source
        End Get
        Set(ByVal value As String)
            Me.m_source = value
            AddRange(RetrieveData(File.Open(value, FileMode.Open)))
        End Set
    End Property
    Private Function RetrieveData(ByVal xmlStream As Stream) As XmlNodeItemList
        Dim serializer As New XmlSerializer(GetType(XmlNodeItemList))
        Dim reader As New StreamReader(xmlStream)
        Dim list As XmlNodeItemList = DirectCast(serializer.Deserialize(reader), XmlNodeItemList)
        Return list
    End Function
End Class
' #endregion
End Class
