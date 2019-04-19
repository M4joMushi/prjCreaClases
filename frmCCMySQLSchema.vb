Public Class frmCCMySQLSchema
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents rtxtClase As System.Windows.Forms.RichTextBox
    Friend WithEvents dgColumnas As System.Windows.Forms.DataGrid
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents txtNombreClase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombreColeccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSubNameSpace As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lvTABLAS As System.Windows.Forms.ListView
    Friend WithEvents Tabla As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbNameSpace As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbDB As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdServidor As System.Windows.Forms.Button
    Friend WithEvents btnGeneraSP As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCCMySQLSchema))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbDB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lvTABLAS = New System.Windows.Forms.ListView()
        Me.Tabla = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rtxtClase = New System.Windows.Forms.RichTextBox()
        Me.dgColumnas = New System.Windows.Forms.DataGrid()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtNombreClase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreColeccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGeneraSP = New System.Windows.Forms.Button()
        Me.txtSubNameSpace = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbNameSpace = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdServidor = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgColumnas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdServidor)
        Me.Panel1.Controls.Add(Me.cbDB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtServer)
        Me.Panel1.Controls.Add(Me.btnConectar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(14, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 120)
        Me.Panel1.TabIndex = 7
        '
        'cbDB
        '
        Me.cbDB.FormattingEnabled = True
        Me.cbDB.Location = New System.Drawing.Point(112, 87)
        Me.cbDB.Name = "cbDB"
        Me.cbDB.Size = New System.Drawing.Size(176, 21)
        Me.cbDB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Servidor"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(112, 62)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(100, 20)
        Me.txtServer.TabIndex = 2
        Me.txtServer.Text = "192.168.0.10"
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(224, 12)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(88, 24)
        Me.btnConectar.TabIndex = 4
        Me.btnConectar.Text = "&Conectar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Base de datos"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(112, 38)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 1
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(112, 12)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 0
        Me.txtUser.Text = "root"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Password"
        '
        'lvTABLAS
        '
        Me.lvTABLAS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvTABLAS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Tabla, Me.ColumnHeader1})
        Me.lvTABLAS.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTABLAS.FullRowSelect = True
        Me.lvTABLAS.GridLines = True
        Me.lvTABLAS.HideSelection = False
        Me.lvTABLAS.Location = New System.Drawing.Point(12, 147)
        Me.lvTABLAS.MultiSelect = False
        Me.lvTABLAS.Name = "lvTABLAS"
        Me.lvTABLAS.Size = New System.Drawing.Size(299, 505)
        Me.lvTABLAS.TabIndex = 12
        Me.lvTABLAS.UseCompatibleStateImageBehavior = False
        Me.lvTABLAS.View = System.Windows.Forms.View.Details
        '
        'Tabla
        '
        Me.Tabla.Text = "Tabla"
        Me.Tabla.Width = 350
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "TipoTabla"
        Me.ColumnHeader1.Width = 0
        '
        'rtxtClase
        '
        Me.rtxtClase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtClase.BackColor = System.Drawing.Color.DarkBlue
        Me.rtxtClase.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtClase.ForeColor = System.Drawing.Color.White
        Me.rtxtClase.Location = New System.Drawing.Point(687, 147)
        Me.rtxtClase.Name = "rtxtClase"
        Me.rtxtClase.Size = New System.Drawing.Size(379, 508)
        Me.rtxtClase.TabIndex = 10
        Me.rtxtClase.Text = ""
        Me.rtxtClase.WordWrap = False
        '
        'dgColumnas
        '
        Me.dgColumnas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgColumnas.DataMember = ""
        Me.dgColumnas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgColumnas.Location = New System.Drawing.Point(317, 147)
        Me.dgColumnas.Name = "dgColumnas"
        Me.dgColumnas.RowHeadersVisible = False
        Me.dgColumnas.Size = New System.Drawing.Size(365, 505)
        Me.dgColumnas.TabIndex = 11
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(340, 107)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(120, 24)
        Me.btnGenerar.TabIndex = 12
        Me.btnGenerar.Text = "<< &Generar Clase"
        '
        'txtNombreClase
        '
        Me.txtNombreClase.Location = New System.Drawing.Point(468, 11)
        Me.txtNombreClase.Name = "txtNombreClase"
        Me.txtNombreClase.Size = New System.Drawing.Size(136, 20)
        Me.txtNombreClase.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(340, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nombre de Clase"
        '
        'txtNombreColeccion
        '
        Me.txtNombreColeccion.Location = New System.Drawing.Point(468, 34)
        Me.txtNombreColeccion.Name = "txtNombreColeccion"
        Me.txtNombreColeccion.Size = New System.Drawing.Size(136, 20)
        Me.txtNombreColeccion.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(340, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nombre Colección"
        '
        'btnGeneraSP
        '
        Me.btnGeneraSP.Location = New System.Drawing.Point(484, 107)
        Me.btnGeneraSP.Name = "btnGeneraSP"
        Me.btnGeneraSP.Size = New System.Drawing.Size(120, 24)
        Me.btnGeneraSP.TabIndex = 17
        Me.btnGeneraSP.Text = "<< &Generar SProc"
        Me.btnGeneraSP.Visible = False
        '
        'txtSubNameSpace
        '
        Me.txtSubNameSpace.Location = New System.Drawing.Point(468, 81)
        Me.txtSubNameSpace.Name = "txtSubNameSpace"
        Me.txtSubNameSpace.Size = New System.Drawing.Size(136, 20)
        Me.txtSubNameSpace.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(340, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Nombre SubNameSpace"
        '
        'cbNameSpace
        '
        Me.cbNameSpace.FormattingEnabled = True
        Me.cbNameSpace.Items.AddRange(New Object() {"Manejo_Tablas", "Tablas", "Manejo_Tablas_Configuracion", "Manejo_Tablas_csp", "Manejo_Tablas_Historico", "Sys_Datos"})
        Me.cbNameSpace.Location = New System.Drawing.Point(468, 57)
        Me.cbNameSpace.Name = "cbNameSpace"
        Me.cbNameSpace.Size = New System.Drawing.Size(136, 21)
        Me.cbNameSpace.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(340, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Nombre NameSpace"
        '
        'cmdServidor
        '
        Me.cmdServidor.Location = New System.Drawing.Point(224, 60)
        Me.cmdServidor.Name = "cmdServidor"
        Me.cmdServidor.Size = New System.Drawing.Size(88, 24)
        Me.cmdServidor.TabIndex = 16
        Me.cmdServidor.Text = "&Servidor"
        '
        'frmCCMySQLSchema
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1070, 666)
        Me.Controls.Add(Me.lvTABLAS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbNameSpace)
        Me.Controls.Add(Me.txtSubNameSpace)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnGeneraSP)
        Me.Controls.Add(Me.txtNombreColeccion)
        Me.Controls.Add(Me.txtNombreClase)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dgColumnas)
        Me.Controls.Add(Me.rtxtClase)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1020, 700)
        Me.Name = "frmCCMySQLSchema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea Clases de Mysql"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgColumnas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables"
    'Esta es mi conexion mysql
    Private objConexion As CConexionMySQL
    Private ds As DataSet
    'Aqui guardo los campos de la bd, y también guardo el nombre de la propiedad publica de la clase
    Private dtCampos As DataTable
    'Esta va a ser la colección que tendrá todos los elemntos para crear:
    '1) La clase
    '2) La coleccion
    '3) Los stored procedures (NOTA: esto brinda un stored procedure básico de guardado/Editado y lectura)
    '   Las personalizaciones de lectura con subcatalogos o cosas similares, deberás programarla tu hehe
    Private objMiembros As New CMiembrosMySQL
