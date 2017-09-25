<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnverificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnverificar
        '
        Me.btnverificar.Location = New System.Drawing.Point(99, 215)
        Me.btnverificar.Name = "btnverificar"
        Me.btnverificar.Size = New System.Drawing.Size(75, 23)
        Me.btnverificar.TabIndex = 0
        Me.btnverificar.Text = "VERIFICAR"
        Me.btnverificar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnverificar)
        Me.Name = "Form1"
        Me.Text = "PRUEBA_1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnverificar As Button
End Class
