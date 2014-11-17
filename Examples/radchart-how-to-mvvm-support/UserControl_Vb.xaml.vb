Public Class Default_Vb


' #region radchart-how-to-mvvm-support_1
Public Class Person
    Implements INotifyPropertyChanged
    Private m_grade As Double
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Private Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Property Grade() As Double
        Get
            Return Me.m_grade
        End Get
        Set(ByVal value As Double)
            Me.m_grade = value
            Me.OnPropertyChanged("Grade")
        End Set
    End Property
    Public Sub New(ByVal name__1 As String, ByVal grade__2 As Double)
        Name = name__1
        Grade = grade__2
    End Sub
    Public Event PropertyChanged As PropertyChangedEventHandler
    Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
' #endregion

' #region radchart-how-to-mvvm-support_3
Public Class PersonViewModel
    Implements INotifyPropertyChanged
    Private _person As Person
    Public Property Person() As Person
        Get
            Return _person
        End Get
        Private Set(ByVal value As Person)
            _person = value
        End Set
    End Property
    Private _gradeColor As Brush
    Public Property GradeColor() As Brush
        Get
            Return _gradeColor
        End Get
        Private Set(ByVal value As Brush)
            _gradeColor = value
        End Set
    End Property
    Public Sub New(ByVal person As Person)
        Me.Person = person
        person.PropertyChanged += HandleStudentPropertyChanged
        Me.UpdateGradeColor()
    End Sub
    Private Sub HandleStudentPropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
        If e.PropertyName = "Grade" Then
            Me.UpdateGradeColor()
        End If
    End Sub
    Private Sub UpdateGradeColor()
        If Me.Person.Grade < 10 Then
            Me.GradeColor = Me.CreateBrush("#FFFF3D40")
        ElseIf Me.Person.Grade < 20 Then
            Me.GradeColor = Me.CreateBrush("#FFFD583A")
        ElseIf Me.Person.Grade < 30 Then
            Me.GradeColor = Me.CreateBrush("#FFFD8145")
        ElseIf Me.Person.Grade < 40 Then
            Me.GradeColor = Me.CreateBrush("#FFFAA03D")
        ElseIf Me.Person.Grade < 50 Then
            Me.GradeColor = Me.CreateBrush("#FFFAC741")
        ElseIf Me.Person.Grade < 60 Then
            Me.GradeColor = Me.CreateBrush("#FFFCED40")
        ElseIf Me.Person.Grade < 70 Then
            Me.GradeColor = Me.CreateBrush("#FFD7FC3C")
        ElseIf Me.Person.Grade < 80 Then
            Me.GradeColor = Me.CreateBrush("#FF99F839")
        ElseIf Me.Person.Grade < 90 Then
            Me.GradeColor = Me.CreateBrush("#FF46E633")
        Else
            Me.GradeColor = Me.CreateBrush("#FF1CD64D")
        End If
        Me.OnPropertyChanged("GradeColor")
    End Sub
    Public Event PropertyChanged As PropertyChangedEventHandler
    Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
    Private Function CreateBrush(ByVal color As String) As Brush
        Return New SolidColorBrush(Me.GetColorFromHexString(color))
    End Function
    Private Function GetColorFromHexString(ByVal s As String) As Color
        s = s.Replace("#", String.Empty)
        Dim a As Byte = System.Convert.ToByte(s.Substring(0, 2), 16)
        Dim r As Byte = System.Convert.ToByte(s.Substring(2, 2), 16)
        Dim g As Byte = System.Convert.ToByte(s.Substring(4, 2), 16)
        Dim b As Byte = System.Convert.ToByte(s.Substring(6, 2), 16)
        Return Color.FromArgb(a, r, g, b)
    End Function
End Class
' #endregion

' #region radchart-how-to-mvvm-support_6
Private Sub MVVM_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
    radChart.DefaultView.ChartArea.AxisY.AutoRange = False
    radChart.DefaultView.ChartArea.AxisY.MinValue = 0
    radChart.DefaultView.ChartArea.AxisY.MaxValue = 100
    radChart.DefaultView.ChartArea.AxisY.[Step] = 10
    radChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed
    radChart.DefaultSeriesDefinition = New BarSeriesDefinition()
    Dim seriesMapping As New SeriesMapping()
    seriesMapping.ItemMappings.Add(New ItemMapping("Person.Grade", DataPointMember.YValue))
    seriesMapping.ItemMappings.Add(New ItemMapping("Person.Name", DataPointMember.XCategory))
    radChart.SeriesMappings.Add(seriesMapping)
    radChart.ItemsSource = Me.GetData()
End Sub
' #endregion

' #region radchart-how-to-mvvm-support_8
Private Function GetData() As List(Of PersonViewModel)
    Dim rand As New Random(DateTime.Now.Millisecond)
    Dim studentList As New List(Of Person)()
    For i As Integer = 0 To rand.[Next](9, 12) - 1
        studentList.Add(New Person("Person" & i, rand.[Next](15, 100)))
    Next
    Dim modelList As New List(Of PersonViewModel)()
    For Each person As Person In studentList
        modelList.Add(New PersonViewModel(person))
    Next
    Return modelList
End Function
' #endregion

' #region radchart-how-to-mvvm-support_10
Public Function BuildCustomItemStyle(item As Control, style As Style, point As DataPoint, dataSeries As DataSeries) As Style
 If TryCast(item, BaseChartItem) Is Nothing Then
  Return style
 End If
 Dim newStyle As New Style()
 newStyle.BasedOn = style
 newStyle.TargetType = GetType(Shape)
 Dim brush As Brush = TryCast(dataSeries(TryCast(item, BaseChartItem).CurrentIndex).DataItem, PersonViewModel).GradeColor
 newStyle.Setters.Add(New Setter(Shape.FillProperty, brush))
 Return newStyle
End Function
' #endregion

' #region radchart-how-to-mvvm-support_12
Me.radChart.CreateItemStyleDelegate = Me.BuildCustomItemStyle;
' #endregion

' #region radchart-how-to-mvvm-support_15
radChart.DefaultSeriesDefinition.SeriesItemLabelStyle = TryCast(Me.Resources("MySeriesItemLabel_Style"), Style)
' #endregion
End Class
