---
title: CRUD Operations with Cosmos DB and RadGridView
page_title: CRUD Operations with Cosmos DB and RadGridView
description: CRUD Operations with Cosmos DB and RadGridView
slug: crud-operations-gridview-cosmosdb
tags: crud,operations,radgridview,cosmosdb
published: True
position: 1
---

# CRUD Operations with Cosmos DB and RadGridView

**Azure Cosmos DB** is a globally distributed, multi-model database service which enables you to develop document, key-value, wide-column, and graph databases by using popular APIs and programming models. Using the **RadGridView** control, you can easily implement all CRUD operations to work with your remote database.

>important For the purposes of this article, we will assume that you've already set up the database from the [SQL API Getting Started Tutorial](https://docs.microsoft.com/en-us/azure/cosmos-db/sql-api-get-started).

## Read

Let us first define the RadGridView instance that we will be using.

#### __[XAML] Example 1: Adding RadGridView in XAML__

{{region xaml-crud-operations-gridview-cosmosdb-0}}
    <telerik:RadGridView x:Name="grid" AutoGenerateColumns="False"
                    RowDetailsTemplate="{StaticResource ParentGridTemplate}"
                    NewRowPosition="Top">
        <telerik:RadGridView.Columns>
            <telerik:GridViewToggleRowDetailsColumn />
            <telerik:GridViewDataColumn DataMemberBinding="{Binding Id}" />
            <telerik:GridViewDataColumn DataMemberBinding="{Binding LastName}" />
            <telerik:GridViewCheckBoxColumn DataMemberBinding="{Binding IsRegistered}" />
            <telerik:GridViewDataColumn DataMemberBinding="{Binding Address}" />
        </telerik:RadGridView.Columns>
    </telerik:RadGridView>
{{endregion}}

## See Also