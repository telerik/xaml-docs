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

#region consuming-data-linq-to-sql-classes_0
NortwindDataContext dbContext = new NortwindDataContext();
var query = from p in dbContext.Products
               where p.Category.CategoryName == "Seafood"
               select p;
IEnumerable<Product> products = query.ToList();
#endregion

#region consuming-data-linq-to-sql-classes_2
NortwindDataContext dbContext = new NortwindDataContext();
Product product = dbContext.Products.Single( p => p.ProductName == "Aniseed Syrup" );
product.UnitPrice = 1000;
dbContext.SubmitChanges();
#endregion

#region consuming-data-linq-to-sql-classes_4
NortwindDataContext dbContext = new NortwindDataContext();
Category category = new Category();
category.CategoryName = "Test Category";
Product firstProduct = new Product();
firstProduct.ProductName = "Test Product 1";
Product secondProduct = new Product();
secondProduct.ProductName = "Test Product 2";
category.Products.Add( firstProduct );
category.Products.Add( secondProduct );
dbContext.Categories.InsertOnSubmit( category );
dbContext.SubmitChanges();
#endregion

#region consuming-data-linq-to-sql-classes_6
NortwindDataContext dbContext = new NortwindDataContext();
var query = from p in dbContext.Products
            where p.ProductName.Contains( "Test" )
            select p;
dbContext.Products.DeleteAllOnSubmit( query );
dbContext.SubmitChanges();
#endregion

#region consuming-data-linq-to-sql-classes_8
NortwindDataContext dbContext = new NortwindDataContext();
var query = ( from p in dbContext.Products
              where p.Category.CategoryName == "Aniseed Syrup"
              select p ).Skip( 300 ).Take( 15 );
IEnumerable<Product> products = query.ToList();
#endregion
}
