---
title: Grouping
page_title: Grouping
description: The article describes the grouping feature of RadCardView.
slug: radcardview-features-grouping
tags: grouping,cardview
published: True
position: 5
---

# {{ site.framework_name }} RadCardView Grouping

RadCardView supports grouping via the UI or in code, in case you are using ICollectionView as the ItemsSource.

#### Figure 1: RadCardView groups
![{{ site.framework_name }} RadCardView RadCardView groups](images/radcardview-features-grouping-0.png)

The control internally works with a [QueryableCollectionView]({%slug consuming-data-queryablecollectionview%}) instance. If you set the ItemsSource of the RadCardView that is not a QueryableCollectionView, then the original collection is wrapped in a QueryableCollectionView instance. This way grouping is supported even if you use a more basic IEnumerable implementation, like `List<T>` or `ObservableCollection<T>`.
 
## Grouping in the UI

The data items can be grouped by dragging a data field descriptor from the [data field descriptors list]({%slug radcardview-visual-structure%}) to the group panel area.

#### Figure 2: Dragging data field descriptor
![{{ site.framework_name }} RadCardView Dragging data field descriptor](images/radcardview-features-grouping-1.png)

#### Figure 3: Grouped RadCardView
![{{ site.framework_name }} RadCardView Grouped RadCardView](images/radcardview-features-grouping-2.png)

The RadCardView groups support sorting by clicking onto the associated [group member button]({%slug radcardview-visual-structure%}). To disable this, set the __CanUserSortGroups__ property to __False__.

#### __[XAML] Example 1: Setting the CanUserSortGroups property__
{{region radcardview-features-grouping-0}}
	<telerik:RadCardView CanUserSortGroups="False" />
{{endregion}}

Additionally, the grouping can be disabled per [CardDataFieldDescriptor]({%slug radcardview-features-datafielddescriptors%}) by setting its __AllowGrouping__ property.

## Programmatic Grouping

The following example shows how to setup RadCardView, populate it a [QueryableCollectionView]({%slug consuming-data-queryablecollectionview%}) and add GroupDescriptors in code.

#### __[C#] Example 2: Defining the model__
{{region radcardview-features-grouping-1}}
	public class CardInfo
    {
        public string Header { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Category { get; set; }
    }
	
	public class MainViewModel
    {
        public ObservableCollection<CardInfo> Items { get; private set; }
        public QueryableCollectionView CollectionView { get; private set; }

        public MainViewModel()
        {
            int counter = 0;
            Items = new ObservableCollection<CardInfo>();
            for (int g = 0; g < 3; g++)
            {
                for (int i = 0; i < 6; i++)
                {
                    Items.Add(new CardInfo()
                    {
                        Header = "Card " + counter,
                        Name = "Name " + counter,
                        Number = counter,
                        Category = "Category " + g
                    });
                    counter++;
                }
            }

            CollectionView = new QueryableCollectionView(Items);
            CollectionView.GroupDescriptors.Add(new GroupDescriptor() { Member = "Category" });
        }
    }
{{endregion}} 

>tip Read the [QueryableCollectionView]({%slug consuming-data-queryablecollectionview%}#grouping) to see how to use the GroupDescriptors collection of the QueryableCollectionView.

#### __[C#] Example 3: Setting the DataContext__
{{region radcardview-features-grouping-2}}
	public MainWindow()
	{
		InitializeComponent();
		this.DataContext = new MainViewModel();
	}
{{endregion}}

#### __[XAML] Example 4: Setting up the view__
{{region radcardview-features-grouping-3}}
	<telerik:RadCardView ItemsSource="{Binding CollectionView}" CardHeaderBinding="{Binding Header}" />
{{endregion}}

## Events

The grouping operations invoke several events that can be used to customize the grouping. Read more in the [Events]({%slug radcardview-events%}#grouping) article.

## Customizing Grouping UI

The [group panel area]({%slug radcardview-visual-structure%}) can be customized using several public properties. To hide the area, set the __ShowGroupPanel__ property to __False__. Read more in the [Customizing Groups]({%slug radcardview-appearance-customizing-groups%}) article.

#### __[XAML] Example 5: Setting the ShowGroupPanel property__
{{region radcardview-features-grouping-4}}
	<telerik:RadCardView ShowGroupPanel="False" />
{{endregion}}

## See Also
* [Getting Started]({%slug radcardview-getting-started%})
* [Data Binding]({%slug radcardview-populating-with-data-data-binding%})
* [Filtering]({%slug radcardview-features-filtering%})
* [Sorting]({%slug radcardview-features-sorting%})