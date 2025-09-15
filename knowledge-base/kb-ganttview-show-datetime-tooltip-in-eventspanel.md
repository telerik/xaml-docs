---
title: Show ToolTip With DateTime Under Mouse in Eventspanel
description: How to display a datetime tooltip in eventspanel.
type: how-to
page_title: Convert mouse coordinates to datetime in eventspanel
slug: kb-ganttview-show-datetime-tooltip-in-eventspanel
position: 0
tags: ganttview, datetime, tooltip, mouse, position, eventspanel
ticketid: 1389043
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadGanttView for WPF</td>
	</tr>
</table>

## Description

How to display a tooltip showing a datetime on mouse location in the eventspanel.

## Solution

1. Obtain a reference to the EventsPanel inside the RadGanttView using the [ChildlrenOfType]({%slug common-visual-tree-helpers%}#childrenoftypeextensions) extension method. 
2. Handle its MouseLeave, MouseEnter and MouseMove events.  
3. Create a tooltip and set its PlacementTarget to the EventsPanel. The tooltip will be opened/closed in the MouseEnter/MouseLeave events and its Content and position will changed in the MouseMove event.
4. Introduce logic that translates the mouse coordinates to a datetime as demonstrated in the following example. Note, that the logic will be different depending on whether the VisibleRange of the RadGanttView is set or not.


```C#
	public partial class MainWindow : Window
    {
        private RadToolTip tooltip = new RadToolTip();
        private LogicalCanvasPanel eventsPanel;
        private ScrollBar horizontalScrollBar;
        private VisibleRange VisibleRange = new VisibleRange(DateTime.Now.AddYears(-2), DateTime.Now.AddYears(2));

        public MainWindow()
        {
            InitializeComponent();
            
            var date = DateTime.Now;
            var task1 = new GanttTask(date, date.AddDays(1), "task 1");
            var task2 = new GanttTask(date.AddDays(1), date.AddDays(350).AddHours(15), "task 2");
            var mainTask = new GanttTask(date, date.AddDays(2), "my task") { Children = { task1, task2 } };

            this.DataContext = new ObservableCollection<GanttTask>() { mainTask };

            this.ganttView.VisibleRange = this.VisibleRange;
            this.ganttView.Loaded += GanttView_Loaded;
        }
           
        private void GanttView_Loaded(object sender, RoutedEventArgs e)
        {
            this.eventsPanel = this.ganttView
                .ChildrenOfType<LogicalCanvasPanel>()
                .FirstOrDefault(x => x.Name == "EventsPanel");

            this.horizontalScrollBar = this.eventsPanel
                .ParentOfType<GanttPresenterPanel>()
                .ChildrenOfType<ScrollBar>()
                .ElementAt(1);
            
            this.tooltip.PlacementTarget = this.eventsPanel;
            this.tooltip.Placement = PlacementMode.Relative;
            this.tooltip.HorizontalAlignment = HorizontalAlignment.Right;
            this.tooltip.VerticalOffset = 10;

            this.eventsPanel.MouseEnter += EventsPanel_MouseEnter;

            this.eventsPanel.AddHandler(LogicalCanvasPanel.MouseLeaveEvent, new MouseEventHandler(EventsPanel_MouseLeave), true);
            this.eventsPanel.MouseMove += EventsPanel_MouseMove;            
        }

        private void EventsPanel_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.tooltip.IsOpen = false;
        }
        
        private void EventsPanel_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.tooltip.IsOpen = true;
        }

        private void EventsPanel_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Point position = e.GetPosition(this.eventsPanel);

            DateTime date;
            if (this.ganttView.VisibleRange != null)
            {
                date = ConvertPointToDate(position, this.ganttView);
            }
            else
            {
                date = ConvertPointToDate(position, this.eventsPanel);
            }

            this.tooltip.Content = date;
            this.tooltip.HorizontalOffset = position.X + 5;
            this.tooltip.VerticalOffset = position.Y + 5;
        }

        public DateTime ConvertPointToDate(Point point, LogicalCanvasPanel canvasPanel)
        {
            TimeRenderingHelper renderingHelper = (TimeRenderingHelper)canvasPanel.HorizontalHelper;
            Range<long> viewportRange = (Range<long>)renderingHelper.GetLogicalViewport(new Range<double>(point.X, point.X));

            return new DateTime(viewportRange.Start);
        }

        public DateTime ConvertPointToDate(Point point, RadGanttView gantt)
        {            
            double offsetX = this.horizontalScrollBar.Value;
            long ticksPerPixel = gantt.PixelLength.Ticks;
            var tickOnPoint = (point.X + this.horizontalScrollBar.Value) * ticksPerPixel;

            return gantt.VisibleRange.Start.AddTicks((long)tickOnPoint);
        }
```


```XAML
	<telerik:RadGanttView x:Name="ganttView" TasksSource="{Binding}">
            <telerik:RadGanttView.Columns>
                <telerik:TreeColumnDefinition Header="Title" Width="AutoHeaderAndContent"/>
                <telerik:ColumnDefinition MemberBinding="{Binding Start}" Header="Start" Width="AutoHeaderAndContent"/>
                <telerik:ColumnDefinition MemberBinding="{Binding End}" Header="End" Width="AutoHeaderAndContent"/>
            </telerik:RadGanttView.Columns>
        </telerik:RadGanttView>
```