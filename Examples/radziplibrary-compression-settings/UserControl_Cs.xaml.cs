using System.IO;
using Telerik.Windows.Zip;

namespace RadZipLibraryDocumentationSourceCode.Examples.CompressionSettings
{
    public class UserControl_Cs
    {
        private void DeflateSettings()
        {
            #region radziplibrary-compression-settings_0
            DeflateSettings compressionSettings = new DeflateSettings();
            compressionSettings.CompressionLevel = CompressionLevel.Best;
            compressionSettings.HeaderType = CompressedStreamHeader.ZLib;
            #endregion
        }

        private void LzmaSettings()
        {
            #region radziplibrary-compression-settings_1
            LzmaSettings compressionSettings = new LzmaSettings();
            compressionSettings.DictionarySize = 23;
            compressionSettings.FastBytes = 32;
            compressionSettings.LiteralContextBits = 3;
            compressionSettings.LiteralPositionBits = 3;
            compressionSettings.MatchFinderType = LzmaMatchFinderType.BT4;
            compressionSettings.PositionStateBits = 2;
            #endregion
        }

        public void StoreSettings()
        {
            #region radziplibrary-compression-settings_2
            StoreSettings compressionSettings = new StoreSettings();
            #endregion
        }
    }
}