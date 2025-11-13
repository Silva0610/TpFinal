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
        Label1 = New Label()
        txtdni1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtcontraseña1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(279, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 37)
        Label1.TabIndex = 0
        Label1.Text = "INGRESE DATOS"
        ' 
        ' txtdni1
        ' 
        txtdni1.Location = New Point(311, 180)
        txtdni1.Name = "txtdni1"
        txtdni1.Size = New Size(254, 23)
        txtdni1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(251, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 17)
        Label2.TabIndex = 2
        Label2.Text = "DNI"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(228, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 17)
        Label3.TabIndex = 4
        Label3.Text = "Contraseña"
        ' 
        ' txtcontraseña1
        ' 
        txtcontraseña1.Location = New Point(311, 234)
        txtcontraseña1.Name = "txtcontraseña1"
        txtcontraseña1.Size = New Size(254, 23)
        txtcontraseña1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(377, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 54)
        Button1.TabIndex = 5
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(676, 378)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 60)
        Button2.TabIndex = 6
        Button2.Text = "Registrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(txtcontraseña1)
        Controls.Add(Label2)
        Controls.Add(txtdni1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtdni1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcontraseña1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
