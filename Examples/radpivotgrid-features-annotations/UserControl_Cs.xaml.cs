#region radpivotgrid-features-annotations_1
public class Order
{
    public DateTime Date { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
    public double Net { get; set; }
    public string Promotion { get; set; }
    public string Advertisement { get; set; }
}
#endregion

#region radpivotgrid-features-annotations_2
//Rename the Date property to Month in the UI
[Display (Name="Month")]
public DateTime Date { get; set; }

//Hide Product from the UI
[Display (AutoGenerateField=false)]
public string Product { get; set; }
#endregion

#region radpivotgrid-features-annotations_3
//Hide Product from the UI
[Browsable (false) ]
public string Product { get; set; }
#endregion

#region radpivotgrid-features-annotations_4
//Rename the Date property to Month in the UI
[DisplayName ("Month")]
public DateTime Date { get; set; }
#endregion

#region radpivotgrid-features-annotations_5
public class Order
{
    //Rename the Date property to Month in the UI
    [Display (Name="Month")]
    public DateTime Date { get; set; }

    public string Product { get; set; }

    //Hide Quantiy from the UI
    [Display (AutoGenerateField=false)]
    public int Quantity { get; set; }

    public double Net { get; set; }

    public string Promotion { get; set; }

    //Hide Product from the UI
    [Browsable(false)]
    public string Advertisement { get; set; }
}
#endregion