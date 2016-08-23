---
title: Interact with the User before the Page Changes
page_title: Interact with the User before the Page Changes
description: Interact with the User before the Page Changes
slug: raddatapager-how-to-interact-with-with-user-before-page-changes
tags: interact,with,the,user,before,the,page,changes
published: True
position: 2
---

# Interact with the User before the Page Changes

While developing an UI, which contains paging, you might want to ensure that there are no unfinished actions by the user, such as unsubmitted data, data in edit mode and others, on the current page. In this case, it's common to prompt the users if they surely want to continue. If the user refuses to continue, you should prevent the paging from happening. The place, where the prompt should be implemented, is the event handler for the __PageIndexChanging__ event.

__Example 1__ shows a __RadDataPager__ that invokes a __MessageBox__ before changing the page when a condition is met.

#### __[XAML]Example 1: RadDataPager with MessageBox confirmation__
{{region xaml-raddatapager-how-to-interact-with-with-user-before-page-changes_0}}

	<telerik:RadDataPager x:Name="radDataPager"
	                        Grid.Row="1"
	                        PageSize="5"
	                        DisplayMode="All"
	                        IsTotalItemCountFixed="True"
	                        Margin="0,10,0,0" PageIndexChanging="radDataPager_PageIndexChanging" />
{{endregion}}

#### __[C#]Example 1: RadDataPager with MessageBox confirmation__
{{region cs-raddatapager-how-to-interact-with-with-user-before-page-changes_1}}
	        private bool myCondition;
	        private void radDataPager_PageIndexChanging(object sender, PageIndexChangingEventArgs e)
	        {
	            if (myCondition)
	            {
	                MessageBoxResult result = MessageBox.Show("There is unsaved data! Are you sure you want to continue?", "Confirm", MessageBoxButton.OKCancel);
	                if (result == MessageBoxResult.Cancel)
	                {
	                    e.Cancel = true;
	                }
	            }
	        }
{{endregion}}


#### __[VB.NET]Example 1: RadDataPager with MessageBox confirmation__
{{region vb-raddatapager-how-to-interact-with-with-user-before-page-changes_2}}

	Private myCondition As Boolean
	Private Sub radDataPager_PageIndexChanging(sender As Object, e As PageIndexChangingEventArgs)
	 If myCondition Then
	  Dim result As MessageBoxResult = MessageBox.Show("There is unsaved data! Are you sure you want to continue?", "Confirm", MessageBoxButton.OKCancel)
	  If result = MessageBoxResult.Cancel Then
	   e.Cancel = True
	  End If
	 End If
	End Sub
{{endregion}}

#### __Figure 1: RadDataPager with MessageBox confirmation__
![](images/RadDataPager_How_To_Interact_With_The_User_01.png)

# See Also

 * [Events]({%slug raddatapager-events-overview%})

 * [Page RadGridView]({%slug raddatapager-how-to-page-radgridview%})

 * [Paging Essentials]({%slug raddapager-features-paging-essentials%})

 * [Source and Paged Source]({%slug raddatapager-features-source-and-paged-source%})
