Public Class Default_Vb


' #region radupload-features-upload-validation_1
radUpload.AddHandler(RadUploadItem.ValidateEvent, New UploadValidateEventHandler(AddressOf OnValidate))
' #endregion

' #region radupload-features-upload-validation_3
Private Sub
    OnValidate(ByVal sender As Object, ByVal e As UploadValidateEventArgs)
        If (TryCast(e.OriginalSource, RadUploadItem)).FileName.Equals("Desert.jpg") Then
            e.ErrorMessage = "Cannot upload this image!"
            e.Cancel = True
        End If
    End Sub
' #endregion
End Class
