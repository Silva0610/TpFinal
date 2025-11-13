<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        TxtBuscar = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        BtnBuscar = New Button()
        Button3 = New Button()
        btnbaja = New Button()
        BtnAlta = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(602, 175)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(112, 23)
        TxtBuscar.TabIndex = 22
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(664, 386)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 38)
        Button2.TabIndex = 21
        Button2.Text = "Retroceder"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(459, 265)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 38)
        Button1.TabIndex = 20
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.Location = New Point(459, 163)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(116, 45)
        BtnBuscar.TabIndex = 19
        BtnBuscar.Text = "Buscar clientes"
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(459, 214)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 45)
        Button3.TabIndex = 18
        Button3.Text = "Modificar Clientes "
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnbaja
        ' 
        btnbaja.Location = New Point(459, 112)
        btnbaja.Name = "btnbaja"
        btnbaja.Size = New Size(116, 45)
        btnbaja.TabIndex = 17
        btnbaja.Text = "Baja"
        btnbaja.UseVisualStyleBackColor = True
        ' 
        ' BtnAlta
        ' 
        BtnAlta.Location = New Point(459, 52)
        BtnAlta.Name = "BtnAlta"
        BtnAlta.Size = New Size(116, 45)
        BtnAlta.TabIndex = 16
        BtnAlta.Text = "Alta"
        BtnAlta.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 26)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(376, 307)
        DataGridView1.TabIndex = 15
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtBuscar)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(BtnBuscar)
        Controls.Add(Button3)
        Controls.Add(btnbaja)
        Controls.Add(BtnAlta)
        Controls.Add(DataGridView1)
        Name = "Form4"
        Text = "Form4"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnbaja As Button
    Friend WithEvents BtnAlta As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
