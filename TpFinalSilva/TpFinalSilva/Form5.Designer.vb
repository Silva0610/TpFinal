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
        DataGridView4 = New DataGridView()
        Total = New Button()
        asd = New Button()
        Salir = New Button()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView4
        ' 
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Location = New Point(131, 12)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.Size = New Size(494, 274)
        DataGridView4.TabIndex = 0
        ' 
        ' Total
        ' 
        Total.Location = New Point(144, 336)
        Total.Name = "Total"
        Total.Size = New Size(122, 45)
        Total.TabIndex = 1
        Total.Text = "Mostrar total"
        Total.UseVisualStyleBackColor = True
        ' 
        ' asd
        ' 
        asd.Location = New Point(294, 339)
        asd.Name = "asd"
        asd.Size = New Size(117, 42)
        asd.TabIndex = 2
        asd.Text = "asd"
        asd.UseVisualStyleBackColor = True
        ' 
        ' Salir
        ' 
        Salir.Location = New Point(455, 340)
        Salir.Name = "Salir"
        Salir.Size = New Size(122, 41)
        Salir.TabIndex = 3
        Salir.Text = "Salir"
        Salir.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Salir)
        Controls.Add(asd)
        Controls.Add(Total)
        Controls.Add(DataGridView4)
        Name = "Form5"
        Text = "Form5"
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Total As Button
    Friend WithEvents asd As Button
    Friend WithEvents Salir As Button
End Class
