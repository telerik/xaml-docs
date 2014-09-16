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

#region gridview-basic-hierarchies_1
GridViewTableDefinition d = new GridViewTableDefinition();
#endregion

#region gridview-basic-hierarchies_5
GridViewTableDefinition d = new GridViewTableDefinition();
d.Relation = new Telerik.Windows.Data.PropertyRelation( "Orders" );
#endregion

#region gridview-basic-hierarchies_8
this.radGridView.ChildTableDefinitions.Add( d );
#endregion
}
