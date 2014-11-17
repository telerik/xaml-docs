'#region raddiagram-howto-customize-resizing-0
Public Class MyResizing
    Inherits ResizingService

    Public Sub New(ByVal owner As RadDiagram)
        MyBase.New(TryCast(owner, IGraphInternal))

    End Sub

    Protected Overrides Function CalculateNewDelta(ByVal newPoint As Point) As Point
        Return MyBase.CalculateNewDelta(newPoint)
    End Function
End Class
'#endregion
'#region raddiagram-howto-customize-resizing-1
Public Class MyResizing
    Inherits ResizingService
    Implements INotifyPropertyChanged

    Private resizeHeight As Boolean
    Private resizeWidth As Boolean

    Public Sub New(ByVal owner As RadDiagram)
        MyBase.New(TryCast(owner, IGraphInternal))
        'Initialize the boolean properties that will control the availability of the resizing
        Me.CanResizeWidth = True
        Me.CanResizeHeight = True
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property CanResizeWidth() As Boolean
        Get
            Return Me.resizeWidth
        End Get
        Set(ByVal value As Boolean)
            If Me.resizeWidth <> value Then
                Me.resizeWidth = value
                Me.OnPropertyChaged("CanResizeWidth")
            End If
        End Set
    End Property
    Public Property CanResizeHeight() As Boolean
        Get
            Return Me.resizeHeight
        End Get
        Set(ByVal value As Boolean)
            If Me.resizeHeight <> value Then
                Me.resizeHeight = value
                Me.OnPropertyChaged("CanResizeHeight")
            End If
        End Set
    End Property

    Protected Overrides Function CalculateNewDelta(ByVal newPoint As Point) As Point
        'calculate the size change using the defaul calulation mechanism
        Dim newDelta = MyBase.CalculateNewDelta(newPoint)
        'use the boolean properties to determine whether to apply any changes in the size of the manipulated item
        Return New Point(If(Me.CanResizeWidth, newDelta.X, 0), If(Me.CanResizeHeight, newDelta.Y, 0))
    End Function

    Private Sub OnPropertyChaged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
End Class
'#endregion
'#region raddiagram-howto-customize-resizing-2
Private newResizingService As MyResizing

Public Sub New()
    InitializeComponent()

    Me.InitializeNewServices()
End Sub

Private Sub InitializeNewServices()
    'initialize the newResizingService
    Me.newResizingService = New MyResizing(Me.diagram)
    'create a binding with Path=CanResizeWidth
    Dim binding As New Binding("CanResizeWidth")
    'use the newResizingService as a source of the binding
    binding.Source = Me.newResizingService
    binding.Mode = BindingMode.TwoWay
    'apply the binding on the resizeWidth RadToggleButton
    Me.resizeWidth.SetBinding(RadToggleButton.IsCheckedProperty, binding)

    'create a binding with Path=CanResizeHeight
    binding = New Binding("CanResizeHeight")
    'use the newResizingService as a source of the binding
    binding.Source = Me.newResizingService
    binding.Mode = BindingMode.TwoWay
    'apply the binding on the resizeHeight RadToggleButton
    Me.resizeHeight.SetBinding(RadToggleButton.IsCheckedProperty, binding)
End Sub
'#endregion
'#region raddiagram-howto-customize-resizing-3
Public Sub New()
    InitializeComponent()

    Me.InitializeNewServices()

    Me.diagram.ServiceLocator.Register(Of IResizingService)(Me.newResizingService)
End Sub
'#endregion