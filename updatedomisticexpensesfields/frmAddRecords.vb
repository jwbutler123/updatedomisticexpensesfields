Public Class frmAddRecords
    Private prodone As Boolean = False
    Private prolistitem As ListViewItem = Nothing
    Private cityexception_continue As Boolean = False
    Private whereclause_continue As Boolean = False
    Private default_whereclause As String = "WHERE (EffectiveEnd IS NULL) AND (PrimaryRecord = 'P') AND (State = '') AND (City IN('', '')) OR" & vbCrLf & _
                                            "      (EffectiveEnd IS NULL) AND (PrimaryRecord = 'P') AND (State = '') AND (City IN('', '')) OR" & vbCrLf & _
                                            "      (EffectiveEnd IS NULL) AND (PrimaryRecord = 'P') AND (State = '') AND (County IN('', '')) OR" & vbCrLf & _
                                            "      (EffectiveEnd IS NULL) AND (PrimaryRecord = 'P') AND (State = '') AND (County IN('', ''))"

    Public Property AddDone() As Boolean
        Get
            Return prodone
        End Get
        Set(ByVal value As Boolean)
            prodone = value
        End Set
    End Property

    Public WriteOnly Property SelectedListViewItem() As ListViewItem
        Set(ByVal value As ListViewItem)
            prolistitem = value
        End Set
    End Property

    Public Sub LoadRecords()
        Dim cnn As SqlClient.SqlConnection = Nothing
        Dim cmd As SqlClient.SqlCommand = Nothing
        Dim rdr As SqlClient.SqlDataReader = Nothing
        Dim prm As SqlClient.SqlParameter = Nothing
        Dim prm_cityexecption As SqlClient.SqlParameter = Nothing
        Dim prm_whereclause As SqlClient.SqlParameter = Nothing

        Dim exception As Exception = Nothing
        Dim cmdtext As String = String.Empty
        Dim counties() As String = Nothing
        Dim cities() As String = Nothing

        Try
            txtorigState.Text = prolistitem.SubItems(0).Text
            txtorigCounty.Text = prolistitem.SubItems(2).Text
            txtorigCity.Text = prolistitem.SubItems(1).Text

            cnn = penergy.sql.Connection.GetSQLClientConnectionToSupport("eFAACTSupport", exception)
            If cnn.State <> ConnectionState.Open Then
                If exception IsNot Nothing Then
                    Throw exception
                Else
                    Throw New Exception("Couldn't open connection to the support database...")
                End If
            End If

            cmd = cnn.CreateCommand

            If prolistitem.SubItems(1).Text.Contains("/") Then
                cities = prolistitem.SubItems(1).Text.Split("/"c)
            End If

            If prolistitem.SubItems(2).Text.Contains("/") Then
                counties = prolistitem.SubItems(2).Text.Split("/"c)
            Else
                If cities IsNot Nothing Then
                    counties = prolistitem.SubItems(2).Text.Split(","c)
                End If
            End If

            If cities Is Nothing And counties Is Nothing Then
                Dim temp_city() As String = prolistitem.SubItems(1).Text.Split(" "c)
                Dim temp_county() As String = prolistitem.SubItems(2).Text.Split(" "c)
                If temp_city.Length < 3 And temp_county.Length < 3 Then
                    cmdtext = "zip_getrecords4county"
                    counties = prolistitem.SubItems(2).Text.Split("/"c)
                Else
                    cmdtext = "zip_getrecords4whereclause"

                    txtWhereClause.Text = default_whereclause
                    grbWhereClause.Enabled = True
                    MessageBox.Show("Couldn't evaluate the data automatically please create the where clause...")
                    whereclause_continue = False
                    Do
                        Application.DoEvents()
                    Loop While Not whereclause_continue

                    If txtWhereClause.Text <> default_whereclause Then
                        prm_whereclause = New SqlClient.SqlParameter
                        With prm_whereclause
                            .ParameterName = "whereclause"
                            .SqlDbType = SqlDbType.NVarChar
                            .Value = txtWhereClause.Text
                        End With
                    Else
                        prm_whereclause = Nothing
                    End If
                    txtWhereClause.Text = ""
                End If
            Else
                cmdtext = "zip_getrecords4county"
                cities = Nothing
            End If

            If cmdtext = "zip_getrecords4county" Then
                For county_index As Integer = 0 To counties.Length - 1
                    cmd.Parameters.Clear()

                    Dim county_parts() As String = counties(county_index).Trim.Split(" "c)
                    If county_parts.Length > 1 Then
                        txtCounty.Text = counties(county_index).Trim
                        cityexception_continue = False
                        grbCityExecption.Enabled = True
                        MessageBox.Show("Please verify the county and the city of exception...")
                        Do
                            Application.DoEvents()
                        Loop While Not cityexception_continue

                        counties(county_index) = txtCounty.Text

                        If txtCityException.Text.Length > 0 Then
                            prm_cityexecption = New SqlClient.SqlParameter
                            With prm_cityexecption
                                .ParameterName = "city"
                                .SqlDbType = SqlDbType.NVarChar
                                .SqlValue = txtCityException.Text
                            End With
                        Else
                            prm_cityexecption = Nothing
                        End If
                        txtCityException.Text = ""
                        txtCounty.Text = ""
                    Else
                        prm_cityexecption = Nothing
                    End If

                    prm = New SqlClient.SqlParameter
                    With prm
                        .ParameterName = "state"
                        .SqlDbType = SqlDbType.NVarChar
                        .SqlValue = prolistitem.SubItems(0).Text
                    End With
                    cmd.Parameters.Add(prm)

                    prm = New SqlClient.SqlParameter
                    With prm
                        .ParameterName = "county"
                        .SqlDbType = SqlDbType.NVarChar
                        .SqlValue = counties(county_index).Trim
                    End With
                    cmd.Parameters.Add(prm)

                    If prm_cityexecption IsNot Nothing Then
                        cmd.Parameters.Add(prm_cityexecption)
                    End If

                    With cmd
                        .CommandTimeout = 120
                        .CommandText = cmdtext
                        .CommandType = CommandType.StoredProcedure
                        rdr = .ExecuteReader
                    End With

                    Do While rdr.Read
                        Dim li As New ListViewItem
                        With li
                            .Text = CStr(rdr.Item(rdr.GetOrdinal("State")))
                            .SubItems.Add(CStr(rdr.Item(rdr.GetOrdinal("City"))))    'primarydestination
                            .SubItems.Add(CStr(rdr.Item(rdr.GetOrdinal("County"))))    'county

                            If prolistitem.SubItems(3).Text.Length > 0 Then
                                .SubItems.Add(prolistitem.SubItems(3).Text)
                                .SubItems.Add(prolistitem.SubItems(4).Text)
                            Else
                                .SubItems.Add("")
                                .SubItems.Add("")
                            End If
                            .SubItems.Add(prolistitem.SubItems(5).Text)
                            .SubItems.Add(prolistitem.SubItems(6).Text)
                            .SubItems.Add(Format(CDbl(prolistitem.SubItems(7).Text), "###0.00"))
                            .SubItems.Add(Format(CDbl(prolistitem.SubItems(8).Text), "###0.00"))
                            .SubItems.Add(Format(CDbl(prolistitem.SubItems(9).Text), "###0.00"))
                            .SubItems.Add(prolistitem.SubItems(10).Text)
                        End With
                        lsvNew.Items.Add(li)
                    Loop
                    rdr.Close()
                Next
            Else
                If prm_whereclause IsNot Nothing Then
                    cmd.Parameters.Clear()

                    With cmd
                        .Parameters.Add(prm_whereclause)
                        .CommandTimeout = 120
                        .CommandText = cmdtext
                        .CommandType = CommandType.StoredProcedure
                        rdr = .ExecuteReader
                    End With

                    Do While rdr.Read
                        Dim li As New ListViewItem
                        With li
                            .Text = CStr(rdr.Item(rdr.GetOrdinal("State")))
                            .SubItems.Add(CStr(rdr.Item(rdr.GetOrdinal("City"))))    'primarydestination
                            .SubItems.Add(CStr(rdr.Item(rdr.GetOrdinal("County"))))    'county

                            If prolistitem.SubItems(3).Text.Length > 0 Then
                                .SubItems.Add(prolistitem.SubItems(3).Text)
                                .SubItems.Add(prolistitem.SubItems(4).Text)
                            Else
                                .SubItems.Add("")
                                .SubItems.Add("")
                            End If
                            .SubItems.Add(prolistitem.SubItems(5).Text)
                            .SubItems.Add(prolistitem.SubItems(6).Text)
                            .SubItems.Add(Format(CDbl(prolistitem.SubItems(7).Text), "###0.00"))
                            .SubItems.Add(Format(CDbl(prolistitem.SubItems(8).Text), "###0.00"))
                            .SubItems.Add(Format(CDbl(prolistitem.SubItems(9).Text), "###0.00"))
                            .SubItems.Add(prolistitem.SubItems(10).Text)
                        End With
                        lsvNew.Items.Add(li)
                    Loop

                    rdr.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Try
                rdr.Close()
            Catch ex As Exception
            End Try
            Try
                cnn.Close()
            Catch ex As Exception
            End Try

            btnDone.Enabled = True
        End Try
    End Sub

    Private Sub btnDeleteSelected_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteSelected.Click
        For Each lvi As ListViewItem In lsvNew.SelectedItems
            lsvNew.Items.Remove(lvi)
        Next
    End Sub

    Private Sub btnCityException_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCityException.Click
        Dim cont As Boolean = True
        If txtCityException.Text.Length = 0 Or txtCounty.Text.Length = 0 Then
            Dim response As DialogResult = MessageBox.Show("Execute this without all fields being filled in?", "", MessageBoxButtons.YesNo)
            If response = Windows.Forms.DialogResult.No Then
                cont = False
            End If
        End If

        If cont Then
            cityexception_continue = True
            grbCityExecption.Enabled = False
        End If
    End Sub

    Private Sub btnWhereClause_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWhereClause.Click
        Dim cont As Boolean = True
        If txtWhereClause.Text = default_whereclause Then
            Dim response As DialogResult = MessageBox.Show("Execute this without updating the default query?", "", MessageBoxButtons.YesNo)
            If response = Windows.Forms.DialogResult.No Then
                cont = False
            End If
        End If

        If cont Then
            whereclause_continue = True
            grbWhereClause.Enabled = False
        End If
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        btnDone.Enabled = False
        btnDeleteSelected.Enabled = False
        prodone = True
    End Sub

    Private Sub lsvNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvNew.Click
        btnDeleteSelected.Enabled = True
    End Sub

    Private Sub frmAddRecords_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        prodone = True
    End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        LoadRecords()
    End Sub
End Class