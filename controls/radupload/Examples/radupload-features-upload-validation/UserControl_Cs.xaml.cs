using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            #region radupload-features-upload-validation_0
                radUpload.AddHandler(RadUploadItem.ValidateEvent, new UploadValidateEventHandler(OnValidate));
            #endregion
        }

        #region radupload-features-upload-validation_2
        void OnValidate(object sender, UploadValidateEventArgs e)
        {
            if ((e.OriginalSource as RadUploadItem).FileName.Equals("Desert.jpg"))
            {
                e.ErrorMessage = "Cannot upload this image!";
                e.Cancel = true;
            }
        }
        #endregion
    }
}
