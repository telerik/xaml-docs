Public Class Default_Vb


' #region gridview-binding-to-hierarchical-data-automatically_1
Public Partial Class Example
        Inherits ExampleControl
             Private tableDefinition As TableDefinition
             Public Sub New()
        InitializeComponent()
        Dim dataSet As New NWindDataSet()
        Dim ordersAdapter As New OrdersTableAdapter()
        ordersAdapter.Fill(dataSet.Orders)
        Dim detailAdapter As New Order_DetailsTableAdapter()
                  detailAdapter.Fill(dataSet.Order_Details)
        radGridView1.AutoGenerateHierarchyFromDataSet = True
        radGridView1.DataMember = dataSet.Tables("Orders").TableName
        radGridView1.ItemsSource = dataSet
             End Sub
        End Class
' #endregion
End Class
