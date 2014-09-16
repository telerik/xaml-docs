Public Class Default_Vb

#Region "radtoolbartray-overview_1"
	Imports Telerik.Windows.Controls

	Dim toolBarTray As New RadToolBarTray()
	Dim toolBar1 As New RadToolBar()
	Dim toolBar2 As New RadToolBar()
	Dim toolBar3 As New RadToolBar()
	toolBar1.Band = 0
	toolBar1.BandIndex = 0
	toolBar2.Band = 0
	toolBar2.BandIndex = 1
	toolBar3.Band = 1
	toolBar3.BandIndex = 0
	Me.LayoutRoot.Children.Add(toolBarTray)
	toolBarTray.Items.Add(toolBar1)
	toolBarTray.Items.Add(toolBar2)
	toolBarTray.Items.Add(toolBar3)
#End Region

End Class
