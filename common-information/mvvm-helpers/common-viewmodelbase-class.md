---
title: ViewModelBase
page_title: ViewModelBase Class
description: This article provides information about the ViewModelBase class.
slug: common-viewmodelbase-class
tags: ViewModelBase
published: True
position: 5
---

# ViewModelBase class

The `ViewModelBase` abstract class is designed to serve as a base class for all the model classes in your application. It provides support for property change notifications. Instead of implementing the `INotifyPropertyChanged` interface in each individual view model, you can directly inherit `ViewModelBase`. 

#### **[C#] Example 1: Custom ViewModel that inherits the abstract ViewModelBase class**
```C#
    using Telerik.Windows.Controls;
    public class MyViewModel : ViewModelBase
    {
        private object selectedItem;
        public object SelectedItem
        {
            get { return this.selectedItem; }
            set
            {
                if (value != this.selectedItem)
                {
                    this.selectedItem = value;
                    OnPropertyChanged(() => this.SelectedItem);
                }
            }
        }

        private ObservableCollection<Club> clubsCollection;
        public ObservableCollection<Club> ClubsCollection
        {
            get
            {
                return this.clubsCollection;
            }
            set
            {
                this.clubsCollection = value;
                this.OnPropertyChanged("ClubsCollection");
            }
        }
    }
```

As shown in the previous example the `OnPropertyChanged` method gives a couple of overloads that can be used.

The `ViewModelBase` class supports an additional approach for notifying the property change, via the the [CallerMemberName](https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute(v=vs.110).aspx) attribute which is implemented in the `RaisePropertyChanged` method.

#### **[C#] Example 2: Using the CallerMemberName attribute**:
```C#
        public object SelectedItem
        {
            get { return this.selectedItem; }
            set
            {
                if (value != this.selectedItem)
                {
                    this.selectedItem = value;
                    RaisePropertyChanged();
                }
            }
        }
```

## See Also
* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
* [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%})
