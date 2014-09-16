Public Class Default_Vb


' #region radmap-features-sql-geospatial-data_4
Public Class DataBaseContext
      Inherits Database1Entities1
      Implements INotifyPropertyChanged
            Public Sub New()
                  MyBase.New(New Uri("http://localhost:6838/WcfDataService1.svc"))
            End Sub
            Private locationsWKBs_Renamed As IEnumerable
            Public Shadows Property LocationsWKBs() As IEnumerable
                  Get
                        If Me.locationsWKBs_Renamed Is Nothing Then
                              Dim query = MyBase.LocationsWKBs
                              Me.RunDataServiceQuery(query)
                        End If
                        Return Me.locationsWKBs_Renamed
                  End Get
                  Set(ByVal value As IEnumerable)
                        Me.locationsWKBs_Renamed = value
                        Me.OnPropertyChanged("LocationsWKBs")
                  End Set
            End Property
            Public Sub RunDataServiceQuery(Of T)(ByVal query As IQueryable(Of T))
                  Dim entity = New DataServiceCollection(Of T)()
                  AddHandler entity.LoadCompleted, AddressOf entity_LoadCompleted
                  entity.LoadAsync(query)
            End Sub
            Private Sub entity_LoadCompleted(ByVal sender As Object, ByVal e As LoadCompletedEventArgs)
                  Me.LocationsWKBs = TryCast(sender, IEnumerable)
            End Sub
            Public Event PropertyChanged As PropertyChangedEventHandler
            Private Sub OnPropertyChanged(ByVal name As String)
                  Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
                  If handler IsNot Nothing Then
                        handler(Me, New PropertyChangedEventArgs(name))
                  End If
            End Sub
End Class
' #endregion
End Class
