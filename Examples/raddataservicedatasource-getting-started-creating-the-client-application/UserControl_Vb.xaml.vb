Public Class Default_Vb


' #region raddataservicedatasource-getting-started-creating-the-client-application_1
Public Class MyNorthwindContext
 Inherits NorthwindEntities
 Public Sub New()
  MyBase.New(New Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute))
 End Sub
End Class
' #endregion

' #region raddataservicedatasource-getting-started-creating-the-client-application_3
Public Class MyNorthwindContext
 Inherits NorthwindEntities
 Public Sub New()
  MyBase.New(New Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute))
 End Sub
End Class
' #endregion
End Class
