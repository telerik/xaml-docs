---
title: How to Customize or Remove RadPane's Menu
page_title: How to Customize or Remove RadPane's Menu
description: Check our &quot;How to Customize or Remove RadPane's Menu&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-how-to-add-menu-items-to-the-radpanes-menu
tags: how,to,customize,or,remove,the,radpane's,menu
published: True
position: 0
---

# How to Customize or Remove RadPane's Menu

The purpose of this tutorial is to show you how to customize __RadPane's__ menu.
      
>tipFor more information about the __RadPane__ structure, read [here]({%slug raddocking-panes-radpane%}). If you want to learn more about __RadPane's__ menu, read [this one]({%slug raddocking-features-panes-panes-menu%}).

## Customizing RadPane's Menu 

To add custom commands to __RadPane's__ menu, you should perform the following steps:

1. You can create a custom class CustomRadDockingCommands. Inside, you can create a singleton property of type __Telerik.Windows.Controls.RoutedUICommand__. __Example 1__ demonstrates how you can do that.
	
	#### __[C#] Example 1: Create Singleton command property__
	{{region cs-raddocking-how-to-add-menu-items-to-the-radpanes-menu_0}}
		public class CustomRadDockingCommands
		{
			private static RoutedUICommand closeAllPanesButThisCommand;			
			public static RoutedUICommand CloseAllPanesButThisCommand
			{
				get
				{
					if (closeAllPanesButThisCommand == null)
					{
						closeAllPanesButThisCommand = new RoutedUICommand("Close all panes but this!", "CloseAllPanesButThisCommand", typeof(RadDockingCommands));
					}
					return closeAllPanesButThisCommand;
				}
			}			
		}
	{{endregion}}

1. Create a custom __DataTemplate__ by using the Telerik's __RadContextMenu__ and __RadMenuItem__ controls. You can use either the built-in __RadDockingCommands__ or create a custom one - both approaches are demonstrated in this topic. Set the created __DataTemplate__ to __RadPane__'s __ContextMenuTemplate__ property. __Example 2__ show how to set __RadPane__'s __ContextMenuTemplate__ property.
          
	#### __[XAML] Example 2: Custom DataTemplate for the ContextMenuTemplate property__
	{{region xaml-raddocking-how-to-add-menu-items-to-the-radpanes-menu_2}}
		<Window.Resources>
			<DataTemplate x:Key="ContextMenuTemplate">
				<telerik:RadContextMenu InheritDataContext="False">
					<telerik:RadMenuItem 
						IsChecked="{Binding IsFloatingOnly}"
						Command="telerik:RadDockingCommands.Floating" 
						CommandParameter="{Binding}"                
						CommandTarget="{Binding}"
						Header="{Binding Command.Text, RelativeSource={RelativeSource Self}}" />
			
					<telerik:RadMenuItem 
						IsChecked="{Binding IsDockableOptionChecked}" 
						Command="telerik:RadDockingCommands.Dockable" 
						CommandParameter="{Binding}"
						CommandTarget="{Binding}"
						Header="{Binding Command.Text, RelativeSource={RelativeSource Self}}" />
			
					<telerik:RadMenuItem 
						Command="local:CustomRadDockingCommands.CloseAllPanesButThisCommand"
						CommandParameter="{Binding}" 
						CommandTarget="{Binding}"
						Header="{Binding Command.Text, RelativeSource={RelativeSource Self}}" />
				</telerik:RadContextMenu>
			</DataTemplate>
			
			<Style TargetType="telerik:RadPane">
				<Setter Property="ContextMenuTemplate" Value="{StaticResource ContextMenuTemplate}" />
			</Style>
		</Window.Resources>
		<Grid>
			<telerik:RadDocking x:Name="radDocking">
				<telerik:RadSplitContainer>
					<telerik:RadPaneGroup>
						<telerik:RadPane Title="Pane 1" Content="Pane 1 Content" />
						<telerik:RadPane Title="Pane 2" Content="Pane 2 Content" />
						<telerik:RadPane Title="Pane 3" Content="Pane 3 Content" />
						<telerik:RadPane Title="Pane 4" Content="Pane 4 Content" />
					</telerik:RadPaneGroup>
				</telerik:RadSplitContainer>
			</telerik:RadDocking>
		</Grid>
	{{endregion}}

1. You should implement your custom logic in the __OnCloseAllPanesButThis__ and __OnCloseAllPanesButThisCanExecute__ methods. They specify whether the command can be executed and what action is performed, when it is executed. __Example 3__ demonstrates sample logic for the command methods. 
          
	#### __[C#] Example 3: Implement Execute and CanExecute methods__
	{{region cs-raddocking-how-to-add-menu-items-to-the-radpanes-menu_4}}
		public class CustomRadDockingCommands
		{
			private static RoutedUICommand closeAllPanesButThisCommand;
			public static RoutedUICommand CloseAllPanesButThisCommand
			{
				get
				{
					if (closeAllPanesButThisCommand == null)
					{
						closeAllPanesButThisCommand = new RoutedUICommand("Close all panes but this!", "CloseAllPanesButThisCommand", typeof(RadDockingCommands));
					}
					return closeAllPanesButThisCommand;
				}
			}

			public static void OnCloseAllPanesButThis(object sender, ExecutedRoutedEventArgs e)
			{
				RadPane pane = e.Parameter as RadPane;
				if (pane != null)
				{
					RadPaneGroup paneGroup = pane.PaneGroup;
					if (paneGroup != null)
					{
						System.Collections.Generic.IEnumerable<RadPane> panesToClose = paneGroup.EnumeratePanes().Where(x => !x.IsHidden && x.IsPinned);
						foreach (RadPane paneToClose in panesToClose)
						{
							if (paneToClose != pane)
							{
								paneToClose.IsHidden = true;
							}
						}
					}
				}
			}

			public static void OnCloseAllPanesButThisCanExecute(object sender, CanExecuteRoutedEventArgs e)
			{
				e.CanExecute = false;
				RadPaneGroup paneGroup = sender as RadPaneGroup;
				if (paneGroup != null)
				{
					int childrenCount = paneGroup.EnumeratePanes().Count(x => !x.IsHidden && x.IsPinned);

					if (childrenCount > 1)
					{
						e.CanExecute = true;
					}
					else
					{
						e.CanExecute = false;
					}
				}
			}
		}
	{{endregion}}

