---
title: Hide Zero Values Labels in PieChart
page_title: Remove Zero Values Labels in PieChart
description: This article described how to hide zero segments labels in PieChart
slug: radchartview-troubleshooting-hide-zero-segments-labels
tags: troubleshooting,howto,zero,piechart,label,pieseries,slice,hide,remove,segments
published: True
position: 0
---

# Hide Zero Segments Labels in PieChart 

There's different ways to hide/remove the labels of the zero segments inside __PieChart__. This article will describe one of them. In a few words we are going to hide the labels by binding the __Opacity__ property of the TextBlock which holds it. For the purpose of this example, firstly we will create the following ViewModels which are use for both chart scenarios:

#### __[C#] Example 1: Creating ViewModels__
{{region radchartview-troubleshooting-hide-zero-segments-labels_0}}	
	public class SliceModel : ViewModelBase
	{
		private double opacity = 1;        
		public double Opacity
		{
			get { return opacity; }
			set
			{
				if (opacity != value)
				{
					opacity = value;
					OnPropertyChanged("Opacity");
				}                
			}
		}					
		public double Value { get; set; }        
	}
	
	public class MainViewModel
    {        
        public ObservableCollection<SliceModel> Items { get; set; }
        public MainViewModel()
        {
            this.Items = new ObservableCollection<SliceModel>();
            this.Items.Add(new SliceModel() { Value = 20 });
            this.Items.Add(new SliceModel() { Value = 30 });
            this.Items.Add(new SliceModel() { Value = 40 });
            this.Items.Add(new SliceModel() { Value = 0, Opacity = 0 });
        }       
    }
{{endregion}}

The next step is to set the DataContext of the main Window.

#### __[C#] Example 2: Setting Window DataContext__
{{region radchartview-troubleshooting-hide-zero-segments-labels_1}}	
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = new MainViewModel();;
		}
	}
{{endregion}}

Now you just need to create a custom __DataTemplate__ for the __Template__ property of the __ChartSeriesLabelDefinition__. Inside this DataTemplate we can declare a TextBlock and bind its __Opacity__ property.

#### __[C#] Example 3: Hide Labels of Zero Segments in PieSeries__
{{region radchartview-troubleshooting-hide-zero-segments-labels_1}}	
	<telerik:RadPieChart Palette="Arctic">
		<telerik:PieSeries ValueBinding="Value" ItemsSource="{Binding Items}">
			<telerik:PieSeries.LabelDefinitions>
				<telerik:ChartSeriesLabelDefinition Margin="-20">
					<telerik:ChartSeriesLabelDefinition.Template>
						<DataTemplate>
							<TextBlock Text="{Binding Value}" Opacity="{Binding DataItem.Opacity}" />
						</DataTemplate>
					</telerik:ChartSeriesLabelDefinition.Template>
				</telerik:ChartSeriesLabelDefinition>
			</telerik:PieSeries.LabelDefinitions>
		</telerik:PieSeries>
	</telerik:RadPieChart>
{{endregion}}
