---
title: CRUD
page_title: CRUD
description: This article explains how you can perform CRUD operations in RadDataServiceDataSource.
slug: raddataservicedatasource-crud
tags: crud
published: True
position: 6
---

# {{ site.framework_name }} RadDataServiceDataSource CRUD

You can utilize all CRUD operations by working with the __DataView__ property of the __RadDataServiceDataSource__ control and add, edit or remove entities from the collection which is of type **DataItemCollection**. You can do that either programmatically via the API of the collection or leave the job to __RadGridView__ by binding its __ItemsSource__ to the DataView.

#### __[XAML] Example 1: Bind the DataView collection to RadGridView's ItemsSource__
{{region raddataservicedatasource-crud_1}}
    <Grid>
        <telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Customers" AutoLoad="True">
            <telerik:RadDataServiceDataSource.DataServiceContext>
                <local:MyNorthwindContext/>
            </telerik:RadDataServiceDataSource.DataServiceContext>
        </telerik:RadDataServiceDataSource>
        <telerik:RadGridView ItemsSource="{Binding DataView, ElementName=customersDataSource}" IsBusy="{Binding IsBusy, ElementName=customersDataSource}" />
    </Grid>
{{endregion}}

Once you're ready to submit the changes you can call the __SubmitChanges__ method of the control.

#### __[C#] Example 2: Submit the changes in the view__
{{region raddataservicedatasource-crud_2}}
    private void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
        this.CustomersDataSource.SubmitChanges();
    }
{{endregion}}

#### __[VB.NET] Example 2: Submit the changes in the view__
{{region raddataservicedatasource-crud_2}}
	Private Sub SubmitButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Me.CustomersDataSource.SubmitChanges()
	End Sub
{{endregion}}

In order to reject the changes and reload the original data from the server you need to call the __RejectChanges__ method of the control.

#### __[C#] Example 3: Submit the changes in the view__
{{region cs-raddataservicedatasource-crud_3}}
    private void RejectButton_Click(object sender, RoutedEventArgs e)
    {
        this.CustomersDataSource.RejectChanges();
    }
{{endregion}}

#### __[VB.NET] Example 3: Submit the changes in the view__
{{region vb-raddataservicedatasource-crud_3}}
	Private Sub RejectButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Me.CustomersDataSource.RejectChanges()
	End Sub
{{endregion}}

## See Also
* [Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%})
* [MVVM Support]({%slug raddataservicedatasource-mvvm%})