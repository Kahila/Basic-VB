<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkakespear
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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnTTincome = New System.Windows.Forms.Button()
        Me.btnIndex = New System.Windows.Forms.Button()
        Me.GrdUj = New UJGrid.UJGrid()
        Me.txtTrend = New System.Windows.Forms.TextBox()
        Me.lblTrend = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(16, 15)
        Me.btnInit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(248, 70)
        Me.btnInit.TabIndex = 0
        Me.btnInit.Text = "Initioalize"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(16, 96)
        Me.btnInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(248, 70)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Enter information"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnTTincome
        '
        Me.btnTTincome.Location = New System.Drawing.Point(16, 170)
        Me.btnTTincome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTTincome.Name = "btnTTincome"
        Me.btnTTincome.Size = New System.Drawing.Size(248, 62)
        Me.btnTTincome.TabIndex = 2
        Me.btnTTincome.Text = "View total ticket income"
        Me.btnTTincome.UseVisualStyleBackColor = True
        '
        'btnIndex
        '
        Me.btnIndex.Location = New System.Drawing.Point(16, 239)
        Me.btnIndex.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnIndex.Name = "btnIndex"
        Me.btnIndex.Size = New System.Drawing.Size(248, 64)
        Me.btnIndex.TabIndex = 3
        Me.btnIndex.Text = "View index"
        Me.btnIndex.UseVisualStyleBackColor = True
        '
        'GrdUj
        '
        Me.GrdUj.FixedCols = 1
        Me.GrdUj.FixedRows = 1
        Me.GrdUj.Location = New System.Drawing.Point(272, 15)
        Me.GrdUj.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GrdUj.Name = "GrdUj"
        Me.GrdUj.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.GrdUj.Size = New System.Drawing.Size(517, 320)
        Me.GrdUj.TabIndex = 4
        '
        'txtTrend
        '
        Me.txtTrend.Location = New System.Drawing.Point(155, 310)
        Me.txtTrend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTrend.Name = "txtTrend"
        Me.txtTrend.ReadOnly = True
        Me.txtTrend.Size = New System.Drawing.Size(108, 22)
        Me.txtTrend.TabIndex = 5
        '
        'lblTrend
        '
        Me.lblTrend.AutoSize = True
        Me.lblTrend.Location = New System.Drawing.Point(12, 310)
        Me.lblTrend.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTrend.Name = "lblTrend"
        Me.lblTrend.Size = New System.Drawing.Size(136, 17)
        Me.lblTrend.TabIndex = 6
        Me.lblTrend.Text = "Are sales increasing"
        '
        'frmSkakespear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 345)
        Me.Controls.Add(Me.lblTrend)
        Me.Controls.Add(Me.txtTrend)
        Me.Controls.Add(Me.GrdUj)
        Me.Controls.Add(Me.btnIndex)
        Me.Controls.Add(Me.btnTTincome)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnInit)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSkakespear"
        Me.Text = "Shake your spear ;)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInit As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents btnTTincome As Button
    Friend WithEvents btnIndex As Button
    Friend WithEvents GrdUj As UJGrid.UJGrid
    Friend WithEvents txtTrend As TextBox
    Friend WithEvents lblTrend As Label
End Class
