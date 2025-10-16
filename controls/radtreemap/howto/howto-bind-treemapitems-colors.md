---
title: How to Bind the Color of the TreeMapItems
page_title: How to Bind the Color of the TreeMapItems
description: Check our &quot;How to bind the color of the TreeMapItems&quot; documentation article for the RadTreeMap {{ site.framework_name }} control.
slug: radtreemap-howto-bind-color
tags: bind,color,treemapitem,background,itemstyle
published: True
position: 1
---

# How to Bind the Color of the TreeMapItems

This topic will show you how to bind the color of the TreeMapItems. 

For the purpose of this example, we will create the following model.

__Example 1: Create ItemInfo Model__
```C#
	public class ItemInfo
	{
		public Brush Fill { get; set; }
		public string Label { get; set; }
		public double Value { get; set; }
		public ObservableCollection<ItemInfo> Children { get; set; }

		public ItemInfo()
		{
				
			this.Children = new ObservableCollection<ItemInfo>();
		}
	}
```

Next, we can go ahead and create sample data.

__Example 2: Create Sample Data__
```C#
	public class ViewModel
    {
        Random rnd = new Random();
        public ObservableCollection<ItemInfo> Data { get; set; }
        public ViewModel()
        {
            Data = GetData();
        }
        private ObservableCollection<ItemInfo> GetData()
        {
            var source = new ObservableCollection<ItemInfo>();
            for (int i = 0; i < 2; i++)
            {
                var level1Item = new ItemInfo()
                {
                    Value = rnd.Next(10, 100),
                    Label = "Level 1 Item - " + i,
                    Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)rnd.Next(1, 233)))
                };

                for (int y = 0; y < 2; y++)
                {
                    var level2Item = new ItemInfo()
                    {
                        Value = rnd.Next(10, 100),
                        Label = "Level 2 Item - " + y,
                        Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)rnd.Next(1, 233)))
                    };

                    for (int k = 0; k < 2; k++)
                    {
                        level2Item.Children.Add(new ItemInfo()
                        {
                            Value = rnd.Next(10, 100),
                            Label = "Level 3 Item - " + k,
                            Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)rnd.Next(1, 233)))
                        });
                    }
                    level1Item.Children.Add(level2Item);
                }
                source.Add(level1Item);
            }
            return source;
        }
    }
```

Now, we can declare our RadTreeMap control in XAML. To bind the color of the items, we can use the __ItemStyle__ of the TypeDefinition. This property is of type Style which targets RadTreeMapItem.

__Example 3: Declare our RadTreeMap in XAML__
```XAML
	<telerik:RadTreeMap ItemsSource="{Binding Data}">
		<telerik:RadTreeMap.TypeDefinitions>
			<telerik:TypeDefinition TargetTypeName="ItemInfo" ValuePath="Value" ChildrenPath="Children" LabelPath="Label">
				<telerik:TypeDefinition.ItemStyle>
					<Style TargetType="telerik:RadTreeMapItem">
						<Setter Property="Background" Value="{Binding DataItem.Fill}" />
					</Style>
				</telerik:TypeDefinition.ItemStyle>
			</telerik:TypeDefinition>
		</telerik:RadTreeMap.TypeDefinitions>
	</telerik:RadTreeMap>
```

And finally, we need to set our DataContext to the ViewModel.

__Example 4: Setting our DataContext__
```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();            
			this.DataContext = new ViewModel();
		}
	}
```

If you run the application now, the RadTreeMap should display the following structure:

#### Figure 1: RadTreeMap with bound colors 
![TreeMap Bind Color](images/radtreemap-howto-bind-color-1.png)

## See Also
* [Overview]({%slug radtreemap-overview %})
* [SDK Examples]({%slug radtreemap-sdk-examples %})
* [Populating With Data RadTreeMap]({%slug radtreemap-populating-with-data-radtreemap %})
* [Populating With Data RadPivotMap]({%slug radtreemap-populating-with-data-radpivotmap %})
