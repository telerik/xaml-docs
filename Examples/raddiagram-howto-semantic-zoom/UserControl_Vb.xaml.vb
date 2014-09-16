'#region raddiagram-howto-semantic-zoom-0
Public Class CustomNode
	Inherits HierarchicalNodeViewModel
	Private m_currentDisplayMode As ItemDisplayMode
	Public Property CurrentDisplayMode() As ItemDisplayMode
		Get
			Return Me.m_currentDisplayMode
		End Get
		Friend Set(value As ItemDisplayMode)
			If Me.m_currentDisplayMode <> value Then
				Me.m_currentDisplayMode = value
				OnPropertyChanged("CurrentDisplayMode")
			End If
		End Set
	End Property

	Public Property Email() As String
		Get
			Return m_Email
		End Get
		Set(value As String)
			m_Email = Value
		End Set
	End Property
	Private m_Email As String

	Public Property Phone() As String
		Get
			Return m_Phone
		End Get
		Set(value As String)
			m_Phone = Value
		End Set
	End Property
	Private m_Phone As String

	Public Property ImagePath() As String
		Get
			Return m_ImagePath
		End Get
		Set(value As String)
			m_ImagePath = Value
		End Set
	End Property
	Private m_ImagePath As String

	Public Property Address() As String
		Get
			Return m_Address
		End Get
		Set(value As String)
			m_Address = Value
		End Set
	End Property
	Private m_Address As String

	Public Property HeadCount() As Integer
		Get
			Return m_HeadCount
		End Get
		Set(value As Integer)
			m_HeadCount = Value
		End Set
	End Property
	Private m_HeadCount As Integer

	Public Property JobPosition() As String
		Get
			Return m_JobPosition
		End Get
		Set(value As String)
			m_JobPosition = Value
		End Set
	End Property
	Private m_JobPosition As String

	Public Property FirstName() As String
		Get
			Return m_FirstName
		End Get
		Set(value As String)
			m_FirstName = Value
		End Set
	End Property
	Private m_FirstName As String

	Public Property LastName() As String
		Get
			Return m_LastName
		End Get
		Set(value As String)
			m_LastName = Value
		End Set
	End Property
	Private m_LastName As String

	Public Sub New()
		Me.CurrentDisplayMode = ItemDisplayMode.Small
	End Sub
End Class

Public Enum ItemDisplayMode
	Medium
	Large
	Small
End Enum
' #endregion
'#region raddiagram-howto-semantic-zoom-1
Public Class MainViewModel
	Inherits ViewModelBase

	Public Property Employees() As ObservableGraphSourceBase(Of CustomNode, LinkViewModelBase(Of CustomNode))
		Get
			Return m_Employees
		End Get
		Set(value As ObservableGraphSourceBase(Of CustomNode, LinkViewModelBase(Of CustomNode)))
			m_Employees = Value
		End Set
	End Property
	Private m_Employees As ObservableGraphSourceBase(Of CustomNode, LinkViewModelBase(Of CustomNode))

	Public Sub New()
		Me.Employees = New ObservableGraphSourceBase(Of CustomNode, LinkViewModelBase(Of CustomNode))()
		Me.Employees.AddNode(New CustomNode() With {
														.FirstName = "Andrew",
														.LastName = "Fuller",
														.Email = "afuller@contoso.com",
														.Phone = "(205) 555 - 9898",
														.Address = "London, 120 Hanover Sq.",
														.Position = New Point(250, 250),
														.ImagePath = "/Images/AndrewFuller.jpg",
														.JobPosition = "CEO"
													})
	End Sub
End Class
' #endregion
'#region raddiagram-howto-semantic-zoom-2
Public Class MainViewModel
	Inherits ViewModelBase
	Private Shared SmallToNormalTemplateThreshHold As Double = 1.2
	Private Shared NormallToLargeTemplateThreshHold As Double = 2.1

	Public Property Employees() As ObservableGraphSourceBase(Of CustomNode, LinkViewModelBase(Of CustomNode))
		Get
			Return m_Employees
		End Get
		Set(value As ObservableGraphSourceBase(Of CustomNode, LinkViewModelBase(Of CustomNode)))
			m_Employees = Value
		End Set
	End Property
	Private m_Employees As ObservableGraphSourceBase(Of CustomNode, LinkViewModelBase(Of CustomNode))

	Private m_zoomFactor As Double
	''' <summary>
	'''     Gets or sets the zoom factor of the diagram.
	''' </summary>
	Public Property ZoomFactor() As Double
		Get
			Return Me.m_zoomFactor
		End Get
		Friend Set(value As Double)
			If Me.m_zoomFactor <> value Then
				Me.m_zoomFactor = value
				Me.OnZoomChanged()
				OnPropertyChanged("ZoomFactor")
			End If
		End Set
	End Property
	Private m_ItemsCurrentDisplayMode As ItemDisplayMode
	Public Property ItemsCurrentDisplayMode() As ItemDisplayMode
		Get
			Return m_ItemsCurrentDisplayMode
		End Get
		Set(value As ItemDisplayMode)
			m_ItemsCurrentDisplayMode = Value
		End Set
	End Property


	Public Sub New()
		Me.Employees = New ObservableGraphSourceBase(Of CustomNode, LinkViewModelBase(Of CustomNode))()
		Me.Employees.AddNode(New CustomNode() With {
														.FirstName = "Andrew",
														.LastName = "Fuller",
														.Email = "afuller@contoso.com",
														.Phone = "(205) 555 - 9898",
														.Address = "London, 120 Hanover Sq.",
														.Position = New Point(250, 250),
														.ImagePath = "/Images/AndrewFuller.jpg",
														.JobPosition = "CEO"
													})
		Me.ItemsCurrentDisplayMode = ItemDisplayMode.Medium
		Me.ZoomFactor = 1
	End Sub

	Private Sub OnZoomChanged()
		Dim newMode As ItemDisplayMode
		If SmallToNormalTemplateThreshHold < Me.ZoomFactor AndAlso Me.ZoomFactor <= NormallToLargeTemplateThreshHold Then
			newMode = ItemDisplayMode.Medium
		ElseIf Me.ZoomFactor <= SmallToNormalTemplateThreshHold Then
			newMode = ItemDisplayMode.Small
		Else
			newMode = ItemDisplayMode.Large
		End If

		If Me.ItemsCurrentDisplayMode <> newMode Then
			Me.ChangeAllShapesDisplayMode(newMode)
		End If
	End Sub

	Private Sub ChangeAllShapesDisplayMode(newMode As ItemDisplayMode)
		Me.ItemsCurrentDisplayMode = newMode
		For Each node As var In Me.Employees.InternalItems
			node.CurrentDisplayMode = newMode
		Next
	End Sub
End Class
' #endregion