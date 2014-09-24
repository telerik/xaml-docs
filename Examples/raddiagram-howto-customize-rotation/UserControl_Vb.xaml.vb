'#region raddiagram-howto-customize-rotation-0
Public Class MyRotation
    Inherits RotationService

    Private rStep As Integer

    Public Sub New(ByVal owner As RadDiagram)
        MyBase.New(TryCast(owner, IGraphInternal))
        Me.RotationStep = 1
    End Sub

    Public Property RotationStep() As Integer
        Get
            Return Me.rStep
        End Get
        Set(ByVal value As Integer)
            Me.rStep = value
        End Set
    End Property

    Protected Overrides Function CalculateRotationAngle(ByVal newPoint As Point) As Double
        Dim angle = MyBase.CalculateRotationAngle(newPoint)
        angle = Math.Floor(angle / Me.RotationStep) * Me.RotationStep
        Return angle
    End Function
End Class
' #endregion
'#region raddiagram-howto-customize-rotation-1
Private newRotationService As MyRotation
Private Sub InitializeNewServices()

    'initialize the newRotationService and define a default RotationStep
    Me.newRotationService = New MyRotation(Me.diagram) With {
        .RotationStep = 45
    }
    'create a binding with Path=RotationStep
    Dim binding As New Binding("RotationStep")
    'use the newRotationService as a source of the binding
    binding.Source = Me.newRotationService
    binding.Mode = BindingMode.TwoWay
    'apply the binding on the rotationStep TextBox
    Me.rotationStep.SetBinding(TextBox.TextProperty, binding)
End Sub
' #endregion
'#region raddiagram-howto-customize-rotation-2
Private newRotationService As MyRotation

Public Sub New()
    InitializeComponent()

    Me.InitializeNewServices()
    Me.diagram.ServiceLocator.Register(Of IRotationService)(Me.newRotationService)
End Sub
' #endregion