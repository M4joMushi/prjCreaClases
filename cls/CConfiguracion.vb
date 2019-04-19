Imports System.IO

'Estas clases leen parejas de valores del archivo de configuraciones
'un archivo .ini en él directorio de ejecución del programa

Public Class CConfiguracion
    Private strEtiqueta As String
    Private strValor As String

    Public Property Etiqueta() As String
        Get
            Return strEtiqueta
        End Get
        Set(ByVal Value As String)
            strEtiqueta = Value
        End Set
    End Property

    Public Property Valor() As String
        Get
            Return strValor
        End Get
        Set(ByVal Value As String)
            strValor = Value
        End Set
    End Property
End Class

Public Class CConfiguraciones
    Inherits CollectionBase


#Region "Métodos Publicos"

    Public Sub New()
        MyBase.New()
    End Sub

    'Agrega el método Agregar
    Public Function Agregar(ByVal objBase As CConfiguracion) As Integer
        Return InnerList.Add(objBase)
    End Function

    Public Function Valor(ByVal strEtiqueta As String) As String
        For Each objBase As CConfiguracion In Me
            If objBase.Etiqueta = strEtiqueta Then Return objBase.Valor
        Next
        Return ""
    End Function

    Public Function Leer(ByVal strArchivo As String) As Boolean
        ' The StreamReader must be defined outside of the Try-Catch block
        '   in order to reference it in the Finally block.
        Dim myStreamReader As StreamReader = Nothing
        Dim myInputString As String
        Dim objBase As CConfiguracion
        Dim arrValores() As String

        ' Ensure that the creation of the new StreamReader is wrapped in a 
        '   Try-Catch block, since an invalid filename could have been used.
        Try
            ' Create a StreamReader using a Shared (static) File class.
            myStreamReader = File.OpenText(strArchivo)

            ' Begin by reading a single line
            myInputString = myStreamReader.ReadLine()
            ' Continue reading while there are still lines to be read
            While Not myInputString Is Nothing
                ' Output the text with a line number
                objBase = New CConfiguracion
                arrValores = Split(myInputString, "=")

                With objBase
                    .Etiqueta = arrValores(0)
                    .Valor = arrValores(1)
                End With

                Me.Agregar(objBase)

                ' Read the next line.
                myInputString = myStreamReader.ReadLine()
            End While
        Catch exc As Exception
        Finally
            ' Close the object if it has been created.
            If Not myStreamReader Is Nothing Then
                myStreamReader.Close()
            End If
        End Try
    End Function

#End Region


End Class
