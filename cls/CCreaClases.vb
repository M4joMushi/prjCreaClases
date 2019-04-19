Public Class CMiembro

#Region "Miembros Privados"
    Private m_str_NombreCompleto As String
    Private m_str_Propiedad As String
    Private m_str_Ambito As String
    Private m_str_Tipo As String
    Private m_str_Prefijo As String
    'Indica si la fila ha sido modificada
    Private m_chr_EstadoFila As Char
#End Region

#Region "Public Properties"
    Public Property NombreCompleto() As String
        Get
            Return m_str_NombreCompleto
        End Get
        Set(ByVal Value As String)
            m_str_NombreCompleto = Value
        End Set
    End Property

    Public Property Prefijo() As String
        Get
            Return m_str_Prefijo
        End Get
        Set(ByVal Value As String)
            m_str_Prefijo = Value
        End Set
    End Property

    Public Property Propiedad() As String
        Get
            Return m_str_Propiedad
        End Get
        Set(ByVal Value As String)
            m_str_Propiedad = Value
            'U = Updated
            m_chr_EstadoFila = "U"
        End Set
    End Property

    Public Property Ambito() As String
        Get
            Return m_str_Ambito
        End Get
        Set(ByVal Value As String)
            m_str_Ambito = Value
            'U = Updated
            m_chr_EstadoFila = "U"
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return m_str_Tipo
        End Get
        Set(ByVal Value As String)
            m_str_Tipo = Value
            'U = Updated
            m_chr_EstadoFila = "U"
        End Set
    End Property

    Public Property EstadoFila() As Char
        Get
            Return m_chr_EstadoFila
        End Get
        Set(ByVal Value As Char)
            m_chr_EstadoFila = Value
        End Set
    End Property

#End Region

#Region "Public Methods"
    Public Sub New()
        m_str_Propiedad = ""
        m_str_Ambito = ""
        m_str_Tipo = ""
        'N = New
        m_chr_EstadoFila = "N"
    End Sub


    'Public Sub New(ByVal pNombreCompleto As String, ByVal pPropiedad As String, ByVal pAmbito As String, ByVal pTipo As String, ByVal pTipoBD As String, ByVal pEsPK As Boolean)
    '    m_str_NombreCompleto = pNombreCompleto
    '    m_str_Propiedad = pPropiedad
    '    m_str_Ambito = pAmbito
    '    m_str_Tipo = pTipo
    '    m_str_TipoBD = pTipoBD
    '    m_bol_EsPK = pEsPK
    '    'N = New
    '    m_chr_EstadoFila = "N"
    'End Sub

    Public Sub Delete()
        'D = Deleted
        m_chr_EstadoFila = "D"
    End Sub
#End Region

End Class

Public Class CMiembros
    Inherits CollectionBase

#Region "Miembros Privados"
    Private m_str_NombreClase As String
    Private m_str_NombreColeccion As String
#End Region

#Region "Propiedades"

    Public Property NombreClase() As String
        Get
            Return m_str_NombreClase
        End Get
        Set(ByVal Value As String)
            m_str_NombreClase = Value
        End Set
    End Property

    Public Property NombreColeccion() As String
        Get
            Return m_str_NombreColeccion
        End Get
        Set(ByVal Value As String)
            m_str_NombreColeccion = Value
        End Set
    End Property
#End Region

