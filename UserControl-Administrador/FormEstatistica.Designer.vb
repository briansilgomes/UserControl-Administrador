<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstatistica
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lbgeral = New System.Windows.Forms.Label()
        Me.Listactualizacao = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btactualizacao = New System.Windows.Forms.Button()
        Me.Btuso = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbgeral.Size = New System.Drawing.Size(265, 55)
        Me.lbgeral.TabIndex = 9
        Me.lbgeral.Text = "Estatísticas"
        '
        'Listactualizacao
        '
        Me.Listactualizacao.AccessibleDescription = "ctmbarra"
        Me.Listactualizacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Listactualizacao.BackColor = System.Drawing.Color.White
        Me.Listactualizacao.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Listactualizacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.Listactualizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listactualizacao.FullRowSelect = True
        Me.Listactualizacao.GridLines = True
        Me.Listactualizacao.Location = New System.Drawing.Point(22, 115)
        Me.Listactualizacao.MultiSelect = False
        Me.Listactualizacao.Name = "Listactualizacao"
        Me.Listactualizacao.Size = New System.Drawing.Size(712, 558)
        Me.Listactualizacao.TabIndex = 193
        Me.Listactualizacao.UseCompatibleStateImageBehavior = False
        Me.Listactualizacao.View = System.Windows.Forms.View.Details
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
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(23, 115)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series4.ChartArea = "ChartArea1"
        Series4.IsVisibleInLegend = False
        Series4.Legend = "Legend1"
        Series4.Name = "Máquinas e Ferramentas"
        Series5.ChartArea = "ChartArea1"
        Series5.IsVisibleInLegend = False
        Series5.Legend = "Legend1"
        Series5.Name = "Produtos Siderúrgicos"
        Series6.ChartArea = "ChartArea1"
        Series6.IsVisibleInLegend = False
        Series6.Legend = "Legend1"
        Series6.Name = "Fornecedores"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(711, 558)
        Me.Chart1.TabIndex = 194
        Me.Chart1.Text = "-"
        Me.Chart1.Visible = False
        '
        'btactualizacao
        '
        Me.btactualizacao.BackColor = System.Drawing.Color.SeaGreen
        Me.btactualizacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btactualizacao.FlatAppearance.BorderSize = 0
        Me.btactualizacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btactualizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btactualizacao.ForeColor = System.Drawing.Color.White
        Me.btactualizacao.Location = New System.Drawing.Point(581, 75)
        Me.btactualizacao.Name = "btactualizacao"
        Me.btactualizacao.Size = New System.Drawing.Size(153, 34)
        Me.btactualizacao.TabIndex = 195
        Me.btactualizacao.Text = "Actualização"
        Me.btactualizacao.UseVisualStyleBackColor = False
        '
        'Btuso
        '
        Me.Btuso.BackColor = System.Drawing.Color.SeaGreen
        Me.Btuso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btuso.FlatAppearance.BorderSize = 0
        Me.Btuso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btuso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btuso.ForeColor = System.Drawing.Color.White
        Me.Btuso.Location = New System.Drawing.Point(422, 75)
        Me.Btuso.Name = "Btuso"
        Me.Btuso.Size = New System.Drawing.Size(153, 34)
        Me.Btuso.TabIndex = 196
        Me.Btuso.Text = "Utilização"
        Me.Btuso.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(481, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 20)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Base de Dados: 2013-01-29 08:30"
        '
        'FormEstatistica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(763, 695)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btuso)
        Me.Controls.Add(Me.btactualizacao)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Listactualizacao)
        Me.Controls.Add(Me.lbgeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEstatistica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormEstatistica"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbgeral As System.Windows.Forms.Label
    Friend WithEvents Listactualizacao As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btactualizacao As System.Windows.Forms.Button
    Friend WithEvents Btuso As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
