<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ct_nombre = New TextBox()
        ct_direccion = New TextBox()
        ct_telefono = New TextBox()
        ct_correo = New TextBox()
        ctId_Proveedores = New TextBox()
        bt_nuevo = New Button()
        bt_guardar = New Button()
        bt_borrar = New Button()
        bt_salir = New Button()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 49)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(822, 250)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(126, 384)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(126, 425)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 2
        Label2.Text = "Direccion:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(126, 465)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 3
        Label3.Text = "Telefono:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(126, 502)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 4
        Label4.Text = "Correo:"
        ' 
        ' ct_nombre
        ' 
        ct_nombre.Location = New Point(240, 381)
        ct_nombre.Name = "ct_nombre"
        ct_nombre.Size = New Size(222, 27)
        ct_nombre.TabIndex = 5
        ' 
        ' ct_direccion
        ' 
        ct_direccion.Location = New Point(240, 425)
        ct_direccion.Name = "ct_direccion"
        ct_direccion.Size = New Size(222, 27)
        ct_direccion.TabIndex = 6
        ' 
        ' ct_telefono
        ' 
        ct_telefono.Location = New Point(240, 465)
        ct_telefono.Name = "ct_telefono"
        ct_telefono.Size = New Size(222, 27)
        ct_telefono.TabIndex = 7
        ' 
        ' ct_correo
        ' 
        ct_correo.Location = New Point(240, 502)
        ct_correo.Name = "ct_correo"
        ct_correo.Size = New Size(222, 27)
        ct_correo.TabIndex = 8
        ' 
        ' ctId_Proveedores
        ' 
        ctId_Proveedores.Location = New Point(240, 336)
        ctId_Proveedores.Name = "ctId_Proveedores"
        ctId_Proveedores.Size = New Size(222, 27)
        ctId_Proveedores.TabIndex = 9
        ctId_Proveedores.Visible = False
        ' 
        ' bt_nuevo
        ' 
        bt_nuevo.Location = New Point(76, 34)
        bt_nuevo.Name = "bt_nuevo"
        bt_nuevo.Size = New Size(94, 29)
        bt_nuevo.TabIndex = 0
        bt_nuevo.Text = "Nuevo"
        bt_nuevo.UseVisualStyleBackColor = True
        ' 
        ' bt_guardar
        ' 
        bt_guardar.Location = New Point(76, 69)
        bt_guardar.Name = "bt_guardar"
        bt_guardar.Size = New Size(94, 29)
        bt_guardar.TabIndex = 1
        bt_guardar.Text = "Guardar"
        bt_guardar.UseVisualStyleBackColor = True
        ' 
        ' bt_borrar
        ' 
        bt_borrar.Location = New Point(76, 104)
        bt_borrar.Name = "bt_borrar"
        bt_borrar.Size = New Size(94, 29)
        bt_borrar.TabIndex = 2
        bt_borrar.Text = "Borrar"
        bt_borrar.UseVisualStyleBackColor = True
        ' 
        ' bt_salir
        ' 
        bt_salir.Location = New Point(76, 139)
        bt_salir.Name = "bt_salir"
        bt_salir.Size = New Size(94, 29)
        bt_salir.TabIndex = 3
        bt_salir.Text = "Salir"
        bt_salir.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(bt_salir)
        GroupBox1.Controls.Add(bt_borrar)
        GroupBox1.Controls.Add(bt_guardar)
        GroupBox1.Controls.Add(bt_nuevo)
        GroupBox1.Location = New Point(536, 336)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 193)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(158, 343)
        Label5.Name = "Label5"
        Label5.Size = New Size(25, 20)
        Label5.TabIndex = 11
        Label5.Text = "Id:"
        Label5.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(846, 575)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(ctId_Proveedores)
        Controls.Add(ct_correo)
        Controls.Add(ct_telefono)
        Controls.Add(ct_direccion)
        Controls.Add(ct_nombre)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "Inventario"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ct_nombre As TextBox
    Friend WithEvents ct_direccion As TextBox
    Friend WithEvents ct_telefono As TextBox
    Friend WithEvents ct_correo As TextBox
    Friend WithEvents ctId_Proveedores As TextBox
    Friend WithEvents bt_nuevo As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents bt_borrar As Button
    Friend WithEvents bt_salir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label

End Class
