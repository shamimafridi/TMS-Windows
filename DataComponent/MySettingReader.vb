
Public Class MySettingReader
    Enum FieldLevel As Byte
        ApplicationLevel
        UserLevel
    End Enum
    Shared Function Read(ByVal ReadingField As String, ByVal FieldLevel As FieldLevel) As String
        Try
            Dim ReturnStr As String = String.Empty
            Dim Reader As New Xml.XmlTextReader(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
            If FieldLevel = MySettingReader.FieldLevel.ApplicationLevel Then
                Reader.ReadToFollowing("applicationSettings")
            Else
                Reader.ReadToFollowing("userSettings")
            End If

            Reader.ReadToFollowing("BusinessLeaf.My.MySettings")
            Reader.ReadToFollowing("setting")


            Do
                If ReadingField = Reader.GetAttribute("name") Then
                    Reader.ReadToFollowing("value")
                    ReturnStr = Reader.ReadElementContentAsString()
                    Return ReturnStr
                End If
            Loop While Reader.ReadToFollowing("setting")
            Return ReturnStr
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class