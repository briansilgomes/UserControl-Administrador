<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFamilias
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
        Me.Listfamilia = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbtotal = New System.Windows.Forms.Label()
        Me.txtpesquisa = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.txtpesquisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbgeral.Size = New System.Drawing.Size(431, 55)
        Me.lbgeral.TabIndex = 8
        Me.lbgeral.Text = "Catálogos Famílias"
        '
        'Listfamilia
        '
        Me.Listfamilia.AccessibleDescription = "ctmbarra"
        Me.Listfamilia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Listfamilia.BackColor = System.Drawing.Color.White
        Me.Listfamilia.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Listfamilia.Cursor = System.Windows.Forms.Cursors.Default
        Me.Listfamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listfamilia.FullRowSelect = True
        Me.Listfamilia.GridLines = True
        Me.Listfamilia.Location = New System.Drawing.Point(19, 139)
        Me.Listfamilia.MultiSelect = False
        Me.Listfamilia.Name = "Listfamilia"
        Me.Listfamilia.Size = New System.Drawing.Size(722, 537)
        Me.Listfamilia.TabIndex = 192
        Me.Listfamilia.UseCompatibleStateImageBehavior = False
        Me.Listfamilia.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 56
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome do Catálogo"
        Me.ColumnHeader2.Width = 310
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tipo de Catálogo"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 174
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Última Actualização"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 152
        '
        'lbtotal
        '
        Me.lbtotal.AutoSize = True
        Me.lbtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotal.ForeColor = System.Drawing.Color.White
        Me.lbtotal.Location = New System.Drawing.Point(437, 51)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(173, 25)
        Me.lbtotal.TabIndex = 198
        Me.lbtotal.Text = "( 106 catálogos )"
        '
        'txtpesquisa
        '
        Me.txtpesquisa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpesquisa.Location = New System.Drawing.Point(555, 105)
        Me.txtpesquisa.Name = "txtpesquisa"
        Me.txtpesquisa.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpesquisa.Properties.Appearance.Options.UseFont = True
        Me.txtpesquisa.Size = New System.Drawing.Size(186, 26)
        Me.txtpesquisa.TabIndex = 199
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
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "Pesquisa:"
        '
        'FormFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(763, 695)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpesquisa)
        Me.Controls.Add(Me.lbtotal)
        Me.Controls.Add(Me.Listfamilia)
        Me.Controls.Add(Me.lbgeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormFamilias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        CType(Me.txtpesquisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbgeral As System.Windows.Forms.Label
    Friend WithEvents Listfamilia As System.Windows.Forms.ListView
    Friend WithEvents lbtotal As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtpesquisa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
