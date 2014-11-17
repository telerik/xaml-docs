using System;
using System.Collections.Generic;
using System.Windows;
using Telerik.Pivot.Core;

namespace RadPivotGrid_GettingStarted
{
#region radpivotgrid-getting-started_1
public class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public DateTime Date { get; set; }
}
#endregion

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
#region radpivotgrid-getting-started_3
InitializeComponent();
(this.Resources["LocalDataProvider"] as LocalDataSourceProvider).ItemsSource = GeneratePivotData();
#endregion
        }

#region radpivotgrid-getting-started_2
private static IList<Product> GeneratePivotData()
{
    IList<Product> PivotData = new List<Product>()
    {
        new Product() { Name = "Pen", Date = new DateTime(2012,1,1,0,0,0), Price = 10.40, Quantity = 148 },
        new Product() { Name = "Pen", Date = new DateTime(2012,2,1,0,0,0), Price = 10.99, Quantity = 122 },
        new Product() { Name = "Pen", Date = new DateTime(2012,3,1,0,0,0), Price = 11.24, Quantity = 80 },
        new Product() { Name = "Pen", Date = new DateTime(2012,4,1,0,0,0), Price = 11.24, Quantity = 90 },
        new Product() { Name = "Pen", Date = new DateTime(2012,5,1,0,0,0), Price = 11.14, Quantity = 140 },
        new Product() { Name = "Pen", Date = new DateTime(2012,6,1,0,0,0), Price = 10.89, Quantity = 162 },
        new Product() { Name = "Pen", Date = new DateTime(2012,7,1,0,0,0), Price = 10.89, Quantity = 181 },
        new Product() { Name = "Pen", Date = new DateTime(2012,8,1,0,0,0), Price = 10.88, Quantity = 180 },
        new Product() { Name = "Pen", Date = new DateTime(2012,9,1,0,0,0), Price = 11.00, Quantity = 116 },
        new Product() { Name = "Pen", Date = new DateTime(2012,10,1,0,0,0), Price = 10.99, Quantity = 128 },
        new Product() { Name = "Pen", Date = new DateTime(2012,11,1,0,0,0), Price = 10.95, Quantity = 145 },
        new Product() { Name = "Pen", Date = new DateTime(2012,12,1,0,0,0), Price = 10.45, Quantity = 189 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,1,1,0,0,0), Price = 5.22, Quantity = 100 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,2,1,0,0,0), Price = 5.99, Quantity = 85 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,3,1,0,0,0), Price = 6.04, Quantity = 80 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,4,1,0,0,0), Price = 6.28, Quantity = 72 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,5,1,0,0,0), Price = 6.12, Quantity = 99 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,6,1,0,0,0), Price = 6.59, Quantity = 40 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,7,1,0,0,0), Price = 6.29, Quantity = 68 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,8,1,0,0,0), Price = 5.99, Quantity = 95 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,9,1,0,0,0), Price = 5.89, Quantity = 120 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,10,1,0,0,0), Price = 5.99, Quantity = 105 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,11,1,0,0,0), Price = 5.96, Quantity = 111 },
        new Product() { Name = "Pencil", Date = new DateTime(2012,12,1,0,0,0), Price = 5.99, Quantity = 108 },
        new Product() { Name = "Notebook", Date = new DateTime(2012,1,1,0,0,0), Price = 22.86, Quantity = 88 },
        new Product() { Name = "Notebook", Date = new DateTime(2012,2,1,0,0,0), Price = 23.02, Quantity = 95},
        new Product() { Name = "Notebook", Date = new DateTime(2012,3,1,0,0,0), Price = 23.22, Quantity = 102 },
        new Product() { Name = "Notebook", Date = new DateTime(2012,4,1,0,0,0), Price = 21.99, Quantity = 95},
        new Product() { Name = "Notebook", Date = new DateTime(2012,5,1,0,0,0), Price = 22.45, Quantity = 84},
        new Product() { Name = "Notebook", Date = new DateTime(2012,6,1,0,0,0), Price = 22.56, Quantity = 96 },
        new Product() { Name = "Notebook", Date = new DateTime(2012,7,1,0,0,0), Price = 22.88, Quantity = 88},
        new Product() { Name = "Notebook", Date = new DateTime(2012,8,1,0,0,0), Price = 22.42, Quantity = 99},
        new Product() { Name = "Notebook", Date = new DateTime(2012,9,1,0,0,0), Price = 22.56, Quantity = 111},
        new Product() { Name = "Notebook", Date = new DateTime(2012,10,1,0,0,0), Price = 22.18, Quantity = 102 },
        new Product() { Name = "Notebook", Date = new DateTime(2012,11,1,0,0,0), Price = 22.93, Quantity = 105 },
        new Product() { Name = "Notebook", Date = new DateTime(2012,12,1,0,0,0), Price = 22.89, Quantity = 122 },
    };

    return PivotData;
}
#endregion
    }
}

