---
title: Data Binding
page_title: Data Binding - MVVM
description: Check our &quot;Data Binding&quot; MVVM documentation article for the RadStepProgressBar control.
slug: stepprogressbar-data-binding
tags: data,binding,mvvm
published: True
position: 4
---

# Data Binding (MVVM)

The `RadStepProgressBar` control can be used in a data binding scenario. 

The component's `ItemsSource` property can be assigned to a collection of any objects. A `RadStepProgressBarItem` will be auto generated for each item in the ItemsSource. The following example shows how to setup the control in this scenario.

__Defining the models__
```C#
	public class StepInfo
	{
		public string Text { get; set; }
        public string AdditionalText { get; set; }		
	}

	public class MainViewModel : ViewModelBase
	{
		private StepInfo selectedStep;
		private Geometry stepShapeGeometry;

		public Geometry StepShapeGeometry
		{
			get { return stepShapeGeometry; }
			set 
			{ 
				stepShapeGeometry = value;
				OnPropertyChanged("StepShapeGeometry");
			}
		}

		public ObservableCollection<StepInfo> Steps { get; set; }

		public StepInfo SelectedStep
		{
			get { return selectedStep; }
			set 
			{ 
				selectedStep = value;
				OnPropertyChanged("SelectedStep");
			}
		}

		public MainViewModel()
		{
			Steps = new ObservableCollection<StepInfo>();
			Steps.Add(new StepInfo() { Text = "Your Cart", AdditionalText = "Step 1" });
			Steps.Add(new StepInfo() { Text = "Cart", AdditionalText = "Step 2" });
			Steps.Add(new StepInfo() { Text = "Payment", AdditionalText = "Step 3" });

			var geometry = new RectangleGeometry(new Rect(0, 0, 1, 1));
			geometry.Transform = new RotateTransform(45);
			StepShapeGeometry = geometry;
		}
	}
```
```VB.NET
	Public Class StepInfo
	    Public Property Text As String
	    Public Property AdditionalText As String
	End Class

	Public Class MainViewModel
	    Inherits ViewModelBase

	    Private selectedStep As StepInfo
	    Private stepShapeGeometry As Geometry

	    Public Property StepShapeGeometry As Geometry
	        Get
	            Return stepShapeGeometry
	        End Get
	        Set(ByVal value As Geometry)
	            stepShapeGeometry = value
	            OnPropertyChanged("StepShapeGeometry")
	        End Set
	    End Property

	    Public Property Steps As ObservableCollection(Of StepInfo)

	    Public Property SelectedStep As StepInfo
	        Get
	            Return selectedStep
	        End Get
	        Set(ByVal value As StepInfo)
	            selectedStep = value
	            OnPropertyChanged("SelectedStep")
	        End Set
	    End Property

	    Public Sub New()
	        Steps = New ObservableCollection(Of StepInfo)()
	        Steps.Add(New StepInfo() With {
	            .Text = "Your Cart",
	            .AdditionalText = "Step 1"
	        })
	        Steps.Add(New StepInfo() With {
	            .Text = "Cart",
	            .AdditionalText = "Step 2"
	        })
	        Steps.Add(New StepInfo() With {
	            .Text = "Payment",
	            .AdditionalText = "Step 3"
	        })
	        Dim geometry = New RectangleGeometry(New Rect(0, 0, 1, 1))
	        geometry.Transform = New RotateTransform(45)
	        StepShapeGeometry = geometry
	    End Sub
	End Class
```

__Initializing the view model__
```C#
	public MainWindow()
	{
		InitializeComponent();
		DataContext = new MainViewModel();
	}
```
```VB.NET
	Public Sub New()
	    InitializeComponent()
	    DataContext = New MainViewModel()
	End Sub
```

__Setting up the XAML__
```XAML
	<telerik:RadStepProgressBar ItemsSource="{Binding Steps}"
								SelectedItem="{Binding SelectedStep, Mode=TwoWay}">
		<telerik:RadStepProgressBar.ItemContainerStyle>
			<Style TargetType="telerik:RadStepProgressBarItem">
				<Setter Property="ShapeStroke" Value="#EC6CEE" />
				<Setter Property="ShapeGeometry" Value="{Binding RelativeSource={RelativeSource AncestorType=telerik:RadStepProgressBar}, Path=DataContext.StepShapeGeometry}" />
			</Style>
		</telerik:RadStepProgressBar.ItemContainerStyle>
		<telerik:RadStepProgressBar.ItemTemplate>
			<DataTemplate>
				<TextBlock Text="{Binding Text}" FontWeight="Bold" />
			</DataTemplate>
		</telerik:RadStepProgressBar.ItemTemplate>
		<telerik:RadStepProgressBar.ItemAdditionalContentTemplate>
			<DataTemplate>
				<TextBlock Text="{Binding AdditionalText}" Foreground="#8591A2" />
			</DataTemplate>
		</telerik:RadStepProgressBar.ItemAdditionalContentTemplate>
	</telerik:RadStepProgressBar>
```

__Data bound StepProgressBar control__  

![{{ site.framework_name }} RadStepProgressBar Bound to Data](images/stepprogressbar-data-binding-0.png)

The previous example shows how to data bind the ItemsSource and SelectedItem of the control. This will populate it with data. The SelectedItem binding can be used in a separate visual element if you need to connect the selected step with a separate view.

The visualization of the text at the bottom and top is customized via the `ItemTemplate` and `ItemAdditionalContentTemplate` properties. Alternative of the ItemTemplate setting is the `DisplayMemberPath` that can point to a property from the model of the step.

The `ItemContainerStyle` property is used to customize the RadStepProgressBarItem elements created for each object in the ItemsSource. 

## See Also
* [Getting Started]({%slug stepprogressbar-getting-started%})
* [Visual Structure]({%slug stepprogressbar-visual-structure%})
