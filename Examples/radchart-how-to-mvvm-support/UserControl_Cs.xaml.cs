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

#region radchart-how-to-mvvm-support_0
public class Person : INotifyPropertyChanged
{
    private double grade;
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        private set
        {
            _name = value;
        }
    }
    public double Grade
    {
        get
        {
            return this.grade;
        }
        set
        {
            this.grade = value;
            this.OnPropertyChanged( "Grade" );
        }
    }
    public Person( string name, double grade )
    {
        Name = name;
        Grade = grade;
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged( string propertyName )
    {
        if ( this.PropertyChanged != null )
            this.PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
    }
}
#endregion

#region radchart-how-to-mvvm-support_2
public class PersonViewModel : INotifyPropertyChanged
{
    private Person _person;
    public Person Person
    {
        get
        {
            return _person;
        }
        private set
        {
            _person = value;
        }
    }
    private Brush _gradeColor;
    public Brush GradeColor
    {
        get
        {
            return _gradeColor;
        }
        private set
        {
            _gradeColor = value;
        }
    }
    public PersonViewModel( Person person )
    {
        this.Person = person;
        person.PropertyChanged += HandleStudentPropertyChanged;
        this.UpdateGradeColor();
    }
    private void HandleStudentPropertyChanged( object sender, PropertyChangedEventArgs e )
    {
        if ( e.PropertyName == "Grade" )
            this.UpdateGradeColor();
    }
    private void UpdateGradeColor()
    {
        if ( this.Person.Grade < 10 )
            this.GradeColor = this.CreateBrush( "#FFFF3D40" );
        else if ( this.Person.Grade < 20 )
            this.GradeColor = this.CreateBrush( "#FFFD583A" );
        else if ( this.Person.Grade < 30 )
            this.GradeColor = this.CreateBrush( "#FFFD8145" );
        else if ( this.Person.Grade < 40 )
            this.GradeColor = this.CreateBrush( "#FFFAA03D" );
        else if ( this.Person.Grade < 50 )
            this.GradeColor = this.CreateBrush( "#FFFAC741" );
        else if ( this.Person.Grade < 60 )
            this.GradeColor = this.CreateBrush( "#FFFCED40" );
        else if ( this.Person.Grade < 70 )
            this.GradeColor = this.CreateBrush( "#FFD7FC3C" );
        else if ( this.Person.Grade < 80 )
            this.GradeColor = this.CreateBrush( "#FF99F839" );
        else if ( this.Person.Grade < 90 )
            this.GradeColor = this.CreateBrush( "#FF46E633" );
        else
            this.GradeColor = this.CreateBrush( "#FF1CD64D" );
        this.OnPropertyChanged( "GradeColor" );
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged( string propertyName )
    {
        if ( this.PropertyChanged != null )
            this.PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
    }
    private Brush CreateBrush( string color )
    {
        return new SolidColorBrush( this.GetColorFromHexString( color ) );
    }
    private Color GetColorFromHexString( string s )
    {
        s = s.Replace( "#", string.Empty );
        byte a = System.Convert.ToByte( s.Substring( 0, 2 ), 16 );
        byte r = System.Convert.ToByte( s.Substring( 2, 2 ), 16 );
        byte g = System.Convert.ToByte( s.Substring( 4, 2 ), 16 );
        byte b = System.Convert.ToByte( s.Substring( 6, 2 ), 16 );
        return Color.FromArgb( a, r, g, b );
    }
}
#endregion

#region radchart-how-to-mvvm-support_5
private void MVVM_Loaded( object sender, RoutedEventArgs e )
{
    radChart.DefaultView.ChartArea.AxisY.AutoRange = false;
    radChart.DefaultView.ChartArea.AxisY.MinValue = 0;
    radChart.DefaultView.ChartArea.AxisY.MaxValue = 100;
    radChart.DefaultView.ChartArea.AxisY.Step = 10;
    radChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
    radChart.DefaultSeriesDefinition = new BarSeriesDefinition();
    SeriesMapping seriesMapping = new SeriesMapping();
    seriesMapping.ItemMappings.Add( new ItemMapping( "Person.Grade", DataPointMember.YValue ) );
    seriesMapping.ItemMappings.Add( new ItemMapping( "Person.Name", DataPointMember.XCategory ) );
    radChart.SeriesMappings.Add( seriesMapping );
    radChart.ItemsSource = this.GetData();
}
#endregion

#region radchart-how-to-mvvm-support_7
private List<PersonViewModel> GetData()
{
    Random rand = new Random( DateTime.Now.Millisecond );
    List<Person> studentList = new List<Person>();
    for ( int i = 0; i < rand.Next( 9, 12 ); i++ )
        studentList.Add( new Person( "Person" + i, rand.Next( 15, 100 ) ) );
    List<PersonViewModel> modelList = new List<PersonViewModel>();
    foreach ( Person person in studentList )
        modelList.Add( new PersonViewModel( person ) );
    return modelList;
}
#endregion

#region radchart-how-to-mvvm-support_9
public Style BuildCustomItemStyle( Control item, Style style, DataPoint point, DataSeries dataSeries )
{
    if ( ( item as BaseChartItem ) == null )
    {
        return style;
    }
    Style newStyle = new Style();
    newStyle.BasedOn = style;
    newStyle.TargetType = typeof( Shape );
    Brush brush = ( dataSeries[ ( item as BaseChartItem ).CurrentIndex ].DataItem as PersonViewModel ).GradeColor;
    newStyle.Setters.Add( new Setter( Shape.FillProperty, brush ) );
    return newStyle;
}
#endregion

#region radchart-how-to-mvvm-support_11
this.radChart.CreateItemStyleDelegate = this.BuildCustomItemStyle;
#endregion

#region radchart-how-to-mvvm-support_14
radChart.DefaultSeriesDefinition.SeriesItemLabelStyle = this.Resources["MySeriesItemLabel_Style"] as Style;
#endregion
}
