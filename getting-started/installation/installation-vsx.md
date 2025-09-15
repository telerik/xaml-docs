---
title: Installing UI for WPF (Using VSX)
page_title: Installing UI for WPF with Visual Studio Extension
description: This article explains how to get the Telerik UI for WPF controls in your project and start using them quickly.
slug: getting-started-first-steps
tags: get,started,first,steps
published: True
position: 6
---

# Installing UI for WPF Using Visual Studio Extensions

This article explains how to get the Telerik UI for WPF controls in your project and start using them quickly. The topic shows what is the lifecycle when using the Telerik Visual Studio Extension.

> Note that the recommended installation approach is to use the [Telerik NuGet packages]({%slug nuget-installation%})

## Downloading the Extension

To download the Telerik Visual Studio Extenion, you can either download the `.msi` installer from the Telerik UI for WPF [download page](https://www.telerik.com/account/product-download?product=RCWPF) or use the __Extensions__ menu of Visual Studio to download the extension from the marketplace (*"Progress Telerik UI for WPF Extension"*).

__Download automated (.msi) installer__  

![Download automated installer Telerik_UI_for_WPF_<version>_Dev.msi](images/download-msi.png)

If you are not a customer, you can [download a free, fully functional trial](https://www.telerik.com/try/ui-for-wpf) and the same options will apply to you as well.

The following article can help you choose the installation type that is most suitable for your needs and preferences: [Installation Approaches]({%slug installation-installing-which-file-do-i-need%}).

## Creating Application with Telerik Visual Studio Extensions

The easiest way to create a Telerik UI for WPF project is to use **Visual Studio Extensions** which are distributed with the Telerik UI for WPF installer.

The Visual Studio Extensions can be accessed through the Extensions | Telerik | Telerik UI for WPF menu which has different menu items depending on the selected project in Visual Studio. The extensions can be accessed through the context menu of a WPF Application as well.

1. Open [Microsoft Visual Studio]({%slug installation-system-requirements-wpf%}).

2. Create new Telerik WPF application.

	__Go to Telerik > Telerik  UI for WPF > Create New Telerik Project__  
	
	![Run Create Project Wizard](../../integration/visual-studio-extensions/images/VSExtentions_WPF_OverviewMenuCreate.png)
	
	__Creating new Telerik application__  
	
	![Creating new Telerik application](images/installation-adding-to-application-create-application-and-adding-control-1.png)

3. Choose the project template and the corresponding settings. For an empty project without any Telerik controls added to the view, choose the Blank option.
	
	__Choosing an application template__  
	
	![Choosing an application template](images/installation-adding-to-application-create-application-and-adding-control-2.png)

	At this point the project references only the common `Telerik.Windows.Controls.dll` and `Telerik.Licensing.Runtime.dll`, and you can start adding controls in the UI. 

4. In case you haven't installed a [license key]({%slug installing-license-key%}) already, you can download one using the License Validation screen.
	
	__License validation screen (license not found)__  
	
	![License validation screen](images/installation-adding-to-application-create-application-and-adding-control-license-validation.png)
	
	__License validation screen (successfully downloaded a license)__
	
	![License validation screen - successfull download](images/installation-adding-to-application-create-application-and-adding-control-successfull-download.png)

	If you have a license key already installed the License Validation screen will be skipped.

You can further configure the project using the Project Configuration Wizard. You can do that by going to the __Extensions > Telerik > Telerik UI for WPF > Configure Project__ menu in Visual Studio. When you open the wizard you can select the controls you are going to use from the list (or search them in the search box). Once you have selected them, click Finish. This will add the required dlls and references to your project.

__Adding references to the charting controls__  
	
![Common Installing Creating Application 013 WPF](images/installation-adding-to-application-create-application-and-adding-control-3.png)	

This step is optional and you will only need it if you use controls that are not defined in `Telerik.Windows.Controls.dll`.

## Add a Telerik Control to the Project

For this example we will use [RadGridView]({%slug gridview-overview2%}).

### Assembly References

In order to use the __RadGridView__ control in your projects, you have to add references to the following assemblies:			

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.GridView__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Data__

### Adding a Telerik Control to the Project

You can add __RadGridView__ manually by writing the XAML code in __Example 1__ or you can also add the control by dragging it from the Visual Studio Toolbox and dropping it over the XAML view.
	
__Adding RadGridView in XAML__
```XAML
	<telerik:RadGridView />
```

If you run the application, you will see an empty grid with no columns and rows as demonstrated below. 

__An empty grid__  

![Telerik {{ site.framework_name }} DataGrid GettingStarted 2](../images/RadGridView_GettingStarted_2.png)

### Populating with Data

In order to populate the __RadGridView__ control with data, you should create a collection of business objects. Create a new class named __Profile__ and add several different type properties to it, as shown in __Example 2__.

__Simple business class__  
```C#
	    public class Profile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool IsChecked { get; set; }
    }
```
```VB.NET
	Public Class Profile
    Public Property ID As Integer
    Public Property Name As String
    Public Property Date As DateTime
    Public Property IsChecked As Boolean
End Class
```

Next, create a collection of Profile objects in the MainWindow and set the RadGridView ItemSource.  

__Simple business class__
```C#
		public MainWindow()
    {
		this.InitializeComponent();
        var source = new ObservableCollection<Profile>();
        DateTime date = DateTime.Now;
        for (int i = 0; i < 10; i++)
        {
        source.Add(new Profile() { ID = i, Name = "Item" + i, Date = date, IsChecked = i % 2 == 0 });
        date = date.AddDays(7);
        }
        gridView.ItemsSource = source;
    }
```
```VB.NET
	Public Sub New()
    Me.InitializeComponent()
    Dim source = New ObservableCollection(Of Profile)()
    Dim date As DateTime = DateTime.Now

    For i As Integer = 0 To 10 - 1
        source.Add(New Profile() With {
            .ID = i,
            .Name = "Item" & i,
            .Date = date,
            .IsChecked = i Mod 2 = 0
        })
        date = date.AddDays(7)
    Next

    gridView.ItemsSource = source
	End Sub
	End Class
```

Now that you have prepared the needed sample data, you need to bind it to each column in XAML as shown in the Example 4 below.

__Define RadGridView in XAML__
```XAML
	<Grid>
        <telerik:RadGridView x:Name="gridView"
                             AutoGenerateColumns="False">
            <telerik:RadGridView.Columns>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding ID}"/>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Date}" />
                <telerik:GridViewDataColumn DataMemberBinding="{Binding IsChecked}" />
            </telerik:RadGridView.Columns>
        </telerik:RadGridView>
    </Grid>
```

Run the project and you should see something like this:

![Main window with RadGridView](images/main-window-with-radgridview.png "Main window with RadGridView")

## Next Steps

Now that you have the Telerik UI for WPF controls running in your project, you may want to explore their features, customize their behavior or change their appearance. Below you can find guidance on getting started with such tasks:

* [Explore control features]({%slug getting-started-explore-control-features%})
* [Change control appearance]({%slug getting-started-change-control-appearance%})
* [Further information]({%slug getting-started-next-steps%})

## See Also  
* [System Requirements]({%slug installation-system-requirements-wpf%})
* [Download Product Files]({%slug download-product-files-wpf%})
* [Add Telerik Namespace]({%slug installation-adding-application-namespace-declaration%})
