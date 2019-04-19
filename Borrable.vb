'Namespace Manejo_Tablas
'    Namespace D
'        <System.Diagnostics.DebuggerStepThrough()> _
'        Public Class TDEFINICION_EMPLEADOS

'#Region "Miembros"

'            Dim DA As MySqlDataAdapter = Nothing
'            Dim DS As DataSet = Nothing
'            Dim POS_DS As Integer
'            Dim Lista() As DataRow = Nothing

'            Enum Tipo_Indices
'                PRIMARY
'                Ninguno
'            End Enum

'            <Serializable()> Public Structure DEFINICION_EMPLEADOS
'                Dim Simon_REGISTRO As Boolean
'                Dim MERROR As String
'                Dim EMP_EMPRESA As String
'                Dim EMP_CODIGO As Integer
'                Dim EMP_ACTIVO As String
'                Dim EMP_EMPRESA_CONTRATANTE As String
'                Dim EMP_NOMBRE1 As String
'                Dim EMP_NOMBRE2 As String
'                Dim EMP_NOMBRE3 As String
'                Dim EMP_APELLIDO1 As String
'                Dim EMP_APELLIDO2 As String
'                Dim EMP_APELLIDO3 As String
'                Dim EMP_CEDULA As String
'                Dim EMP_EXTENDIDA_EN As String
'                Dim EMP_DPI As String
'                Dim EMP_NIT As String
'                Dim EMP_NIVEL_ACCESO As String
'                Dim EMP_SEXO As String
'                Dim EMP_DIRECCION As String
'                Dim EMP_TEL_CASA As String
'                Dim EMP_TEL_EMERGENCIA As String
'                Dim EMP_TEL_CELULAR As String
'                Dim EMP_ALERGICO_ANTIBIOTICO As String
'                Dim EMP_TIPO_ANTIBIOTICO As String
'                Dim EMP_TIPO_SANGRE As String
'                Dim EMP_SABE_LEER As String
'                Dim EMP_SABE_ESCRIBIR As String
'                Dim EMP_PATH_FOTO As String
'                Dim EMP_LUGAR_NACIMIENTO As String
'                Dim EMP_FECHA_NACIMIENTO As MySqlDateTime
'                Dim EMP_NO_AFILIACION As String
'                Dim EMP_NOMBRE_CONYUGE As String
'                Dim EMP_TARJETA_SANIDAD As String
'                Dim EMP_CENTRO_SALUD As String
'                Dim EMP_PROFESION_OFICIO As String
'                Dim EMP_NO_LICENCIA As String
'                Dim EMP_EMPRESA1_ANT As String
'                Dim EMP_EMPRESA2_ANT As String
'                Dim EMP_EMPRESA3_ANT As String
'                Dim EMP_CARGO1_ANT As String
'                Dim EMP_CARGO2_ANT As String
'                Dim EMP_CARGO3_ANT As String
'                Dim EMP_CARCEL As String
'                Dim EMP_MOTIVO_CARCEL As String
'                Dim EMP_ANTECEDENTES As String
'                Dim EMP_REFERENCIA_NOM1 As String
'                Dim EMP_REFERENCIA_NOM2 As String
'                Dim EMP_REFERENCIA_NOM3 As String
'                Dim EMP_REFERENCIA_TEL1 As String
'                Dim EMP_REFERENCIA_TEL2 As String
'                Dim EMP_REFERENCIA_TEL3 As String
'                Dim EMP_ESTADO_CIVIL As String
'                Dim EMP_FOTO As Object
'                Dim EMP_FECHA_ALTA As MySqlDateTime
'                Dim EMP_INFECTO As String
'                Dim EMP_HOSPITAL As String
'                Dim EMP_MOTIVO_HOSPITAL As String
'                Dim EMP_PUESTO As String
'                Dim EMP_FILIAL_ASIGNADA As String
'                Dim EMP_NUMERO_HIJOS As Integer
'                Dim EMP_GRADO_ACADEMICO As String
'                Dim EMP_INSTITUCION_ACADEMICA As String
'                Dim EMP_SERVICIOS_ESPECIALES As String
'                Dim ESCRITURA As MySqlDateTime
'                <System.Diagnostics.DebuggerStepThrough()> _
'                Sub ReSet(Optional Tipo_ReSet As Definicion.ReSet_Struc = Definicion.ReSet_Struc.Total)
'                    If Tipo_ReSet = Definicion.ReSet_Struc.Total OrElse Tipo_ReSet = Definicion.ReSet_Struc.Llave Then
'                        EMP_EMPRESA = ""
'                        EMP_CODIGO = 0
'                    End If
'                    If Tipo_ReSet = Definicion.ReSet_Struc.Total OrElse Tipo_ReSet = Definicion.ReSet_Struc.No_Llave Then
'                        EMP_ACTIVO = ""
'                        EMP_EMPRESA_CONTRATANTE = ""
'                        EMP_NOMBRE1 = ""
'                        EMP_NOMBRE2 = ""
'                        EMP_NOMBRE3 = ""
'                        EMP_APELLIDO1 = ""
'                        EMP_APELLIDO2 = ""
'                        EMP_APELLIDO3 = ""
'                        EMP_CEDULA = ""
'                        EMP_EXTENDIDA_EN = ""
'                        EMP_DPI = ""
'                        EMP_NIT = ""
'                        EMP_NIVEL_ACCESO = ""
'                        EMP_SEXO = ""
'                        EMP_DIRECCION = ""
'                        EMP_TEL_CASA = ""
'                        EMP_TEL_EMERGENCIA = ""
'                        EMP_TEL_CELULAR = ""
'                        EMP_ALERGICO_ANTIBIOTICO = ""
'                        EMP_TIPO_ANTIBIOTICO = ""
'                        EMP_TIPO_SANGRE = ""
'                        EMP_SABE_LEER = ""
'                        EMP_SABE_ESCRIBIR = ""
'                        EMP_PATH_FOTO = ""
'                        EMP_LUGAR_NACIMIENTO = ""
'                        EMP_FECHA_NACIMIENTO = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
'                        EMP_NO_AFILIACION = ""
'                        EMP_NOMBRE_CONYUGE = ""
'                        EMP_TARJETA_SANIDAD = ""
'                        EMP_CENTRO_SALUD = ""
'                        EMP_PROFESION_OFICIO = ""
'                        EMP_NO_LICENCIA = ""
'                        EMP_EMPRESA1_ANT = ""
'                        EMP_EMPRESA2_ANT = ""
'                        EMP_EMPRESA3_ANT = ""
'                        EMP_CARGO1_ANT = ""
'                        EMP_CARGO2_ANT = ""
'                        EMP_CARGO3_ANT = ""
'                        EMP_CARCEL = ""
'                        EMP_MOTIVO_CARCEL = ""
'                        EMP_ANTECEDENTES = ""
'                        EMP_REFERENCIA_NOM1 = ""
'                        EMP_REFERENCIA_NOM2 = ""
'                        EMP_REFERENCIA_NOM3 = ""
'                        EMP_REFERENCIA_TEL1 = ""
'                        EMP_REFERENCIA_TEL2 = ""
'                        EMP_REFERENCIA_TEL3 = ""
'                        EMP_ESTADO_CIVIL = ""
'                        EMP_FOTO = Nothing
'                        EMP_FECHA_ALTA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
'                        EMP_INFECTO = ""
'                        EMP_HOSPITAL = ""
'                        EMP_MOTIVO_HOSPITAL = ""
'                        EMP_PUESTO = ""
'                        EMP_FILIAL_ASIGNADA = ""
'                        EMP_NUMERO_HIJOS = 0
'                        EMP_GRADO_ACADEMICO = ""
'                        EMP_INSTITUCION_ACADEMICA = ""
'                        EMP_SERVICIOS_ESPECIALES = ""
'                        ESCRITURA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
'                    End If
'                End Sub
'                <System.Diagnostics.DebuggerStepThrough()> _
'                Public Overrides Function GetHashCode() As Integer
'                    Try
'                        Return EMP_EMPRESA.GetHashCode Xor _
'                        EMP_CODIGO.GetHashCode Xor _
'                        EMP_ACTIVO.GetHashCode Xor _
'                        EMP_EMPRESA_CONTRATANTE.GetHashCode Xor _
'                        EMP_NOMBRE1.GetHashCode Xor _
'                        EMP_NOMBRE2.GetHashCode Xor _
'                        EMP_NOMBRE3.GetHashCode Xor _
'                        EMP_APELLIDO1.GetHashCode Xor _
'                        EMP_APELLIDO2.GetHashCode Xor _
'                        EMP_APELLIDO3.GetHashCode Xor _
'                        EMP_CEDULA.GetHashCode Xor _
'                        EMP_EXTENDIDA_EN.GetHashCode Xor _
'                        EMP_DPI.GetHashCode Xor _
'                        EMP_NIT.GetHashCode Xor _
'                        EMP_NIVEL_ACCESO.GetHashCode Xor _
'                        EMP_SEXO.GetHashCode Xor _
'                        EMP_DIRECCION.GetHashCode Xor _
'                        EMP_TEL_CASA.GetHashCode Xor _
'                        EMP_TEL_EMERGENCIA.GetHashCode Xor _
'                        EMP_TEL_CELULAR.GetHashCode Xor _
'                        EMP_ALERGICO_ANTIBIOTICO.GetHashCode Xor _
'                        EMP_TIPO_ANTIBIOTICO.GetHashCode Xor _
'                        EMP_TIPO_SANGRE.GetHashCode Xor _
'                        EMP_SABE_LEER.GetHashCode Xor _
'                        EMP_SABE_ESCRIBIR.GetHashCode Xor _
'                        EMP_PATH_FOTO.GetHashCode Xor _
'                        EMP_LUGAR_NACIMIENTO.GetHashCode Xor _
'                        EMP_FECHA_NACIMIENTO.GetHashCode Xor _
'                        EMP_NO_AFILIACION.GetHashCode Xor _
'                        EMP_NOMBRE_CONYUGE.GetHashCode Xor _
'                        EMP_TARJETA_SANIDAD.GetHashCode Xor _
'                        EMP_CENTRO_SALUD.GetHashCode Xor _
'                        EMP_PROFESION_OFICIO.GetHashCode Xor _
'                        EMP_NO_LICENCIA.GetHashCode Xor _
'                        EMP_EMPRESA1_ANT.GetHashCode Xor _
'                        EMP_EMPRESA2_ANT.GetHashCode Xor _
'                        EMP_EMPRESA3_ANT.GetHashCode Xor _
'                        EMP_CARGO1_ANT.GetHashCode Xor _
'                        EMP_CARGO2_ANT.GetHashCode Xor _
'                        EMP_CARGO3_ANT.GetHashCode Xor _
'                        EMP_CARCEL.GetHashCode Xor _
'                        EMP_MOTIVO_CARCEL.GetHashCode Xor _
'                        EMP_ANTECEDENTES.GetHashCode Xor _
'                        EMP_REFERENCIA_NOM1.GetHashCode Xor _
'                        EMP_REFERENCIA_NOM2.GetHashCode Xor _
'                        EMP_REFERENCIA_NOM3.GetHashCode Xor _
'                        EMP_REFERENCIA_TEL1.GetHashCode Xor _
'                        EMP_REFERENCIA_TEL2.GetHashCode Xor _
'                        EMP_REFERENCIA_TEL3.GetHashCode Xor _
'                        EMP_ESTADO_CIVIL.GetHashCode Xor _
'                        EMP_FOTO.GetHashCode Xor _
'                        EMP_FECHA_ALTA.GetHashCode Xor _
'                        EMP_INFECTO.GetHashCode Xor _
'                        EMP_HOSPITAL.GetHashCode Xor _
'                        EMP_MOTIVO_HOSPITAL.GetHashCode Xor _
'                        EMP_PUESTO.GetHashCode Xor _
'                        EMP_FILIAL_ASIGNADA.GetHashCode Xor _
'                        EMP_NUMERO_HIJOS.GetHashCode Xor _
'                        EMP_GRADO_ACADEMICO.GetHashCode Xor _
'                        EMP_INSTITUCION_ACADEMICA.GetHashCode Xor _
'                        EMP_SERVICIOS_ESPECIALES.GetHashCode
'                    Catch ex As Exception
'                        Throw New System.Exception("Error Calculando HashCode", ex)
'                    End Try
'                End Function
'            End Structure

