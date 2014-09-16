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

#region gridview-how-to-use-radcontextmenu-mvvm_4
    [ContentProperty("ContextMenu")]
    public class RadContextMenuXamlHolder : INotifyPropertyChanged
    {
        private RadContextMenu contextMenu;
        public event PropertyChangedEventHandler PropertyChanged;

        public RadContextMenu ContextMenu
        {
            get
            {
                return this.contextMenu;
            }
            set
            {
                if (this.contextMenu != value)
                {
                    this.contextMenu = value;
                    this.RaisePropertyChanged("ContextMenu");
                }
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
#endregion

#region gridview-how-to-use-radcontextmenu-mvvm_5
     public ViewModel()
        {
            this.Items = LoadData();

            this.SortAscendingCommand = new DelegateCommand(OnSortAscending, CanSortAscending);
            this.SortDescendingCommand = new DelegateCommand(OnSortDescending, CanSortDescending);
            this.ClearSortCommand = new DelegateCommand(OnClearSort, CanClearSort);
            this.GroupbyCommand = new DelegateCommand(OnGroupby, CanGroupby);
            this.UngroupCommand = new DelegateCommand(OnUngroup, CanUngroup);
        }

        public DelegateCommand SortAscendingCommand { get; private set; }
        public DelegateCommand SortDescendingCommand { get; private set; }
        public DelegateCommand ClearSortCommand { get; private set; }
        public DelegateCommand GroupbyCommand { get; private set; }
        public DelegateCommand UngroupCommand { get; private set; }

        public IEnumerable Items
        {
            get;
            private set;
        }

        private static void Sort(GridViewHeaderCell cell, ListSortDirection sortDirection)
        {
            RadGridView grid = cell.Column.DataControl as RadGridView;
            ColumnSortDescriptor sd = (from d in grid.SortDescriptors.OfType<ColumnSortDescriptor>()
                                       where object.Equals(d.Column, cell.Column)
                                       select d).FirstOrDefault();

            if (sd != null)
            {
                grid.SortDescriptors.Remove(sd);
            }

            ColumnSortDescriptor newDescriptor = new ColumnSortDescriptor();
            newDescriptor.Column = cell.Column;
            newDescriptor.SortDirection = sortDirection;

            grid.SortDescriptors.Add(newDescriptor);
        }

        private void OnSortAscending(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.DataControl != null && cell.Column.SortingState != SortingState.Ascending)
            {
                Sort(cell, ListSortDirection.Ascending);
            }
        }

        private bool CanSortAscending(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.CanSort() && cell.Column.DataControl != null && cell.Column.SortingState != SortingState.Ascending)
            {
                return true;
            }

            return false;
        }

        private void OnSortDescending(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.CanSort() && cell.Column.DataControl != null && cell.Column.SortingState != SortingState.Descending)
            {
                Sort(cell, ListSortDirection.Descending);
            }
        }

        private bool CanSortDescending(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.CanSort() && cell.Column.DataControl != null && cell.Column.SortingState != SortingState.Descending)
            {
                return true;
            }

            return false;
        }

        private void OnClearSort(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.CanSort() && cell.Column.DataControl != null && cell.Column.SortingState != SortingState.None)
            {
                RadGridView grid = cell.Column.DataControl as RadGridView;
                ColumnSortDescriptor sd = (from d in grid.SortDescriptors.OfType<ColumnSortDescriptor>()
                                           where object.Equals(d.Column, cell.Column)
                                           select d).FirstOrDefault();

                if (sd != null)
                {
                    grid.SortDescriptors.Remove(sd);
                }
            }
        }

        private bool CanClearSort(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.CanSort() && cell.Column.DataControl != null && cell.Column.SortingState != SortingState.None)
            {
                return true;
            }

            return false;
        }

        private void OnGroupby(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.DataControl != null && cell.Column.CanGroup())
            {
                RadGridView grid = cell.Column.DataControl as RadGridView;

                ColumnGroupDescriptor gd = (from d in grid.GroupDescriptors.OfType<ColumnGroupDescriptor>()
                                            where object.Equals(d.Column, cell.Column)
                                            select d).FirstOrDefault();

                if (gd == null)
                {
                    ColumnGroupDescriptor newDescriptor = new ColumnGroupDescriptor();
                    newDescriptor.Column = cell.Column;
                    newDescriptor.SortDirection = ListSortDirection.Ascending;
                    grid.GroupDescriptors.Add(newDescriptor);
                }
            }
        }

        private bool CanGroupby(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.DataControl != null && cell.Column.CanGroup())
            {
                RadGridView grid = cell.Column.DataControl as RadGridView;

                ColumnGroupDescriptor gd = (from d in grid.GroupDescriptors.OfType<ColumnGroupDescriptor>()
                                            where object.Equals(d.Column, cell.Column)
                                            select d).FirstOrDefault();

                if (gd == null)
                {
                    return true;
                }
            }

            return false;
        }

        private void OnUngroup(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.DataControl != null && cell.Column.CanGroup())
            {
                RadGridView grid = cell.Column.DataControl as RadGridView;

                ColumnGroupDescriptor gd = (from d in grid.GroupDescriptors.OfType<ColumnGroupDescriptor>()
                                            where object.Equals(d.Column, cell.Column)
                                            select d).FirstOrDefault();

                if (gd != null)
                {
                    grid.GroupDescriptors.Remove(gd);
                }
            }
        }

        private bool CanUngroup(object parameter)
        {
            GridViewHeaderCell cell = parameter as GridViewHeaderCell;
            if (cell != null && cell.Column != null && cell.Column.DataControl != null && cell.Column.CanGroup())
            {
                RadGridView grid = cell.Column.DataControl as RadGridView;

                ColumnGroupDescriptor gd = (from d in grid.GroupDescriptors.OfType<ColumnGroupDescriptor>()
                                            where object.Equals(d.Column, cell.Column)
                                            select d).FirstOrDefault();

                if (gd != null)
                {
                    return true;
                }
            }

            return false;
        }

        private static List<Order> LoadData()
        {
            // return data
        }
}
#endregion

#region gridview-how-to-use-radcontextmenu-mvvm_6
 public class ObjectToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return string.Format(System.Convert.ToString(parameter), value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
#endregion

}
