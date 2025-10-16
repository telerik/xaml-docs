---
title: Persist the Selection of the RadGridView when it is Paged
description: Prevent the Loss of the Selected Items of the RadGridView while Changing Pages.
type: howto
page_title: Preserve the Selected Rows when a RadDataPager is Used
slug: kb-gridview-howto-datapager-persist-selection
position: 0
tags: selection, datapager, persist, preserve, save
ticketid: 1449390
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

How to save and restore the selection in a RadGridView when a RadDataPager is used for paging.

## Solution

Handle the __PageIndexChanging__ event in order to save the selection for the current page and the __PageIndexChanged__ event in order to restore it. __Example 1__ demonstrates some sample logic for how this can be achieved.

__Example 1: Custom Behavior with logic for persisting the RadGridView selection__
```C#

    public class PersistSelectionBehavior : Behavior<RadDataPager>
    {
        public static void SetTargetGrid(DependencyObject obj, object value)
        {
            obj.SetValue(TargetGridProperty, value);
        }

        public static readonly DependencyProperty TargetGridProperty =
            DependencyProperty.RegisterAttached("TargetGrid", typeof(object), typeof(PersistSelectionBehavior), new PropertyMetadata(null));

        protected override void OnAttached()
        {
            base.OnAttached();

            this.AssociatedObject.PageIndexChanging += Pager_PageIndexChanging;
            this.AssociatedObject.PageIndexChanged += Pager_PageIndexChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();

            this.AssociatedObject.PageIndexChanging -= Pager_PageIndexChanging;
            this.AssociatedObject.PageIndexChanged -= Pager_PageIndexChanged;
        }

        public static object GetTargetGrid(DependencyObject obj)
        {
            return (object)obj.GetValue(TargetGridProperty);
        }

        public RadGridView PagedGrid
        {
            get
            {
                return this.GetValue(TargetGridProperty) as RadGridView;
            }
        }

        private static Dictionary<int, List<object>> persistedSelectionPerPage = new Dictionary<int, List<object>>();

        private void Pager_PageIndexChanging(object sender, PageIndexChangingEventArgs e)
        {
            if (!persistedSelectionPerPage.ContainsKey(e.OldPageIndex))
            {
                persistedSelectionPerPage[e.OldPageIndex] = new List<object>();
            }

            persistedSelectionPerPage[e.OldPageIndex].Clear();
            foreach (var item in this.PagedGrid.SelectedItems)
            {
                persistedSelectionPerPage[e.OldPageIndex].Add(item);
            }
        }

        private void Pager_PageIndexChanged(object sender, PageIndexChangedEventArgs e)
        {
            if (persistedSelectionPerPage.ContainsKey(e.NewPageIndex))
            {
                foreach (var item in persistedSelectionPerPage[e.NewPageIndex])
                {
                    this.PagedGrid.SelectedItems.Add(item);
                }
            }
        }
    }
```

> In order to utilize the __Behavior__ class, you should add a reference to the "System.Windows.Interactivity" dll.

__Example 2: RadGridView and RadDataPager setup in xaml__
```XAML

    <Grid xmlns:i="http://schemas.microsoft.com/expression/2010/interactivity">
        <Grid.DataContext>
            <my:MyViewModel />
        </Grid.DataContext>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>
        <telerik:RadGridView Name="clubsGrid" 
                             ItemsSource="{Binding Clubs}"
                             AutoGenerateColumns="False"
                             GroupRenderMode="Flat"
                             SelectionMode="Multiple"
                             EnableLostFocusSelectedState ="False">
            <telerik:RadGridView.Columns>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"/>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Established}"
                                            Header="Est." 
                                            DataFormatString="{}{0:yyyy}"/>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding StadiumCapacity}" 
                                            Header="Stadium" 
                                            DataFormatString="{}{0:N0}"/>
            </telerik:RadGridView.Columns>
        </telerik:RadGridView>

        <telerik:RadDataPager x:Name="radDataPager"
                              Source="{Binding Items, ElementName=clubsGrid}"
                              PageSize="5"
                              Grid.Row="1">
            <i:Interaction.Behaviors>
                <my:PersistSelectionBehavior TargetGrid="{Binding ElementName=clubsGrid}" />
            </i:Interaction.Behaviors>
        </telerik:RadDataPager>
    </Grid>
```

> The "my" namespace refers to the namespace where the "PersistSelectionBehavior" class is defined. 

## See Also

* [RadGridView Getting Started]({%slug gridview-getting-started2%})
* [RadDataPager Getting Started]({%slug raddatapager-getting-started%})
* [DataPager Events]({%slug raddatapager-events-overview%})