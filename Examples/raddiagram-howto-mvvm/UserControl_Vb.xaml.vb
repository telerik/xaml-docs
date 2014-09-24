'#region raddiagram-howto-mvvm-0
Imports Telerik.Windows.Controls.Diagrams.Extensions.ViewModels
Public Class DiagramViewModel
    Inherits GraphSourceBase(Of NodeViewModelBase, LinkViewModelBase(Of NodeViewModelBase))
    Public Sub New()
        Dim first = New NodeViewModelBase With {.Content = "First item", .Position = New Point(50, 100)}
        Dim second = New NodeViewModelBase With {.Content = "Second item", .Position = New Point(150, 100), .RotationAngle = 45}
        Dim third = New NodeViewModelBase With {.Content = "Third item", .Position = New Point(250, 100)}
        Me.AddNode(first)
        Me.AddNode(second)
        Me.AddNode(third)
        Me.AddLink(New LinkViewModelBase(Of NodeViewModelBase)(first, second))
        Me.AddLink(New LinkViewModelBase(Of NodeViewModelBase)(second, third))
    End Sub
End Class
'#endregion
'#region raddiagram-howto-mvvm-1
xDiagram.GraphSource = New DiagramViewModel()
'#endregion
'#region raddiagram-howto-mvvm-2
Public Class Brand
    Inherits ContainerNodeViewModelBase(Of Object)
End Class
Public Class Model
    Inherits NodeViewModelBase

End Class
Public Class Link
    Inherits LinkViewModelBase(Of NodeViewModelBase)

End Class
Public Class CarsGraphSource
    Inherits ObservableGraphSourceBase(Of NodeViewModelBase, Link)
    Public Sub New()
        Dim vwGroup As New Brand() With {
             .Content = "Volkswagen Group",
             .Position = New Point(250, 100)
        }

        Dim bentley As New Brand() With {
             .Content = "Bentley",
             .Position = New Point(250, 100)
        }
        Dim continental As New Model() With {
             .Content = "Continental GT",
             .Position = New Point(250, 100)
        }
        bentley.AddItem(continental)
        vwGroup.AddItem(bentley)

        Dim bugatti As New Brand() With {
             .Content = "Bugatti",
             .Position = New Point(475, 100)
        }
        Dim veyron As New Model() With {
             .Content = "Bugatti Veyron",
             .Position = New Point(475, 100)
        }
        bugatti.AddItem(veyron)
        vwGroup.AddItem(bugatti)

        Dim vw As New Brand() With {
             .Content = "Volkswagen",
             .Position = New Point(220, 400)
        }
        Dim polo As New Model() With {
             .Content = "Polo",
             .Position = New Point(220, 400)
        }
        Dim golf As New Model() With {
             .Content = "Golf",
             .Position = New Point(340, 400)
        }
        Dim passat As New Model() With {
             .Content = "Passat",
             .Position = New Point(240, 460)
        }
        vw.AddItem(polo)
        vw.AddItem(golf)
        vw.AddItem(passat)
        Dim groupToVw As New Link() With {
             .Content = "Owns",
             .Source = vwGroup,
             .Target = vw
        }

        Dim audi As New Brand() With {
             .Content = "Audi",
             .Position = New Point(520, 400)
        }
        Dim r8 As New Model() With {
             .Content = "R8",
             .Position = New Point(520, 400)
        }
        Dim a4 As New Model() With {
             .Content = "A4",
             .Position = New Point(640, 400)
        }
        Dim a6 As New Model() With {
             .Content = "A6",
             .Position = New Point(540, 460)
        }
        audi.AddItem(r8)
        audi.AddItem(a4)
        audi.AddItem(a6)
        Dim groupToAudi As New Link() With {
             .Content = "Owns",
             .Source = vwGroup,
             .Target = audi
        }

        Me.AddNode(vw)
        Me.AddNode(audi)
        Me.AddNode(vwGroup)

        Me.AddLink(groupToVw)
        Me.AddLink(groupToAudi)
    End Sub
End Class
'#endregion
'#region raddiagram-howto-mvvm-3
Public Sub New()
    InitializeComponent()

    Me.diagram.GraphSource = New CarsGraphSource()
End Sub
'#endregion