#region radpivotgrid-getting-started_4
using System;
using System.Collections.Generic;
using System.Windows;
using Telerik.Pivot.Core;

namespace RadPivotGrid_GettingStarted
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            (this.Resources["LocalDataProvider"] as LocalDataSourceProvider).ItemsSource = GeneratePivotData();
        }

        private static IList<Product> GeneratePivotData()
        {
            IList<Product> PivotData = new List<Product>()
            {
                new Product() { Name = "Pen", Date = new DateTime(2012,1,1,0,0,0), Price = 10.40, Quantity = 148 },
                new Product() { Name = "Pen", Date = new DateTime(2012,2,1,0,0,0), Price = 10.99, Quantity = 122 },
                new Product() { Name = "Pen", Date = new DateTime(2012,3,1,0,0,0), Price = 11.24, Quantity = 80 },
                new Product() { Name = "Pen", Date = new DateTime(2012,4,1,0,0,0), Price = 11.24, Quantity = 90 },
                new Product() { Name = "Pen", Date = new DateTime(2012,5,1,0,0,0), Price = 11.14, Quantity = 140 },
                new Product() { Name = "Pen", Date = new DateTime(2012,6,1,0,0,0), Price = 10.89, Quantity = 162 },
                new Product() { Name = "Pen", Date = new DateTime(2012,7,1,0,0,0), Price = 10.89, Quantity = 181 },
                new Product() { Name = "Pen", Date = new DateTime(2012,8,1,0,0,0), Price = 10.88, Quantity = 180 },
                new Product() { Name = "Pen", Date = new DateTime(2012,9,1,0,0,0), Price = 11.00, Quantity = 116 },
                new Product() { Name = "Pen", Date = new DateTime(2012,10,1,0,0,0), Price = 10.99, Quantity = 128 },
                new Product() { Name = "Pen", Date = new DateTime(2012,11,1,0,0,0), Price = 10.95, Quantity = 145 },
                new Product() { Name = "Pen", Date = new DateTime(2012,12,1,0,0,0), Price = 10.45, Quantity = 189 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,1,1,0,0,0), Price = 5.22, Quantity = 100 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,2,1,0,0,0), Price = 5.99, Quantity = 85 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,3,1,0,0,0), Price = 6.04, Quantity = 80 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,4,1,0,0,0), Price = 6.28, Quantity = 72 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,5,1,0,0,0), Price = 6.12, Quantity = 99 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,6,1,0,0,0), Price = 6.59, Quantity = 40 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,7,1,0,0,0), Price = 6.29, Quantity = 68 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,8,1,0,0,0), Price = 5.99, Quantity = 95 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,9,1,0,0,0), Price = 5.89, Quantity = 120 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,10,1,0,0,0), Price = 5.99, Quantity = 105 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,11,1,0,0,0), Price = 5.96, Quantity = 111 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,12,1,0,0,0), Price = 5.99, Quantity = 108 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,1,1,0,0,0), Price = 22.86, Quantity = 88 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,2,1,0,0,0), Price = 23.02, Quantity = 95},
                new Product() { Name = "Notebook", Date = new DateTime(2012,3,1,0,0,0), Price = 23.22, Quantity = 102 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,4,1,0,0,0), Price = 21.99, Quantity = 95},
                new Product() { Name = "Notebook", Date = new DateTime(2012,5,1,0,0,0), Price = 22.45, Quantity = 84},
                new Product() { Name = "Notebook", Date = new DateTime(2012,6,1,0,0,0), Price = 22.56, Quantity = 96 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,7,1,0,0,0), Price = 22.88, Quantity = 88},
                new Product() { Name = "Notebook", Date = new DateTime(2012,8,1,0,0,0), Price = 22.42, Quantity = 99},
                new Product() { Name = "Notebook", Date = new DateTime(2012,9,1,0,0,0), Price = 22.56, Quantity = 111},
                new Product() { Name = "Notebook", Date = new DateTime(2012,10,1,0,0,0), Price = 22.18, Quantity = 102 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,11,1,0,0,0), Price = 22.93, Quantity = 105 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,12,1,0,0,0), Price = 22.89, Quantity = 122 },
            };

            return PivotData;
        }
    }
}
#endregion

