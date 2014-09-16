Public Class Default_Vb


' #region radtimebar-populating-timebar-from-wcf-service-with-linq-to-sql_1
<ServiceContract>
Public Interface IService
<OperationContract>
Function GetTimeBarData() As List(Of SampleTable)
End Interface
' #endregion

' #region radtimebar-populating-timebar-from-wcf-service-with-linq-to-sql_3
Public Class Service
Implements IService
Public Function GetTimeBarData() As List(Of SampleTable)
Dim context As New TimeBarSampleDataContext()
Dim data = (
From tb In context.SampleTables
Select tb).ToList()
Return data
End Function
End Class
' #endregion

' #region radtimebar-populating-timebar-from-wcf-service-with-linq-to-sql_6
Public Class ViewModel
      Implements INotifyPropertyChanged
            Private _StartDate As Date = Date.MinValue
            Private _EndDate As Date = Date.MinValue
            Private _VisibleStartDate As Date = Date.MinValue
            Private _VisibleEndDate As Date = Date.MinValue
            Private _SelectionStartDate As Date = Date.MinValue
            Private _SelectionEndDate As Date = Date.MinValue
            Public Sub New()
                  ' Create a new instance of the web service and get the data from the table
                  Dim service As New ServiceClient()
                  AddHandler service.GetTimeBarDataCompleted, AddressOf service_GetTimeBarDataCompleted
                  service.GetTimeBarDataAsync()
            End Sub
            Private Sub service_GetTimeBarDataCompleted(ByVal sender As Object, ByVal e As GetTimeBarDataCompletedEventArgs)
                  Dim dataCollection As New List(Of SampleTable)(e.Result)
                  If dataCollection IsNot Nothing Then
                        Dim data = dataCollection.Where(Function(d) d.Id = 1).FirstOrDefault()
                        Me.SetDataContent(data)
                  End If
            End Sub
            Private Sub SetDataContent(ByVal data As SampleTable)
                  Me.StartDate = data.PeriodStart.Value
                  Me.EndDate = data.PeriodEnd.Value
                  Me.VisibleStartDate = data.VisiblePeriodStart.Value
                  Me.VisibleEndDate = data.VisiblePeriodEnd.Value
                  Me.SelectionStartDate = data.SelectionStart.Value
                  Me.SelectionEndDate = data.SelectionEnd.Value
            End Sub
            Public Property StartDate() As Date
                  Get
                        Return _StartDate
                  End Get
                  Set(ByVal value As Date)
                        If Me._StartDate Is value Then
                              Return
                        End If
                        Me._StartDate = value
                        Me.RaisePropertyChanged("StartDate")
                  End Set
            End Property
            Public Property EndDate() As Date
                  Get
                        Return _EndDate
                  End Get
                  Set(ByVal value As Date)
                        If Me._EndDate Is value Then
                              Return
                        End If
                        Me._EndDate = value
                        Me.RaisePropertyChanged("EndDate")
                  End Set
            End Property
            Public Property VisibleStartDate() As Date
                  Get
                        Return _VisibleStartDate
                  End Get
                  Set(ByVal value As Date)
                        If Me._VisibleStartDate Is value Then
                              Return
                        End If
                        Me._VisibleStartDate = value
                        Me.RaisePropertyChanged("VisibleStartDate")
                  End Set
            End Property
            Public Property VisibleEndDate() As Date
                  Get
                        Return _VisibleEndDate
                  End Get
                  Set(ByVal value As Date)
                        If Me._VisibleEndDate Is value Then
                              Return
                        End If
                        Me._VisibleEndDate = value
                        Me.RaisePropertyChanged("VisibleEndDate")
                  End Set
            End Property
            Public Property SelectionStartDate() As Date
                  Get
                        Return _SelectionStartDate
                  End Get
                  Set(ByVal value As Date)
                        If Me._SelectionStartDate Is value Then
                              Return
                        End If
                        Me._SelectionStartDate = value
                        Me.RaisePropertyChanged("SelectionStartDate")
                  End Set
            End Property
            Public Property SelectionEndDate() As Date
                  Get
                        Return _SelectionEndDate
                  End Get
                  Set(ByVal value As Date)
                        If Me._SelectionEndDate Is value Then
                              Return
                        End If
                        Me._SelectionEndDate = value
                        Me.RaisePropertyChanged("SelectionEndDate")
                  End Set
            End Property
            Public Event PropertyChanged As PropertyChangedEventHandler
            Public Sub RaisePropertyChanged(ByVal propertyName As String)
                  RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End Sub
End Class
' #endregion
End Class