#End Region


    'Esto me da una conexion a la bd
    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        Dim bConectado As Boolean
        'Dim RO
        Dim Cuenta As Integer = 0
        Dim itm As ListViewItem
        Dim REA As MySql.Data.MySqlClient.MySqlDataReader
        Dim COM As MySql.Data.MySqlClient.MySqlCommand

        'Esta es una clase que hice para hacer conexiones a base de datos,
        'en este caso es de mysql
        objConexion = New CConexionMySQL(txtUser.Text, txtPassword.Text, cbDB.Text, txtServer.Text)

        'Aqui simplemente nos conectamos
        bConectado = objConexion.ConnectToDatabase()

        If bConectado Then
            If ds Is Nothing Then ds = New DataSet
            'Carga las tablas disponibles del servidor en el dataset
            'Esto lo hace con instrucciones de mysql
            'If objConexion.Consulta("show tables", "tablas", ds) Then
            With lvTABLAS
                .BeginUpdate()
                .Items.Clear()
                COM = New MySql.Data.MySqlClient.MySqlCommand("show full tables", objConexion.Conexion)
                REA = COM.ExecuteReader
                Do While REA.Read = True
                    itm = .Items.Add(REA.GetString(0))
                    If Cuenta Mod 3 = 0 Then itm.BackColor = Color.MistyRose
                    If REA.GetString(1).ToUpper <> "BASE TABLE" Then
                        itm.ForeColor = Color.Blue
                        itm.SubItems.Add("Vista")
                    Else
                        itm.SubItems.Add("")
                    End If

                    Cuenta += 1
                Loop
                .EndUpdate()
                REA.Close()
                COM.Dispose()
            End With
            'With cmbTablas
            '    .DataSource = ds.Tables("tablas")
            '    .ValueMember = ds.Tables("tablas").Columns(0).Caption
            '    .DisplayMember = .ValueMember
            'End With
            'btnConsultaTabla.Enabled = True
            'Else
            'btnConsultaTabla.Enabled = False
            'End If
        Else
            MessageBox.Show("No se pudo conectar con la base de datos", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    'Esta funcion busca el tipo equivalente de vb.net para el tipo almacenado en mysql
    Private Sub TiposVB(ByRef objMiembro As CMiembroMySQL, ByRef strPrefijo As String)
        'Modificar esta seccion para incluir los tipos que se utilizarán en MySQL
        'Esto con el fin de crear el tipo de dato en la clase que pueda almacenar 
        'la información, el prefijo solo es para armar la clase

        'NOTA: si tienes campos BLOB o alguno que no veas en la lista, solo agregalo en otro
        '       case para que asignes el tipo de dato correcto en vb.net

        Dim arr1(), arr2(), arr3() As String
        Dim strTipo As String

        Try
            'Con esto separamos el tipo de la precisión
            arr1 = Split(objMiembro.TipoBD, "(")

            'invariablemente, en el elemento cero, esta el tipo, halla o no
            'tamaño y precision
            objMiembro.TipoBD = arr1(0).ToUpper()

            'De acuerdo al tipo de mysql, sacamos el tipo de VB
            'Recuerda, agregale los tipos que consideres necesarios
            Select Case UCase(objMiembro.TipoBD)
                Case "TINYINT", "SMALLINT", "BIT"
                    strTipo = "Short"
                    strPrefijo = "s"
                Case "VARCHAR", "CHAR"
                    strTipo = "String"
                    strPrefijo = "str"
                Case "BOOLEAN"
                    strTipo = "Boolean"
                    strPrefijo = "bol"
                Case "FLOAT", "DECIMAL", "DOUBLE"
                    strTipo = "Decimal"
                    strPrefijo = "dec"
                Case "INTEGER", "MEDIUMINT", "INT"
                    strTipo = "Integer"
                    strPrefijo = "int"
                Case "BIGINT"
                    strTipo = "Long"
                    strPrefijo = "lng"
                Case "DATETIME", "DATE", "MYSQLDATETIME"
                    strTipo = "MYSQLDATETIME"
                    strPrefijo = "dt"
                Case "TIMESTAMP"
                    strTipo = "MYSQLDATETIME"
                    strPrefijo = "dt"
                Case "TIMESPAN"
                    strTipo = "TimeSpan"
                    strPrefijo = "ts"
                Case "ENUM"
                    strTipo = "String"
                    strPrefijo = "str"
                Case "SET"
                    strTipo = "String"
                    strPrefijo = "str"
                Case Else
                    strTipo = "Object"
                    strPrefijo = "obj"
            End Select

            objMiembro.Tipo = strTipo
            objMiembro.Prefijo = strPrefijo

            'Si el tamaño del arreglo es 2, quiere decir que hay tamaño y/o precision,
            'nos interesa solo el tamaño (VG puede ser varchar(200), decimal(10,3)
            If arr1.Length = 2 Then
                arr2 = Split(arr1(1), ")")
                'tenemos ya sea el tamaño o el tamaño y precision en el elemento 0,
                'nos interesa solo el tamaño para los stored procedures que piden tipo y tamaño

                arr3 = Split(arr2(0), ",")
                'Ahora, el tamaño esta en la posición 0 de arr3
                objMiembro.Tamano = arr3(0)
            End If

        Catch ex As Exception
            strPrefijo = "obj"
        End Try

    End Sub

    'Una vez que nos conectamos al servidor, podremos consultar las columnas de la tabla
    'que tengamos seleccionada para obtener su estructura y armar nuestra clase
    'Private Sub btnConsultaTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim bConectado As Boolean, drowcampos As DataRow
    '    Dim dc As DataColumn


    '    bConectado = objConexion.ConnectToDatabase()
    '    If Not bConectado Then Exit Sub
    '    If (Not dtCampos Is Nothing) Then dtCampos.Dispose()

    '    Try
    '        'Es importante limpiar los campos si es que tenía algo la tabla
    '        ds.Tables("campos").Rows.Clear()
    '    Catch ex As Exception
    '    End Try


    '    'Si puede leer las columnas de la tabla, entonces las muestra y permite editar el
    '    'nombre de la propiedad que representará la columna, la tabla dtCampos tendrá solo
    '    'los datos que necesitamos (field, property, type, ESPK -nos dice si usamos los campos
    '    '   llave para hacer las selecciones-)
    '    'If objConexion.Consulta("SHOW columns from " & Me.cmbTablas.SelectedValue, "campos", ds) Then
    '    If objConexion.Consulta("SHOW columns from " & Frm.lvTABLAS.SelectedItems(0).Text, "campos", ds) Then

    '        'Crea la tabla
    '        dtCampos = New DataTable

    '        dc = New DataColumn
    '        With dc
    '            .Caption = "Field"
    '            .ColumnName = "field"
    '            .DataType = GetType(String)
    '            .DefaultValue = ""
    '        End With
    '        dtCampos.Columns.Add(dc)
    '        dc = Nothing

    '        dc = New DataColumn
    '        With dc
    '            .Caption = "property's name"
    '            .ColumnName = "Property"
    '            .DataType = GetType(String)
    '            .DefaultValue = ""
    '        End With
    '        dtCampos.Columns.Add(dc)
    '        dc = Nothing

    '        dc = New DataColumn
    '        With dc
    '            .Caption = "Type"
    '            .ColumnName = "type"
    '            .DataType = GetType(String)
    '            .DefaultValue = ""
    '        End With
    '        dtCampos.Columns.Add(dc)
    '        dc = Nothing

    '        dc = New DataColumn
    '        With dc
    '            .Caption = "Es PK?"
    '            .ColumnName = "key"
    '            .DataType = GetType(String)
    '            .DefaultValue = ""
    '        End With
    '        dtCampos.Columns.Add(dc)
    '        dc = Nothing

    '        For Each row As DataRow In ds.Tables("campos").Rows
    '            'Estas son meras asignaciones
    '            drowcampos = dtCampos.NewRow()
    '            drowcampos.BeginEdit()

    '            drowcampos("field") = row("field")
    '            drowcampos("property") = row("field")
    '            'If row("type") = "timestamp(14)" Or row("type") = "timestamp" Or _
    '            '   row("type") = "datetime" Or row("type") = "date" Or row("type") = "time" Then
    '            If row("type") = "timestamp(14)" Or row("type") = "timestamp" Or _
    '               row("type") = "datetime" Or row("type") = "date" Then
    '                drowcampos("type") = "MYSQLDATETIME"
    '            ElseIf row("type") = "time" Then
    '                drowcampos("type") = "TimeSpan"
    '            Else
    '                drowcampos("type") = row("type")
    '            End If
    '            'If row("type") = "timestamp(14)" Or row("type") = "timestamp" Then
    '            '    drowcampos("type") = "datetime"
    '            'Else
    '            '    drowcampos("type") = row("type")
    '            'End If
    '            drowcampos("key") = row("key")

    '            drowcampos.EndEdit()
    '            dtCampos.Rows.Add(drowcampos)
    '        Next

    '        Me.dgColumnas.DataSource = dtCampos
    '        btnGenerar.Enabled = True
    '        txtNombreClase.Text = UCase("T" & Frm.lvTABLAS.SelectedItems(0).Text)
    '        txtNombreColeccion.Text = txtNombreClase.Text
    '    Else
    '        btnGenerar.Enabled = False
    '    End If
    'End Sub


    'Aqui es donde realmente se genera nuestra clase y colección
    Private Sub btnGenerar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        Dim objMiembro As CMiembroMySQL
        Dim strPrefijo As String = ""
        Dim strClase As String

        Try
            If cbNameSpace.SelectedIndex = -1 Then
                MsgBox("Tiene que seleccionar un NameSpace", , "Error")
                Exit Sub
            End If

            objMiembros = New CMiembrosMySQL
            dtCampos.AcceptChanges()

            For Each drow As DataRow In dtCampos.Rows
                objMiembro = New CMiembroMySQL
                'obtenemos el tipo,
                'se asigna tambien un 'tipo completo' porque:
                '   1) TipoDB tendrá el tipo de la base de datos
                '   2) TipoDBCompleto incluirá el tamaño y la precisión (si aplica) -- esto nos sirve en los stored procedures
                objMiembro.TipoBD = drow("Type")
                objMiembro.TipoBDCompleto = drow("type")
                'Indicador de si es llave primaria
                objMiembro.EsPK = IIf(drow("key") = "PRI", True, False)

                'Del tipo mysql, saca el tipo VB y asigna el tipo correcto y tamaño desglosado de mysql
                TiposVB(objMiembro, strPrefijo)

                objMiembro.Propiedad = drow("property")
                objMiembro.NombreCompleto = "m_" & strPrefijo & "_" & drow("property")
                objMiembro.Prefijo = strPrefijo
                'por default pone los datos privados con propiedades publicas, edita al final si consideras necesario
                objMiembro.Ambito = "private"
                objMiembro.CampoBD = drow("field")
                objMiembro.V_Default = drow("default")
                objMiembro.Extra = drow("extra")

                objMiembros.Agregar(objMiembro)
                objMiembro = Nothing
            Next

            'Los nombres de la clase y la coleccion los proporciona el usuario
            'Para mis estándares XD siempre antepongo a las clases la letra C
            'Asi, mi clase para el catalogo de Cheques, sera CCheque y la coleccion CCheques
            'El programa antepone esta C, entonces los nombres que proporciono son 
            'Cheque y Cheques (que tambien se usa para crear los nombres de los stored procedures)
            objMiembros.NombreClase = txtNombreClase.Text
            objMiembros.NombreColeccion = txtNombreColeccion.Text

            'Aqui se genera la clase tal cual, checate el archivo
            'CCREACLASESMYSQL (clase CMiembrosMysql, funcion genera clase)
            'Ahi esta la verdad absoluta de esto, solamente genera la cadena basado en los datos
            'es algo tedioso y largo pero ahorra mucho tiempo en proyectos que tienes 80 catalogos
            'y al igual que yo tal vez prefieras diseñar tus clases para reutilizar objetos en diferentes
            'partes de tu programa,

            'LO QUE GENERA ES:
            '1) La clase del objeto individual con
            '   1.1) Una region de datos miembro 
            '    1.2) Una region de propiedades
            '    1.3) Una region de funciones (Lectura, guardado, si quieres incluir el borrado, basicamente duplica la lectura pero con un sp diferente)
            '    1.4) El constructor
            '2) La coleccion (para que manejes tus objetos y puedas asignar datagrids y cosas asi
            '    1.1) funciones para manejar la coleccion
            '    1.2) Guardado
            '    1.3) Lectura
            '    1.4) Ordenamiento (comentado, ya que esto hay que personalizarlo)
            '    1.5) Filtrado (comentado, ya que esto hay que personalizarlo)
            Dim TT As New CMiembrosMySQL.Tipo_Tabla

            If lvTABLAS.SelectedItems(0).SubItems(1).Text = "Vista" Then
                TT = CMiembrosMySQL.Tipo_Tabla.Vista
            Else
                TT = CMiembrosMySQL.Tipo_Tabla.Tabla
            End If

            Lista_Indices.Clear()
            Dim Ultimo As String = ""
            Dim CON As New MySql.Data.MySqlClient.MySqlConnection(objConexion.Conexion.ConnectionString)
            Dim COM As MySql.Data.MySqlClient.MySqlCommand = Nothing
            Dim REA As MySql.Data.MySqlClient.MySqlDataReader = Nothing
            Dim Query As String

            CON.Open()
            Query = "show index from " & lvTABLAS.SelectedItems(0).Text
            COM = New MySql.Data.MySqlClient.MySqlCommand(Query, CON)
            REA = COM.ExecuteReader()

            Do While REA.Read
                If Ultimo <> REA.GetString(2) Then
                    Ultimo = REA.GetString(2)
                    Dim T As String = Quita_Blancos(Ultimo)
                    Lista_Indices.Add(T)
                End If
            Loop
            REA.Close()
            REA = Nothing
            COM.Dispose()
            COM = Nothing
            CON.Close()
            CON.Dispose()
            CON = Nothing


            strClase = objMiembros.GeneraClase(Me, TT)
            btnGeneraSP.Enabled = True
            rtxtClase.Text = strClase

            Dim sfdGuardar As New System.Windows.Forms.SaveFileDialog
            With sfdGuardar
                .DefaultExt = "vb"
                .Title = "Escoge el archivo para guardar la clase"
                .FileName = objMiembros.NombreColeccion + "." + .DefaultExt

                If .ShowDialog() = DialogResult.OK Then
                    rtxtClase.SaveFile(.FileName, _
                    RichTextBoxStreamType.PlainText)
                End If
            End With

            btnGeneraSP.Enabled = True
        Catch ex As Exception
            btnGeneraSP.Enabled = False
        Finally
            lvTABLAS.Focus()
        End Try
    End Sub

    ''' <summary>
    ''' Funcion que quita los blancos del nombre del Indice.
    ''' </summary>
    ''' <param name="Valor">String, Nombre del Indice</param>
    ''' <returns>String, Valor sin Blancos</returns>
    Function Quita_Blancos(Valor As String) As String
        Dim T As String = ""
        Quita_Blancos = Valor

        'Se comento el codigo porque es mejor que de error al tratar de compilar que al momento de correr.
        'Try
        '    For X As Integer = 1 To Valor.Length
        '        If Mid(Valor, X, 1) <> " " Then
        '            T &= Mid(Valor, X, 1)
        '        End If
        '    Next
        '    Return T
        'Catch ex As Exception
        '    MsgBox("Error Quitando Blancos")
        'End Try
    End Function

    'Este genera los Stored procedures, no saben cuanto tiempo de desarrollo me he ahorrado por que
    'me genere toda la lista de inserciones, actualizaciones y lectura
    'al menos elimino todos los errores de tipear mal el nombre de los campos y cosas asi
    Private Sub btnGeneraSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraSP.Click
        If objMiembros Is Nothing Then
            MessageBox.Show("Genere primero la clase", "Atencion", MessageBoxButtons.OK)
            Exit Sub
        End If

        'Aqui se genera la clase tal cual, checate el archivo
        'CCREACLASESMYSQL (clase CMiembrosMysql, funcion GeneraSPs)
        rtxtClase.Text = objMiembros.GeneraSPs()

        Dim sfdGuardar As New System.Windows.Forms.SaveFileDialog
        With sfdGuardar
            .DefaultExt = "sql"
            .Title = "Escoge el archivo para guardar el script"
            .FileName = objMiembros.NombreColeccion + "." + .DefaultExt

            If .ShowDialog() = DialogResult.OK Then
                rtxtClase.SaveFile(.FileName, _
                RichTextBoxStreamType.PlainText)
            End If
        End With

    End Sub

    Private Sub frmCCMySQLSchema_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        btnGeneraSP.Enabled = False
        btnGenerar.Enabled = False
        'btnConsultaTabla.Enabled = False
        cbNameSpace.SelectedIndex = 0 'Selecciono siempre el primero.
        Frm = Me
        txtServer.Text = My.Settings.Server
        txtServer.Focus()
        txtUser.Focus()

        If cbDB.Items.Count <> 0 Then cbDB.SelectedIndex = 0

    End Sub

    Private Sub lvTABLAS_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTABLAS.DoubleClick
        'Seleccionaron una tabla
        Dim bConectado As Boolean
        Dim drowcampos As DataRow
        Dim dc As DataColumn
        'Dim ITM As ListViewItem
        Dim TT As CMiembrosMySQL.Tipo_Tabla

        'lvTABLAS.BeginUpdate()
        'For Each ITM In lvTABLAS.Items
        '    ITM.BackColor = System.Drawing.SystemColors.Window
        '    ITM.ForeColor = System.Drawing.SystemColors.ControlText
        'Next

        'ITM = lvTABLAS.SelectedItems(0)

        'ITM.BackColor = Color.BlueViolet
        'ITM.ForeColor = Color.White

        'lvTABLAS.EndUpdate()

        If lvTABLAS.SelectedItems(0).SubItems(1).Text = "Vista" Then
            TT = CMiembrosMySQL.Tipo_Tabla.Vista
        Else
            TT = CMiembrosMySQL.Tipo_Tabla.Tabla
        End If

        If TT = CMiembrosMySQL.Tipo_Tabla.Tabla Then
            txtSubNameSpace.Text = Mid(lvTABLAS.SelectedItems(0).Text, 1, 1).ToUpper
        End If

        bConectado = objConexion.ConnectToDatabase()
        If Not bConectado Then Exit Sub
        If (Not dtCampos Is Nothing) Then dtCampos.Dispose()

        Try
            'Es importante limpiar los campos si es que tenía algo la tabla
            ds.Tables("campos").Rows.Clear()
        Catch ex As Exception
        End Try


        'Si puede leer las columnas de la tabla, entonces las muestra y permite editar el
        'nombre de la propiedad que representará la columna, la tabla dtCampos tendrá solo
        'los datos que necesitamos (field, property, type, ESPK -nos dice si usamos los campos
        '   llave para hacer las selecciones-)
        'If objConexion.Consulta("SHOW columns from " & Me.cmbTablas.SelectedValue, "campos", ds) Then
        If objConexion.Consulta("SHOW columns from " & lvTABLAS.SelectedItems(0).Text, "campos", ds) Then
            'Crea la tabla
            dtCampos = New DataTable

            dc = New DataColumn
            With dc
                .Caption = "Field"
                .ColumnName = "field"
                .DataType = GetType(String)
                .DefaultValue = ""
            End With
            dtCampos.Columns.Add(dc)
            dc = Nothing

            dc = New DataColumn
            With dc
                .Caption = "property's name"
                .ColumnName = "Property"
                .DataType = GetType(String)
                .DefaultValue = ""
            End With
            dtCampos.Columns.Add(dc)
            dc = Nothing

            dc = New DataColumn
            With dc
                .Caption = "Type"
                .ColumnName = "type"
                .DataType = GetType(String)
                .DefaultValue = ""
            End With
            dtCampos.Columns.Add(dc)
            dc = Nothing

            dc = New DataColumn
            With dc
                .Caption = "Es PK?"
                .ColumnName = "key"
                .DataType = GetType(String)
                .DefaultValue = ""
            End With
            dtCampos.Columns.Add(dc)
            dc = Nothing

            dc = New DataColumn
            With dc
                .Caption = "Default"
                .ColumnName = "default"
                .DataType = GetType(String)
                .DefaultValue = ""
            End With
            dtCampos.Columns.Add(dc)
            dc = Nothing

            dc = New DataColumn
            With dc
                .Caption = "Extra"
                .ColumnName = "extra"
                .DataType = GetType(String)
                .DefaultValue = ""
            End With
            dtCampos.Columns.Add(dc)
            dc = Nothing


            For Each row As DataRow In ds.Tables("campos").Rows
                'Estas son meras asignaciones
                drowcampos = dtCampos.NewRow()
                drowcampos.BeginEdit()

                drowcampos("field") = row("field")
                drowcampos("property") = row("field")
                Select Case row("type").ToString
                    Case "timestamp(14)", "timestamp"
                        drowcampos("type") = "TimeStamp"
                    Case "datetime", "date"
                        drowcampos("type") = "MySQLDateTime"
                    Case "time"
                        drowcampos("type") = "TimeSpan"
                    Case Else
                        drowcampos("type") = row("type")
                End Select
                'If row("type") = "timestamp(14)" Or row("type") = "timestamp" Or _
                '   row("type") = "datetime" Or row("type") = "date" Then
                '    drowcampos("type") = "MYSQLDATETIME"
                'ElseIf row("type") = "time" Then
                '    drowcampos("type") = "TimeSpan"
                'Else
                '    drowcampos("type") = row("type")
                'End If
                drowcampos("key") = row("key")
                If row("default") Is DBNull.Value Then
                    drowcampos("default") = "(null)"
                Else
                    drowcampos("default") = row("default")
                End If
                If row("Extra") Is DBNull.Value Then
                    drowcampos("Extra") = ""
                Else
                    drowcampos("Extra") = row("Extra").ToString.ToUpper     'lo guardo en mayusculas
                End If

                drowcampos.EndEdit()
                dtCampos.Rows.Add(drowcampos)
            Next

            Me.dgColumnas.DataSource = dtCampos
            btnGenerar.Enabled = True
            txtNombreClase.Text = UCase("T" & lvTABLAS.SelectedItems(0).Text)
            txtNombreColeccion.Text = txtNombreClase.Text


            'Quiero que genere un preview de la clase antes de salvarla.

            Dim objMiembro As CMiembroMySQL
            Dim strPrefijo As String = ""
            Dim strClase As String

            If cbNameSpace.SelectedIndex = -1 Then
                MsgBox("Tiene que seleccionar un NameSpace", , "Error")
                Exit Sub
            End If

            objMiembros = New CMiembrosMySQL
            dtCampos.AcceptChanges()

            For Each drow As DataRow In dtCampos.Rows
                objMiembro = New CMiembroMySQL
                'obtenemos el tipo,
                'se asigna tambien un 'tipo completo' porque:
                '   1) TipoDB tendrá el tipo de la base de datos
                '   2) TipoDBCompleto incluirá el tamaño y la precisión (si aplica) -- esto nos sirve en los stored procedures
                objMiembro.TipoBD = drow("Type")
                objMiembro.TipoBDCompleto = drow("type")
                'Indicador de si es llave primaria
                objMiembro.EsPK = IIf(drow("key") = "PRI", True, False)

                'Del tipo mysql, saca el tipo VB y asigna el tipo correcto y tamaño desglosado de mysql
                TiposVB(objMiembro, strPrefijo)

                objMiembro.Propiedad = drow("property")
                objMiembro.NombreCompleto = "m_" & strPrefijo & "_" & drow("property")
                objMiembro.Prefijo = strPrefijo
                'por default pone los datos privados con propiedades publicas, edita al final si consideras necesario
                objMiembro.Ambito = "private"
                objMiembro.CampoBD = drow("field")

                objMiembro.V_Default = drow("default")
                objMiembro.Extra = drow("Extra")    'Tengo si es autoincrement

                objMiembros.Agregar(objMiembro)
                objMiembro = Nothing
            Next

            objMiembros.NombreClase = txtNombreClase.Text
            objMiembros.NombreColeccion = txtNombreColeccion.Text


            'Tengo que ir a buscar los indices de la tabla

            Lista_Indices.Clear()
            Dim Ultimo As String = ""
            Dim COM As MySql.Data.MySqlClient.MySqlCommand = Nothing
            Dim REA As MySql.Data.MySqlClient.MySqlDataReader = Nothing
            Dim Query As String

            Query = "show index from " & lvTABLAS.SelectedItems(0).Text
            COM = New MySql.Data.MySqlClient.MySqlCommand(Query, objConexion.Conexion)
            REA = COM.ExecuteReader()

            Do While REA.Read
                If Ultimo <> REA.GetString(2) Then
                    Ultimo = REA.GetString(2)
                    Dim T As String = Quita_Blancos(Ultimo)
                    Lista_Indices.Add(T)
                End If
            Loop

            REA.Close()
            REA = Nothing
            COM.Dispose()
            COM = Nothing

            strClase = objMiembros.GeneraClase(Me, TT)
            btnGeneraSP.Enabled = True
            rtxtClase.Text = strClase
            btnGenerar.Focus()
        Else
            btnGenerar.Enabled = False
        End If
    End Sub

    Private Sub txtServer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtServer.LostFocus
        'voy a tratar de recuperar las base de datos que existen en el servidor.
        Dim CON As MySql.Data.MySqlClient.MySqlConnection = Nothing
        Dim COM As MySql.Data.MySqlClient.MySqlCommand = Nothing
        Dim REA As MySql.Data.MySqlClient.MySqlDataReader = Nothing
        Dim STR As String
        Try
            STR = "server=" & txtServer.Text & "; uid=" & txtUser.Text & "; pwd=" & txtPassword.Text & "; Persist Security Info=True; Pooling=False; Connect Timeout=1;"
            CON = New MySql.Data.MySqlClient.MySqlConnection(STR)
            CON.Open()
            STR = "show databases"
            COM = New MySql.Data.MySqlClient.MySqlCommand(STR, CON)
            REA = COM.ExecuteReader(System.Data.CommandBehavior.SingleResult)
            'Tengo las posibles base de datos

            cbDB.BeginUpdate()
            cbDB.Items.Clear()   'Borro todos los registros que contiene actualmente.

            Do While REA.Read = True
                If REA.GetString(0).ToUpper <> "INFORMATION_SCHEMA" And REA.GetString(0).ToUpper <> "MYSQL" Then
                    cbDB.Items.Add(REA.GetString(0))
                End If
            Loop
            If cbDB.Items.Count <> 0 Then cbDB.SelectedIndex = 0

            My.Settings.Server = txtServer.Text
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.ToString, , "Error")
        Finally
            cbDB.EndUpdate()
            If Not IsNothing(REA) Then
                REA.Close()
                REA = Nothing
            End If
            If Not IsNothing(COM) Then
                COM.Dispose()
                COM = Nothing
            End If
            If Not IsNothing(CON) Then
                Try
                    CON.Close()
                Catch ex As Exception
                End Try
                CON.Dispose()
                CON = Nothing
            End If
        End Try
    End Sub

    Private Sub cbDB_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDB.SelectedIndexChanged
        Try
            If cbDB.Text.ToUpper = "DELICA" Then cbNameSpace.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.ToString, , "Error")
        End Try
    End Sub

    Private Sub lvTABLAS_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvTABLAS.KeyDown
        Dim L As String = Chr(e.KeyData)

        For Each ITM As ListViewItem In lvTABLAS.Items
            If Mid(ITM.Text.ToUpper, 1, 1) = L Then
                ITM.EnsureVisible()
                ITM.Selected = True
                Exit For
            End If
        Next

    End Sub

    Private Sub cmdServidor_Click(sender As System.Object, e As System.EventArgs) Handles cmdServidor.Click
        If txtServer.Text = "192.168.0.10" Then
            txtServer.Text = "LocalHost"
        Else
            txtServer.Text = "192.168.0.10"
        End If
        My.Settings.Server = txtServer.Text
        My.Settings.Save()
    End Sub

End Class
