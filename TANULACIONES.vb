Namespace Manejo_Tablas
    Namespace A
        <System.Diagnostics.DebuggerStepThrough()> _
        Public Class TANULACIONES

#Region "Miembros"

            Dim DA As MySqlDataAdapter = Nothing
            Dim DS As DataSet = Nothing
            Dim POS_DS As Integer
            Dim Lista() As DataRow = Nothing

            Enum Tipo_Indices
                PRIMARY
                Ninguno
            End Enum

            <Serializable()> Public Structure ANULACIONES
                Dim Simon_REGISTRO As Boolean
                Dim MERROR As String
                Dim ANUL_EMPRESA As String
                Dim ANUL_TIENDA As String
                Dim ANUL_CAJA As Integer
                Dim ANUL_TIPO As String
                Dim ANUL_CORRELATIVO As Integer
                Dim ANUL_NUMERO As Integer
                Dim ANUL_SERIE As String
                Dim ANUL_MONTO As Decimal
                Dim ANUL_FECHA As MySqlDateTime
                Dim ANUL_USUARIO As String
                Dim ANUL_SUPERVISOR As String
                Dim ANUL_CAUSA As String
                Dim ANUL_CORTE_Z As Integer
                Dim ESCRITURA As MySqlDateTime
                <System.Diagnostics.DebuggerStepThrough()> _
                Sub ReSet(Optional Tipo_ReSet As Definicion.ReSet_Struc = Definicion.ReSet_Struc.Total)
                    If Tipo_ReSet = Definicion.ReSet_Struc.Total OrElse Tipo_ReSet = Definicion.ReSet_Struc.Llave Then
                        ANUL_EMPRESA = ""
                        ANUL_TIENDA = ""
                        ANUL_CAJA = 0
                        ANUL_TIPO = ""
                        ANUL_CORRELATIVO = 0
                    End If
                    If Tipo_ReSet = Definicion.ReSet_Struc.Total OrElse Tipo_ReSet = Definicion.ReSet_Struc.No_Llave Then
                        ANUL_NUMERO = 0
                        ANUL_SERIE = ""
                        ANUL_MONTO = 0
                        ANUL_FECHA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
                        ANUL_USUARIO = ""
                        ANUL_SUPERVISOR = ""
                        ANUL_CAUSA = ""
                        ANUL_CORTE_Z = 0
                        ESCRITURA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
                    End If
                End Sub
                <System.Diagnostics.DebuggerStepThrough()> _
                Public Overrides Function GetHashCode() As Integer
                    Try
                        Return ANUL_EMPRESA.GetHashCode Xor _
                        ANUL_TIENDA.GetHashCode Xor _
                        ANUL_CAJA.GetHashCode Xor _
                        ANUL_TIPO.GetHashCode Xor _
                        ANUL_CORRELATIVO.GetHashCode Xor _
                        ANUL_NUMERO.GetHashCode Xor _
                        ANUL_SERIE.GetHashCode Xor _
                        ANUL_MONTO.GetHashCode Xor _
                        ANUL_FECHA.GetHashCode Xor _
                        ANUL_USUARIO.GetHashCode Xor _
                        ANUL_SUPERVISOR.GetHashCode Xor _
                        ANUL_CAUSA.GetHashCode Xor _
                        ANUL_CORTE_Z.GetHashCode
                    Catch ex As Exception
                        Throw New System.Exception("Error Calculando HashCode", ex)
                    End Try
                End Function
            End Structure

            Private m_str_ANUL_EMPRESA As String
            Private m_str_ANUL_TIENDA As String
            Private m_int_ANUL_CAJA As Integer
            Private m_str_ANUL_TIPO As String
            Private m_int_ANUL_CORRELATIVO As Integer
            Private m_int_ANUL_NUMERO As Integer
            Private m_str_ANUL_SERIE As String
            Private m_dec_ANUL_MONTO As Decimal
            Private m_dt_ANUL_FECHA As MySqlDateTime
            Private m_str_ANUL_USUARIO As String
            Private m_str_ANUL_SUPERVISOR As String
            Private m_str_ANUL_CAUSA As String
            Private m_int_ANUL_CORTE_Z As Integer
            Private m_dt_ESCRITURA As MySqlDateTime
            Private MENSAJE As String
            Private Cantidad_de_la_Clase As Integer = 0
            Private CON As MySqlConnection
            Private TRA As MySqlTransaction
            Private CONstr As String
            Dim _Usar_Transaccion_Select As Boolean = False
            Dim _TimeOut As Integer = 30

#End Region

