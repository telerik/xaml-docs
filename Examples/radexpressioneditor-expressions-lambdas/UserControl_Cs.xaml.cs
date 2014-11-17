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

#region radexpressioneditor-expressions-lambdas_0
item => item.Salary
#endregion

#region radexpressioneditor-expressions-lambdas_2
item => item.Tasks.Where(param0 => param0.SubTasks.Count > 2)
#endregion
}
