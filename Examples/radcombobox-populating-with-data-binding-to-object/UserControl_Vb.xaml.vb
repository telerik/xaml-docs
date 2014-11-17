Public Class Default_Vb


' #region radcombobox-populating-with-data-binding-to-object_2
Public Class Agency
    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal phone As String, ByVal zip As String)
        Me.Name = name
        Me.Phone = phone
        Me.Zip = zip
    End Sub
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _Phone As String
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property
Private _Zip As String
    Public Property Zip() As String
        Get
            Return _Zip
        End Get
        Set(ByVal value As String)
            _Zip = value
        End Set
    End Property
End Class
' #endregion

' #region radcombobox-populating-with-data-binding-to-object_4
Public Class AgencyViewModel
    Private agencies As ObservableCollection(Of Agency)
    Public ReadOnly Property Agency() As ObservableCollection(Of Agency)
        Get
            If agencies Is Nothing Then
                agencies = New ObservableCollection(Of Agency)()
                agencies.Add(New Agency("Exotic Liquids", "(171) 555-2222", "EC1 4SD"))
                agencies.Add(New Agency("New Orleans Cajun Delights", "(100) 555-4822", "70117"))
                agencies.Add(New Agency("Grandma Kelly's Homestead", "(313) 555-5735", "48104"))
                agencies.Add(New Agency("Tokyo Traders", "(03) 3555-5011", "100"))
                agencies.Add(New Agency("Cooperativa de Quesos 'Las Cabras'", "(98) 598 76 54", "33007"))
                agencies.Add(New Agency("Mayumi's", "(06) 431-7877", "545"))
                agencies.Add(New Agency("Pavlova, Ltd.", "(03) 444-2343", "3058"))
                agencies.Add(New Agency("Specialty Biscuits, Ltd.", "(161) 555-4448", "M14 GSD"))
                agencies.Add(New Agency("PB Knäckebröd AB", "031-987 65 43", "S-345 67"))
                agencies.Add(New Agency("Refrescos Americanas LTDA", "(11) 555 4640", "5442"))
                agencies.Add(New Agency("Heli Süßwaren GmbH & Co. KG", "(New Item) (010) 9984510", "10785"))
                agencies.Add(New Agency("Plutzer Lebensmittelgroßmärkte AG", "(New Item) (069) 992755", "60439"))
                agencies.Add(New Agency("Nord-Ost-Fisch Handelsgesellschaft mbH", "(New Item) (04721) 8713", "27478"))
                agencies.Add(New Agency("Formaggi Fortini s.r.l.", "(New Item) (0544) 60323", "48100"))
                agencies.Add(New Agency("Norske Meierier", "(New Item) (0)2-953010", "1320"))
                agencies.Add(New Agency("Bigfoot Breweries", "(New Item) (503) 555-9931", "97101"))
                agencies.Add(New Agency("Svensk Sjöföda AB", "(New Item) 08-123 45 67", "S-123 45"))
                agencies.Add(New Agency("Aux joyeux ecclésiastiques", "(New Item) (1) 03.83.00.68", "75004"))
                agencies.Add(New Agency("New England Seafood Cannery", "(New Item) (617) 555-3267", "2134"))
                agencies.Add(New Agency("Leka Trading", "(New Item) 555-8787", "512"))
                agencies.Add(New Agency("Lyngbysild", "(New Item) 43844108", "2800"))
                agencies.Add(New Agency("Zaanse Snoepfabriek", "(New Item) (12345) 1212", "9999 ZZ"))
                agencies.Add(New Agency("Karkki Oy", "(New Item) (953) 10956", "53120"))
                agencies.Add(New Agency("G'day, Mate", "(New Item) (02) 555-5914", "2042"))
                agencies.Add(New Agency("Ma Maison", "(New Item) (514) 555-9022", "H1J 1C3"))
                agencies.Add(New Agency("Pasta Buttini s.r.l.", "(New Item) (089) 6547665", "84100"))
                agencies.Add(New Agency("Escargots Nouveaux", "(New Item) 85.57.00.07", "71300"))
                agencies.Add(New Agency("Gai pâturage", "(New Item) 38.76.98.06", "74000"))
                agencies.Add(New Agency("Forêts d'érables", "(New Item) (514) 555-2955", "J2S 7S8"))
            End If
            Return agencies
        End Get
    End Property
End Class
' #endregion
End Class
