---
title: Fluid Content Control
page_title: Fluid Content Control
description: Fluid Content Control
slug: radtileview-fluid-content-control
tags: fluid,content,control
publish: True
position: 2
---

# Fluid Content Control



This article will make you familear with the __RadFluidContentControl__ and its properties.
            

## 

__RadFluidContentControl__ exposes three content properties - __Content__, __SmallContent__ and __LargeContent__. Only one of these three properties is visible at any given time. The way the visible content is changed is determined by the two available threshold properties - __NormalToLargeThreshold__ and __NormalToSmallThreshold__. The __NormalToSmallThreshold__ is used to determine when the small content will be shown, in the cases when the __NormalContent__ is currently visible and vice versa. Alternatively, the __NormalToLargeThreshold__ property controls when the normal content will be hidden and the __LargeContent__ shown.
                

Consider a case where there are three visual elements that should be shown depending on the available space - __SmallContent__(200px X 200px), __NormalContent__(400px X 400px) and __LargeContent__(600px X 600px).
                

#### __XAML__

{{region radtileview-fluid-content-control_0}}
	<telerik:RadFluidContentControl>
	 <!--Small Content-->
	 <telerik:RadFluidContentControl.SmallContent>
	  <Border Background="LightBlue" Width="200" Height="200">
	   <TextBlock Text="Small Content" />
	  </Border>
	 </telerik:RadFluidContentControl.SmallContent>
	
	 <!--Normal Content-->
	 <telerik:RadFluidContentControl.Content>
	  <Border Background="LightGreen" Width="400" Height="400">
	   <TextBlock Text="Normal Content" />
	  </Border>
	 </telerik:RadFluidContentControl.Content>
	
	 <!--Large Content-->
	 <telerik:RadFluidContentControl.LargeContent>
	  <Border Background="LightYellow" Width="600" Height="600">
	   <TextBlock Text="Large Content" />
	  </Border>
	 </telerik:RadFluidContentControl.LargeContent>
	</telerik:RadFluidContentControl>
	{{endregion}}



Next, suitable values for the corresponding thresholds should be set. What follows is an explanation on why such values have been chosen.

#### __XAML__

{{region radtileview-fluid-content-control_1}}
	<telerik:RadFluidContentControl NormalToSmallThreshold="400 400" NormalToLargeThreshold="600 600">
	
	   <!--Small Content-->
	
	   <!--Normal Content-->
	
	   <!--Large Content-->
	
	</telerik:RadFluidContentControl>
	{{endregion}}



* __NormalToSmallThreshold(400px X 400px)__ - setting it to the size of the normal content means that as soon as enough space__(400px X 400px)__ is available, the normal content will be shown. Alternatively, the control will hide the normal content (and show the small content) as soon as the available size is not enough to properly render the normal content.
                        

* __NormalToLargeThreshold(600px X 600px)__ - setting it to the size of the large content means that as soon as enough space__(600px X 600px)__ is available, the large content will be shown. Alternatively, the control will hide the large content (and show the normal content) as soon as the available size is not enough to properly render the large content.
                        

In case you need to specify only the width or height of a threshold, you can set the other value to 0 - this way it will be disregarded.

If you choose to use __RadFluidContentControl__ with __RadTileView__, an additional property can be taken into consideration - __ContentChangeMode__. __RadFluidContentControl's____ContentChangeMode__ property allows to manually change the __State__ of the control, and thus the visible content. Setting the property to "__Manual__", tells __RadFluidContentControl__ to completely disregard its threshold properties, thus making you responsible for switching the visible content. Setting the property to "__Automatic__" makes the control use the thresholds again.
                

#### __XAML__

