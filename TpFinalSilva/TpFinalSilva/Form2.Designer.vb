<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        txtnombre2 = New TextBox()
        txtapellido2 = New TextBox()
        Label3 = New Label()
        txtdni2 = New TextBox()
        Label4 = New Label()
        txtcontraseña2 = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(219, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(352, 37)
        Label1.TabIndex = 0
        Label1.Text = "INGRESE NUEVOS DATOS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(219, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 1
        Label2.Text = "Usuario"
        ' 
        ' txtnombre2
        ' 
        txtnombre2.Location = New Point(312, 205)
        txtnombre2.Name = "txtnombre2"
        txtnombre2.Size = New Size(248, 23)
        txtnombre2.TabIndex = 2
        ' 
        ' txtapellido2
        ' 
        txtapellido2.Location = New Point(312, 246)
        txtapellido2.Name = "txtapellido2"
        txtapellido2.Size = New Size(248, 23)
        txtapellido2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(219, 249)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 3
        Label3.Text = "Apellido"
        ' 
        ' txtdni2
        ' 
        txtdni2.Location = New Point(312, 159)
        txtdni2.Name = "txtdni2"
        txtdni2.Size = New Size(248, 23)
        txtdni2.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(219, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(27, 15)
        Label4.TabIndex = 5
        Label4.Text = "DNI"
        ' 
        ' txtcontraseña2
        ' 
        txtcontraseña2.Location = New Point(312, 291)
        txtcontraseña2.Name = "txtcontraseña2"
        txtcontraseña2.Size = New Size(248, 23)
        txtcontraseña2.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(219, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 7
        Label5.Text = "Contraseña"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(333, 361)
        Button1.Name = "Button1"
        Button1.Size = New Size(181, 38)
        Button1.TabIndex = 9
        Button1.Text = "Crear cuenta"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(txtcontraseña2)
        Controls.Add(Label5)
        Controls.Add(txtdni2)
        Controls.Add(Label4)
        Controls.Add(txtapellido2)
        Controls.Add(Label3)
        Controls.Add(txtnombre2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre2 As TextBox
    Friend WithEvents txtapellido2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdni2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcontraseña2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
