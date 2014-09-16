Public Class Default_Vb


' #region radpropertygrid-getting-started-getting-started_5
Me.PropertyGrid1.Item = New Employee() With { _
  .FirstName = "Sarah", _
  .LastName = "Blake", _
  .Occupation = "Supplied Manager", _
  .StartingDate = New DateTime(2005, 4, 12), _
  .IsMarried = True, _
  .Salary = 3500, _
  .Gender = Gender.Female _
}
    ' #endregion

    ' #region radpropertygrid-getting-started-getting-started_9
    DataContext = New Order() With { _
	.OrderDate = New DateTime(1996, 7, 5), _
	.ShippedDate = New DateTime(1996, 8, 16), _
	.ShipAddress = "Luisenstr. 48", _
	.ShipCountry = "Germany", _
	.ShipName = "Toms Spezialitaten", _
	.ShipPostalCode = "44087", _
	.Employee = New Employee() With { _
		.FirstName = "Nancy", _
		.LastName = "Davolio", _
		.Title = "Sales Representative", _
		.HomePhone = "(206) 555-9857", _
		.Department = New Department() With { _
			.Country = "USA", _
			.ID = 1 _
		} _
	} _
}
    ' #endregion
End Class