#Region "Public Methods"
    Public Sub New()
        MyBase.New()
    End Sub

    'Mediante esta función se buscan los objetos que han sido modificados
    'No es utilizada en el programa
    Public Function ChangedRecords() As CMiembros
        Dim objBase As CMiembro
        Dim objColeccion As CMiembros

        For Each objBase In Me
            If objBase.EstadoFila = "U" Then
                objColeccion.Agregar(objBase)
            End If
        Next
        Return objColeccion
    End Function

    'Permite insertar un elemento en la colección con un indice específico
    Public Sub Insertar(ByVal iIndex As Integer, ByVal objBase As CMiembro)
        InnerList.Insert(iIndex, objBase)
    End Sub

    'Borra un elemento de la colección
    Public Sub Borrar(ByVal objBase As CMiembro)
        InnerList.Remove(objBase)
    End Sub

    'Indica el indice de un objeto en la coleccion
    Public Function IndiceDe(ByVal objBase As CMiembro) As Integer
        Return InnerList.IndexOf(objBase)
    End Function

    'Indica si un objeto esta contenido en la colección
    Public Function Contiene(ByVal objBase As CMiembro) As Boolean
        Return InnerList.Contains(objBase)
    End Function

    'Permite agregar elementos en la coleccion
    Public Function Agregar(ByVal objBase As CMiembro) As Integer
        Return InnerList.Add(objBase)
    End Function


    'Mediante esta función y los datos que se proveen, 
    'se genera una clase con sus datos miembro y las propiedades para
    'accederlos, tambien se genera una colección para almacenar objetos
    'y al final una clase que permite ordenar la colección de objetos

    Public Function GeneraClase() As String
        Dim objBase As CMiembro
        Dim strResultado As String
        Dim mTab As String = Chr(9)
        Dim iCont As Integer

        'Primero Crea la Clase Base
        strResultado = "Public Class " & Me.NombreClase & Chr(10)

        'Primero carga todos los datos miembro dentro de una region "Miembros"
        strResultado &= "#Region ""Miembros""" & Chr(10) & Chr(10)
        For Each objBase In Me
            strResultado &= mTab & objBase.Ambito & mTab & objBase.NombreCompleto & mTab & " As " & objBase.Tipo & Chr(10)
        Next
        'Agrega 1 datos miembro, estado del objeto
        strResultado &= mTab & "Private" & mTab & "m_Chr_EstadoFila" & mTab & " As Char" & Chr(10)

        strResultado &= "#End Region" & Chr(10) & Chr(10) & Chr(10)


        'Luego crea las propiedades para acceder 
        strResultado &= "#Region ""Propiedades""" & Chr(10) & Chr(10)

        For Each objBase In Me

            strResultado &= mTab & "Public Property " & mTab & objBase.Propiedad & mTab & " As " & objBase.Tipo & Chr(10)
            strResultado &= mTab & "Get" & Chr(10)
            If objBase.Tipo = "String" Then
                strResultado &= mTab & mTab & "return trim(" & objBase.NombreCompleto & ")" & Chr(10)
            Else
                strResultado &= mTab & mTab & "return " & objBase.NombreCompleto & Chr(10)
            End If
            strResultado &= mTab & "End Get" & Chr(10)

            strResultado &= mTab & "Set (ByVal Value As " & objBase.Tipo & ")" & Chr(10)
            strResultado &= mTab & mTab & objBase.NombreCompleto & " = Value " & Chr(10)
            strResultado &= mTab & "End Set" & Chr(10)
            strResultado &= mTab & "End Property" & Chr(10) & Chr(10)
        Next

        'Agrega la propiedad para acceder al estado de la fila
        strResultado &= mTab & "Public Property " & mTab & "EstadoFila" & mTab & " As Char" & Chr(10)
        strResultado &= mTab & "Get" & Chr(10)
        strResultado &= mTab & mTab & "return m_chr_EstadoFila" & Chr(10)
        strResultado &= mTab & "End Get" & Chr(10)

        strResultado &= mTab & "Set (ByVal Value As Char)" & Chr(10)
        strResultado &= mTab & mTab & "m_Chr_EstadoFila = Value " & Chr(10)
        strResultado &= mTab & "End Set" & Chr(10)
        strResultado &= mTab & "End Property" & Chr(10) & Chr(10)

        strResultado &= "#End Region" & Chr(10) & Chr(10) & Chr(10)


        'POR ÚLTIMO CREA LA FUNCIÓN PARA GUARDAR
        strResultado &= "#Region ""Funciones Publicas""" & Chr(10) & Chr(10)

        'PRIMERO, AGREGA EL CONSTRUCTOR DE LA CLASE, YA QUE A MANO ES UN PAIN IN THE ASS
        strResultado &= mTab & "Public Sub New()" & Chr(10)
        strResultado &= mTab & mTab & "With Me" & Chr(10)
        For Each objBase In Me
            Select Case objBase.Tipo
                Case "Decimal", "Integer", "Short"
                    strResultado &= mTab & mTab & mTab & "." & objBase.Propiedad & " = 0" & Chr(10)
                Case "Boolean"
                    strResultado &= mTab & mTab & mTab & "." & objBase.Propiedad & " = false" & Chr(10)
                Case "DateTime"
                    strResultado &= mTab & mTab & mTab & "." & objBase.Propiedad & " = 01/01/1900" & Chr(10)
                Case Else
                    strResultado &= mTab & mTab & mTab & "." & objBase.Propiedad & " = """"" & Chr(10)
            End Select
        Next
        strResultado &= mTab & mTab & "End With" & Chr(10)
        strResultado &= mTab & "End Sub" & Chr(10) & Chr(10)


        'AGREGA LA LECTURA DE LOS OBJETOS INDIVIDUALES
        strResultado &= "Public Function Leer( _" & Chr(10) & _
            mTab & "ByVal pFolio As String, _" & Chr(10) & _
            mTab & "ByVal pConexion As CConexion) As Boolean" & Chr(10) & Chr(10) & _
            mTab & "Dim dr As SqlClient.SqlDataReader" & Chr(10) & _
            mTab & "Dim cmd As New SqlClient.SqlCommand" & Chr(10) & _
            mTab & "Dim sqlParam As New SqlClient.SqlParameter" & Chr(10) & Chr(10)

        strResultado &= mTab & "pConexion.ConnectToDatabase()" & Chr(10) & _
            mTab & "cmd.CommandType = CommandType.StoredProcedure" & Chr(10) & _
            mTab & "cmd.CommandText = ""SP_LECTURA_OBJETO""" & Chr(10) & _
            mTab & "cmd.Connection = pConexion.Conexion" & Chr(10) & Chr(10) & _
            mTab & "sqlParam = cmd.Parameters.Add(""@FOLIO"", SqlDbType.Char, 16)" & Chr(10) & _
            mTab & "sqlParam.Direction = ParameterDirection.Input" & Chr(10) & _
            mTab & "sqlParam.Value = pFolio" & Chr(10) & Chr(10)

        strResultado &= mTab & "dr = cmd.ExecuteReader()" & Chr(10) & Chr(10) & _
            mTab & "While dr.Read()" & Chr(10) & _
            mTab & mTab & "With Me" & Chr(10)

        iCont = 0
        For Each objBase In Me
            strResultado &= mTab & mTab & mTab & objBase.NombreCompleto & " = dr(" & CType(iCont, Integer) & ")" & Chr(10)
            iCont += 1
        Next

        strResultado &= mTab & mTab & "End With" & Chr(10) & _
            mTab & "End While" & Chr(10) & _
            mTab & "dr.Close()" & Chr(10) & _
            mTab & "dr = Nothing" & Chr(10) & _
            mTab & "cmd = Nothing" & Chr(10) & _
            "End Function" & Chr(10) & Chr(10)

        strResultado &= "Public Function Guardar(ByVal pConexion As CConexion, _" & Chr(10) & _
             mTab & "Optional ByVal tran As SqlClient.SqlTransaction = Nothing) As Boolean" & Chr(10) & Chr(10) & _
             mTab & "Dim strSQL As String" & Chr(10) & _
             mTab & "Dim cmd As New SqlClient.SqlCommand" & Chr(10) & _
             mTab & "Dim sqlParam As New SqlClient.SqlParameter" & Chr(10) & _
             mTab & "Dim transaction As SqlClient.SqlTransaction" & Chr(10) & Chr(10) & _
             mTab & "pConexion.ConnectToDatabase()" & Chr(10) & _
             mTab & "If tran Is Nothing Then" & Chr(10) & _
                 mTab & mTab & "transaction = pConexion.Conexion.BeginTransaction()" & Chr(10) & _
             mTab & "Else" & Chr(10) & _
                 mTab & mTab & "transaction = tran" & Chr(10) & _
             mTab & "End If" & Chr(10) & Chr(10) & _
             mTab & "cmd.Transaction = transaction" & Chr(10) & _
             mTab & "cmd.Connection = pConexion.Conexion" & Chr(10) & Chr(10) & _
             mTab & "Try" & Chr(10) & _
             mTab & mTab & "cmd.CommandType = CommandType.StoredProcedure" & Chr(10) & _
            mTab & mTab & "cmd.CommandText = ""NOMBRE_SP""" & Chr(10) & Chr(10)


        For Each objBase In Me
            strResultado &= mTab & mTab & "sqlParam = cmd.Parameters.Add(""" & objBase.NombreCompleto & """, SqlDbType."
            Select Case objBase.Tipo
                Case "Decimal", "DateTime"
                    strResultado &= objBase.Tipo
                Case "Integer"
                    strResultado &= "Int"
                Case "Boolean"
                    strResultado &= "Bit"
                Case "String"
                    If objBase.Prefijo = "vch" Then
                        strResultado &= "varchar"
                    Else
                        strResultado &= "Char"
                    End If
            End Select

            strResultado &= ")" & Chr(10) & _
            mTab & mTab & "sqlParam.Direction = ParameterDirection.Input" & Chr(10) & _
            mTab & mTab & "sqlParam.Value = Me." & objBase.Propiedad & Chr(10) & Chr(10)
        Next


        strResultado &= mTab & mTab & "cmd.ExecuteNonQuery()" & Chr(10) & _
            mTab & mTab & "If tran Is Nothing Then" & Chr(10) & _
                mTab & mTab & mTab & "transaction.Commit()" & Chr(10) & _
            mTab & mTab & "End If" & Chr(10) & _
            mTab & mTab & "Catch ex As Exception" & Chr(10) & _
                mTab & mTab & mTab & "'Mensaje = ex.Message" & Chr(10) & _
                mTab & mTab & mTab & "If tran Is Nothing Then" & Chr(10) & _
                    mTab & mTab & mTab & mTab & "transaction.Rollback()" & Chr(10) & _
                mTab & mTab & mTab & "End If" & Chr(10) & _
                mTab & mTab & mTab & "Return False" & Chr(10) & _
             mTab & "End Try" & Chr(10) & Chr(10) & _
             mTab & "'Mensaje = """"" & Chr(10) & _
             mTab & "Return True" & Chr(10) & _
        "End Function" & Chr(10) & Chr(10)
        strResultado &= "#End Region" & Chr(10) & Chr(10) & Chr(10)

        strResultado &= "End Class " & Chr(10) & Chr(10) & Chr(10)



        'LUEGO FORMA LA COLECCION DE LA CLASE
        strResultado &= "Public Class " & Me.NombreColeccion & Chr(10)
        strResultado &= "   Inherits CollectionBase" & Chr(10) & Chr(10)

        strResultado &= "#Region ""Métodos Publicos""" & Chr(10)
        strResultado &= "Public Sub New() " & Chr(10) & mTab & "MyBase.New()" & Chr(10) & "End Sub" & Chr(10) & Chr(10)


        strResultado &= "'FUNCION QUE REGRESA UNA COLECCION DE ELEMENTOS MODIFICADOS" & Chr(10) & _
        "Public Function RegistrosModificados() As " & Me.NombreColeccion & Chr(10) & _
         mTab & "Dim objBase As " & Me.NombreClase & Chr(10) & _
         mTab & "Dim objColeccion As " & Me.NombreColeccion & Chr(10) & Chr(10) & _
         mTab & "For Each objBase In Me" & Chr(10) & _
         mTab & mTab & "If objBase.EstadoFila = ""U"" Then" & Chr(10) & _
         mTab & mTab & mTab & "objColeccion.Agregar(objBase)" & Chr(10) & _
         mTab & mTab & "End If" & Chr(10) & _
         mTab & "Next" & Chr(10) & _
         mTab & "Return objColeccion" & Chr(10) & _
        "End Function" & Chr(10) & Chr(10)


        strResultado &= "'FUNCION QUE INSERTA EN EL INDICE ESPECIFICADO" & Chr(10) & _
            "Public Sub Insertar(ByVal iIndex As Integer, ByVal objBase As " & Me.NombreClase & ")" & Chr(10) & _
            mTab & "InnerList.Insert(iIndex, objBase)" & Chr(10) & _
            "End Sub" & Chr(10) & Chr(10)

        strResultado &= "'Permite a la colección borrar los elementos" & Chr(10) & _
            "Public Sub Borrar(ByVal objBase As " & Me.NombreClase & ")" & Chr(10) & _
                mTab & "Innerlist.Remove(objBase)" & Chr(10) & _
            "End Sub" & Chr(10) & Chr(10)

        strResultado &= "'Permite a la colección buscar si contiene un objeto" & Chr(10) & _
            "Public Function Contiene(ByVal objBase As " & Me.NombreClase & ")" & Chr(10) & _
                mTab & "Return Innerlist.Contains(objBase)" & Chr(10) & _
            "End Function" & Chr(10) & Chr(10)

        strResultado &= "'Devuelve el índice en la colección de un objeto" & Chr(10) & _
            "Public Function IndiceDe(ByVal objBase As " & Me.NombreClase & ") As Integer" & Chr(10) & _
                mTab & "Return InnerList.IndexOf(objBase)" & Chr(10) & _
            "End Function" & Chr(10) & Chr(10)

        strResultado &= "'Agrega el método Agregar" & Chr(10) & _
            "Public Function Agregar(ByVal objBase As " & Me.NombreClase & ") As Integer" & Chr(10) & _
                mTab & "Return InnerList.Add(objBase)" & Chr(10) & _
            "End Function" & Chr(10) & Chr(10)


        'AGREGA LA LECTURA DE LA COLECCION
        strResultado &= "Public Function Leer( _" & Chr(10) & _
            mTab & "ByVal pFolio As String, _" & Chr(10) & _
            mTab & "ByVal pConexion As CConexion) As Boolean" & Chr(10) & Chr(10) & _
            mTab & "Dim dr As SqlClient.SqlDataReader" & Chr(10) & _
            mTab & "Dim cmd As New SqlClient.SqlCommand" & Chr(10) & _
            mTab & "Dim objBase As " & Me.NombreClase & Chr(10) & _
            mTab & "Dim sqlParam As New SqlClient.SqlParameter" & Chr(10) & Chr(10)

        strResultado &= mTab & "pConexion.ConnectToDatabase()" & Chr(10) & Chr(10) & _
            mTab & "cmd.CommandType = CommandType.StoredProcedure" & Chr(10) & _
            mTab & "cmd.CommandText = ""SP_LECTURA_COLECCION""" & Chr(10) & _
            mTab & "cmd.Connection = pConexion.Conexion" & Chr(10) & Chr(10) & _
            mTab & "sqlParam = cmd.Parameters.Add(""@FOLIO"", SqlDbType.Char, 16)" & Chr(10) & _
            mTab & "sqlParam.Direction = ParameterDirection.Input" & Chr(10) & _
            mTab & "sqlParam.Value = pFolio" & Chr(10) & Chr(10)

        strResultado &= mTab & "dr = cmd.ExecuteReader()" & Chr(10) & _
            mTab & "While dr.Read()" & Chr(10) & _
            mTab & mTab & "objBase = New " & Me.NombreClase & Chr(10) & _
            mTab & mTab & "With objBase" & Chr(10)

        iCont = 0
        For Each objBase In Me
            strResultado &= mTab & mTab & mTab & "." & objBase.Propiedad & " = dr(" & CType(iCont, Integer) & ")" & Chr(10)
            iCont += 1
        Next

        strResultado &= mTab & mTab & "End With" & Chr(10) & _
            mTab & mTab & "Me.Agregar(objBase)" & Chr(10) & _
            mTab & mTab & "objBase = Nothing" & Chr(10) & _
            mTab & "End While" & Chr(10) & _
            mTab & "dr.Close()" & Chr(10) & _
            mTab & "dr = Nothing" & Chr(10) & _
            mTab & "cmd = Nothing" & Chr(10) & _
            "End Function" & Chr(10) & Chr(10)


        'AGREGA EL GUARDADO DE LA COLECCION
        strResultado &= "'Public Function Guardar(ByRef pConexion As CConexion) As Boolean" & Chr(10) & _
            mTab & "'Dim bOk As Boolean = True" & Chr(10) & _
            mTab & "'Dim objBase As " & Me.NombreClase & Chr(10) & _
            mTab & "'Dim transaction As SqlClient.SqlTransaction" & Chr(10) & _
            mTab & "'transaction = pConexion.Conexion.BeginTransaction()" & Chr(10) & _
            mTab & "'For Each objBase In List" & Chr(10) & _
                mTab & mTab & "'bOk = bOk And objBase.Guardar(pConexion, transaction)" & Chr(10) & _
                mTab & mTab & "'If Not bOk Then" & Chr(10) & _
                    mTab & mTab & mTab & "'Mensaje = objBase.Mensaje" & Chr(10) & _
                    mTab & mTab & mTab & "'transaction.Rollback()" & Chr(10) & _
                    mTab & mTab & mTab & "'Return bOk" & Chr(10) & _
                mTab & mTab & "'End If" & Chr(10) & _
            mTab & "'Next" & Chr(10) & _
            mTab & "'Mensaje = """"" & Chr(10) & _
            mTab & "'transaction.Commit()" & Chr(10) & _
            mTab & "'Return bOk" & Chr(10) & _
            "'End Function" & Chr(10) & Chr(10)
        strResultado &= "#End Region" & Chr(10) & Chr(10) & Chr(10)

        strResultado &= "'#Region ""Providing Filtering""" & Chr(10) & _
        "'Public Function FilterByX(ByVal strCriterio As String) As " & Me.NombreColeccion & Chr(10) & _
        mTab & "'Dim objBase As " & Me.NombreClase & Chr(10) & _
        mTab & "'Dim objColeccion As " & Me.NombreColeccion & Chr(10) & Chr(10) & _
        mTab & "'ESTO PROVEE UNA ESPECIE DE LIKE" & Chr(10) & _
        mTab & "'For Each objBase In Me" & Chr(10) & _
        mTab & "'If objBase.Nombre.ToUpper.IndexOf(strCriterio.ToUpper) > -1 Then" & Chr(10) & _
        mTab & mTab & "'If objColeccion Is Nothing Then" & Chr(10) & _
        mTab & mTab & mTab & "'objColeccion = New " & Me.NombreColeccion & Chr(10) & _
        mTab & mTab & "'End If" & Chr(10) & _
        mTab & mTab & "'objColeccion.Add(objBase)" & Chr(10) & _
        mTab & "'End If" & Chr(10) & _
        mTab & "'Next" & Chr(10) & Chr(10) & _
        mTab & "'ESTO FILTRA EXACTAMENTE" & Chr(10) & _
        mTab & "'For Each objBase In Me" & Chr(10) & _
        mTab & mTab & "'If objBase.Nombre.ToUpper = strCriterio.ToUpper Then" & Chr(10) & _
        mTab & mTab & mTab & "'If objColeccion Is Nothing Then" & Chr(10) & _
        mTab & mTab & mTab & mTab & "'objColeccion = New " & Me.NombreColeccion & Chr(10) & _
        mTab & mTab & mTab & "'End If" & Chr(10) & _
        mTab & mTab & mTab & "'objColeccion.Add(objBase)" & Chr(10) & _
        mTab & mTab & "'End If" & Chr(10) & _
        mTab & "'Next" & Chr(10) & Chr(10) & _
        mTab & "'Return objColeccion" & Chr(10) & _
        "'End Function" & Chr(10) & Chr(10) & _
        "'#End Region" & Chr(10) & Chr(10) & Chr(10)

        strResultado &= "'#Region ""Providing Sorting""" & Chr(10) & _
        "'Public Sub Sort(ByVal strPropiedad As String)" & Chr(10) & _
        mTab & "'Select Case strPropiedad.ToUpper" & Chr(10) & _
        mTab & "'Case ""PROPIEDAD""" & Chr(10) & _
        mTab & mTab & "'Dim objComparer As New CComparer" & Me.NombreClase & ".DefaultComparer" & Chr(10) & _
        mTab & mTab & "'InnerList.Sort(objComparer)" & Chr(10) & _
        mTab & "'End Select" & Chr(10) & _
        "'End Sub" & Chr(10) & _
        "'#End Region" & Chr(10) & Chr(10) & Chr(10)

        strResultado &= "End Class " & Chr(10) & Chr(10) & Chr(10)

        'AGREGA TAMBIÉN UNA CLASE PARA PODER USAR EL ORDENAMIENTO
        strResultado &= "'Class CComparer" & Me.NombreClase & Chr(10) & _
        mTab & "'Class DefaultComparer" & Chr(10) & _
        mTab & mTab & "'Implements IComparer" & Chr(10) & Chr(10) & _
        mTab & mTab & "'Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare" & Chr(10) & Chr(10) & _
        mTab & mTab & mTab & "'Dim objBase1 As " & Me.NombreClase & Chr(10) & _
        mTab & mTab & mTab & "'Dim objBase2 As " & Me.NombreClase & Chr(10) & Chr(10) & _
        mTab & mTab & mTab & "'If GetType(" & Me.NombreClase & ").IsInstanceOfType(x) Then" & Chr(10) & _
        mTab & mTab & mTab & mTab & "'objBase1 = CType(x, " & Me.NombreClase & ")" & Chr(10) & _
        mTab & mTab & mTab & "'Else" & Chr(10) & _
        mTab & mTab & mTab & mTab & "'Throw New Exception(""Casting failed..."")" & Chr(10) & _
        mTab & mTab & mTab & "'End If" & Chr(10) & Chr(10) & _
        mTab & mTab & mTab & "'If GetType(" & Me.NombreClase & ").IsInstanceOfType(y) Then" & Chr(10) & _
        mTab & mTab & mTab & mTab & "'objBase2 = CType(y, " & Me.NombreClase & ")" & Chr(10) & _
        mTab & mTab & mTab & "'Else" & Chr(10) & _
        mTab & mTab & mTab & mTab & "'Throw New Exception(""Casting failed..."")" & Chr(10) & _
        mTab & mTab & mTab & "'End If" & Chr(10) & Chr(10)


        'ESTO ES EN SI LA COMPARACION PERO SE DEJA COMENTADO PARA PERSONALIZAR LOS CAMPOS
        strResultado &= mTab & mTab & mTab & "'If objBase1.CampoX = objBase2.CampoX Then" & Chr(10) & _
        mTab & mTab & mTab & mTab & "'Return 0" & Chr(10) & _
        mTab & mTab & mTab & "'ElseIf objBase1.CampoX < objBase2.CampoX Then" & Chr(10) & _
        mTab & mTab & mTab & mTab & "'Return -1" & Chr(10) & _
        mTab & mTab & mTab & "'Else" & Chr(10) & _
        mTab & mTab & mTab & mTab & "'Return 1" & Chr(10) & _
        mTab & mTab & mTab & "'End If" & Chr(10) & _
        mTab & mTab & "'End Function" & Chr(10) & _
        mTab & "'End Class" & Chr(10) & _
        "'End Class" & Chr(10) & Chr(10)

        Return strResultado
    End Function
#End Region

End Class
