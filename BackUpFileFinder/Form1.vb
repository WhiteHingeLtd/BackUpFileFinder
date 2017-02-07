Public Class Form1
    Private Sub GetTandEListBtn_Click(sender As Object, e As EventArgs) Handles GetTandEListBtn.Click
        If My.Computer.FileSystem.DirectoryExists(TandXbackuppath.Text) Then
            Dim MostRecent As New Date
            Dim listOfFiles As List(Of String) = My.Computer.FileSystem.GetFiles(TandXbackuppath.Text).ToList
            If XandTDGV.Rows.Count > 0 Then
                XandTDGV.Rows.Clear()
            End If
            For Each item As String In listOfFiles
                Dim itemData As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(item)
                Dim newrow As New DataGridViewRow
                newrow.CreateCells(XandTDGV)
                newrow.Cells(0).Value = itemData.Name
                newrow.Cells(1).Value = itemData.CreationTime
                If itemData.CreationTime.DayOfWeek = DayOfWeek.Monday Then
                    newrow.Cells(1).Style.BackColor = Color.LightGreen
                    If itemData.CreationTime.Day <= 7 Then
                        newrow.DefaultCellStyle.BackColor = Color.LightGreen
                        newrow.Cells(3).Value = "1st Monday"
                    Else
                        newrow.Cells(3).Value = "Monday"
                    End If
                End If
                If itemData.CreationTime > MostRecent Then
                    MostRecent = itemData.CreationTime
                End If
                Dim sizeNum As Decimal = Math.Round(itemData.Length / 1048576, 2)
                newrow.Cells(2).Value = sizeNum.ToString
                newrow.Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                newrow.Tag = item
                XandTDGV.Rows.Add(newrow)
            Next
            XandTDGV.Sort(DateCol, System.ComponentModel.ListSortDirection.Descending)
            For Each selRow As DataGridViewRow In XandTDGV.SelectedRows
                selRow.Selected = False
            Next
            TandXBackupCountLbl.Text = listOfFiles.Count.ToString
            TandXMostRecentLbl.Text = MostRecent.ToString("dd/MM/yyyy")

            XandTDGV.Sort(XandTDGV.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        Else
            MsgBox("Path to " + TandXbackuppath.Text + " wasn't found. You may not be currently connected to that particular point of the network - See IT for details.")
        End If
    End Sub
End Class