{{region radtileview-fluid-content-control_2}}
	<telerik:RadTileView TileStateChanged="RadTileView_TileStateChanged">
	 <telerik:RadTileViewItem Header="BMW">
	  <telerik:RadFluidContentControl ContentChangeMode="Manual">
	   <telerik:RadFluidContentControl.SmallContent>
	    <Grid Width="200" Height="200">
	     <Image Source="Images/BMW/bmw200x200.jpg" />
	    </Grid>
	   </telerik:RadFluidContentControl.SmallContent>
	   <telerik:RadFluidContentControl.Content>
	    <Grid Width="400" Height="400">
	     <Image Source="Images/BMW/bmw400x400.jpg" />
	    </Grid>
	   </telerik:RadFluidContentControl.Content>
	   <telerik:RadFluidContentControl.LargeContent>
	    <Grid Width="600" Height="600">
	     <Image Source="Images/BMW/bmw600x600.jpg" />
	    </Grid>
	   </telerik:RadFluidContentControl.LargeContent>
	  </telerik:RadFluidContentControl>
	 </telerik:RadTileViewItem>
	
	 <telerik:RadTileViewItem Header="Audi">
	  <telerik:RadFluidContentControl ContentChangeMode="Manual">
	   <telerik:RadFluidContentControl.SmallContent>
	    <Grid Width="200" Height="200">
	     <Image Source="Images/Audi/audi200x200.jpg" />
	    </Grid>
	   </telerik:RadFluidContentControl.SmallContent>
	   <telerik:RadFluidContentControl.Content>
	    <Grid Width="400" Height="400">
	     <Image Source="Images/Audi/audi400x400.jpg" />
	    </Grid>
	   </telerik:RadFluidContentControl.Content>
	   <telerik:RadFluidContentControl.LargeContent>
	    <Grid Width="600" Height="600">
	     <Image Source="Images/Audi/audi600x600.jpg" />
	    </Grid>
	   </telerik:RadFluidContentControl.LargeContent>
	  </telerik:RadFluidContentControl>
	 </telerik:RadTileViewItem>
	
	 <telerik:RadTileViewItem Header="Mercedes">
	  <telerik:RadFluidContentControl ContentChangeMode="Manual">
	   <telerik:RadFluidContentControl.SmallContent>
	    <Grid Width="200" Height="200">
	     <Image Source="Images/Mercedes/mercedes200x200.jpg" />
	    </Grid>
	   </telerik:RadFluidContentControl.SmallContent>
	   <telerik:RadFluidContentControl.Content>
	    <Grid Width="400" Height="400">
	     <Image Source="Images/Mercedes/mercedes400x400.jpg" />
	    </Grid>
	   </telerik:RadFluidContentControl.Content>
	   <telerik:RadFluidContentControl.LargeContent>
	    <Grid Width="600" Height="600">
	     <Image Source="Images/Mercedes/mercedes600x600.jpg" />
	    </Grid>
	   </telerik:RadFluidContentControl.LargeContent>
	  </telerik:RadFluidContentControl>
	 </telerik:RadTileViewItem>
	</telerik:RadTileView>
	{{endregion}}



#### __C#__

{{region radtileview-fluid-content-control_3}}
	private void RadTileView_TileStateChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
	{
	 RadTileViewItem item = e.Source as RadTileViewItem;
	 if (item != null)
	 {
	  RadFluidContentControl fluidControl = item.Content as RadFluidContentControl;
	  if (fluidControl != null)
	  {
	   switch (item.TileState)
	   {
	    case TileViewItemState.Maximized:
	     fluidControl.State = FluidContentControlState.Large;
	     break;
	    case TileViewItemState.Minimized:
	     fluidControl.State = FluidContentControlState.Small;
	     break;
	    case TileViewItemState.Restored:
	     fluidControl.State = FluidContentControlState.Normal;
	     break;
	   }
	  }
	 }
	}
	{{endregion}}



#### __VB.NET__

{{region radtileview-fluid-content-control_3}}
		Private Sub RadTileView_TileStateChanged(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
			Dim item As RadTileViewItem = TryCast(e.Source, RadTileViewItem)
			If item IsNot Nothing Then
				Dim fluidControl As RadFluidContentControl = TryCast(item.Content, RadFluidContentControl)
				If fluidControl IsNot Nothing Then
					Select Case item.TileState
						Case TileViewItemState.Maximized
							fluidControl.State = FluidContentControlState.Large
							Exit Select
						Case TileViewItemState.Minimized
							fluidControl.State = FluidContentControlState.Small
							Exit Select
						Case TileViewItemState.Restored
							fluidControl.State = FluidContentControlState.Normal
							Exit Select
					End Select
				End If
			End If
		End Sub
	#End Region
	
	End Class


