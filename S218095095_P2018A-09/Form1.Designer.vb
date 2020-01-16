<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFishingSeason
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
        Me.btnInit = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnCalcAve = New System.Windows.Forms.Button()
        Me.btnIndex = New System.Windows.Forms.Button()
        Me.btnRat = New System.Windows.Forms.Button()
        Me.grdUj = New UJGrid.UJGrid()
        Me.txtChangeRat = New System.Windows.Forms.TextBox()
        Me.lblChangeRat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(9, 10)
        Me.btnInit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(178, 45)
        Me.btnInit.TabIndex = 0
        Me.btnInit.Text = "Initialize"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(9, 59)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(178, 45)
        Me.btnInfo.TabIndex = 1
        Me.btnInfo.Text = "Enter information"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnCalcAve
        '
        Me.btnCalcAve.Location = New System.Drawing.Point(9, 109)
        Me.btnCalcAve.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalcAve.Name = "btnCalcAve"
        Me.btnCalcAve.Size = New System.Drawing.Size(178, 45)
        Me.btnCalcAve.TabIndex = 2
        Me.btnCalcAve.Text = "View Average"
        Me.btnCalcAve.UseVisualStyleBackColor = True
        '
        'btnIndex
        '
        Me.btnIndex.Location = New System.Drawing.Point(9, 158)
        Me.btnIndex.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIndex.Name = "btnIndex"
        Me.btnIndex.Size = New System.Drawing.Size(178, 45)
        Me.btnIndex.TabIndex = 3
        Me.btnIndex.Text = "View highest average index"
        Me.btnIndex.UseVisualStyleBackColor = True
        '
        'btnRat
        '
        Me.btnRat.Location = New System.Drawing.Point(9, 208)
        Me.btnRat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRat.Name = "btnRat"
        Me.btnRat.Size = New System.Drawing.Size(178, 45)
        Me.btnRat.TabIndex = 4
        Me.btnRat.Text = "View Period rating"
        Me.btnRat.UseVisualStyleBackColor = True
        '
        'grdUj
        '
        Me.grdUj.FixedCols = 1
        Me.grdUj.FixedRows = 1
        Me.grdUj.Location = New System.Drawing.Point(193, 11)
        Me.grdUj.Name = "grdUj"
        Me.grdUj.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdUj.Size = New System.Drawing.Size(474, 289)
        Me.grdUj.TabIndex = 5
        '
        'txtChangeRat
        '
        Me.txtChangeRat.Location = New System.Drawing.Point(9, 282)
        Me.txtChangeRat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtChangeRat.Name = "txtChangeRat"
        Me.txtChangeRat.Size = New System.Drawing.Size(180, 20)
        Me.txtChangeRat.TabIndex = 6
        '
        'lblChangeRat
        '
        Me.lblChangeRat.AutoSize = True
        Me.lblChangeRat.Location = New System.Drawing.Point(28, 266)
        Me.lblChangeRat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChangeRat.Name = "lblChangeRat"
        Me.lblChangeRat.Size = New System.Drawing.Size(135, 13)
        Me.lblChangeRat.TabIndex = 7
        Me.lblChangeRat.Text = "Is rating a decreasing trend"
        '
        'frmFishingSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 313)
        Me.Controls.Add(Me.lblChangeRat)
        Me.Controls.Add(Me.txtChangeRat)
        Me.Controls.Add(Me.grdUj)
        Me.Controls.Add(Me.btnRat)
        Me.Controls.Add(Me.btnIndex)
        Me.Controls.Add(Me.btnCalcAve)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnInit)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmFishingSeason"
        Me.Text = "Fishing season"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInit As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnCalcAve As Button
    Friend WithEvents btnIndex As Button
    Friend WithEvents btnRat As Button
    Friend WithEvents grdUj As UJGrid.UJGrid
    Friend WithEvents txtChangeRat As TextBox
    Friend WithEvents lblChangeRat As Label
End Class
