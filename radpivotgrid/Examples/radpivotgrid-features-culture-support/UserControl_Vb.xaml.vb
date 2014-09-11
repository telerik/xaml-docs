'#region radpivotgrid-features-culture-support_1
Dim dataProvider = New LocalDataSourceProvider With {.Culture = New CultureInfo("en-US")}
'#endregion

'#region radpivotgrid-features-culture-support_2
Dim provider = TryCast(Me.Resources("LocalDataProvider"), LocalDataSourceProvider)
Dim itemsSource = provider.ItemsSource
provider.ItemsSource = Nothing
provider.Culture = New CultureInfo("fr-FR")
provider.ItemsSource = itemsSource
'#endregion