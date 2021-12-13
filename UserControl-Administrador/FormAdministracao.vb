Public Class FormAdministracao

    Private Sub FormAdministracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbd.Text = My.Settings.conectionstringmysql
        txtunidade.Text = My.Settings.unidade
        ' Label5.Text = FileLen("C:\UserControl\setup-usercontrol.exe")
        ' Label5.Text =
    End Sub

    Private Sub btadicinarchagas_Click(sender As Object, e As EventArgs) Handles btadicinarchagas.Click
        If txtbd.Text <> Nothing And txtunidade.Text <> Nothing Then
            My.Settings.conectionstringmysql = txtbd.Text
            My.Settings.unidade = txtunidade.Text
            MsgBox("A definições do sistema foram alteradas com sucesso.", MsgBoxStyle.Information, "UserControl - Administrador")
            Me.Close()
            FormHome.Painelfundo.BringToFront()
        End If

    End Sub
End Class