#Region "Propiedades"

            Public Property ANUL_EMPRESA() As String
                Get
                    Return m_str_ANUL_EMPRESA.Trim()
                End Get
                Set(ByVal Value As String)
                    m_str_ANUL_EMPRESA = Value
                End Set
            End Property

            Public Property ANUL_TIENDA() As String
                Get
                    Return m_str_ANUL_TIENDA.Trim()
                End Get
                Set(ByVal Value As String)
                    m_str_ANUL_TIENDA = Value
                End Set
            End Property

            Public Property ANUL_CAJA() As Integer
                Get
                    Return m_int_ANUL_CAJA
                End Get
                Set(ByVal Value As Integer)
                    m_int_ANUL_CAJA = Value
                End Set
            End Property

            Public Property ANUL_TIPO() As String
                Get
                    Return m_str_ANUL_TIPO.Trim()
                End Get
                Set(ByVal Value As String)
                    m_str_ANUL_TIPO = Value
                End Set
            End Property

            Public Property ANUL_CORRELATIVO() As Integer
                Get
                    Return m_int_ANUL_CORRELATIVO
                End Get
                Set(ByVal Value As Integer)
                    m_int_ANUL_CORRELATIVO = Value
                End Set
            End Property

            Public Property ANUL_NUMERO() As Integer
                Get
                    Return m_int_ANUL_NUMERO
                End Get
                Set(ByVal Value As Integer)
                    m_int_ANUL_NUMERO = Value
                End Set
            End Property

            Public Property ANUL_SERIE() As String
                Get
                    Return m_str_ANUL_SERIE.Trim()
                End Get
                Set(ByVal Value As String)
                    m_str_ANUL_SERIE = Value
                End Set
            End Property

            Public Property ANUL_MONTO() As Decimal
                Get
                    Return m_dec_ANUL_MONTO
                End Get
                Set(ByVal Value As Decimal)
                    m_dec_ANUL_MONTO = Value
                End Set
            End Property

            Public Property ANUL_FECHA() As MySqlDateTime
                Get
                    Return m_dt_ANUL_FECHA
                End Get
                Set(ByVal Value As MySqlDateTime)
                    m_dt_ANUL_FECHA = Value
                End Set
            End Property

            Public WriteOnly Property ANUL_FECHA_NET() As DateTime
                Set(ByVal Value As DateTime)
                    m_dt_ANUL_FECHA = New MySqlDateTime(Value)
                End Set
            End Property

            Public Property ANUL_USUARIO() As String
                Get
                    Return m_str_ANUL_USUARIO.Trim()
                End Get
                Set(ByVal Value As String)
                    m_str_ANUL_USUARIO = Value
                End Set
            End Property

            Public Property ANUL_SUPERVISOR() As String
                Get
                    Return m_str_ANUL_SUPERVISOR.Trim()
                End Get
                Set(ByVal Value As String)
                    m_str_ANUL_SUPERVISOR = Value
                End Set
            End Property

            Public Property ANUL_CAUSA() As String
                Get
                    Return m_str_ANUL_CAUSA.Trim()
                End Get
                Set(ByVal Value As String)
                    m_str_ANUL_CAUSA = Value
                End Set
            End Property

            Public Property ANUL_CORTE_Z() As Integer
                Get
                    Return m_int_ANUL_CORTE_Z
                End Get
                Set(ByVal Value As Integer)
                    m_int_ANUL_CORTE_Z = Value
                End Set
            End Property

            Public Property ESCRITURA() As MySqlDateTime
                Get
                    Return m_dt_ESCRITURA
                End Get
                Set(ByVal Value As MySqlDateTime)
                    m_dt_ESCRITURA = Value
                End Set
            End Property

            Public WriteOnly Property ESCRITURA_NET() As DateTime
                Set(ByVal Value As DateTime)
                    m_dt_ESCRITURA = New MySqlDateTime(Value)
                End Set
            End Property

            Public ReadOnly Property CantRecorSet() As Integer
                Get
                    Return Cantidad_de_la_Clase
                End Get
            End Property

            Public Property CONEXION() As String
                Set(ByVal VALUE As String)
                    CONstr = VALUE
                    Try
                        MENSAJE = ""
                        Dim Status As Tipo_Status_Ping = Verifica_PING(VALUE)
                        If Status <> Tipo_Status_Ping.OK Then
                            MENSAJE = "BiblioTABLAS - TANULACIONES - CONEXION No se logro hacer pineo a Servidor Error:" & _
                                      Status.ToString
                            Throw New System.Exception("Error. No se logro hacer pineo a Servidor" & vbNewLine & _
                                                       "Conexión:" & VALUE & vbNewLine & "Error:" & Status.ToString)
                            Exit Property
                        End If
                        If IsNothing(CON) Then CON = New MySqlConnection
                        If CON.State = ConnectionState.Open Then CON.Close()
                        CON.ConnectionString = CONstr
                        CON.Open()
                    Catch MyEX As MySqlException
                        MENSAJE = "BiblioTABLAS - TANULACIONES - CONEXION MyError=" & MyEX.ToString
                        Throw New System.Exception("MySQLError#:" & MyEX.Number.ToString("0000") & " Error MySQL Conectando con Servidor" & vbNewLine & "Conexión:" & VALUE, MyEX)
                    Catch EX As Exception
                        MENSAJE = "BiblioTABLAS - TANULACIONES - CONEXION Error=" & EX.ToString
                        Throw New System.Exception("Error no contemplado Conectando Servidor" & vbNewLine & "Conexión:" & VALUE, EX)
                    End Try
                End Set
                Get
                    Return CONstr
                End Get
            End Property

            Public WriteOnly Property TRANSACCION() As MySqlTransaction
                Set(ByVal VALUE As MySqlTransaction)
                    TRA = VALUE
                    _Usar_Transaccion_Select = False
                    If Not IsNothing(VALUE) Then _Usar_Transaccion_Select = True
                End Set
            End Property

            Public ReadOnly Property MERROR() As String
                Get
                    Return MENSAJE
                End Get
            End Property

            Public Property Usar_Transaccion_Select As Boolean
                Get
                    Return _Usar_Transaccion_Select
                End Get
                Set(ByVal Value As Boolean)
                    _Usar_Transaccion_Select = Value
                End Set
            End Property

            Public Property TimeOut() As Integer
                Get
                    Return _TimeOut
                End Get
                Set(ByVal Value As Integer)
                    _TimeOut = Value
                End Set
            End Property

#End Region