#region radpivotgrid-getting-started_5
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Telerik.Pivot.Core;

namespace RadPivotGrid_GettingStarted
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }

    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            (this.Resources["LocalDataProvider"] as LocalDataSourceProvider).ItemsSource = GeneratePivotData();
        }

        private static IList<Product> GeneratePivotData()
        {
            IList<Product> PivotData = new List<Product>()
            {
                new Product() { Name = "Pen", Date = new DateTime(2012,1,1,0,0,0), Price = 10.40, Quantity = 148 },
                new Product() { Name = "Pen", Date = new DateTime(2012,2,1,0,0,0), Price = 10.99, Quantity = 122 },
                new Product() { Name = "Pen", Date = new DateTime(2012,3,1,0,0,0), Price = 11.24, Quantity = 80 },
                new Product() { Name = "Pen", Date = new DateTime(2012,4,1,0,0,0), Price = 11.24, Quantity = 90 },
                new Product() { Name = "Pen", Date = new DateTime(2012,5,1,0,0,0), Price = 11.14, Quantity = 140 },
                new Product() { Name = "Pen", Date = new DateTime(2012,6,1,0,0,0), Price = 10.89, Quantity = 162 },
                new Product() { Name = "Pen", Date = new DateTime(2012,7,1,0,0,0), Price = 10.89, Quantity = 181 },
                new Product() { Name = "Pen", Date = new DateTime(2012,8,1,0,0,0), Price = 10.88, Quantity = 180 },
                new Product() { Name = "Pen", Date = new DateTime(2012,9,1,0,0,0), Price = 11.00, Quantity = 116 },
                new Product() { Name = "Pen", Date = new DateTime(2012,10,1,0,0,0), Price = 10.99, Quantity = 128 },
                new Product() { Name = "Pen", Date = new DateTime(2012,11,1,0,0,0), Price = 10.95, Quantity = 145 },
                new Product() { Name = "Pen", Date = new DateTime(2012,12,1,0,0,0), Price = 10.45, Quantity = 189 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,1,1,0,0,0), Price = 5.22, Quantity = 100 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,2,1,0,0,0), Price = 5.99, Quantity = 85 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,3,1,0,0,0), Price = 6.04, Quantity = 80 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,4,1,0,0,0), Price = 6.28, Quantity = 72 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,5,1,0,0,0), Price = 6.12, Quantity = 99 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,6,1,0,0,0), Price = 6.59, Quantity = 40 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,7,1,0,0,0), Price = 6.29, Quantity = 68 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,8,1,0,0,0), Price = 5.99, Quantity = 95 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,9,1,0,0,0), Price = 5.89, Quantity = 120 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,10,1,0,0,0), Price = 5.99, Quantity = 105 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,11,1,0,0,0), Price = 5.96, Quantity = 111 },
                new Product() { Name = "Pencil", Date = new DateTime(2012,12,1,0,0,0), Price = 5.99, Quantity = 108 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,1,1,0,0,0), Price = 22.86, Quantity = 88 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,2,1,0,0,0), Price = 23.02, Quantity = 95},
                new Product() { Name = "Notebook", Date = new DateTime(2012,3,1,0,0,0), Price = 23.22, Quantity = 102 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,4,1,0,0,0), Price = 21.99, Quantity = 95},
                new Product() { Name = "Notebook", Date = new DateTime(2012,5,1,0,0,0), Price = 22.45, Quantity = 84},
                new Product() { Name = "Notebook", Date = new DateTime(2012,6,1,0,0,0), Price = 22.56, Quantity = 96 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,7,1,0,0,0), Price = 22.88, Quantity = 88},
                new Product() { Name = "Notebook", Date = new DateTime(2012,8,1,0,0,0), Price = 22.42, Quantity = 99},
                new Product() { Name = "Notebook", Date = new DateTime(2012,9,1,0,0,0), Price = 22.56, Quantity = 111},
                new Product() { Name = "Notebook", Date = new DateTime(2012,10,1,0,0,0), Price = 22.18, Quantity = 102 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,11,1,0,0,0), Price = 22.93, Quantity = 105 },
                new Product() { Name = "Notebook", Date = new DateTime(2012,12,1,0,0,0), Price = 22.89, Quantity = 122 },
            };

            return PivotData;
        }
    }
}
#endregion