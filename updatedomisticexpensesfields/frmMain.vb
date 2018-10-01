Public Class frmMain
    Private frmAddRecords As New frmAddRecords

    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        btnBrowse.Enabled = False

        Dim browse As New OpenFileDialog
        Dim result As DialogResult = browse.ShowDialog()
        If result <> Windows.Forms.DialogResult.Cancel Then
            txtSourceFile.Text = browse.FileName

            Dim fr As New System.IO.StreamReader(txtSourceFile.Text)

            With ListView1
                .BeginUpdate()
                .Items.Clear()
            End With
            Dim line As String = String.Empty

            Dim previous_li As ListViewItem = Nothing
            Dim newarea As Boolean = True
            Dim year As Integer = Date.Today.Year

            Do While Not fr.EndOfStream
                Try
                    line = fr.ReadLine
                    Dim fields() As String = line.Split(Convert.ToChar(vbTab))
                    If fields(0).ToLower <> "state" Then
                        fields(1) = fields(1).Replace("St. ", "Saint ")
                        fields(1) = fields(1).Replace(" Parish", "")
                        fields(1) = fields(1).Replace(" Parishs", "")
                        fields(2) = fields(2).Replace("St. ", "Saint ")
                        fields(2) = fields(2).Replace(" Parish", "")
                        fields(2) = fields(2).Replace(" Parishs", "")

                        If previous_li IsNot Nothing Then
                            If fields(0) = previous_li.Text And fields(1) = previous_li.SubItems(1).Text And fields(2) = previous_li.SubItems(2).Text Then
                                newarea = False
                            Else
                                newarea = True
                            End If
                        End If

                        Dim li As New ListViewItem
                        With li
                            .Text = fields(0)   'state
                            .SubItems.Add(fields(1).Replace(Chr(34), ""))    'primarydestination
                            .SubItems.Add(fields(2).Replace(Chr(34), ""))    'county

                            If fields(3).Length > 0 Then
                                Dim start_parts() As String = fields(3).Split("-"c)
                                year = CInt(txtFY.Text) - 1

                                If newarea And CInt(cvbMonth(start_parts(0))) <= 9 Or Not newarea And CInt(cvbMonth(start_parts(0))) <= 9 Then
                                    year += 1
                                End If

                                Dim start_new As Date = Date.Parse(cvbMonth(start_parts(1)) & "/" & start_parts(0) & "/" & year.ToString)

                                Dim end_parts() As String = fields(4).Split("-"c)
                                year = CInt(txtFY.Text) - 1

                                If newarea And CInt(cvbMonth(end_parts(1))) <= 9 Or Not newarea And CInt(cvbMonth(end_parts(1))) <= 9 Then
                                    year += 1
                                End If

                                Dim end_new As Date = Date.Parse(cvbMonth(end_parts(1)) & "/" & end_parts(0) & "/" & year.ToString)

                                .SubItems.Add(start_new.ToShortDateString)
                                .SubItems.Add(end_new.ToShortDateString)
                            Else
                                .SubItems.Add("")
                                .SubItems.Add("")
                            End If
                            .SubItems.Add(fields(3))
                            .SubItems.Add(fields(4))
                            .SubItems.Add(Format(CDbl(fields(5)), "###0.00"))
                            .SubItems.Add(Format(CDbl(fields(6)), "###0.00"))
                            .SubItems.Add(Format(CDbl(fields(7)), "###0.00"))
                            .SubItems.Add(fields(8))
                        End With
                        ListView1.Items.Add(li)
                        previous_li = ListView1.Items(ListView1.Items.Count - 1)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    Exit Do
                End Try
            Loop
            ListView1.EndUpdate()
            fr.Close()
            MessageBox.Show("Processing complete...")
            Button1.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim fw As New System.IO.StreamWriter(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(txtSourceFile.Text), System.IO.Path.GetFileNameWithoutExtension(txtSourceFile.Text) & "_new" & System.IO.Path.GetExtension(txtSourceFile.Text)))

        fw.WriteLine("State" & vbTab & "PrimaryDestination" & vbTab & "County" & vbTab & "SeasonStart" & vbTab & "SeasonEnd" & vbTab & "Lodging" & vbTab & "MandIE" & vbTab & "Total" & vbTab & "ValidPeriodID")

        For Each li As ListViewItem In ListView1.Items
            Dim line As String = li.SubItems(0).Text

            For x As Integer = 1 To li.SubItems.Count - 1
                If x <> 5 And x <> 6 Then
                    line += vbTab & li.SubItems(x).Text
                End If
            Next
            fw.WriteLine(line)
        Next

        fw.Close()

        MessageBox.Show("The file " & System.IO.Path.Combine(System.IO.Path.GetDirectoryName(txtSourceFile.Text), System.IO.Path.GetFileNameWithoutExtension(txtSourceFile.Text) & "_new" & System.IO.Path.GetExtension(txtSourceFile.Text)) & " has been created...", "Penergy Technologies, Inc.", MessageBoxButtons.OK)
    End Sub

    Private Function cvbMonth(ByVal Month As String) As Integer
        Dim result As Integer = 0

        Select Case Month.ToLower
            Case "january", "jan"
                result = 1
            Case "february", "feb"
                result = 2
            Case "march", "mar"
                result = 3
            Case "april", "apr"
                result = 4
            Case "may"
                result = 5
            Case "june", "jun"
                result = 6
            Case "july", "jul"
                result = 7
            Case "august", "aug"
                result = 8
            Case "september", "sep"
                result = 9
            Case "october", "oct"
                result = 10
            Case "november", "nov"
                result = 11
            Case "december", "dec"
                result = 12
        End Select

        Return result
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim initial_records As Integer = ListView1.Items.Count - 1
        Dim lvi As ListViewItem = Nothing
        For listview_index As Integer = 0 To initial_records
            lvi = ListView1.Items(listview_index)
            lvi.Selected = True
            lvi.EnsureVisible()

            frmAddRecords.AddDone = False
            frmAddRecords.SelectedListViewItem = lvi
            frmAddRecords.Show()
            frmAddRecords.LoadRecords()
            Do
                Application.DoEvents()
            Loop While Not frmAddRecords.AddDone

            If frmAddRecords.IsDisposed Then
                MessageBox.Show("You have chosen to stop adding missing records" & vbCrLf & "To save your progress -" & vbCrLf & "1. Click the Save2File button" & vbCrLf & "2. Remove the rows from " & System.IO.Path.GetFileName(txtSourceFile.Text) & " that have already been processed.")
                Exit For
            End If

            frmAddRecords.Hide()
            frmAddRecords.AddDone = False

            ListView1.BeginUpdate()
            For Each li As ListViewItem In frmAddRecords.lsvNew.Items
                Dim nli As ListViewItem = CType(li.Clone, ListViewItem)
                ListView1.Items.Add(nli)
            Next
            ListView1.EndUpdate()

            frmAddRecords.lsvNew.Items.Clear()
            lvi.Selected = False
        Next

        btnSave.Enabled = True
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Today.Month >= 10 Then
            txtFY.Text = (Today.Year + 1).ToString
        Else
            txtFY.Text = Today.Year.ToString
        End If
    End Sub
End Class