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

#region xamlflix_ganttview_0
var d = DateTime.Today;
xGanttView.VisibleRange = new VisibleRange(d, d.AddMonths(2));
#endregion

#region xamlflix_ganttview_1
xGanttView.PixelLength = new TimeSpan(1, 0, 0, 0);
#endregion

#region xamlflix_ganttview_2
var tasks = new ObservableCollection<GanttTask>();
#endregion

#region xamlflix_ganttview_3
for (int i = 0; i < 4; i++)
{
    var gt = new GanttTask(d.AddDays(14 * i), d.AddDays(14 * i + 14), "Title " + i.ToString());

    for (int j = 0; j < gt.Duration.Days; j++)
    {
        var childGT = new GanttTask();
        childGT.Start = gt.Start.AddDays(j);
        childGT.End = childGT.Start.AddHours(23);
        childGT.Title = "Child " + i.ToString() + "/" + j.ToString();    
        gt.Children.Add(childGT);
    }

    tasks.Add(gt);
}
#endregion

#region xamlflix_ganttview_4
xGanttView.TasksSource = tasks;
#endregion

#region xamlflix_ganttview_5
xGanttView.PixelLength = new TimeSpan(0, 1, 0, 0);
#endregion

#region xamlflix_ganttview_6
if (j > 0)
{
    GanttTask prevGt = gt.Children[j - 1] as GanttTask;
    prevGt.Dependencies.Add(new Dependency { FromTask = childGT });
}
#endregion

#region xamlflix_ganttview_7
public class GanttVM : ViewModelBase
{
    public ObservableCollection<GanttTask> Tasks { get; set; }

    public GanttVM()
    {
        this.Tasks = new ObservableCollection<GanttTask>();
        this.LoadTasks();
    }
}
#endregion

#region xamlflix_ganttview_8
private void LoadTasks()
{
    var d = DateTime.Today;

    for (int i = 0; i < 4; i++)
    {
        var gt = new GanttTask(d.AddDays(14 * i), d.AddDays(14 * i + 14), "Title " + i.ToString());

        for (int j = 0; j < gt.Duration.Days; j++)
        {
            var childGT = new GanttTask();
            childGT.Start = gt.Start.AddDays(j);
            childGT.End = childGT.Start.AddHours(23);
            childGT.Title = "Child " + i.ToString() + "/" + j.ToString();

            if (j > 0)
            {
                GanttTask prevGt = gt.Children[j - 1] as GanttTask;
                prevGt.Dependencies.Add(new Dependency { FromTask = childGT });
            }

            gt.Children.Add(childGT);

        }

        this.Tasks.Add(gt);
    }
}
#endregion

#region xamlflix_ganttview_9
public VisibleRange GanttRange { get; set; }
#endregion

#region xamlflix_ganttview_10
this.GanttRange = new VisibleRange(DateTime.Today, DateTime.Today.AddMonths(2));
#endregion

#region xamlflix_ganttview_11
public class TicksToTimeSpanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return TimeSpan.FromTicks((long)(double)value);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
#endregion

#region xamlflix_ganttview_12

#endregion

#region xamlflix_ganttview_13
private bool checkedValue;
 public bool CheckedValue
 {
     get { return checkedValue;  }
     set
     {
     	if ( checkedValue != value)
         {
             checkedValue = value;
             OnPropertyChanged(() => this.CheckedValue);
         }
     }
 }
#endregion

#region xamlflix_ganttview_14
public ObservableCollection<GanttTask> HighlightedTasks { get; set; }
#endregion

#region xamlflix_ganttview_15
this.HighlightedTasks = new ObservableCollection<GanttTask>();	
#endregion

#region xamlflix_ganttview_16
private void ToggleHighlight(bool? amIHighlighted)
{
    if (amIHighlighted == null)
    {
        return;
    }

    this.HighlightedTasks.Clear();

    if (amIHighlighted == true)
    {
        var rnd = new Random();
        GanttTask parentGT = Tasks[rnd.Next(0, Tasks.Count)] as GanttTask;
        int randNumber = rnd.Next(2, parentGT.Children.Count - 2);
        for (int i = 2; i < randNumber; i++)
        {
            this.HighlightedTasks.Add(parentGT.Children[i] as GanttTask);
        }
    }  
}
#endregion

#region xamlflix_ganttview_17
this.ToggleHighlight(CheckedValue);		
#endregion

#region xamlflix_ganttview_18
public class TeamGanttTask : GanttTask	
{
    public TeamGanttTask() :
        base()
    {}

    public TeamGanttTask(DateTime startDate, DateTime endDate, string title) :
        base(startDate, endDate, title)
    {}
}	
#endregion

#region xamlflix_ganttview_19
private int teamID;
public int TeamID
{
     get { return teamID; }
     set
     {
     	if (teamID != value)
         {
             teamID = value;
             OnPropertyChanged(() => this.TeamID);
         }
     }
}	  	
#endregion

#region xamlflix_ganttview_20
public ObservableCollection<TeamGanttTask> TeamTasks { get; set; }
public ObservableCollection<TeamGanttTask> HighlightedTeamTasks { get; set; }	  	
#endregion

#region xamlflix_ganttview_21
this.TeamTasks = new ObservableCollection<TeamGanttTask>();
this.HighlightedTeamTasks = new ObservableCollection<TeamGanttTask>();  	
#endregion

#region xamlflix_ganttview_22
//LoadTasks();
this.LoadTeamTasks();	
#endregion

#region xamlflix_ganttview_23
Random rnd = new Random();
private void LoadTeamTasks()
{
    var d = DateTime.Today;

    for (int i = 0; i < 4; i++)
    {
        var gt = new TeamGanttTask(d.AddDays(14 * i), d.AddDays(14 * i + 14), "Title " + i.ToString());

        for (int j = 0; j < gt.Duration.Days; j++)
        {
            var childGT = new TeamGanttTask();
            childGT.Start = gt.Start.AddDays(j);
            childGT.End = childGT.Start.AddHours(23);
            childGT.Title = "Child " + i.ToString() + "/" + j.ToString();
            childGT.TeamID = rnd.Next(0, 4);

            if (j > 0)
            {
                GanttTask prevGt = gt.Children[j - 1] as GanttTask;
                prevGt.Dependencies.Add(new Dependency { FromTask = childGT });
            }

            gt.Children.Add(childGT);

        }

        TeamTasks.Add(gt);
    }
}	
#endregion

#region xamlflix_ganttview_24
private TeamGanttTask selectedTask;
public TeamGanttTask SelectedTask
{
    get { return selectedTask; }
    set
    {
    if ( selectedTask != value)
        {
            selectedTask = value;
            OnPropertyChanged(() => this.SelectedTask);
        }
    }
}
#endregion

#region xamlflix_ganttview_25
void ToggleTeamHighlight(bool? amIHightlighting)
{
    if (amIHightlighting == null || SelectedTask == null)
    {
        return;
    }
    this.HighlightedTeamTasks.Clear();

    if (amIHightlighting == true)
    {
        int counter = TeamTasks.Count;

        for (int i = 0; i < counter; i++)
        {
            TeamGanttTask tgt = TeamTasks[i];

            var teamKids = tgt.Children.OfType<TeamGanttTask>().
                   Where(x => x.TeamId == SelectedTask.TeamId);

            foreach (var teamkid in teamKids)
            {
                HighlightedTeamTasks.Add(teamkid);
            }
        }
    }
}
#endregion
}