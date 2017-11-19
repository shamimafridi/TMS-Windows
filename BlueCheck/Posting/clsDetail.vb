
Public Class Detail
    Public Recordset As New DataTable
    Public StoreProcedure As String
    'Public OptionVariable   As String
    'Public ParameterAll     As String

    'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Class_Initialize_Renamed()

        'OptionVariable = "@OPTION"
        'ParameterAll = "ALL"

    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub
End Class