<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.txttexto = New System.Windows.Forms.TextBox()
        Me.btnenviar = New System.Windows.Forms.Button()
        Me.txtchat = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txttexto
        '
        Me.txttexto.Location = New System.Drawing.Point(28, 283)
        Me.txttexto.Multiline = True
        Me.txttexto.Name = "txttexto"
        Me.txttexto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txttexto.Size = New System.Drawing.Size(289, 40)
        Me.txttexto.TabIndex = 0
        '
        'btnenviar
        '
        Me.btnenviar.Location = New System.Drawing.Point(327, 283)
        Me.btnenviar.Name = "btnenviar"
        Me.btnenviar.Size = New System.Drawing.Size(100, 40)
        Me.btnenviar.TabIndex = 1
        Me.btnenviar.Text = "ENVIAR"
        Me.btnenviar.UseVisualStyleBackColor = True
        '
        'txtchat
        '
        Me.txtchat.Enabled = False
        Me.txtchat.Location = New System.Drawing.Point(28, 13)
        Me.txtchat.Name = "txtchat"
        Me.txtchat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtchat.Size = New System.Drawing.Size(399, 263)
        Me.txtchat.TabIndex = 2
        Me.txtchat.Text = ""
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 335)
        Me.Controls.Add(Me.txtchat)
        Me.Controls.Add(Me.btnenviar)
        Me.Controls.Add(Me.txttexto)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnenviar As Button
    Friend WithEvents txtchat As RichTextBox
    Public WithEvents txttexto As TextBox
End Class
