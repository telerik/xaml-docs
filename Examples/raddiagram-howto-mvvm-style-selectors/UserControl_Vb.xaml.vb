' #region raddiagram-howto-mvvm-style-selectors-0
Imports Telerik.Windows.Controls.Diagrams.Extensions.ViewModels

Public Class EllipseNode
	Inherits NodeViewModelBase
	Public Property Type() As EllipseNodeType
End Class

Public Enum EllipseNodeType
	Start
	[End]
End Enum

Public Class RectangleNode
	Inherits NodeViewModelBase
	Public Property Description() As String
End Class

Public Class DecisionNode
	Inherits NodeViewModelBase
	Public Overloads Property Content() As String
End Class
' #endregion

' #region raddiagram-howto-mvvm-style-selectors-1
Imports Telerik.Windows.Controls.Diagrams.Extensions.ViewModels

Public Class Link
	Inherits LinkViewModelBase(Of NodeViewModelBase)
	Public Property Type() As LinkType

	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal source As NodeViewModelBase, ByVal target As NodeViewModelBase)
		MyBase.New(source, target)
	End Sub
End Class

Public Enum LinkType
	RightToLeft
	LeftToRight
	Normal
End Enum
' #endregion
' #region raddiagram-howto-mvvm-style-selectors-2
Public Class GraphSource
	Inherits ObservableGraphSourceBase(Of NodeViewModelBase, Link)
	Public Sub PopulateGraphSource()
		'Add Nodes
		Dim processNode1 As New RectangleNode() With {.Position = New Point(160, 280), .Description = "Process 1"}
		Me.AddNode(processNode1)
		Dim processNode2 As New RectangleNode() With {.Position = New Point(644, 280), .Description = "Process 2.1"}
		Me.AddNode(processNode2)
		Dim processNode3 As New RectangleNode() With {.Position = New Point(644, 420), .Description = "Process 2.2"}
		Me.AddNode(processNode3)
		Dim processNode4 As New RectangleNode() With {.Position = New Point(644, 140), .Description = "Process 2.3"}
		Me.AddNode(processNode4)
		Dim processNode5 As New RectangleNode() With {.Position = New Point(880, 280), .Description = "Process 3"}
		Me.AddNode(processNode5)
		Dim processNode6 As New RectangleNode() With {.Position = New Point(420, 420), .Description = "Process A"}
		Me.AddNode(processNode6)
		Dim processNode7 As New RectangleNode() With {.Position = New Point(160, 420), .Description = "Process B"}
		Me.AddNode(processNode7)

		Dim decisionNode_Renamed As New DecisionNode() With {.Position = New Point(420, 280), .Content = "condition"}
		Me.AddNode(decisionNode_Renamed)
		Dim endNode As New EllipseNode() With {.Position = New Point(1100, 300), .Type = EllipseNodeType.End}
		Me.AddNode(endNode)
		Dim startNode As New EllipseNode() With {.Position = New Point(60, 300), .Type = EllipseNodeType.Start, .Content = "Start"}
		Me.AddNode(startNode)

		'Add Links
		Me.AddLink(New Link(startNode, processNode1) With {.Type = LinkType.LeftToRight})
		Me.AddLink(New Link(processNode1, decisionNode_Renamed) With {.Type = LinkType.LeftToRight})
		Me.AddLink(New Link(decisionNode_Renamed, processNode2) With {.Type = LinkType.LeftToRight})
		Me.AddLink(New Link(processNode2, processNode3) With {.Type = LinkType.Normal})
		Me.AddLink(New Link(processNode2, processNode4) With {.Type = LinkType.Normal})
		Me.AddLink(New Link(processNode2, processNode5) With {.Type = LinkType.LeftToRight})
		Me.AddLink(New Link(processNode3, processNode5) With {.Type = LinkType.LeftToRight})
		Me.AddLink(New Link(processNode4, processNode5) With {.Type = LinkType.LeftToRight})
		Me.AddLink(New Link(processNode5, endNode) With {.Type = LinkType.LeftToRight})
		Me.AddLink(New Link(processNode6, decisionNode_Renamed) With {.Type = LinkType.RightToLeft})
		Me.AddLink(New Link(processNode7, processNode6) With {.Type = LinkType.RightToLeft})
		Me.AddLink(New Link(processNode1, processNode7) With {.Type = LinkType.RightToLeft})

	End Sub
End Class
' #endregion
' #region raddiagram-howto-mvvm-style-selectors-3
Partial Public Class MainWindow
	Inherits Window
	Public Sub New()
		InitializeComponent()

		Dim DiagramSource As New GraphSource()
		DiagramSource.PopulateGraphSource()
		Me.xDiagram.GraphSource = DiagramSource
	End Sub
End Class
' #endregion
' #region raddiagram-howto-mvvm-style-selectors-4
Public Class NodeStyleSelector
	Inherits StyleSelector
	Public Property DecisionNodeStyle() As Style
	Public Property StartNodeStyle() As Style
	Public Property EndNodeStyle() As Style
	Public Property RectangleNodeStyle() As Style

	Public Overrides Function SelectStyle(ByVal item As Object, ByVal container As DependencyObject) As Style
		If TypeOf item Is DecisionNode Then
			Return DecisionNodeStyle
		ElseIf TypeOf item Is RectangleNode Then
			Return RectangleNodeStyle
		ElseIf TypeOf item Is EllipseNode Then
			Select Case (CType(item, EllipseNode)).Type
				Case EllipseNodeType.Start
					Return StartNodeStyle
				Case EllipseNodeType.End
					Return EndNodeStyle
				Case Else
					Return MyBase.SelectStyle(item, container)
			End Select
		Else
			Return MyBase.SelectStyle(item, container)
		End If
	End Function
End Class
' #endregion
' #region raddiagram-howto-mvvm-style-selectors-5
Public Class LinkStyleSelector
	Inherits StyleSelector
	Public Property NormalLinkStyle() As Style
	Public Property RightCapLinkStyle() As Style
	Public Property LeftCapLinkStyle() As Style

	Public Overrides Function SelectStyle(ByVal item As Object, ByVal container As DependencyObject) As Style
		Dim link_Renamed As Link = TryCast(item, Link)
		If link_Renamed Is Nothing Then
			Return MyBase.SelectStyle(item, container)
		Else
			Select Case link_Renamed.Type
				Case LinkType.RightToLeft
					Return LeftCapLinkStyle
				Case LinkType.LeftToRight
					Return RightCapLinkStyle
				Case LinkType.Normal
					Return NormalLinkStyle
				Case Else
					Return MyBase.SelectStyle(item, container)
			End Select
		End If
	End Function
End Class
' #endregion