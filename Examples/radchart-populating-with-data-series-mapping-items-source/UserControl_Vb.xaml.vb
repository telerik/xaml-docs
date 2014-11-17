Public Class Default_Vb


' #region radchart-populating-with-data-series-mapping-items-source_1
Imports System
Imports System.Collections.ObjectModel
Namespace ChartDataSources
   Public Class MyDateObject
         Public Property Value() As Double
         Public Property Value2() As Double
         Public Sub New(ByVal value As Double, ByVal value2 As Double)
               Me.Value = value
               Me.Value2 = value2
         End Sub
         Public Shared Function GetData(ByVal count As Integer) As ObservableCollection(Of MyDateObject)
               Dim r As New Random()
               Dim result As New ObservableCollection(Of MyDateObject)()
               For i As Integer = 0 To count - 1
                     result.Add(New MyDateObject(r.Next(0, 100), r.Next(0, 100)))
               Next i
               Return result
         End Function
   End Class
End Namespace
' #endregion

' #region radchart-populating-with-data-series-mapping-items-source_3
Public Class MyViewModel
            Inherits ViewModelBase
            Private _data As ObservableCollection(Of MyDateObject)
            Public Property Data() As ObservableCollection(Of MyDateObject)
                  Get
                        Return Me._data
                  End Get
                  Set(ByVal value As ObservableCollection(Of MyDateObject))
                        If Me._data IsNot value Then
                              Me._data = value
                              Me.OnPropertyChanged("Data")
                        End If
                  End Set
            End Property
            Private _mappingData As ObservableCollection(Of MyDateObject)
            Public Property MappingData() As ObservableCollection(Of MyDateObject)
                  Get
                        Return Me._mappingData
                  End Get
                  Set(ByVal value As ObservableCollection(Of MyDateObject))
                        If Me._mappingData IsNot value Then
                              Me._mappingData = value
                              Me.OnPropertyChanged("MappingData")
                        End If
                  End Set
            End Property
            Public Sub New()
                  Me.Data = MyDateObject.GetData(10)
                  Me.MappingData = MyDateObject.GetData(20)
            End Sub
      End Class
' #endregion
End Class
