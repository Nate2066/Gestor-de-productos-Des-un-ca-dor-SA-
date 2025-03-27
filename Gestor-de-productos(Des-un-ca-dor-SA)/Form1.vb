Public Class Form1
    Dim formularioFactura As Factura
    Dim costoProducto, comision As Decimal
    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        formularioFactura = Factura
        If txtNombreCliente.Text <> Nothing And txtSalarioCliente.Text <> Nothing And txtPrecioProducto.Text <> Nothing Then
            If txtSalarioCliente.Text > 12500 Then
                formularioFactura.Show()
                formularioFactura.txtNombreCliente.Enabled = False
                formularioFactura.txtSalarioCliente.Enabled = False
                formularioFactura.txtPrecioProducto.Enabled = False
                formularioFactura.txtComision.Enabled = False
                formularioFactura.txtCostoSeguro.Enabled = False
                formularioFactura.ckbSeguro.Enabled = False

                formularioFactura.txtTotalAPagar.Enabled = False

                formularioFactura.txtCuota18Meses.Enabled = False
                formularioFactura.txtCuota24Meses.Enabled = False
                formularioFactura.txtCuota36Meses.Enabled = False

                formularioFactura.txtNombreCliente.Text = txtNombreCliente.Text
                formularioFactura.txtSalarioCliente.Text = "C$. " + txtSalarioCliente.Text
                If ckbIncluirSeguro.Checked = True Then
                    formularioFactura.txtCostoSeguro.Text = "$. 100.00"
                    formularioFactura.ckbSeguro.Checked = True
                Else
                    formularioFactura.txtCostoSeguro.Text = "$. 0.00"
                    formularioFactura.ckbSeguro.Checked = False
                End If
                If ckbIncluirSeguro.Checked = True Then
                    costoProducto = CDec(txtPrecioProducto.Text) + 100
                    formularioFactura.txtPrecioProducto.Text = "$. " + CStr(Math.Round(costoProducto, 2))
                Else
                    formularioFactura.txtPrecioProducto.Text = "$. " + CStr(txtPrecioProducto.Text)
                    costoProducto = CDec(txtPrecioProducto.Text)
                End If
                comision = costoProducto * 0.07
                formularioFactura.txtComision.Text = "$. " + CStr(comision)

                formularioFactura.txtTotalAPagar.Text = "$. " + CStr((costoProducto + comision))

                'cuotas
                If ckbIncluirSeguro.Checked = True Then
                    formularioFactura.txtCuota18Meses.Text = "$. " + CStr(Math.Round((costoProducto + comision) / 18, 2))
                    formularioFactura.txtCuota24Meses.Text = "$. " + CStr(Math.Round((costoProducto + comision) / 24, 2))
                    formularioFactura.txtCuota36Meses.Text = "$. " + CStr(Math.Round((costoProducto + comision) / 36, 2))
                End If
            Else
                MsgBox("Lo sentimos, usted no aplica para un credito", vbInformation, "Salario menor!")
            End If
        Else
            MsgBox("Ninguno de los primeros 3 espacios pueden estar vacios", vbInformation, "Espacios vacios!")
        End If
    End Sub

    Private Sub txtSalarioCliente_TextChanged(sender As Object, e As EventArgs) Handles txtSalarioCliente.TextChanged
        If Not IsNumeric(txtSalarioCliente.Text) Then
            txtSalarioCliente.Clear()
        End If
    End Sub

    Private Sub txtPrecioProducto_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioProducto.TextChanged
        If Not IsNumeric(txtPrecioProducto.Text) Then
            txtPrecioProducto.Clear()
        End If
    End Sub
End Class
