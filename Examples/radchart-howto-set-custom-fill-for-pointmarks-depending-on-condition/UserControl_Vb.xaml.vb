Public Class Default_Vb


' #region radchart-howto-set-custom-fill-for-pointmarks-depending-on-condition_1
Public Class Data
      Implements INotifyPropertyChanged
            Private _date As Date
            Private _pointMarkFill As SolidColorBrush
            Private _yvalue As Integer
            Public Sub New(ByVal [date] As Date, ByVal yvalue As Integer)
                  Me._date = [date]
                  Me._yvalue = yvalue
                  Me.UpdatePointMarkVisibility()
            End Sub
            Public Event PropertyChanged As PropertyChangedEventHandler
            Public Property [Date]() As Date
                  Get
                        Return _date
                  End Get
                  Set(ByVal value As Date)
                        If Me._date Is value Then
                              Return
                        End If
                        Me._date = value
                        Me.OnPropertyChanged("Date")
                  End Set
            End Property
            Public Property YValue() As Integer
                  Get
                        Return _yvalue
                  End Get
                  Set(ByVal value As Integer)
                        If Me._yvalue = value Then
                              Return
                        End If
                        Me._yvalue = value
                        Me.OnPropertyChanged("YValue")
                  End Set
            End Property
            Public Property PointMarkFill() As SolidColorBrush
                  Get
                        Return _pointMarkFill
                  End Get
                  Private Set(ByVal value As SolidColorBrush)
                        If Object.Equals(Me._pointMarkFill, value) Then
                              Return
                        End If
                        Me._pointMarkFill = value
                        Me.OnPropertyChanged("PointMarkVisibility")
                  End Set
            End Property
            Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
                  If Me.PropertyChangedEvent IsNot Nothing Then
                        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
                  End If
            End Sub
            Private Sub UpdatePointMarkVisibility()
                  If Me.YValue > 0 Then
                        Me.PointMarkFill = New SolidColorBrush(Colors.Red)
                  Else
                        Me.PointMarkFill = New SolidColorBrush(Colors.Blue)
                  End If
            End Sub
End Class
' #endregion

' #region radchart-howto-set-custom-fill-for-pointmarks-depending-on-condition_6
Dim exportData As New List(Of Data)()
Dim baseDate As Date = Date.Today
Dim r As New Random()
For i As Integer = 0 To 29
exportData.Add(New Data(baseDate.AddDays(i), r.Next(-20, 20)))
Next i
Dim mapping As New SeriesMapping()
mapping.ItemMappings.Add(New ItemMapping("YValue", DataPointMember.YValue))
mapping.ItemMappings.Add(New ItemMapping("Date", DataPointMember.XCategory))
chart.ItemsSource = exportData
chart.SeriesMappings.Add(mapping)
chart.DefaultView.ChartArea.AxisX.IsDateTime = True
chart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45
chart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MM-yy"
Dim line As New LineSeriesDefinition()
chart.DefaultSeriesDefinition = line
line.ShowPointMarks = True
line.ShowItemLabels = True
chart.DefaultSeriesDefinition.PointMarkItemStyle = TryCast(Me.Resources("MyPointMark_Style"), Style)
chart.DefaultSeriesDefinition.SeriesItemLabelStyle = TryCast(Me.Resources("MySeriesItemLabel_Style"), Style)
' #endregion
End Class
