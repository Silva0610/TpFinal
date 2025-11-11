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
        BtnBuscar = New Button()
        Button3 = New Button()
        btnbajapr = New Button()
        BtnAltapr = New Button()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        TxtBuscar = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.Location = New Point(467, 177)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(116, 45)
        BtnBuscar.TabIndex = 10
        BtnBuscar.Text = "Buscar clientes"
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(467, 228)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 45)
        Button3.TabIndex = 9
        Button3.Text = "Modificar Clientes "
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnbajapr
        ' 
        btnbajapr.Location = New Point(467, 126)
        btnbajapr.Name = "btnbajapr"
        btnbajapr.Size = New Size(116, 45)
        btnbajapr.TabIndex = 8
        btnbajapr.Text = "Baja"
        btnbajapr.UseVisualStyleBackColor = True
        ' 
        ' BtnAltapr
        ' 
        BtnAltapr.Location = New Point(467, 66)
        BtnAltapr.Name = "BtnAltapr"
        BtnAltapr.Size = New Size(116, 45)
        BtnAltapr.TabIndex = 7
        BtnAltapr.Text = "Alta"
        BtnAltapr.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(29, 40)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(376, 307)
        DataGridView1.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(467, 279)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 38)
        Button1.TabIndex = 12
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(672, 400)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 38)
        Button2.TabIndex = 13
        Button2.Text = "Retroceder"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(610, 189)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(112, 23)
        TxtBuscar.TabIndex = 14
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtBuscar)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(BtnBuscar)
        Controls.Add(Button3)
        Controls.Add(btnbajapr)
        Controls.Add(BtnAltapr)
        Controls.Add(DataGridView1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnbajapr As Button
    Friend WithEvents BtnAltapr As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtBuscar As TextBox
End Class
