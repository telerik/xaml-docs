---
title: Use MVVM in RadToolbar
page_title: Use MVVM in RadToolbar
description: Use MVVM in RadToolbar
slug: use-mvvm-in-radtoolbar
tags: mvvm,support
published: True
position: 5
---

# Use MVVM in RadToolbar

This example shows how to use the __RadToolBar__ control with the Model-View-ViewModel (MVVM) pattern and a custom DataTemplateSelector.

### 1. __Implementing the custom DataTemplateSelector__

Since there is no ToolBarItem, because ToolBar may contain variety of other controls, we will use custom DataTemplateSelector to help us determine the template for each item inside the ToolBar:            

#### __[C#] Example 1: Implementing the custom DataTemplateSelector__

{{region radtoolbar-mvvm-support-0}}
    public class ToolBarItemTemplateSelector : DataTemplateSelector
    {
        public override System.Windows.DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is TextBlockViewModel)
            {
                return this.TextBlockTemplate;
            }
            else if (item is ColorPickerViewModel)
            {
                return this.ColorPickerTemplate;
            }
            return base.SelectTemplate(item, container);
        }

        public DataTemplate TextBlockTemplate { get; set; }
        public DataTemplate ColorPickerTemplate { get; set; }
    }
{{endregion}}

#### __[VB.NET] Example 1: Implementing the custom DataTemplateSelector__

{{region radtoolbar-mvvm-support-1}}
    Public Class ToolBarItemTemplateSelector
        Inherits DataTemplateSelector
        Public Overrides Function SelectTemplate(item As Object, container As System.Windows.DependencyObject) As System.Windows.DataTemplate
            If TypeOf item Is TextBlockViewModel Then
                Return Me.TextBlockTemplate
            ElseIf TypeOf item Is ColorPickerViewModel Then
                Return Me.ColorPickerTemplate
            End If
            Return MyBase.SelectTemplate(item, container)
        End Function

        Public Property TextBlockTemplate() As DataTemplate
            Get
                Return m_TextBlockTemplate
            End Get
            Set
                m_TextBlockTemplate = Value
            End Set
        End Property
        Private m_TextBlockTemplate As DataTemplate
        Public Property ColorPickerTemplate() As DataTemplate
            Get
                Return m_ColorPickerTemplate
            End Get
            Set
                m_ColorPickerTemplate = Value
            End Set
        End Property
        Private m_ColorPickerTemplate As DataTemplate
    End Class
{{endregion}}


#### __[XAML] Example 2: Assigning the ItemTemplateSelector Property__

{{region radtoolbar-mvvm-support-2}}
    <Window.Resources>
        <local:ToolBarItemTemplateSelector 	x:Key="TemplateSelector"
                                            TextBlockTemplate="{StaticResource TextBlockTemplate}"
                                            ColorPickerTemplate="{StaticResource RadColorPickerTemplate}"/>
    </Window.Resources>

    <telerik:RadToolBar ItemTemplateSelector="{StaticResource TemplateSelector}" />
{{endregion}}

### 2. __Creating ViewModels__

We will create two view models for this example: ColorPickerViewModel and TextBlockViewModel. The ColorPickerViewModel will contain a collection of colors and the TextBlockViewModel will contain only one property - Text:

#### __[C#] Example 3: Defining ColorPickerViewModel and TextViewModel__

{{region radtoolbar-mvvm-support-3}}
    public class ColorPickerViewModel : ViewModelBase
    {
        public ColorPickerViewModel()
        {
            this.MainPaletteColors = new ObservableCollection<Color>()
            {
                Color.FromArgb(255, 253, 253, 0),
                Color.FromArgb(255, 0, 253, 0),
                Color.FromArgb(255, 0, 253, 253),
                Color.FromArgb(255, 253, 0, 253),
                Color.FromArgb(255, 0, 0 , 253 ),
                Color.FromArgb(255, 253, 0 ,0),
                Color.FromArgb(255, 0 , 0, 126),
                Color.FromArgb(255, 0, 126, 126),
                Color.FromArgb(255, 0, 126, 0),
                Color.FromArgb(255, 126, 0, 126),
                Color.FromArgb(255, 126, 0, 0),
                Color.FromArgb(255, 126, 126, 0),
                Color.FromArgb(255, 126, 126, 126),
                Color.FromArgb(255, 190, 190, 190),
                Color.FromArgb(255, 0 , 1 , 1)
            };
        }
        public ObservableCollection<Color> MainPaletteColors { get; set; }
    }

    public class TextBlockViewModel : ViewModelBase
    {
        public TextBlockViewModel(string text)
        {
            this.Text = text;
        }

        private string text;
        public string Text
        {
            get { return this.text; }
            set
            {
                if (this.text != value)
                {
                    this.text = value;
                    this.OnPropertyChanged("Text");
                }
            }
        }

    }
{{endregion}}

#### __[VB.NET] Example 3: Defining ColorPickerViewModel and TextViewModel__

