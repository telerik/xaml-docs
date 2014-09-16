Public Class Default_Vb


	' #region radtreeview-howto-bind-treeview_5
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

	' #region radtreeview-howto-bind-treeview_7
	Public Enum Category
		Amphibians
		Bears
		Canines
		Spiders
		Primates
		BigCats
	End Enum
	' #endregion

	' #region radtreeview-howto-bind-treeview_9
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
				Dim animalList As New List(Of Animal)()
				animalList.Add(New Animal("California Newt", Category.Amphibians))
				animalList.Add(New Animal("Giant Panda", Category.Bears))
				animalList.Add(New Animal("Coyote", Category.Canines))
				animalList.Add(New Animal("Golden Silk Spader", Category.Spiders))
				animalList.Add(New Animal("Mandrill", Category.Primates))
				animalList.Add(New Animal("Black Bear", Category.Bears))
				animalList.Add(New Animal("Jaguar", Category.BigCats))
				animalList.Add(New Animal("Bornean Gibbon", Category.Primates))
				animalList.Add(New Animal("African Wildcat", Category.BigCats))
				animalList.Add(New Animal("Artic Fox", Category.Canines))
				animalList.Add(New Animal("Tomato Frog", Category.Amphibians))
				animalList.Add(New Animal("Grizzly Bear", Category.Bears))
				animalList.Add(New Animal("Dingo", Category.Canines))
				animalList.Add(New Animal("Gorilla", Category.Primates))
				animalList.Add(New Animal("Green Tree Frog", Category.Amphibians))
				animalList.Add(New Animal("Bald Vakari", Category.Primates))
				animalList.Add(New Animal("Polar Bear", Category.Bears))
				animalList.Add(New Animal("Black Widow Spider", Category.Spiders))
				animalList.Add(New Animal("Bat-Eared Fox", Category.Canines))
				animalList.Add(New Animal("Cheetah", Category.BigCats))
				Return animalList.AsEnumerable()
			End Get
		End Property
	End Class
	' #endregion
End Class
