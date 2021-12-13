Imports MySql.Data.MySqlClient
Public Class FormFamilias

    Sub totaldefamilias()
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT COUNT(*) FROM tabfamilias where idtipoproduto in (1,2)"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            lbtotal.Text = "( " & myReader(0) & " catálogos )"
        End While

        FormHome.connserver.Close()
    End Sub

    Sub carregarfamilias()
        Listfamilia.Items.Clear()
        txtpesquisa.Text = Nothing
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT tabfamilias.codigofamilia, tabfamilias.nomefamilia, tabtipoprodutos.tipoproduto, modificacao From bdusercontrol.tabfamilias INNER JOIN tabtipoprodutos ON tabfamilias.idtipoproduto = tabtipoprodutos.idtipoproduto WHERE tabfamilias.idtipoproduto in (1,2) ORDER BY tabtipoprodutos.tipoproduto, tabfamilias.codigofamilia"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        Dim cont As Integer = 0
        While myReader.Read
            Listfamilia.Items.Add(myReader(0))
            Listfamilia.Items(cont).SubItems.Add(myReader(1).ToString)
            Listfamilia.Items(cont).SubItems.Add(myReader(2).ToString)
            Listfamilia.Items(cont).SubItems.Add(myReader(3).ToString)
            cont = cont + 1
        End While

        FormHome.connserver.Close()
        totaldefamilias()

    End Sub

    Private Sub FormFamilias_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FormHome.btfamilias.BackColor = Color.Transparent
    End Sub

    Private Sub FormFamilias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FormHome.formactivo = "Familias"
        carregarfamilias()
    End Sub

    Private Sub txtpesquisa_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtpesquisa.EditValueChanged

        Listfamilia.Items.Clear()
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT tabfamilias.codigofamilia, tabfamilias.nomefamilia, tabtipoprodutos.tipoproduto, modificacao From bdusercontrol.tabfamilias INNER JOIN tabtipoprodutos ON tabfamilias.idtipoproduto = tabtipoprodutos.idtipoproduto WHERE tabfamilias.idtipoproduto in (1,2) AND codigofamilia LIKE '" & Trim(Trim(txtpesquisa.Text)) & "%' ORDER BY tabtipoprodutos.tipoproduto"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        Dim cont As Integer = 0
        While myReader.Read
            Listfamilia.Items.Add(myReader(0))
            Listfamilia.Items(cont).SubItems.Add(myReader(1).ToString)
            Listfamilia.Items(cont).SubItems.Add(myReader(2).ToString)
            Listfamilia.Items(cont).SubItems.Add(myReader(3).ToString)
            cont = cont + 1
        End While

        FormHome.connserver.Close()

    End Sub

    Private Sub Listfamilia_DoubleClick(sender As Object, e As System.EventArgs) Handles Listfamilia.DoubleClick

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT caminhofamilia From bdusercontrol.tabfamilias WHERE codigofamilia ='" & Listfamilia.SelectedItems(0).Text & "' and nomefamilia='" & Listfamilia.SelectedItems(0).SubItems(1).Text & "'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            Diagnostics.Process.Start("" & My.Settings.unidade & "" & myReader(0))
        End While

    End Sub
End Class