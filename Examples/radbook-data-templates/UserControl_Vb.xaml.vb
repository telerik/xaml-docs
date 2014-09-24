Public Class Default_Vb
#Region "radbook-data-templates_0"
Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			' create the collection of photos
			Dim myPhotos As New ObservableCollection(Of PhotoItem)()
			myPhotos.Add(New PhotoItem() With {.Title = "Chrysanthemum", .Image = "Chrysanthemum.jpg", .DateTaken = Date.Parse("3/14/2008 1:59 PM"), .Size = "858 KB"})
			myPhotos.Add(New PhotoItem() With {.Title = "Desert", .Image = "Desert.jpg", .DateTaken = Date.Parse("2/12/2008 3:12 PM"), .Size = "458 KB"})
			myPhotos.Add(New PhotoItem() With {.Title = "Hydrangeas", .Image = "Hydrangeas.jpg", .DateTaken = Date.Parse("3/25/2008 2:22 PM"), .Size = "843 KB"})
			myPhotos.Add(New PhotoItem() With {.Title = "Jellyfish", .Image = "Jellyfish.jpg", .DateTaken = Date.Parse("1/14/2008 4:32 PM"), .Size = "456 KB"})
			myPhotos.Add(New PhotoItem() With {.Title = "Koala", .Image = "Koala.jpg", .DateTaken = Date.Parse("6/14/2008 2:46 PM"), .Size = "654 KB"})
			myPhotos.Add(New PhotoItem() With {.Title = "LightHouse", .Image = "LightHouse.jpg", .DateTaken = Date.Parse("8/23/2008 3:59 PM"), .Size = "930 KB"})
			myPhotos.Add(New PhotoItem() With {.Title = "Penguis", .Image = "Penguis.jpg", .DateTaken = Date.Parse("3/14/2008 1:59 PM"), .Size = "623 KB"})
			RadBook1.ItemsSource = myPhotos
		End Sub
	End Class
	' create a class representing a single photo
	Public Class PhotoItem
		Public Property Image() As String
		Public Property Title() As String
		Public Property DateTaken() As Date
		Public Property Size() As String
	End Class
#End Region
End Class
