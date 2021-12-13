Imports MySql.Data.MySqlClient
Public Class FormHome

    Public app As String = My.Settings.conectionstringmysql
    Public connserver As MySqlConnection
    Public myAdapter As New MySqlDataAdapter
    Public myCommand As New MySqlCommand
    Public comando As String

    Public formactivo As String
    Dim heighthome, widthhome As Integer
    Dim resultado As Boolean = False

    Sub fecharform()
        While (Not Me.ActiveMdiChild Is Nothing)
            Me.ActiveMdiChild.Close()
        End While
    End Sub

    Private Sub btfamilias_Click(sender As System.Object, e As System.EventArgs) Handles btfamilias.Click

        fecharform()
        FormFamilias.MdiParent = Me
        FormFamilias.Location = New Point(0, 0)
        FormFamilias.Show()

        If Me.Height > 725 And Me.Width > 1010 Then
            FormFamilias.Size = New Size(widthhome, heighthome)
        ElseIf Me.Height = 725 And Me.Width = 1010 Then
            FormFamilias.Size = New Size(763, 695)
        End If

        Painelfundo.SendToBack()
        btfamilias.BackColor = Color.DarkSeaGreen

    End Sub
    Private Sub btfornecedor_Click(sender As System.Object, e As System.EventArgs) Handles btfornecedor.Click

        fecharform()
        FormFornecedores.MdiParent = Me
        FormFornecedores.Location = New Point(0, 0)
        FormFornecedores.Show()

        If Me.Height > 725 And Me.Width > 1010 Then
            FormFornecedores.Size = New Size(widthhome, heighthome)
        ElseIf Me.Height = 725 And Me.Width = 1010 Then
            FormFornecedores.Size = New Size(763, 695)
        End If

        Painelfundo.SendToBack()
        btfornecedor.BackColor = Color.DarkSeaGreen

    End Sub
    Private Sub btmanuais_Click(sender As System.Object, e As System.EventArgs) Handles btmanuais.Click

        fecharform()
        FormManuaisTecnicos.MdiParent = Me
        FormManuaisTecnicos.Location = New Point(0, 0)
        FormManuaisTecnicos.Show()

        If Me.Height > 725 And Me.Width > 1010 Then
            FormManuaisTecnicos.Size = New Size(widthhome, heighthome)
        ElseIf Me.Height = 725 And Me.Width = 1010 Then
            FormManuaisTecnicos.Size = New Size(763, 695)
        End If

        Painelfundo.SendToBack()
        btmanuais.BackColor = Color.DarkSeaGreen

    End Sub


    Private Sub btpromo_Click(sender As System.Object, e As System.EventArgs) Handles btpromo.Click

        fecharform()
        FormPromocoes.MdiParent = Me
        FormPromocoes.Location = New Point(0, 0)
        FormPromocoes.Show()

        If Me.Height > 725 And Me.Width > 1010 Then
            FormPromocoes.Size = New Size(widthhome, heighthome)
        ElseIf Me.Height = 725 And Me.Width = 1010 Then
            FormPromocoes.Size = New Size(763, 695)
        End If

        Painelfundo.SendToBack()
        btpromo.BackColor = Color.DarkSeaGreen

    End Sub

  

    Private Sub FormHome_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged

        heighthome = 0
        widthhome = 0

        heighthome = Panel1.Height
        widthhome = Me.Width - 246

        If formactivo = "Familias" Then
            btfamilias.PerformClick()
        ElseIf formactivo = "Fornecedores" Then
            btfornecedor.PerformClick()
        ElseIf formactivo = "Manuais Tecnicos" Then
            btmanuais.PerformClick()
        ElseIf formactivo = "Promocoes" Then
            btpromo.PerformClick()
        ElseIf formactivo = "Estatistica" Then
            btadmin.PerformClick()
        ElseIf formactivo = "Insert" Then
            btadicionar.PerformClick()
        ElseIf formactivo = "Update" Then
            btalterar.PerformClick()
        ElseIf formactivo = "Delete" Then
            bteliminar.PerformClick()
        End If

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        fecharform()
        formactivo = "nothing"
        Painelfundo.BringToFront()
    End Sub

    Private Sub btadicionar_Click(sender As System.Object, e As System.EventArgs) Handles btadicionar.Click

        fecharform()
        FormGestaoDados.MdiParent = Me
        FormGestaoDados.Location = New Point(0, 0)
        FormGestaoDados.Show()

        If Me.Height > 725 And Me.Width > 1010 Then
            FormGestaoDados.Size = New Size(widthhome, heighthome)
        ElseIf Me.Height = 725 And Me.Width = 1010 Then
            FormGestaoDados.Size = New Size(763, 695)
        End If

        Painelfundo.SendToBack()

        btadicionar.BackColor = Color.DarkSeaGreen
        btalterar.BackColor = Color.Transparent
        bteliminar.BackColor = Color.Transparent

        FormGestaoDados.lbgeral.Text = "Adicionar Catálogo"
        FormGestaoDados.btadicinarchagas.Text = "Adicionar"
        formactivo = "Insert"
    End Sub

    Public antigocodigo, antigonome, antigotipo, antigocaminho, antigoimagem, idfamilia, antigodropboxfamilia, antigoidtipo As String
    Public antigonomef, antigotipof, antigocaminhof, antigoimagemf, antigoweb As String
    Private Sub btalterar_Click(sender As System.Object, e As System.EventArgs) Handles btalterar.Click

        If FormFamilias.Visible = True And FormFamilias.Listfamilia.SelectedItems.Count <> 0 Then

            FormGestaoDados.btadicinarchagas.Text = "Alterar"

            FormGestaoDados.CheckChagas.Enabled = False
            FormGestaoDados.CheckFornecedor.Enabled = False

            FormGestaoDados.txtcodigo.Text = FormFamilias.Listfamilia.SelectedItems(0).Text
            FormGestaoDados.txtnomechagas.Text = FormFamilias.Listfamilia.SelectedItems(0).SubItems(1).Text
            FormGestaoDados.txttipochagas.SelectedItem = FormFamilias.Listfamilia.SelectedItems(0).SubItems(2).Text

            antigocodigo = FormFamilias.Listfamilia.SelectedItems(0).Text
            antigonome = FormFamilias.Listfamilia.SelectedItems(0).SubItems(1).Text
            antigotipo = FormFamilias.Listfamilia.SelectedItems(0).SubItems(2).Text

            Me.connserver = New MySqlConnection(Me.app)
            Me.connserver.Open()

            Me.comando = "SELECT caminhofamilia, imagemfamilia, idfamilia, dropboxfamilia FROM tabfamilias where codigofamilia='" & antigocodigo & "' and nomefamilia='" & antigonome & "'"
            Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
            Dim myReader As MySqlDataReader = Me.myCommand.ExecuteReader

            While myReader.Read
                FormGestaoDados.txtcaminhochagas.Text = myReader(0)
                antigocaminho = myReader(0)
                FormGestaoDados.txtcaminhoimagemchagas.Text = myReader(1)
                antigoimagem = myReader(1)
                idfamilia = myReader(2)
                FormGestaoDados.txtdropbox.Text = myReader(3)
                antigodropboxfamilia = myReader(3)
            End While

            Me.connserver.Close()

        ElseIf FormFamilias.Visible = True And FormFamilias.Listfamilia.SelectedItems.Count = 0 Then

            If Me.Height > 725 And Me.Width > 1010 Then
                FormGestaoDados.Size = New Size(widthhome, heighthome)
            ElseIf Me.Height = 725 And Me.Width = 1010 Then
                FormGestaoDados.Size = New Size(763, 695)
            End If

            btalterar.BackColor = Color.Transparent
            ' MsgBox("Para poder alterar um catálogo deverá primeiro seleccionar o catálogo em questão!", MsgBoxStyle.Information, "UserControl - Administrador")
            Exit Sub

        ElseIf FormFornecedores.Visible = True And FormFornecedores.Listfornecedor.SelectedItems.Count <> 0 Then

            alterarfornecedor()
        ElseIf FormManuaisTecnicos.Visible = True And FormManuaisTecnicos.Listmanual.SelectedItems.Count <> 0 Then

            alterarmanuais()


        ElseIf FormManuaisTecnicos.Visible = True And FormManuaisTecnicos.Listmanual.SelectedItems.Count = 0 Then
            If Me.Height > 725 And Me.Width > 1010 Then
                FormGestaoDados.Size = New Size(widthhome, heighthome)
            ElseIf Me.Height = 725 And Me.Width = 1010 Then
                FormGestaoDados.Size = New Size(763, 695)
            End If

            btalterar.BackColor = Color.Transparent
            ' MsgBox("Para poder alterar um catálogo deverá primeiro seleccionar o catálogo em questão!", MsgBoxStyle.Information, "UserControl - Administrador")
            Exit Sub
        ElseIf FormFornecedores.Visible = True And FormFornecedores.Listfornecedor.SelectedItems.Count = 0 Then

            If Me.Height > 725 And Me.Width > 1010 Then
                FormGestaoDados.Size = New Size(widthhome, heighthome)
            ElseIf Me.Height = 725 And Me.Width = 1010 Then
                FormGestaoDados.Size = New Size(763, 695)
            End If

            btalterar.BackColor = Color.Transparent
            ' MsgBox("Para poder alterar um catálogo deverá primeiro seleccionar o catálogo em questão!", MsgBoxStyle.Information, "UserControl - Administrador")
            Exit Sub

        ElseIf FormPromocoes.Visible = True And FormPromocoes.Listpromo.SelectedItems.Count <> 0 Then
            alterarpromocoes()

        ElseIf FormPromocoes.Visible = True And FormPromocoes.Listpromo.SelectedItems.Count = 0 Then
            If Me.Height > 725 And Me.Width > 1010 Then
                FormGestaoDados.Size = New Size(widthhome, heighthome)
            ElseIf Me.Height = 725 And Me.Width = 1010 Then
                FormGestaoDados.Size = New Size(763, 695)
            End If

            btalterar.BackColor = Color.Transparent
            ' MsgBox("Para poder alterar um catálogo deverá primeiro seleccionar o catálogo em questão!", MsgBoxStyle.Information, "UserControl - Administrador")
            Exit Sub

        ElseIf FormFornecedores.Visible = False Or FormFamilias.Visible = False Or FormPromocoes.Visible = False Or FormManuaisTecnicos.Visible = False Then

            If Me.Height > 725 And Me.Width > 1010 Then
                FormGestaoDados.Size = New Size(widthhome, heighthome)
            ElseIf Me.Height = 725 And Me.Width = 1010 Then
                FormGestaoDados.Size = New Size(763, 695)
            End If

            Exit Sub

        End If

        fecharform()
        FormGestaoDados.MdiParent = Me
        FormGestaoDados.Location = New Point(0, 0)
        FormGestaoDados.Show()

        If Me.Height > 725 And Me.Width > 1010 Then
            FormGestaoDados.Size = New Size(widthhome, heighthome)
        ElseIf Me.Height = 725 And Me.Width = 1010 Then
            FormGestaoDados.Size = New Size(763, 695)
        End If

        Painelfundo.SendToBack()

        btalterar.BackColor = Color.DarkSeaGreen
        btadicionar.BackColor = Color.Transparent
        bteliminar.BackColor = Color.Transparent

        If formactivo = "Fornecedores" Then
            FormGestaoDados.txttipofornecedor.SelectedItem = antigotipof
            FormGestaoDados.txttipochagas.SelectedItem = FormGestaoDados.tipocatalogo
        Else
            FormGestaoDados.txttipochagas.SelectedItem = antigotipo
        End If

        FormGestaoDados.lbgeral.Text = "Alterar Catálogo"
        formactivo = "Update"



    End Sub


    Private Sub bteliminar_Click(sender As System.Object, e As System.EventArgs) Handles bteliminar.Click

        'ELIINAR FAMILIA 
        If FormFamilias.Visible = True Then
            eliminarfamilias()
        ElseIf FormFornecedores.Visible = True Then
            eliminarfornecedor()
        ElseIf FormManuaisTecnicos.Visible = True Then
            eliminarmanuais()
        ElseIf FormPromocoes.Visible = True Then
            eliminarpromocoes()
        End If

    End Sub

    Sub VerificarAssociacaoChagas()

        Dim IDfamilia As String
        Dim result As String

        Me.connserver = New MySqlConnection(Me.app)
        Me.connserver.Open()

        Me.comando = "SELECT idfamilia FROM tabfamilias WHERE codigofamilia ='" & FormFamilias.Listfamilia.SelectedItems(0).Text & "' and nomefamilia='" & FormFamilias.Listfamilia.SelectedItems(0).SubItems(1).Text & "'"
        Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
        Dim myReader As MySqlDataReader = Me.myCommand.ExecuteReader

        While myReader.Read
            IDfamilia = myReader(0)
        End While

        myReader.Close()
        Me.connserver.Close()

        'VERIFICAR SE A FAMILIA EXISTE NA TABELA DE FORNECEDOREES
        Me.connserver.Open()

        Me.comando = "SELECT idfornecedor FROM tabfornecedores WHERE idfamilia='" & IDfamilia & "'"
        Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
        myReader = Me.myCommand.ExecuteReader

        While myReader.Read
            result = myReader(0)
        End While

        If result = Nothing Then
            resultado = False
        ElseIf result <> Nothing Then
            resultado = True
        End If

    End Sub

    'Familias
    Sub eliminarfamilias()

        Dim codigofamilia As String = FormFamilias.Listfamilia.SelectedItems(0).Text
        Dim nomefamilia As String = FormFamilias.Listfamilia.SelectedItems(0).SubItems(1).Text

        If FormFamilias.Listfamilia.SelectedItems.Count <> 0 Then

            Dim familiaeliminada As String = FormFamilias.Listfamilia.SelectedItems(0).Text & " - " & FormFamilias.Listfamilia.SelectedItems(0).SubItems(1).Text

            VerificarAssociacaoChagas()

            If resultado = True Then
                MsgBox("Este catálogo tem associado Catálogos de Fornecedores! Para eliminar esta família deverá primeiro eliminar todos os Catálogos de Fornecedores associados. ( " & familiaeliminada & " )", MsgBoxStyle.Exclamation, "UserControl - Administrador")
                Exit Sub
            End If

            If MsgBox("Deseja mesmo eliminar esta família? ( " & familiaeliminada & " )", MsgBoxStyle.YesNo, "UserControl - Administrador") = MsgBoxResult.Yes Then

                Me.connserver = New MySqlConnection(Me.app)
                Me.connserver.Open()

                Me.comando = "SELECT idtipoproduto, caminhofamilia, imagemfamilia FROM tabfamilias WHERE codigofamilia ='" & codigofamilia & "' and nomefamilia='" & nomefamilia & "'"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                Dim myRead As MySqlDataReader = Me.myCommand.ExecuteReader

                Dim tipoproduto, caminhopdf, caminhoimagem

                While myRead.Read
                    tipoproduto = myRead(0)
                    caminhopdf = myRead(1)
                    caminhoimagem = myRead(2)
                End While

                myRead.Close()
                Me.connserver.Close()

                ' CONVERTENDO CAMINHOS 
                caminhopdf = Replace(caminhopdf, "\", "\\")
                caminhoimagem = Replace(caminhoimagem, "\", "\\")

                Me.connserver.Open()
                Me.comando = "INSERT INTO tabelimindados (idtipoproduto, codigofamilia, nomefamilia, caminhofamilia, imagemfamilia) VALUES ('" & tipoproduto & "','" & codigofamilia & "','" & nomefamilia & "','" & caminhopdf & "','" & caminhoimagem & "')"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                Dim myReader As MySqlCommand = New MySqlCommand(Me.myCommand.ExecuteNonQuery)
                Me.connserver.Close()

                Me.connserver = New MySqlConnection(Me.app)
                Me.connserver.Open()
                Me.comando = "DELETE FROM tabfamilias WHERE codigofamilia ='" & codigofamilia & "' and nomefamilia='" & nomefamilia & "'"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                myReader = New MySqlCommand(Me.myCommand.ExecuteNonQuery)
                Me.connserver.Close()

                MsgBox("O catálogo foi elimidado com sucesso! ( " & familiaeliminada & " )", MsgBoxStyle.Information, "UserControl - Administrador")
                FormFamilias.carregarfamilias()

            End If
        End If
    End Sub

    'Fornecedores
    Sub alterarfornecedor()

        FormGestaoDados.btadicionar.Text = "Alterar"

        If FormFamilias.Visible = True Then
            FormGestaoDados.CheckChagas.Checked = True
        ElseIf FormFornecedores.Visible = True Then
            FormGestaoDados.CheckFornecedor.Checked = True
        End If

        FormGestaoDados.CheckChagas.Enabled = False
        FormGestaoDados.CheckFornecedor.Enabled = False

        antigonomef = FormFornecedores.Listfornecedor.SelectedItems(0).Text
        antigotipof = FormFornecedores.Listfornecedor.SelectedItems(0).SubItems(1).Text

        FormGestaoDados.txtnomeforn.Text = FormFornecedores.Listfornecedor.SelectedItems(0).Text
        FormGestaoDados.txttipofornecedor.SelectedItem = antigotipof
        FormGestaoDados.txtmodificacao.Text = FormFornecedores.Listfornecedor.SelectedItems(0).SubItems(2).Text

        Me.connserver = New MySqlConnection(Me.app)
        Me.connserver.Open()

        Me.comando = "SELECT caminhofornecedor, imagemfornecedor, paginaweb, idfamilia, idtipoproduto FROM tabfornecedores where nomefornecedor='" & antigonomef & "'"
        Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
        Dim myReader As MySqlDataReader = Me.myCommand.ExecuteReader

        While myReader.Read

            FormGestaoDados.txtcaminhoforn.Text = myReader(0)
            antigocaminhof = myReader(0)
            FormGestaoDados.txtimagemforn.Text = myReader(1)
            antigoimagemf = myReader(1)
            FormGestaoDados.txtwebforn.Text = myReader(2)
            antigoweb = myReader(2)
            idfamilia = myReader(3)
            antigoidtipo = myReader(4)

        End While

        Me.connserver.Close()

        Me.connserver = New MySqlConnection(Me.app)
        Me.connserver.Open()

        Me.comando = "SELECT caminhofornecedor, imagemfornecedor, paginaweb, idfamilia FROM tabfornecedores where nomefornecedor='" & antigonomef & "'"
        Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
        myReader = Me.myCommand.ExecuteReader

        While myReader.Read

            FormGestaoDados.txtcaminhoforn.Text = myReader(0)
            antigocaminhof = myReader(0)
            FormGestaoDados.txtimagemforn.Text = myReader(1)
            antigoimagemf = myReader(1)
            FormGestaoDados.txtwebforn.Text = myReader(2)
            antigoweb = myReader(2)
            idfamilia = myReader(3)
        End While

        Me.connserver.Close()

        Me.connserver = New MySqlConnection(Me.app)
        Me.connserver.Open()

        Me.comando = "SELECT tabfamilias.codigofamilia, tabfamilias.nomefamilia, tabtipoprodutos.tipoproduto, modificacao From bdusercontrol.tabfamilias INNER JOIN tabtipoprodutos ON tabfamilias.idtipoproduto = tabtipoprodutos.idtipoproduto WHERE tabfamilias.idfamilia='" & idfamilia & "' and tabfamilias.idtipoproduto in (1,2) ORDER BY tabtipoprodutos.tipoproduto"
        Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
        myReader = Me.myCommand.ExecuteReader

        While myReader.Read

            FormGestaoDados.txtcodigo.Text = myReader(0)
            antigocodigo = myReader(0)
           
        End While
        FormGestaoDados.txtnomeforn.Text = antigonomef
        Me.connserver.Close()

        FormFornecedores.carregarfornecedores()

        FormGestaoDados.txtcodigo.Enabled = False
        FormGestaoDados.txtdropbox.Enabled = False
        FormGestaoDados.txtnomechagas.Enabled = False
        FormGestaoDados.txttipochagas.Enabled = False
        FormGestaoDados.txtcaminhochagas.Enabled = False
        FormGestaoDados.txtcaminhoimagemchagas.Enabled = False
        FormGestaoDados.btserchc.Enabled = False
        FormGestaoDados.btserchi.Enabled = False
        FormGestaoDados.SimpleButton3.Enabled = False
        FormGestaoDados.SimpleButton2.Select()
    End Sub
    Sub eliminarfornecedor()

        If FormFornecedores.Listfornecedor.SelectedItems.Count <> 0 Or FormManuaisTecnicos.Listmanual.SelectedItems.Count <> 0 Then

            Dim familiaeliminada As String = FormFornecedores.Listfornecedor.SelectedItems(0).Text
            
            If MsgBox("Deseja mesmo eliminar este fornecedor? ( " & familiaeliminada & " )", MsgBoxStyle.YesNo, "UserControl - Administrador") = MsgBoxResult.Yes Then

                Me.connserver = New MySqlConnection(Me.app)
                Me.connserver.Open()

                Me.comando = "SELECT idtipoproduto, caminhofornecedor, imagemfornecedor, idfamilia FROM tabfornecedores WHERE nomefornecedor ='" & familiaeliminada & "'"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                Dim myRead As MySqlDataReader = Me.myCommand.ExecuteReader

                Dim tipoproduto, caminhopdf, caminhoimagem, idfamilia

                While myRead.Read
                    tipoproduto = myRead(0)
                    caminhopdf = myRead(1)
                    caminhoimagem = myRead(2)
                    idfamilia = myRead(3)
                End While

                myRead.Close()
                Me.connserver.Close()

                'CONVERTENDO CAMINHOS 
                caminhopdf = Replace(caminhopdf, "\", "\\")
                caminhoimagem = Replace(caminhoimagem, "\", "\\")

                Me.connserver.Open()
                Me.comando = "INSERT INTO tabelimindados (idtipoproduto, codigofamilia, nomefamilia, caminhofamilia, imagemfamilia) VALUES ('" & tipoproduto & "','" & idfamilia & "','" & familiaeliminada & "','" & caminhopdf & "','" & caminhoimagem & "')"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                Dim myReader As MySqlCommand = New MySqlCommand(Me.myCommand.ExecuteNonQuery)
                Me.connserver.Close()

                Me.connserver = New MySqlConnection(Me.app)
                Me.connserver.Open()
                Me.comando = "DELETE FROM tabfornecedores WHERE nomefornecedor ='" & familiaeliminada & "' and idtipoproduto='" & tipoproduto & "'"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                myReader = New MySqlCommand(Me.myCommand.ExecuteNonQuery)
                Me.connserver.Close()

                MsgBox("O catálogo foi elimidado com sucesso! ( " & familiaeliminada & " )", MsgBoxStyle.Information, "UserControl - Administrador")
                FormFornecedores.carregarfornecedores()

            End If

        End If

    End Sub

    'Promocoes
    Sub alterarpromocoes()
        FormGestaoDados.btadicinarchagas.Text = "Alterar"

        FormGestaoDados.CheckChagas.Enabled = False
        FormGestaoDados.CheckFornecedor.Enabled = False

        FormGestaoDados.txtcodigo.Text = FormPromocoes.Listpromo.SelectedItems(0).Text
        FormGestaoDados.txtnomechagas.Text = FormPromocoes.Listpromo.SelectedItems(0).SubItems(1).Text
        FormGestaoDados.txttipochagas.SelectedItem = FormPromocoes.Listpromo.SelectedItems(0).SubItems(2).Text

        antigocodigo = FormPromocoes.Listpromo.SelectedItems(0).Text
        antigonome = FormPromocoes.Listpromo.SelectedItems(0).SubItems(1).Text
        antigotipo = FormPromocoes.Listpromo.SelectedItems(0).SubItems(2).Text

        Me.connserver = New MySqlConnection(Me.app)
        Me.connserver.Open()

        Me.comando = "SELECT caminhofamilia, imagemfamilia, idfamilia FROM tabfamilias where codigofamilia='" & antigocodigo & "' and nomefamilia='" & antigonome & "'"
        Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
        Dim myReader As MySqlDataReader = Me.myCommand.ExecuteReader

        While myReader.Read
            FormGestaoDados.txtcaminhochagas.Text = myReader(0)
            antigocaminho = myReader(0)
            FormGestaoDados.txtcaminhoimagemchagas.Text = myReader(1)
            antigoimagem = myReader(1)
            idfamilia = myReader(2)
        End While

        Me.connserver.Close()
    End Sub
    Sub eliminarpromocoes()

        Dim codigofamilia As String = FormPromocoes.Listpromo.SelectedItems(0).Text
        Dim nomefamilia As String = FormPromocoes.Listpromo.SelectedItems(0).SubItems(1).Text

        If FormPromocoes.Listpromo.SelectedItems.Count <> 0 Then

            Dim familiaeliminada As String = codigofamilia & " - " & nomefamilia

            If MsgBox("Deseja mesmo eliminar esta promoção? ( " & familiaeliminada & " )", MsgBoxStyle.YesNo, "UserControl - Administrador") = MsgBoxResult.Yes Then

                Me.connserver = New MySqlConnection(Me.app)
                Me.connserver.Open()

                Me.comando = "SELECT idtipoproduto, caminhofamilia, imagemfamilia FROM tabfamilias WHERE codigofamilia ='" & codigofamilia & "' and nomefamilia='" & nomefamilia & "'"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                Dim myRead As MySqlDataReader = Me.myCommand.ExecuteReader

                Dim tipoproduto, caminhopdf, caminhoimagem

                While myRead.Read
                    tipoproduto = myRead(0)
                    caminhopdf = myRead(1)
                    caminhoimagem = myRead(2)
                End While

                myRead.Close()
                Me.connserver.Close()

                ' CONVERTENDO CAMINHOS 
                caminhopdf = Replace(caminhopdf, "\", "\\")
                caminhoimagem = Replace(caminhoimagem, "\", "\\")

                Me.connserver.Open()
                Me.comando = "INSERT INTO tabelimindados (idtipoproduto, codigofamilia, nomefamilia, caminhofamilia, imagemfamilia) VALUES ('" & tipoproduto & "','" & codigofamilia & "','" & nomefamilia & "','" & caminhopdf & "','" & caminhoimagem & "')"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                Dim myReader As MySqlCommand = New MySqlCommand(Me.myCommand.ExecuteNonQuery)
                Me.connserver.Close()

                Me.connserver = New MySqlConnection(Me.app)
                Me.connserver.Open()
                Me.comando = "DELETE FROM tabfamilias WHERE codigofamilia ='" & codigofamilia & "' and nomefamilia='" & nomefamilia & "'"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                myReader = New MySqlCommand(Me.myCommand.ExecuteNonQuery)
                Me.connserver.Close()

                MsgBox("A promoção foi elimidado com sucesso! ( " & familiaeliminada & " )", MsgBoxStyle.Information, "UserControl - Administrador")
                FormPromocoes.carregarpromo()

            End If
        End If

    End Sub
    
    'Manuais Técnicos
    Sub alterarmanuais()

        FormGestaoDados.btadicionar.Text = "Alterar"

        FormGestaoDados.CheckChagas.Enabled = False
        FormGestaoDados.CheckFornecedor.Enabled = False
        FormGestaoDados.CheckFornecedor.Checked = True

        antigonomef = FormManuaisTecnicos.Listmanual.SelectedItems(0).Text
        antigotipof = FormManuaisTecnicos.Listmanual.SelectedItems(0).SubItems(1).Text

        FormGestaoDados.txtnomeforn.Text = FormManuaisTecnicos.Listmanual.SelectedItems(0).Text
        FormGestaoDados.txttipofornecedor.SelectedItem = antigotipof
        FormGestaoDados.txtmodificacao.Text = FormManuaisTecnicos.Listmanual.SelectedItems(0).SubItems(2).Text

        Me.connserver = New MySqlConnection(Me.app)
        Me.connserver.Open()

        Me.comando = "SELECT caminhofornecedor, imagemfornecedor, paginaweb, idfamilia, idtipoproduto FROM tabfornecedores where nomefornecedor='" & antigonomef & "'"
        Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
        Dim myReader As MySqlDataReader = Me.myCommand.ExecuteReader

        While myReader.Read

            FormGestaoDados.txtcaminhoforn.Text = myReader(0)
            antigocaminhof = myReader(0)
            FormGestaoDados.txtimagemforn.Text = myReader(1)
            antigoimagemf = myReader(1)
            FormGestaoDados.txtwebforn.Text = myReader(2)
            antigoweb = myReader(2)
            idfamilia = myReader(3)
            antigoidtipo = myReader(4)

        End While

        Me.connserver.Close()

        Me.connserver = New MySqlConnection(Me.app)
        Me.connserver.Open()

        Me.comando = "SELECT caminhofornecedor, imagemfornecedor, paginaweb, idfamilia FROM tabfornecedores where nomefornecedor='" & antigonomef & "' and idfamilia='" & idfamilia & "'"
        Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
        myReader = Me.myCommand.ExecuteReader

        While myReader.Read

            FormGestaoDados.txtcaminhoforn.Text = myReader(0)
            antigocaminhof = myReader(0)
            FormGestaoDados.txtimagemforn.Text = myReader(1)
            antigoimagemf = myReader(1)
            FormGestaoDados.txtwebforn.Text = myReader(2)
            antigoweb = myReader(2)
            idfamilia = myReader(3)
        End While

        Me.connserver.Close()

        Me.connserver = New MySqlConnection(Me.app)
        Me.connserver.Open()

        Me.comando = "SELECT tabfamilias.codigofamilia, tabfamilias.nomefamilia, tabtipoprodutos.tipoproduto, modificacao From bdusercontrol.tabfamilias INNER JOIN tabtipoprodutos ON tabfamilias.idtipoproduto = tabtipoprodutos.idtipoproduto WHERE tabfamilias.idfamilia='" & idfamilia & "' and tabfamilias.idtipoproduto in (1,2) ORDER BY tabtipoprodutos.tipoproduto"
        Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
        myReader = Me.myCommand.ExecuteReader

        While myReader.Read

            FormGestaoDados.txtcodigo.Text = myReader(0)
            antigocodigo = myReader(0)

        End While
        FormGestaoDados.txtnomeforn.Text = antigonomef
        Me.connserver.Close()

        ' FormFornecedores.carregarfornecedores()

        FormGestaoDados.txtcodigo.Enabled = False
        FormGestaoDados.txtdropbox.Enabled = False
        FormGestaoDados.txtnomechagas.Enabled = False
        FormGestaoDados.txttipochagas.Enabled = False
        FormGestaoDados.txtcaminhochagas.Enabled = False
        FormGestaoDados.txtcaminhoimagemchagas.Enabled = False
        FormGestaoDados.btserchc.Enabled = False
        FormGestaoDados.btserchi.Enabled = False
        FormGestaoDados.SimpleButton3.Enabled = False
        FormGestaoDados.SimpleButton2.Select()
        FormGestaoDados.txttipofornecedor.SelectedIndex = 1
    End Sub
    Sub eliminarmanuais()

        If FormManuaisTecnicos.Listmanual.SelectedItems.Count <> 0 Then

            Dim familiaeliminada As String = FormManuaisTecnicos.Listmanual.SelectedItems(0).Text()

            If MsgBox("Deseja mesmo eliminar este manual tecnico? ( " & familiaeliminada & " )", MsgBoxStyle.YesNo, "UserControl - Administrador") = MsgBoxResult.Yes Then

                Me.connserver = New MySqlConnection(Me.app)
                Me.connserver.Open()

                Me.comando = "SELECT idtipoproduto, caminhofornecedor, imagemfornecedor, idfamilia FROM tabfornecedores WHERE nomefornecedor ='" & familiaeliminada & "'"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                Dim myRead As MySqlDataReader = Me.myCommand.ExecuteReader

                Dim tipoproduto, caminhopdf, caminhoimagem, idfamilia

                While myRead.Read
                    tipoproduto = myRead(0)
                    caminhopdf = myRead(1)
                    caminhoimagem = myRead(2)
                    idfamilia = myRead(3)
                End While

                myRead.Close()
                Me.connserver.Close()

                'CONVERTENDO CAMINHOS 
                caminhopdf = Replace(caminhopdf, "\", "\\")
                caminhoimagem = Replace(caminhoimagem, "\", "\\")

                Me.connserver.Open()
                Me.comando = "INSERT INTO tabelimindados (idtipoproduto, codigofamilia, nomefamilia, caminhofamilia, imagemfamilia) VALUES ('" & tipoproduto & "','" & idfamilia & "','" & familiaeliminada & "','" & caminhopdf & "','" & caminhoimagem & "')"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                Dim myReader As MySqlCommand = New MySqlCommand(Me.myCommand.ExecuteNonQuery)
                Me.connserver.Close()

                Me.connserver = New MySqlConnection(Me.app)
                Me.connserver.Open()
                Me.comando = "DELETE FROM tabfornecedores WHERE nomefornecedor ='" & familiaeliminada & "' and idtipoproduto='" & tipoproduto & "'"
                Me.myCommand = New MySqlCommand(Me.comando, Me.connserver)
                myReader = New MySqlCommand(Me.myCommand.ExecuteNonQuery)
                Me.connserver.Close()

                MsgBox("O catálogo foi elimidado com sucesso! ( " & familiaeliminada & " )", MsgBoxStyle.Information, "UserControl - Administrador")
                FormManuaisTecnicos.carregarmanuais()

            End If

        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        fecharform()
        FormAdministracao.MdiParent = Me
        FormAdministracao.Location = New Point(0, 0)
        FormAdministracao.Show()

        If Me.Height > 725 And Me.Width > 1010 Then
            FormAdministracao.Size = New Size(widthhome, heighthome)
        ElseIf Me.Height = 725 And Me.Width = 1010 Then
            FormAdministracao.Size = New Size(763, 695)
        End If

        Painelfundo.SendToBack()
    End Sub

    Private Sub btadmin_Click(sender As Object, e As EventArgs) Handles btadmin.Click
        fecharform()
        FormEstatistica.MdiParent = Me
        FormEstatistica.Location = New Point(0, 0)
        FormEstatistica.Show()

        If Me.Height > 725 And Me.Width > 1010 Then
            FormEstatistica.Size = New Size(widthhome, heighthome)
        ElseIf Me.Height = 725 And Me.Width = 1010 Then
            FormEstatistica.Size = New Size(763, 695)
        End If
        FormEstatistica.btactualizacao.PerformClick()

        Painelfundo.SendToBack()
        btadmin.BackColor = Color.DarkSeaGreen
    End Sub
End Class
