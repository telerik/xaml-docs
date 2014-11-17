Public Class Default_Vb


	' #region radtreeview-howto-bind-treeview-wpf_5
	Public Class Animal
		Public Sub New(ByVal name As String, ByVal category As Category)
			Me.Name = name
			Me.Category = category
		End Sub

		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property

		Private _Category As Category
		Public Property Category() As Category
			Get
				Return _Category
			End Get
			Set(ByVal value As Category)
				_Category = value
			End Set
		End Property
	End Class
	' #endregion

	' #region radtreeview-howto-bind-treeview-wpf_7
	Public Enum Category
		Amphibians
		Bears
		Canines
		Spiders
		Primates
		BigCats
	End Enum
	' #endregion

	' #region radtreeview-howto-bind-treeview-wpf_9
	Public Class Animal
		Public Sub New(ByVal name As String, ByVal category As Category)
			Me.Name = name
			Me.Category = category
		End Sub

		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property

		Private _Category As Category
		Public Property Category() As Category
			Get
				Return _Category
			End Get
			Set(ByVal value As Category)
				_Category = value
			End Set
		End Property

		Public ReadOnly Property AnimalList() As IEnumerable(Of Animal)
			Get
				Dim animalLst As New List(Of Animal)()
				animalLst.Add(New Animal("California Newt", Category.Amphibians))
				animalLst.Add(New Animal("Giant Panda", Category.Bears))
				animalLst.Add(New Animal("Coyote", Category.Canines))
				animalLst.Add(New Animal("Golden Silk Spader", Category.Spiders))
				animalLst.Add(New Animal("Mandrill", Category.Primates))
				animalLst.Add(New Animal("Black Bear", Category.Bears))
				animalLst.Add(New Animal("Jaguar", Category.BigCats))
				animalLst.Add(New Animal("Bornean Gibbon", Category.Primates))
				animalLst.Add(New Animal("African Wildcat", Category.BigCats))
				animalLst.Add(New Animal("Artic Fox", Category.Canines))
				animalLst.Add(New Animal("Tomato Frog", Category.Amphibians))
				animalLst.Add(New Animal("Grizzly Bear", Category.Bears))
				animalLst.Add(New Animal("Dingo", Category.Canines))
				animalLst.Add(New Animal("Gorilla", Category.Primates))
				animalLst.Add(New Animal("Green Tree Frog", Category.Amphibians))
				animalLst.Add(New Animal("Bald Vakari", Category.Primates))
				animalLst.Add(New Animal("Polar Bear", Category.Bears))
				animalLst.Add(New Animal("Black Widow Spider", Category.Spiders))
				animalLst.Add(New Animal("Bat-Eared Fox", Category.Canines))
				animalLst.Add(New Animal("Cheetah", Category.BigCats))

				Return animalList.AsEnumerable()
			End Get
		End Property
	End Class
	' #endregion
End Class
