#region radpivotgrid-features-expand-behavior_1
RadPivotGrid pivot = new RadPivotGrid();
pivot.RowGroupsExpandBehavior = new GroupsExpandBehavior() { Expanded = false, UpToLevel = 2 };
pivot.ColumnGroupsExpandBehavior = new GroupsExpandBehavior() { Expanded = false };
#endregion

#region radpivotgrid-features-expand-behavior_2
public void ExpandGroupsButton_Click(object sender, RoutedEventArgs e)
{
    (this.pivot.RowGroupsExpandBehavior as GroupsExpandBehavior).Expanded = true;
    (this.pivot.ColumnGroupsExpandBehavior as GroupsExpandBehavior).Expanded = true;
    this.pivot.DataProvider.Refresh();
}

private void CollapseGroupsButton_Click(object sender, RoutedEventArgs e)
{
    (this.pivot.RowGroupsExpandBehavior as GroupsExpandBehavior).Expanded = false;
    (this.pivot.ColumnGroupsExpandBehavior as GroupsExpandBehavior).Expanded = false;
    this.pivot.DataProvider.Refresh();
}
#endregion