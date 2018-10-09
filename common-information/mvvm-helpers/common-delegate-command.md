---
title: Delegate Command
page_title: DelegateCommand
description: DelegateCommand
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

#### **[C#] Example 1: DelegateCommand implementation in your ViewModel that accepts a delegate:**
{{region common-mvvm-delegate-command-implementation-0}}
	 	public ICommand CustomCommand { get; set; }

        public MyViewModel()
        {
            this.CustomCommand = new DelegateCommand(onCustomCommandExecuted);
        }
		
		private void onCustomCommandExecuted(object obj)
        {
            MessageBox.Show("Custom Command Executed!");
        }
{{endregion}}
	

#### **[C#] Example 2: DelegateCommand implementation in your ViewModel that accepts a delegate and a predicate:**
{{region common-mvvm-delegate-command-implementation-1}}
		public bool CanExecuteCommand { get; set; }
        public ICommand CustomCommand { get; set; }

        public MyViewModel()
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
{{endregion}}



## See Also

* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [ViewModelBase]({%slug common-viewmodelbase-class%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
