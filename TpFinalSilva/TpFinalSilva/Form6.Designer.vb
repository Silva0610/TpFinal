<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        BtnRegistro = New Button()
        DataGridView3 = New DataGridView()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(477, 179)
        Button3.Name = "Button3"
        Button3.Size = New Size(122, 36)
        Button3.TabIndex = 14
        Button3.Text = "Informe"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(477, 241)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 40)
        Button2.TabIndex = 13
        Button2.Text = "Salir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(650, 366)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 46)
        Button1.TabIndex = 12
        Button1.Text = "Retroceder"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnRegistro
        ' 
        BtnRegistro.Location = New Point(476, 107)
        BtnRegistro.Name = "BtnRegistro"
        BtnRegistro.Size = New Size(125, 45)
        BtnRegistro.TabIndex = 11
        BtnRegistro.Text = "Registrar venta"
        BtnRegistro.UseVisualStyleBackColor = True
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(22, 38)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(406, 264)
        DataGridView3.TabIndex = 10
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(BtnRegistro)
        Controls.Add(DataGridView3)
        Name = "Form6"
        Text = "Form6"
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnRegistro As Button
    Friend WithEvents DataGridView3 As DataGridView
End Class
