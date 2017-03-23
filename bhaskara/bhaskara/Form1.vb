Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CalcButton1.Click
        x1.Text = bhaskara(axT.Text, bxT.Text, cT.Text, 1)
        x2.Text = bhaskara(axT.Text, bxT.Text, cT.Text, 2)
        dT.Text = bhaskara(axT.Text, bxT.Text, cT.Text, 3)
    End Sub
    Function bhaskara(ByVal ax As Double, ByVal bx As Double, ByVal c As Double, ByVal xType As Int16)
        Dim x1 As Double ''First X
        Dim x2 As Double ''Second X
        Dim ret As Double = 0 'Return x1, x2 or delta
        x1 = (Math.Sqrt(Delta(ax, bx, c)) - bx) / (2 * ax) ''Calculate First X
        x2 = (0 - Math.Sqrt(Delta(ax, bx, c)) - bx) / (2 * ax) ''Calculate Second X
        If xType = 1 Then
            ret = x1
        ElseIf xType = 2 Then
            ret = x2
        ElseIf xType = 3 Then
            ret = Delta(ax, bx, c)
        End If
        Return ret
    End Function
    Function Delta(ByVal ax As Double, ByVal bx As Double, ByVal c As Double)
        Dim deltaF As Double
        deltaF = QTwoX(bx) + ((-4) * ax * c) 'calculate delta
        Return deltaF '' Return Delta
    End Function

    Function QTwoX(ByVal x As String) ''X Squared
        Return x * x
    End Function
End Class
