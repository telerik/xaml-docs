using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radchart-populating-with-data-binding-to-wcf_2
[ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service2
    {
        [OperationContract]
        public List<Product> LoadTop10Products()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var query = from c in db.Products select c;
            return query.Take(10).ToList();
        }
    }
#endregion

#region radchart-populating-with-data-binding-to-wcf_4
MyService.Service2Client client = new MyService.Service2Client();
#endregion

#region radchart-populating-with-data-binding-to-wcf_6
InitializeComponent();
MyService.Service2Client client = new MyService.Service2Client();
client.LoadTop10ProductsCompleted += new EventHandler<LoadTop10ProductsCompletedEventArgs>(client_LoadTop10ProductsCompleted);
client.LoadTop10ProductsAsync();
void client_LoadTop10ProductsCompleted(object sender, LoadTop10ProductsCompletedEventArgs e)
{
var products = e.Result;
 this.radChart.ItemsSource = products;
 this.radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = -90;
}
#endregion

#region radchart-populating-with-data-binding-to-wcf_8
radChart.ItemsSource = serviceClient.LoadTop10Products();
#endregion

#region radchart-populating-with-data-binding-to-wcf_10
public class NorthwindDataSource
{
}
#endregion

#region radchart-populating-with-data-binding-to-wcf_12
public class NorthwindDataSource
{
    private SampleWcfServiceClient serviceClient;
    public NorthwindDataSource()
    {
        this.serviceClient = new SampleWcfServiceClient();
        this.Products = new ObservableCollection<Products>();
    }
    public ObservableCollection<Products> Products
    {
        get;
        set;
    }
}
#endregion

#region radchart-populating-with-data-binding-to-wcf_14
this.serviceClient.LoadTop10ProductsCompleted += new EventHandler<LoadTop10ProductsCompletedEventArgs>( serviceClient_LoadTop10ProductsCompleted );
this.serviceClient.LoadTop10ProductsAsync();
#endregion

#region radchart-populating-with-data-binding-to-wcf_15
foreach ( Products p in serviceClient.LoadTop10Products() )
{
    this.Products.Add( p );
}
#endregion

#region radchart-populating-with-data-binding-to-wcf_18
private void serviceClient_LoadTop10ProductsCompleted( object sender, LoadTop10ProductsCompletedEventArgs e )
{
    foreach ( Products p in e.Result )
    {
        this.Products.Add( p );
    }
}
#endregion
}
