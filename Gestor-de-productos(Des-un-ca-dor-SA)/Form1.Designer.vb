<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtNombreCliente = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtSalarioCliente = New TextBox()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        txtPrecioProducto = New TextBox()
        Label5 = New Label()
        ckbIncluirSeguro = New CheckBox()
        btnFacturar = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(86, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 15)
        Label1.TabIndex = 1
        Label1.Text = "Ingrese datos del cliente"
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(12, 68)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(287, 23)
        txtNombreCliente.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(128, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nombre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(128, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 5
        Label3.Text = "Salario C$ :"
        ' 
        ' txtSalarioCliente
        ' 
        txtSalarioCliente.Location = New Point(12, 121)
        txtSalarioCliente.Name = "txtSalarioCliente"
        txtSalarioCliente.Size = New Size(287, 23)
        txtSalarioCliente.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Lavadora", "Refrigerador", "TV", "Microondas"})
        ComboBox1.Location = New Point(148, 195)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 23)
        ComboBox1.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 15)
        Label4.TabIndex = 7
        Label4.Text = "Seleccione el producto:"
        ' 
        ' txtPrecioProducto
        ' 
        txtPrecioProducto.Location = New Point(148, 166)
        txtPrecioProducto.Name = "txtPrecioProducto"
        txtPrecioProducto.Size = New Size(151, 23)
        txtPrecioProducto.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 169)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 15)
        Label5.TabIndex = 9
        Label5.Text = "Precio del producto $ :"
        ' 
        ' ckbIncluirSeguro
        ' 
        ckbIncluirSeguro.AutoSize = True
        ckbIncluirSeguro.Location = New Point(12, 238)
        ckbIncluirSeguro.Name = "ckbIncluirSeguro"
        ckbIncluirSeguro.Size = New Size(98, 19)
        ckbIncluirSeguro.TabIndex = 10
        ckbIncluirSeguro.Text = "Incluir seguro"
        ckbIncluirSeguro.UseVisualStyleBackColor = True
        ' 
        ' btnFacturar
        ' 
        btnFacturar.Location = New Point(148, 238)
        btnFacturar.Name = "btnFacturar"
        btnFacturar.Size = New Size(151, 23)
        btnFacturar.TabIndex = 11
        btnFacturar.Text = "Facturar"
        btnFacturar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.IndianRed
        Label6.Location = New Point(116, 275)
        Label6.Name = "Label6"
        Label6.Size = New Size(183, 15)
        Label6.TabIndex = 12
        Label6.Text = "Integrantes al inicio del codigo :D"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(311, 302)
        Controls.Add(Label6)
        Controls.Add(btnFacturar)
        Controls.Add(ckbIncluirSeguro)
        Controls.Add(Label5)
        Controls.Add(txtPrecioProducto)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(txtSalarioCliente)
        Controls.Add(Label2)
        Controls.Add(txtNombreCliente)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Datos de entrada"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSalarioCliente As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ckbIncluirSeguro As CheckBox
    Friend WithEvents btnFacturar As Button
    Friend WithEvents Label6 As Label

End Class
