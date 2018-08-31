---
title: ViewModelBase
page_title: ViewModelBase Class
description: ViewModelBase
slug: common-viewmodelbase-class
tags: ViewModelBase
published: True
position: 5
---

# ViewModelBase class

The **ViewModelBase** abstract class is designed to serve as a base class for all **ViewModel** classes. It provides support for property change notifications. Instead of implementing the **INotifyPropertyChanged** interface in each individual **ViewModel** of your application, you can directly inherit the **ViewModelBase** class. 

#### **[C#] Example 1: Custom ViewModel that inherits the abstract ViewModelBase class**
{{region common-viewmodelbase-class-0}}
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

		. . .
    }
{{endregion}}

As shown in **Example 1**, when explicitly specifying the changed property, there are a couple of overloads that you can use. If you are using the .NET 4.5 controls version, an additional approach is available which uses the [CallerMemberName](https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute(v=vs.110).aspx) attribute to notify for property changed events:

#### **[C#] Example 2: Using the CallerMemberName attribute**:
{{region common-viewmodelbase-class-1}}
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
{{endregion}}


## See Also

* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
* [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%})
