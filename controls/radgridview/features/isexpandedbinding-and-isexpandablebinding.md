---
title: IsExpandedBinding and IsExpandableBinding
page_title: IsExpandedBinding and IsExpandableBinding
description: Learn how to synchronize the expanded and expandable states of the rows with the view model when working with RadGridView - Telerik's {{ site.framework_name }} DataGrid. 
slug: radgridview-isexpandedbinding-isexpandablebinding
tags: isexpandedbinding,and,isexpandablebinding
published: True
position: 18
---

# IsExpandedBinding and IsExpandableBinding

> This functionality is available only when  [Hierarchical RadGridView]({%slug gridview-basic-hierarchies%}) is used.

As of __R1 2018 SP2 RadGridView__ exposes the __IsExpandedBinding__ and __IsExpandableBinding__ properties. Through it the expanded and expandable states of the rows can be synchronized with the view model. For the purpose of demonstrating this functionality, the following business model will be defined.


__Example 1: Defining the business model__
```C#
    public class WarehouseItem 
    {
        private bool isExpanded;
        private string name;

        public WarehouseItem(string name, bool isExpanded = true)
        {
            this.Name = name;
            this.IsExpanded = isExpanded;
            this.Items = new ObservableCollection<WarehouseItem>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public bool IsExpanded
        {
            get
            {
                return this.isExpanded;
            }
            set
            {

                this.isExpanded = value;

            }
        }

		[Display(AutoGenerateField = false)]
        public ObservableCollection<WarehouseItem> Items { get; set; }

    }
```

__Example 2: Create sample data__
```C#
	public class MyDataContext
    {
        ObservableCollection<WarehouseItem> warehouseData;
        public ObservableCollection<WarehouseItem> WarehouseData
        {
            get
            {
                if (warehouseData == null)
                {
                    warehouseData = new ObservableCollection<WarehouseItem>();
                    var drinks = new WarehouseItem("Drinks");
                    drinks.Items.Add(new WarehouseItem("Water"));
                    var tea = new WarehouseItem("Tea");
                    tea.Items.Add(new WarehouseItem("Black"));
                    tea.Items.Add(new WarehouseItem("Green"));
                    drinks.Items.Add(tea);
                    drinks.Items.Add(new WarehouseItem("Coffee"));
                    warehouseData.Add(drinks);

                    var vegetables = new WarehouseItem("Vegetables");
                    vegetables.Items.Add(new WarehouseItem("Tomato"));
                    vegetables.Items.Add(new WarehouseItem("Carrot"));
                    vegetables.Items.Add(new WarehouseItem("Onion"));
                    warehouseData.Add(vegetables);

                    var fruits = new WarehouseItem("Fruits");
                    fruits.Items.Add(new WarehouseItem("Cherry"));
                    fruits.Items.Add(new WarehouseItem("Apple"));
                    fruits.Items.Add(new WarehouseItem("Melon"));
                    warehouseData.Add(fruits);
                }

                return warehouseData;
            }
        }
    }
```

## IsExpandedBinding

This property controls whether the hierarchy should be expanded or not. Setting the bound property to __true__ will result in expanding the given hierarchy.

#### [XAML] Example 3: Binding the IsExpandedBinding to the business model
```XAML
	<telerik:RadGridView x:Name="RadGridView"
								 ItemsSource="{Binding WarehouseData}"
                                 IsExpandedBinding="{Binding IsExpanded, Mode=TwoWay}"
								 CanUserFreezeColumns="False"
								 RowIndicatorVisibility="Collapsed"
								 ColumnWidth="*">
            <telerik:RadGridView.ChildTableDefinitions>
                <telerik:GridViewTableDefinition>
                    <telerik:GridViewTableDefinition.Relation>
                        <telerik:PropertyRelation ParentPropertyName="Items" />
                    </telerik:GridViewTableDefinition.Relation>
                </telerik:GridViewTableDefinition>
            </telerik:RadGridView.ChildTableDefinitions>
        </telerik:RadGridView>
```

#### Figure 1: Expanding hierarchy through the IsExpandedBinding property
![Telerik {{ site.framework_name }} DataGrid-isexpandedbinding-isexpandablebinding 1](images/radgridview-isexpandedbinding-isexpandablebinding_1.png)

## IsExpandableBinding

The visibility of the __GridViewToggleButton__ can be controlled through setting the property value. For example, if there are no items present in the hierarchical collection, the bound property can be set to __false__ thus, the toggle button will be hidden.

#### [XAML] Example 4: Binding the IsExpandableBinding to the business model
```XAML
	<telerik:RadGridView x:Name="RadGridView"
								 ItemsSource="{Binding WarehouseData}"
                                 IsExpandableBinding="{Binding IsExpandable, Mode=TwoWay}"
								 CanUserFreezeColumns="False"
								 RowIndicatorVisibility="Collapsed"
								 ColumnWidth="*">
            <telerik:RadGridView.ChildTableDefinitions>
                <telerik:GridViewTableDefinition>
                    <telerik:GridViewTableDefinition.Relation>
                        <telerik:PropertyRelation ParentPropertyName="Items" />
                    </telerik:GridViewTableDefinition.Relation>
                </telerik:GridViewTableDefinition>
            </telerik:RadGridView.ChildTableDefinitions>
        </telerik:RadGridView>
```

#### Figure 2: Hiding the GridViewToggleButton through the IsExpandableBinding
![Telerik {{ site.framework_name }} DataGrid-isexpandedbinding-isexpandablebinding 2](images/radgridview-isexpandedbinding-isexpandablebinding_2.png)

## See Also

* [Defining Columns]({%slug gridview-columns-defining-columns%})
