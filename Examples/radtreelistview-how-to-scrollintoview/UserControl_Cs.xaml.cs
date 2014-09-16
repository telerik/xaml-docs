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

#region radtreelistview-how-to-scrollintoview-0
public class DataItem : ViewModelBase
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        private ObservableCollection<DataItem> children;
        public ObservableCollection<DataItem> Children
        {
            get
            {
                if (children == null)
                {
                    children = new ObservableCollection<DataItem>();
                    for (int i = 0; i < 100; i++)
                    {
                        DataItem item = new DataItem() { Name = this.Name + "." + i};
                        children.Add(item);
                    }
                }
                return children;
            }
        }

        public bool IsExpandable
        {
            get
            {
                return true;
            }
        }
    }
#endregion

#region radtreelistview-how-to-scrollintoview-1
public partial class Example : UserControl
{
	DateTime listBringStart;
	private ObservableCollection<DataItem> list;

	public Example()
	{
		InitializeComponent();
		this.LoadData();
	}

	private void LoadData()
	{
		list = new ObservableCollection<DataItem>();
		for (int i = 0; i < 100; i++)
		{
			DataItem root = new DataItem() { Name = "Item " + i };
			list.Add(root);
		}
		this.treeList.ItemsSource = list;
	}
}
#endregion
#region radtreelistview-how-to-scrollintoview-2
private void RadButton_Click_1(object sender, RoutedEventArgs e)
{
	this.listBringStart = DateTime.Now;
	this.ScrollIntoViewRecursive(0, list[85]);
}

private void ScrollIntoViewRecursive(int level, DataItem item)
{
	if (level >= 20)
	{
		MessageBox.Show(DateTime.Now.Subtract(this.listBringStart).TotalSeconds.ToString() + " sec.");
		return;
	}
	var newItem = item.Children[85];
	this.treeList.ScrollIntoViewAsync(item, (f) => { ScrollIntoViewRecursive(++level, newItem); }, true);
}
#endregion
#region radtreelistview-how-to-scrollintoview-3
private void RadButton_Click_2(object sender, RoutedEventArgs e)
{
	DateTime startTime = DateTime.Now;

	DataItem start = this.list[85];
	for (int i = 0; i < 20; i++)
	{
		this.treeList.ExpandHierarchyItem(start);
		start = start.Children[85];
	}
	this.treeList.ScrollIntoView(start, false);
	this.treeList.SelectedItems.Add(start);
	DateTime end = DateTime.Now;
	MessageBox.Show(end.Subtract(startTime).TotalSeconds.ToString() + " sec.");
}
#endregion


}
