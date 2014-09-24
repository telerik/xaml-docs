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

#region radtreemap-populating-with-data-radtreemap_0
public interface IDiskItem
    {
        string Name { get; }
        long Size { get; }
        IEnumerable<IDiskItem> Children { get; }
    }
#endregion

#region radtreemap-populating-with-data-radtreemap_2
public class Folder : IDiskItem
    {
        private string _name;
        private IEnumerable<IDiskItem> _children;
        public Folder(string name, IEnumerable<IDiskItem> children)
        {
            this._name = name;
            this._children = children;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public long Size
        {
            get
            {
                return this.Children.Sum(child => child.Size);
            }
        }
        public IEnumerable<IDiskItem> Children
        {
            get
            {
                return _children;
            }
        }
    }
    public class File : IDiskItem
    {
        private string _name;
        private long _size;
        public File(string name, long size)
        {
            this._name = name;
            this._size = size;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public long Size
        {
            get
            {
                return _size;
            }
        }
        public IEnumerable<IDiskItem> Children
        {
            get { return null; }
        }
    }
#endregion

#region radtreemap-populating-with-data-radtreemap_6
     public MainPage() // MainWindow in WPF
        {
            InitializeComponent();
            var datasource = new List<IDiskItem>() {
                new Folder("Windows", 
                    new List<IDiskItem>() {
                         new Folder("Fonts", new List<IDiskItem>() { new File("Arial", 256), new File("Tahoma", 246)}),
                         new Folder("Logs", new List<IDiskItem>() { new File("Log1.log", 112), new File("Log2.log", 156)})
                    }),
                    new Folder ("My Documents", new List<IDiskItem>() {
                        new File("Document1.txt", 88), new File("Document2.txt", 55)}),
                    new File("pagefile.sys", 114)};
            treeMap1.ItemsSource = datasource;
        }
#endregion
}
