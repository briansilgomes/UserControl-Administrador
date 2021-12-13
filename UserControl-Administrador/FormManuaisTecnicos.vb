Imports MySql.Data.MySqlClient
Public Class FormManuaisTecnicos

    Sub totaldemanuais()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT COUNT(*) FROM tabfornecedores where idtipoproduto in (5)"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            lbtotal.Text = "( " & myReader(0) & " catálogos )"
        End While

        FormHome.connserver.Close()

    End Sub

    Sub carregarmanuais()
        Listmanual.Items.Clear()
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT tabfornecedores.nomefornecedor, tabtipoprodutos.tipoproduto, modificacao From bdusercontrol.tabfornecedores INNER JOIN tabtipoprodutos ON tabfornecedores.idtipoproduto = tabtipoprodutos.idtipoproduto WHERE tabfornecedores.idtipoproduto in (5) ORDER BY tabfornecedores.nomefornecedor"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        Dim cont As Integer = 0
        While myReader.Read
            Listmanual.Items.Add(myReader(0))
            Listmanual.Items(cont).SubItems.Add(myReader(1).ToString)
            Listmanual.Items(cont).SubItems.Add(myReader(2).ToString)
            cont = cont + 1
        End While

        FormHome.connserver.Close()
        totaldemanuais()
    End Sub

    Private Sub FormManuaisTecnicos_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FormHome.btmanuais.BackColor = Color.Transparent
    End Sub

    Private Sub FormManuaisTecnicos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FormHome.formactivo = "Manuais Tecnicos"
        totaldemanuais()
        carregarmanuais()
    End Sub

    Private Sub Listmanual_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Listmanual.MouseDoubleClick
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT caminhofornecedor From bdusercontrol.tabfornecedores WHERE nomefornecedor='" & Listmanual.SelectedItems(0).Text & "'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            Diagnostics.Process.Start("" & My.Settings.unidade & "" & myReader(0))
        End While
    End Sub

End Class