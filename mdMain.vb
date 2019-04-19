Module mdMain
    Public Frm As frmCCMySQLSchema

    Public Sub Main()
        Dim objFInicial As New frmPrincipal
        objFInicial.ShowDialog()
    End Sub

    Function MTab(Cant As Integer) As String
        Return Space(Cant * 4)
    End Function

    Public Lista_Indices As New System.Collections.Generic.List(Of String)

End Module
