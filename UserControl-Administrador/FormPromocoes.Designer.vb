<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPromocoes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbgeral = New System.Windows.Forms.Label()
        Me.lbtotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Listpromo = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbgeral
        '
        Me.lbgeral.AutoSize = True
        Me.lbgeral.BackColor = System.Drawing.Color.Transparent
        Me.lbgeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgeral.ForeColor = System.Drawing.Color.White
        Me.lbgeral.Location = New System.Drawing.Point(12, 29)
        Me.lbgeral.Name = "lbgeral"
        Me.lbgeral.Size = New System.Drawing.Size(268, 55)
        Me.lbgeral.TabIndex = 9
        Me.lbgeral.Text = "Promoções"
        '
        'lbtotal
        '
        Me.lbtotal.AutoSize = True
        Me.lbtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotal.ForeColor = System.Drawing.Color.White
        Me.lbtotal.Location = New System.Drawing.Point(274, 51)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(173, 25)
        Me.lbtotal.TabIndex = 199
        Me.lbtotal.Text = "( 106 catálogos )"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(477, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Pesquisa:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.Location = New System.Drawing.Point(555, 108)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(186, 22)
        Me.TextEdit1.TabIndex = 205
        '
        'Listpromo
        '
        Me.Listpromo.AccessibleDescription = "ctmbarra"
        Me.Listpromo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Listpromo.BackColor = System.Drawing.Color.White
        Me.Listpromo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Listpromo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Listpromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listpromo.FullRowSelect = True
        Me.Listpromo.GridLines = True
        Me.Listpromo.Location = New System.Drawing.Point(19, 139)
        Me.Listpromo.MultiSelect = False
        Me.Listpromo.Name = "Listpromo"
        Me.Listpromo.Size = New System.Drawing.Size(722, 537)
        Me.Listpromo.TabIndex = 201
        Me.Listpromo.UseCompatibleStateImageBehavior = False
        Me.Listpromo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição da Promoção"
        Me.ColumnHeader2.Width = 280
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tipo de Promoção"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 174
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Última Actualização"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 152
        '
        'FormPromocoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(763, 695)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.Listpromo)
        Me.Controls.Add(Me.lbtotal)
        Me.Controls.Add(Me.lbgeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPromocoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormPromocoes"
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbgeral As System.Windows.Forms.Label
    Friend WithEvents lbtotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Listpromo As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
