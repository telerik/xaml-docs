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

#region consuming-data-linq-to-ado-net-entity-data-model_0
NorthwindEntities dbContext = new NorthwindEntities();
var query = from p in dbContext.ProductSet
            where p.Categories.CategoryName == "Seafood"
            select p;
IEnumerable<Product> products = query.ToList();
#endregion

#region consuming-data-linq-to-ado-net-entity-data-model_2
NorthwindEntities dbContext = new NorthwindEntities();
Product product = dbContext.ProductSet.Single( p => p.ProductName == "Aniseed Syrup" );
product.UnitPrice = 1000;
dbContext.SaveChanges();
#endregion

#region consuming-data-linq-to-ado-net-entity-data-model_4
NorthwindEntities dbContext = new NorthwindEntities();
Category category = new Category();
category.CategoryName = "Test Category";
Product firstProduct = new Product();
firstProduct.ProductName = "Test Product 1";
Product secondProduct = new Product();
secondProduct.ProductName = "Test Product 2";
category.Products.Add( firstProduct );
category.Products.Add( secondProduct );
dbContext.AddToCategorySet( category );
dbContext.SaveChanges();
#endregion

#region consuming-data-linq-to-ado-net-entity-data-model_6
NorthwindEntities dbContext = new NorthwindEntities();
var query = from p in dbContext.ProductSet
            where p.ProductName.Contains( "Test" )
            select p;
foreach ( Product p in query )
    dbContext.DeleteObject( p );
dbContext.SaveChanges();
#endregion

#region consuming-data-linq-to-ado-net-entity-data-model_8
NorthwindEntities dbContext = new NorthwindEntities();
var query = ( from p in dbContext.ProductSet
              where p.Categories.CategoryName == "Aniseed Syrup"
              select p ).Skip( 300 ).Take( 15 );
IEnumerable<Product> products = query.ToList();
#endregion
}