'            Private m_str_EMP_EMPRESA As String
'            Private m_int_EMP_CODIGO As Integer
'            Private m_str_EMP_ACTIVO As String
'            Private m_str_EMP_EMPRESA_CONTRATANTE As String
'            Private m_str_EMP_NOMBRE1 As String
'            Private m_str_EMP_NOMBRE2 As String
'            Private m_str_EMP_NOMBRE3 As String
'            Private m_str_EMP_APELLIDO1 As String
'            Private m_str_EMP_APELLIDO2 As String
'            Private m_str_EMP_APELLIDO3 As String
'            Private m_str_EMP_CEDULA As String
'            Private m_str_EMP_EXTENDIDA_EN As String
'            Private m_str_EMP_DPI As String
'            Private m_str_EMP_NIT As String
'            Private m_str_EMP_NIVEL_ACCESO As String
'            Private m_str_EMP_SEXO As String
'            Private m_str_EMP_DIRECCION As String
'            Private m_str_EMP_TEL_CASA As String
'            Private m_str_EMP_TEL_EMERGENCIA As String
'            Private m_str_EMP_TEL_CELULAR As String
'            Private m_str_EMP_ALERGICO_ANTIBIOTICO As String
'            Private m_str_EMP_TIPO_ANTIBIOTICO As String
'            Private m_str_EMP_TIPO_SANGRE As String
'            Private m_str_EMP_SABE_LEER As String
'            Private m_str_EMP_SABE_ESCRIBIR As String
'            Private m_str_EMP_PATH_FOTO As String
'            Private m_str_EMP_LUGAR_NACIMIENTO As String
'            Private m_dt_EMP_FECHA_NACIMIENTO As MySqlDateTime
'            Private m_str_EMP_NO_AFILIACION As String
'            Private m_str_EMP_NOMBRE_CONYUGE As String
'            Private m_str_EMP_TARJETA_SANIDAD As String
'            Private m_str_EMP_CENTRO_SALUD As String
'            Private m_str_EMP_PROFESION_OFICIO As String
'            Private m_str_EMP_NO_LICENCIA As String
'            Private m_str_EMP_EMPRESA1_ANT As String
'            Private m_str_EMP_EMPRESA2_ANT As String
'            Private m_str_EMP_EMPRESA3_ANT As String
'            Private m_str_EMP_CARGO1_ANT As String
'            Private m_str_EMP_CARGO2_ANT As String
'            Private m_str_EMP_CARGO3_ANT As String
'            Private m_str_EMP_CARCEL As String
'            Private m_str_EMP_MOTIVO_CARCEL As String
'            Private m_str_EMP_ANTECEDENTES As String
'            Private m_str_EMP_REFERENCIA_NOM1 As String
'            Private m_str_EMP_REFERENCIA_NOM2 As String
'            Private m_str_EMP_REFERENCIA_NOM3 As String
'            Private m_str_EMP_REFERENCIA_TEL1 As String
'            Private m_str_EMP_REFERENCIA_TEL2 As String
'            Private m_str_EMP_REFERENCIA_TEL3 As String
'            Private m_str_EMP_ESTADO_CIVIL As String
'            Private m_obj_EMP_FOTO As Object
'            Private m_dt_EMP_FECHA_ALTA As MySqlDateTime
'            Private m_str_EMP_INFECTO As String
'            Private m_str_EMP_HOSPITAL As String
'            Private m_str_EMP_MOTIVO_HOSPITAL As String
'            Private m_str_EMP_PUESTO As String
'            Private m_str_EMP_FILIAL_ASIGNADA As String
'            Private m_int_EMP_NUMERO_HIJOS As Integer
'            Private m_str_EMP_GRADO_ACADEMICO As String
'            Private m_str_EMP_INSTITUCION_ACADEMICA As String
'            Private m_obj_EMP_SERVICIOS_ESPECIALES As String
'            Private m_dt_escritura As MySqlDateTime
'            Private MENSAJE As String
'            Private Cantidad_de_la_Clase As Integer = 0
'            Private CON As MySqlConnection
'            Private TRA As MySqlTransaction
'            Private CONstr As String
'            Dim _Usar_Transaccion_Select As Boolean = False
'            Dim _TimeOut As Integer = 30

'#End Region

'#Region "Propiedades"

'            Public Property EMP_EMPRESA() As String
'                Get
'                    Return m_str_EMP_EMPRESA.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_EMPRESA = Value
'                End Set
'            End Property

'            Public Property EMP_CODIGO() As Integer
'                Get
'                    Return m_int_EMP_CODIGO
'                End Get
'                Set(ByVal Value As Integer)
'                    m_int_EMP_CODIGO = Value
'                End Set
'            End Property

'            Public Property EMP_ACTIVO() As String
'                Get
'                    Return m_str_EMP_ACTIVO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_ACTIVO = Value
'                End Set
'            End Property

'            Public Property EMP_EMPRESA_CONTRATANTE() As String
'                Get
'                    Return m_str_EMP_EMPRESA_CONTRATANTE.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_EMPRESA_CONTRATANTE = Value
'                End Set
'            End Property

'            Public Property EMP_NOMBRE1() As String
'                Get
'                    Return m_str_EMP_NOMBRE1.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_NOMBRE1 = Value
'                End Set
'            End Property

'            Public Property EMP_NOMBRE2() As String
'                Get
'                    Return m_str_EMP_NOMBRE2.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_NOMBRE2 = Value
'                End Set
'            End Property

'            Public Property EMP_NOMBRE3() As String
'                Get
'                    Return m_str_EMP_NOMBRE3.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_NOMBRE3 = Value
'                End Set
'            End Property

'            Public Property EMP_APELLIDO1() As String
'                Get
'                    Return m_str_EMP_APELLIDO1.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_APELLIDO1 = Value
'                End Set
'            End Property

'            Public Property EMP_APELLIDO2() As String
'                Get
'                    Return m_str_EMP_APELLIDO2.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_APELLIDO2 = Value
'                End Set
'            End Property

'            Public Property EMP_APELLIDO3() As String
'                Get
'                    Return m_str_EMP_APELLIDO3.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_APELLIDO3 = Value
'                End Set
'            End Property

'            Public Property EMP_CEDULA() As String
'                Get
'                    Return m_str_EMP_CEDULA.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_CEDULA = Value
'                End Set
'            End Property

'            Public Property EMP_EXTENDIDA_EN() As String
'                Get
'                    Return m_str_EMP_EXTENDIDA_EN.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_EXTENDIDA_EN = Value
'                End Set
'            End Property

'            Public Property EMP_DPI() As String
'                Get
'                    Return m_str_EMP_DPI.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_DPI = Value
'                End Set
'            End Property

'            Public Property EMP_NIT() As String
'                Get
'                    Return m_str_EMP_NIT.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_NIT = Value
'                End Set
'            End Property

'            Public Property EMP_NIVEL_ACCESO() As String
'                Get
'                    Return m_str_EMP_NIVEL_ACCESO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_NIVEL_ACCESO = Value
'                End Set
'            End Property

'            Public Property EMP_SEXO() As String
'                Get
'                    Return m_str_EMP_SEXO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_SEXO = Value
'                End Set
'            End Property

'            Public Property EMP_DIRECCION() As String
'                Get
'                    Return m_str_EMP_DIRECCION.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_DIRECCION = Value
'                End Set
'            End Property

'            Public Property EMP_TEL_CASA() As String
'                Get
'                    Return m_str_EMP_TEL_CASA.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_TEL_CASA = Value
'                End Set
'            End Property

'            Public Property EMP_TEL_EMERGENCIA() As String
'                Get
'                    Return m_str_EMP_TEL_EMERGENCIA.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_TEL_EMERGENCIA = Value
'                End Set
'            End Property

'            Public Property EMP_TEL_CELULAR() As String
'                Get
'                    Return m_str_EMP_TEL_CELULAR.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_TEL_CELULAR = Value
'                End Set
'            End Property

'            Public Property EMP_ALERGICO_ANTIBIOTICO() As String
'                Get
'                    Return m_str_EMP_ALERGICO_ANTIBIOTICO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_ALERGICO_ANTIBIOTICO = Value
'                End Set
'            End Property

'            Public Property EMP_TIPO_ANTIBIOTICO() As String
'                Get
'                    Return m_str_EMP_TIPO_ANTIBIOTICO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_TIPO_ANTIBIOTICO = Value
'                End Set
'            End Property

'            Public Property EMP_TIPO_SANGRE() As String
'                Get
'                    Return m_str_EMP_TIPO_SANGRE.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_TIPO_SANGRE = Value
'                End Set
'            End Property

'            Public Property EMP_SABE_LEER() As String
'                Get
'                    Return m_str_EMP_SABE_LEER.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_SABE_LEER = Value
'                End Set
'            End Property

'            Public Property EMP_SABE_ESCRIBIR() As String
'                Get
'                    Return m_str_EMP_SABE_ESCRIBIR.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_SABE_ESCRIBIR = Value
'                End Set
'            End Property

'            Public Property EMP_PATH_FOTO() As String
'                Get
'                    Return m_str_EMP_PATH_FOTO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_PATH_FOTO = Value
'                End Set
'            End Property

'            Public Property EMP_LUGAR_NACIMIENTO() As String
'                Get
'                    Return m_str_EMP_LUGAR_NACIMIENTO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_LUGAR_NACIMIENTO = Value
'                End Set
'            End Property

'            Public Property EMP_FECHA_NACIMIENTO() As MySqlDateTime
'                Get
'                    Return m_dt_EMP_FECHA_NACIMIENTO
'                End Get
'                Set(ByVal Value As MySqlDateTime)
'                    m_dt_EMP_FECHA_NACIMIENTO = Value
'                End Set
'            End Property

'            Public WriteOnly Property EMP_FECHA_NACIMIENTO_NET() As DateTime
'                Set(ByVal Value As DateTime)
'                    m_dt_EMP_FECHA_NACIMIENTO = New MySqlDateTime(Value)
'                End Set
'            End Property

'            Public Property EMP_NO_AFILIACION() As String
'                Get
'                    Return m_str_EMP_NO_AFILIACION.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_NO_AFILIACION = Value
'                End Set
'            End Property

'            Public Property EMP_NOMBRE_CONYUGE() As String
'                Get
'                    Return m_str_EMP_NOMBRE_CONYUGE.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_NOMBRE_CONYUGE = Value
'                End Set
'            End Property

'            Public Property EMP_TARJETA_SANIDAD() As String
'                Get
'                    Return m_str_EMP_TARJETA_SANIDAD.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_TARJETA_SANIDAD = Value
'                End Set
'            End Property

'            Public Property EMP_CENTRO_SALUD() As String
'                Get
'                    Return m_str_EMP_CENTRO_SALUD.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_CENTRO_SALUD = Value
'                End Set
'            End Property

'            Public Property EMP_PROFESION_OFICIO() As String
'                Get
'                    Return m_str_EMP_PROFESION_OFICIO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_PROFESION_OFICIO = Value
'                End Set
'            End Property

'            Public Property EMP_NO_LICENCIA() As String
'                Get
'                    Return m_str_EMP_NO_LICENCIA.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_NO_LICENCIA = Value
'                End Set
'            End Property

'            Public Property EMP_EMPRESA1_ANT() As String
'                Get
'                    Return m_str_EMP_EMPRESA1_ANT.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_EMPRESA1_ANT = Value
'                End Set
'            End Property

'            Public Property EMP_EMPRESA2_ANT() As String
'                Get
'                    Return m_str_EMP_EMPRESA2_ANT.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_EMPRESA2_ANT = Value
'                End Set
'            End Property

'            Public Property EMP_EMPRESA3_ANT() As String
'                Get
'                    Return m_str_EMP_EMPRESA3_ANT.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_EMPRESA3_ANT = Value
'                End Set
'            End Property

'            Public Property EMP_CARGO1_ANT() As String
'                Get
'                    Return m_str_EMP_CARGO1_ANT.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_CARGO1_ANT = Value
'                End Set
'            End Property

'            Public Property EMP_CARGO2_ANT() As String
'                Get
'                    Return m_str_EMP_CARGO2_ANT.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_CARGO2_ANT = Value
'                End Set
'            End Property

'            Public Property EMP_CARGO3_ANT() As String
'                Get
'                    Return m_str_EMP_CARGO3_ANT.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_CARGO3_ANT = Value
'                End Set
'            End Property

'            Public Property EMP_CARCEL() As String
'                Get
'                    Return m_str_EMP_CARCEL.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_CARCEL = Value
'                End Set
'            End Property

'            Public Property EMP_MOTIVO_CARCEL() As String
'                Get
'                    Return m_str_EMP_MOTIVO_CARCEL.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_MOTIVO_CARCEL = Value
'                End Set
'            End Property

'            Public Property EMP_ANTECEDENTES() As String
'                Get
'                    Return m_str_EMP_ANTECEDENTES.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_ANTECEDENTES = Value
'                End Set
'            End Property

'            Public Property EMP_REFERENCIA_NOM1() As String
'                Get
'                    Return m_str_EMP_REFERENCIA_NOM1.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_REFERENCIA_NOM1 = Value
'                End Set
'            End Property

'            Public Property EMP_REFERENCIA_NOM2() As String
'                Get
'                    Return m_str_EMP_REFERENCIA_NOM2.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_REFERENCIA_NOM2 = Value
'                End Set
'            End Property

'            Public Property EMP_REFERENCIA_NOM3() As String
'                Get
'                    Return m_str_EMP_REFERENCIA_NOM3.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_REFERENCIA_NOM3 = Value
'                End Set
'            End Property

'            Public Property EMP_REFERENCIA_TEL1() As String
'                Get
'                    Return m_str_EMP_REFERENCIA_TEL1.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_REFERENCIA_TEL1 = Value
'                End Set
'            End Property

'            Public Property EMP_REFERENCIA_TEL2() As String
'                Get
'                    Return m_str_EMP_REFERENCIA_TEL2.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_REFERENCIA_TEL2 = Value
'                End Set
'            End Property

'            Public Property EMP_REFERENCIA_TEL3() As String
'                Get
'                    Return m_str_EMP_REFERENCIA_TEL3.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_REFERENCIA_TEL3 = Value
'                End Set
'            End Property

'            Public Property EMP_ESTADO_CIVIL() As String
'                Get
'                    Return m_str_EMP_ESTADO_CIVIL.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_ESTADO_CIVIL = Value
'                End Set
'            End Property

'            Public Property EMP_FOTO() As Object
'                Get
'                    Return m_obj_EMP_FOTO
'                End Get
'                Set(ByVal Value As Object)
'                    m_obj_EMP_FOTO = Value
'                End Set
'            End Property

'            Public Property EMP_FECHA_ALTA() As MySqlDateTime
'                Get
'                    Return m_dt_EMP_FECHA_ALTA
'                End Get
'                Set(ByVal Value As MySqlDateTime)
'                    m_dt_EMP_FECHA_ALTA = Value
'                End Set
'            End Property

'            Public WriteOnly Property EMP_FECHA_ALTA_NET() As DateTime
'                Set(ByVal Value As DateTime)
'                    m_dt_EMP_FECHA_ALTA = New MySqlDateTime(Value)
'                End Set
'            End Property

'            Public Property EMP_INFECTO() As String
'                Get
'                    Return m_str_EMP_INFECTO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_INFECTO = Value
'                End Set
'            End Property

'            Public Property EMP_HOSPITAL() As String
'                Get
'                    Return m_str_EMP_HOSPITAL.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_HOSPITAL = Value
'                End Set
'            End Property

