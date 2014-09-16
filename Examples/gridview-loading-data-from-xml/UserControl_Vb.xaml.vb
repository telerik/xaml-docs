Public Class Default_Vb


' #region gridview-loading-data-from-xml_2
Public Class XmlNodeItem
Private _Team As String
    <XmlAttribute(AttributeName = "Team")> _
    Public Property Team() As String
        Get
            Return _Team
        End Get
        Set(ByVal value As String)
            _Team = value
        End Set
    End Property
Private _Country As String
    <XmlAttribute(AttributeName = "Country")> _
    Public Property Country() As String
        Get
            Return _Country
        End Get
        Set(ByVal value As String)
            _Country = value
        End Set
    End Property
End Class
' #endregion

' #region gridview-loading-data-from-xml_4
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

' #region gridview-loading-data-from-xml_6
Public Class RadGridViewXmlDataSource
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
End Class
