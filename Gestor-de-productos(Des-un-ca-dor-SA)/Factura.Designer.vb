<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        lblNombreCliente = New Label()
        txtSalarioCliente = New TextBox()
        lblSalarioCliente = New Label()
        txtNombreCliente = New TextBox()
        txtPrecioProducto = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtComision = New TextBox()
        Label3 = New Label()
        txtCostoSeguro = New TextBox()
        txtTotalAPagar = New TextBox()
        Label4 = New Label()
        ckbSeguro = New CheckBox()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        txtCuota18Meses = New TextBox()
        txtCuota24Meses = New TextBox()
        Label6 = New Label()
        txtCuota36Meses = New TextBox()
        Label7 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNombreCliente
        ' 
        lblNombreCliente.AutoSize = True
        lblNombreCliente.Location = New Point(12, 15)
        lblNombreCliente.Name = "lblNombreCliente"
        lblNombreCliente.Size = New Size(111, 15)
        lblNombreCliente.TabIndex = 0
        lblNombreCliente.Text = "Nombre de cliente :"
        ' 
        ' txtSalarioCliente
        ' 
        txtSalarioCliente.Location = New Point(126, 41)
        txtSalarioCliente.Name = "txtSalarioCliente"
        txtSalarioCliente.Size = New Size(247, 23)
        txtSalarioCliente.TabIndex = 1
        ' 
        ' lblSalarioCliente
        ' 
        lblSalarioCliente.AutoSize = True
        lblSalarioCliente.Location = New Point(12, 44)
        lblSalarioCliente.Name = "lblSalarioCliente"
        lblSalarioCliente.Size = New Size(102, 15)
        lblSalarioCliente.TabIndex = 2
        lblSalarioCliente.Text = "Salario de cliente :"
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(126, 12)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(247, 23)
        txtNombreCliente.TabIndex = 3
        ' 
        ' txtPrecioProducto
        ' 
        txtPrecioProducto.Location = New Point(126, 100)
        txtPrecioProducto.Name = "txtPrecioProducto"
        txtPrecioProducto.Size = New Size(247, 23)
        txtPrecioProducto.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 15)
        Label1.TabIndex = 5
        Label1.Text = "Precio de producto :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 15)
        Label2.TabIndex = 7
        Label2.Text = "Costo de seguro :"
        ' 
        ' txtComision
        ' 
        txtComision.Location = New Point(126, 129)
        txtComision.Name = "txtComision"
        txtComision.Size = New Size(247, 23)
        txtComision.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 9
        Label3.Text = "Comision del 7% :"
        ' 
        ' txtCostoSeguro
        ' 
        txtCostoSeguro.Location = New Point(126, 70)
        txtCostoSeguro.Name = "txtCostoSeguro"
        txtCostoSeguro.Size = New Size(178, 23)
        txtCostoSeguro.TabIndex = 8
        ' 
        ' txtTotalAPagar
        ' 
        txtTotalAPagar.Location = New Point(126, 179)
        txtTotalAPagar.Name = "txtTotalAPagar"
        txtTotalAPagar.Size = New Size(247, 23)
        txtTotalAPagar.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 10
        Label4.Text = "Monto total :"
        ' 
        ' ckbSeguro
        ' 
        ckbSeguro.AutoSize = True
        ckbSeguro.Location = New Point(310, 74)
        ckbSeguro.Name = "ckbSeguro"
        ckbSeguro.Size = New Size(63, 19)
        ckbSeguro.TabIndex = 12
        ckbSeguro.Text = "Seguro"
        ckbSeguro.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtCuota36Meses)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtCuota24Meses)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtCuota18Meses)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(12, 256)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(361, 124)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cuotas mensuales"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 0
        Label5.Text = "18 Meses"
        ' 
        ' txtCuota18Meses
        ' 
        txtCuota18Meses.Location = New Point(67, 25)
        txtCuota18Meses.Name = "txtCuota18Meses"
        txtCuota18Meses.Size = New Size(277, 23)
        txtCuota18Meses.TabIndex = 16
        ' 
        ' txtCuota24Meses
        ' 
        txtCuota24Meses.Location = New Point(67, 54)
        txtCuota24Meses.Name = "txtCuota24Meses"
        txtCuota24Meses.Size = New Size(277, 23)
        txtCuota24Meses.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 17
        Label6.Text = "24 Meses"
        ' 
        ' txtCuota36Meses
        ' 
        txtCuota36Meses.Location = New Point(67, 83)
        txtCuota36Meses.Name = "txtCuota36Meses"
        txtCuota36Meses.Size = New Size(277, 23)
        txtCuota36Meses.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 19
        Label7.Text = "36 Meses"
        ' 
        ' Factura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(385, 392)
        Controls.Add(GroupBox1)
        Controls.Add(ckbSeguro)
        Controls.Add(txtTotalAPagar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtCostoSeguro)
        Controls.Add(Label2)
        Controls.Add(txtComision)
        Controls.Add(Label1)
        Controls.Add(txtPrecioProducto)
        Controls.Add(txtNombreCliente)
        Controls.Add(lblSalarioCliente)
        Controls.Add(txtSalarioCliente)
        Controls.Add(lblNombreCliente)
        Name = "Factura"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Factura"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtSalarioCliente As TextBox
    Friend WithEvents lblSalarioCliente As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtComision As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCostoSeguro As TextBox
    Friend WithEvents txtTotalAPagar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ckbSeguro As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCuota18Meses As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCuota36Meses As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCuota24Meses As TextBox
    Friend WithEvents Label6 As Label
End Class
