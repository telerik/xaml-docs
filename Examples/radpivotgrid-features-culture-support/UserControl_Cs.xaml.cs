#region radpivotgrid-features-culture-support_1
var dataProvider = new LocalDataSourceProvider { Culture = new CultureInfo("en-US") };
#endregion

#region radpivotgrid-features-culture-support_2
var provider = this.Resources["LocalDataProvider"] as LocalDataSourceProvider;
var itemsSource = provider.ItemsSource;
provider.ItemsSource = null;
provider.Culture = new CultureInfo("fr-FR");
provider.ItemsSource = itemsSource;
#endregion