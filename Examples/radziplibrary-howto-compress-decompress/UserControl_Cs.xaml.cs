#region radziplibrary-howto-compress-decompress-0
        public MainWindow()
        {
            InitializeComponent();

            UncompressedText.Text = "<NWindDataSet><Products><ProductID>1</ProductID><ProductName>Chai</ProductName><SupplierID>1</SupplierID>   <CategoryID>1</CategoryID><QuantityPerUnit>10 boxes x 20 bags</QuantityPerUnit><UnitPrice>18.0000</UnitPrice><UnitsInStock>39</UnitsInStock>   <UnitsOnOrder>0</UnitsOnOrder><ReorderLevel>10</ReorderLevel><Discontinued>false</Discontinued></Products><Products><ProductID>2</ProductID>   <ProductName>Chang</ProductName><SupplierID>1</SupplierID><CategoryID>1</CategoryID><QuantityPerUnit>24 - 12 oz bottles</QuantityPerUnit>   <UnitPrice>19.0000</UnitPrice><UnitsInStock>17</UnitsInStock><UnitsOnOrder>40</UnitsOnOrder><ReorderLevel>25</ReorderLevel><Discontinued>false</Discontinued>  </Products><Products><ProductID>3</ProductID><ProductName>Aniseed Syrup</ProductName><SupplierID>1</SupplierID><CategoryID>2</CategoryID><QuantityPerUnit>12 - 550 ml bottles</QuantityPerUnit><UnitPrice>10.0000</UnitPrice><UnitsInStock>13</UnitsInStock><UnitsOnOrder>70</UnitsOnOrder><ReorderLevel>25</ReorderLevel>   <Discontinued>false</Discontinued></Products><Products><ProductID>4</ProductID><ProductName>Chef Anton's Cajun Seasoning</ProductName><SupplierID>2</SupplierID><CategoryID>2</CategoryID><QuantityPerUnit>48 - 6 oz jars</QuantityPerUnit><UnitPrice>22.0000</UnitPrice><UnitsInStock>53</UnitsInStock>  <UnitsOnOrder>0</UnitsOnOrder><ReorderLevel>0</ReorderLevel><Discontinued>false</Discontinued></Products></NWindDataSet>";
        }
#endregion
#region radziplibrary-howto-compress-decompress-1
        public MainPage()
        {
            InitializeComponent();

            UncompressedText.Text = "<NWindDataSet><Products><ProductID>1</ProductID><ProductName>Chai</ProductName><SupplierID>1</SupplierID>   <CategoryID>1</CategoryID><QuantityPerUnit>10 boxes x 20 bags</QuantityPerUnit><UnitPrice>18.0000</UnitPrice><UnitsInStock>39</UnitsInStock>   <UnitsOnOrder>0</UnitsOnOrder><ReorderLevel>10</ReorderLevel><Discontinued>false</Discontinued></Products><Products><ProductID>2</ProductID>   <ProductName>Chang</ProductName><SupplierID>1</SupplierID><CategoryID>1</CategoryID><QuantityPerUnit>24 - 12 oz bottles</QuantityPerUnit>   <UnitPrice>19.0000</UnitPrice><UnitsInStock>17</UnitsInStock><UnitsOnOrder>40</UnitsOnOrder><ReorderLevel>25</ReorderLevel><Discontinued>false</Discontinued>  </Products><Products><ProductID>3</ProductID><ProductName>Aniseed Syrup</ProductName><SupplierID>1</SupplierID><CategoryID>2</CategoryID><QuantityPerUnit>12 - 550 ml bottles</QuantityPerUnit><UnitPrice>10.0000</UnitPrice><UnitsInStock>13</UnitsInStock><UnitsOnOrder>70</UnitsOnOrder><ReorderLevel>25</ReorderLevel>   <Discontinued>false</Discontinued></Products><Products><ProductID>4</ProductID><ProductName>Chef Anton's Cajun Seasoning</ProductName><SupplierID>2</SupplierID><CategoryID>2</CategoryID><QuantityPerUnit>48 - 6 oz jars</QuantityPerUnit><UnitPrice>22.0000</UnitPrice><UnitsInStock>53</UnitsInStock>  <UnitsOnOrder>0</UnitsOnOrder><ReorderLevel>0</ReorderLevel><Discontinued>false</Discontinued></Products></NWindDataSet>";
        }
#endregion
#region radziplibrary-howto-compress-decompress-2
public string CompressString(string arg)
{
    msCompress = new MemoryStream();
    ZipCompression method = ZipCompression.Deflate64;
    zipOut = new ZipOutputStream(msCompress, method);
    StreamWriter sWriter = new StreamWriter(zipOut);

    sWriter.Write(arg);
    sWriter.Flush();

    CompressedText.Text = Convert.ToBase64String(msCompress.ToArray());

    return ("Compress: " + zipOut.CompressedSize.ToString() + ", Uncompress:" + zipOut.UncompressedSize.ToString());
}
#endregion
#region radziplibrary-howto-compress-decompress-3
public string DecompressStream()
{
    System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
    msCompress.Position = 0;

    ZipInputStream inputStream = new ZipInputStream(msCompress, false);

    string str = null;
    StreamReader reader = new StreamReader(inputStream, encoding);
    str = reader.ReadToEnd();
    DeCompressedSize.Text = inputStream.UncompressedSize.ToString();
    return str;
}
#endregion