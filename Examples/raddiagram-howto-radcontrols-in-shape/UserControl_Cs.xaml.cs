#region raddiagram-howto-radcontrols-in-shape-0
public class ProductSales
{
    public ProductSales(int quantity, int month, string monthName)
    {
        this.Quantity = quantity;
        this.Month = month;
        this.MonthName = monthName;
    }

    public int Quantity { get; set; }
    public int Month { get; set; }
    public string MonthName { get; set; }
}
#endregion
#region raddiagram-howto-radcontrols-in-shape-1
private static List<ProductSales> GetProductSales()
{
    var persons = new List<ProductSales>
	{
		new ProductSales(154, 1, "January"), 
        new ProductSales(138, 2, "February"), 
        new ProductSales(143, 3, "March"), 
        new ProductSales(120, 4, "April"), 
        new ProductSales(135, 5, "May"), 
        new ProductSales(125, 6, "June"), 
        new ProductSales(179, 7, "July"), 
        new ProductSales(170, 8, "August"), 
        new ProductSales(198, 9, "September"), 
        new ProductSales(187, 10, "October"), 
        new ProductSales(193, 11, "November"), 
        new ProductSales(212, 12, "December")
	};
    return persons;
}
public Example()
{
    InitializeComponent();
    this.DataContext = GetProductSales();
}
#endregion
#region raddiagram-howto-radcontrols-in-shape-2
public Example()
{
    InitializeComponent();
    this.DataContext = GetProductSales();
    this.Loaded += this.OnLoaded;
}

private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
{
    // the alternative to this code approach is to set the ContentTemplate in XAML
    // See the documentation on this - http://www.telerik.com/help/wpf/raddiagrams-features-shapes.html
    var calendar = new RadDiagramShape()
    {
        Position = new Point(20, 150),
        Content = new RadCalendar { SelectedDate = DateTime.Now.AddDays(254), Margin = new Thickness(10) },
        Background = new SolidColorBrush(Colors.Blue),
        BorderBrush = new SolidColorBrush(Colors.DarkGray),
        BorderThickness = new Thickness(1),
        UseGlidingConnector = true,
        HorizontalContentAlignment = HorizontalAlignment.Stretch,
        VerticalContentAlignment = VerticalAlignment.Stretch
    };
    this.diagram.AddShape(calendar);
}
#endregion
#region raddiagram-howto-radcontrols-in-shape-3
private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
{
    // the alternative to this code-approach is to set the ContentTemplate in XAML
    // See the documentation on this, http://www.telerik.com/help/wpf/raddiagrams-features-shapes.html
    var calendar = new RadDiagramShape()
    {
        //...
    };
    this.diagram.AddShape(calendar);

    var con = this.diagram.AddConnection(this.diagram.Shapes[1], this.diagram.Shapes[0]) as RadDiagramConnection;
    con.Content = "Corresponds to";
    con.SourceCapType = CapType.Arrow6Filled;
    con.TargetCapType = CapType.Arrow2Filled;
}
#endregion
