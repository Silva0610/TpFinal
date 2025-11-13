<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        TxtPr = New TextBox()
        Button5 = New Button()
        Button1 = New Button()
        BuscarPr = New Button()
        Button3 = New Button()
        btnbajapr = New Button()
        BtnAltapr = New Button()
        DataGridView2 = New DataGridView()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtPr
        ' 
        TxtPr.Location = New Point(585, 263)
        TxtPr.Name = "TxtPr"
        TxtPr.Size = New Size(140, 23)
        TxtPr.TabIndex = 29
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(443, 311)
        Button5.Name = "Button5"
        Button5.Size = New Size(116, 39)
        Button5.TabIndex = 28
        Button5.Text = "Salir"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(665, 393)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 38)
        Button1.TabIndex = 27
        Button1.Text = "Retroceder"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BuscarPr
        ' 
        BuscarPr.Location = New Point(443, 251)
        BuscarPr.Name = "BuscarPr"
        BuscarPr.Size = New Size(116, 45)
        BuscarPr.TabIndex = 26
        BuscarPr.Text = "Buscar productos"
        BuscarPr.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(443, 182)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 45)
        Button3.TabIndex = 25
        Button3.Text = "Modificar productos"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnbajapr
        ' 
        btnbajapr.Location = New Point(443, 111)
        btnbajapr.Name = "btnbajapr"
        btnbajapr.Size = New Size(116, 45)
        btnbajapr.TabIndex = 24
        btnbajapr.Text = "Baja"
        btnbajapr.UseVisualStyleBackColor = True
        ' 
        ' BtnAltapr
        ' 
        BtnAltapr.Location = New Point(443, 51)
        BtnAltapr.Name = "BtnAltapr"
        BtnAltapr.Size = New Size(116, 45)
        BtnAltapr.TabIndex = 23
        BtnAltapr.Text = "Alta"
        BtnAltapr.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(19, 19)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(387, 355)
        DataGridView2.TabIndex = 22
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtPr)
        Controls.Add(Button5)
        Controls.Add(Button1)
        Controls.Add(BuscarPr)
        Controls.Add(Button3)
        Controls.Add(btnbajapr)
        Controls.Add(BtnAltapr)
        Controls.Add(DataGridView2)
        Name = "Form5"
        Text = "Form5"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtPr As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BuscarPr As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnbajapr As Button
    Friend WithEvents BtnAltapr As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
