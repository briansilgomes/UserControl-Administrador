Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class FormGestaoDados

    Private Sub FormGestaoDados_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FormHome.btadicionar.BackColor = Color.Transparent
        FormHome.btalterar.BackColor = Color.Transparent
        FormHome.bteliminar.BackColor = Color.Transparent
    End Sub
    Private Sub FormGestaoDados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        carregartiposprodutos()

        txtmodificacao.BackColor = Color.White
        txtmodificacao.ForeColor = Color.Black
        txtmodificacao.Enabled = False

        If CheckChagas.Checked = True Then
            Panel2.Visible = False
        End If
    End Sub
    Private Sub CheckEdit1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckFornecedor.CheckedChanged
        If CheckFornecedor.Checked = True Then
            CheckChagas.Checked = False
            Panel2.Visible = True
            btadicinarchagas.Visible = False
        End If
    End Sub
    Private Sub CheckEdit2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckChagas.CheckedChanged
        If CheckChagas.Checked = True Then
            CheckFornecedor.Checked = False
            Panel2.Visible = False
            btadicinarchagas.Visible = True
            chekactualizacao.Visible = True
        End If

    End Sub
   
    Sub carregartiposprodutos()

        txttipochagas.Items.Clear()
        txttipofornecedor.Items.Clear()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT tipoproduto FROM tabtipoprodutos where idtipoproduto in (1,2,3)"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            txttipochagas.Items.Add(myReader(0))
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT tipoproduto FROM tabtipoprodutos where idtipoproduto in (4,5)"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            txttipofornecedor.Items.Add(myReader(0))
        End While

        FormHome.connserver.Close()

    End Sub

    Private Sub btserchc_Click(sender As System.Object, e As System.EventArgs) Handles btserchc.Click
        Try

            If txttipochagas.Text = "Promoções" Then
                OpenFileDialog1.InitialDirectory = My.Settings.unidade & "\Touch\Promoções"
                OpenFileDialog1.Title = "Promoções"

            ElseIf txttipochagas.Text = "Produtos Siderúrgicos" Then
                OpenFileDialog1.InitialDirectory = My.Settings.unidade & "\TABELAS FERRO PDF"
                OpenFileDialog1.Title = "Produtos Siderúrgicos"

            ElseIf txttipochagas.Text = "Máquinas e Ferramentas" Then
                OpenFileDialog1.InitialDirectory = My.Settings.unidade & "\TABELAS LOJA PDF"
                OpenFileDialog1.Title = "Máquinas e Ferramentas"

            End If

            OpenFileDialog1.Filter = "Text files (*.pdf)|*.pdf"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim stFilePathAndName As String = OpenFileDialog1.FileName
                txtcaminhochagas.Text = stFilePathAndName.Remove(0, 2)
            End If

        Catch ex As Exception
            MsgBox("A unidade de rede pode não estar ligada correctamente!", MsgBoxStyle.Information, "UserControl - Administrador")
        End Try

    End Sub

    Private Sub btserchi_Click(sender As System.Object, e As System.EventArgs) Handles btserchi.Click

        Try

            If txttipochagas.Text = "Promoções" Then
                OpenFileDialog1.InitialDirectory = My.Settings.unidade & "\Touch\Promoções"
                OpenFileDialog1.Title = "Promoções"

            ElseIf txttipochagas.Text = "Produtos Siderúrgicos" Then
                OpenFileDialog1.InitialDirectory = My.Settings.unidade & "\Touch\IMG-TAB"
                OpenFileDialog1.Title = "Produtos Siderúrgicos"

            ElseIf txttipochagas.Text = "Máquinas e Ferramentas" Then
                OpenFileDialog1.InitialDirectory = My.Settings.unidade & "\Touch\IMG-TAB"
                OpenFileDialog1.Title = "Máquinas e Ferramentas"

            End If

            OpenFileDialog1.Filter = "Text files (*.jpg)|*.jpg"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim stFilePathAndName As String = OpenFileDialog1.FileName

                txtcaminhoimagemchagas.Text = stFilePathAndName.Remove(0, 2)
            End If

        Catch ex As Exception
            MsgBox("A unidade de rede pode não estar ligada correctamente!", MsgBoxStyle.Exclamation, "UserControl - Administrador")
        End Try

    End Sub

    Private Sub btadicinarchagas_Click(sender As System.Object, e As System.EventArgs) Handles btadicinarchagas.Click

        If txtcodigo.Text = Nothing Or txtnomechagas.Text = Nothing Or txttipochagas.Text = Nothing Or txtcaminhochagas.Text = Nothing Or txtcaminhoimagemchagas.Text = Nothing Then
            MsgBox("Deverá preencher todos os campos obrigatórios!", MsgBoxStyle.Exclamation, "UserControl - Administrador")
            Exit Sub

        ElseIf FormHome.formactivo = "Insert" Then

            ' VALIDAR O NOVO CATÁLOGO
            validacao()
            validacaodecaminho()
            verificarapagados()
            If confimacao = False Then
                MsgBox("Este catálogo já encontra-se em utilização! ( " & Trim(txtcodigo.Text) & " - " & Trim(txtnomechagas.Text) & " )", MsgBoxStyle.Exclamation, "UserControl - Administrador")
                Exit Sub
            ElseIf ficheiroexiste = False Then
                Exit Sub
            End If

            ' CONVERTENDO CAMINHOS 
            Dim caminhopdf As String = Replace(txtcaminhochagas.Text, "\", "\\")
            Dim caminhoimagem As String = Replace(txtcaminhoimagemchagas.Text, "\", "\\")

            'SABER O ID DO TIPO DE CATÁLOGO EM QUESTÃO
            tipodecatalogo()

            'HORA MODIFACACAO
            horanoservidor()

            'ADICIONAR NA BASE DE DADOS
            FormHome.connserver = New MySqlConnection(FormHome.app)
            FormHome.connserver.Open()

            FormHome.comando = "INSERT INTO tabfamilias (idtipoproduto, codigofamilia, nomefamilia, caminhofamilia, imagemfamilia, modificacao, dropboxfamilia) VALUES ('" & _
                               tipocatalogo & "','" & Trim(txtcodigo.Text) & "','" & Trim(txtnomechagas.Text) & "','" & Trim(caminhopdf) & "','" & Trim(caminhoimagem) & "','" & horaservidor & "','" & Trim(txtdropbox.Text) & "')"
            FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
            Dim myReader As MySqlCommand = New MySqlCommand(FormHome.myCommand.ExecuteNonQuery)
            FormHome.connserver.Close()




            MsgBox("O catálogo foi inserido com sucesso! ( " & Trim(txtcodigo.Text) & " - " & Trim(txtnomechagas.Text) & " )", MsgBoxStyle.Information, "UserControl - Administrador")
            limpeza()

            If tipocatalogo = "1" Or tipocatalogo = "2" Then
                FormHome.btfamilias.PerformClick()
            ElseIf tipocatalogo = "3" Then
                FormHome.btpromo.PerformClick()
            End If


        ElseIf FormHome.formactivo = "Update" Then

            ' VALIDAR ALTERAÇÂO
            validacao()
            validacaodecaminho()
            verificarapagados()
            If confimacao = False Then
                MsgBox("Este catálogo já encontra-se em utilização! ( " & Trim(txtcodigo.Text) & " - " & Trim(txtnomechagas.Text) & " )", MsgBoxStyle.Exclamation, "UserControl - Administrador")
                Exit Sub
            ElseIf ficheiroexiste = False Then
                Exit Sub
            End If

            ' CONVERTENDO CAMINHOS 
            Dim caminhopdf As String = Replace(txtcaminhochagas.Text, "\", "\\")
            Dim caminhoimagem As String = Replace(txtcaminhoimagemchagas.Text, "\", "\\")

            'SABER O ID DO TIPO DE CATÁLOGO EM QUESTÃO
            tipodecatalogo()

            'HORA MODIFACACAO
            horanoservidor()

            'ADICIONAR NA BASE DE DADOS
            FormHome.connserver = New MySqlConnection(FormHome.app)
            FormHome.connserver.Open()
            If Checkactualizacaochagas.Checked = True Then
                FormHome.comando = "UPDATE tabfamilias SET idtipoproduto='" & tipocatalogo & "', codigofamilia='" & Trim(txtcodigo.Text) & "', nomefamilia='" & Trim(txtnomechagas.Text) & "', caminhofamilia='" & Trim(caminhopdf) & "', imagemfamilia='" & Trim(caminhoimagem) & "', modificacao='" & horaservidor & "', dropboxfamilia='" & txtdropbox.Text & "' WHERE idfamilia=" & FormHome.idfamilia
            ElseIf Checkactualizacaochagas.Checked = False Then
                FormHome.comando = "UPDATE tabfamilias SET idtipoproduto='" & tipocatalogo & "', codigofamilia='" & Trim(txtcodigo.Text) & "', nomefamilia='" & Trim(txtnomechagas.Text) & "', caminhofamilia='" & Trim(caminhopdf) & "', imagemfamilia='" & Trim(caminhoimagem) & "', dropboxfamilia='" & txtdropbox.Text & "' WHERE idfamilia=" & FormHome.idfamilia
            End If
            FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
            Dim myReader As MySqlCommand = New MySqlCommand(FormHome.myCommand.ExecuteNonQuery)
            FormHome.connserver.Close()

            MsgBox("O catálogo foi alterado com sucesso!", MsgBoxStyle.Information, "UserControl - Administrador")

            dadosmail1 = horaservidor
            dadosmail2 = "UPDATE tabfamilias ( " & Trim(txtcodigo.Text) & " - " & Trim(txtnomechagas.Text) & " )"
            enviaremail()

            limpeza()

            If tipocatalogo = "1" Or tipocatalogo = "2" Then
                FormHome.btfamilias.PerformClick()
            ElseIf tipocatalogo = "3" Then
                FormHome.btpromo.PerformClick()
            End If

        End If

    End Sub

    Dim confimacao, ficheiroexiste As Boolean
    Public tipocatalogo, horaservidor, idfamilia As String
    Dim dadosmail1, dadosmail2 As String

    Sub validacaodecaminho()

        If CheckChagas.Checked = True Then

            If My.Computer.FileSystem.FileExists(My.Settings.unidade & Trim(txtcaminhochagas.Text)) = True And My.Computer.FileSystem.FileExists(My.Settings.unidade & Trim(txtcaminhoimagemchagas.Text)) = True Then
                ficheiroexiste = True
                Exit Sub
            Else
                ficheiroexiste = False
                MsgBox("Os directorios encontram-se incorrectos! Certifique-os !", MsgBoxStyle.Exclamation, "UserControl - Administrador")
            End If

        ElseIf CheckFornecedor.Checked = True Then

            If My.Computer.FileSystem.FileExists(My.Settings.unidade & Trim(txtcaminhoforn.Text)) = True And My.Computer.FileSystem.FileExists(My.Settings.unidade & Trim(txtimagemforn.Text)) = True Then
                ficheiroexiste = True
                Exit Sub
            Else
                ficheiroexiste = False
                MsgBox("Os directorios encontram-se incorrectos! Certifique-os !", MsgBoxStyle.Exclamation, "UserControl - Administrador")
            End If

        End If

    End Sub
    Sub validacao()

        Dim resultado, resultado1 As String

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        If CheckChagas.Checked = True Then
            FormHome.comando = "SELECT * FROM tabfamilias WHERE codigofamilia='" & Trim(txtcodigo.Text) & "' and nomefamilia='" & Trim(txtnomechagas.Text) & "'"
        ElseIf CheckFornecedor.Checked = True Then
            FormHome.comando = "SELECT idfamilia, nomefornecedor FROM tabfornecedores WHERE idfamilia='" & idfamilia & "' and nomefornecedor='" & Trim(txtnomeforn.Text) & "'"
        End If
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            resultado = myReader(0)
            resultado1 = myReader(1)
        End While

        FormHome.connserver.Close()


        If FormHome.formactivo = "Insert" Then

            If resultado = Nothing Then
                confimacao = True
            Else
                confimacao = False
            End If

        ElseIf FormHome.formactivo = "Update" Then


            If CheckChagas.Checked = True Then

                If Trim(txtcodigo.Text) <> FormHome.antigocodigo Or Trim(txtnomechagas.Text) <> FormHome.antigonome Or Trim(txttipochagas.Text) <> FormHome.antigotipo Then

                    If resultado = Nothing Then
                        confimacao = True
                    Else
                        confimacao = False
                    End If

                Else
                    confimacao = True
                End If

            ElseIf CheckFornecedor.Checked = True Then
                Dim antigo As String = FormHome.antigonomef

                If Trim(txtnomeforn.Text) <> FormHome.antigonomef Or Trim(txtcaminhoforn.Text) <> FormHome.antigocaminhof Or Trim(txtimagemforn.Text) <> FormHome.antigoimagemf Or Trim(txtwebforn.Text) <> FormHome.antigoweb Then
                    If idfamilia = resultado And resultado1 = FormHome.antigonomef Then
                        confimacao = True
                    ElseIf resultado = Nothing And resultado1 = Nothing Then
                        confimacao = True
                    Else
                        confimacao = False
                    End If
                Else
                    confimacao = True
                End If

            End If






        End If

    End Sub
    Sub verificarapagados()

        ' Verifica se a falia em questão está na lista de eliminados

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        If CheckChagas.Checked = True Then
            FormHome.comando = "SELECT codigofamilia, nomefamilia FROM tabelimindados WHERE codigofamilia='" & Trim(txtcodigo.Text) & "' and nomefamilia='" & Trim(txtnomechagas.Text) & "'"
        ElseIf CheckFornecedor.Checked = True Then
            FormHome.comando = "SELECT * FROM tabelimindados WHERE codigofamilia='" & Trim(txtcodigo.Text) & "' and nomefamilia='" & Trim(txtnomechagas.Text) & "' and idtipoproduto='" & tipocatalogo & "'"
        End If

        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader
        Dim existe As Boolean = False
        Dim codigo, nome As String
        While myReader.Read
            codigo = myReader(0)
            nome = myReader(1)
            existe = True
        End While
        myReader.Close()
        FormHome.connserver.Close()

        If existe = True Then
            FormHome.comando = "DELETE FROM tabelimindados WHERE codigofamilia ='" & codigo & "' and nomefamilia='" & nome & "'"
            FormHome.connserver = New MySqlConnection(FormHome.app)

            FormHome.connserver.Open()
            FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
            Dim myReader1 As MySqlCommand = New MySqlCommand(FormHome.myCommand.ExecuteNonQuery)
            FormHome.connserver.Close()
        End If


    End Sub

    Sub tipodecatalogo()


        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        If CheckChagas.Checked = True Then
            FormHome.comando = "SELECT idtipoproduto FROM tabtipoprodutos WHERE tipoproduto='" & txttipochagas.Text & "'"
        ElseIf CheckFornecedor.Checked = True Then
            FormHome.comando = "SELECT idtipoproduto FROM tabtipoprodutos WHERE tipoproduto='" & txttipofornecedor.Text & "'"
        End If

        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            tipocatalogo = myReader(0)
        End While

        FormHome.connserver.Close()
    End Sub
    Sub tipocatalogofornecedor()
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT idtipoproduto FROM tabtipoprodutos WHERE tipoproduto='" & txttipofornecedor.Text & "'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            tipocatalogo = myReader(0)
        End While

        FormHome.connserver.Close()
    End Sub
    Sub horanoservidor()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i:%s') as perdate"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            horaservidor = myReader(0)
        End While

        FormHome.connserver.Close()

    End Sub
    Sub limpeza()
        txtcodigo.Text = Nothing
        txtnomechagas.Text = Nothing
        txttipochagas.SelectedItem = Nothing
        txtcaminhochagas.Text = Nothing
        txtcaminhoimagemchagas.Text = Nothing
        txtdropbox.Text = Nothing
        'FORNECEDORES
        txtnomeforn.Text = Nothing
        txtcaminhoforn.Text = Nothing
        txtimagemforn.Text = Nothing
        txttipofornecedor.SelectedItem = Nothing
        txtwebforn.Text = Nothing
        txtmodificacao.Text = Nothing
    End Sub

    Sub enviaremail()

        ' cria uma instância do objeto MailMessage

        Dim mMailMessage As New MailMessage()


        ' Define o endereço do remetente

        mMailMessage.From = New MailAddress("usercontrol@chagas.pt")


        ' Define o destinario da mensagem

        mMailMessage.To.Add(New MailAddress("brian@chagas.pt"))

        ' Define o assunto 

        mMailMessage.Subject = "UserControl - Actulização ( " & dadosmail1 & " )"

        ' Define o corpo da mensagem

        mMailMessage.Body = dadosmail2

        ' Define o formato do email como HTML

        mMailMessage.IsBodyHtml = True

        ' Define a prioridade da mensagem como normal

        mMailMessage.Priority = MailPriority.Normal


        ' Cria uma instância de SmtpClient - Nota - Define qual o host a ser usado para envio 

        ' de mensagens, no local de smtp.server.com use o nome do SEU servidor

        Dim mSmtpClient As New SmtpClient("192.128.32.50")

        ' Envia o email

        ' mSmtpClient.Send(mMailMessage)

    End Sub

    Private Sub txtcodigo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcodigo.TextChanged

        Dim tipoproduto As String

        If CheckFornecedor.Checked = True Then

            If txtcodigo.Text = Nothing Then
                limpeza()
            End If

            'PREENCHEER CAMPOS DA FAMILIA
            FormHome.connserver = New MySqlConnection(FormHome.app)
            FormHome.connserver.Open()

            FormHome.comando = "SELECT nomefamilia, caminhofamilia, imagemfamilia, idtipoproduto, idfamilia, dropboxfamilia FROM tabfamilias where codigofamilia='" & Trim(txtcodigo.Text) & "'"
            FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
            Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

            While myReader.Read
                txtnomechagas.Text = myReader(0)
                txtcaminhochagas.Text = myReader(1)
                txtcaminhoimagemchagas.Text = myReader(2)
                txtdropbox.Text = myReader(5)
                tipoproduto = myReader(3)
                idfamilia = myReader(4)
            End While

            'TIPO DE CATÁLOGOO
            FormHome.connserver.Close()

            FormHome.connserver = New MySqlConnection(FormHome.app)
            FormHome.connserver.Open()

            FormHome.comando = "SELECT tipoproduto FROM tabtipoprodutos where idtipoproduto ='" & tipoproduto & "'"
            FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
            myReader = FormHome.myCommand.ExecuteReader

            While myReader.Read
                tipocatalogo = myReader(0)
            End While

            Me.carregartiposprodutos()

            txttipochagas.SelectedItem = tipocatalogo
            FormHome.connserver.Close()

            'TOTAL CATÁLOGOS ASSOCIADOS
            FormHome.connserver = New MySqlConnection(FormHome.app)
            FormHome.connserver.Open()

            FormHome.comando = "SELECT count(*) FROM tabfornecedores where idfamilia ='" & idfamilia & "'"
            FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
            myReader = FormHome.myCommand.ExecuteReader

            While myReader.Read
                Label6.Text = "* Esta família tem " & myReader(0) & " catálogo(s) associado(s)."
            End While

            FormHome.connserver.Close()

            If txtnomechagas.Text <> Nothing Then
                txtnomeforn.Text = Trim(txtcodigo.Text) & " - "
            End If


            'VERIFICAR SE A FAMILIA EXISTE
            If idfamilia = Nothing And txtcodigo.TextLength >= 8 Then
                MsgBox("O código de família inserido não existe.", MsgBoxStyle.Exclamation, "UserControl - Administrador")
                txtcodigo.Text = Nothing
                txtcodigo.Text = Nothing
                txtcodigo.Select()
                Exit Sub

            End If
        End If

    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Try

            OpenFileDialog1.InitialDirectory = My.Settings.unidade & "\Catálogos Fornecedores"
            OpenFileDialog1.Title = "Catálogo de Fornecedores"

            OpenFileDialog1.Filter = "Text files (*.pdf)|*.pdf"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim stFilePathAndName As String = OpenFileDialog1.FileName
                txtcaminhoforn.Text = stFilePathAndName.Remove(0, 2)
            End If

        Catch ex As Exception
            MsgBox("A unidade de rede pode não estar ligada correctamente!", MsgBoxStyle.Information, "UserControl - Administrador")
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Try


            OpenFileDialog1.InitialDirectory = My.Settings.unidade & "\Touch\TAB- Fornecedores"
            OpenFileDialog1.Title = "Imagem Catálogo Fornecedor"

            OpenFileDialog1.Filter = "Text files (*.jpg)|*.jpg"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim stFilePathAndName As String = OpenFileDialog1.FileName

                txtimagemforn.Text = stFilePathAndName.Remove(0, 2)
            End If

        Catch ex As Exception
            MsgBox("A unidade de rede pode não estar ligada correctamente!", MsgBoxStyle.Exclamation, "UserControl - Administrador")
        End Try
    End Sub

    Private Sub txtcaminhoforn_Click(sender As Object, e As System.EventArgs) Handles txtcaminhoforn.Click
        SimpleButton2.PerformClick()
    End Sub

    Private Sub txtimagemforn_Click(sender As Object, e As System.EventArgs) Handles txtimagemforn.Click
        SimpleButton1.PerformClick()
    End Sub

    Private Sub btadicionar_Click(sender As System.Object, e As System.EventArgs) Handles btadicionar.Click

        If txtnomeforn.Text = Nothing Or txtnomeforn.TextLength < 7 Or txttipofornecedor.Text = Nothing Then
            MsgBox("Deverá preencher todos os campos obrigatórios!", MsgBoxStyle.Exclamation, "UserControl - Administrador")
            Exit Sub

        ElseIf FormHome.formactivo = "Insert" Then

            ' VALIDAR O NOVO CATÁLOGO
            validacao()
            validacaodecaminho()
            If confimacao = False Then
                MsgBox("Este catálogo já encontra-se em utilização! ( " & Trim(txtnomeforn.Text) & " )", MsgBoxStyle.Exclamation, "UserControl - Administrador")
                Exit Sub
            ElseIf ficheiroexiste = False Then
                Exit Sub
            End If

            ' CONVERTENDO CAMINHOS 
            Dim caminhopdf As String = Replace(txtcaminhoforn.Text, "\", "\\")
            Dim caminhoimagem As String = Replace(txtimagemforn.Text, "\", "\\")

            'BUSCAR ID DO TIPO DE FORNECEDOR
            tipocatalogofornecedor()

            'HORA MODIFACACAO
            horanoservidor()

            FormHome.connserver = New MySqlConnection(FormHome.app)
            FormHome.connserver.Open()


            FormHome.comando = "INSERT INTO tabfornecedores (idfamilia, nomefornecedor, caminhofornecedor, imagemfornecedor, modificacao, idtipoproduto) VALUES (" & _
                idfamilia & ",'" & Trim(txtnomeforn.Text) & "','" & Trim(caminhopdf) & "','" & Trim(caminhoimagem) & "','" & horaservidor & "','" & tipocatalogo & "')"
            FormHome.comando = "INSERT INTO tabfornecedores (idfamilia, nomefornecedor, caminhofornecedor, imagemfornecedor, modificacao, idtipoproduto) VALUES (" & _
                      idfamilia & ",'" & Trim(txtnomeforn.Text) & "','" & Trim(caminhopdf) & "','" & Trim(caminhoimagem) & "','" & horaservidor & "','" & tipocatalogo & "')"
            FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
            Dim myReader As MySqlCommand = New MySqlCommand(FormHome.myCommand.ExecuteNonQuery)
            FormHome.connserver.Close()

            MsgBox("O catálogo foi inserido com sucesso!", MsgBoxStyle.Information, "UserControl - Administrador")
            limpeza()

            If tipocatalogo = "4" Then
                FormHome.btfornecedor.PerformClick()
            ElseIf tipocatalogo = "5" Then
                FormHome.btmanuais.PerformClick()
            End If

        ElseIf FormHome.formactivo = "Update" Then

            ' VALIDAR ALTERAÇÂO
            validacao()
            validacaodecaminho()
            If confimacao = False Then
                MsgBox("Este catálogo já encontra-se em vigor! (código e nome)", MsgBoxStyle.Exclamation, "UserControl - Administrador")
                Exit Sub
            ElseIf ficheiroexiste = False Then
                Exit Sub
            End If

            ' CONVERTENDO CAMINHOS 
            Dim caminhopdf As String = Replace(txtcaminhoforn.Text, "\", "\\")
            Dim caminhoimagem As String = Replace(txtimagemforn.Text, "\", "\\")

            'SABER O ID DO TIPO DE CATÁLOGO EM QUESTÃO
            tipodecatalogo()

            'HORA MODIFACACAO
            horanoservidor()

            'ADICIONAR NA BASE DE DADOS
            FormHome.connserver.Open()
            If chekactualizacao.Checked = True Then
                FormHome.comando = "UPDATE tabfornecedores SET idtipoproduto='" & tipocatalogo & "', idfamilia='" & idfamilia & "', nomefornecedor='" & Trim(txtnomeforn.Text) & "', caminhofornecedor='" & Trim(caminhopdf) & "', imagemfornecedor='" & Trim(caminhoimagem) & "', modificacao='" & horaservidor & "', paginaweb='" & Trim(txtwebforn.Text) & "' WHERE idfamilia='" & FormHome.idfamilia & "' and nomefornecedor='" & FormHome.antigonomef & "'"
            ElseIf chekactualizacao.Checked = False Then
                FormHome.comando = "UPDATE tabfornecedores SET idtipoproduto='" & tipocatalogo & "', idfamilia='" & idfamilia & "', nomefornecedor='" & Trim(txtnomeforn.Text) & "', caminhofornecedor='" & Trim(caminhopdf) & "', imagemfornecedor='" & Trim(caminhoimagem) & "', paginaweb='" & Trim(txtwebforn.Text) & "' WHERE idfamilia='" & FormHome.idfamilia & "' and nomefornecedor='" & FormHome.antigonomef & "'"
            End If
            Dim comando As String = FormHome.comando
            FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
            Dim myReader As MySqlCommand = New MySqlCommand(FormHome.myCommand.ExecuteNonQuery)
            FormHome.connserver.Close()

            MsgBox("O catálogo foi alterado com sucesso!", MsgBoxStyle.Information, "UserControl - Administrador")

            dadosmail1 = horaservidor
            dadosmail2 = "UPDATE tabfornecedor ( " & Trim(txtcodigo.Text) & " - " & Trim(txtnomechagas.Text) & " )"
            'enviaremail()

            limpeza()
            If tipocatalogo = "4" Then
                FormHome.btfornecedor.PerformClick()
            ElseIf tipocatalogo = "5" Then
                FormHome.btmanuais.PerformClick()
            End If

        End If

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Process.Start(txtdropbox.Text)
    End Sub
End Class