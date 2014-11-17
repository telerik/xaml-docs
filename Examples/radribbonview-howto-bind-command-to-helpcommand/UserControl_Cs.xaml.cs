using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;


namespace WpfApplication1
{
#region radribbonview-howto-bind-command-to-helpcommand-01
    public DelegateCommand OpenHelpPageCommand { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        OpenHelpPageCommand = new DelegateCommand(ExecuteCommandHandler, CanExecuteCommandHandler);
        this.DataContext = OpenHelpPageCommand;
    }
#endregion

#region radribbonview-howto-bind-command-to-helpcommand-02
private bool CanExecuteCommandHandler(object obj)
{
    // Implement logic that checks if the button command can be executed
    return true;
}

private void ExecuteCommandHandler(object obj)
{
    // Implement the logic that should be executed when the button is clicked
    MessageBox.Show("Help Command Executed");
}
#endregion

#region radribbonview-howto-bind-command-to-helpcommand-03
public DelegateCommand OpenHelpPageCommand { get; set; }
public MainPage()
        {
            InitializeComponent(); 
            
            OpenHelpPageCommand = new DelegateCommand(ExecuteOpenHelpPage);
            this.DataContext = OpenHelpPageCommand;
            InputBindingCollection inputBindCollection = new InputBindingCollection();
            inputBindCollection.Add(new KeyBinding(this.OpenHelpPageCommand, new KeyGesture(Key.F1)));
            CommandManager.SetInputBindings(this, inputBindCollection);
        }
#endregion
}