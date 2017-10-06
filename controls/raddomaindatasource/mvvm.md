---
title: MVVM approach to Telerik Domain Services
page_title: MVVM approach to Telerik Domain Services
description: MVVM approach to Telerik Domain Services
slug: domaindatasource-mvvm
tags: mvvm,approach,to,telerik,domain,services
published: True
position: 5
---

# MVVM approach to Telerik Domain Services



## 

The class that __RadDomainDataSource__ internally uses as its view is public and can be used directly in your view models. You can learn about the relationship between the __RadDomainDataSource__ control and the __QueryableDomainServiceCollectionView__ [here]({%slug domaindatasource-loading-data%}).

The sample in this tutorial contains a main page with several UI controls on it - __RadGridView__, __RadDataPager__ and some other controls. All of these UI elements are bound to a common view model which is the data context of the root element: 

#### __XAML__

{{region domaindatasource-mvvm_0}}

	<UserControl.Resources>
	         <my:CustomersViewModel x:Key="CustomersViewModel"/>
	     </UserControl.Resources>
	     <Grid DataContext="{StaticResource CustomersViewModel}">
	         <Grid.ColumnDefinitions>
	             <ColumnDefinition Width="*"/>
	             <ColumnDefinition Width="250"/>
	         </Grid.ColumnDefinitions>
	         <Grid Name="mainGrid" Grid.Column="0">
	             <Grid.RowDefinitions>
	                 <RowDefinition Height="*" />
	                 <RowDefinition Height="Auto" />
	             </Grid.RowDefinitions>
	             <telerik:RadGridView
	                 x:Name="radGridView"
	                 Grid.Row="0"
	                 ItemsSource="{Binding View}"
	                 IsBusy="{Binding IsBusy}"
	                 ShowGroupPanel="False"
	                 RowIndicatorVisibility="Collapsed"
	                 IsFilteringAllowed="False"
	                 CanUserSortColumns="False"
	                 AutoGenerateColumns="False"
	                 IsReadOnly="True">
	                 <telerik:RadGridView.Columns>
	                     <telerik:GridViewDataColumn DataMemberBinding="{Binding Country}"/>
	                     <telerik:GridViewDataColumn DataMemberBinding="{Binding City}"/>
	                     <telerik:GridViewDataColumn DataMemberBinding="{Binding ContactName}" Header="Contact"/>
	                     <telerik:GridViewDataColumn DataMemberBinding="{Binding ContactTitle}" Header="Title"/>
	                     <telerik:GridViewDataColumn DataMemberBinding="{Binding CompanyName}" Header="Company"/>
	                 </telerik:RadGridView.Columns>
	             </telerik:RadGridView>
	             <telerik:RadDataPager x:Name="radDataPager"
	                                   Grid.Row="1"
	                                   Margin="0, 0, 0, 1"
	                                  Source="{Binding View}"
	                                   DisplayMode="All"
	                                  IsTotalItemCountFixed="True"/>
	         </Grid>
	         <StackPanel Grid.Column="1" Margin="3">
	
	             <Grid>
	                 <Grid.RowDefinitions>
	                     <RowDefinition/>
	                     <RowDefinition/>
	                 </Grid.RowDefinitions>
	                 <Grid.ColumnDefinitions>
	                     <ColumnDefinition/>
	                     <ColumnDefinition/>
	                 </Grid.ColumnDefinitions>
	                 <CheckBox Content="Auto"
	                           Margin="1"
	                          VerticalAlignment="Center"
	                          VerticalContentAlignment="Center"
	                           IsChecked="{Binding AutoLoad, Mode=TwoWay}"/>
	                 <telerik:RadButton Grid.Column="1"
	                                    Content="Refresh"
	                                    Margin="1"
	                                    Padding="10,2"
	                                    Command="{Binding LoadCommand}"/>
	                 <TextBlock Grid.Row="1"
	                            Text="Page Size"
	                            VerticalAlignment="Center"
	                            Margin="1" />
	                 <telerik:RadNumericUpDown Grid.Row="1"
	                                           Grid.Column="1"
	                                           Margin="1"
	                                          Value="{Binding PageSize, Mode=TwoWay}"
	                                          Minimum="0"
	                                           IsInteger="True"/>
	             </Grid>
	
	             <TextBlock Text="Sort by" Margin="0,10,0,0" FontWeight="Bold" />
	             <TextBlock Text="Country" />
	             <RadioButton Content="Ascending"
	                          GroupName="CountrySort"
	                          IsChecked="{Binding IsCountryAscendingChecked, Mode=TwoWay}"/>
	             <RadioButton Content="Descending"
	                          GroupName="CountrySort"
	                          IsChecked="{Binding IsCountryDescendingChecked, Mode=TwoWay}"/>
	             <RadioButton Content="None"
	                          GroupName="CountrySort"
	                          IsChecked="{Binding IsCountryNoneChecked, Mode=TwoWay}"/>
	             <TextBlock Text="Then by" Margin="0,10,0,0" FontWeight="Bold" />
	             <TextBlock Text="City" />
	             <RadioButton Content="Ascending"
	                          GroupName="CitySort"
	                          IsChecked="{Binding IsCityAscendingChecked, Mode=TwoWay}"/>
	             <RadioButton Content="Descending"
	                          GroupName="CitySort"
	                          IsChecked="{Binding IsCityDescendingChecked, Mode=TwoWay}"/>
	             <RadioButton Content="None"
	                          GroupName="CitySort"
	                          IsChecked="{Binding IsCityNoneChecked, Mode=TwoWay}"/>
	
	             <TextBlock Text="Filter by" Margin="0,10,0,0" FontWeight="Bold" />
	             <TextBlock Text="Contact Title" Margin="0,5,0,0" />
	             <telerik:RadComboBox ItemsSource="{Binding ContactTitles}"
	                                  SelectedValue="{Binding SelectedContactTitle, Mode=TwoWay}"/>
	         </StackPanel>
	     </Grid>
{{endregion}}



