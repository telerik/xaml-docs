---
title: Value cannot be null. Parameter name - Pages exception opening a particular pdf
description: Resolve ArgumentNullException when trying to show PDF document. Error message Value cannot be null. Parameter name - Pages.
type: troubleshooting
page_title: ArgumentNullException when importing document in PdfViewer
slug: kb-pdfviewer-argumentnullexception-pages
position: 0
tags: argumentnullexception, error, opening, open, import, pdf, pdfviewer
ticketid: 1401132
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadPDFViewer for WPF</td>
	</tr>
</table>


## Description
An error is thrown with a message "Value cannot be null. Parameter name: Pages" when trying to show a PDF document. The document cannot be opened in RadPdfViewer.


## Error Message
System.ArgumentNullException: 'Value cannot be null.
Parameter name: Pages' 

Call Stack:
Telerik.Windows.Documents.Core.dll!Telerik.Windows.Documents.Utilities.Guard.ThrowExceptionIfNull<Telerik.Windows.Documents.Fixed.FormatProviders.Old.Pdf.DocumentModel.Core.Trees.PageTreeNodeOld>(Telerik.Windows.Documents.Fixed.FormatProviders.Old.Pdf.DocumentModel.Core.Trees.PageTreeNodeOld param, string paramName) Line 84	
 	Telerik.Windows.Documents.Fixed.dll!Telerik.Windows.Documents.Fixed.FormatProviders.Old.Pdf.PdfReader.PdfContentManager.GetPages() Line 314	
 	Telerik.Windows.Documents.Fixed.dll!Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider.GetPages(Telerik.Windows.Documents.Fixed.Model.Internal.RadFixedDocumentInternal doc) Line 443	
 	Telerik.Windows.Documents.Fixed.dll!Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider.LoadPages() Line 433
 	Telerik.Windows.Documents.Fixed.dll!Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider.Import() Line 129

## Cause\Possible Cause(s)
The exception is thrown when there is an invalid cross-reference table definition inside the document. Some applications generate PDF documents in which the start index of the table is 1 (instead of its correct zero value). Although Adobe Reader handles this kind of invalid documents, Telerik's PDF viewer does not display them. 

## Suggested Workarounds
Changing the value of the start index from 1 to 0 fixes the issue and the modified document is opened successfully in PdfViewer. This can be seen by opening the PDF document and searching for the xref keyword - the cross-reference definition starts just after the keyword.

You can also automate the process by changing the stream that is being imported in PdfViewer. To achieve that, you will need to add an additional class to keep the logic about validating and repairing the data, similar to the following one:


```C#

    public class CrossReferencesValidator
    {
        private const string StartXRefKeyword = "startxref";
        private const string XRefKeyword = "xref";
        private const int BufferSize = 1024;
    
        public static bool TryHandleInvalidCrossReferenceStartIndex(Stream stream, out Stream validatedStream)
        {
            validatedStream = null;
    
            if (!TrySeekToStartXRefKeyword(stream))
            {
                return false;
            }
    
            int xrefOffset = ReadStartXRefOffset(stream);
            stream.Seek(xrefOffset, SeekOrigin.Begin);
            string line = ReadLine(stream).Trim();
    
            if (line != XRefKeyword)
            {
                return false;
            }
    
            long position = stream.Position;
            string[] tokens = ReadLine(stream).Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            line = ReadLine(stream).Trim();
    
            if (tokens[0] == "1" && line == "0000000000 65535 f")
            {
                validatedStream = ChangeByteToZero(stream, position);
    
                return true;
            }
    
            return false;
        }
    
        private static Stream ChangeByteToZero(Stream stream, long zeroBytePosition)
        {
            MemoryStream memory = new MemoryStream();
            stream.Seek(0, SeekOrigin.Begin);
            stream.CopyTo(memory);
            memory.Seek(0, SeekOrigin.Begin);
            byte[] bytes = memory.ToArray();
            bytes[zeroBytePosition] = (byte)'0';
    
            return new MemoryStream(bytes);
        }
    
        private static int ReadStartXRefOffset(Stream stream)
        {
            ReadLine(stream); // Skip startxref word
            string offsetValue = ReadLine(stream).Trim();
            int offset = int.Parse(offsetValue);
    
            return offset;
        }
    
        private static bool TrySeekToStartXRefKeyword(Stream input)
        {
            StringBuilder tmp = new StringBuilder();
            StringBuilder tok = new StringBuilder(StartXRefKeyword);
            int size = (int)Math.Min(input.Length, BufferSize);
            byte[] buffer = new byte[size];
            input.Seek(-size, SeekOrigin.End);
    
            long offset = -1;
            input.Read(buffer, 0, buffer.Length);
            for (int i = size - 1; i >= 0; i--)
            {
                tmp.Insert(0, ((char)buffer[i]).ToString());
                if (tok.Length < tmp.Length)
                {
                    tmp.Remove(tmp.Length - 1, 1);
                }
    
                if (tmp.Equals(tok))
                {
                    offset = size - i;
    
                    break;
                }
            }
    
            if (offset == -1)
            {
                return false;
            }
    
            input.Seek(-offset, SeekOrigin.End);
    
            return true;
        }
    
        private static string ReadLine(Stream stream)
        {
            byte b;
            StringBuilder stringBuilder = new StringBuilder();
    
            while (!IsEndOfFile(stream) && !IsLineFeed(b = ReadByte(stream)))
            {
                if (!IsCarriageReturn(b))
                {
                    stringBuilder.Append((char)b);
                }
                else if (!IsEndOfFile(stream) && !IsLineFeed(b = PeekByte(stream)))
                {
                    break;
                }
            }
    
            return stringBuilder.ToString();
        }
    
        private static byte PeekByte(Stream stream)
        {
            byte b = ReadByte(stream);
            stream.Seek(-1, SeekOrigin.Current);
    
            return b;
        }
    
        private static byte ReadByte(Stream stream)
        {
            int res = stream.ReadByte();
    
            if (res < 0)
            {
                throw new EndOfStreamException();
            }
    
            return (byte)res;
        }
    
        private static bool IsEndOfFile(Stream stream)
        {
            return stream.Position >= stream.Length;
        }
    
        private static bool IsLineFeed(byte b)
        {
            return b == (byte)'\n';
        }
    
        private static bool IsCarriageReturn(byte b)
        {
            return b == (byte)'\r';
        }
    }

```

The next step is to ensure that the **CrossReferencesValidator.TryHandleInvalidCrossReferenceStartIndex()** method is called to check the validity of the PDF document and depending on the result, use the original or the modified stream to import the data in the viewer. For clarity, this logic is separated in a method:


```C#
    
    private PdfDocumentSource CreateValidatedDocumentSource(string filePath)
    {
        Stream originalStream = File.OpenRead(filePath);
    
        Stream modifiedStream;
        if (CrossReferencesValidator.TryHandleInvalidCrossReferenceStartIndex(originalStream, out modifiedStream))
        {
            return new PdfDocumentSource(modifiedStream);
        }
    
        return new PdfDocumentSource(originalStream);
    }
```

And here is how you can invoke this method to import the document:


```C#

    this.pdfViewer.DocumentSource = this.CreateValidatedDocumentSource("../../Test.pdf");
```

## Notes

There is a request for this functionality to be integrated inside RadPdfViewer. Make sure to cast your vote for it as this directly affects its priority: [PdfViewer: Handle documents containing invalid cross-reference table start index](https://feedback.telerik.com/silverlight/1355903-pdfviewer-handle-documents-containing-invalid-cross-reference-table-start-index).
