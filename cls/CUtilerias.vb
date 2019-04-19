
Public Class CReglasRotas
    Inherits CollectionBase

#Region "Métodos Publicos"
    Public Sub New()
        MyBase.New()
    End Sub

    'Permite a la colección borrar los elementos
    Public Sub Borrar(ByVal strRegla As String)
        InnerList.Remove(strRegla)
    End Sub

    'Agrega el método Agregar
    Public Sub Agregar(ByVal strRegla As String, ByVal bRota As Boolean)

        If bRota Then
            If Not Existe(strRegla) Then
                InnerList.Add(strRegla)
            End If
        Else
            Borrar(strRegla)
        End If

    End Sub

    Public Function Cuenta() As Integer
        Return InnerList.Count
    End Function

    Public Function Existe(ByVal _Clave As String) As Boolean
        Return InnerList.Contains(_Clave)
    End Function

#End Region

End Class


Public Class CEncriptado

    Public Shared Function Desencripta(ByVal _Valor As String) As String
        Dim sNum As Short
        Dim sContador As Short = 1
        Dim sInicio As Short = 1
        Dim strDEncriptado As String = ""

        If _Valor Is Nothing Or
            _Valor.Length = 0 Then Return ""

        While sInicio <= _Valor.Length - 1
            sNum = CType(Mid$(_Valor, sInicio, 3), Short)

            If sContador Mod 2 = 0 Then
                sNum += 2
            Else
                sNum -= 1
            End If

            strDEncriptado &= Chr(sNum)
            sContador += 1
            sInicio += 3
        End While

        Return strDEncriptado
    End Function

    Public Shared Function Encripta(ByVal _Valor As Object) As String
        Dim chrLetra As Char
        Dim strValor As Char()
        Dim sNum As Short
        Dim sContador As Short = 1
        Dim strEncriptado As String = ""

        If _Valor Is Nothing Then Return ""

        _Valor = CType(_Valor, String)

        strValor = _Valor.ToCharArray()
        For Each chrLetra In strValor
            sNum = Asc(chrLetra)

            If sContador Mod 2 = 0 Then
                sNum -= 2
            Else
                sNum += 1
            End If

            strEncriptado &= Format(sNum, "000")
            sContador += 1
        Next

        Return strEncriptado
    End Function

End Class


Public Class CConstantes
    'Estados en los que puede estar un registro
    Public Const chrEstadoNormal As Char = "N"
    Public Const chrEstadoModificado As Char = "U"

    Public Const chrEstadoBorrado As Char = "D"

    'Acciones requeridas
    Public Const chrAccModificar As Char = "U"
    Public Const chrAccNuevo As Char = "N"

    'Estatus de articulo
    Public Const cteArticuloActivo As String = "AST001"
    Public Const cteArticuloInactivo As String = "AST002"

    'Constantes de formato 
    Public Const cteFormatoFolio As String = "000000"
    Public Const cteFormatoMoneda As String = "$##,###,###.##"
    Public Const cteFormatoNumero As String = "#,###.00"
    Public Const cteFormatoFecha As String = "dd/MM/yyyy hh:mm"

    'Estados de requisiciones
    Public Const cteRegNueva As Char = "N"
    Public Const cteRegEnEspera As Char = "E"
    Public Const cteRegModificado As Char = "U"

    'Estatus de Requisiciones
    Public Const cteSTreqApartada As String = "APARTA"
    Public Const cteSTreqAutorizada As String = "AUTORI"
    Public Const cteSTreqRechazada As String = "RECHAZ"
    Public Const cteSTreqEntregada As String = "ENTREG"
    Public Const cteSTreqCancelada As String = "CANCEL"

    'Estatus extra de requisiciones de material
    Public Const cteSTreqPrestada As String = "PRESTA"
    Public Const cteSTreqDevuelta As String = "DEVUEL"

    'tIPOS DE USUARIO
    Public Const cteTUAlmacenista As String = "ALM"

    'Constantes de tipo de documentos
    Public Const ctrTDRequi As String = "REQUI"

    'Constantes de estado de articulos
    Public Const cteSTAactivo As String = "AST001"
    Public Const cteSTAInactivo As String = "AST002"

End Class

Public Class ManejoNulls
    Public Shared Function ManageNullStr(ByVal aValue As System.Object) As String
        If IsDBNull(aValue) Then
            Return String.Empty
        Else
            Return CStr(aValue)
        End If
    End Function

    Public Shared Function ManageNullLng(ByVal aValue As System.Object) As Long
        If IsDBNull(aValue) Then
            Return Nothing
        Else
            Return CLng(aValue)
        End If
    End Function

#Region "  Date Time  "
    Public Function MonthShort() As String
        Dim TodayDate As String = Now.Day & ShortMonth() & ShortYear()
        Return (TodayDate)
    End Function

    Function ShortMonth() As String
        Dim sMonth As String = ""
        'set new month values
        If Now.Month = 1 Then
            sMonth = "ENE"
        ElseIf Now.Month = 2 Then
            sMonth = "FEB"
        ElseIf Now.Month = 3 Then
            sMonth = "MAR"
        ElseIf Now.Month = 4 Then
            sMonth = "ABR"
        ElseIf Now.Month = 5 Then
            sMonth = "MAY"
        ElseIf Now.Month = 6 Then
            sMonth = "JUN"
        ElseIf Now.Month = 7 Then
            sMonth = "JUL"
        ElseIf Now.Month = 8 Then
            sMonth = "AGO"
        ElseIf Now.Month = 9 Then
            sMonth = "SEP"
        ElseIf Now.Month = 10 Then
            sMonth = "OCT"
        ElseIf Now.Month = 11 Then
            sMonth = "NOV"
        ElseIf Now.Month = 12 Then
            sMonth = "DIC"
        End If
        Return (sMonth)
    End Function

    Function ShortYear() As String
        Dim sYear As String = CStr(Now.Year())
        Return (sYear.Substring(2, 2))
    End Function

#End Region

End Class

