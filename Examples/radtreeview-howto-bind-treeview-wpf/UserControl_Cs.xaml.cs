using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

	#region radtreeview-howto-bind-treeview-wpf_4
	public class Animal
	{
		public Animal(string name, Category category)
		{
			this.Name = name;
			this.Category = category;
		}
		public string Name
		{
			get;
			set;
		}
		public Category Category
		{
			get;
			set;
		}
	}
	#endregion

	#region radtreeview-howto-bind-treeview-wpf_6
	public enum Category
	{
		Amphibians,
		Bears,
		Canines,
		Spiders,
		Primates,
		BigCats
	}
	#endregion

	#region radtreeview-howto-bind-treeview-wpf_8
	public class Animal
	{
		public Animal(string name, Category category)
		{
			this.Name = name;
			this.Category = category;
		}
		public string Name
		{
			get;
			set;
		}
		public Category Category
		{
			get;
			set;
		}
		public IEnumerable<Animal> AnimalList
		{
			get
			{
				List<Animal> animalList = new List<Animal>();
				animalList.Add(new Animal("California Newt", Category.Amphibians));
				animalList.Add(new Animal("Giant Panda", Category.Bears));
				animalList.Add(new Animal("Coyote", Category.Canines));
				animalList.Add(new Animal("Golden Silk Spader", Category.Spiders));
				animalList.Add(new Animal("Mandrill", Category.Primates));
				animalList.Add(new Animal("Black Bear", Category.Bears));
				animalList.Add(new Animal("Jaguar", Category.BigCats));
				animalList.Add(new Animal("Bornean Gibbon", Category.Primates));
				animalList.Add(new Animal("African Wildcat", Category.BigCats));
				animalList.Add(new Animal("Artic Fox", Category.Canines));
				animalList.Add(new Animal("Tomato Frog", Category.Amphibians));
				animalList.Add(new Animal("Grizzly Bear", Category.Bears));
				animalList.Add(new Animal("Dingo", Category.Canines));
				animalList.Add(new Animal("Gorilla", Category.Primates));
				animalList.Add(new Animal("Green Tree Frog", Category.Amphibians));
				animalList.Add(new Animal("Bald Vakari", Category.Primates));
				animalList.Add(new Animal("Polar Bear", Category.Bears));
				animalList.Add(new Animal("Black Widow Spider", Category.Spiders));
				animalList.Add(new Animal("Bat-Eared Fox", Category.Canines));
				animalList.Add(new Animal("Cheetah", Category.BigCats));
				return animalList.AsEnumerable();
			}
		}
	}
	#endregion
}
