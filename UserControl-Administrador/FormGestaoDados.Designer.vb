<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestaoDados
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnomechagas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcaminhochagas = New System.Windows.Forms.TextBox()
        Me.txtcaminhoimagemchagas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtmodificacao = New System.Windows.Forms.TextBox()
        Me.txtwebforn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtimagemforn = New System.Windows.Forms.TextBox()
        Me.txtcaminhoforn = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtnomeforn = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btadicionar = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckChagas = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckFornecedor = New DevExpress.XtraEditors.CheckEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txttipofornecedor = New System.Windows.Forms.ComboBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chekactualizacao = New DevExpress.XtraEditors.CheckEdit()
        Me.txttipochagas = New System.Windows.Forms.ComboBox()
        Me.btadicinarchagas = New DevExpress.XtraEditors.SimpleButton()
        Me.btserchc = New DevExpress.XtraEditors.SimpleButton()
        Me.btserchi = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Checkactualizacaochagas = New DevExpress.XtraEditors.CheckEdit()
        Me.txtdropbox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.CheckChagas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckFornecedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.chekactualizacao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Checkactualizacaochagas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbgeral.Size = New System.Drawing.Size(476, 55)
        Me.lbgeral.TabIndex = 9
        Me.lbgeral.Text = "Gestão de Catálogos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nome do Catálogo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Código do Catálogo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tipo do Catálogo:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(210, 165)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(504, 26)
        Me.txtcodigo.TabIndex = 1
        '
        'txtnomechagas
        '
        Me.txtnomechagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomechagas.Location = New System.Drawing.Point(210, 199)
        Me.txtnomechagas.Name = "txtnomechagas"
        Me.txtnomechagas.Size = New System.Drawing.Size(504, 26)
        Me.txtnomechagas.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Caminho Catálogo:"
        '
        'txtcaminhochagas
        '
        Me.txtcaminhochagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcaminhochagas.Location = New System.Drawing.Point(210, 266)
        Me.txtcaminhochagas.Name = "txtcaminhochagas"
        Me.txtcaminhochagas.Size = New System.Drawing.Size(504, 26)
        Me.txtcaminhochagas.TabIndex = 101
        '
        'txtcaminhoimagemchagas
        '
        Me.txtcaminhoimagemchagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcaminhoimagemchagas.Location = New System.Drawing.Point(210, 298)
        Me.txtcaminhoimagemchagas.Name = "txtcaminhoimagemchagas"
        Me.txtcaminhoimagemchagas.Size = New System.Drawing.Size(504, 26)
        Me.txtcaminhoimagemchagas.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Caminho Imagem:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 24)
        Me.Label10.TabIndex = 359
        Me.Label10.Text = "Última Modificação:"
        '
        'txtmodificacao
        '
        Me.txtmodificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodificacao.Location = New System.Drawing.Point(199, 268)
        Me.txtmodificacao.Name = "txtmodificacao"
        Me.txtmodificacao.Size = New System.Drawing.Size(301, 26)
        Me.txtmodificacao.TabIndex = 13
        '
        'txtwebforn
        '
        Me.txtwebforn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwebforn.Location = New System.Drawing.Point(199, 219)
        Me.txtwebforn.Name = "txtwebforn"
        Me.txtwebforn.Size = New System.Drawing.Size(503, 26)
        Me.txtwebforn.TabIndex = 387
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(11, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 24)
        Me.Label11.TabIndex = 362
        Me.Label11.Text = "Página Web:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(11, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 24)
        Me.Label12.TabIndex = 368
        Me.Label12.Text = "Caminho Imagem:"
        '
        'txtimagemforn
        '
        Me.txtimagemforn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimagemforn.Location = New System.Drawing.Point(199, 177)
        Me.txtimagemforn.Name = "txtimagemforn"
        Me.txtimagemforn.Size = New System.Drawing.Size(503, 26)
        Me.txtimagemforn.TabIndex = 10
        '
        'txtcaminhoforn
        '
        Me.txtcaminhoforn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcaminhoforn.Location = New System.Drawing.Point(199, 135)
        Me.txtcaminhoforn.Name = "txtcaminhoforn"
        Me.txtcaminhoforn.Size = New System.Drawing.Size(503, 26)
        Me.txtcaminhoforn.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(11, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(170, 24)
        Me.Label13.TabIndex = 365
        Me.Label13.Text = "Caminho Catálogo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(11, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(159, 24)
        Me.Label14.TabIndex = 363
        Me.Label14.Text = "Tipo do Catálogo:"
        '
        'txtnomeforn
        '
        Me.txtnomeforn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomeforn.Location = New System.Drawing.Point(199, 51)
        Me.txtnomeforn.Name = "txtnomeforn"
        Me.txtnomeforn.Size = New System.Drawing.Size(503, 26)
        Me.txtnomeforn.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(11, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(173, 24)
        Me.Label15.TabIndex = 369
        Me.Label15.Text = "Nome do Catálogo:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(11, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(489, 29)
        Me.Label16.TabIndex = 371
        Me.Label16.Text = "__________________________________"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(466, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(242, 29)
        Me.Label17.TabIndex = 372
        Me.Label17.Text = "Catálogo Fornecedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(510, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 29)
        Me.Label7.TabIndex = 374
        Me.Label7.Text = "Catálogos Chagas"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(22, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(601, 29)
        Me.Label8.TabIndex = 373
        Me.Label8.Text = "__________________________________________"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btadicionar
        '
        Me.btadicionar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btadicionar.Appearance.Options.UseFont = True
        Me.btadicionar.Location = New System.Drawing.Point(518, 268)
        Me.btadicionar.Name = "btadicionar"
        Me.btadicionar.Size = New System.Drawing.Size(184, 26)
        Me.btadicionar.TabIndex = 388
        Me.btadicionar.Text = "Adicionar"
        '
        'CheckChagas
        '
        Me.CheckChagas.EditValue = True
        Me.CheckChagas.Location = New System.Drawing.Point(512, 27)
        Me.CheckChagas.Name = "CheckChagas"
        Me.CheckChagas.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckChagas.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CheckChagas.Properties.Appearance.Options.UseFont = True
        Me.CheckChagas.Properties.Appearance.Options.UseForeColor = True
        Me.CheckChagas.Properties.Caption = "Catálogo Chagas"
        Me.CheckChagas.Size = New System.Drawing.Size(194, 30)
        Me.CheckChagas.TabIndex = 382
        '
        'CheckFornecedor
        '
        Me.CheckFornecedor.Location = New System.Drawing.Point(512, 63)
        Me.CheckFornecedor.Name = "CheckFornecedor"
        Me.CheckFornecedor.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckFornecedor.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CheckFornecedor.Properties.Appearance.Options.UseFont = True
        Me.CheckFornecedor.Properties.Appearance.Options.UseForeColor = True
        Me.CheckFornecedor.Properties.Caption = "Catálogo Fornecedor"
        Me.CheckFornecedor.Size = New System.Drawing.Size(226, 30)
        Me.CheckFornecedor.TabIndex = 383
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txttipofornecedor)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btadicionar)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtmodificacao)
        Me.Panel2.Controls.Add(Me.txtwebforn)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtcaminhoforn)
        Me.Panel2.Controls.Add(Me.txtimagemforn)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txtnomeforn)
        Me.Panel2.Controls.Add(Me.chekactualizacao)
        Me.Panel2.Location = New System.Drawing.Point(12, 361)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(749, 325)
        Me.Panel2.TabIndex = 384
        '
        'txttipofornecedor
        '
        Me.txttipofornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txttipofornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipofornecedor.FormattingEnabled = True
        Me.txttipofornecedor.Location = New System.Drawing.Point(198, 93)
        Me.txttipofornecedor.Name = "txttipofornecedor"
        Me.txttipofornecedor.Size = New System.Drawing.Size(504, 28)
        Me.txttipofornecedor.TabIndex = 385
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(707, 177)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(29, 26)
        Me.SimpleButton1.TabIndex = 386
        Me.SimpleButton1.Text = "P"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(706, 135)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(29, 26)
        Me.SimpleButton2.TabIndex = 385
        Me.SimpleButton2.Text = "P"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(445, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(257, 16)
        Me.Label6.TabIndex = 378
        Me.Label6.Text = "* Esta família tem 0 catálogos associados"
        '
        'chekactualizacao
        '
        Me.chekactualizacao.EditValue = True
        Me.chekactualizacao.Location = New System.Drawing.Point(196, 305)
        Me.chekactualizacao.Name = "chekactualizacao"
        Me.chekactualizacao.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chekactualizacao.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chekactualizacao.Properties.Appearance.Options.UseFont = True
        Me.chekactualizacao.Properties.Appearance.Options.UseForeColor = True
        Me.chekactualizacao.Properties.Caption = "Disponibilizar Actualização"
        Me.chekactualizacao.Size = New System.Drawing.Size(226, 21)
        Me.chekactualizacao.TabIndex = 385
        '
        'txttipochagas
        '
        Me.txttipochagas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txttipochagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipochagas.FormattingEnabled = True
        Me.txttipochagas.Location = New System.Drawing.Point(210, 232)
        Me.txttipochagas.Name = "txttipochagas"
        Me.txttipochagas.Size = New System.Drawing.Size(504, 28)
        Me.txttipochagas.TabIndex = 3
        '
        'btadicinarchagas
        '
        Me.btadicinarchagas.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btadicinarchagas.Appearance.Options.UseFont = True
        Me.btadicinarchagas.Location = New System.Drawing.Point(530, 365)
        Me.btadicinarchagas.Name = "btadicinarchagas"
        Me.btadicinarchagas.Size = New System.Drawing.Size(184, 26)
        Me.btadicinarchagas.TabIndex = 7
        Me.btadicinarchagas.Text = "Adicionar"
        '
        'btserchc
        '
        Me.btserchc.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btserchc.Appearance.Options.UseFont = True
        Me.btserchc.Location = New System.Drawing.Point(718, 266)
        Me.btserchc.Name = "btserchc"
        Me.btserchc.Size = New System.Drawing.Size(29, 26)
        Me.btserchc.TabIndex = 4
        Me.btserchc.Text = "P"
        '
        'btserchi
        '
        Me.btserchi.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btserchi.Appearance.Options.UseFont = True
        Me.btserchi.Location = New System.Drawing.Point(718, 298)
        Me.btserchi.Name = "btserchi"
        Me.btserchi.Size = New System.Drawing.Size(29, 26)
        Me.btserchi.TabIndex = 5
        Me.btserchi.Text = "P"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Checkactualizacaochagas
        '
        Me.Checkactualizacaochagas.EditValue = True
        Me.Checkactualizacaochagas.Location = New System.Drawing.Point(208, 366)
        Me.Checkactualizacaochagas.Name = "Checkactualizacaochagas"
        Me.Checkactualizacaochagas.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkactualizacaochagas.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.Checkactualizacaochagas.Properties.Appearance.Options.UseFont = True
        Me.Checkactualizacaochagas.Properties.Appearance.Options.UseForeColor = True
        Me.Checkactualizacaochagas.Properties.Caption = "Disponibilizar Actualização"
        Me.Checkactualizacaochagas.Size = New System.Drawing.Size(226, 21)
        Me.Checkactualizacaochagas.TabIndex = 387
        '
        'txtdropbox
        '
        Me.txtdropbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdropbox.Location = New System.Drawing.Point(210, 330)
        Me.txtdropbox.Name = "txtdropbox"
        Me.txtdropbox.Size = New System.Drawing.Size(504, 26)
        Me.txtdropbox.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(23, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 24)
        Me.Label9.TabIndex = 389
        Me.Label9.Text = "Cloud:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Location = New System.Drawing.Point(718, 330)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(29, 26)
        Me.SimpleButton3.TabIndex = 390
        Me.SimpleButton3.Text = "B"
        '
        'FormGestaoDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(763, 695)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdropbox)
        Me.Controls.Add(Me.btserchi)
        Me.Controls.Add(Me.btserchc)
        Me.Controls.Add(Me.btadicinarchagas)
        Me.Controls.Add(Me.txttipochagas)
        Me.Controls.Add(Me.CheckFornecedor)
        Me.Controls.Add(Me.CheckChagas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcaminhoimagemchagas)
        Me.Controls.Add(Me.txtcaminhochagas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnomechagas)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbgeral)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Checkactualizacaochagas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGestaoDados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormGestaoDados"
        CType(Me.CheckChagas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckFornecedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.chekactualizacao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Checkactualizacaochagas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbgeral As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtnomechagas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcaminhochagas As System.Windows.Forms.TextBox
    Friend WithEvents txtcaminhoimagemchagas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtmodificacao As System.Windows.Forms.TextBox
    Friend WithEvents txtwebforn As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtimagemforn As System.Windows.Forms.TextBox
    Friend WithEvents txtcaminhoforn As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtnomeforn As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btadicionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckChagas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckFornecedor As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txttipochagas As System.Windows.Forms.ComboBox
    Friend WithEvents btadicinarchagas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btserchc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btserchi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txttipofornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents chekactualizacao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Checkactualizacaochagas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtdropbox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
