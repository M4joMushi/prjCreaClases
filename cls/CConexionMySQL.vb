Imports System.IO
Imports MySql.Data
'Imports System.Environment

Public Class CConexionMySQL

    Private sDatabase As String
    Private sServer As String
    Private sUserID As String
    Private sPassword As String
    Private sConnectionString As String
    Private cnn As MySqlClient.MySqlConnection
    Private objConfiguraciones As CConfiguraciones


    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    Public ReadOnly Property Conexion() As MySqlClient.MySqlConnection
        Get
            Return cnn
        End Get
    End Property


    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    Private Sub BuildConnectionString()
        '*************************************************
        ' BUILD THE CONNECTION STRING
        'Provider=MySQLProv;Data Source=Your_MySQL_Database;User Id=Your_Username; Password=Your_Password;" 
        '*************************************************

        sConnectionString = "" '"Provider=MySQLProv;"
        sConnectionString &= "server=" + sServer.ToString + ";"
        sConnectionString &= "database=" + sDatabase.ToString + ";"
        sConnectionString &= "User ID=" + sUserID.ToString + ";"
        sConnectionString &= "Password=" + Trim(sPassword.ToString) + ";"

    End Sub

    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    Public Sub New(ByVal strRuta As String)

        objConfiguraciones = New CConfiguraciones
        objConfiguraciones.Leer(strRuta & "mysqlschema.ini")


        sServer = objConfiguraciones.Valor("server")
        sUserID = objConfiguraciones.Valor("user")
        sPassword = CEncriptado.Desencripta(objConfiguraciones.Valor("password"))
        sDatabase = objConfiguraciones.Valor("db")

        BuildConnectionString()
        objConfiguraciones = Nothing
    End Sub

    Public Sub New(ByVal strUser As String, _
        ByVal strPass As String, _
        ByVal strDB As String, _
        ByVal strServer As String)

        sServer = strServer
        sUserID = strUser
        sPassword = strPass
        sDatabase = strDB

        BuildConnectionString()
    End Sub

    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    '**********************************************************************************
    Public Function ConnectToDatabase() As Boolean
        '*************************************************
        ' CONNECT TO THE DATABASE
        '*************************************************
        Try
            If Not cnn Is Nothing Then
                If cnn.State = ConnectionState.Open Then Return True
            Else
                cnn = New MySqlClient.MySqlConnection(sConnectionString)
            End If

            cnn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


    Protected Overrides Sub Finalize()
        Try
            If Not cnn Is Nothing And Not cnn.State = ConnectionState.Closed Then
                cnn.Close()
            End If
            cnn.Dispose()
            MyBase.Finalize()
        Catch ex As Exception

        End Try
    End Sub

    Public Function ActualizarBD(ByVal strCmd As String) As Boolean
        Dim cmdAccion As New MySqlClient.MySqlCommand
        cmdAccion.Connection = Me.Conexion
        cmdAccion.CommandText = strCmd
        cmdAccion.CommandType = CommandType.Text

        Try
            cmdAccion.ExecuteNonQuery()
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Public Function Consulta(ByVal _strSQL As String, ByVal _strNombreTabla As String, ByVal _dstDatos As DataSet) As Boolean
        Dim da As New MySqlClient.MySqlDataAdapter
        Try
            da = New MySqlClient.MySqlDataAdapter(_strSQL, Me.Conexion)
            da.Fill(_dstDatos, _strNombreTabla)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
