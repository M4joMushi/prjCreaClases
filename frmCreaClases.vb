
Public Class frmCreaClases
    Inherits System.Windows.Forms.Form

    Private objMiembros As New CMiembros

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents rtxtClase As System.Windows.Forms.RichTextBox
    Friend WithEvents txtNombreClase As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreColeccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAgregaMiembro As System.Windows.Forms.Button
    Friend WithEvents lvwMiembros As System.Windows.Forms.ListView
    Friend WithEvents colMiembro As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAmbito As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbAmbito As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents colConsecutivo As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.rtxtClase = New System.Windows.Forms.RichTextBox
        Me.txtNombreClase = New System.Windows.Forms.TextBox
        Me.txtNombreColeccion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAgregaMiembro = New System.Windows.Forms.Button
        Me.lvwMiembros = New System.Windows.Forms.ListView
        Me.colConsecutivo = New System.Windows.Forms.ColumnHeader
        Me.colMiembro = New System.Windows.Forms.ColumnHeader
        Me.colAmbito = New System.Windows.Forms.ColumnHeader
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.cmbAmbito = New System.Windows.Forms.ComboBox
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dato Miembro (ttt_Nombre)"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(80, 360)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(120, 24)
        Me.btnGenerar.TabIndex = 6
        Me.btnGenerar.Text = "Generar Clase >>"
        '
        'rtxtClase
        '
        Me.rtxtClase.Location = New System.Drawing.Point(208, 8)
        Me.rtxtClase.Name = "rtxtClase"
        Me.rtxtClase.Size = New System.Drawing.Size(360, 376)
        Me.rtxtClase.TabIndex = 5
        Me.rtxtClase.Text = ""
        '
        'txtNombreClase
        '
        Me.txtNombreClase.Location = New System.Drawing.Point(8, 32)
        Me.txtNombreClase.Name = "txtNombreClase"
        Me.txtNombreClase.Size = New System.Drawing.Size(168, 20)
        Me.txtNombreClase.TabIndex = 0
        Me.txtNombreClase.Text = ""
        '
        'txtNombreColeccion
        '
        Me.txtNombreColeccion.Location = New System.Drawing.Point(8, 72)
        Me.txtNombreColeccion.Name = "txtNombreColeccion"
        Me.txtNombreColeccion.Size = New System.Drawing.Size(168, 20)
        Me.txtNombreColeccion.TabIndex = 1
        Me.txtNombreColeccion.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre Clase"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "NombreColeccion"
        '
        'btnAgregaMiembro
        '
        Me.btnAgregaMiembro.Location = New System.Drawing.Point(8, 192)
        Me.btnAgregaMiembro.Name = "btnAgregaMiembro"
        Me.btnAgregaMiembro.Size = New System.Drawing.Size(56, 24)
        Me.btnAgregaMiembro.TabIndex = 4
        Me.btnAgregaMiembro.Text = "Agregar"
        '
        'lvwMiembros
        '
        Me.lvwMiembros.BackColor = System.Drawing.SystemColors.Window
        Me.lvwMiembros.CheckBoxes = True
        Me.lvwMiembros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colConsecutivo, Me.colMiembro, Me.colAmbito})
        Me.lvwMiembros.GridLines = True
        Me.lvwMiembros.Location = New System.Drawing.Point(8, 224)
        Me.lvwMiembros.Name = "lvwMiembros"
        Me.lvwMiembros.Size = New System.Drawing.Size(184, 104)
        Me.lvwMiembros.TabIndex = 5
        Me.lvwMiembros.View = System.Windows.Forms.View.Details
        '
        'colConsecutivo
        '
        Me.colConsecutivo.Text = "ID"
        Me.colConsecutivo.Width = 29
        '
        'colMiembro
        '
        Me.colMiembro.Text = "Miembro"
        Me.colMiembro.Width = 64
        '
        'colAmbito
        '
        Me.colAmbito.Text = "Ambito"
        Me.colAmbito.Width = 85
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(8, 128)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(184, 20)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Text = ""
        '
        'cmbAmbito
        '
        Me.cmbAmbito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAmbito.Items.AddRange(New Object() {"Private", "Public", "Protected"})
        Me.cmbAmbito.Location = New System.Drawing.Point(8, 160)
        Me.cmbAmbito.Name = "cmbAmbito"
        Me.cmbAmbito.Size = New System.Drawing.Size(112, 21)
        Me.cmbAmbito.TabIndex = 3
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(72, 192)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(120, 24)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "Borrar Seleccionados"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 328)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(80, 24)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        '
        'frmCreaClases
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 390)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.cmbAmbito)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNombreColeccion)
        Me.Controls.Add(Me.txtNombreClase)
        Me.Controls.Add(Me.lvwMiembros)
        Me.Controls.Add(Me.btnAgregaMiembro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rtxtClase)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCreaClases"
        Me.Text = "Crea Clase y Coleccion"
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        Dim objMiembro As CMiembro
        Dim objLVWItem As ListViewItem
        Dim strDatos() As String
        Dim strTipo As String
        Dim strClase As String

        objMiembros.Clear()

        For Each objLVWItem In lvwMiembros.Items
            objMiembro = New CMiembro
            objMiembro.NombreCompleto = "m_" & objLVWItem.SubItems(1).Text
            strDatos = Split(objMiembro.NombreCompleto, "_")
            objMiembro.Propiedad = strDatos(2)

            Select Case strDatos(1)
                Case "str", "vch"
                    strTipo = "String"
                Case "chr"
                    strTipo = "Char"
                Case "b"
                    strTipo = "boolean"
                Case "d"
                    strTipo = "Decimal"
                Case "i"
                    strTipo = "Integer"
                Case "s"
                    strTipo = "Short"
                Case "dt"
                    strTipo = "DateTime"
                Case Else
                    strTipo = "Object"

            End Select
            objMiembro.Tipo = strTipo
            objMiembro.Prefijo = strDatos(1)
            objMiembro.Ambito = objLVWItem.SubItems(2).Text

            objMiembros.Agregar(objMiembro)
            objMiembro = Nothing
        Next

        objMiembros.NombreClase = txtNombreClase.Text
        objMiembros.NombreColeccion = txtNombreColeccion.Text

        strClase = objMiembros.GeneraClase()
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

    End Sub


    Private Sub btnAgregaMiembro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaMiembro.Click

        Dim lSingleItem As ListViewItem

        lSingleItem = lvwMiembros.Items.Add(CType(lvwMiembros.Items.Count + 1, String))   'Create a new line, and assign the ListItem into the variable so we can add sub items
        lSingleItem.SubItems.Add(txtNombre.Text)    'The first sub item for the first line
        lSingleItem.SubItems.Add(cmbAmbito.SelectedItem)    'The second sub item for the first line
        'lSingleItem.BackColor = CUtilerias.Color(lvwMiembros.Items.Count + 1)

    End Sub

    Private Sub frmCreaClases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbAmbito.SelectedItem = "Private"
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        With Me
            .lvwMiembros.Items.Clear()
            .txtNombre.Text = ""
            .txtNombreClase.Text = ""
            .txtNombreColeccion.Text = ""
            .rtxtClase.Text = ""
        End With
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim lSingleItem As ListViewItem

        For Each lSingleItem In lvwMiembros.CheckedItems
            lvwMiembros.Items.Remove(lSingleItem)
        Next
    End Sub
End Class
