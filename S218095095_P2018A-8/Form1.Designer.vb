<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPracEight
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
        Me.GrdUIj = New UJGrid.UJGrid()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.txtPride = New System.Windows.Forms.TextBox()
        Me.txtLion = New System.Windows.Forms.TextBox()
        Me.lblPride = New System.Windows.Forms.Label()
        Me.lblLions = New System.Windows.Forms.Label()
        Me.btnPrideInfo = New System.Windows.Forms.Button()
        Me.btnLowestM = New System.Windows.Forms.Button()
        Me.btnPriderat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GrdUIj
        '
        Me.GrdUIj.FixedCols = 1
        Me.GrdUIj.FixedRows = 1
        Me.GrdUIj.Location = New System.Drawing.Point(208, 12)
        Me.GrdUIj.Name = "GrdUIj"
        Me.GrdUIj.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.GrdUIj.Size = New System.Drawing.Size(418, 345)
        Me.GrdUIj.TabIndex = 0
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(12, 80)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(190, 64)
        Me.btnInit.TabIndex = 1
        Me.btnInit.Text = "Initialize"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'txtPride
        '
        Me.txtPride.Location = New System.Drawing.Point(105, 16)
        Me.txtPride.Name = "txtPride"
        Me.txtPride.Size = New System.Drawing.Size(97, 20)
        Me.txtPride.TabIndex = 2
        '
        'txtLion
        '
        Me.txtLion.Location = New System.Drawing.Point(105, 45)
        Me.txtLion.Name = "txtLion"
        Me.txtLion.Size = New System.Drawing.Size(97, 20)
        Me.txtLion.TabIndex = 3
        '
        'lblPride
        '
        Me.lblPride.AutoSize = True
        Me.lblPride.Location = New System.Drawing.Point(12, 23)
        Me.lblPride.Name = "lblPride"
        Me.lblPride.Size = New System.Drawing.Size(74, 13)
        Me.lblPride.TabIndex = 4
        Me.lblPride.Text = "pride (number)"
        '
        'lblLions
        '
        Me.lblLions.AutoSize = True
        Me.lblLions.Location = New System.Drawing.Point(15, 52)
        Me.lblLions.Name = "lblLions"
        Me.lblLions.Size = New System.Drawing.Size(71, 13)
        Me.lblLions.TabIndex = 5
        Me.lblLions.Text = "Lion (number)"
        '
        'btnPrideInfo
        '
        Me.btnPrideInfo.Location = New System.Drawing.Point(12, 151)
        Me.btnPrideInfo.Name = "btnPrideInfo"
        Me.btnPrideInfo.Size = New System.Drawing.Size(190, 64)
        Me.btnPrideInfo.TabIndex = 6
        Me.btnPrideInfo.Text = "Pride Information"
        Me.btnPrideInfo.UseVisualStyleBackColor = True
        '
        'btnLowestM
        '
        Me.btnLowestM.Location = New System.Drawing.Point(12, 222)
        Me.btnLowestM.Name = "btnLowestM"
        Me.btnLowestM.Size = New System.Drawing.Size(190, 64)
        Me.btnLowestM.TabIndex = 8
        Me.btnLowestM.Text = "View lowest average movement Lion"
        Me.btnLowestM.UseVisualStyleBackColor = True
        '
        'btnPriderat
        '
        Me.btnPriderat.Location = New System.Drawing.Point(12, 293)
        Me.btnPriderat.Name = "btnPriderat"
        Me.btnPriderat.Size = New System.Drawing.Size(190, 64)
        Me.btnPriderat.TabIndex = 9
        Me.btnPriderat.Text = "Pride rating"
        Me.btnPriderat.UseVisualStyleBackColor = True
        '
        'frmPracEight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 369)
        Me.Controls.Add(Me.btnPriderat)
        Me.Controls.Add(Me.btnLowestM)
        Me.Controls.Add(Me.btnPrideInfo)
        Me.Controls.Add(Me.lblLions)
        Me.Controls.Add(Me.lblPride)
        Me.Controls.Add(Me.txtLion)
        Me.Controls.Add(Me.txtPride)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.GrdUIj)
        Me.Name = "frmPracEight"
        Me.Text = "National Parks Veterinarian Service"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrdUIj As UJGrid.UJGrid
    Friend WithEvents btnInit As Button
    Friend WithEvents txtPride As TextBox
    Friend WithEvents txtLion As TextBox
    Friend WithEvents lblPride As Label
    Friend WithEvents lblLions As Label
    Friend WithEvents btnPrideInfo As Button
    Friend WithEvents btnLowestM As Button
    Friend WithEvents btnPriderat As Button
End Class
