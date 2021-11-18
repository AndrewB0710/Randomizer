Public Class fRandomizer

    Private deleteAllOfPickedItem As Boolean = True

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim Count As Integer
        Dim i As Integer

        Count = nmQuantity.Value

        If txtNames.Text.Trim.Length = 0 Then
            MsgBox("Entry can not contain only whitespace OR be a quantity of 0", 0, "Error")
        Else
            While i <> Count
                lstNames.Items.Add(txtNames.Text)
                i = i + 1
            End While
        End If

        txtNames.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        lstNames.Items.Remove(lstNames.SelectedItem)
    End Sub

    Private Sub btnRandomize_Click(sender As Object, e As EventArgs) Handles btnRandomize.Click
        Dim myRandom As New Random
        Dim i As Integer = lstNames.Items.Count - 1


        Try
            lblRandomName.Text = lstNames.Items.Item(myRandom.Next(i)).ToString

            If deleteAllOfPickedItem = False Then
                lstNames.Items.Remove(lblRandomName.Text)
            ElseIf deleteAllOfPickedItem = True Then
                For index = lstNames.Items.Count - 1 To 0 Step -1
                    If lstNames.Items(index) = lblRandomName.Text Then
                        lstNames.Items.RemoveAt(index)
                    End If
                Next
            End If
        Catch
            MsgBox("Can not Randomly Select an empty list", 0, "Error")
        End Try
    End Sub

    Private Sub fRandomizer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRandomName.Font = New Font("Times New Roman", 18)

        Me.AcceptButton = btnAdd
        btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click
        Dim random As New Random()

        For count = 0 To lstNames.Items.Count - 1
            Dim index As Integer = random.Next(count, lstNames.Items.Count)
            If count <> index Then
                Dim temp = lstNames.Items(count)
                lstNames.Items(count) = lstNames.Items(index)
                lstNames.Items(index) = temp
            End If
        Next
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        Dim Response = MsgBox("Are you sure you want to delete the entire list?", 4, "Warning")
        If Response = vbNo Then
            'Do Nothing
        ElseIf Response = vbYes Then
            lstNames.Items.Clear()
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        If deleteAllOfPickedItem = True Then
            Dim Response = MsgBox("Current random selects delete all entrys with a similar name. Would you like to change this to delete only one entry?",
                              4, "Change Selection Removal")
            If Response = vbNo Then
                'Do nothing
            ElseIf Response = vbYes Then
                deleteAllOfPickedItem = False
            End If
        ElseIf deleteAllOfPickedItem = False Then
            Dim Response = MsgBox("Current random selects delete one entry. Would you like to change this to delete all entries with a similar name?",
                              4, "Change Selection Removal")
            If Response = vbNo Then
                'Do nothing
            ElseIf Response = vbYes Then
                deleteAllOfPickedItem = True
            End If
        End If

    End Sub
End Class