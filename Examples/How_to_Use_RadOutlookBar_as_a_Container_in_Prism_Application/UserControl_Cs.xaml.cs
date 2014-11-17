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
	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_1
	public class Bootstrapper : UnityBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			// Use the container to create an instance of the shell.
			Shell.Views.ShellView shellView = Container.Resolve<Shell.Views.ShellView>();
			// Display the Shell as the root visual for the  application.
			Application.Current.RootVisual = shellView;
			return shellView;
		}
	}
	#endregion

	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_2
	private void Application_Startup(object sender, StartupEventArgs e)
	{
		Bootstrapper bootstrapper = new Bootstrapper();
		bootstrapper.Run();
	}
	#endregion

	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_3
	public class ModuleA : IModule
	{
		IUnityContainer container;
		IRegionManager regionManager;

		public ModuleA(IRegionManager regionManager, IUnityContainer container)
		{
			this.regionManager = regionManager;
			this.container = container;
		}

		public void Initialize()
		{
			// Register views here.
		}
	}
	#endregion

	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_5
	public void Initialize()
	{
		// Register views here.
		this.regionManager.RegisterViewWithRegion("OutlookBarRegion", ()  =>
		{
			return new ModuleAView();
		});
	}
	#endregion

	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_6
	protected override IModuleCatalog GetModuleCatalog()
	{
		ModuleCatalog catalog = new ModuleCatalog();
		catalog.AddModule(typeof(ModuleA.ModuleA));
		return catalog;
	}
	#endregion

	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_7
	public partial class ModuleAView : UserControl
	{
		public ModuleAView()
		{
			InitializeComponent();
			this.ItemHeader = "ModuleA";
		}

		public string ItemHeader { get; set; }
	}
	#endregion

	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_9
	public ModuleAView()
	{
		InitializeComponent();
		this.ItemHeader = "ModuleA";
		Telerik.Windows.Controls.TextSearch.SetText(this, "ModuleA");
	}
	#endregion

	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_12
	public partial class ModuleAView : UserControl
	{
		public ModuleAView()
		{
			InitializeComponent();
		}
		public RadOutlookBarItem OutlookBarItem
		{
			get
			{
				return this.outlookBarItem1;
			}
		}
	}
	#endregion

	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_13
	public void Initialize()
	    {
	     // Register views here.
	     this.regionManager.RegisterViewWithRegion("OutlookBarRegion", () =>
	     {
	      return new ModuleAView().OutlookBarItem;
	     });
	    }
	#endregion

	#region How_to_Use_RadOutlookBar_as_a_Container_in_Prism_Application_14
	public partial class ModuleAView : UserControl
	{
		public ModuleAView()
		{
			InitializeComponent();
			this.LayoutRoot.Children.Clear();
		}

		public RadOutlookBarItem OutlookBarItem
		{
			get
			{
				return this.outlookBarItem1;
			}
		}
	}
	#endregion
}
