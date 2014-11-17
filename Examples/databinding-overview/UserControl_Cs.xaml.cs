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

#region databinding-overview_0
TextBox1.DataContext = new CategoryList();
#endregion

#region databinding-overview_3
TextBox1.DataContext = new CategoryList();
ListBox1.DataContext = new CategoryList();
#endregion

#region databinding-overview_4
LayoutRoot.DataContext = currentProduct;
#endregion

#region databinding-overview_7
public class CategoryList : ObservableCollection<Category>
    {
        public CategoryList()
        {
            this.Add(new Category("Category1"));
            this.Add(new Category("Category2"));
            this.Add(new Category("Category3"));
            this.Add(new Category("Category4"));
            this.Add(new Category("Category5"));
            this.Add(new Category("Category6"));
        }
    }
    public class Category : INotifyPropertyChanged
    {
        private string nameValue;
        public Category(string name)
        {
            this.nameValue = name;
        }
        public string Name
        {
            set
            {
                if (this.nameValue != value)
                {
                    this.nameValue = value;
                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            }
            get
            {
                return this.nameValue;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
#endregion
}
