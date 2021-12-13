Imports MySql.Data.MySqlClient
Public Class FormEstatistica

    Private Sub FormEstatistica_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FormHome.btadmin.BackColor = Color.Transparent
    End Sub

    Private Sub FormEstatistica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormHome.formactivo = "Estatistica"
    End Sub

    Private Sub btactualizacao_Click(sender As Object, e As EventArgs)

        Chart1.Visible = False
        Listactualizacao.Visible = True
        Listactualizacao.BringToFront()

        Listactualizacao.Items.Clear()
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT utilizadoractualizacao, catalogoactualizacao, dataactualizacao, statusactualizacao From tabactualizacao WHERE statusactualizacao='Correcto' or statusactualizacao='Corrigido' ORDER BY dataactualizacao DESC LIMIT 200"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        Dim cont As Integer = 0
        While myReader.Read
            Listactualizacao.Items.Add(myReader(0))
            Listactualizacao.Items(cont).SubItems.Add(myReader(1).ToString)
            Listactualizacao.Items(cont).SubItems.Add(myReader(2).ToString)
            Listactualizacao.Items(cont).SubItems.Add(myReader(3).ToString)
            cont = cont + 1
        End While

        FormHome.connserver.Close()
    End Sub

    Dim countclick As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btactualizacao.Click
        Chart1.Visible = False
        Listactualizacao.Visible = True
        Listactualizacao.BringToFront()

        Listactualizacao.Items.Clear()
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT utilizadoractualizacao, catalogoactualizacao, dataactualizacao, statusactualizacao From tabactualizacao WHERE statusactualizacao='Correcto' or statusactualizacao='Corrigido' ORDER BY dataactualizacao DESC LIMIT 200"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        Dim cont As Integer = 0
        While myReader.Read
            Listactualizacao.Items.Add(myReader(0))
            Listactualizacao.Items(cont).SubItems.Add(myReader(1).ToString)
            Listactualizacao.Items(cont).SubItems.Add(myReader(2).ToString)
            Listactualizacao.Items(cont).SubItems.Add(myReader(3).ToString)
            cont = cont + 1
        End While

        FormHome.connserver.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btuso.Click
        Listactualizacao.Visible = False
        Chart1.Visible = True
        Chart1.BringToFront()

        If countclick = 1 Then
            Exit Sub
        End If
        countclick = 1


        Dim totalvisitasmaquinas, totalvisitassiderurgicos, totalvisitasfornecedores As Integer

        'ARMAZÉM 01
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM01-Touch01-ARM01' and idtipofamilia in (1) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasmaquinas = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM01-Touch01-ARM01' and idtipofamilia in (2) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitassiderurgicos = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM01-Touch01-ARM01' and idtipofamilia in (4,5) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasfornecedores = myReader(0)
        End While

        FormHome.connserver.Close()

        Chart1.Series("Máquinas e Ferramentas").Points.AddXY("Armazém 01", totalvisitasmaquinas)
        Chart1.Series("Produtos Siderúrgicos").Points.AddXY("Armazém 01", totalvisitassiderurgicos)
        Chart1.Series("Fornecedores").Points.AddXY("Armazém 01", totalvisitasfornecedores)



        'ARMAZÉM 02
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM02-Touch01-ARM02' and idtipofamilia in (1) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasmaquinas = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM02-Touch01-ARM02' and idtipofamilia in (2) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitassiderurgicos = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM02-Touch01-ARM02' and idtipofamilia in (4,5) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasfornecedores = myReader(0)
        End While

        FormHome.connserver.Close()

        Chart1.Series("Máquinas e Ferramentas").Points.AddXY("Armazém 02", totalvisitasmaquinas)
        Chart1.Series("Produtos Siderúrgicos").Points.AddXY("Armazém 02", totalvisitassiderurgicos)
        Chart1.Series("Fornecedores").Points.AddXY("Armazém 02", totalvisitasfornecedores)


        'ARMAZÉM 06
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM06-Touch01-ARM06' and idtipofamilia in (1) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasmaquinas = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM06-Touch01-ARM06' and idtipofamilia in (2) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitassiderurgicos = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM06-Touch01-ARM06' and idtipofamilia in (4,5) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasfornecedores = myReader(0)
        End While

        FormHome.connserver.Close()

        Chart1.Series("Máquinas e Ferramentas").Points.AddXY("Armazém 06", totalvisitasmaquinas)
        Chart1.Series("Produtos Siderúrgicos").Points.AddXY("Armazém 06", totalvisitassiderurgicos)
        Chart1.Series("Fornecedores").Points.AddXY("Armazém 06", totalvisitasfornecedores)




        'ARMAZÉM 15
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM15-Touch01-ARM15' and idtipofamilia in (1) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasmaquinas = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM15-Touch01-ARM15' and idtipofamilia in (2) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitassiderurgicos = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM15-Touch01-ARM15' and idtipofamilia in (4,5) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasfornecedores = myReader(0)
        End While

        FormHome.connserver.Close()

        Chart1.Series("Máquinas e Ferramentas").Points.AddXY("Armazém 15", totalvisitasmaquinas)
        Chart1.Series("Produtos Siderúrgicos").Points.AddXY("Armazém 15", totalvisitassiderurgicos)
        Chart1.Series("Fornecedores").Points.AddXY("Armazém 15", totalvisitasfornecedores)



        'ARMAZÉM 16
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM16-Touch01-ARM16' and idtipofamilia in (1) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasmaquinas = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM16-Touch01-ARM16' and idtipofamilia in (2) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitassiderurgicos = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM16-Touch01-ARM16' and idtipofamilia in (4,5) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasfornecedores = myReader(0)
        End While

        FormHome.connserver.Close()

        Chart1.Series("Máquinas e Ferramentas").Points.AddXY("Armazém 16", totalvisitasmaquinas)
        Chart1.Series("Produtos Siderúrgicos").Points.AddXY("Armazém 16", totalvisitassiderurgicos)
        Chart1.Series("Fornecedores").Points.AddXY("Armazém 16", totalvisitasfornecedores)




        'ARMAZÉM 17
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM17-Touch01-ARM17' and idtipofamilia in (1) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasmaquinas = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM17-Touch01-ARM17' and idtipofamilia in (2) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitassiderurgicos = myReader(0)
        End While

        FormHome.connserver.Close()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "Select count(*) from tabactualizacao where utilizadoractualizacao='TOUCH01ARM17-Touch01-ARM17' and idtipofamilia in (4,5) and statusactualizacao='Estatisticas'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        myReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            totalvisitasfornecedores = myReader(0)
        End While

        FormHome.connserver.Close()

        Chart1.Series("Máquinas e Ferramentas").Points.AddXY("Armazém 17", totalvisitasmaquinas)
        Chart1.Series("Produtos Siderúrgicos").Points.AddXY("Armazém 17", totalvisitassiderurgicos)
        Chart1.Series("Fornecedores").Points.AddXY("Armazém 17", totalvisitasfornecedores)
    End Sub
End Class