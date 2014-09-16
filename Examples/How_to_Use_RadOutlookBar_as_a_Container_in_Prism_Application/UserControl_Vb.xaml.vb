#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_1"
Public Class Bootstrapper
	Inherits UnityBootstrapper
	Protected Overrides Function CreateShell() As DependencyObject
		' Use the container to create an instance of the shell.
		Dim shellView As Shell.Views.ShellView = Container.Resolve(Of Shell.Views.ShellView)()
		' Display the Shell as the root visual for the  application.
		Application.Current.RootVisual = shellView
		Return shellView
	End Function
End Class
#End Region

#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_2"
Private Sub Application_Startup(ByVal sender As Object, ByVal e As StartupEventArgs)
	Dim bootstrapper As New Bootstrapper()
	bootstrapper.Run()
End Sub
#End Region

#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_3"
Public Class ModuleA
	Implements IModule
	Private container As IUnityContainer
	Private regionManager As IRegionManager

	Public Sub New(ByVal regionManager As IRegionManager, ByVal container As IUnityContainer)
		Me.regionManager = regionManager
		Me.container = container
	End Sub

	Public Sub Initialize()
		' Register views here.
	End Sub
End Class
#End Region

#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_5"
Public Sub Initialize()
	' Register views here.
	Me.regionManager.RegisterViewWithRegion("OutlookBarRegion", Function()
																	Return New ModuleAView()
																End Function)
End Sub
#End Region

#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_6"
Protected Overrides Function GetModuleCatalog() As IModuleCatalog
	Dim catalog As New ModuleCatalog()
	catalog.AddModule(GetType(ModuleA.ModuleA))
	Return catalog
End Function
#End Region

#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_7"
Partial Public Class ModuleAView
	Inherits UserControl
	Public Sub New()
		InitializeComponent()
		Me.ItemHeader = "ModuleA"
	End Sub

	Public Property ItemHeader() As String
		Get
			Return m_ItemHeader
		End Get
		Set(ByVal value As String)
			m_ItemHeader = Value
		End Set
	End Property
	Private m_ItemHeader As String
End Class
#End Region

#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_9"
Public Sub New()
	InitializeComponent()
	Me.ItemHeader = "ModuleA"
	Telerik.Windows.Controls.TextSearch.SetText(Me, "ModuleA")
End Sub
#End Region

#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_12"
Partial Public Class ModuleAView
	Inherits UserControl
	Public Sub New()
		InitializeComponent()
	End Sub
	Public ReadOnly Property OutlookBarItem() As RadOutlookBarItem
		Get
			Return Me.outlookBarItem1
		End Get
	End Property
End Class
#End Region

#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_13"
Public Sub Initialize()
	' Register views here.
	Me.regionManager.RegisterViewWithRegion("OutlookBarRegion", Function()
																	Return New ModuleAView().OutlookBarItem
																End Function)
End Sub
#End Region

#Region "How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_14"
Partial Public Class ModuleAView
	Inherits UserControl
	Public Sub New()
		InitializeComponent()
		Me.LayoutRoot.Children.Clear()
	End Sub

	Public ReadOnly Property OutlookBarItem() As RadOutlookBarItem
		Get
			Return Me.outlookBarItem1
		End Get
	End Property
End Class
#End Region