All of the business logic happens inside this view model. A central part of the view model is an instance of the __QueryableDomainServiceCollectionView__. The view itself and several of its properties are exposed as properties of the view model, so various UI elements can be bound to them:

#### __C#__

{{region domaindatasource-mvvm_1}}

	private readonly QueryableDomainServiceCollectionView<Customer> view;
	
	public CustomersViewModel()
	{
	    NorthwindDomainContext context = new NorthwindDomainContext();
	    EntityQuery<Customer> getCustomersQuery = context.GetCustomersQuery();
	    this.view = new QueryableDomainServiceCollectionView<Customer>(context, getCustomersQuery);
	    //...
	}
{{endregion}}



To illustrate this, let’s take a look at how the page size can be changed by the user. The view contains a [RadNumericUpDown](https://demos.telerik.com/silverlight/#NumericUpDown/FirstLook) bound to the __PageSize__ property of the view model:

#### __XAML__

{{region domaindatasource-mvvm_2}}

	<telerik:RadNumericUpDown Grid.Row="1"
	                          Grid.Column="1"
	                          Value="{Binding PageSize, Mode=TwoWay}"
	                          Minimum="0"
	                          IsInteger="True"/>
{{endregion}}



The view model simply forwards the page changing logic between the view and the model. In this case there is no additional complex logic involved, but your real-life projects may be more complex than this:

#### __C#__

{{region domaindatasource-mvvm_3}}

	public int PageSize
	{
	     get
	     {
	         return this.view.PageSize;
	     }
	     set
	     {
	         if (this.view.PageSize != value)
	         {
	              this.view.PageSize = value;
	              this.OnPropertyChanged("PageSize");
	         }
	     }
	}
{{endregion}}



The view model gives you unlimited opportunities to inject custom logic in both directions. As a matter of fact, __RadDomainDataSource__ is built in a very similar way. It aggregates an instance of the __QueryableDomainServiceCollectionView___ and simply forwards information forth and back. So, for example, when you go and change __RadDomainDataSource.PageSize__ to ___10___, it will simply change the __PageSize__ of its view to ___10___. In fact, you can write these two lines of code and they will do absolutely the same thing:

#### __C#__

{{region domaindatasource-mvvm_4}}

	radDomainDataSource.PageSize = 10;
	radDomainDataSource.DataView.PageSize = 10;
{{endregion}}



You can totally bypass __RadDomainDataSource__ and work directly with the view. That’s the reason why in the [Loading Data article]({%slug domaindatasource-loading-data%}) we have described __RadDomainDataSource__ as just a ___“XAML-friendly thin wrapper over the QDSCV”___. When you are developing your very own view models that will aggregate a __QDSCV__, you are kind of writing your very own personal __RadDomainDataSource__ that does exactly what you need. With the only difference that __RadDomainDataSource__ is a control and your view model is not.

In the sample project that can be downloaded from [here](http://blogs.telerik.com/blogs/posts/10-12-31/an-mvvm-approach-to-telerik-domain-services-for-silverlight.aspx), you will also see how to use buttons with commands, how to listen for changes in the __QDSCV__, and how to retrieve and expose distinct values. 


