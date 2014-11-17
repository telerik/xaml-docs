Public Class Default_Vb


' #region consuming-data-isolated-storage_1
Dim isf As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
' #endregion

' #region consuming-data-isolated-storage_3
Dim isfs As New IsolatedStorageFileStream(fileName, FileMode.Open, isf)
' #endregion

' #region consuming-data-isolated-storage_5
Using sr As New StreamReader(isfs)
    Dim lineOfData As String = sr.ReadLine()
    While lineOfData IsNot Nothing
        data += lineOfData
        lineOfData = sr.ReadLine()
    End While
End Using
' #endregion

' #region consuming-data-isolated-storage_7
Private Function LoadData(ByVal fileName As String) As String
    Dim data As String = [String].Empty
    Using isf As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
        Using isfs As New IsolatedStorageFileStream(fileName, FileMode.Open, isf)
            Using sr As New StreamReader(isfs)
                Dim lineOfData As String = sr.ReadLine()
                While lineOfData IsNot Nothing
                    data += lineOfData
                    lineOfData = sr.ReadLine()
                End While
            End Using
        End Using
    End Using
    Return data
End Function
' #endregion
End Class
