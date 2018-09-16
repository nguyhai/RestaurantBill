<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurantBill
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPizza = New System.Windows.Forms.TextBox()
        Me.txtFries = New System.Windows.Forms.TextBox()
        Me.txtDrinks = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How man pizza slices"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "How many fries"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "How many soft drinks"
        '
        'txtPizza
        '
        Me.txtPizza.Location = New System.Drawing.Point(178, 27)
        Me.txtPizza.Name = "txtPizza"
        Me.txtPizza.Size = New System.Drawing.Size(56, 20)
        Me.txtPizza.TabIndex = 3
        '
        'txtFries
        '
        Me.txtFries.Location = New System.Drawing.Point(178, 58)
        Me.txtFries.Name = "txtFries"
        Me.txtFries.Size = New System.Drawing.Size(56, 20)
        Me.txtFries.TabIndex = 4
        '
        'txtDrinks
        '
        Me.txtDrinks.Location = New System.Drawing.Point(178, 91)
        Me.txtDrinks.Name = "txtDrinks"
        Me.txtDrinks.Size = New System.Drawing.Size(56, 20)
        Me.txtDrinks.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(266, 24)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(92, 86)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate Total Cost"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(25, 136)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(333, 147)
        Me.lstDisplay.TabIndex = 7
        '
        'frmRestaurantBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 297)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtDrinks)
        Me.Controls.Add(Me.txtFries)
        Me.Controls.Add(Me.txtPizza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRestaurantBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPizza As TextBox
    Friend WithEvents txtFries As TextBox
    Friend WithEvents txtDrinks As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lstDisplay As ListBox
End Class
