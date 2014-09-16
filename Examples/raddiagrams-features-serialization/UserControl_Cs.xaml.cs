#region raddiagrams_features_serialization_0
private string diagramXMLString;       

public MainWindow()
{
	StyleManager.ApplicationTheme = new Windows8Theme();
	InitializeComponent();          
}

private void CommandBinding_Executed_Save(object sender, ExecutedRoutedEventArgs e)
{
   diagramXMLString =  this.diagram.Save();
}

private void CommandBinding_Executed_Open(object sender, ExecutedRoutedEventArgs e)
{
	if (diagramXMLString != null)
	{
		this.diagram.Load(diagramXMLString);
	}
}

private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
{
	e.CanExecute = this.diagram.Items.Count > 0;
}
#endregion
