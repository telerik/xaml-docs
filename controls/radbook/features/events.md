---
title: Events
page_title: Events
description: Events
slug: radbook-events
tags: events
published: True
position: 2
---

# Events



## 

__RadBook__ exposes the following events:

* __FoldActivated__ - raised when the user hovers the fold
    with the mouse.

* __FoldDeactivated__ - raised when the fold is not active -
    e.g. the user is not over it.

* __PageChanged__ - raised when the page set is
    changed.

* __PageFlipStarted__ - raised when user starts to flip a
    page.

* __PreviewPageFlipStarted__ - raised when user starts to
    flip a page. Allows the developer to cancel the page flip.

* __PageFlipEnded__ - raised when the flip is finished. This
    happen when the page is changed, or user canceled the flip.



Please find below and example of how to use those events:

#### __XAML__

{{region radbook-events_0}}
	<Grid x:Name="LayoutRoot" Background="Purple">
	    <telerik:RadBook x:Name="RadBook1" 
	                        Margin="50"
	                        FoldActivated="RadBook_FoldActivated"
	                        FoldDeactivated="RadBook1_FoldDeactivated"
	                        FoldSize="150,150"
	                        PageChanged="RadBook1_PageChanged"
	                        PageFlipEnded="RadBook1_PageFlipEnded"
	                        PageFlipStarted="RadBook1_PageFlipStarted"
	                        PreviewPageFlipStarted="RadBook1_PreviewPageFlipStarted">
	        <telerik:RadBookItem Background="Red">
	            <StackPanel>
	                <TextBlock FontSize="36" Text="Page 1" />
	                <Button Content="Click Me" />
	            </StackPanel>
	        </telerik:RadBookItem>
	        <telerik:RadBookItem Background="BlueViolet">
	            <StackPanel>
	                <TextBlock HorizontalAlignment="Right" 
	                            FontSize="36"
	                            Text="Page 2" />
	                <Image Width="320" 
	                        Height="240"
	                        Source="Koala.jpg" />
	            </StackPanel>
	        </telerik:RadBookItem>
	        <telerik:RadBookItem Background="RosyBrown">
	            <TextBlock FontSize="36" Text="Page 3" />
	        </telerik:RadBookItem>
	        <telerik:RadBookItem Background="Chocolate">
	            <TextBlock HorizontalAlignment="Right" 
	                        FontSize="36"
	                        Text="Page 4" />
	        </telerik:RadBookItem>
	    </telerik:RadBook>
	</Grid>
{{endregion}}



#### __C#__

{{region radbook-events_1}}
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void RadBook_FoldActivated(object sender, Telerik.Windows.Controls.FoldEventArgs e)
		{
			FoldPosition position = e.Position;
		}
		private void RadBook1_FoldDeactivated(object sender, Telerik.Windows.Controls.FoldEventArgs e)
		{

		}
		private void RadBook1_PageChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
		{
			int currentPage = RadBook1.RightPageIndex;
		}
		private void RadBook1_PageFlipEnded(object sender, Telerik.Windows.Controls.PageFlipEventArgs e)
		{
			RadBookItem flippedPage = e.Page;
		}
		private void RadBook1_PageFlipStarted(object sender, Telerik.Windows.Controls.PageFlipEventArgs e)
		{
			RadBookItem flippedPage = e.Page;
		}
		private void RadBook1_PreviewPageFlipStarted(object sender, Telerik.Windows.Controls.PageFlipEventArgs e)
		{
			RadBookItem flippedPage = e.Page;
			e.Handled = true; //if the page flip should stop
		}
	}
{{endregion}}



#### __VB.NET__

{{region radbook-events_1}}
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub RadBook_FoldActivated(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.FoldEventArgs)
			Dim position As FoldPosition = e.Position
		End Sub
		Private Sub RadBook1_FoldDeactivated(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.FoldEventArgs)

		End Sub
		Private Sub RadBook1_PageChanged(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
			Dim currentPage As Integer = RadBook1.RightPageIndex
		End Sub
		Private Sub RadBook1_PageFlipEnded(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.PageFlipEventArgs)
			Dim flippedPage As RadBookItem = e.Page
		End Sub
		Private Sub RadBook1_PageFlipStarted(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.PageFlipEventArgs)
			Dim flippedPage As RadBookItem = e.Page
		End Sub
		Private Sub RadBook1_PreviewPageFlipStarted(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.PageFlipEventArgs)
			Dim flippedPage As RadBookItem = e.Page
			e.Handled = True 'if the page flip should stop'
		End Sub
	End Class
{{endregion}}