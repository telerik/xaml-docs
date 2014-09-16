Public Class Default_Vb


' #region consuming-data-using-xml_1
Private Function RetrieveData() As XmlNodeItemList
    Dim xmlDocument As String = "/DataSource/XmlData.xml"
    ' 1. Get the resource stream for the file located in the application package.
    Dim xmlStream As Stream = Application.GetResourceStream(New Uri(xmlDocument, UriKind.Relative)).Stream
    ' 1. Get the stream for the file located on the local hard drive.
    Dim xmlStream As Stream = File.Open(xmlDocument, FileMode.Open)
    ' 2. Create a new instance of the XmlSerializer class.
    Dim serializer As New XmlSerializer(GetType(XmlNodeItemList))
    ' 3. Create a new instance of the StreamReader class.
    Dim reader As New StreamReader(xmlStream)
    ' 4. Deserialize the data
    Dim list As XmlNodeItemList = DirectCast(serializer.Deserialize(reader), XmlNodeItemList)
End Function
' #endregion

' #region consuming-data-using-xml_3
Dim myXML As XDocument = XDocument.Load("MyXML.xml")
' #endregion

' #region consuming-data-using-xml_5
Dim personsList As List(Of Person) = (From person In myXml.Descendants("person") _
    Where DirectCast(person.Element("address").Attribute("country"), String).Equals("Bulgaria") _
    Select New Person()).ToList()
' #endregion

' #region consuming-data-using-xml_7
Using reader As XmlReader = XmlReader.Create(New StringReader(xmlString))
    Dim ws As New XmlWriterSettings()
    ws.Indent = True
    Using writer As XmlWriter = XmlWriter.Create(output, ws)
        ' Parse the file and display each of the nodes.
        While reader.Read()
            Select Case reader.NodeType
                Case XmlNodeType.Element
                    writer.WriteStartElement(reader.Name)
                    Exit Select
                Case XmlNodeType.Text
                    writer.WriteString(reader.Value)
                    Exit Select
                Case XmlNodeType.XmlDeclaration, XmlNodeType.ProcessingInstruction
                    writer.WriteProcessingInstruction(reader.Name, reader.Value)
                    Exit Select
                Case XmlNodeType.Comment
                    writer.WriteComment(reader.Value)
                    Exit Select
                Case XmlNodeType.EndElement
                    writer.WriteFullEndElement()
                    Exit Select
            End Select
        End While
    End Using
End Using
' #endregion
End Class