#Region "Funciones Publicas"

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Sub New()
                ANUL_EMPRESA = ""
                ANUL_TIENDA = ""
                ANUL_CAJA = 0
                ANUL_TIPO = ""
                ANUL_CORRELATIVO = 0
                ANUL_NUMERO = 0
                ANUL_SERIE = ""
                ANUL_MONTO = 0
                ANUL_FECHA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
                ANUL_USUARIO = ""
                ANUL_SUPERVISOR = ""
                ANUL_CAUSA = ""
                ANUL_CORTE_Z = 0
                ESCRITURA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
            End Sub

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Sub Reset(Optional ByVal Tipo As Definicion.TipoReset = Definicion.TipoReset.Data)
                Try
                    MENSAJE = ""
                    _Usar_Transaccion_Select = False
                    INIT_LLAVE()
                    INIT()
                    If Tipo = Definicion.TipoReset.Full Then Dispose()
                    Cantidad_de_la_Clase = 0
                Catch Ex As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - RESET No se pudo hacer el Reset de la Clase" & Ex.ToString
                    Throw New System.Exception("Error no Contemplado", Ex)
                Finally
                    System.GC.Collect()
                End Try
            End Sub

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Sub Dispose()
                Try
                    If Not IsNothing(CON) Then
                        If CON.State = ConnectionState.Open Then CON.Close()
                        CON.Dispose()
                        CON = Nothing
                    End If
                    Lista = Nothing

                    If Not IsNothing(DA) Then DA.Dispose()
                    DA = Nothing

                    If Not IsNothing(DS) Then
                        DS.Clear()
                        DS.Dispose()
                        DS = Nothing
                    End If

                    _Usar_Transaccion_Select = False
                    TRA = Nothing
                Catch EX As Exception
                End Try
            End Sub

            <System.Diagnostics.DebuggerStepThrough()> _
            Private Sub INIT()
                ANUL_NUMERO = 0
                ANUL_SERIE = ""
                ANUL_MONTO = 0
                ANUL_FECHA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
                ANUL_USUARIO = ""
                ANUL_SUPERVISOR = ""
                ANUL_CAUSA = ""
                ANUL_CORTE_Z = 0
                ESCRITURA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
            End Sub

            <System.Diagnostics.DebuggerStepThrough()> _
            Private Sub INIT_LLAVE()
                ANUL_EMPRESA = ""
                ANUL_TIENDA = ""
                ANUL_CAJA = 0
                ANUL_TIPO = ""
                ANUL_CORRELATIVO = 0
            End Sub

            <System.Diagnostics.DebuggerStepThrough()> _
            Private Function Pone_Valores_Internos(REA_Local As MySqlDataReader) As Boolean
                Pone_Valores_Internos = False
                Try
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_EMPRESA")) Then
                        m_str_ANUL_EMPRESA = REA_Local.GetString("ANUL_EMPRESA")
                    Else
                        m_str_ANUL_EMPRESA = "NULL"
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_TIENDA")) Then
                        m_str_ANUL_TIENDA = REA_Local.GetString("ANUL_TIENDA")
                    Else
                        m_str_ANUL_TIENDA = "NULL"
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_CAJA")) Then
                        m_int_ANUL_CAJA = REA_Local.GetInt32("ANUL_CAJA")
                    Else
                        m_int_ANUL_CAJA = -1
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_TIPO")) Then
                        m_str_ANUL_TIPO = REA_Local.GetString("ANUL_TIPO")
                    Else
                        m_str_ANUL_TIPO = "NULL"
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_CORRELATIVO")) Then
                        m_int_ANUL_CORRELATIVO = REA_Local.GetInt32("ANUL_CORRELATIVO")
                    Else
                        m_int_ANUL_CORRELATIVO = -1
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_NUMERO")) Then
                        m_int_ANUL_NUMERO = REA_Local.GetInt32("ANUL_NUMERO")
                    Else
                        m_int_ANUL_NUMERO = -1
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_SERIE")) Then
                        m_str_ANUL_SERIE = REA_Local.GetString("ANUL_SERIE")
                    Else
                        m_str_ANUL_SERIE = "NULL"
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_MONTO")) Then
                        m_dec_ANUL_MONTO = REA_Local.GetDecimal("ANUL_MONTO")
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_FECHA")) Then
                        m_dt_ANUL_FECHA = REA_Local.GetMySqlDateTime("ANUL_FECHA")
                        If Not m_dt_ANUL_FECHA.IsValidDateTime Then
                            If m_dt_ANUL_FECHA.ToString = "0000-00-00 00:00:00" Then
                                m_dt_ANUL_FECHA = New MySqlDateTime(1900, 1, 1, 0, 0, 0, 0)
                            End If
                        End If
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_USUARIO")) Then
                        m_str_ANUL_USUARIO = REA_Local.GetString("ANUL_USUARIO")
                    Else
                        m_str_ANUL_USUARIO = "NULL"
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_SUPERVISOR")) Then
                        m_str_ANUL_SUPERVISOR = REA_Local.GetString("ANUL_SUPERVISOR")
                    Else
                        m_str_ANUL_SUPERVISOR = "NULL"
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_CAUSA")) Then
                        m_str_ANUL_CAUSA = REA_Local.GetString("ANUL_CAUSA")
                    Else
                        m_str_ANUL_CAUSA = "NULL"
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ANUL_CORTE_Z")) Then
                        m_int_ANUL_CORTE_Z = REA_Local.GetInt32("ANUL_CORTE_Z")
                    Else
                        m_int_ANUL_CORTE_Z = -1
                    End If
                    If Not REA_Local.IsDBNull(REA_Local.GetOrdinal("ESCRITURA")) Then
                        m_dt_ESCRITURA = REA_Local.GetMySqlDateTime("ESCRITURA")
                        If Not m_dt_ESCRITURA.IsValidDateTime Then
                            If m_dt_ESCRITURA.ToString = "0000-00-00 00:00:00" Then
                                m_dt_ESCRITURA = New MySqlDateTime(1900, 1, 1, 0, 0, 0, 0)
                            End If
                        End If
                    End If
                    Pone_Valores_Internos = True
                Catch EX As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - Pone_Valores_Internos Error=" & EX.ToString
                    Throw New System.Exception("Error No Contemplado", EX)
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Private Function Pone_Valores_Internos(R As DataRow) As Boolean
                Pone_Valores_Internos = False
                Try
                    If Not IsDBNull(R.Item("ANUL_EMPRESA")) Then
                        m_str_ANUL_EMPRESA = CType(R.Item("ANUL_EMPRESA"), String)
                    Else
                        m_str_ANUL_EMPRESA = "NULL"
                    End If
                    If Not IsDBNull(R.Item("ANUL_TIENDA")) Then
                        m_str_ANUL_TIENDA = CType(R.Item("ANUL_TIENDA"), String)
                    Else
                        m_str_ANUL_TIENDA = "NULL"
                    End If
                    If Not IsDBNull(R.Item("ANUL_CAJA")) Then
                        m_int_ANUL_CAJA = CType(R.Item("ANUL_CAJA"), Integer)
                    Else
                        m_int_ANUL_CAJA = -1
                    End If
                    If Not IsDBNull(R.Item("ANUL_TIPO")) Then
                        m_str_ANUL_TIPO = CType(R.Item("ANUL_TIPO"), String)
                    Else
                        m_str_ANUL_TIPO = "NULL"
                    End If
                    If Not IsDBNull(R.Item("ANUL_CORRELATIVO")) Then
                        m_int_ANUL_CORRELATIVO = CType(R.Item("ANUL_CORRELATIVO"), Integer)
                    Else
                        m_int_ANUL_CORRELATIVO = -1
                    End If
                    If Not IsDBNull(R.Item("ANUL_NUMERO")) Then
                        m_int_ANUL_NUMERO = CType(R.Item("ANUL_NUMERO"), Integer)
                    Else
                        m_int_ANUL_NUMERO = -1
                    End If
                    If Not IsDBNull(R.Item("ANUL_SERIE")) Then
                        m_str_ANUL_SERIE = CType(R.Item("ANUL_SERIE"), String)
                    Else
                        m_str_ANUL_SERIE = "NULL"
                    End If
                    If Not IsDBNull(R.Item("ANUL_MONTO")) Then
                        m_dec_ANUL_MONTO = CType(R.Item("ANUL_MONTO"), Decimal)
                    End If
                    If Not IsDBNull(R.Item("ANUL_FECHA")) Then
                        m_dt_ANUL_FECHA = CType(R.Item("ANUL_FECHA"), MySqlDateTime)
                        If Not m_dt_ANUL_FECHA.IsValidDateTime Then
                            If m_dt_ANUL_FECHA.ToString = "0000-00-00 00:00:00" Then
                                m_dt_ANUL_FECHA = New MySqlDateTime(1900, 1, 1, 0, 0, 0, 0)
                            End If
                        End If
                    End If
                    If Not IsDBNull(R.Item("ANUL_USUARIO")) Then
                        m_str_ANUL_USUARIO = CType(R.Item("ANUL_USUARIO"), String)
                    Else
                        m_str_ANUL_USUARIO = "NULL"
                    End If
                    If Not IsDBNull(R.Item("ANUL_SUPERVISOR")) Then
                        m_str_ANUL_SUPERVISOR = CType(R.Item("ANUL_SUPERVISOR"), String)
                    Else
                        m_str_ANUL_SUPERVISOR = "NULL"
                    End If
                    If Not IsDBNull(R.Item("ANUL_CAUSA")) Then
                        m_str_ANUL_CAUSA = CType(R.Item("ANUL_CAUSA"), String)
                    Else
                        m_str_ANUL_CAUSA = "NULL"
                    End If
                    If Not IsDBNull(R.Item("ANUL_CORTE_Z")) Then
                        m_int_ANUL_CORTE_Z = CType(R.Item("ANUL_CORTE_Z"), Integer)
                    Else
                        m_int_ANUL_CORTE_Z = -1
                    End If
                    If Not IsDBNull(R.Item("ESCRITURA")) Then
                        m_dt_ESCRITURA = CType(R.Item("ESCRITURA"), MySqlDateTime)
                        If Not m_dt_ESCRITURA.IsValidDateTime Then
                            If m_dt_ESCRITURA.ToString = "0000-00-00 00:00:00" Then
                                m_dt_ESCRITURA = New MySqlDateTime(1900, 1, 1, 0, 0, 0, 0)
                            End If
                        End If
                    End If
                    Pone_Valores_Internos = True
                Catch EX As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - Pone_Valores_Internos Error=" & EX.ToString
                    Throw New System.Exception("Error No Contemplado", EX)
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PMOVE_NEXT() As Boolean
                PMOVE_NEXT = False
                Try
                    MENSAJE = ""
                    INIT()
                    INIT_LLAVE()
                    If IsNothing(DA) Then
                        MENSAJE = "BiblioTABLAS - TANULACIONES - PMOVE_NEXT DataAdapter no definido."
                        Throw New System.Exception("Para ejecutar el PMOVE_NEXT, antes tiene que ejecutar PSELECT_RECORDSET")
                        Exit Function
                    End If
                    If IsNothing(DS) Then
                        MENSAJE = "BiblioTABLAS - TANULACIONES - PMOVE_NEXT DataSet no definido."
                        Throw New System.Exception("Para ejecutar el PMOVE_NEXT, antes tiene que ejecutar PSELECT_RECORDSET")
                        Exit Function
                    End If

                    If IsNothing(Lista) Then Exit Function

                    If POS_DS <= Lista.Length - 1 Then
                        Pone_Valores_Internos(Lista(POS_DS))
                        POS_DS += 1
                        PMOVE_NEXT = True
                    Else
                        Lista = Nothing
                        Exit Function
                    End If
                Catch EX As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PMOVE_NEXT Error=" & EX.ToString
                    Throw New System.Exception("BiblioTablas - TANULACIONES - PMOVE_NEXT, Error no contemplado.", EX)
                Finally
                    System.GC.Collect()
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PSUB_SELECT(ByVal condicion As String, Optional ByVal Ordenamiento As String = "") As Boolean
                PSUB_SELECT = False
                Try
                    Lista = Nothing
                    If IsNothing(DS) Then
                        MENSAJE = "BiblioTABLAS - TANULACIONES - PSUB_SELECT Error=Tiene que hacer un PSelect_Recordset para hacer un PSub_Select"
                        Throw New System.Exception("Tiene que hacer un PSELECT_RECORDSET para hacer un PSUB_SELECT")
                    End If

                    If Ordenamiento.Length <> 0 Then
                        Lista = DS.Tables("anulaciones").Select(condicion, Ordenamiento)
                    Else
                        Lista = DS.Tables("anulaciones").Select(condicion)
                    End If
                    POS_DS = 0
                    Cantidad_de_la_Clase = 0
                    If Not IsNothing(Lista) Then Cantidad_de_la_Clase = Lista.Length
                    If Cantidad_de_la_Clase <> 0 Then Return True
                Catch ex As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSUB_SELECT Error=" & ex.ToString
                    Throw New System.Exception("Error no contemplado Condición:" & condicion & vbNewLine & "Ordenamiento:" & Ordenamiento, ex)
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PSELECT_RECORDSET(Optional ByVal CONDICION As String = "",
                                              Optional ByVal ORDENAMIENTO As String = "",
                                              Optional ByVal Solo_Contar As Boolean = False,
                                              Optional ByVal Indice As Tipo_Indices = Tipo_Indices.Ninguno) As Boolean
                Dim SQL As String

                PSELECT_RECORDSET = False
                MENSAJE = ""

                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Lectura)

                If Not IsNothing(DS) Then
                    DS.Clear()
                    DS.Dispose()
                    DS = Nothing
                End If
                DS = New DataSet()

                If Not IsNothing(DA) Then
                    DA.Dispose()
                    DA = Nothing
                End If

                If Indice <> Tipo_Indices.Ninguno Then
                    SQL = "Select * from anulaciones use index(" & Indice.ToString & ")"
                Else
                    SQL = "Select * from anulaciones"
                End If
                If CONDICION.Length <> 0 Then SQL &= " Where " & CONDICION
                If ORDENAMIENTO.Length <> 0 Then SQL &= " Order By " & ORDENAMIENTO

                Try
                    INIT()
                    INIT_LLAVE()
                    If _Usar_Transaccion_Select Then
                        DA = New MySqlDataAdapter(SQL, TRA.Connection)
                    Else
                        DA = New MySqlDataAdapter(SQL, CON)
                    End If
                    Cantidad_de_la_Clase = DA.Fill(DS, "anulaciones")
                    Lista = DS.Tables("anulaciones").Select()
                    POS_DS = 0

                    If Cantidad_de_la_Clase <> 0 Then PSELECT_RECORDSET = True
                Catch MYEX As MySqlException
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT_RECORDSET MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL Condición:" & CONDICION & vbNewLine & "Ordenamiento:" & ORDENAMIENTO, MYEX)
                Catch EX As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT_RECORDSET Error=" & EX.ToString
                    Throw New System.Exception("Error no contemplado Condición:" & CONDICION & vbNewLine & "Ordenamiento:" & ORDENAMIENTO, EX)
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PSELECT(ByVal KANUL_EMPRESA As String, ByVal KANUL_TIENDA As String, ByVal KANUL_CAJA As Integer, ByVal KANUL_TIPO As String, ByVal KANUL_CORRELATIVO As Integer) As Boolean
                Dim READER As MySqlDataReader
                Dim COM As MySqlCommand
                Dim SQL As String

                MENSAJE = ""
                PSELECT = False

                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Lectura)

                SQL = "SELECT * FROM anulaciones WHERE ANUL_EMPRESA = ?P1 AND ANUL_TIENDA = ?P2 AND ANUL_CAJA = ?P3 AND ANUL_TIPO = ?P4 AND ANUL_CORRELATIVO = ?P5"
                READER = Nothing
                COM = Nothing
                Try
                    INIT()
                    If _Usar_Transaccion_Select Then
                        COM = New MySqlCommand(SQL, TRA.Connection, TRA)
                    Else
                        COM = New MySqlCommand(SQL, CON)
                    End If
                    COM.CommandType = CommandType.Text
                    COM.CommandTimeout = _TimeOut
                    COM.Parameters.AddWithValue("?P1", KANUL_EMPRESA)
                    COM.Parameters.AddWithValue("?P2", KANUL_TIENDA)
                    COM.Parameters.AddWithValue("?P3", KANUL_CAJA)
                    COM.Parameters.AddWithValue("?P4", KANUL_TIPO)
                    COM.Parameters.AddWithValue("?P5", KANUL_CORRELATIVO)
                    READER = COM.ExecuteReader(CommandBehavior.SingleRow)
                    READER.Read()
                    If Not READER.HasRows Then
                        MENSAJE = ""
                        PSELECT = False
                        Exit Function
                    End If

                    PSELECT = Pone_Valores_Internos(READER)

                Catch MYEX As MySqlException
                    Dim tt As String = "Llave:" & KANUL_EMPRESA & "-" & KANUL_TIENDA & "-" & KANUL_CAJA & "-" & KANUL_TIPO & "-" & KANUL_CORRELATIVO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. " & tt, MYEX)
                Catch EX As Exception
                    Dim tt As String = "Llave:" & KANUL_EMPRESA & "-" & KANUL_TIENDA & "-" & KANUL_CAJA & "-" & KANUL_TIPO & "-" & KANUL_CORRELATIVO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT Error=" & EX.ToString
                    Throw New System.Exception("Error no Contemplado. " & tt, EX)
                Finally
                    If Not IsNothing(READER) Then
                        READER.Close()
                        READER = Nothing
                    End If
                    If Not IsNothing(COM) Then
                        COM.Dispose()
                        COM = Nothing
                    End If
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PSELECT_CONDICION(ByVal CONDICION As String, Optional ByVal Indice As Tipo_Indices = Tipo_Indices.Ninguno) As Boolean
                Dim READER As MySqlDataReader
                Dim COM As MySqlCommand
                Dim SQL As String

                MENSAJE = ""
                PSELECT_CONDICION = False

                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Lectura)

                If Indice <> Tipo_Indices.Ninguno Then
                    SQL = "SELECT * FROM anulaciones use index(" & Indice.ToString & ") WHERE " & CONDICION
                Else
                    SQL = "SELECT * FROM anulaciones WHERE " & CONDICION
                End If
                READER = Nothing
                COM = Nothing
                Try
                    INIT()
                    INIT_LLAVE()
                    If _Usar_Transaccion_Select Then
                        COM = New MySqlCommand(SQL, TRA.Connection, TRA)
                    Else
                        COM = New MySqlCommand(SQL, CON)
                    End If
                    COM.CommandType = CommandType.Text
                    COM.CommandTimeout = _TimeOut
                    READER = COM.ExecuteReader(CommandBehavior.SingleRow)
                    READER.Read()
                    If Not READER.HasRows Then
                        MENSAJE = ""
                        PSELECT_CONDICION = False
                        Exit Function
                    End If

                    PSELECT_CONDICION = Pone_Valores_Internos(READER)

                Catch MYEX As MySqlException
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT_CONDICION MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. Condición:" & CONDICION, MYEX)
                Catch EX As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT_CONDICION Error=" & EX.ToString
                    Throw New System.Exception("Error no contemplado. Condición:" & CONDICION, EX)
                Finally
                    If Not IsNothing(READER) Then
                        READER.Close()
                        READER = Nothing
                    End If
                    If Not IsNothing(COM) Then
                        COM.Dispose()
                        COM = Nothing
                    End If
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PSELECT_DATASET(ByRef DataS As DataSet,
                Optional ByVal CAMPOS As String = "",
                Optional ByVal CONDICION As String = "",
                Optional ByVal ORDENAMIENTO As String = "",
                Optional ByVal INDICE As Tipo_Indices = Tipo_Indices.Ninguno) As Boolean

                Dim DataA As MySqlDataAdapter = Nothing
                Dim SQL As String

                PSELECT_DATASET = False

                If Not IsNothing(DataS) Then
                    DataS.Clear()
                    DataS.Dispose()
                    DataS = Nothing
                End If
                DataS = New DataSet()

                If CAMPOS.Length <> 0 Then
                    If INDICE <> Tipo_Indices.Ninguno Then
                        SQL = "Select " & CAMPOS & " from definicion_empleados use index(" & INDICE.ToString & ")"
                    Else
                        SQL = "Select " & CAMPOS & " from definicion_empleados"
                    End If
                Else
                    If INDICE <> Tipo_Indices.Ninguno Then
                        SQL = "Select * from definicion_empleados use index(" & INDICE.ToString & ")"
                    Else
                        SQL = "Select * from definicion_empleados"
                    End If
                End If
                If CONDICION.Length <> 0 Then SQL &= " Where " & CONDICION
                If ORDENAMIENTO.Length <> 0 Then SQL &= " Order By " & ORDENAMIENTO
                Cantidad_de_la_Clase = 0

                Try
                    If _Usar_Transaccion_Select Then
                        DataA = New MySqlDataAdapter(SQL, TRA.Connection)
                    Else
                        DataA = New MySqlDataAdapter(SQL, CON)
                    End If
                    Cantidad_de_la_Clase = DataA.Fill(DataS, "anulaciones")
                    Return True
                Catch MYEX As MySqlException
                    Dim tt As String = vbNewLine & "Campos:" & CAMPOS & vbNewLine &
                        "Condición:" & CONDICION & vbNewLine &
                        "Ordenamiento:" & ORDENAMIENTO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT_DATASET MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. Sql=" & SQL & " " & tt, MYEX)
                Catch EX As Exception
                    Dim tt As String = vbNewLine & "Campos:" & CAMPOS & vbNewLine & _
                            "Condición:" & CONDICION & vbNewLine & _
                            "Ordenamiento:" & ORDENAMIENTO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT_DATASET Error=" & EX.ToString
                    Throw New System.Exception("Error no contemplado." & tt, EX)
                Finally
                    If Not IsNothing(DataA) Then
                        DataA.Dispose()
                        DataA = Nothing
                    End If
                    System.GC.Collect()
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PSELECT_READER(ByRef READER As MySqlDataReader, _
                Optional ByVal CAMPOS As String = "", _
                Optional ByVal CONDICION As String = "", _
                Optional ByVal ORDENAMIENTO As String = "") As Boolean
                Dim COM As MySqlCommand
                Dim SQL As String
                Dim SQL1 As String

                MENSAJE = ""
                PSELECT_READER = False

                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Lectura)

                If CAMPOS.Length = 0 Then
                    SQL = "Select * from anulaciones"
                Else
                    SQL = "SELECT " & CAMPOS & " FROM anulaciones"
                End If
                If CONDICION.Length <> 0 Then SQL &= " Where " & CONDICION
                If ORDENAMIENTO.Length <> 0 Then SQL &= " Order By " & ORDENAMIENTO

                SQL1 = "Select Count(*) as Cuenta from anulaciones"
                If CONDICION.Length <> 0 Then SQL1 &= " Where " & CONDICION

                READER = Nothing
                COM = Nothing
                Try
                    INIT()
                    INIT_LLAVE()
                    If _Usar_Transaccion_Select Then
                        COM = New MySqlCommand(SQL1, TRA.Connection, TRA)
                    Else
                        COM = New MySqlCommand(SQL1, CON)
                    End If
                    COM.CommandType = CommandType.Text
                    COM.CommandTimeout = _TimeOut
                    Cantidad_de_la_Clase = CInt(COM.ExecuteScalar())
                    COM.Dispose()
                    COM = Nothing

                    If _Usar_Transaccion_Select Then
                        COM = New MySqlCommand(SQL, TRA.Connection)
                    Else
                        COM = New MySqlCommand(SQL, CON)
                    End If
                    COM.CommandType = CommandType.Text
                    COM.CommandTimeout = _TimeOut
                    READER = COM.ExecuteReader()
                    PSELECT_READER = True
                Catch MYEX As MySqlException
                    Dim tt As String = vbNewLine & "Campos:" & CAMPOS & vbNewLine & _
                        "Condición:" & CONDICION & vbNewLine & _
                        "Ordenamiento:" & ORDENAMIENTO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT_READER MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. SQL1=" & SQL1 & vbNewLine & "Sql=" & SQL & tt, MYEX)
                Catch EX As Exception
                    Dim tt As String = vbNewLine & "Campos:" & CAMPOS & vbNewLine & _
                            "Condición:" & CONDICION & vbNewLine & _
                            "Ordenamiento:" & ORDENAMIENTO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PSELECT_READER Error=" & EX.ToString
                    Throw New System.Exception("Error no contemplado." & tt, EX)
                Finally
                    If Not IsNothing(COM) Then
                        COM.Dispose()
                        COM = Nothing
                    End If
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PINSERT() As Boolean
                Dim COM As MySqlCommand
                Dim SQL As String

                MENSAJE = ""
                PINSERT = False

                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Insert)

                COM = Nothing
                Try
                    SQL = "INSERT INTO anulaciones (ANUL_EMPRESA,ANUL_TIENDA,ANUL_CAJA,ANUL_TIPO,ANUL_CORRELATIVO,ANUL_NUMERO,ANUL_SERIE,ANUL_MONTO,ANUL_FECHA,ANUL_USUARIO,ANUL_SUPERVISOR,ANUL_CAUSA,ANUL_CORTE_Z,ESCRITURA) " & _
                        "VALUES(?P1,?P2,?P3,?P4,?P5,?P6,?P7,?P8,?P9,?P10,?P11,?P12,?P13,?P14)"
                    If _Usar_Transaccion_Select Then
                        COM = New MySqlCommand(SQL, TRA.Connection, TRA)
                    Else
                        COM = New MySqlCommand(SQL, CON)
                    End If
                    COM.CommandType = CommandType.Text
                    COM.CommandTimeout = _TimeOut
                    If m_str_ANUL_EMPRESA.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P1", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P1", m_str_ANUL_EMPRESA)
                    End If
                    If m_str_ANUL_TIENDA.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P2", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P2", m_str_ANUL_TIENDA)
                    End If
                    If m_int_ANUL_CAJA = -1 Then
                        COM.Parameters.AddWithValue("?P3", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P3", m_int_ANUL_CAJA)
                    End If
                    If m_str_ANUL_TIPO.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P4", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P4", m_str_ANUL_TIPO)
                    End If
                    If m_int_ANUL_CORRELATIVO = -1 Then
                        COM.Parameters.AddWithValue("?P5", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P5", m_int_ANUL_CORRELATIVO)
                    End If
                    If m_int_ANUL_NUMERO = -1 Then
                        COM.Parameters.AddWithValue("?P6", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P6", m_int_ANUL_NUMERO)
                    End If
                    If m_str_ANUL_SERIE.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P7", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P7", m_str_ANUL_SERIE)
                    End If
                    COM.Parameters.AddWithValue("?P8", m_dec_ANUL_MONTO)
                    If m_dt_ANUL_FECHA.IsValidDateTime = False Then
                        COM.Parameters.AddWithValue("?P9", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P9", m_dt_ANUL_FECHA.Value)
                    End If
                    If m_str_ANUL_USUARIO.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P10", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P10", m_str_ANUL_USUARIO)
                    End If
                    If m_str_ANUL_SUPERVISOR.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P11", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P11", m_str_ANUL_SUPERVISOR)
                    End If
                    If m_str_ANUL_CAUSA.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P12", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P12", m_str_ANUL_CAUSA)
                    End If
                    If m_int_ANUL_CORTE_Z = -1 Then
                        COM.Parameters.AddWithValue("?P13", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P13", m_int_ANUL_CORTE_Z)
                    End If
                    COM.Parameters.AddWithValue("?P14", Now)
                    COM.ExecuteNonQuery()
                    PINSERT = True
                Catch MYEX As MySqlException
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PINSERT MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL.", MYEX)
                Catch ex As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PINSERT Error=" & ex.ToString
                    Throw New System.Exception("Error no contemplado.", ex)
                Finally
                    If Not IsNothing(COM) Then
                        COM.Dispose()
                        COM = Nothing
                    End If
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PDELETE(Optional ByVal Condicion As String = "") As Boolean
                Dim COM As MySqlCommand
                Dim SQL As String = ""

                MENSAJE = ""
                PDELETE = False

                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Delete)

                COM = Nothing
                Try
                    If Condicion.Length <> 0 Then
                        SQL = "DELETE FROM anulaciones WHERE " & Condicion
                        If _Usar_Transaccion_Select Then
                            COM = New MySqlCommand(SQL, TRA.Connection, TRA)
                        Else
                            COM = New MySqlCommand(SQL, CON)
                        End If
                        COM.CommandType = CommandType.Text
                        COM.CommandTimeout = _TimeOut
                    Else
                        SQL = "DELETE FROM anulaciones WHERE ANUL_EMPRESA = ?P1  AND ANUL_TIENDA = ?P2  AND ANUL_CAJA = ?P3  AND ANUL_TIPO = ?P4  AND ANUL_CORRELATIVO = ?P5 "
                        If _Usar_Transaccion_Select Then
                            COM = New MySqlCommand(SQL, TRA.Connection, TRA)
                        Else
                            COM = New MySqlCommand(SQL, CON)
                        End If
                        COM.CommandType = CommandType.Text
                        COM.CommandTimeout = _TimeOut
                        COM.Parameters.AddWithValue("?P1", m_str_ANUL_EMPRESA)
                        COM.Parameters.AddWithValue("?P2", m_str_ANUL_TIENDA)
                        COM.Parameters.AddWithValue("?P3", m_int_ANUL_CAJA)
                        COM.Parameters.AddWithValue("?P4", m_str_ANUL_TIPO)
                        COM.Parameters.AddWithValue("?P5", m_int_ANUL_CORRELATIVO)
                    End If
                    If COM.ExecuteNonQuery <= 0 Then
                        PDELETE = False
                    Else
                        PDELETE = True
                    End If
                Catch MYEX As MySqlException
                    Dim tt As String = vbNewLine & "Llave:" & m_str_ANUL_EMPRESA & "-" & m_str_ANUL_TIENDA & "-" & m_int_ANUL_CAJA & "-" & m_str_ANUL_TIPO & "-" & m_int_ANUL_CORRELATIVO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PDELETE MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. SQL=" & SQL & tt, MYEX)
                Catch ex As Exception
                    Dim tt As String = vbNewLine & "Llave:" & m_str_ANUL_EMPRESA & "-" & m_str_ANUL_TIENDA & "-" & m_int_ANUL_CAJA & "-" & m_str_ANUL_TIPO & "-" & m_int_ANUL_CORRELATIVO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PDELETE Error=" & ex.ToString
                    Throw New System.Exception("Error no Contemplado Sql=." & SQL & tt, ex)
                Finally
                    If Not IsNothing(COM) Then
                        COM.Dispose()
                        COM = Nothing
                    End If
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Public Function PUPDATE() As Boolean
                Dim COM As MySqlCommand
                Dim SQL As String = ""

                MENSAJE = ""
                PUPDATE = False

                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Update)

                COM = Nothing
                Try
                    SQL = "UPDATE anulaciones SET ANUL_NUMERO = ?P6, ANUL_SERIE = ?P7, ANUL_MONTO = ?P8, ANUL_FECHA = ?P9, ANUL_USUARIO = ?P10, ANUL_SUPERVISOR = ?P11, ANUL_CAUSA = ?P12, ANUL_CORTE_Z = ?P13, ESCRITURA = ?P14 WHERE ANUL_EMPRESA = ?P1 AND ANUL_TIENDA = ?P2 AND ANUL_CAJA = ?P3 AND ANUL_TIPO = ?P4 AND ANUL_CORRELATIVO = ?P5"
                    If _Usar_Transaccion_Select Then
                        COM = New MySqlCommand(SQL, TRA.Connection, TRA)
                    Else
                        COM = New MySqlCommand(SQL, CON)
                    End If
                    COM.CommandType = CommandType.Text
                    COM.CommandTimeout = _TimeOut

                    If m_int_ANUL_NUMERO = -1 Then
                        COM.Parameters.AddWithValue("?P6", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P6", m_int_ANUL_NUMERO)
                    End If
                    If m_str_ANUL_SERIE.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P7", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P7", m_str_ANUL_SERIE)
                    End If
                    COM.Parameters.AddWithValue("?P8", m_dec_ANUL_MONTO)
                    If m_dt_ANUL_FECHA.IsValidDateTime = False Then
                        COM.Parameters.AddWithValue("?P9", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P9", m_dt_ANUL_FECHA.Value)
                    End If
                    If m_str_ANUL_USUARIO.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P10", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P10", m_str_ANUL_USUARIO)
                    End If
                    If m_str_ANUL_SUPERVISOR.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P11", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P11", m_str_ANUL_SUPERVISOR)
                    End If
                    If m_str_ANUL_CAUSA.ToUpper = "NULL" Then
                        COM.Parameters.AddWithValue("?P12", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P12", m_str_ANUL_CAUSA)
                    End If
                    If m_int_ANUL_CORTE_Z = -1 Then
                        COM.Parameters.AddWithValue("?P13", DBNull.Value)
                    Else
                        COM.Parameters.AddWithValue("?P13", m_int_ANUL_CORTE_Z)
                    End If
                    COM.Parameters.AddWithValue("?P14", Now)  'Es TimeStamp , Pongo Fecha Actual.
                    COM.Parameters.AddWithValue("?P1", m_str_ANUL_EMPRESA)
                    COM.Parameters.AddWithValue("?P2", m_str_ANUL_TIENDA)
                    COM.Parameters.AddWithValue("?P3", m_int_ANUL_CAJA)
                    COM.Parameters.AddWithValue("?P4", m_str_ANUL_TIPO)
                    COM.Parameters.AddWithValue("?P5", m_int_ANUL_CORRELATIVO)
                    If COM.ExecuteNonQuery <= 0 Then
                        PUPDATE = False
                    Else
                        PUPDATE = True
                    End If
                Catch MYEX As MySqlException
                    Dim tt As String = vbNewLine & "Llave:" & m_str_ANUL_EMPRESA & "-" & m_str_ANUL_TIENDA & "-" & m_int_ANUL_CAJA & "-" & m_str_ANUL_TIPO & "-" & m_int_ANUL_CORRELATIVO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PUPDATE MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. SQL=" & SQL & tt, MYEX)
                Catch ex As Exception
                    Dim tt As String = vbNewLine & "Llave:" & m_str_ANUL_EMPRESA & "-" & m_str_ANUL_TIENDA & "-" & m_int_ANUL_CAJA & "-" & m_str_ANUL_TIPO & "-" & m_int_ANUL_CORRELATIVO
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PUPDATE Error=" & ex.ToString
                    Throw New System.Exception("Error no contemplado." & tt, ex)
                Finally
                    If Not IsNothing(COM) Then
                        COM.Dispose()
                        COM = Nothing
                    End If
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Function PRECUPERA_REGISTRO() As ANULACIONES
                Dim VAL As New ANULACIONES
                VAL.ANUL_EMPRESA = ""
                VAL.ANUL_TIENDA = ""
                VAL.ANUL_CAJA = 0
                VAL.ANUL_TIPO = ""
                VAL.ANUL_CORRELATIVO = 0
                VAL.Simon_REGISTRO = False
                VAL.MERROR = ""
                PRECUPERA_REGISTRO = VAL
                Try
                    VAL.ANUL_EMPRESA = ANUL_EMPRESA
                    VAL.ANUL_TIENDA = ANUL_TIENDA
                    VAL.ANUL_CAJA = ANUL_CAJA
                    VAL.ANUL_TIPO = ANUL_TIPO
                    VAL.ANUL_CORRELATIVO = ANUL_CORRELATIVO
                    VAL.ANUL_NUMERO = ANUL_NUMERO
                    VAL.ANUL_SERIE = ANUL_SERIE
                    VAL.ANUL_MONTO = ANUL_MONTO
                    VAL.ANUL_FECHA = ANUL_FECHA
                    VAL.ANUL_USUARIO = ANUL_USUARIO
                    VAL.ANUL_SUPERVISOR = ANUL_SUPERVISOR
                    VAL.ANUL_CAUSA = ANUL_CAUSA
                    VAL.ANUL_CORTE_Z = ANUL_CORTE_Z
                    VAL.ESCRITURA = ESCRITURA
                    VAL.Simon_REGISTRO = True
                    PRECUPERA_REGISTRO = VAL
                Catch Ex As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PRECUPERA_REGISTRO Error=" & Ex.ToString
                    Throw New System.Exception("Error no Contemplado", Ex)
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Function PPONE_REGISTRO(ByVal VAL As ANULACIONES) As Boolean
                PPONE_REGISTRO = False
                Try
                    ANUL_EMPRESA = VAL.ANUL_EMPRESA
                    ANUL_TIENDA = VAL.ANUL_TIENDA
                    ANUL_CAJA = VAL.ANUL_CAJA
                    ANUL_TIPO = VAL.ANUL_TIPO
                    ANUL_CORRELATIVO = VAL.ANUL_CORRELATIVO
                    ANUL_NUMERO = VAL.ANUL_NUMERO
                    ANUL_SERIE = VAL.ANUL_SERIE
                    ANUL_MONTO = VAL.ANUL_MONTO
                    ANUL_FECHA = VAL.ANUL_FECHA
                    ANUL_USUARIO = VAL.ANUL_USUARIO
                    ANUL_SUPERVISOR = VAL.ANUL_SUPERVISOR
                    ANUL_CAUSA = VAL.ANUL_CAUSA
                    ANUL_CORTE_Z = VAL.ANUL_CORTE_Z
                    ESCRITURA = VAL.ESCRITURA
                    PPONE_REGISTRO = True
                Catch Ex As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PPONE_REGISTRO Error=" & Ex.ToString
                    Throw New System.Exception("Error No Contemplado", Ex)
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Function PLLENA_COLECCION(ByRef COLECCION As Collection, ByVal CONDICION As String, Optional ByVal ORDENAMIENTO As String = "") As Boolean
                Dim CC As New Manejo_Tablas.A.TANULACIONES
                Dim TEMPO As ANULACIONES
                Dim Llave As String

                PLLENA_COLECCION = False
                Try
                    If IsNothing(CON) Then
                        MENSAJE = "BiblioTABLAS - TANULACIONES - PLLENA_COLLECION Error = No se ha definido el String de Conexión a la base de datos."
                        Throw New System.Exception("Sin Conexión")
                        Exit Function
                    End If

                    CC.CONEXION = CONstr
                    CC.PSELECT_RECORDSET(CONDICION, ORDENAMIENTO)

                    Do While CC.PMOVE_NEXT
                        TEMPO = CC.PRECUPERA_REGISTRO
                        Llave = TEMPO.ANUL_EMPRESA.ToString & "|" & TEMPO.ANUL_TIENDA.ToString & "|" & TEMPO.ANUL_CAJA.ToString & "|" & TEMPO.ANUL_TIPO.ToString & "|" & TEMPO.ANUL_CORRELATIVO.ToString
                        COLECCION.Add(TEMPO, Llave)
                    Loop
                    PLLENA_COLECCION = True
                Catch EX As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - PLLENA_COLECCION Error=" & EX.ToString
                    Throw New System.Exception("Error No Contemplado", EX)
                Finally
                    CC.Dispose()
                    CC = Nothing
                    TEMPO = Nothing

                    System.GC.Collect()
                End Try
            End Function

            <System.Diagnostics.DebuggerStepThrough()> _
            Function POBTIENE_DEFAULT() As ANULACIONES
                Dim VAL As New ANULACIONES
                VAL.Simon_REGISTRO = False
                VAL.MERROR = ""
                POBTIENE_DEFAULT = VAL
                Try
                    VAL.ANUL_EMPRESA = ""
                    VAL.ANUL_TIENDA = ""
                    VAL.ANUL_CAJA = 0
                    VAL.ANUL_TIPO = ""
                    VAL.ANUL_CORRELATIVO = 0
                    VAL.ANUL_NUMERO = 0
                    VAL.ANUL_SERIE = ""
                    VAL.ANUL_MONTO = 0D
                    VAL.ANUL_FECHA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
                    VAL.ANUL_USUARIO = ""
                    VAL.ANUL_SUPERVISOR = ""
                    VAL.ANUL_CAUSA = ""
                    VAL.ANUL_CORTE_Z = 0
                    VAL.ESCRITURA = New MySqlDateTime(Now)
                    VAL.Simon_REGISTRO = True
                    POBTIENE_DEFAULT = VAL
                Catch Ex As Exception
                    MENSAJE = "BiblioTABLAS - TANULACIONES - POBTIENE_DEFAULT Error=" & Ex.ToString
                    Throw New System.Exception("Error no contemplado", Ex)
                End Try
            End Function

#End Region

        End Class
    End Namespace
End Namespace
