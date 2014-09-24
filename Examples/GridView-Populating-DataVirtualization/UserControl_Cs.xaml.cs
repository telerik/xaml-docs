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

#region GridView-Populating-DataVirtualization_0
public MainWindow()
        {
            InitializeComponent();
            var context = new NorthwindEntities();
            var query = context.Order_Details.OrderBy(o => o.OrderID);
            var view = new VirtualQueryableCollectionView(query) { LoadSize = 10 };
            DataContext = view;
        }
#endregion

#region GridView-Populating-DataVirtualization_3
public MainPage()
        {
            InitializeComponent();
            var context = new NorthwindDomainContext();
            var query = context.GetOrder_DetailsQuery().OrderBy(o => o.OrderID);
            query.IncludeTotalCount = true;
            var view = new VirtualQueryableCollectionView() { LoadSize = 10, VirtualItemCount = 100 };
            view.ItemsLoading += (s, e) =>
            {
                context.Load<Order_Detail>(query.Skip(e.StartIndex).Take(e.ItemCount)).Completed += (sender, args) =>
               {
                   var lo = (LoadOperation)sender;
                   if (lo.TotalEntityCount != -1 && lo.TotalEntityCount != view.VirtualItemCount)
                   {
                       view.VirtualItemCount = lo.TotalEntityCount;
                   }
                   view.Load(e.StartIndex, lo.Entities);
               };
            };
            DataContext = view;
        }
#endregion
}
