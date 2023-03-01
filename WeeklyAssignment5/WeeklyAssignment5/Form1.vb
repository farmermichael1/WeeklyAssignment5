Public Class WeeklyAssignment5
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Private Sub clear()
        lbCost.Text = ""
        txtSize.Text = ""
        rbtnSuper.Checked = True
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const superHero As Decimal = 380D
        Const autoGraph As Decimal = 275D
        Const con As Decimal = 209D
        Dim groupSize As Integer
        Dim amount As Decimal
        lbCost.Text = ""
        If IsNumeric(txtSize.Text) Then
            groupSize = Convert.ToInt32(txtSize.Text)
            If groupSize >= 1 And groupSize <= 20 Then
                If rbtnSuper.Checked Then
                    amount = groupSize * superHero
                ElseIf rbtnAuto.Checked Then
                    amount = groupSize * autoGraph
                ElseIf rbtnCon.Checked Then
                    amount = groupSize * con
                End If
                lbCost.Text = FormatCurrency(amount.ToString())
            Else
                MsgBox("Enter Value Between 1-20", 0)
            End If
        Else
            MsgBox("Non Numeric Value", 0)
        End If
    End Sub
End Class
