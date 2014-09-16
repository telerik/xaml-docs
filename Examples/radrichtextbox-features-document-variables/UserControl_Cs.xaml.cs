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

#region radrichtextbox-features-document-variables_0
this.editor.Document.DocumentVariables
#endregion

#region radrichtextbox-features-document-variables_1
this.editor.Document.DocumentVariables.Add("Name", "Andrew Fuller");
this.editor.Document.DocumentVariables["Job"] = "Software Engineer";
#endregion

#region radrichtextbox-features-document-variables_2
this.editor.Document.DocumentVariables.Remove("Name");
#endregion

#region radrichtextbox-features-document-variables_3
DocumentVariableField docVariable = new DocumentVariableField() { VariableName = "Name" };
this.editor.InsertField(docVariable);

#endregion

#region radrichtextbox-features-document-variables_4

#endregion

#region radrichtextbox-features-document-variables_5

#endregion

}
