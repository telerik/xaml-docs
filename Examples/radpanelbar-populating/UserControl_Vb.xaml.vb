Partial Public Class App
	Inherits Application
	Public Sub PopulatePanelBar()

		'#Region "radpanelbar-populating_2"
		Dim myPanelBar As New RadPanelBar()
		Dim item1 As New RadPanelBarItem() With {
		 .Header = "Item 1"
		}
		Dim item2 As New RadPanelBarItem() With {
		 .Header = "Item 2"
		}
		Dim item3 As New RadPanelBarItem() With {
		 .Header = "Item 3"
		}
		myPanelBar.Items.Add(item1)
		myPanelBar.Items.Add(item2)
		myPanelBar.Items.Add(item3)
		'#End Region

		'#Region "radpanelbar-populating_3"
		Dim myListDataSource As New List(Of String)()
		myListDataSource.Add("Item 1")
		myListDataSource.Add("Item 2")
		myListDataSource.Add("Item 3")
		Dim myPanel As New RadPanelBar()
		myPanel.ItemsSource = myListDataSource
		'#End Region
	End Sub
End Class

