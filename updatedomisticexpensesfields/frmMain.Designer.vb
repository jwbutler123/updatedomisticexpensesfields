<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ListView1 = New System.Windows.Forms.ListView
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
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.txtSourceFile = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtFY = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.State, Me.PrimaryDestination, Me.County, Me.NewSeasonStart, Me.NewSeasonEnd, Me.SeasonStart, Me.SeasonEnd, Me.Lodging, Me.MandIE, Me.Total, Me.ValidPeriodID})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 23)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1262, 480)
        Me.ListView1.TabIndex = 0
        Me.ListView1.TabStop = False
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
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
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(1201, 545)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save 2 File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(957, 521)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(30, 20)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtSourceFile
        '
        Me.txtSourceFile.Location = New System.Drawing.Point(119, 521)
        Me.txtSourceFile.Name = "txtSourceFile"
        Me.txtSourceFile.ReadOnly = True
        Me.txtSourceFile.Size = New System.Drawing.Size(832, 20)
        Me.txtSourceFile.TabIndex = 3
        Me.txtSourceFile.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 505)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Source file"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(13, 547)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add Missing Records"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFY
        '
        Me.txtFY.Location = New System.Drawing.Point(13, 521)
        Me.txtFY.Name = "txtFY"
        Me.txtFY.Size = New System.Drawing.Size(100, 20)
        Me.txtFY.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 503)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fiscal year to use"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 575)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFY)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSourceFile)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Update Domistic Expense Fields"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents State As System.Windows.Forms.ColumnHeader
    Friend WithEvents County As System.Windows.Forms.ColumnHeader
    Friend WithEvents SeasonStart As System.Windows.Forms.ColumnHeader
    Friend WithEvents SeasonEnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lodging As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents MandIE As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.ColumnHeader
    Friend WithEvents ValidPeriodID As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtSourceFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewSeasonStart As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewSeasonEnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrimaryDestination As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