'            Public Property EMP_MOTIVO_HOSPITAL() As String
'                Get
'                    Return m_str_EMP_MOTIVO_HOSPITAL.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_MOTIVO_HOSPITAL = Value
'                End Set
'            End Property

'            Public Property EMP_PUESTO() As String
'                Get
'                    Return m_str_EMP_PUESTO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_PUESTO = Value
'                End Set
'            End Property

'            Public Property EMP_FILIAL_ASIGNADA() As String
'                Get
'                    Return m_str_EMP_FILIAL_ASIGNADA.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_FILIAL_ASIGNADA = Value
'                End Set
'            End Property

'            Public Property EMP_NUMERO_HIJOS() As Integer
'                Get
'                    Return m_int_EMP_NUMERO_HIJOS
'                End Get
'                Set(ByVal Value As Integer)
'                    m_int_EMP_NUMERO_HIJOS = Value
'                End Set
'            End Property

'            Public Property EMP_GRADO_ACADEMICO() As String
'                Get
'                    Return m_str_EMP_GRADO_ACADEMICO.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_GRADO_ACADEMICO = Value
'                End Set
'            End Property

'            Public Property EMP_INSTITUCION_ACADEMICA() As String
'                Get
'                    Return m_str_EMP_INSTITUCION_ACADEMICA.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_str_EMP_INSTITUCION_ACADEMICA = Value
'                End Set
'            End Property

'            Public Property EMP_SERVICIOS_ESPECIALES() As String
'                Get
'                    Return m_obj_EMP_SERVICIOS_ESPECIALES.Trim()
'                End Get
'                Set(ByVal Value As String)
'                    m_obj_EMP_SERVICIOS_ESPECIALES = Value
'                End Set
'            End Property

'            Public Property ESCRITURA() As MySqlDateTime
'                Get
'                    Return m_dt_escritura
'                End Get
'                Set(ByVal Value As MySqlDateTime)
'                    m_dt_escritura = Value
'                End Set
'            End Property

'            Public WriteOnly Property escritura_NET() As DateTime
'                Set(ByVal Value As DateTime)
'                    m_dt_escritura = New MySqlDateTime(Value)
'                End Set
'            End Property

'            Public ReadOnly Property CantRecorSet() As Integer
'                Get
'                    Return Cantidad_de_la_Clase
'                End Get
'            End Property

'            Public Property CONEXION() As String
'                Set(ByVal VALUE As String)
'                    CONstr = VALUE
'                    Try
'                        MENSAJE = ""
'                        Dim Status As Tipo_Status_Ping = Verifica_PING(VALUE)
'                        If Status <> Tipo_Status_Ping.OK Then
'                            MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - CONEXION No se logro hacer pineo a Servidor Error:" & _
'                                      Status.ToString
'                            Throw New System.Exception("Error. No se logro hacer pineo a Servidor" & vbNewLine & _
'                                                       "Conexión:" & VALUE & vbNewLine & "Error:" & Status.ToString)
'                            Exit Property
'                        End If
'                        If IsNothing(CON) Then CON = New MySqlConnection
'                        If CON.State = ConnectionState.Open Then CON.Close()
'                        CON.ConnectionString = CONstr
'                        CON.Open()
'                    Catch MyEX As MySqlException
'                        MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - CONEXION MyError=" & MyEX.ToString
'                        Throw New System.Exception("MySQLError#:" & MyEX.Number.ToString("0000") & " Error MySQL Conectando con Servidor" & vbNewLine & "Conexión:" & VALUE, MyEX)
'                    Catch EX As Exception
'                        MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - CONEXION Error=" & EX.ToString
'                        Throw New System.Exception("Error no contemplado Conectando Servidor" & vbNewLine & "Conexión:" & VALUE, EX)
'                    End Try
'                End Set
'                Get
'                    Return CONstr
'                End Get
'            End Property

'            Public WriteOnly Property TRANSACCION() As MySqlTransaction
'                Set(ByVal VALUE As MySqlTransaction)
'                    TRA = VALUE
'                    _Usar_Transaccion_Select = False
'                    If Not IsNothing(VALUE) Then _Usar_Transaccion_Select = True
'                End Set
'            End Property

'            Public ReadOnly Property MERROR() As String
'                Get
'                    Return MENSAJE
'                End Get
'            End Property

'            Public Property Usar_Transaccion_Select As Boolean
'                Get
'                    Return _Usar_Transaccion_Select
'                End Get
'                Set(ByVal Value As Boolean)
'                    _Usar_Transaccion_Select = Value
'                End Set
'            End Property

'            Public Property TimeOut() As Integer
'                Get
'                    Return _TimeOut
'                End Get
'                Set(ByVal Value As Integer)
'                    _TimeOut = Value
'                End Set
'            End Property

'#End Region

'#Region "Funciones Publicas"

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Sub New()
'                INIT()
'                INIT_LLAVE()
'            End Sub

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Sub Reset(Optional ByVal Tipo As Definicion.TipoReset = Definicion.TipoReset.Data)
'                Try
'                    MENSAJE = ""
'                    _Usar_Transaccion_Select = False
'                    INIT_LLAVE()
'                    INIT()
'                    If Tipo = Definicion.TipoReset.Full Then Dispose()
'                    Cantidad_de_la_Clase = 0
'                Catch Ex As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - RESET No se pudo hacer el Reset de la Clase" & Ex.ToString
'                    Throw New System.Exception("Error no Contemplado", Ex)
'                Finally
'                    System.GC.Collect()
'                End Try
'            End Sub

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Sub Dispose()
'                Try
'                    If Not IsNothing(CON) Then
'                        If CON.State = ConnectionState.Open Then CON.Close()
'                        CON.Dispose()
'                        CON = Nothing
'                    End If
'                    Lista = Nothing

'                    If Not IsNothing(DA) Then DA.Dispose()
'                    DA = Nothing

'                    If Not IsNothing(DS) Then
'                        DS.Clear()
'                        DS.Dispose()
'                        DS = Nothing
'                    End If

