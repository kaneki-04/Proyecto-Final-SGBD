<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cmbRole = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnRegister = New Button()
        btnMostrarContraseña = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(172, 38)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(125, 27)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(172, 84)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(125, 27)
        txtPassword.TabIndex = 1
        ' 
        ' cmbRole
        ' 
        cmbRole.Location = New Point(172, 139)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(125, 27)
        cmbRole.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nombre de usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 4
        Label2.Text = "Contraseña:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 20)
        Label3.TabIndex = 5
        Label3.Text = "Rol:"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = SystemColors.Menu
        btnRegister.Location = New Point(172, 199)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(125, 44)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Registrar"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnMostrarContraseña
        ' 
        btnMostrarContraseña.BackColor = SystemColors.Menu
        btnMostrarContraseña.Location = New Point(312, 84)
        btnMostrarContraseña.Name = "btnMostrarContraseña"
        btnMostrarContraseña.Size = New Size(72, 27)
        btnMostrarContraseña.TabIndex = 7
        btnMostrarContraseña.Text = "Mostrar"
        btnMostrarContraseña.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 20)
        Label4.TabIndex = 8
        Label4.Text = "Registrar usuario:"
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(420, 287)
        Controls.Add(Label4)
        Controls.Add(btnMostrarContraseña)
        Controls.Add(btnRegister)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbRole)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        MaximizeBox = False
        Name = "FormRegister"
        Text = "Registro:"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRole As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnMostrarContraseña As Button
    Friend WithEvents Label4 As Label
End Class
