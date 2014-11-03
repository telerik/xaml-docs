using System;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using Telerik.Windows.Zip;

namespace RadZipLibraryDocumentationSourceCode.Examples.CompressStream
{
    public partial class Default_Cs : UserControl
    {
        private void CompressStream(Stream outputStream, Stream inputStream)
        {
            #region radziplibrary-compress-stream_0
            using (CompressedStream compressedStream = new CompressedStream(outputStream, StreamOperationMode.Write, new DeflateSettings()))
            {
                // write to compressed stream
            }
            #endregion

            #region radziplibrary-compress-stream_1
            using (CompressedStream compressedStream = new CompressedStream(outputStream, StreamOperationMode.Write, new DeflateSettings()))
            {
                inputStream.CopyTo(compressedStream);
                compressedStream.Flush();
            }
            #endregion
        }

        private void DecompressStream(Stream outputStream, Stream inputStream)
        {
            #region radziplibrary-compress-stream_2
            using (CompressedStream compressedStream = new CompressedStream(inputStream, StreamOperationMode.Read, new DeflateSettings()))
            {
                compressedStream.CopyTo(outputStream);
            }
            #endregion
        }
    }
}