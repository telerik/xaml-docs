Public Class Default_Vb
#Region "radtoolbartray-programming_0"
	Imports Telerik.Windows.Controls

	Dim toolBarTray As New RadToolBarTray()
#End Region

#Region "radtoolbartray-programming_2"
	Imports Telerik.Windows.Controls

	Dim toolBarTray As New RadToolBarTray()
	Dim toolBar As New RadToolBar()
	Me.LayoutRoot.Children.Add(toolBarTray)
	toolBarTray.Items.Add(toolBar)
#End Region

#Region "radtoolbartray-programming_4"
	Imports Telerik.Windows.Controls

	Dim toolBarTray As New RadToolBarTray()
	Dim toolBar1 As New RadToolBar()
	Me.LayoutRoot.Children.Add(toolBarTray)
	toolBarTray.Items.Add(toolBar1)
	toolBarTray.IsLocked = False
	RadToolBarTray.SetIsLocked(toolBarTray, True)
	If RadToolBarTray.GetIsLocked(toolBar1) Then
	End If
#End Region

End Class
