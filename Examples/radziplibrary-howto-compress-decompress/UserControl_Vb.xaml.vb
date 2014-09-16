'#region radziplibrary-howto-compress-decompress-0
Public Sub New()
	InitializeComponent()

	UncompressedText.Text = "<NWindDataSet><Products><ProductID>1</ProductID><ProductName>Chai</ProductName><SupplierID>1</SupplierID>   <CategoryID>1</CategoryID><QuantityPerUnit>10 boxes x 20 bags</QuantityPerUnit><UnitPrice>18.0000</UnitPrice><UnitsInStock>39</UnitsInStock>   <UnitsOnOrder>0</UnitsOnOrder><ReorderLevel>10</ReorderLevel><Discontinued>false</Discontinued></Products><Products><ProductID>2</ProductID>   <ProductName>Chang</ProductName><SupplierID>1</SupplierID><CategoryID>1</CategoryID><QuantityPerUnit>24 - 12 oz bottles</QuantityPerUnit>   <UnitPrice>19.0000</UnitPrice><UnitsInStock>17</UnitsInStock><UnitsOnOrder>40</UnitsOnOrder><ReorderLevel>25</ReorderLevel><Discontinued>false</Discontinued>  </Products><Products><ProductID>3</ProductID><ProductName>Aniseed Syrup</ProductName><SupplierID>1</SupplierID><CategoryID>2</CategoryID><QuantityPerUnit>12 - 550 ml bottles</QuantityPerUnit><UnitPrice>10.0000</UnitPrice><UnitsInStock>13</UnitsInStock><UnitsOnOrder>70</UnitsOnOrder><ReorderLevel>25</ReorderLevel>   <Discontinued>false</Discontinued></Products><Products><ProductID>4</ProductID><ProductName>Chef Anton's Cajun Seasoning</ProductName><SupplierID>2</SupplierID><CategoryID>2</CategoryID><QuantityPerUnit>48 - 6 oz jars</QuantityPerUnit><UnitPrice>22.0000</UnitPrice><UnitsInStock>53</UnitsInStock>  <UnitsOnOrder>0</UnitsOnOrder><ReorderLevel>0</ReorderLevel><Discontinued>false</Discontinued></Products></NWindDataSet>"
End Sub
'#endregion
'#region radziplibrary-howto-compress-decompress-1
Public Function CompressString(ByVal arg As String) As String
	msCompress = New MemoryStream()
	Dim method As ZipCompression = ZipCompression.Deflate64
	zipOut = New ZipOutputStream(msCompress, method)
	Dim sWriter As New StreamWriter(zipOut)

	sWriter.Write(arg)
	sWriter.Flush()

	CompressedText.Text = Convert.ToBase64String(msCompress.ToArray())

	Return ("Compress: " & zipOut.CompressedSize.ToString() & ", Uncompress:" & zipOut.UncompressedSize.ToString())
End Function
'#endregion
'#region radziplibrary-howto-compress-decompress-2
Public Function DecompressStream() As String
	Dim encoding As New System.Text.UTF8Encoding()
	msCompress.Position = 0

	Dim inputStream As New ZipInputStream(msCompress, False)

	Dim str As String = Nothing
	Dim reader As New StreamReader(inputStream, encoding)
	str = reader.ReadToEnd()
	DeCompressedSize.Text = inputStream.UncompressedSize.ToString()
	Return str
End Function
'#endregions