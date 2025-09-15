---
title: How to Preserve the Groups Expand State When New Item is Added
description: Save the expanded state of the groups after new element is inserted in the ItemsSource of the RadTimeline control.
type: how-to
page_title: How to save expand/collapse state of grouped elements when a new item is added
slug: kb-timeline-preserve-groups-expand-state
position: 0
tags: expand,collapse,grouping,timelineitemgroupcontrol
ticketid: 1401798
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadTimeline for WPF</td>
	</tr>
</table>

## Description

How to preserve groups' collapsed/expanded state when new items are added to the RadTimeline.

## Solution

Save the names of the TimelineItemGroupControl elements.


```C#
	public partial class MainWindow : Window
    {
        private ObservableCollection<MyPlotInfo> source;        
        private List<string> expandedGroupNames = new List<string>();
        
        public MainWindow()
        {
            InitializeComponent();            
            this.source = new ObservableCollection<MyPlotInfo>();
        }        

        private void AddNewDataItem(DateTime start, TimeSpan duration, string groupName)
        {
            this.PreserveExpandedGroups();
            this.source.Add(new MyPlotInfo()
            {
                Start = start,
                Duration = duration,
                GroupName = groupName
            });
            this.RestorePreservedGroups();
        }
        
        private void PreserveExpandedGroups()
        {
            this.expandedGroupNames.Clear();

            foreach (var group in this.timeline.GroupedDataItems)
            {                
                var groupContainer = this.timeline.GetGroupByGroupHeader(group.GroupKey);
                if (groupContainer != null && groupContainer.IsExpanded)
                {
                    this.expandedGroupNames.Add(group.GroupKey);
                }
            }
        }

        private void RestorePreservedGroups()
        {
            foreach (var groupName in this.expandedGroupNames)
            {
                var groupContainer = this.timeline.GetGroupByGroupHeader(groupName);
                if (groupContainer != null)
                {
                    groupContainer.IsExpanded = true;
                }                
            }
        }
    }
```

Note that the code snippet is not fully functional. You will need to add a logic that populates the source and also that calls the AddNewDataItem method.

## See Also

* [Grouping]({%slug radtimeline-features-grouping%})
