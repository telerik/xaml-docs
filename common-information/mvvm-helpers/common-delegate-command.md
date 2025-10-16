---
title: Delegate Command
page_title: DelegateCommand
description: This article describes the DelegateCommand class, which provides a simple ICommand implementation.
slug: common-mvvm-delegate-command-implementation
tags: delegate,command
published: True
position: 3
---

# DelegateCommand

The **DelegateCommand** class provides a simple **ICommand** implementation. It is located in the **Telerik.Windows.Controls** namespace and exposes the following methods and events:

* **CanExecute:** Defines the method that determines whether the command can execute in its current state.
* **Execute:** Defines the method to be called when the command is invoked.
* **InvalidateCanExecute:** Raises the CanExecuteChanged event.
* **CanExecuteChanged:** Raised when changes occur that affect whether the command should execute.

The **DelegateCommand** constructor has two overloads. The first accepts just a Delegate to execute as a parameter. The second one accepts the **Delegate** to execute as well as a **Predicate** that allows/bans the execution.  

#### **[C#] Example 1: DelegateCommand implementation in your ViewModel that accepts a delegate and a predicate**
```C#
	
    public class ViewModel
    {
        public bool CanExecuteCommand
        {
            get
            {
                return true;
            }
        }
        public ICommand CustomCommand { get; set; }

        public ViewModel()
        {
            this.CustomCommand = new DelegateCommand(onCustomCommandExecuted, canBeExecuted);
        }

        private bool canBeExecuted(object obj)
        {
            return this.CanExecuteCommand;
        }

        private void onCustomCommandExecuted(object obj)
        {
            MessageBox.Show("Custom Command Executed!");
        }
    }
```
	

#### **[XAML] Example 2: Using the command in xaml**
```XAML
		
    <Grid>
        <Grid.DataContext>
            <my:ViewModel />
        </Grid.DataContext>

        <Button Command="{Binding CustomCommand}" Content="Execute command" VerticalAlignment="Bottom" />
    </Grid>
```

## See Also

* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [ViewModelBase]({%slug common-viewmodelbase-class%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
