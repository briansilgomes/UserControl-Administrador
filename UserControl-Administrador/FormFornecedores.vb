Imports MySql.Data.MySqlClient
Public Class FormFornecedores

    Sub totaldefornecedores()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT COUNT(*) FROM tabfornecedores where idtipoproduto in (4)"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            lbtotal.Text = "( " & myReader(0) & " catálogos )"
        End While

        FormHome.connserver.Close()

    End Sub

    Sub carregarfornecedores()
        Listfornecedor.Items.Clear()
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT tabfornecedores.nomefornecedor, tabtipoprodutos.tipoproduto, modificacao From bdusercontrol.tabfornecedores INNER JOIN tabtipoprodutos ON tabfornecedores.idtipoproduto = tabtipoprodutos.idtipoproduto WHERE tabfornecedores.idtipoproduto in (4) ORDER BY tabfornecedores.nomefornecedor"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        Dim cont As Integer = 0
        While myReader.Read
            Listfornecedor.Items.Add(myReader(0))
            Listfornecedor.Items(cont).SubItems.Add(myReader(1).ToString)
            Listfornecedor.Items(cont).SubItems.Add(myReader(2).ToString)
            cont = cont + 1
        End While

        FormHome.connserver.Close()
        totaldefornecedores()
    End Sub
    Private Sub FormFornecedores_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FormHome.btfornecedor.BackColor = Color.Transparent
    End Sub

    Private Sub FormFornecedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FormHome.formactivo = "Fornecedores"
        carregarfornecedores()
    End Sub

    Private Sub txtpesquisa_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtpesquisa.EditValueChanged

        Listfornecedor.Items.Clear()
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT tabfornecedores.nomefornecedor, tabtipoprodutos.tipoproduto, modificacao From bdusercontrol.tabfornecedores INNER JOIN tabtipoprodutos ON tabfornecedores.idtipoproduto = tabtipoprodutos.idtipoproduto WHERE tabfornecedores.idtipoproduto in (4) and nomefornecedor LIKE '" & Trim(Trim(txtpesquisa.Text)) & "%' ORDER BY tabfornecedores.nomefornecedor"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        Dim cont As Integer = 0
        While myReader.Read
            Listfornecedor.Items.Add(myReader(0))
            Listfornecedor.Items(cont).SubItems.Add(myReader(1).ToString)
            Listfornecedor.Items(cont).SubItems.Add(myReader(2).ToString)
            cont = cont + 1
        End While

        FormHome.connserver.Close()

    End Sub

    Private Sub Listfornecedor_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Listfornecedor.MouseDoubleClick

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT caminhofornecedor From bdusercontrol.tabfornecedores WHERE nomefornecedor='" & Listfornecedor.SelectedItems(0).Text & "'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            Diagnostics.Process.Start("" & My.Settings.unidade & "" & myReader(0))
        End While

    End Sub

End Class