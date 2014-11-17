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

#region raddatafilter-how-to-create-custom-filter-editors_0
public class EditorTemplateRule
{
    public string PropertyName
    {
        get;
        set;
    }
    public DataTemplate DataTemplate
    {
        get;
        set;
    }
}
#endregion

#region raddatafilter-how-to-create-custom-filter-editors_2
public class EditorTemplateSelector : DataTemplateSelector
{
    private List<EditorTemplateRule> editorTemplateRules;
    public override DataTemplate SelectTemplate( object item, DependencyObject container )
    {
        ItemPropertyDefinition info = ( ItemPropertyDefinition )item;
        foreach ( EditorTemplateRule rule in this.EditorTemplateRules )
        {
            if ( rule.PropertyName == info.PropertyName )
            {
                return rule.DataTemplate;
            }
        }
        return base.SelectTemplate( item, container );
    }
    public List<EditorTemplateRule> EditorTemplateRules
    {
        get
        {
            if ( this.editorTemplateRules == null )
            {
                this.editorTemplateRules = new List<EditorTemplateRule>();
            }
            return this.editorTemplateRules;
        }
    }
}
#endregion

#region raddatafilter-how-to-create-custom-filter-editors_5
public partial class CustomFilterEditorsSample : UserControl
{
    public CustomFilterEditorsSample()
    {
        InitializeComponent();
        this.radDataFilter.Source = SampleData.GetEmployees();
    }
    private void radDataFilter_EditorCreated( object sender, EditorCreatedEventArgs e )
    {
        switch ( e.ItemPropertyDefinition.PropertyName )
        {
            case "Title":
                ( ( RadComboBox )e.Editor ).ItemsSource = this.GetTitles();
                break;
        }
    }
    public  List<string> GetTitles()
    {
        return new List<string>() { "Owner", "Sales Representative", "Sales Associate", "Sales Agent", "Marketing Assistent" };
    }
}
#endregion

#region raddatafilter-how-to-create-custom-filter-editors_7
public class Employee
{
    public Employee( string name, string companyName, string title )
    {
        this.Name = name;
        this.CompanyName = companyName;
        this.Title = title;
    }
    public string Name
    {
        get;
        set;
    }
    public string CompanyName
    {
        get;
        set;
    }
    public string Title
    {
        get;
        set;
    }
}
#endregion

#region raddatafilter-how-to-create-custom-filter-editors_9
ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
employees.Add( new Employee( "Maria Anders", "Alfreds Futterkiste", "Sales Representative" ) );
employees.Add( new Employee( "Ana Trujillo", "Ana Trujillo Emparedados y helados", "Owner" ) );
employees.Add( new Employee( "Antonio Moreno", "Antonio Moreno Taqueria", "Owner" ) );
employees.Add( new Employee( "Thomas Hardy", "Around the Horn", "Sales Representative" ) );
employees.Add( new Employee( "Hanna Moos", "Blauer See Delikatessen", "Sales Representative" ) );
employees.Add( new Employee( "Frederique Citeaux", "Blondesddsl pere et fils", "Marketing Manager" ) );
employees.Add( new Employee( "Martin Sommer", "Bolido Comidas preparadas", "Owner" ) );
employees.Add( new Employee( "Laurence Lebihan", "Bon app'", "Owner" ) );
employees.Add( new Employee( "Elizabeth Lincoln", "Bottom-Dollar Markets", "Accounting manager" ) );
employees.Add( new Employee( "Victoria Ashworth", "B's Beverages", "Sales representative" ) );
#endregion
}