'                    _Usar_Transaccion_Select = False
'                    TRA = Nothing
'                Catch EX As Exception
'                End Try
'            End Sub

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Private Sub INIT()
'                EMP_ACTIVO = ""
'                EMP_EMPRESA_CONTRATANTE = ""
'                EMP_NOMBRE1 = ""
'                EMP_NOMBRE2 = ""
'                EMP_NOMBRE3 = ""
'                EMP_APELLIDO1 = ""
'                EMP_APELLIDO2 = ""
'                EMP_APELLIDO3 = ""
'                EMP_CEDULA = ""
'                EMP_EXTENDIDA_EN = ""
'                EMP_DPI = ""
'                EMP_NIT = ""
'                EMP_NIVEL_ACCESO = ""
'                EMP_SEXO = ""
'                EMP_DIRECCION = ""
'                EMP_TEL_CASA = ""
'                EMP_TEL_EMERGENCIA = ""
'                EMP_TEL_CELULAR = ""
'                EMP_ALERGICO_ANTIBIOTICO = ""
'                EMP_TIPO_ANTIBIOTICO = ""
'                EMP_TIPO_SANGRE = ""
'                EMP_SABE_LEER = ""
'                EMP_SABE_ESCRIBIR = ""
'                EMP_PATH_FOTO = ""
'                EMP_LUGAR_NACIMIENTO = ""
'                EMP_FECHA_NACIMIENTO = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
'                EMP_NO_AFILIACION = ""
'                EMP_NOMBRE_CONYUGE = ""
'                EMP_TARJETA_SANIDAD = ""
'                EMP_CENTRO_SALUD = ""
'                EMP_PROFESION_OFICIO = ""
'                EMP_NO_LICENCIA = ""
'                EMP_EMPRESA1_ANT = ""
'                EMP_EMPRESA2_ANT = ""
'                EMP_EMPRESA3_ANT = ""
'                EMP_CARGO1_ANT = ""
'                EMP_CARGO2_ANT = ""
'                EMP_CARGO3_ANT = ""
'                EMP_CARCEL = ""
'                EMP_MOTIVO_CARCEL = ""
'                EMP_ANTECEDENTES = ""
'                EMP_REFERENCIA_NOM1 = ""
'                EMP_REFERENCIA_NOM2 = ""
'                EMP_REFERENCIA_NOM3 = ""
'                EMP_REFERENCIA_TEL1 = ""
'                EMP_REFERENCIA_TEL2 = ""
'                EMP_REFERENCIA_TEL3 = ""
'                EMP_ESTADO_CIVIL = ""
'                EMP_FOTO = Nothing
'                EMP_FECHA_ALTA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
'                EMP_INFECTO = ""
'                EMP_HOSPITAL = ""
'                EMP_MOTIVO_HOSPITAL = ""
'                EMP_PUESTO = ""
'                EMP_FILIAL_ASIGNADA = ""
'                EMP_NUMERO_HIJOS = 0
'                EMP_GRADO_ACADEMICO = ""
'                EMP_INSTITUCION_ACADEMICA = ""
'                EMP_SERVICIOS_ESPECIALES = ""
'                ESCRITURA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
'            End Sub

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Private Sub INIT_LLAVE()
'                EMP_EMPRESA = ""
'                EMP_CODIGO = 0
'            End Sub

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Private Function Pone_Valores_Internos(R As DataRow) As Boolean
'                Pone_Valores_Internos = False
'                Try
'                    If Not IsDBNull(R.Item("EMP_EMPRESA")) Then
'                        m_str_EMP_EMPRESA = CType(R.Item("EMP_EMPRESA"), String)
'                    Else
'                        m_str_EMP_EMPRESA = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_CODIGO")) Then
'                        m_int_EMP_CODIGO = CType(R.Item("EMP_CODIGO"), Integer)
'                    Else
'                        m_int_EMP_CODIGO = -1
'                    End If
'                    If Not IsDBNull(R.Item("EMP_ACTIVO")) Then
'                        m_str_EMP_ACTIVO = CType(R.Item("EMP_ACTIVO"), String)
'                    Else
'                        m_str_EMP_ACTIVO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_EMPRESA_CONTRATANTE")) Then
'                        m_str_EMP_EMPRESA_CONTRATANTE = CType(R.Item("EMP_EMPRESA_CONTRATANTE"), String)
'                    Else
'                        m_str_EMP_EMPRESA_CONTRATANTE = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_NOMBRE1")) Then
'                        m_str_EMP_NOMBRE1 = CType(R.Item("EMP_NOMBRE1"), String)
'                    Else
'                        m_str_EMP_NOMBRE1 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_NOMBRE2")) Then
'                        m_str_EMP_NOMBRE2 = CType(R.Item("EMP_NOMBRE2"), String)
'                    Else
'                        m_str_EMP_NOMBRE2 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_NOMBRE3")) Then
'                        m_str_EMP_NOMBRE3 = CType(R.Item("EMP_NOMBRE3"), String)
'                    Else
'                        m_str_EMP_NOMBRE3 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_APELLIDO1")) Then
'                        m_str_EMP_APELLIDO1 = CType(R.Item("EMP_APELLIDO1"), String)
'                    Else
'                        m_str_EMP_APELLIDO1 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_APELLIDO2")) Then
'                        m_str_EMP_APELLIDO2 = CType(R.Item("EMP_APELLIDO2"), String)
'                    Else
'                        m_str_EMP_APELLIDO2 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_APELLIDO3")) Then
'                        m_str_EMP_APELLIDO3 = CType(R.Item("EMP_APELLIDO3"), String)
'                    Else
'                        m_str_EMP_APELLIDO3 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_CEDULA")) Then
'                        m_str_EMP_CEDULA = CType(R.Item("EMP_CEDULA"), String)
'                    Else
'                        m_str_EMP_CEDULA = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_EXTENDIDA_EN")) Then
'                        m_str_EMP_EXTENDIDA_EN = CType(R.Item("EMP_EXTENDIDA_EN"), String)
'                    Else
'                        m_str_EMP_EXTENDIDA_EN = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_DPI")) Then
'                        m_str_EMP_DPI = CType(R.Item("EMP_DPI"), String)
'                    Else
'                        m_str_EMP_DPI = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_NIT")) Then
'                        m_str_EMP_NIT = CType(R.Item("EMP_NIT"), String)
'                    Else
'                        m_str_EMP_NIT = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_NIVEL_ACCESO")) Then
'                        m_str_EMP_NIVEL_ACCESO = CType(R.Item("EMP_NIVEL_ACCESO"), String)
'                    Else
'                        m_str_EMP_NIVEL_ACCESO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_SEXO")) Then
'                        m_str_EMP_SEXO = CType(R.Item("EMP_SEXO"), String)
'                    Else
'                        m_str_EMP_SEXO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_DIRECCION")) Then
'                        m_str_EMP_DIRECCION = CType(R.Item("EMP_DIRECCION"), String)
'                    Else
'                        m_str_EMP_DIRECCION = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_TEL_CASA")) Then
'                        m_str_EMP_TEL_CASA = CType(R.Item("EMP_TEL_CASA"), String)
'                    Else
'                        m_str_EMP_TEL_CASA = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_TEL_EMERGENCIA")) Then
'                        m_str_EMP_TEL_EMERGENCIA = CType(R.Item("EMP_TEL_EMERGENCIA"), String)
'                    Else
'                        m_str_EMP_TEL_EMERGENCIA = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_TEL_CELULAR")) Then
'                        m_str_EMP_TEL_CELULAR = CType(R.Item("EMP_TEL_CELULAR"), String)
'                    Else
'                        m_str_EMP_TEL_CELULAR = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_ALERGICO_ANTIBIOTICO")) Then
'                        m_str_EMP_ALERGICO_ANTIBIOTICO = CType(R.Item("EMP_ALERGICO_ANTIBIOTICO"), String)
'                    Else
'                        m_str_EMP_ALERGICO_ANTIBIOTICO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_TIPO_ANTIBIOTICO")) Then
'                        m_str_EMP_TIPO_ANTIBIOTICO = CType(R.Item("EMP_TIPO_ANTIBIOTICO"), String)
'                    Else
'                        m_str_EMP_TIPO_ANTIBIOTICO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_TIPO_SANGRE")) Then
'                        m_str_EMP_TIPO_SANGRE = CType(R.Item("EMP_TIPO_SANGRE"), String)
'                    Else
'                        m_str_EMP_TIPO_SANGRE = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_SABE_LEER")) Then
'                        m_str_EMP_SABE_LEER = CType(R.Item("EMP_SABE_LEER"), String)
'                    Else
'                        m_str_EMP_SABE_LEER = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_SABE_ESCRIBIR")) Then
'                        m_str_EMP_SABE_ESCRIBIR = CType(R.Item("EMP_SABE_ESCRIBIR"), String)
'                    Else
'                        m_str_EMP_SABE_ESCRIBIR = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_PATH_FOTO")) Then
'                        m_str_EMP_PATH_FOTO = CType(R.Item("EMP_PATH_FOTO"), String)
'                    Else
'                        m_str_EMP_PATH_FOTO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_LUGAR_NACIMIENTO")) Then
'                        m_str_EMP_LUGAR_NACIMIENTO = CType(R.Item("EMP_LUGAR_NACIMIENTO"), String)
'                    Else
'                        m_str_EMP_LUGAR_NACIMIENTO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_FECHA_NACIMIENTO")) Then
'                        m_dt_EMP_FECHA_NACIMIENTO = CType(R.Item("EMP_FECHA_NACIMIENTO"), MySqlDateTime)
'                        If Not m_dt_EMP_FECHA_NACIMIENTO.IsValidDateTime Then
'                            If m_dt_EMP_FECHA_NACIMIENTO.ToString = "0000-00-00 00:00:00" Then
'                                m_dt_EMP_FECHA_NACIMIENTO = New MySqlDateTime(1900, 1, 1, 0, 0, 0, 0)
'                            End If
'                        End If
'                    End If
'                    If Not IsDBNull(R.Item("EMP_NO_AFILIACION")) Then
'                        m_str_EMP_NO_AFILIACION = CType(R.Item("EMP_NO_AFILIACION"), String)
'                    Else
'                        m_str_EMP_NO_AFILIACION = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_NOMBRE_CONYUGE")) Then
'                        m_str_EMP_NOMBRE_CONYUGE = CType(R.Item("EMP_NOMBRE_CONYUGE"), String)
'                    Else
'                        m_str_EMP_NOMBRE_CONYUGE = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_TARJETA_SANIDAD")) Then
'                        m_str_EMP_TARJETA_SANIDAD = CType(R.Item("EMP_TARJETA_SANIDAD"), String)
'                    Else
'                        m_str_EMP_TARJETA_SANIDAD = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_CENTRO_SALUD")) Then
'                        m_str_EMP_CENTRO_SALUD = CType(R.Item("EMP_CENTRO_SALUD"), String)
'                    Else
'                        m_str_EMP_CENTRO_SALUD = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_PROFESION_OFICIO")) Then
'                        m_str_EMP_PROFESION_OFICIO = CType(R.Item("EMP_PROFESION_OFICIO"), String)
'                    Else
'                        m_str_EMP_PROFESION_OFICIO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_NO_LICENCIA")) Then
'                        m_str_EMP_NO_LICENCIA = CType(R.Item("EMP_NO_LICENCIA"), String)
'                    Else
'                        m_str_EMP_NO_LICENCIA = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_EMPRESA1_ANT")) Then
'                        m_str_EMP_EMPRESA1_ANT = CType(R.Item("EMP_EMPRESA1_ANT"), String)
'                    Else
'                        m_str_EMP_EMPRESA1_ANT = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_EMPRESA2_ANT")) Then
'                        m_str_EMP_EMPRESA2_ANT = CType(R.Item("EMP_EMPRESA2_ANT"), String)
'                    Else
'                        m_str_EMP_EMPRESA2_ANT = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_EMPRESA3_ANT")) Then
'                        m_str_EMP_EMPRESA3_ANT = CType(R.Item("EMP_EMPRESA3_ANT"), String)
'                    Else
'                        m_str_EMP_EMPRESA3_ANT = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_CARGO1_ANT")) Then
'                        m_str_EMP_CARGO1_ANT = CType(R.Item("EMP_CARGO1_ANT"), String)
'                    Else
'                        m_str_EMP_CARGO1_ANT = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_CARGO2_ANT")) Then
'                        m_str_EMP_CARGO2_ANT = CType(R.Item("EMP_CARGO2_ANT"), String)
'                    Else
'                        m_str_EMP_CARGO2_ANT = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_CARGO3_ANT")) Then
'                        m_str_EMP_CARGO3_ANT = CType(R.Item("EMP_CARGO3_ANT"), String)
'                    Else
'                        m_str_EMP_CARGO3_ANT = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_CARCEL")) Then
'                        m_str_EMP_CARCEL = CType(R.Item("EMP_CARCEL"), String)
'                    Else
'                        m_str_EMP_CARCEL = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_MOTIVO_CARCEL")) Then
'                        m_str_EMP_MOTIVO_CARCEL = CType(R.Item("EMP_MOTIVO_CARCEL"), String)
'                    Else
'                        m_str_EMP_MOTIVO_CARCEL = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_ANTECEDENTES")) Then
'                        m_str_EMP_ANTECEDENTES = CType(R.Item("EMP_ANTECEDENTES"), String)
'                    Else
'                        m_str_EMP_ANTECEDENTES = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_REFERENCIA_NOM1")) Then
'                        m_str_EMP_REFERENCIA_NOM1 = CType(R.Item("EMP_REFERENCIA_NOM1"), String)
'                    Else
'                        m_str_EMP_REFERENCIA_NOM1 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_REFERENCIA_NOM2")) Then
'                        m_str_EMP_REFERENCIA_NOM2 = CType(R.Item("EMP_REFERENCIA_NOM2"), String)
'                    Else
'                        m_str_EMP_REFERENCIA_NOM2 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_REFERENCIA_NOM3")) Then
'                        m_str_EMP_REFERENCIA_NOM3 = CType(R.Item("EMP_REFERENCIA_NOM3"), String)
'                    Else
'                        m_str_EMP_REFERENCIA_NOM3 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_REFERENCIA_TEL1")) Then
'                        m_str_EMP_REFERENCIA_TEL1 = CType(R.Item("EMP_REFERENCIA_TEL1"), String)
'                    Else
'                        m_str_EMP_REFERENCIA_TEL1 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_REFERENCIA_TEL2")) Then
'                        m_str_EMP_REFERENCIA_TEL2 = CType(R.Item("EMP_REFERENCIA_TEL2"), String)
'                    Else
'                        m_str_EMP_REFERENCIA_TEL2 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_REFERENCIA_TEL3")) Then
'                        m_str_EMP_REFERENCIA_TEL3 = CType(R.Item("EMP_REFERENCIA_TEL3"), String)
'                    Else
'                        m_str_EMP_REFERENCIA_TEL3 = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_ESTADO_CIVIL")) Then
'                        m_str_EMP_ESTADO_CIVIL = CType(R.Item("EMP_ESTADO_CIVIL"), String)
'                    Else
'                        m_str_EMP_ESTADO_CIVIL = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_FOTO")) Then
'                        m_obj_EMP_FOTO = CType(R.Item("EMP_FOTO"), Byte())
'                    End If
'                    If Not IsDBNull(R.Item("EMP_FECHA_ALTA")) Then
'                        m_dt_EMP_FECHA_ALTA = CType(R.Item("EMP_FECHA_ALTA"), MySqlDateTime)
'                        If Not m_dt_EMP_FECHA_ALTA.IsValidDateTime Then
'                            If m_dt_EMP_FECHA_ALTA.ToString = "0000-00-00 00:00:00" Then
'                                m_dt_EMP_FECHA_ALTA = New MySqlDateTime(1900, 1, 1, 0, 0, 0, 0)
'                            End If
'                        End If
'                    End If
'                    If Not IsDBNull(R.Item("EMP_INFECTO")) Then
'                        m_str_EMP_INFECTO = CType(R.Item("EMP_INFECTO"), String)
'                    Else
'                        m_str_EMP_INFECTO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_HOSPITAL")) Then
'                        m_str_EMP_HOSPITAL = CType(R.Item("EMP_HOSPITAL"), String)
'                    Else
'                        m_str_EMP_HOSPITAL = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_MOTIVO_HOSPITAL")) Then
'                        m_str_EMP_MOTIVO_HOSPITAL = CType(R.Item("EMP_MOTIVO_HOSPITAL"), String)
'                    Else
'                        m_str_EMP_MOTIVO_HOSPITAL = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_PUESTO")) Then
'                        m_str_EMP_PUESTO = CType(R.Item("EMP_PUESTO"), String)
'                    Else
'                        m_str_EMP_PUESTO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_FILIAL_ASIGNADA")) Then
'                        m_str_EMP_FILIAL_ASIGNADA = CType(R.Item("EMP_FILIAL_ASIGNADA"), String)
'                    Else
'                        m_str_EMP_FILIAL_ASIGNADA = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_NUMERO_HIJOS")) Then
'                        m_int_EMP_NUMERO_HIJOS = CType(R.Item("EMP_NUMERO_HIJOS"), Integer)
'                    Else
'                        m_int_EMP_NUMERO_HIJOS = -1
'                    End If
'                    If Not IsDBNull(R.Item("EMP_GRADO_ACADEMICO")) Then
'                        m_str_EMP_GRADO_ACADEMICO = CType(R.Item("EMP_GRADO_ACADEMICO"), String)
'                    Else
'                        m_str_EMP_GRADO_ACADEMICO = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_INSTITUCION_ACADEMICA")) Then
'                        m_str_EMP_INSTITUCION_ACADEMICA = CType(R.Item("EMP_INSTITUCION_ACADEMICA"), String)
'                    Else
'                        m_str_EMP_INSTITUCION_ACADEMICA = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("EMP_SERVICIOS_ESPECIALES")) Then
'                        m_obj_EMP_SERVICIOS_ESPECIALES = CType(R.Item("EMP_SERVICIOS_ESPECIALES"), String)
'                    Else
'                        m_obj_EMP_SERVICIOS_ESPECIALES = "NULL"
'                    End If
'                    If Not IsDBNull(R.Item("escritura")) Then
'                        m_dt_escritura = CType(R.Item("escritura"), MySqlDateTime)
'                        If Not m_dt_escritura.IsValidDateTime Then
'                            If m_dt_escritura.ToString = "0000-00-00 00:00:00" Then
'                                m_dt_escritura = New MySqlDateTime(1900, 1, 1, 0, 0, 0, 0)
'                            End If
'                        End If
'                    End If
'                    Pone_Valores_Internos = True
'                Catch EX As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - Pone_Valores_Internos Error=" & EX.ToString
'                    Throw New System.Exception("Error No Contemplado", EX)
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PMOVE_NEXT() As Boolean
'                PMOVE_NEXT = False
'                Try
'                    MENSAJE = ""
'                    INIT()
'                    INIT_LLAVE()

'                    If IsNothing(Lista) Then
'                        MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PMOVE_NEXT No se ha seleccionado data."
'                        Throw New System.Exception("Para ejecutar el PMOVE_NEXT, antes tiene que ejecutar PSELECT_RECORDSET")
'                        Exit Function
'                    End If

'                    If POS_DS <= Lista.Length - 1 Then
'                        Pone_Valores_Internos(Lista(POS_DS))
'                        POS_DS += 1
'                        PMOVE_NEXT = True
'                    Else
'                        Lista = Nothing
'                        Exit Function
'                    End If
'                Catch EX As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PMOVE_NEXT Error=" & EX.ToString
'                    Throw New System.Exception("BiblioTablas - TDEFINICION_EMPLEADOS - PMOVE_NEXT, Error no contemplado.", EX)
'                Finally
'                    System.GC.Collect()
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PSUB_SELECT(ByVal condicion As String, Optional ByVal Ordenamiento As String = "") As Boolean
'                PSUB_SELECT = False
'                Try
'                    Lista = Nothing
'                    If IsNothing(DS) Then
'                        MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSUB_SELECT Error=Tiene que hacer un PSelect_Recordset para hacer un PSub_Select"
'                        Throw New System.Exception("Tiene que hacer un PSELECT_RECORDSET para hacer un PSUB_SELECT")
'                    End If

