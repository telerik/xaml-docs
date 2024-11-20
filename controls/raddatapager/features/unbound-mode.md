---
title: Unbound Mode
page_title: Unbound Mode
description: Check our &quot;Unbound Mode&quot; documentation article for the RadDataPager {{ site.framework_name }} control.
slug: raddatapager-features-unbound-mode
tags: unbound,mode
published: True
position: 7
---

# Unbound Mode

There are scenarios, in which you might want to use the __RadDataPager__ only for its UI without passing any data to it. This scenarios will require you to use the RadDataPager's __Unbound Mode__ feature. The use of this feature consists in setting some of the __RadDataPager's__ properties manually and handling a few events.

The example in this topic will show you a __ListBox__ bound to a list of integers. A __RadDataPager__ will be used as UI to page the data, but the paging itself will be done outside of the __RadDataPager__ via __LINQ__ extension methods.

Here is the XAML for the example. In it you can see a __ListBox__ and a __RadDataPager__ with its __PageSize__ property set. The other important thing is the event handler attached to the __PageIndexChanged__ event.

#### __XAML__
{{region raddatapager-features-unbound-mode_0}}

	<Grid x:Name="LayoutRoot"
	        Background="White">
	    <Grid.RowDefinitions>
	        <RowDefinition />
	        <RowDefinition Height="Auto" />
	    </Grid.RowDefinitions>
	    <ListBox x:Name="listBox" />
	    <telerik:RadDataPager x:Name="radDataPager"
	                            Grid.Row="1"
	                            PageSize="10"
	                            Margin="0,10,0,0"
	                            PageIndexChanged="radDataPager_PageIndexChanged" />
	</Grid>
{{endregion}}


Now take a look at the code-behind. There is a simple list of integers, which will serve as a dummy data. The keypoints here are to set the __ItemCount__ property of the __DataPager__ to the count of your data. In this way the UI will display correct information to the user. The next point is to set the __ItemsSource__ of the __ListBox__ to an appropriate value and the last one is to implement the custom paging logic inside the handler for the __PageIndexChanged__ event.

>tip If you want to implement some logic before the __PageIndex__ gets changed, you can attach an event handler to the __PageIndexChanging__ event.

#### __C#__
{{region raddatapager-features-unbound-mode_1}}

	public partial class UnboundModeSample : UserControl
	{
	    private List<int> data;
	    public UnboundModeSample()
	    {
	        InitializeComponent();
	        this.data = Enumerable.Range( 0, 100 ).ToList();
	        this.radDataPager.ItemCount = data.Count;
	        this.listBox.ItemsSource = this.data.Take( this.radDataPager.PageSize ).ToList();
	    }
	    private void radDataPager_PageIndexChanged( object sender, PageIndexChangedEventArgs e )
	    {
	        if ( this.data != null )
	        {
	            this.listBox.ItemsSource = this.data.Skip( e.NewPageIndex * this.radDataPager.PageSize ).Take( this.radDataPager.PageSize ).ToList();
	        }
	    }
	}
{{endregion}}


#### __VB.NET__
{{region raddatapager-features-unbound-mode_2}}

	Public Partial Class UnboundModeSample
	 Inherits UserControl
	 Implements IView
	 Private data As List(Of Integer)
	 Public Sub New()
	  InitializeComponent()
	  Me.data = Enumerable.Range(0, 100).ToList()
	  Me.radDataPager.ItemCount = data.Count
	  Me.listBox.ItemsSource = Me.data.Take(Me.radDataPager.PageSize).ToList()
	 End Sub
	 Private Sub radDataPager_PageIndexChanged(sender As Object, e As PageIndexChangedEventArgs)
	  If Me.data IsNot Nothing Then
	   Me.listBox.ItemsSource = Me.data.Skip(e.NewPageIndex * Me.radDataPager.PageSize).Take(Me.radDataPager.PageSize).ToList()
	  End If
	 End Sub
	End Class
{{endregion}}

## See Also  
 * [Source and Paged Source]({%slug raddatapager-features-source-and-paged-source%})
 * [Display Modes]({%slug raddatapager-features-display-modes%})
