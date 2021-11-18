Public Class fRandomizer

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim Count As Integer
        Dim i As Integer

        Count = nmQuantity.Value

        While i <> Count
            lstNames.Items.Add(txtNames.Text)
            i = i + 1
        End While
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        lstNames.Items.Remove(lstNames.SelectedItem)
    End Sub

    Private Sub btnRandomize_Click(sender As Object, e As EventArgs) Handles btnRandomize.Click
        Dim myRandom As New Random
        Dim i As Integer = lstNames.Items.Count

        lblRandomName.Text = lstNames.Items.Item(myRandom.Next(i)).ToString
        lstNames.Items.Remove(lblRandomName.Text)
    End Sub

    Private Sub fRandomizer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRandomName.Font = New Font("Times New Roman", 18)

        Me.AcceptButton = btnAdd
        btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class
