<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Label2 = New Label()
        Label1 = New Label()
        btnBuscar = New Button()
        TxtFecha2 = New TextBox()
        TxtFecha1 = New TextBox()
        Salir = New Button()
        asd = New Button()
        Total = New Button()
        DataGridView6 = New DataGridView()
        Button1 = New Button()
        CType(DataGridView6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(561, 284)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 17)
        Label2.TabIndex = 26
        Label2.Text = "FECHA 2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(561, 243)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 17)
        Label1.TabIndex = 25
        Label1.Text = "FECHA 1"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(666, 192)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(122, 42)
        btnBuscar.TabIndex = 24
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' TxtFecha2
        ' 
        TxtFecha2.Location = New Point(632, 281)
        TxtFecha2.Name = "TxtFecha2"
        TxtFecha2.Size = New Size(156, 23)
        TxtFecha2.TabIndex = 23
        ' 
        ' TxtFecha1
        ' 
        TxtFecha1.Location = New Point(632, 240)
        TxtFecha1.Name = "TxtFecha1"
        TxtFecha1.Size = New Size(156, 23)
        TxtFecha1.TabIndex = 22
        ' 
        ' Salir
        ' 
        Salir.Location = New Point(666, 397)
        Salir.Name = "Salir"
        Salir.Size = New Size(122, 41)
        Salir.TabIndex = 21
        Salir.Text = "Salir"
        Salir.UseVisualStyleBackColor = True
        ' 
        ' asd
        ' 
        asd.Location = New Point(666, 94)
        asd.Name = "asd"
        asd.Size = New Size(122, 42)
        asd.TabIndex = 20
        asd.Text = "Agregar cantidad"
        asd.UseVisualStyleBackColor = True
        ' 
        ' Total
        ' 
        Total.Location = New Point(666, 43)
        Total.Name = "Total"
        Total.Size = New Size(122, 45)
        Total.TabIndex = 19
        Total.Text = "Mostrar total"
        Total.UseVisualStyleBackColor = True
        ' 
        ' DataGridView6
        ' 
        DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView6.Location = New Point(12, 12)
        DataGridView6.Name = "DataGridView6"
        DataGridView6.Size = New Size(494, 274)
        DataGridView6.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(668, 150)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 28)
        Button1.TabIndex = 27
        Button1.Text = "Volver a ventas"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBuscar)
        Controls.Add(TxtFecha2)
        Controls.Add(TxtFecha1)
        Controls.Add(Salir)
        Controls.Add(asd)
        Controls.Add(Total)
        Controls.Add(DataGridView6)
        Name = "Form7"
        Text = "Form7"
        CType(DataGridView6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents TxtFecha2 As TextBox
    Friend WithEvents TxtFecha1 As TextBox
    Friend WithEvents Salir As Button
    Friend WithEvents asd As Button
    Friend WithEvents Total As Button
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents Button1 As Button
End Class
