<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Me.txtnick = New System.Windows.Forms.TextBox()
        Me.btnconectar = New System.Windows.Forms.Button()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.lblipservidor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnick
        '
        Me.txtnick.Location = New System.Drawing.Point(12, 93)
        Me.txtnick.Name = "txtnick"
        Me.txtnick.Size = New System.Drawing.Size(176, 20)
        Me.txtnick.TabIndex = 0
        '
        'btnconectar
        '
        Me.btnconectar.Location = New System.Drawing.Point(229, 38)
        Me.btnconectar.Name = "btnconectar"
        Me.btnconectar.Size = New System.Drawing.Size(92, 47)
        Me.btnconectar.TabIndex = 1
        Me.btnconectar.Text = "Conectar"
        Me.btnconectar.UseVisualStyleBackColor = True
        '
        'txtip
        '
        Me.txtip.Location = New System.Drawing.Point(48, 38)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(100, 20)
        Me.txtip.TabIndex = 2
        '
        'lblipservidor
        '
        Me.lblipservidor.AutoSize = True
        Me.lblipservidor.Location = New System.Drawing.Point(59, 22)
        Me.lblipservidor.Name = "lblipservidor"
        Me.lblipservidor.Size = New System.Drawing.Size(76, 13)
        Me.lblipservidor.TabIndex = 3
        Me.lblipservidor.Text = "IP SERVIDOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NICK NAME"
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 125)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblipservidor)
        Me.Controls.Add(Me.txtip)
        Me.Controls.Add(Me.btnconectar)
        Me.Controls.Add(Me.txtnick)
        Me.Name = "inicio"
        Me.Text = "inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnick As TextBox
    Friend WithEvents btnconectar As Button
    Friend WithEvents txtip As TextBox
    Friend WithEvents lblipservidor As Label
    Friend WithEvents Label1 As Label
End Class
