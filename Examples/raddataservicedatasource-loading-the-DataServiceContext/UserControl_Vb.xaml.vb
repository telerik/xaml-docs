Public Class Default_Vb


' #region raddataservicedatasource-loading-the-DataServiceContext_1
Partial Public Class NorthwindEntities Inherits Global.System.Data.Services.Client.DataServiceContext
' #endregion

' #region raddataservicedatasource-loading-the-DataServiceContext_3
Dim serviceUri As New Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute)
Dim northwindContext As New NorthwindEntities(serviceUri)
Me.radDataServiceDataSource.DataServiceContext = northwindContextSetting DataServiceContext in XAML
' #endregion

' #region raddataservicedatasource-loading-the-DataServiceContext_5
Public Class MyNorthwindContext
 Inherits NorthwindEntities
 Public Sub New()
  MyBase.New(New Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute))
 End Sub
End Class
' #endregion
End Class
