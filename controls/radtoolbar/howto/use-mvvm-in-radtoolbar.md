---
title: Use MVVM in RadToolbar
page_title: Use MVVM in RadToolbar
description: Check our &quot;Use MVVM in RadToolbar&quot; documentation article for the RadToolBar {{ site.framework_name }} control.
slug: use-mvvm-in-radtoolbar
tags: mvvm,support
published: True
position: 5
---

# Use MVVM in RadToolbar

This example shows how to use the __RadToolBar__ control with the Model-View-ViewModel (MVVM) pattern and a custom **DataTemplateSelector**.

### 1. __Implement the custom DataTemplateSelector__

Because RadToolBar may contain a variety of other controls as its items, we will use a custom DataTemplateSelector to help us determine the template for each item inside its ItemsSource.

__Example 1: The custom DataTemplateSelector__

```C#
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
```
```VB.NET
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
```

__Example 2: Assign the ItemTemplateSelector property__

```XAML
    <Window.Resources>
        <local:ToolBarItemTemplateSelector 	x:Key="TemplateSelector"
                                            TextBlockTemplate="{StaticResource TextBlockTemplate}"
                                            ColorPickerTemplate="{StaticResource RadColorPickerTemplate}"/>
    </Window.Resources>

    <telerik:RadToolBar ItemTemplateSelector="{StaticResource TemplateSelector}" />
```

### 2. __Create ViewModels__

We will create two view models for this example: **ColorPickerViewModel** and **TextBlockViewModel**. The ColorPickerViewModel will contain a collection of colors and the TextBlockViewModel will contain a single text property.

__Example 3: Define ColorPickerViewModel and TextViewModel__

```C#
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
```
```VB.NET
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
```

### 3. __Define the DataTemplates for the DataTemplateSelector__           

> In order to use the RadColorPicker control, you have to add a reference to the following assembly: __Telerik.Windows.Controls.Input__

#### __[XAML] Example 4: Defining the templates for the ViewModels:

```XAML
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
```

### 4. __Create the MainViewModel__

Let's now create the MainViewModel which will contain a collection of our ViewModels.

__Example 5: Create the MainViewModel__

```C#
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
```
```VB.NET
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
```

### 5.  __Set the DataContext and ItemsSource of the RadToolBar__

Finally we need to instantiate our ViewModel and assign it as the DataContext of the ToolBar. You should then bind the **ItemsSource** property to the **Items** property in our ViewModel. Let's also set the **VerticalAlignment** to **Center** and add some margins for better visualization.

__Example 6: Set the DataContext and ItemsSource of the RadToolBar__

```XAML
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
```

#### __Figure 1: MVVM ToolBar with custom DataTemplateSelector__
![ToolBar MVVM](images/RadToolBar_MVVM.png)

> For an extended implementation with custom styles, check out the [ToolBarMVVM](https://github.com/telerik/xaml-sdk/tree/master/ToolBar/ToolBarMVVM) demo from our [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser/).

## See Also
* [ToolBar DataBinding]({%slug toolbar-databinding%})