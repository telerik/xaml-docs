Public Class Default_Vb


' #region radtimebar-mvvm-support_1
Public Class ExampleViewModel Inherits ViewModelBase
            Private periodStart_Renamed As Date
            Private periodEnd_Renamed As Date
            Private data_Renamed As IEnumerable(Of Double)
            Private visiblePeriodStart_Renamed As Date
            Private visiblePeriodEnd_Renamed As Date
            <TypeConverter(GetType(DateTimeTypeConverter))>
            Public Property PeriodStart() As Date
                  Get
                        Return Me.periodStart_Renamed
                  End Get
                  Set(ByVal value As Date)
                        If Me.periodStart_Renamed Is value Then
                              Return
                        End If
                        Me.periodStart_Renamed = value
                        Me.OnPropertyChanged("PeriodStart")
                  End Set
            End Property
            <TypeConverter(GetType(DateTimeTypeConverter))>
            Public Property PeriodEnd() As Date
                                                Get
                        Return Me.periodEnd_Renamed
                  End Get
                  Set(ByVal value As Date)
                        If Me.periodEnd_Renamed Is value Then
                              Return
                        End If
                        Me.periodEnd_Renamed = value
                        Me.OnPropertyChanged("PeriodEnd")
                  End Set
            End Property
            <TypeConverter(GetType(DateTimeTypeConverter))>
            Public Property VisiblePeriodStart() As Date
                  Get
                        Return Me.visiblePeriodStart_Renamed
                  End Get
                  Set(ByVal value As Date)
                        If Me.visiblePeriodStart_Renamed Is value Then
                              Return
                        End If
                        Me.visiblePeriodStart_Renamed = value
                        Me.OnPropertyChanged("VisiblePeriodStart")
                  End Set
            End Property
            <TypeConverter(GetType(DateTimeTypeConverter))>
            Public Property VisiblePeriodEnd() As Date
                  Get
                        Return Me.visiblePeriodEnd_Renamed
                  End Get
                  Set(ByVal value As Date)
                        If Me.visiblePeriodEnd_Renamed Is value Then
                              Return
                        End If
                        Me.visiblePeriodEnd_Renamed = value
                        Me.OnPropertyChanged("VisiblePeriodEnd")
                  End Set
            End Property
            Public ReadOnly Property Data() As IEnumerable(Of Double)
                  Get
                        If data_Renamed Is Nothing Then
                              Dim r As New Random()
                              Dim collection As New List(Of Double)()
                              Dim [date] As Date = PeriodStart
                              Do While [date] <= PeriodEnd
                                    collection.Add(r.Next(0, 100))
                                    [date] = [date].AddDays(1)
                              Loop
                              Me.data_Renamed = collection
                        End If
                        Return Me.data_Renamed
                  End Get
            End Property
End Class
' #endregion
End Class