'                    If Ordenamiento.Length <> 0 Then
'                        Lista = DS.Tables("definicion_empleados").Select(condicion, Ordenamiento)
'                    Else
'                        Lista = DS.Tables("definicion_empleados").Select(condicion)
'                    End If
'                    POS_DS = 0
'                    Cantidad_de_la_Clase = 0
'                    If Not IsNothing(Lista) Then Cantidad_de_la_Clase = Lista.Length
'                    If Cantidad_de_la_Clase <> 0 Then Return True
'                Catch ex As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSUB_SELECT Error=" & ex.ToString
'                    Throw New System.Exception("Error no contemplado Condición:" & condicion & vbNewLine & "Ordenamiento:" & Ordenamiento, ex)
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PSELECT_RECORDSET(Optional ByVal CONDICION As String = "",
'                                              Optional ByVal ORDENAMIENTO As String = "",
'                                              Optional ByVal Solo_Contar As Boolean = False,
'                                              Optional ByVal Indice As Tipo_Indices = Tipo_Indices.Ninguno) As Boolean
'                Dim SQL As String

'                PSELECT_RECORDSET = False
'                MENSAJE = ""

'                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Lectura)

'                If Not IsNothing(DS) Then
'                    DS.Clear()
'                    DS.Dispose()
'                    DS = Nothing
'                End If
'                DS = New DataSet("definicion_empleados")

'                If Not IsNothing(DA) Then
'                    DA.Dispose()
'                    DA = Nothing
'                End If

'                If Indice <> Tipo_Indices.Ninguno Then
'                    SQL = "Select * from definicion_empleados use index(" & Indice.ToString & ")"
'                Else
'                    SQL = "Select * from definicion_empleados"
'                End If
'                If CONDICION.Length <> 0 Then SQL &= " Where " & CONDICION
'                If ORDENAMIENTO.Length <> 0 Then SQL &= " Order By " & ORDENAMIENTO

'                Try
'                    INIT()
'                    INIT_LLAVE()
'                    If _Usar_Transaccion_Select Then
'                        DA = New MySqlDataAdapter(SQL, TRA.Connection)
'                    Else
'                        DA = New MySqlDataAdapter(SQL, CON)
'                    End If
'                    DA.SelectCommand.CommandType = CommandType.Text
'                    DA.SelectCommand.CommandTimeout = _TimeOut
'                    Cantidad_de_la_Clase = DA.Fill(DS, "definicion_empleados")
'                    Lista = DS.Tables("definicion_empleados").Select()
'                    POS_DS = 0

'                    If Cantidad_de_la_Clase <> 0 Then PSELECT_RECORDSET = True
'                Catch MYEX As MySqlException
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT_RECORDSET MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
'                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL Condición:" & CONDICION & vbNewLine & "Ordenamiento:" & ORDENAMIENTO, MYEX)
'                Catch EX As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT_RECORDSET Error=" & EX.ToString
'                    Throw New System.Exception("Error no contemplado Condición:" & CONDICION & vbNewLine & "Ordenamiento:" & ORDENAMIENTO, EX)
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PSELECT(ByVal KEMP_EMPRESA As String, ByVal KEMP_CODIGO As Integer) As Boolean
'                Dim DSL As DataSet = Nothing
'                Dim DAL As MySqlDataAdapter = Nothing
'                Dim SQL As String

'                MENSAJE = ""
'                PSELECT = False

'                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Lectura)
'                SQL = "SELECT * FROM definicion_empleados WHERE EMP_EMPRESA = ?P1 AND EMP_CODIGO = ?P2"

'                Try
'                    INIT()
'                    INIT_LLAVE()
'                    DSL = New DataSet("definicion_empleados")
'                    If _Usar_Transaccion_Select Then
'                        DAL = New MySqlDataAdapter(SQL, TRA.Connection)
'                    Else
'                        DAL = New MySqlDataAdapter(SQL, CON)
'                    End If
'                    DAL.SelectCommand.Parameters.AddWithValue("?P1", KEMP_EMPRESA)
'                    DAL.SelectCommand.Parameters.AddWithValue("?P2", KEMP_CODIGO)
'                    DAL.SelectCommand.CommandType = CommandType.Text
'                    DAL.SelectCommand.CommandTimeout = _TimeOut

'                    If DAL.Fill(DSL, "definicion_empleados") > 0 Then
'                        Pone_Valores_Internos(DSL.Tables("definicion_empleados").Rows(0))
'                        PSELECT = True
'                    Else
'                        PSELECT = False
'                    End If

'                Catch MYEX As MySqlException
'                    Dim tt As String = "Llave:" & KEMP_EMPRESA & "-" & KEMP_CODIGO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
'                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. " & tt, MYEX)
'                Catch EX As Exception
'                    Dim tt As String = "Llave:" & KEMP_EMPRESA & "-" & KEMP_CODIGO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT Error=" & EX.ToString
'                    Throw New System.Exception("Error no Contemplado. " & tt, EX)
'                Finally
'                    If Not IsNothing(DSL) Then
'                        DSL.Dispose()
'                        DSL = Nothing
'                    End If
'                    If Not IsNothing(DAL) Then
'                        DAL.Dispose()
'                        DAL = Nothing
'                    End If
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PSELECT_CONDICION(ByVal CONDICION As String, Optional ByVal Indice As Tipo_Indices = Tipo_Indices.Ninguno) As Boolean
'                Dim DSL As DataSet = Nothing
'                Dim DAL As MySqlDataAdapter = Nothing
'                Dim SQL As String

'                MENSAJE = ""
'                PSELECT_CONDICION = False

'                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Lectura)

'                If Indice <> Tipo_Indices.Ninguno Then
'                    SQL = "SELECT * FROM definicion_empleados use index(" & Indice.ToString & ") WHERE " & CONDICION
'                Else
'                    SQL = "SELECT * FROM definicion_empleados WHERE " & CONDICION
'                End If

'                Try
'                    INIT()
'                    INIT_LLAVE()

'                    DSL = New DataSet("definicion_empleados")
'                    If _Usar_Transaccion_Select Then
'                        DAL = New MySqlDataAdapter(SQL, TRA.Connection)
'                    Else
'                        DAL = New MySqlDataAdapter(SQL, CON)
'                    End If
'                    DAL.SelectCommand.CommandType = CommandType.Text
'                    DAL.SelectCommand.CommandTimeout = _TimeOut
'                    If DAL.Fill(DSL, "definicion_empleados") > 0 Then
'                        Pone_Valores_Internos(DSL.Tables("definicion_empleados").Rows(0))
'                        PSELECT_CONDICION = True
'                    Else
'                        PSELECT_CONDICION = False
'                    End If

'                Catch MYEX As MySqlException
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT_CONDICION MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
'                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. Condición:" & CONDICION, MYEX)
'                Catch EX As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT_CONDICION Error=" & EX.ToString
'                    Throw New System.Exception("Error no contemplado. Condición:" & CONDICION, EX)
'                Finally
'                    If Not IsNothing(DSL) Then
'                        DSL.Dispose()
'                        DSL = Nothing
'                    End If
'                    If Not IsNothing(DAL) Then
'                        DAL.Dispose()
'                        DAL = Nothing
'                    End If
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PSELECT_DATASET(ByRef DataS As DataSet,
'                Optional ByVal CAMPOS As String = "",
'                Optional ByVal CONDICION As String = "",
'                Optional ByVal ORDENAMIENTO As String = "",
'                Optional ByVal INDICE As Tipo_Indices = Tipo_Indices.Ninguno) As Boolean

'                Dim DataA As MySqlDataAdapter = Nothing
'                Dim SQL As String

'                PSELECT_DATASET = False

'                If Not IsNothing(DataS) Then
'                    DataS.Clear()
'                    DataS.Dispose()
'                    DataS = Nothing
'                End If
'                DataS = New DataSet()

'                If CAMPOS.Length <> 0 Then
'                    If INDICE <> Tipo_Indices.Ninguno Then
'                        SQL = "Select " & CAMPOS & " from definicion_empleados use index(" & INDICE.ToString & ")"
'                    Else
'                        SQL = "Select " & CAMPOS & " from definicion_empleados"
'                    End If
'                Else
'                    If INDICE <> Tipo_Indices.Ninguno Then
'                        SQL = "Select * from definicion_empleados use index(" & INDICE.ToString & ")"
'                    Else
'                        SQL = "Select * from definicion_empleados"
'                    End If
'                End If
'                If CONDICION.Length <> 0 Then SQL &= " Where " & CONDICION
'                If ORDENAMIENTO.Length <> 0 Then SQL &= " Order By " & ORDENAMIENTO
'                Cantidad_de_la_Clase = 0

'                Try
'                    If _Usar_Transaccion_Select Then
'                        DataA = New MySqlDataAdapter(SQL, TRA.Connection)
'                    Else
'                        DataA = New MySqlDataAdapter(SQL, CON)
'                    End If
'                    Cantidad_de_la_Clase = DataA.Fill(DataS, "definicion_empleados")
'                    Return True
'                Catch MYEX As MySqlException
'                    Dim tt As String = vbNewLine & "Campos:" & CAMPOS & vbNewLine &
'                        "Condición:" & CONDICION & vbNewLine &
'                        "Ordenamiento:" & ORDENAMIENTO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT_DATASET MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
'                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. Sql=" & SQL & " " & tt, MYEX)
'                Catch EX As Exception
'                    Dim tt As String = vbNewLine & "Campos:" & CAMPOS & vbNewLine & _
'                            "Condición:" & CONDICION & vbNewLine & _
'                            "Ordenamiento:" & ORDENAMIENTO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT_DATASET Error=" & EX.ToString
'                    Throw New System.Exception("Error no contemplado." & tt, EX)
'                Finally
'                    If Not IsNothing(DataA) Then
'                        DataA.Dispose()
'                        DataA = Nothing
'                    End If
'                    System.GC.Collect()
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PSELECT_READER(ByRef READER As MySqlDataReader, _
'                Optional ByVal CAMPOS As String = "", _
'                Optional ByVal CONDICION As String = "", _
'                Optional ByVal ORDENAMIENTO As String = "") As Boolean
'                Dim COM As MySqlCommand
'                Dim SQL As String
'                Dim SQL1 As String

'                MENSAJE = ""
'                PSELECT_READER = False

'                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Lectura)

'                If CAMPOS.Length = 0 Then
'                    SQL = "Select * from definicion_empleados"
'                Else
'                    SQL = "SELECT " & CAMPOS & " FROM definicion_empleados"
'                End If
'                If CONDICION.Length <> 0 Then SQL &= " Where " & CONDICION
'                If ORDENAMIENTO.Length <> 0 Then SQL &= " Order By " & ORDENAMIENTO

'                SQL1 = "Select Count(*) as Cuenta from definicion_empleados"
'                If CONDICION.Length <> 0 Then SQL1 &= " Where " & CONDICION

'                READER = Nothing
'                COM = Nothing
'                Try
'                    INIT()
'                    INIT_LLAVE()
'                    If _Usar_Transaccion_Select Then
'                        COM = New MySqlCommand(SQL1, TRA.Connection, TRA)
'                    Else
'                        COM = New MySqlCommand(SQL1, CON)
'                    End If
'                    COM.CommandType = CommandType.Text
'                    COM.CommandTimeout = _TimeOut
'                    Cantidad_de_la_Clase = CInt(COM.ExecuteScalar())
'                    COM.Dispose()
'                    COM = Nothing

'                    If _Usar_Transaccion_Select Then
'                        COM = New MySqlCommand(SQL, TRA.Connection)
'                    Else
'                        COM = New MySqlCommand(SQL, CON)
'                    End If
'                    COM.CommandType = CommandType.Text
'                    COM.CommandTimeout = _TimeOut
'                    READER = COM.ExecuteReader()
'                    PSELECT_READER = True
'                Catch MYEX As MySqlException
'                    Dim tt As String = vbNewLine & "Campos:" & CAMPOS & vbNewLine & _
'                        "Condición:" & CONDICION & vbNewLine & _
'                        "Ordenamiento:" & ORDENAMIENTO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT_READER MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
'                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. SQL1=" & SQL1 & vbNewLine & "Sql=" & SQL & tt, MYEX)
'                Catch EX As Exception
'                    Dim tt As String = vbNewLine & "Campos:" & CAMPOS & vbNewLine & _
'                            "Condición:" & CONDICION & vbNewLine & _
'                            "Ordenamiento:" & ORDENAMIENTO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PSELECT_READER Error=" & EX.ToString
'                    Throw New System.Exception("Error no contemplado." & tt, EX)
'                Finally
'                    If Not IsNothing(COM) Then
'                        COM.Dispose()
'                        COM = Nothing
'                    End If
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PINSERT() As Boolean
'                Dim COM As MySqlCommand = Nothing
'                Dim SQL As String

'                MENSAJE = ""
'                PINSERT = False

'                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Insert)

'                Try
'                    SQL = "INSERT INTO definicion_empleados (EMP_EMPRESA,EMP_CODIGO,EMP_ACTIVO,EMP_EMPRESA_CONTRATANTE,EMP_NOMBRE1,EMP_NOMBRE2,EMP_NOMBRE3,EMP_APELLIDO1,EMP_APELLIDO2,EMP_APELLIDO3,EMP_CEDULA,EMP_EXTENDIDA_EN,EMP_DPI,EMP_NIT,EMP_NIVEL_ACCESO,EMP_SEXO,EMP_DIRECCION,EMP_TEL_CASA,EMP_TEL_EMERGENCIA,EMP_TEL_CELULAR,EMP_ALERGICO_ANTIBIOTICO,EMP_TIPO_ANTIBIOTICO,EMP_TIPO_SANGRE,EMP_SABE_LEER,EMP_SABE_ESCRIBIR,EMP_PATH_FOTO,EMP_LUGAR_NACIMIENTO,EMP_FECHA_NACIMIENTO,EMP_NO_AFILIACION,EMP_NOMBRE_CONYUGE,EMP_TARJETA_SANIDAD,EMP_CENTRO_SALUD,EMP_PROFESION_OFICIO,EMP_NO_LICENCIA,EMP_EMPRESA1_ANT,EMP_EMPRESA2_ANT,EMP_EMPRESA3_ANT,EMP_CARGO1_ANT,EMP_CARGO2_ANT,EMP_CARGO3_ANT,EMP_CARCEL,EMP_MOTIVO_CARCEL,EMP_ANTECEDENTES,EMP_REFERENCIA_NOM1,EMP_REFERENCIA_NOM2,EMP_REFERENCIA_NOM3,EMP_REFERENCIA_TEL1,EMP_REFERENCIA_TEL2,EMP_REFERENCIA_TEL3,EMP_ESTADO_CIVIL,EMP_FOTO,EMP_FECHA_ALTA,EMP_INFECTO,EMP_HOSPITAL,EMP_MOTIVO_HOSPITAL,EMP_PUESTO,EMP_FILIAL_ASIGNADA,EMP_NUMERO_HIJOS,EMP_GRADO_ACADEMICO,EMP_INSTITUCION_ACADEMICA,EMP_SERVICIOS_ESPECIALES,escritura) " & _
'                        "VALUES(?P1,?P2,?P3,?P4,?P5,?P6,?P7,?P8,?P9,?P10,?P11,?P12,?P13,?P14,?P15,?P16,?P17,?P18,?P19,?P20,?P21,?P22,?P23,?P24,?P25,?P26,?P27,?P28,?P29,?P30,?P31,?P32,?P33,?P34,?P35,?P36,?P37,?P38,?P39,?P40,?P41,?P42,?P43,?P44,?P45,?P46,?P47,?P48,?P49,?P50,?P51,?P52,?P53,?P54,?P55,?P56,?P57,?P58,?P59,?P60,?P61,?P62)"
'                    If _Usar_Transaccion_Select Then
'                        COM = New MySqlCommand(SQL, TRA.Connection, TRA)
'                    Else
'                        COM = New MySqlCommand(SQL, CON)
'                    End If
'                    COM.CommandType = CommandType.Text
'                    COM.CommandTimeout = _TimeOut
'                    If m_str_EMP_EMPRESA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P1", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P1", m_str_EMP_EMPRESA)
'                    End If
'                    If m_int_EMP_CODIGO = -1 Then
'                        COM.Parameters.AddWithValue("?P2", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P2", m_int_EMP_CODIGO)
'                    End If
'                    If m_str_EMP_ACTIVO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P3", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P3", m_str_EMP_ACTIVO)
'                    End If
'                    If m_str_EMP_EMPRESA_CONTRATANTE.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P4", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P4", m_str_EMP_EMPRESA_CONTRATANTE)
'                    End If
'                    If m_str_EMP_NOMBRE1.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P5", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P5", m_str_EMP_NOMBRE1)
'                    End If
'                    If m_str_EMP_NOMBRE2.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P6", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P6", m_str_EMP_NOMBRE2)
'                    End If
'                    If m_str_EMP_NOMBRE3.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P7", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P7", m_str_EMP_NOMBRE3)
'                    End If
'                    If m_str_EMP_APELLIDO1.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P8", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P8", m_str_EMP_APELLIDO1)
'                    End If
'                    If m_str_EMP_APELLIDO2.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P9", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P9", m_str_EMP_APELLIDO2)
'                    End If
'                    If m_str_EMP_APELLIDO3.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P10", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P10", m_str_EMP_APELLIDO3)
'                    End If
'                    If m_str_EMP_CEDULA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P11", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P11", m_str_EMP_CEDULA)
'                    End If
'                    If m_str_EMP_EXTENDIDA_EN.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P12", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P12", m_str_EMP_EXTENDIDA_EN)
'                    End If
'                    If m_str_EMP_DPI.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P13", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P13", m_str_EMP_DPI)
'                    End If
'                    If m_str_EMP_NIT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P14", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P14", m_str_EMP_NIT)
'                    End If
'                    If m_str_EMP_NIVEL_ACCESO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P15", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P15", m_str_EMP_NIVEL_ACCESO)
'                    End If
'                    If m_str_EMP_SEXO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P16", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P16", m_str_EMP_SEXO)
'                    End If
'                    If m_str_EMP_DIRECCION.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P17", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P17", m_str_EMP_DIRECCION)
'                    End If
'                    If m_str_EMP_TEL_CASA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P18", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P18", m_str_EMP_TEL_CASA)
'                    End If
'                    If m_str_EMP_TEL_EMERGENCIA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P19", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P19", m_str_EMP_TEL_EMERGENCIA)
'                    End If
'                    If m_str_EMP_TEL_CELULAR.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P20", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P20", m_str_EMP_TEL_CELULAR)
'                    End If
'                    If m_str_EMP_ALERGICO_ANTIBIOTICO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P21", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P21", m_str_EMP_ALERGICO_ANTIBIOTICO)
'                    End If
'                    If m_str_EMP_TIPO_ANTIBIOTICO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P22", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P22", m_str_EMP_TIPO_ANTIBIOTICO)
'                    End If
'                    If m_str_EMP_TIPO_SANGRE.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P23", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P23", m_str_EMP_TIPO_SANGRE)
'                    End If
'                    If m_str_EMP_SABE_LEER.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P24", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P24", m_str_EMP_SABE_LEER)
'                    End If
'                    If m_str_EMP_SABE_ESCRIBIR.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P25", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P25", m_str_EMP_SABE_ESCRIBIR)
'                    End If
'                    If m_str_EMP_PATH_FOTO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P26", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P26", m_str_EMP_PATH_FOTO)
'                    End If
'                    If m_str_EMP_LUGAR_NACIMIENTO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P27", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P27", m_str_EMP_LUGAR_NACIMIENTO)
'                    End If
'                    If m_dt_EMP_FECHA_NACIMIENTO.IsValidDateTime = False Then
'                        COM.Parameters.AddWithValue("?P28", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P28", m_dt_EMP_FECHA_NACIMIENTO.Value)
'                    End If
'                    If m_str_EMP_NO_AFILIACION.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P29", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P29", m_str_EMP_NO_AFILIACION)
'                    End If
'                    If m_str_EMP_NOMBRE_CONYUGE.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P30", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P30", m_str_EMP_NOMBRE_CONYUGE)
'                    End If
'                    If m_str_EMP_TARJETA_SANIDAD.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P31", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P31", m_str_EMP_TARJETA_SANIDAD)
'                    End If
'                    If m_str_EMP_CENTRO_SALUD.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P32", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P32", m_str_EMP_CENTRO_SALUD)
'                    End If
'                    If m_str_EMP_PROFESION_OFICIO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P33", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P33", m_str_EMP_PROFESION_OFICIO)
'                    End If
'                    If m_str_EMP_NO_LICENCIA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P34", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P34", m_str_EMP_NO_LICENCIA)
'                    End If
'                    If m_str_EMP_EMPRESA1_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P35", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P35", m_str_EMP_EMPRESA1_ANT)
'                    End If
'                    If m_str_EMP_EMPRESA2_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P36", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P36", m_str_EMP_EMPRESA2_ANT)
'                    End If
'                    If m_str_EMP_EMPRESA3_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P37", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P37", m_str_EMP_EMPRESA3_ANT)
'                    End If
'                    If m_str_EMP_CARGO1_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P38", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P38", m_str_EMP_CARGO1_ANT)
'                    End If
'                    If m_str_EMP_CARGO2_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P39", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P39", m_str_EMP_CARGO2_ANT)
'                    End If
'                    If m_str_EMP_CARGO3_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P40", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P40", m_str_EMP_CARGO3_ANT)
'                    End If
'                    If m_str_EMP_CARCEL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P41", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P41", m_str_EMP_CARCEL)
'                    End If
'                    If m_str_EMP_MOTIVO_CARCEL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P42", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P42", m_str_EMP_MOTIVO_CARCEL)
'                    End If
'                    If m_str_EMP_ANTECEDENTES.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P43", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P43", m_str_EMP_ANTECEDENTES)
'                    End If
'                    If m_str_EMP_REFERENCIA_NOM1.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P44", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P44", m_str_EMP_REFERENCIA_NOM1)
'                    End If
'                    If m_str_EMP_REFERENCIA_NOM2.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P45", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P45", m_str_EMP_REFERENCIA_NOM2)
'                    End If
'                    If m_str_EMP_REFERENCIA_NOM3.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P46", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P46", m_str_EMP_REFERENCIA_NOM3)
'                    End If
'                    If m_str_EMP_REFERENCIA_TEL1.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P47", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P47", m_str_EMP_REFERENCIA_TEL1)
'                    End If
'                    If m_str_EMP_REFERENCIA_TEL2.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P48", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P48", m_str_EMP_REFERENCIA_TEL2)
'                    End If
'                    If m_str_EMP_REFERENCIA_TEL3.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P49", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P49", m_str_EMP_REFERENCIA_TEL3)
'                    End If
'                    If m_str_EMP_ESTADO_CIVIL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P50", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P50", m_str_EMP_ESTADO_CIVIL)
'                    End If
'                    COM.Parameters.AddWithValue("?P51", m_obj_EMP_FOTO)
'                    If m_dt_EMP_FECHA_ALTA.IsValidDateTime = False Then
'                        COM.Parameters.AddWithValue("?P52", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P52", m_dt_EMP_FECHA_ALTA.Value)
'                    End If
'                    If m_str_EMP_INFECTO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P53", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P53", m_str_EMP_INFECTO)
'                    End If
'                    If m_str_EMP_HOSPITAL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P54", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P54", m_str_EMP_HOSPITAL)
'                    End If
'                    If m_str_EMP_MOTIVO_HOSPITAL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P55", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P55", m_str_EMP_MOTIVO_HOSPITAL)
'                    End If
'                    If m_str_EMP_PUESTO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P56", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P56", m_str_EMP_PUESTO)
'                    End If
'                    If m_str_EMP_FILIAL_ASIGNADA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P57", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P57", m_str_EMP_FILIAL_ASIGNADA)
'                    End If
'                    If m_int_EMP_NUMERO_HIJOS = -1 Then
'                        COM.Parameters.AddWithValue("?P58", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P58", m_int_EMP_NUMERO_HIJOS)
'                    End If
'                    If m_str_EMP_GRADO_ACADEMICO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P59", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P59", m_str_EMP_GRADO_ACADEMICO)
'                    End If
'                    If m_str_EMP_INSTITUCION_ACADEMICA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P60", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P60", m_str_EMP_INSTITUCION_ACADEMICA)
'                    End If
'                    If m_obj_EMP_SERVICIOS_ESPECIALES.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P61", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P61", m_obj_EMP_SERVICIOS_ESPECIALES)
'                    End If
'                    COM.Parameters.AddWithValue("?P62", Now)
'                    COM.ExecuteNonQuery()
'                    PINSERT = True
'                Catch MYEX As MySqlException
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PINSERT MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
'                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL.", MYEX)
'                Catch ex As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PINSERT Error=" & ex.ToString
'                    Throw New System.Exception("Error no contemplado.", ex)
'                Finally
'                    If Not IsNothing(COM) Then
'                        COM.Dispose()
'                        COM = Nothing
'                    End If
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PDELETE(Optional ByVal Condicion As String = "") As Boolean
'                Dim COM As MySqlCommand = Nothing
'                Dim SQL As String = ""

'                MENSAJE = ""
'                PDELETE = False

'                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Delete)

'                Try
'                    If Condicion.Length <> 0 Then
'                        SQL = "DELETE FROM definicion_empleados WHERE " & Condicion
'                        If _Usar_Transaccion_Select Then
'                            COM = New MySqlCommand(SQL, TRA.Connection, TRA)
'                        Else
'                            COM = New MySqlCommand(SQL, CON)
'                        End If
'                        COM.CommandType = CommandType.Text
'                        COM.CommandTimeout = _TimeOut
'                    Else
'                        SQL = "DELETE FROM definicion_empleados WHERE EMP_EMPRESA = ?P1  AND EMP_CODIGO = ?P2 "
'                        If _Usar_Transaccion_Select Then
'                            COM = New MySqlCommand(SQL, TRA.Connection, TRA)
'                        Else
'                            COM = New MySqlCommand(SQL, CON)
'                        End If
'                        COM.CommandType = CommandType.Text
'                        COM.CommandTimeout = _TimeOut
'                        COM.Parameters.AddWithValue("?P1", m_str_EMP_EMPRESA)
'                        COM.Parameters.AddWithValue("?P2", m_int_EMP_CODIGO)
'                    End If
'                    If COM.ExecuteNonQuery <= 0 Then
'                        PDELETE = False
'                    Else
'                        PDELETE = True
'                    End If
'                Catch MYEX As MySqlException
'                    Dim tt As String = vbNewLine & "Llave:" & m_str_EMP_EMPRESA & "-" & m_int_EMP_CODIGO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PDELETE MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
'                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. SQL=" & SQL & tt, MYEX)
'                Catch ex As Exception
'                    Dim tt As String = vbNewLine & "Llave:" & m_str_EMP_EMPRESA & "-" & m_int_EMP_CODIGO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PDELETE Error=" & ex.ToString
'                    Throw New System.Exception("Error no Contemplado Sql=." & SQL & tt, ex)
'                Finally
'                    If Not IsNothing(COM) Then
'                        COM.Dispose()
'                        COM = Nothing
'                    End If
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Public Function PUPDATE() As Boolean
'                Dim COM As MySqlCommand = Nothing
'                Dim SQL As String = ""

'                MENSAJE = ""
'                PUPDATE = False

'                Definicion.Verifica_Conexion(_Usar_Transaccion_Select, TRA, CON, MENSAJE, Definicion.Tipo_de_Funcion.Update)

'                Try
'                    SQL = "UPDATE definicion_empleados SET EMP_ACTIVO = ?P3, EMP_EMPRESA_CONTRATANTE = ?P4, EMP_NOMBRE1 = ?P5, EMP_NOMBRE2 = ?P6, EMP_NOMBRE3 = ?P7, EMP_APELLIDO1 = ?P8, EMP_APELLIDO2 = ?P9, EMP_APELLIDO3 = ?P10, EMP_CEDULA = ?P11, EMP_EXTENDIDA_EN = ?P12, EMP_DPI = ?P13, EMP_NIT = ?P14, EMP_NIVEL_ACCESO = ?P15, EMP_SEXO = ?P16, EMP_DIRECCION = ?P17, EMP_TEL_CASA = ?P18, EMP_TEL_EMERGENCIA = ?P19, EMP_TEL_CELULAR = ?P20, EMP_ALERGICO_ANTIBIOTICO = ?P21, EMP_TIPO_ANTIBIOTICO = ?P22, EMP_TIPO_SANGRE = ?P23, EMP_SABE_LEER = ?P24, EMP_SABE_ESCRIBIR = ?P25, EMP_PATH_FOTO = ?P26, EMP_LUGAR_NACIMIENTO = ?P27, EMP_FECHA_NACIMIENTO = ?P28, EMP_NO_AFILIACION = ?P29, EMP_NOMBRE_CONYUGE = ?P30, EMP_TARJETA_SANIDAD = ?P31, EMP_CENTRO_SALUD = ?P32, EMP_PROFESION_OFICIO = ?P33, EMP_NO_LICENCIA = ?P34, EMP_EMPRESA1_ANT = ?P35, EMP_EMPRESA2_ANT = ?P36, EMP_EMPRESA3_ANT = ?P37, EMP_CARGO1_ANT = ?P38, EMP_CARGO2_ANT = ?P39, EMP_CARGO3_ANT = ?P40, EMP_CARCEL = ?P41, EMP_MOTIVO_CARCEL = ?P42, EMP_ANTECEDENTES = ?P43, EMP_REFERENCIA_NOM1 = ?P44, EMP_REFERENCIA_NOM2 = ?P45, EMP_REFERENCIA_NOM3 = ?P46, EMP_REFERENCIA_TEL1 = ?P47, EMP_REFERENCIA_TEL2 = ?P48, EMP_REFERENCIA_TEL3 = ?P49, EMP_ESTADO_CIVIL = ?P50, EMP_FOTO = ?P51, EMP_FECHA_ALTA = ?P52, EMP_INFECTO = ?P53, EMP_HOSPITAL = ?P54, EMP_MOTIVO_HOSPITAL = ?P55, EMP_PUESTO = ?P56, EMP_FILIAL_ASIGNADA = ?P57, EMP_NUMERO_HIJOS = ?P58, EMP_GRADO_ACADEMICO = ?P59, EMP_INSTITUCION_ACADEMICA = ?P60, EMP_SERVICIOS_ESPECIALES = ?P61, escritura = ?P62 WHERE EMP_EMPRESA = ?P1 AND EMP_CODIGO = ?P2"
'                    If _Usar_Transaccion_Select Then
'                        COM = New MySqlCommand(SQL, TRA.Connection, TRA)
'                    Else
'                        COM = New MySqlCommand(SQL, CON)
'                    End If
'                    COM.CommandType = CommandType.Text
'                    COM.CommandTimeout = _TimeOut

'                    If m_str_EMP_ACTIVO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P3", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P3", m_str_EMP_ACTIVO)
'                    End If
'                    If m_str_EMP_EMPRESA_CONTRATANTE.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P4", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P4", m_str_EMP_EMPRESA_CONTRATANTE)
'                    End If
'                    If m_str_EMP_NOMBRE1.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P5", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P5", m_str_EMP_NOMBRE1)
'                    End If
'                    If m_str_EMP_NOMBRE2.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P6", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P6", m_str_EMP_NOMBRE2)
'                    End If
'                    If m_str_EMP_NOMBRE3.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P7", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P7", m_str_EMP_NOMBRE3)
'                    End If
'                    If m_str_EMP_APELLIDO1.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P8", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P8", m_str_EMP_APELLIDO1)
'                    End If
'                    If m_str_EMP_APELLIDO2.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P9", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P9", m_str_EMP_APELLIDO2)
'                    End If
'                    If m_str_EMP_APELLIDO3.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P10", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P10", m_str_EMP_APELLIDO3)
'                    End If
'                    If m_str_EMP_CEDULA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P11", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P11", m_str_EMP_CEDULA)
'                    End If
'                    If m_str_EMP_EXTENDIDA_EN.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P12", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P12", m_str_EMP_EXTENDIDA_EN)
'                    End If
'                    If m_str_EMP_DPI.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P13", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P13", m_str_EMP_DPI)
'                    End If
'                    If m_str_EMP_NIT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P14", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P14", m_str_EMP_NIT)
'                    End If
'                    If m_str_EMP_NIVEL_ACCESO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P15", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P15", m_str_EMP_NIVEL_ACCESO)
'                    End If
'                    If m_str_EMP_SEXO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P16", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P16", m_str_EMP_SEXO)
'                    End If
'                    If m_str_EMP_DIRECCION.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P17", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P17", m_str_EMP_DIRECCION)
'                    End If
'                    If m_str_EMP_TEL_CASA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P18", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P18", m_str_EMP_TEL_CASA)
'                    End If
'                    If m_str_EMP_TEL_EMERGENCIA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P19", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P19", m_str_EMP_TEL_EMERGENCIA)
'                    End If
'                    If m_str_EMP_TEL_CELULAR.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P20", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P20", m_str_EMP_TEL_CELULAR)
'                    End If
'                    If m_str_EMP_ALERGICO_ANTIBIOTICO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P21", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P21", m_str_EMP_ALERGICO_ANTIBIOTICO)
'                    End If
'                    If m_str_EMP_TIPO_ANTIBIOTICO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P22", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P22", m_str_EMP_TIPO_ANTIBIOTICO)
'                    End If
'                    If m_str_EMP_TIPO_SANGRE.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P23", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P23", m_str_EMP_TIPO_SANGRE)
'                    End If
'                    If m_str_EMP_SABE_LEER.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P24", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P24", m_str_EMP_SABE_LEER)
'                    End If
'                    If m_str_EMP_SABE_ESCRIBIR.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P25", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P25", m_str_EMP_SABE_ESCRIBIR)
'                    End If
'                    If m_str_EMP_PATH_FOTO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P26", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P26", m_str_EMP_PATH_FOTO)
'                    End If
'                    If m_str_EMP_LUGAR_NACIMIENTO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P27", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P27", m_str_EMP_LUGAR_NACIMIENTO)
'                    End If
'                    If m_dt_EMP_FECHA_NACIMIENTO.IsValidDateTime = False Then
'                        COM.Parameters.AddWithValue("?P28", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P28", m_dt_EMP_FECHA_NACIMIENTO.Value)
'                    End If
'                    If m_str_EMP_NO_AFILIACION.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P29", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P29", m_str_EMP_NO_AFILIACION)
'                    End If
'                    If m_str_EMP_NOMBRE_CONYUGE.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P30", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P30", m_str_EMP_NOMBRE_CONYUGE)
'                    End If
'                    If m_str_EMP_TARJETA_SANIDAD.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P31", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P31", m_str_EMP_TARJETA_SANIDAD)
'                    End If
'                    If m_str_EMP_CENTRO_SALUD.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P32", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P32", m_str_EMP_CENTRO_SALUD)
'                    End If
'                    If m_str_EMP_PROFESION_OFICIO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P33", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P33", m_str_EMP_PROFESION_OFICIO)
'                    End If
'                    If m_str_EMP_NO_LICENCIA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P34", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P34", m_str_EMP_NO_LICENCIA)
'                    End If
'                    If m_str_EMP_EMPRESA1_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P35", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P35", m_str_EMP_EMPRESA1_ANT)
'                    End If
'                    If m_str_EMP_EMPRESA2_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P36", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P36", m_str_EMP_EMPRESA2_ANT)
'                    End If
'                    If m_str_EMP_EMPRESA3_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P37", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P37", m_str_EMP_EMPRESA3_ANT)
'                    End If
'                    If m_str_EMP_CARGO1_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P38", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P38", m_str_EMP_CARGO1_ANT)
'                    End If
'                    If m_str_EMP_CARGO2_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P39", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P39", m_str_EMP_CARGO2_ANT)
'                    End If
'                    If m_str_EMP_CARGO3_ANT.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P40", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P40", m_str_EMP_CARGO3_ANT)
'                    End If
'                    If m_str_EMP_CARCEL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P41", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P41", m_str_EMP_CARCEL)
'                    End If
'                    If m_str_EMP_MOTIVO_CARCEL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P42", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P42", m_str_EMP_MOTIVO_CARCEL)
'                    End If
'                    If m_str_EMP_ANTECEDENTES.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P43", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P43", m_str_EMP_ANTECEDENTES)
'                    End If
'                    If m_str_EMP_REFERENCIA_NOM1.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P44", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P44", m_str_EMP_REFERENCIA_NOM1)
'                    End If
'                    If m_str_EMP_REFERENCIA_NOM2.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P45", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P45", m_str_EMP_REFERENCIA_NOM2)
'                    End If
'                    If m_str_EMP_REFERENCIA_NOM3.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P46", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P46", m_str_EMP_REFERENCIA_NOM3)
'                    End If
'                    If m_str_EMP_REFERENCIA_TEL1.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P47", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P47", m_str_EMP_REFERENCIA_TEL1)
'                    End If
'                    If m_str_EMP_REFERENCIA_TEL2.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P48", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P48", m_str_EMP_REFERENCIA_TEL2)
'                    End If
'                    If m_str_EMP_REFERENCIA_TEL3.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P49", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P49", m_str_EMP_REFERENCIA_TEL3)
'                    End If
'                    If m_str_EMP_ESTADO_CIVIL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P50", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P50", m_str_EMP_ESTADO_CIVIL)
'                    End If
'                    COM.Parameters.AddWithValue("?P51", m_obj_EMP_FOTO)
'                    If m_dt_EMP_FECHA_ALTA.IsValidDateTime = False Then
'                        COM.Parameters.AddWithValue("?P52", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P52", m_dt_EMP_FECHA_ALTA.Value)
'                    End If
'                    If m_str_EMP_INFECTO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P53", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P53", m_str_EMP_INFECTO)
'                    End If
'                    If m_str_EMP_HOSPITAL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P54", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P54", m_str_EMP_HOSPITAL)
'                    End If
'                    If m_str_EMP_MOTIVO_HOSPITAL.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P55", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P55", m_str_EMP_MOTIVO_HOSPITAL)
'                    End If
'                    If m_str_EMP_PUESTO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P56", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P56", m_str_EMP_PUESTO)
'                    End If
'                    If m_str_EMP_FILIAL_ASIGNADA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P57", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P57", m_str_EMP_FILIAL_ASIGNADA)
'                    End If
'                    If m_int_EMP_NUMERO_HIJOS = -1 Then
'                        COM.Parameters.AddWithValue("?P58", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P58", m_int_EMP_NUMERO_HIJOS)
'                    End If
'                    If m_str_EMP_GRADO_ACADEMICO.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P59", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P59", m_str_EMP_GRADO_ACADEMICO)
'                    End If
'                    If m_str_EMP_INSTITUCION_ACADEMICA.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P60", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P60", m_str_EMP_INSTITUCION_ACADEMICA)
'                    End If
'                    If m_obj_EMP_SERVICIOS_ESPECIALES.ToUpper = "NULL" Then
'                        COM.Parameters.AddWithValue("?P61", DBNull.Value)
'                    Else
'                        COM.Parameters.AddWithValue("?P61", m_obj_EMP_SERVICIOS_ESPECIALES)
'                    End If
'                    COM.Parameters.AddWithValue("?P62", Now)  'Es TimeStamp , Pongo Fecha Actual.
'                    COM.Parameters.AddWithValue("?P1", m_str_EMP_EMPRESA)
'                    COM.Parameters.AddWithValue("?P2", m_int_EMP_CODIGO)
'                    If COM.ExecuteNonQuery <= 0 Then
'                        PUPDATE = False
'                    Else
'                        PUPDATE = True
'                    End If
'                Catch MYEX As MySqlException
'                    Dim tt As String = vbNewLine & "Llave:" & m_str_EMP_EMPRESA & "-" & m_int_EMP_CODIGO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PUPDATE MyError#=" & MYEX.Number & " MyError=" & MYEX.ToString
'                    Throw New System.Exception("MySQLError#:" & MYEX.Number.ToString("0000") & " Error de MySQL. SQL=" & SQL & tt, MYEX)
'                Catch ex As Exception
'                    Dim tt As String = vbNewLine & "Llave:" & m_str_EMP_EMPRESA & "-" & m_int_EMP_CODIGO
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PUPDATE Error=" & ex.ToString
'                    Throw New System.Exception("Error no contemplado." & tt, ex)
'                Finally
'                    If Not IsNothing(COM) Then
'                        COM.Dispose()
'                        COM = Nothing
'                    End If
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Function PRECUPERA_REGISTRO() As DEFINICION_EMPLEADOS
'                Dim VAL As New DEFINICION_EMPLEADOS
'                VAL.EMP_EMPRESA = ""
'                VAL.EMP_CODIGO = 0
'                VAL.Simon_REGISTRO = False
'                VAL.MERROR = ""
'                PRECUPERA_REGISTRO = VAL
'                Try
'                    VAL.EMP_EMPRESA = EMP_EMPRESA
'                    VAL.EMP_CODIGO = EMP_CODIGO
'                    VAL.EMP_ACTIVO = EMP_ACTIVO
'                    VAL.EMP_EMPRESA_CONTRATANTE = EMP_EMPRESA_CONTRATANTE
'                    VAL.EMP_NOMBRE1 = EMP_NOMBRE1
'                    VAL.EMP_NOMBRE2 = EMP_NOMBRE2
'                    VAL.EMP_NOMBRE3 = EMP_NOMBRE3
'                    VAL.EMP_APELLIDO1 = EMP_APELLIDO1
'                    VAL.EMP_APELLIDO2 = EMP_APELLIDO2
'                    VAL.EMP_APELLIDO3 = EMP_APELLIDO3
'                    VAL.EMP_CEDULA = EMP_CEDULA
'                    VAL.EMP_EXTENDIDA_EN = EMP_EXTENDIDA_EN
'                    VAL.EMP_DPI = EMP_DPI
'                    VAL.EMP_NIT = EMP_NIT
'                    VAL.EMP_NIVEL_ACCESO = EMP_NIVEL_ACCESO
'                    VAL.EMP_SEXO = EMP_SEXO
'                    VAL.EMP_DIRECCION = EMP_DIRECCION
'                    VAL.EMP_TEL_CASA = EMP_TEL_CASA
'                    VAL.EMP_TEL_EMERGENCIA = EMP_TEL_EMERGENCIA
'                    VAL.EMP_TEL_CELULAR = EMP_TEL_CELULAR
'                    VAL.EMP_ALERGICO_ANTIBIOTICO = EMP_ALERGICO_ANTIBIOTICO
'                    VAL.EMP_TIPO_ANTIBIOTICO = EMP_TIPO_ANTIBIOTICO
'                    VAL.EMP_TIPO_SANGRE = EMP_TIPO_SANGRE
'                    VAL.EMP_SABE_LEER = EMP_SABE_LEER
'                    VAL.EMP_SABE_ESCRIBIR = EMP_SABE_ESCRIBIR
'                    VAL.EMP_PATH_FOTO = EMP_PATH_FOTO
'                    VAL.EMP_LUGAR_NACIMIENTO = EMP_LUGAR_NACIMIENTO
'                    VAL.EMP_FECHA_NACIMIENTO = EMP_FECHA_NACIMIENTO
'                    VAL.EMP_NO_AFILIACION = EMP_NO_AFILIACION
'                    VAL.EMP_NOMBRE_CONYUGE = EMP_NOMBRE_CONYUGE
'                    VAL.EMP_TARJETA_SANIDAD = EMP_TARJETA_SANIDAD
'                    VAL.EMP_CENTRO_SALUD = EMP_CENTRO_SALUD
'                    VAL.EMP_PROFESION_OFICIO = EMP_PROFESION_OFICIO
'                    VAL.EMP_NO_LICENCIA = EMP_NO_LICENCIA
'                    VAL.EMP_EMPRESA1_ANT = EMP_EMPRESA1_ANT
'                    VAL.EMP_EMPRESA2_ANT = EMP_EMPRESA2_ANT
'                    VAL.EMP_EMPRESA3_ANT = EMP_EMPRESA3_ANT
'                    VAL.EMP_CARGO1_ANT = EMP_CARGO1_ANT
'                    VAL.EMP_CARGO2_ANT = EMP_CARGO2_ANT
'                    VAL.EMP_CARGO3_ANT = EMP_CARGO3_ANT
'                    VAL.EMP_CARCEL = EMP_CARCEL
'                    VAL.EMP_MOTIVO_CARCEL = EMP_MOTIVO_CARCEL
'                    VAL.EMP_ANTECEDENTES = EMP_ANTECEDENTES
'                    VAL.EMP_REFERENCIA_NOM1 = EMP_REFERENCIA_NOM1
'                    VAL.EMP_REFERENCIA_NOM2 = EMP_REFERENCIA_NOM2
'                    VAL.EMP_REFERENCIA_NOM3 = EMP_REFERENCIA_NOM3
'                    VAL.EMP_REFERENCIA_TEL1 = EMP_REFERENCIA_TEL1
'                    VAL.EMP_REFERENCIA_TEL2 = EMP_REFERENCIA_TEL2
'                    VAL.EMP_REFERENCIA_TEL3 = EMP_REFERENCIA_TEL3
'                    VAL.EMP_ESTADO_CIVIL = EMP_ESTADO_CIVIL
'                    VAL.EMP_FOTO = EMP_FOTO
'                    VAL.EMP_FECHA_ALTA = EMP_FECHA_ALTA
'                    VAL.EMP_INFECTO = EMP_INFECTO
'                    VAL.EMP_HOSPITAL = EMP_HOSPITAL
'                    VAL.EMP_MOTIVO_HOSPITAL = EMP_MOTIVO_HOSPITAL
'                    VAL.EMP_PUESTO = EMP_PUESTO
'                    VAL.EMP_FILIAL_ASIGNADA = EMP_FILIAL_ASIGNADA
'                    VAL.EMP_NUMERO_HIJOS = EMP_NUMERO_HIJOS
'                    VAL.EMP_GRADO_ACADEMICO = EMP_GRADO_ACADEMICO
'                    VAL.EMP_INSTITUCION_ACADEMICA = EMP_INSTITUCION_ACADEMICA
'                    VAL.EMP_SERVICIOS_ESPECIALES = EMP_SERVICIOS_ESPECIALES
'                    VAL.ESCRITURA = ESCRITURA
'                    VAL.Simon_REGISTRO = True
'                    PRECUPERA_REGISTRO = VAL
'                Catch Ex As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PRECUPERA_REGISTRO Error=" & Ex.ToString
'                    Throw New System.Exception("Error no Contemplado", Ex)
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Function PPONE_REGISTRO(ByVal VAL As DEFINICION_EMPLEADOS) As Boolean
'                PPONE_REGISTRO = False
'                Try
'                    EMP_EMPRESA = VAL.EMP_EMPRESA
'                    EMP_CODIGO = VAL.EMP_CODIGO
'                    EMP_ACTIVO = VAL.EMP_ACTIVO
'                    EMP_EMPRESA_CONTRATANTE = VAL.EMP_EMPRESA_CONTRATANTE
'                    EMP_NOMBRE1 = VAL.EMP_NOMBRE1
'                    EMP_NOMBRE2 = VAL.EMP_NOMBRE2
'                    EMP_NOMBRE3 = VAL.EMP_NOMBRE3
'                    EMP_APELLIDO1 = VAL.EMP_APELLIDO1
'                    EMP_APELLIDO2 = VAL.EMP_APELLIDO2
'                    EMP_APELLIDO3 = VAL.EMP_APELLIDO3
'                    EMP_CEDULA = VAL.EMP_CEDULA
'                    EMP_EXTENDIDA_EN = VAL.EMP_EXTENDIDA_EN
'                    EMP_DPI = VAL.EMP_DPI
'                    EMP_NIT = VAL.EMP_NIT
'                    EMP_NIVEL_ACCESO = VAL.EMP_NIVEL_ACCESO
'                    EMP_SEXO = VAL.EMP_SEXO
'                    EMP_DIRECCION = VAL.EMP_DIRECCION
'                    EMP_TEL_CASA = VAL.EMP_TEL_CASA
'                    EMP_TEL_EMERGENCIA = VAL.EMP_TEL_EMERGENCIA
'                    EMP_TEL_CELULAR = VAL.EMP_TEL_CELULAR
'                    EMP_ALERGICO_ANTIBIOTICO = VAL.EMP_ALERGICO_ANTIBIOTICO
'                    EMP_TIPO_ANTIBIOTICO = VAL.EMP_TIPO_ANTIBIOTICO
'                    EMP_TIPO_SANGRE = VAL.EMP_TIPO_SANGRE
'                    EMP_SABE_LEER = VAL.EMP_SABE_LEER
'                    EMP_SABE_ESCRIBIR = VAL.EMP_SABE_ESCRIBIR
'                    EMP_PATH_FOTO = VAL.EMP_PATH_FOTO
'                    EMP_LUGAR_NACIMIENTO = VAL.EMP_LUGAR_NACIMIENTO
'                    EMP_FECHA_NACIMIENTO = VAL.EMP_FECHA_NACIMIENTO
'                    EMP_NO_AFILIACION = VAL.EMP_NO_AFILIACION
'                    EMP_NOMBRE_CONYUGE = VAL.EMP_NOMBRE_CONYUGE
'                    EMP_TARJETA_SANIDAD = VAL.EMP_TARJETA_SANIDAD
'                    EMP_CENTRO_SALUD = VAL.EMP_CENTRO_SALUD
'                    EMP_PROFESION_OFICIO = VAL.EMP_PROFESION_OFICIO
'                    EMP_NO_LICENCIA = VAL.EMP_NO_LICENCIA
'                    EMP_EMPRESA1_ANT = VAL.EMP_EMPRESA1_ANT
'                    EMP_EMPRESA2_ANT = VAL.EMP_EMPRESA2_ANT
'                    EMP_EMPRESA3_ANT = VAL.EMP_EMPRESA3_ANT
'                    EMP_CARGO1_ANT = VAL.EMP_CARGO1_ANT
'                    EMP_CARGO2_ANT = VAL.EMP_CARGO2_ANT
'                    EMP_CARGO3_ANT = VAL.EMP_CARGO3_ANT
'                    EMP_CARCEL = VAL.EMP_CARCEL
'                    EMP_MOTIVO_CARCEL = VAL.EMP_MOTIVO_CARCEL
'                    EMP_ANTECEDENTES = VAL.EMP_ANTECEDENTES
'                    EMP_REFERENCIA_NOM1 = VAL.EMP_REFERENCIA_NOM1
'                    EMP_REFERENCIA_NOM2 = VAL.EMP_REFERENCIA_NOM2
'                    EMP_REFERENCIA_NOM3 = VAL.EMP_REFERENCIA_NOM3
'                    EMP_REFERENCIA_TEL1 = VAL.EMP_REFERENCIA_TEL1
'                    EMP_REFERENCIA_TEL2 = VAL.EMP_REFERENCIA_TEL2
'                    EMP_REFERENCIA_TEL3 = VAL.EMP_REFERENCIA_TEL3
'                    EMP_ESTADO_CIVIL = VAL.EMP_ESTADO_CIVIL
'                    EMP_FOTO = VAL.EMP_FOTO
'                    EMP_FECHA_ALTA = VAL.EMP_FECHA_ALTA
'                    EMP_INFECTO = VAL.EMP_INFECTO
'                    EMP_HOSPITAL = VAL.EMP_HOSPITAL
'                    EMP_MOTIVO_HOSPITAL = VAL.EMP_MOTIVO_HOSPITAL
'                    EMP_PUESTO = VAL.EMP_PUESTO
'                    EMP_FILIAL_ASIGNADA = VAL.EMP_FILIAL_ASIGNADA
'                    EMP_NUMERO_HIJOS = VAL.EMP_NUMERO_HIJOS
'                    EMP_GRADO_ACADEMICO = VAL.EMP_GRADO_ACADEMICO
'                    EMP_INSTITUCION_ACADEMICA = VAL.EMP_INSTITUCION_ACADEMICA
'                    EMP_SERVICIOS_ESPECIALES = VAL.EMP_SERVICIOS_ESPECIALES
'                    ESCRITURA = VAL.ESCRITURA
'                    PPONE_REGISTRO = True
'                Catch Ex As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - PPONE_REGISTRO Error=" & Ex.ToString
'                    Throw New System.Exception("Error No Contemplado", Ex)
'                End Try
'            End Function

'            <System.Diagnostics.DebuggerStepThrough()> _
'            Function POBTIENE_DEFAULT() As DEFINICION_EMPLEADOS
'                Dim VAL As New DEFINICION_EMPLEADOS
'                VAL.Simon_REGISTRO = False
'                VAL.MERROR = ""
'                POBTIENE_DEFAULT = VAL
'                Try
'                    VAL.EMP_EMPRESA = ""
'                    VAL.EMP_CODIGO = 0
'                    VAL.EMP_ACTIVO = "S"
'                    VAL.EMP_EMPRESA_CONTRATANTE = ""
'                    VAL.EMP_NOMBRE1 = ""
'                    VAL.EMP_NOMBRE2 = ""
'                    VAL.EMP_NOMBRE3 = ""
'                    VAL.EMP_APELLIDO1 = ""
'                    VAL.EMP_APELLIDO2 = ""
'                    VAL.EMP_APELLIDO3 = ""
'                    VAL.EMP_CEDULA = ""
'                    VAL.EMP_EXTENDIDA_EN = ""
'                    VAL.EMP_DPI = ""
'                    VAL.EMP_NIT = ""
'                    VAL.EMP_NIVEL_ACCESO = "0"
'                    VAL.EMP_SEXO = ""
'                    VAL.EMP_DIRECCION = ""
'                    VAL.EMP_TEL_CASA = ""
'                    VAL.EMP_TEL_EMERGENCIA = ""
'                    VAL.EMP_TEL_CELULAR = ""
'                    VAL.EMP_ALERGICO_ANTIBIOTICO = "N"
'                    VAL.EMP_TIPO_ANTIBIOTICO = ""
'                    VAL.EMP_TIPO_SANGRE = ""
'                    VAL.EMP_SABE_LEER = "S"
'                    VAL.EMP_SABE_ESCRIBIR = "S"
'                    VAL.EMP_PATH_FOTO = ""
'                    VAL.EMP_LUGAR_NACIMIENTO = ""
'                    VAL.EMP_FECHA_NACIMIENTO = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
'                    VAL.EMP_NO_AFILIACION = ""
'                    VAL.EMP_NOMBRE_CONYUGE = ""
'                    VAL.EMP_TARJETA_SANIDAD = ""
'                    VAL.EMP_CENTRO_SALUD = ""
'                    VAL.EMP_PROFESION_OFICIO = ""
'                    VAL.EMP_NO_LICENCIA = ""
'                    VAL.EMP_EMPRESA1_ANT = ""
'                    VAL.EMP_EMPRESA2_ANT = ""
'                    VAL.EMP_EMPRESA3_ANT = ""
'                    VAL.EMP_CARGO1_ANT = ""
'                    VAL.EMP_CARGO2_ANT = ""
'                    VAL.EMP_CARGO3_ANT = ""
'                    VAL.EMP_CARCEL = ""
'                    VAL.EMP_MOTIVO_CARCEL = ""
'                    VAL.EMP_ANTECEDENTES = ""
'                    VAL.EMP_REFERENCIA_NOM1 = ""
'                    VAL.EMP_REFERENCIA_NOM2 = ""
'                    VAL.EMP_REFERENCIA_NOM3 = ""
'                    VAL.EMP_REFERENCIA_TEL1 = ""
'                    VAL.EMP_REFERENCIA_TEL2 = ""
'                    VAL.EMP_REFERENCIA_TEL3 = ""
'                    VAL.EMP_ESTADO_CIVIL = ""
'                    VAL.EMP_FOTO = ""
'                    VAL.EMP_FECHA_ALTA = New MySqlDateTime(0, 0, 0, 0, 0, 0, 0)
'                    VAL.EMP_INFECTO = ""
'                    VAL.EMP_HOSPITAL = ""
'                    VAL.EMP_MOTIVO_HOSPITAL = ""
'                    VAL.EMP_PUESTO = ""
'                    VAL.EMP_FILIAL_ASIGNADA = "T00"
'                    VAL.EMP_NUMERO_HIJOS = 0
'                    VAL.EMP_GRADO_ACADEMICO = ""
'                    VAL.EMP_INSTITUCION_ACADEMICA = ""
'                    VAL.EMP_SERVICIOS_ESPECIALES = "E"
'                    VAL.ESCRITURA = New MySqlDateTime(Now)
'                    VAL.Simon_REGISTRO = True
'                    POBTIENE_DEFAULT = VAL
'                Catch Ex As Exception
'                    MENSAJE = "BiblioTABLAS - TDEFINICION_EMPLEADOS - POBTIENE_DEFAULT Error=" & Ex.ToString
'                    Throw New System.Exception("Error no contemplado", Ex)
'                End Try
'            End Function

'#End Region

'        End Class
'    End Namespace
'End Namespace
