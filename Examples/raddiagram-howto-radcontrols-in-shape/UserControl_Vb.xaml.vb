'#region raddiagram-howto-radcontrols-in-shape-0
Public Class ProductSales
    Public Sub New(quantity As Integer, month As Integer, monthName As String)
        Me.Quantity = quantity
        Me.Month = month
        Me.MonthName = monthName
    End Sub

    Public Property Quantity() As Integer
        Get
            Return m_Quantity
        End Get
        Set(value As Integer)
            m_Quantity = Value
        End Set
    End Property
    Private m_Quantity As Integer
    Public Property Month() As Integer
        Get
            Return m_Month
        End Get
        Set(value As Integer)
            m_Month = Value
        End Set
    End Property
    Private m_Month As Integer
    Public Property MonthName() As String
        Get
            Return m_MonthName
        End Get
        Set(value As String)
            m_MonthName = Value
        End Set
    End Property
    Private m_MonthName As String
End Class
' #endregion
'#region raddiagram-howto-radcontrols-in-shape-1
Private Shared Function GetProductSales() As List(Of ProductSales)
    Dim persons = New List(Of ProductSales)() From {
        New ProductSales(154, 1, "January"),
        New ProductSales(138, 2, "February"),
        New ProductSales(143, 3, "March"),
        New ProductSales(120, 4, "April"),
        New ProductSales(135, 5, "May"),
        New ProductSales(125, 6, "June"),
        New ProductSales(179, 7, "July"),
        New ProductSales(170, 8, "August"),
        New ProductSales(198, 9, "September"),
        New ProductSales(187, 10, "October"),
        New ProductSales(193, 11, "November"),
        New ProductSales(212, 12, "December")
    }
    Return persons
End Function
Public Sub New()
    InitializeComponent()
    Me.DataContext = GetProductSales()
End Sub
' #endregion
'#region raddiagram-howto-radcontrols-in-shape-2
Public Sub New()
    InitializeComponent()
    Me.DataContext = GetProductSales()
    AddHandler Me.Loaded, AddressOf Me.OnLoaded
End Sub

Private Sub OnLoaded(sender As Object, routedEventArgs As RoutedEventArgs)
    ' the alternative to this code approach is to set the ContentTemplate in XAML
    ' See the documentation on this - http://www.telerik.com/help/wpf/raddiagrams-features-shapes.html
    Dim calendar = New RadDiagramShape() With {
            .Position = New Point(20, 150),
            .Content = New RadCalendar() With
                        {
                            .SelectedDate = DateTime.Now.AddDays(254),
                            .Margin = New Thickness(10)
                        },
            .Background = New SolidColorBrush(Colors.Blue),
            .BorderBrush = New SolidColorBrush(Colors.DarkGray),
            .BorderThickness = New Thickness(1),
            .UseGlidingConnector = True,
            .HorizontalContentAlignment = HorizontalAlignment.Stretch,
            .VerticalContentAlignment = VerticalAlignment.Stretch
    }
    Me.diagram.AddShape(calendar)
End Sub
' #endregion
'#region raddiagram-howto-radcontrols-in-shape-3
Private Sub OnLoaded(sender As Object, routedEventArgs As RoutedEventArgs)
    ' the alternative to this code-approach is to set the ContentTemplate in XAML
    ' See the documentation on this, http://www.telerik.com/help/wpf/raddiagrams-features-shapes.html
    Dim calendar = New RadDiagramShape() From {
                                                ...
                                              }
    Me.diagram.AddShape(calendar)

    Dim con = TryCast(Me.diagram.AddConnection(Me.diagram.Shapes(1), Me.diagram.Shapes(0)), RadDiagramConnection)
    con.Content = "Corresponds to"
    con.SourceCapType = CapType.Arrow6Filled
    con.TargetCapType = CapType.Arrow2Filled
End Sub
' #endregion
'#region raddiagram-howto-radcontrols-in-shape-0
' #endregion