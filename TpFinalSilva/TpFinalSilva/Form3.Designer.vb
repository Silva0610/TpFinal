<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button1 = New Button()
        BuscarPr = New Button()
        Button3 = New Button()
        Button2 = New Button()
        BtnAlta = New Button()
        DataGridView2 = New DataGridView()
        Button5 = New Button()
        TxtPr = New TextBox()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(672, 400)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 38)
        Button1.TabIndex = 19
        Button1.Text = "Retroceder"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BuscarPr
        ' 
        BuscarPr.Location = New Point(450, 258)
        BuscarPr.Name = "BuscarPr"
        BuscarPr.Size = New Size(116, 45)
        BuscarPr.TabIndex = 17
        BuscarPr.Text = "Buscar productos"
        BuscarPr.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(450, 189)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 45)
        Button3.TabIndex = 16
        Button3.Text = "Modificar productos"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(450, 118)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 45)
        Button2.TabIndex = 15
        Button2.Text = "Baja"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnAlta
        ' 
        BtnAlta.Location = New Point(450, 58)
        BtnAlta.Name = "BtnAlta"
        BtnAlta.Size = New Size(116, 45)
        BtnAlta.TabIndex = 14
        BtnAlta.Text = "Alta"
        BtnAlta.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(26, 26)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(387, 355)
        DataGridView2.TabIndex = 13
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(450, 318)
        Button5.Name = "Button5"
        Button5.Size = New Size(116, 39)
        Button5.TabIndex = 20
        Button5.Text = "Salir"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TxtPr
        ' 
        TxtPr.Location = New Point(592, 270)
        TxtPr.Name = "TxtPr"
        TxtPr.Size = New Size(140, 23)
        TxtPr.TabIndex = 21
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtPr)
        Controls.Add(Button5)
        Controls.Add(Button1)
        Controls.Add(BuscarPr)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(BtnAlta)
        Controls.Add(DataGridView2)
        Name = "Form3"
        Text = "Form3"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BuscarPr As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnAlta As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents TxtPr As TextBox
End Class
