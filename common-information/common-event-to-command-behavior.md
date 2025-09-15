---
title: EventToCommandBehavior
page_title: EventToCommandBehavior
description: The EventToCommandBehavior class allows you to handle events in an MVVM-friendly manner.
slug: common-event-to-command-behavior
tags: eventtocommandbehavior
published: False
position: 15
---

# EventToCommandBehavior

When working in more advanced development scenarios we often find ourselves leaning towards the MVVM pattern for producing cleaner, loosely coupled, easier to test code, but along with this comes the responsibility of ensuring that all controls we are using can follow this pattern. While it is very easy to work with the event-based model that exists across the .Net framework, events do not play well into the mindset of reducing traditional code-behind and instead handling logic within a viewmodel. This is where the Telerik __EventToCommandBehavior__ comes into use to allow your events to fire and your code to respond accordingly, all in the ViewModel without touching the code-behind of the UserControls.
      
## Getting Started

Let's imagine that you need to use a __RadListBox__ event in the ViewModel in order to execute some custom logic there. If you have the following __RadListBox__:
        
#### __XAML__

```XAML
	<telerik:RadListBox ItemsSource="{Binding ListBoxItems}" />
```

Which DataContext is the ViewModel below:
        
#### __C#__

```C#
	public class ViewModel: ViewModelBase
	{
	    public ObservableCollection<string> ListBoxItems { get; set; }
	
	    public ViewModel()
	    {
	        this.ListBoxItems = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
	    }
	}
```

And you need to handle the MouseEnter event of the ListBox, the __EventToCommandBehavior__ will easily allow you to bind that event to a command in the ViewModel. You would just need to add object of type __EventBinding__ to the __EventToCommandBehavior.EventBindings__ collection. The __EventBinding__ object contains few properties, in this case you will need to use the Command property which should be bound to the desired Command and the Event property which represents the event you want to handle:
       
#### __XAML__

```XAML
	<telerik:RadListBox x:Name="ListBox" ItemsSource="{Binding ListBoxItems}">
	    <telerik:EventToCommandBehavior.EventBindings>
	        <telerik:EventBinding Command="{Binding CustomCommand}" EventName="MouseEnter" />
	    </telerik:EventToCommandBehavior.EventBindings>
	</telerik:RadListBox>
```

The last thing you should do is to define the custom command in the ViewModel as shown below:
        
#### __C#__

```C#
	public ICommand CustomCommand { get; set; }
	    ...
	public ViewModel()
	{
	    ...
	    this.CustomCommand = new DelegateCommand(OnCustomCommandExecuted);
	}
	
	private void OnCustomCommandExecuted(object obj)
	{
	    MessageBox.Show("Command Executed!");
	}
```

And here is the final result:
![Common Event To Command Behavior 1](images/Common_EventToCommandBehavior_1.png)

## RaiseOnHandledEvents

Sometimes it appears that the event you need to handle is already handled in the code of the control. In the previous example the event wasn't handled in the code so there weren't any problems. However if you need to handle the MouseLeftButtonDown for an example you won't be able unless you set the __RaiseOnHandledEvents__ property to True which allows you to raise handled events:
       
#### __XAML__

```XAML
	<telerik:EventToCommandBehavior.EventBindings>
	    <telerik:EventBinding Command="{Binding CustomCommand}" EventName="MouseLeftButtonDown" RaiseOnHandledEvents="True" />
	</telerik:EventToCommandBehavior.EventBindings>
```

The result will be the same command executed when the ListBox is Clicked.

## Command Parameters

When binding to a command you will probably need to pass some data to the method that executes the command. The __EventToCommandBehavior__ provides you with two options in this case - to pass whatever you need with the __CommandParameter__ property or to pass the event arguments of handled event with the __PassEventArgsToCommand__ property set to True.          
        
>Note that if you set both the properties at the same time, the __CommandParameter__ is with higher priority than the __PassEventArgsToCommand__ property.
          

### CommandParameter

With the __CommandParameter__ property you can easily pass an object or bind it to property of another control. Let's upgrade the example above by including a CommandParameter which will pass a simple string to the method in the ViewModel:
                
#### __XAML__

```XAML
	<telerik:EventToCommandBehavior.EventBindings>
	    <telerik:EventBinding Command="{Binding CustomCommand}" EventName="MouseLeftButtonDown" RaiseOnHandledEvents="True"
	                          CommandParameter="This is a command parameter!"/>
	</telerik:EventToCommandBehavior.EventBindings>
```

And the method in the ViewModel should look as follows:
              
#### __C#__

```C#
	private void OnCustomCommandExecuted(object obj)
	{
	    MessageBox.Show(obj.ToString());
	}
```

This will be the result:
![Common Event To Command Behavior 2](images/Common_EventToCommandBehavior_2.png)

### PassEventArgsToCommand

You can also pass the event arguments to the method by setting the __PassEventArgsToCommand__ property to True. This will allow you to get the clicked element in same example and to use it as required.
                  

#### __XAML__

```XAML
	<telerik:EventToCommandBehavior.EventBindings>
	    <telerik:EventBinding Command="{Binding CustomCommand}" EventName="MouseLeftButtonDown" RaiseOnHandledEvents="True"
	                        PassEventArgsToCommand="True" />
	</telerik:EventToCommandBehavior.EventBindings>
```

#### __C#__

```C#
	private void OnCustomCommandExecuted(object obj)
	{
	    var clickedItem = (obj as MouseButtonEventArgs).OriginalSource as TextBlock;
	    if (clickedItem != null)
	    {
	        MessageBox.Show("Clicked Item: " + clickedItem.Text);
	    }
	}
```

Here is the result:
![Common Event To Command Behavior 3](images/Common_EventToCommandBehavior_3.png)

## CommandTarget

The __CommandTarget__ property of the __EventBinding__ specifies the element where the command occurs. If __CommandTarget__ is not set, the element that has keyboard focus will receive the command. For more details about the __CommandTarget__ please check the [CommandTarget Property topic](http://msdn.microsoft.com/en-us/library/system.windows.input.icommandsource.commandtarget%28v=vs.110%29.aspx).
        
## Multiple Commands

The __EventToCommandBehavior__ gives you the ability to add multiple __EventBinidings__. You can easily bind multiple commands to a single event as well as a single command to multiple events. For example we can execute two commands in the ViewModel when the MouseLeftButtonDown event of __RadListBox__ is fired:
        
#### __XAML__

```XAML
	<telerik:EventToCommandBehavior.EventBindings>
	    <telerik:EventBinding Command="{Binding CustomCommand}" EventName="MouseLeftButtonDown" RaiseOnHandledEvents="True" />
	    <telerik:EventBinding Command="{Binding AnotherCommand}" EventName="MouseLeftButtonDown" RaiseOnHandledEvents="True" />
	</telerik:EventToCommandBehavior.EventBindings>
```

>If you have multiple commands attached to a single event, the commands will be executed in the order they are defined in the __EventBindings__ collection (from top to bottom).
