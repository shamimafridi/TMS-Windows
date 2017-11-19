Namespace Slides

    Public Class Slide
        Implements IDisposable
        Enum TypeOfSlide
            ProjectViewer
            VehicleTripChart
            slide_2
            slide_n
        End Enum
        Private SldProjVeiwer As Slides.ProjectViewerSlide
        'Private  SldP1 As Slides.Sldddd
        'Private  SldP2 As Slides.Proje1
        Sub New(ByVal type As TypeOfSlide, ByVal MainControl As Object)
            Select Case type
                Case TypeOfSlide.ProjectViewer

                    SldProjVeiwer = New Slides.ProjectViewerSlide
                    SldProjVeiwer.MainControl = MainControl
                    ' SldProjVeiwer.CreatingConfigXmlFile()
                    SldProjVeiwer.CreateNodes()
                    'Case TypeOfSlide.ProjectViewer
                    'Case TypeOfSlide.ProjectViewer
                Case TypeOfSlide.VehicleTripChart
                    'SldProjVeiwer = New Slides.ProjectViewerSlide
                    'SldProjVeiwer.MainControl = MainControl
                    ' SldProjVeiwer.CreatingConfigXmlFile()
                    'SldProjVeiwer.CreateNodes()
            End Select
        End Sub
        Public Overloads Sub Dispose() Implements IDisposable.Dispose
            ' write ytour clean up code here
            GC.SuppressFinalize(Me)
            Me.SldProjVeiwer = Nothing
        End Sub
        Protected Overrides Sub Finalize()
            Dispose()
        End Sub
    End Class
End Namespace