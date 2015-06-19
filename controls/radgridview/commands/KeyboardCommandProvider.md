---
title: Keyboard Command Provider
page_title: Keyboard Command Provider
description: Keyboard Command Provider
slug: gridview-commands-keyboardcommandprovider
tags: keyboard,command,provider
published: True
position: 2
---

# Keyboard Command Provider


__RadGridView__ provides a set of keyboard navigation scenarios that will result in certain consequence of commands to be executed. However, in case you require them not to be invoked at all or to utilize different commands, you may take advantage of the __IKeyboardCommandProvider__ Interface and implement your custom logic. 
Thus, you will be able to change the behavior of all keys. The hurdle here is the requirement for predefining each one of the commands. 
        

Another approach for accomplishing the purpose will be to create a separate class, inheriting the __DefaultKeyboardCommandProvider__ and overriding the __ProvideCommandsForKey (Key key)__ method. In this way only the undesired behavior can be adjusted according to your requirements.
        

The custom class responsible for the update of the commands needs to be similar to the one below:
        

#### __C#__

{{region GridView-Commands-KeyboardCommandProvider_0}}

	class CustomKeyboardCommandProvider : DefaultKeyboardCommandProvider
	 {
	  private GridViewDataControl parentGrid;
	  private DefaultKeyboardCommandProvider defaultKeyboardProvider;
	  private CustomKeyboardCommandProvider customKeyboardProvider;
	  public CustomKeyboardCommandProvider(GridViewDataControl grid)
	   : base(grid)
	  {
	   this.parentGrid = grid;
	  }
	  public override IEnumerable<ICommand> ProvideCommandsForKey(Key key)
	  {
	   List<ICommand> commandsToExecute = base.ProvideCommandsForKey(key).ToList();
	  
	    if (key == Key.Enter)
	       {
	          commandsToExecute.Clear();
	          commandsToExecute.Add(RadGridViewCommands.CommitEdit);
	          commandsToExecute.Add(RadGridViewCommands.MoveNext);
	          commandsToExecute.Add(RadGridViewCommands.BeginEdit);
	       }
	
	   return commandsToExecute;
	
	  }
	 }
{{endregion}}

#### __VB.NET__

{{region GridView-Commands-KeyboardCommandProvider_1}}

	Class CustomKeyboardCommandProvider
	 Inherits DefaultKeyboardCommandProvider
	 Private parentGrid As GridViewDataControl
	 Private defaultKeyboardProvider As DefaultKeyboardCommandProvider
	 Private customKeyboardProvider As CustomKeyboardCommandProvider
	 Public Sub New(grid As GridViewDataControl)
	  MyBase.New(grid)
	  Me.parentGrid = grid
	 End Sub
	 Public Overrides Function ProvideCommandsForKey(key__1 As Key) As IEnumerable(Of ICommand)
	  Dim commandsToExecute As List(Of ICommand) = MyBase.ProvideCommandsForKey(key__1).ToList()
	   If key = Key.Enter Then
		commandsToExecute.Clear()
		commandsToExecute.Add(RadGridViewCommands.CommitEdit)
		commandsToExecute.Add(RadGridViewCommands.MoveNext)
		commandsToExecute.Add(RadGridViewCommands.BeginEdit)
	   End If
	  Return commandsToExecute
	 End Function
	End Class
{{endregion}}


Following up the code-snippet above, a press of Enter key will result in saving the current changes,
moving the focus to the right cell and editing it. However, do not forget to remove the predefined
commands for that particular key by calling the __Clear()__ method.
        

The last thing to be done is to set __KeyboardCommandProvider__ Property of the __RadGridView__ to be the newly-created __CustomKeyboardCommandProvider__ class:
        

#### __C#__

{{region GridView-Commands-KeyboardCommandProvider_2}}

	this.RadGridView1.KeyboardCommandProvider = new CustomKeyboardCommandProvider(this.RadGridView1);
{{endregion}}



#### __VB.NET__

{{region GridView-Commands-KeyboardCommandProvider_3}}

	Me.RadGridView1.KeyboardCommandProvider = New CustomKeyboardCommandProvider(Me.RadGridView1)
{{endregion}}


>tipYou can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk/), the example is listed as __GridView__ / __CustomKeyboardCommandProvider__.
          
>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. 

>tipFor some additional details you can also check [this blog post](http://blogs.telerik.com/xamlteam/posts/10-06-30/how---to-change-the-default-keyboard-behavior-in-radgridview-for-silverlight-wpf.aspx)
