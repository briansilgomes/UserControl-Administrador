<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.lbgeral = New System.Windows.Forms.Label()
        Me.Painelfundo = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bteliminar = New System.Windows.Forms.Button()
        Me.btalterar = New System.Windows.Forms.Button()
        Me.btadicionar = New System.Windows.Forms.Button()
        Me.btfamilias = New System.Windows.Forms.Button()
        Me.btadmin = New System.Windows.Forms.Button()
        Me.btpromo = New System.Windows.Forms.Button()
        Me.btmanuais = New System.Windows.Forms.Button()
        Me.btfornecedor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Painelfundo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbgeral
        '
        Me.lbgeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbgeral.AutoSize = True
        Me.lbgeral.BackColor = System.Drawing.Color.Transparent
        Me.lbgeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgeral.ForeColor = System.Drawing.Color.White
        Me.lbgeral.Location = New System.Drawing.Point(19, 560)
        Me.lbgeral.Name = "lbgeral"
        Me.lbgeral.Size = New System.Drawing.Size(683, 110)
        Me.lbgeral.TabIndex = 7
        Me.lbgeral.Text = "UserControl" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gestão Intregrada de Vendas"
        Me.lbgeral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Painelfundo
        '
        Me.Painelfundo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Painelfundo.Controls.Add(Me.Label5)
        Me.Painelfundo.Controls.Add(Me.Label3)
        Me.Painelfundo.Controls.Add(Me.lbgeral)
        Me.Painelfundo.Location = New System.Drawing.Point(1, 0)
        Me.Painelfundo.Name = "Painelfundo"
        Me.Painelfundo.Size = New System.Drawing.Size(764, 697)
        Me.Painelfundo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Ivory
        Me.Label5.Location = New System.Drawing.Point(478, 570)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Florêncio Augusto Chagas, S.A."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(302, 540)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(402, 55)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "______________"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.UserControl___Administrador.My.Resources.Resources.Untitled_1
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.bteliminar)
        Me.Panel1.Controls.Add(Me.btalterar)
        Me.Panel1.Controls.Add(Me.btadicionar)
        Me.Panel1.Controls.Add(Me.btfamilias)
        Me.Panel1.Controls.Add(Me.btadmin)
        Me.Panel1.Controls.Add(Me.btpromo)
        Me.Panel1.Controls.Add(Me.btmanuais)
        Me.Panel1.Controls.Add(Me.btfornecedor)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(765, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 697)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 468)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(402, 55)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "______________"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bteliminar
        '
        Me.bteliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bteliminar.BackColor = System.Drawing.Color.Transparent
        Me.bteliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bteliminar.FlatAppearance.BorderSize = 0
        Me.bteliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.bteliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.bteliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bteliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bteliminar.ForeColor = System.Drawing.Color.White
        Me.bteliminar.Location = New System.Drawing.Point(0, 626)
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.Size = New System.Drawing.Size(245, 44)
        Me.bteliminar.TabIndex = 9
        Me.bteliminar.Text = "   Remover Catálogo"
        Me.bteliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bteliminar.UseVisualStyleBackColor = False
        '
        'btalterar
        '
        Me.btalterar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btalterar.BackColor = System.Drawing.Color.Transparent
        Me.btalterar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btalterar.FlatAppearance.BorderSize = 0
        Me.btalterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btalterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btalterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btalterar.ForeColor = System.Drawing.Color.White
        Me.btalterar.Location = New System.Drawing.Point(0, 576)
        Me.btalterar.Name = "btalterar"
        Me.btalterar.Size = New System.Drawing.Size(245, 44)
        Me.btalterar.TabIndex = 8
        Me.btalterar.Text = "   Alterar Catálogo"
        Me.btalterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btalterar.UseVisualStyleBackColor = False
        '
        'btadicionar
        '
        Me.btadicionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btadicionar.BackColor = System.Drawing.Color.Transparent
        Me.btadicionar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btadicionar.FlatAppearance.BorderSize = 0
        Me.btadicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btadicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btadicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btadicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btadicionar.ForeColor = System.Drawing.Color.White
        Me.btadicionar.Location = New System.Drawing.Point(0, 526)
        Me.btadicionar.Name = "btadicionar"
        Me.btadicionar.Size = New System.Drawing.Size(245, 44)
        Me.btadicionar.TabIndex = 7
        Me.btadicionar.Text = "   Adicionar Catálogo"
        Me.btadicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btadicionar.UseVisualStyleBackColor = False
        '
        'btfamilias
        '
        Me.btfamilias.BackColor = System.Drawing.Color.Transparent
        Me.btfamilias.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btfamilias.FlatAppearance.BorderSize = 0
        Me.btfamilias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btfamilias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btfamilias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btfamilias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btfamilias.ForeColor = System.Drawing.Color.White
        Me.btfamilias.Location = New System.Drawing.Point(0, 119)
        Me.btfamilias.Name = "btfamilias"
        Me.btfamilias.Size = New System.Drawing.Size(245, 44)
        Me.btfamilias.TabIndex = 1
        Me.btfamilias.Text = "   Catálogos Chagas  "
        Me.btfamilias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btfamilias.UseVisualStyleBackColor = False
        '
        'btadmin
        '
        Me.btadmin.BackColor = System.Drawing.Color.Transparent
        Me.btadmin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btadmin.FlatAppearance.BorderSize = 0
        Me.btadmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btadmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btadmin.ForeColor = System.Drawing.Color.White
        Me.btadmin.Location = New System.Drawing.Point(0, 319)
        Me.btadmin.Name = "btadmin"
        Me.btadmin.Size = New System.Drawing.Size(245, 44)
        Me.btadmin.TabIndex = 6
        Me.btadmin.Text = "   Estatística "
        Me.btadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btadmin.UseVisualStyleBackColor = False
        '
        'btpromo
        '
        Me.btpromo.BackColor = System.Drawing.Color.Transparent
        Me.btpromo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btpromo.FlatAppearance.BorderSize = 0
        Me.btpromo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btpromo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btpromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btpromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btpromo.ForeColor = System.Drawing.Color.White
        Me.btpromo.Location = New System.Drawing.Point(0, 269)
        Me.btpromo.Name = "btpromo"
        Me.btpromo.Size = New System.Drawing.Size(245, 44)
        Me.btpromo.TabIndex = 5
        Me.btpromo.Text = "   Promoções   "
        Me.btpromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btpromo.UseVisualStyleBackColor = False
        '
        'btmanuais
        '
        Me.btmanuais.BackColor = System.Drawing.Color.Transparent
        Me.btmanuais.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btmanuais.FlatAppearance.BorderSize = 0
        Me.btmanuais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btmanuais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btmanuais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmanuais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmanuais.ForeColor = System.Drawing.Color.White
        Me.btmanuais.Location = New System.Drawing.Point(0, 219)
        Me.btmanuais.Name = "btmanuais"
        Me.btmanuais.Size = New System.Drawing.Size(245, 44)
        Me.btmanuais.TabIndex = 4
        Me.btmanuais.Text = "   Manuais Técnicos   "
        Me.btmanuais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btmanuais.UseVisualStyleBackColor = False
        '
        'btfornecedor
        '
        Me.btfornecedor.BackColor = System.Drawing.Color.Transparent
        Me.btfornecedor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btfornecedor.FlatAppearance.BorderSize = 0
        Me.btfornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btfornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btfornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btfornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btfornecedor.ForeColor = System.Drawing.Color.White
        Me.btfornecedor.Location = New System.Drawing.Point(0, 169)
        Me.btfornecedor.Name = "btfornecedor"
        Me.btfornecedor.Size = New System.Drawing.Size(245, 44)
        Me.btfornecedor.TabIndex = 3
        Me.btfornecedor.Text = "   Catálogos Fornecedores  "
        Me.btfornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btfornecedor.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(62, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Administrador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UserControl"
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1004, 699)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Painelfundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserControl - Administrador"
        Me.Painelfundo.ResumeLayout(False)
        Me.Painelfundo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btfamilias As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btadmin As System.Windows.Forms.Button
    Friend WithEvents btpromo As System.Windows.Forms.Button
    Friend WithEvents btmanuais As System.Windows.Forms.Button
    Friend WithEvents btfornecedor As System.Windows.Forms.Button
    Friend WithEvents lbgeral As System.Windows.Forms.Label
    Friend WithEvents Painelfundo As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btadicionar As System.Windows.Forms.Button
    Friend WithEvents bteliminar As System.Windows.Forms.Button
    Friend WithEvents btalterar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