1. Your menu command is ready and you have a custom __DataTemplate__, which is set to the __ContextMenuTemplate__ property. The next step is to register your custom command by using the __Telerik.Windows.Controls.CommandManager__ class in the __CustomRadDockingCommands__ constructor. __Example 4__ shows the final structure of the __CustomRadDockingCommands__ class.
	
	#### __[C#] Example 4: Register CloseAllPanesButThisCommand custom command__
	{{region cs-raddocking-how-to-add-menu-items-to-the-radpanes-menu_3}}
		public class CustomRadDockingCommands
		{
			private static RoutedUICommand closeAllPanesButThisCommand;

			public static RoutedUICommand CloseAllPanesButThisCommand
			{
				get
				{
					if (closeAllPanesButThisCommand == null)
					{
						closeAllPanesButThisCommand = new RoutedUICommand("Close all panes but this!", "CloseAllPanesButThisCommand", typeof(RadDockingCommands));
					}
					return closeAllPanesButThisCommand;
				}
			}
			static CustomRadDockingCommands()
			{
				CommandManager.RegisterClassCommandBinding(typeof(RadPaneGroup), new CommandBinding(CustomRadDockingCommands.CloseAllPanesButThisCommand, OnCloseAllPanesButThis, OnCloseAllPanesButThisCanExecute));
			}

			public static void OnCloseAllPanesButThis(object sender, ExecutedRoutedEventArgs e)
			{
				RadPane pane = e.Parameter as RadPane;
				if (pane != null)
				{
					RadPaneGroup paneGroup = pane.PaneGroup;
					if (paneGroup != null)
					{
						System.Collections.Generic.IEnumerable<RadPane> panesToClose = paneGroup.EnumeratePanes().Where(x => !x.IsHidden && x.IsPinned);
						foreach (RadPane paneToClose in panesToClose)
						{
							if (paneToClose != pane)
							{
								paneToClose.IsHidden = true;
							}
						}
					}
				}
			}

			public static void OnCloseAllPanesButThisCanExecute(object sender, CanExecuteRoutedEventArgs e)
			{
				e.CanExecute = false;
				RadPaneGroup paneGroup = sender as RadPaneGroup;
				if (paneGroup != null)
				{
					int childrenCount = paneGroup.EnumeratePanes().Count(x => !x.IsHidden && x.IsPinned);

					if (childrenCount > 1)
					{
						e.CanExecute = true;
					}
					else
					{
						e.CanExecute = false;
					}
				}
			}
		}
	{{endregion}}

Run your demo. __RadPane__'s menu should look like the snapshot below.

![{{ site.framework_name }} RadDocking Customize or Remove RadPane's Menu](images/RadDocking_HowTo_Customize_Or_Remove_The_RadPanes_Menu.png)
	
## Removing RadPane's Menu

In order to remove __RadPane__'s Menu, you should set __RadPane__'s __ContextMenuTemplate__ property to __null__ (respectively __{x:Null}__ in XAML).

#### __[XAML] Example 5: Set ContextMenuTemplate property to null__

{{region xaml-raddocking-how-to-add-menu-items-to-the-radpanes-menu_5}}
	<telerik:RadDocking x:Name="radDocking">
	    <telerik:RadDocking.DocumentHost>
	        <telerik:RadSplitContainer>
	            <telerik:RadPaneGroup>
	                <telerik:RadPane x:Name="radPane"
	                            Title="Pane 1"
	                            ContextMenuTemplate="{x:Null}">
	                    <TextBlock Text="Some simple text here" />
	                </telerik:RadPane>
	            </telerik:RadPaneGroup>
	        </telerik:RadSplitContainer>
	    </telerik:RadDocking.DocumentHost>
	</telerik:RadDocking>
{{endregion}}

#### __[C#] Example 6: Set ContextMenuTemplate property to null in code behind__

{{region cs-raddocking-how-to-add-menu-items-to-the-radpanes-menu_6}}
	radPane.ContextMenuTemplate = null;
{{endregion}}

#### __[VB.NET] Example 6: Set ContextMenuTemplate property to null in code behind__

{{region vb-raddocking-how-to-add-menu-items-to-the-radpanes-menu_7}}
	radPane.ContextMenuTemplate = Nothing
{{endregion}}

![{{ site.framework_name }} RadDocking Remove Pane Context Menu](images/RadDocking_HowTo_AddPaneMenuItems_040.png)

## See Also

 * [How to Add Buttons to the Pane Header]({%slug raddocking-how-to-add-buttons-to-the-pane-headers%})
 * [How to Disable the Close Button]({%slug raddocking-how-to-disable-the-close-button%})