{{region radtoolbar-mvvm-support-4}}
    Public Class ColorPickerViewModel
    Inherits ViewModelBase
    Public Sub New()
        Me.MainPaletteColors = New ObservableCollection(Of Color)() From { _
            Color.FromArgb(255, 253, 253, 0), _
            Color.FromArgb(255, 0, 253, 0), _
            Color.FromArgb(255, 0, 253, 253), _
            Color.FromArgb(255, 253, 0, 253), _
            Color.FromArgb(255, 0, 0, 253), _
            Color.FromArgb(255, 253, 0, 0), _
            Color.FromArgb(255, 0, 0, 126), _
            Color.FromArgb(255, 0, 126, 126), _
            Color.FromArgb(255, 0, 126, 0), _
            Color.FromArgb(255, 126, 0, 126), _
            Color.FromArgb(255, 126, 0, 0), _
            Color.FromArgb(255, 126, 126, 0), _
            Color.FromArgb(255, 126, 126, 126), _
            Color.FromArgb(255, 190, 190, 190), _
            Color.FromArgb(255, 0, 1, 1) _
        }
    End Sub
    Public Property MainPaletteColors() As ObservableCollection(Of Color)
        Get
            Return m_MainPaletteColors
        End Get
        Set
            m_MainPaletteColors = Value
        End Set
    End Property
    Private m_MainPaletteColors As ObservableCollection(Of Color)
    End Class

    Public Class TextBlockViewModel
        Inherits ViewModelBase
        Public Sub New(text As String)
            Me.Text = text
        End Sub

        Private m_text As String
        Public Property Text() As String
            Get
                Return Me.m_text
            End Get
            Set
                If Me.m_text <> value Then
                    Me.m_text = value
                    Me.OnPropertyChanged("Text")
                End If
            End Set
        End Property

    End Class
{{endregion}}


The next step is to define the templates for the ViewModel classes:            

> In order to use the RadColorPicker, you have to add references to the following assembly: __Telerik.Windows.Controls.Input__

#### __[XAML] Example 4: Defining the templates for the ViewModels:

{{region radtoolbar-mvvm-support-5}}
    <DataTemplate x:Key="TextBlockTemplate">
        <TextBlock FontWeight="Bold" Text="{Binding Text}"/>
    </DataTemplate>

    <DataTemplate x:Key="RadColorPickerTemplate">
        <telerik:RadColorPicker HeaderPaletteVisibility="Collapsed" 
                                StandardPaletteVisibility="Collapsed"
                                MainPaletteItemsSource="{Binding MainPaletteColors}" 
                                MainPaletteHeaderText="Custom Colors"  
                                MainPaletteColumnsCount="5" 
                                MainPaletteOrientation="Horizontal" />
    </DataTemplate>
{{endregion}}

After that we are going to create our MainViewModel which will contain a collection of our ViewModels:

#### __[C#] Example 5: Creating the MainViewModel__

{{region radtoolbar-mvvm-support-6}}
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.PopulateSampleViewModel();
        }
        public ObservableCollection<ViewModelBase> Items { get; set; }

        private void PopulateSampleViewModel()
        {
            this.Items = new ObservableCollection<ViewModelBase>()
            {
                new TextBlockViewModel("Foreground:"),
                new ColorPickerViewModel(),
                new TextBlockViewModel("Background:"),
                new ColorPickerViewModel(),
                new TextBlockViewModel("BorderColor:"),
                new ColorPickerViewModel(),
            };
        }
    }
{{endregion}}

#### __[VB.NET] Example 5: Creating the MainViewModel__

{{region radtoolbar-mvvm-support-7}}
    Public Class MainViewModel
        Public Sub New()
            Me.PopulateSampleViewModel()
        End Sub
        Public Property Items() As ObservableCollection(Of ViewModelBase)
            Get
                Return m_Items
            End Get
            Set
                m_Items = Value
            End Set
        End Property
        Private m_Items As ObservableCollection(Of ViewModelBase)

        Private Sub PopulateSampleViewModel()
            Me.Items = New ObservableCollection(Of ViewModelBase)() From { _
                New TextBlockViewModel("Foreground:"), _
                New ColorPickerViewModel(), _
                New TextBlockViewModel("Background:"), _
                New ColorPickerViewModel(), _
                New TextBlockViewModel("BorderColor:"), _
                New ColorPickerViewModel() _
            }
        End Sub
    End Class
{{endregion}}

### 3.  __Setting the DataContext and ItemsSource of the RadToolBar__

Finally we need to instantiate our ViewModel, assign it as the DataContext of the ToolBar and bind the ItemsSource property to the Items property in our ViewModel. We also set the VerticalAlignment to center and add some margin for better visualization:

#### __[XAML] Example 6: Setting the DataContext and ItemsSource of the RadToolBar:

{{region radtoolbar-mvvm-support-8}}
<Window.Resources>
        <DataTemplate x:Key="TextBlockTemplate">
            <TextBlock FontWeight="Bold" Text="{Binding Text}"/>
        </DataTemplate>

        <DataTemplate x:Key="RadColorPickerTemplate">
            <telerik:RadColorPicker HeaderPaletteVisibility="Collapsed" 
                                StandardPaletteVisibility="Collapsed"
                                MainPaletteItemsSource="{Binding MainPaletteColors}" 
                                MainPaletteHeaderText="Custom Colors"  
                                MainPaletteColumnsCount="5" 
                                MainPaletteOrientation="Horizontal"/>
        </DataTemplate>
        
        <local:ToolBarItemTemplateSelector 	x:Key="TemplateSelector"
                                            TextBlockTemplate="{StaticResource TextBlockTemplate}"
                                            ColorPickerTemplate="{StaticResource RadColorPickerTemplate}"/>

        <local:MainViewModel x:Key="MainViewModel" />
    </Window.Resources>

    <telerik:RadToolBar DataContext="{StaticResource MainViewModel}"
                        VerticalAlignment="Center" 
                        Margin="20 0 20 50"
                        ItemsSource="{Binding Items}"
                        ItemTemplateSelector="{StaticResource TemplateSelector}"/>
{{endregion}}

#### __Figure 1: MVVM ToolBar with custom DataTemplateSelector__
![ToolBar MVVM](images/RadToolBar_MVVM.png)

> In order to see an extended implemenation with custom styles, you can check out our [ToolBarMVVM SDK Example](https://github.com/telerik/xaml-sdk/tree/master/ToolBar/ToolBarMVVM) 

## See Also
* [ToolBar DataBinding]({%slug toolbar-databinding%})