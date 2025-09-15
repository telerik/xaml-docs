---
title: Perform Time-Consuming Operation while Showing Busy Indicator
description: Display a busy indicator while executing a heavy operation.
type: how-to
page_title: Show a Busy Indicator while a Heavy Operation is Executed
slug: kb-busyindicator-backgroundworker-operation
position: 0
tags: busyindicator, perform, execute, heavy, time-consuming, operation, UI, thread
ticketid: 1117434
res_type: kb
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.3.917</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadBusyIndicator for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to display a busy indicator while executing a heavy operation.

## Solution

To perform the heavy operation without blocking the UI thread, you can create a **BackgroundWorker** and utilize its **DoWork** and **RunWorkerCompleted** events.

__Example 1: Using the BackgroundWorker in the viewmodel__
```C#
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<string> items;
        private BackgroundWorker BackgroundWorker = new BackgroundWorker();
        private bool isBusy;

        public MainViewModel()
        {
            this.DoWorkCommand = new DelegateCommand(this.OnDoWorkExecuted);

            this.BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            this.BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            this.BackgroundWorker.RunWorkerAsync();
        }

        public ICommand DoWorkCommand { get; private set; }

        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }

            set
            {
                if (this.isBusy != value)
                {
                    this.isBusy = value;
                    this.OnPropertyChanged(() => this.IsBusy);
                }
            }
        }

        public ObservableCollection<string> Items
        {
            get
            {
                return this.items;
            }

            set
            {
                if (this.items != value)
                {
                    this.items = value;
                    this.OnPropertyChanged(() => this.Items);
                }
            }
        }

        private ObservableCollection<string> GetData()
        {
            return new ObservableCollection<string>()
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
        }

        private void OnDoWorkExecuted(object parameter)
        {
            this.BackgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.IsBusy = false;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.IsBusy = true;
            Thread.Sleep(3000);
            this.Items = GetData();
        }
    }
```

In the **BackgroundWorker_DoWork** method we put the thread to sleep for 3 seconds in order to simulate the time-consuming operation but in a real scenario you can make a database call or some heavy computation here.

You can then bind your view to this viewmodel as demonstrated in **Example 2**.

__Example 2: Defining and binding the RadBusyIndicator__
```XAML
    <Grid>
        <Grid.DataContext>
            <local:MainViewModel />
        </Grid.DataContext>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>

        <telerik:RadBusyIndicator IsBusy="{Binding IsBusy}">
            <telerik:RadListBox ItemsSource="{Binding Items}" />
        </telerik:RadBusyIndicator>

        <Button Content="Do Work" Command="{Binding DoWorkCommand}" Grid.Row="1" />
    </Grid>
```

## See Also

* [RadBusyIndicator]({%slug radbusyindicator-getting-started%})
* [Integrate with services and a RadWindow]({%slug radbusyindicator-how-to-integrate-with-services-and-radwindow%})