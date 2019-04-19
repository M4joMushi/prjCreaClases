Public Class frmPrincipal
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuPr0012 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPr001 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuPr001 = New System.Windows.Forms.MenuItem
        Me.mnuPr0012 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPr001})
        '
        'mnuPr001
        '
        Me.mnuPr001.Index = 0
        Me.mnuPr001.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPr0012})
        Me.mnuPr001.Text = "Proceso"
        '
        'mnuPr0012
        '
        Me.mnuPr0012.Index = 0
        Me.mnuPr0012.Text = "Crea clases de mysql"
        '
        'frmPrincipal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub mnuPr0012_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPr0012.Click
        Dim objFBase As New frmCCMySQLSchema
        MuestraVentana(objFBase)
    End Sub

    Private Sub MuestraVentana(ByVal objVentana As Windows.Forms.Form)
        With objVentana
            .MdiParent = Me
            .Show()
        End With
        objVentana = Nothing
    End Sub

End Class
