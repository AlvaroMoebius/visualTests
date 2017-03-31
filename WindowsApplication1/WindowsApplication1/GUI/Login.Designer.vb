<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.labelUsuario = New System.Windows.Forms.Label
        Me.campoUsuario = New System.Windows.Forms.TextBox
        Me.campoClave = New System.Windows.Forms.TextBox
        Me.labelClave = New System.Windows.Forms.Label
        Me.botonLogin = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'labelUsuario
        '
        Me.labelUsuario.AutoSize = True
        Me.labelUsuario.Location = New System.Drawing.Point(13, 13)
        Me.labelUsuario.Name = "labelUsuario"
        Me.labelUsuario.Size = New System.Drawing.Size(46, 13)
        Me.labelUsuario.TabIndex = 0
        Me.labelUsuario.Text = "Usuario:"
        '
        'campoUsuario
        '
        Me.campoUsuario.Location = New System.Drawing.Point(66, 13)
        Me.campoUsuario.Name = "campoUsuario"
        Me.campoUsuario.Size = New System.Drawing.Size(111, 20)
        Me.campoUsuario.TabIndex = 1
        '
        'campoClave
        '
        Me.campoClave.Location = New System.Drawing.Point(66, 39)
        Me.campoClave.Name = "campoClave"
        Me.campoClave.Size = New System.Drawing.Size(111, 20)
        Me.campoClave.TabIndex = 2
        '
        'labelClave
        '
        Me.labelClave.AutoSize = True
        Me.labelClave.Location = New System.Drawing.Point(14, 39)
        Me.labelClave.Name = "labelClave"
        Me.labelClave.Size = New System.Drawing.Size(37, 13)
        Me.labelClave.TabIndex = 3
        Me.labelClave.Text = "Clave:"
        '
        'botonLogin
        '
        Me.botonLogin.Location = New System.Drawing.Point(66, 66)
        Me.botonLogin.Name = "botonLogin"
        Me.botonLogin.Size = New System.Drawing.Size(75, 23)
        Me.botonLogin.TabIndex = 4
        Me.botonLogin.Text = "Login"
        Me.botonLogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 220)
        Me.Controls.Add(Me.botonLogin)
        Me.Controls.Add(Me.labelClave)
        Me.Controls.Add(Me.campoClave)
        Me.Controls.Add(Me.campoUsuario)
        Me.Controls.Add(Me.labelUsuario)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelUsuario As System.Windows.Forms.Label
    Friend WithEvents campoUsuario As System.Windows.Forms.TextBox
    Friend WithEvents campoClave As System.Windows.Forms.TextBox
    Friend WithEvents labelClave As System.Windows.Forms.Label
    Friend WithEvents botonLogin As System.Windows.Forms.Button

End Class
