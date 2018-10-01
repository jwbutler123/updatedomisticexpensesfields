<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddRecords))
        Me.lsvNew = New System.Windows.Forms.ListView
        Me.State = New System.Windows.Forms.ColumnHeader
        Me.PrimaryDestination = New System.Windows.Forms.ColumnHeader
        Me.County = New System.Windows.Forms.ColumnHeader
        Me.NewSeasonStart = New System.Windows.Forms.ColumnHeader
        Me.NewSeasonEnd = New System.Windows.Forms.ColumnHeader
        Me.SeasonStart = New System.Windows.Forms.ColumnHeader
        Me.SeasonEnd = New System.Windows.Forms.ColumnHeader
        Me.Lodging = New System.Windows.Forms.ColumnHeader
        Me.MandIE = New System.Windows.Forms.ColumnHeader
        Me.Total = New System.Windows.Forms.ColumnHeader
        Me.ValidPeriodID = New System.Windows.Forms.ColumnHeader
        Me.btnDeleteSelected = New System.Windows.Forms.Button
        Me.txtorigState = New System.Windows.Forms.TextBox
        Me.txtorigCounty = New System.Windows.Forms.TextBox
        Me.txtorigCity = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblCityException = New System.Windows.Forms.Label
        Me.txtCityException = New System.Windows.Forms.TextBox
        Me.btnCityException = New System.Windows.Forms.Button
        Me.lblCounty = New System.Windows.Forms.Label
        Me.txtCounty = New System.Windows.Forms.TextBox
        Me.txtWhereClause = New System.Windows.Forms.TextBox
        Me.btnWhereClause = New System.Windows.Forms.Button
        Me.grbWhereClause = New System.Windows.Forms.GroupBox
        Me.grbCityExecption = New System.Windows.Forms.GroupBox
        Me.btnDone = New System.Windows.Forms.Button
        Me.btnReload = New System.Windows.Forms.Button
        Me.grbWhereClause.SuspendLayout()
        Me.grbCityExecption.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvNew
        '
        Me.lsvNew.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.State, Me.PrimaryDestination, Me.County, Me.NewSeasonStart, Me.NewSeasonEnd, Me.SeasonStart, Me.SeasonEnd, Me.Lodging, Me.MandIE, Me.Total, Me.ValidPeriodID})
        Me.lsvNew.FullRowSelect = True
        Me.lsvNew.GridLines = True
        Me.lsvNew.HideSelection = False
        Me.lsvNew.Location = New System.Drawing.Point(12, 49)
        Me.lsvNew.Name = "lsvNew"
        Me.lsvNew.Size = New System.Drawing.Size(1245, 474)
        Me.lsvNew.TabIndex = 1
        Me.lsvNew.UseCompatibleStateImageBehavior = False
        Me.lsvNew.View = System.Windows.Forms.View.Details
        '
        'State
        '
        Me.State.Text = "Area"
        Me.State.Width = 40
        '
        'PrimaryDestination
        '
        Me.PrimaryDestination.Text = "PrimaryDestination"
        Me.PrimaryDestination.Width = 200
        '
        'County
        '
        Me.County.Text = "County"
        Me.County.Width = 200
        '
        'NewSeasonStart
        '
        Me.NewSeasonStart.Text = "NewSeasonStart"
        Me.NewSeasonStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NewSeasonStart.Width = 100
        '
        'NewSeasonEnd
        '
        Me.NewSeasonEnd.Text = "NewSeasonEnd"
        Me.NewSeasonEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NewSeasonEnd.Width = 100
        '
        'SeasonStart
        '
        Me.SeasonStart.Text = "SeasonStart"
        Me.SeasonStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SeasonStart.Width = 100
        '
        'SeasonEnd
        '
        Me.SeasonEnd.Text = "SeasonEnd"
        Me.SeasonEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SeasonEnd.Width = 100
        '
        'Lodging
        '
        Me.Lodging.Text = "Lodging"
        Me.Lodging.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Lodging.Width = 100
        '
        'MandIE
        '
        Me.MandIE.Text = "MandIE"
        Me.MandIE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MandIE.Width = 100
        '
        'Total
        '
        Me.Total.Text = "Total"
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.Width = 100
        '
        'ValidPeriodID
        '
        Me.ValidPeriodID.Text = "ValidPeriodID"
        Me.ValidPeriodID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValidPeriodID.Width = 100
        '
        'btnDeleteSelected
        '
        Me.btnDeleteSelected.Enabled = False
        Me.btnDeleteSelected.Location = New System.Drawing.Point(1105, 20)
        Me.btnDeleteSelected.Name = "btnDeleteSelected"
        Me.btnDeleteSelected.Size = New System.Drawing.Size(152, 23)
        Me.btnDeleteSelected.TabIndex = 6
        Me.btnDeleteSelected.Text = "Delete selected..."
        Me.btnDeleteSelected.UseVisualStyleBackColor = True
        '
        'txtorigState
        '
        Me.txtorigState.Location = New System.Drawing.Point(13, 23)
        Me.txtorigState.Name = "txtorigState"
        Me.txtorigState.ReadOnly = True
        Me.txtorigState.Size = New System.Drawing.Size(100, 20)
        Me.txtorigState.TabIndex = 8
        Me.txtorigState.TabStop = False
        '
        'txtorigCounty
        '
        Me.txtorigCounty.Location = New System.Drawing.Point(119, 23)
        Me.txtorigCounty.Name = "txtorigCounty"
        Me.txtorigCounty.ReadOnly = True
        Me.txtorigCounty.Size = New System.Drawing.Size(283, 20)
        Me.txtorigCounty.TabIndex = 9
        Me.txtorigCounty.TabStop = False
        '
        'txtorigCity
        '
        Me.txtorigCity.Location = New System.Drawing.Point(408, 23)
        Me.txtorigCity.Name = "txtorigCity"
        Me.txtorigCity.ReadOnly = True
        Me.txtorigCity.Size = New System.Drawing.Size(275, 20)
        Me.txtorigCity.TabIndex = 10
        Me.txtorigCity.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "State"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "County"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(405, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "City"
        '
        'lblCityException
        '
        Me.lblCityException.AutoSize = True
        Me.lblCityException.Location = New System.Drawing.Point(150, 24)
        Me.lblCityException.Name = "lblCityException"
        Me.lblCityException.Size = New System.Drawing.Size(74, 13)
        Me.lblCityException.TabIndex = 15
        Me.lblCityException.Text = "City Exception"
        '
        'txtCityException
        '
        Me.txtCityException.Location = New System.Drawing.Point(153, 40)
        Me.txtCityException.Name = "txtCityException"
        Me.txtCityException.Size = New System.Drawing.Size(140, 20)
        Me.txtCityException.TabIndex = 1
        Me.txtCityException.TabStop = False
        '
        'btnCityException
        '
        Me.btnCityException.Location = New System.Drawing.Point(299, 37)
        Me.btnCityException.Name = "btnCityException"
        Me.btnCityException.Size = New System.Drawing.Size(39, 23)
        Me.btnCityException.TabIndex = 2
        Me.btnCityException.Text = "OK"
        Me.btnCityException.UseVisualStyleBackColor = True
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(4, 24)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(40, 13)
        Me.lblCounty.TabIndex = 18
        Me.lblCounty.Text = "County"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(7, 40)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(140, 20)
        Me.txtCounty.TabIndex = 0
        Me.txtCounty.TabStop = False
        '
        'txtWhereClause
        '
        Me.txtWhereClause.Location = New System.Drawing.Point(6, 19)
        Me.txtWhereClause.Multiline = True
        Me.txtWhereClause.Name = "txtWhereClause"
        Me.txtWhereClause.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtWhereClause.Size = New System.Drawing.Size(1164, 61)
        Me.txtWhereClause.TabIndex = 3
        '
        'btnWhereClause
        '
        Me.btnWhereClause.Location = New System.Drawing.Point(1176, 57)
        Me.btnWhereClause.Name = "btnWhereClause"
        Me.btnWhereClause.Size = New System.Drawing.Size(61, 23)
        Me.btnWhereClause.TabIndex = 4
        Me.btnWhereClause.Text = "OK"
        Me.btnWhereClause.UseVisualStyleBackColor = True
        '
        'grbWhereClause
        '
        Me.grbWhereClause.Controls.Add(Me.txtWhereClause)
        Me.grbWhereClause.Controls.Add(Me.btnWhereClause)
        Me.grbWhereClause.Enabled = False
        Me.grbWhereClause.Location = New System.Drawing.Point(13, 628)
        Me.grbWhereClause.Name = "grbWhereClause"
        Me.grbWhereClause.Size = New System.Drawing.Size(1243, 90)
        Me.grbWhereClause.TabIndex = 21
        Me.grbWhereClause.TabStop = False
        Me.grbWhereClause.Text = "Create where clause"
        '
        'grbCityExecption
        '
        Me.grbCityExecption.Controls.Add(Me.txtCounty)
        Me.grbCityExecption.Controls.Add(Me.txtCityException)
        Me.grbCityExecption.Controls.Add(Me.lblCounty)
        Me.grbCityExecption.Controls.Add(Me.lblCityException)
        Me.grbCityExecption.Controls.Add(Me.btnCityException)
        Me.grbCityExecption.Enabled = False
        Me.grbCityExecption.Location = New System.Drawing.Point(12, 532)
        Me.grbCityExecption.Name = "grbCityExecption"
        Me.grbCityExecption.Size = New System.Drawing.Size(1243, 90)
        Me.grbCityExecption.TabIndex = 22
        Me.grbCityExecption.TabStop = False
        Me.grbCityExecption.Text = "City Exception"
        '
        'btnDone
        '
        Me.btnDone.Enabled = False
        Me.btnDone.Location = New System.Drawing.Point(1024, 20)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 5
        Me.btnDone.Text = "Done..."
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(689, 20)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(75, 23)
        Me.btnReload.TabIndex = 23
        Me.btnReload.Text = "Reload..."
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'frmAddRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 727)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.grbWhereClause)
        Me.Controls.Add(Me.grbCityExecption)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtorigCity)
        Me.Controls.Add(Me.txtorigCounty)
        Me.Controls.Add(Me.txtorigState)
        Me.Controls.Add(Me.btnDeleteSelected)
        Me.Controls.Add(Me.lsvNew)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddRecords"
        Me.Text = "Add missing records"
        Me.grbWhereClause.ResumeLayout(False)
        Me.grbWhereClause.PerformLayout()
        Me.grbCityExecption.ResumeLayout(False)
        Me.grbCityExecption.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvNew As System.Windows.Forms.ListView
    Friend WithEvents State As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrimaryDestination As System.Windows.Forms.ColumnHeader
    Friend WithEvents County As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewSeasonStart As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewSeasonEnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lodging As System.Windows.Forms.ColumnHeader
    Friend WithEvents MandIE As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.ColumnHeader
    Friend WithEvents ValidPeriodID As System.Windows.Forms.ColumnHeader
    Friend WithEvents SeasonStart As System.Windows.Forms.ColumnHeader
    Friend WithEvents SeasonEnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDeleteSelected As System.Windows.Forms.Button
    Friend WithEvents txtorigState As System.Windows.Forms.TextBox
    Friend WithEvents txtorigCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtorigCity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCityException As System.Windows.Forms.Label
    Friend WithEvents txtCityException As System.Windows.Forms.TextBox
    Friend WithEvents btnCityException As System.Windows.Forms.Button
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtWhereClause As System.Windows.Forms.TextBox
    Friend WithEvents btnWhereClause As System.Windows.Forms.Button
    Friend WithEvents grbWhereClause As System.Windows.Forms.GroupBox
    Friend WithEvents grbCityExecption As System.Windows.Forms.GroupBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
End Class
