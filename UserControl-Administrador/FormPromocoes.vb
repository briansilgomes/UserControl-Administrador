Imports MySql.Data.MySqlClient
Public Class FormPromocoes

    Sub totaldepromocoes()

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT COUNT(*) FROM tabfamilias where idtipoproduto in (3,6)"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            lbtotal.Text = "( " & myReader(0) & " promoções em vigor )"
        End While

        FormHome.connserver.Close()

    End Sub

    Sub carregarpromo()
        Listpromo.Items.Clear()
        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT tabfamilias.codigofamilia, tabfamilias.nomefamilia, tabtipoprodutos.tipoproduto, modificacao From bdusercontrol.tabfamilias INNER JOIN tabtipoprodutos ON tabfamilias.idtipoproduto = tabtipoprodutos.idtipoproduto WHERE tabfamilias.idtipoproduto in (3,6) ORDER BY tabtipoprodutos.tipoproduto"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        Dim cont As Integer = 0
        While myReader.Read
            Listpromo.Items.Add(myReader(0))
            Listpromo.Items(cont).SubItems.Add(myReader(1).ToString)
            Listpromo.Items(cont).SubItems.Add(myReader(2).ToString)
            Listpromo.Items(cont).SubItems.Add(myReader(3).ToString)
            cont = cont + 1
        End While

        FormHome.connserver.Close()
    End Sub

    Private Sub FormPromocoes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FormHome.btpromo.BackColor = Color.Transparent
    End Sub

    Private Sub FormPromocoes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FormHome.formactivo = "Promocoes"
        totaldepromocoes()
        carregarpromo()
    End Sub

    Private Sub Listpromo_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Listpromo.MouseDoubleClick

        FormHome.connserver = New MySqlConnection(FormHome.app)
        FormHome.connserver.Open()

        FormHome.comando = "SELECT caminhofamilia From bdusercontrol.tabfamilias WHERE codigofamilia ='" & Listpromo.SelectedItems(0).Text & "' and nomefamilia='" & Listpromo.SelectedItems(0).SubItems(1).Text & "'"
        FormHome.myCommand = New MySqlCommand(FormHome.comando, FormHome.connserver)
        Dim myReader As MySqlDataReader = FormHome.myCommand.ExecuteReader

        While myReader.Read
            Diagnostics.Process.Start("" & My.Settings.unidade & "" & myReader(0))
        End While
    End Sub

End Class