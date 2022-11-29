Public Class FrmvbArrayPractice
    Dim tempData As Integer() = {15, 45, 65, 85, 95}
    Private Sub btnEx1_Click(sender As Object, e As EventArgs) Handles btnEx1.Click

        Dim i As Integer
        For i = 0 To 4
            MsgBox(tempData(i))

        Next

    End Sub

    Private Sub btnEx2_Click(sender As Object, e As EventArgs) Handles btnEx2.Click

        Dim i As Integer
        Dim x As String
        For i = 0 To 4
            x = x & tempData(i) & vbNewLine
        Next
        MsgBox(x)

    End Sub

    Private Sub btnEx3_Click(sender As Object, e As EventArgs) Handles btnEx3.Click
        Dim i As Integer
        Dim x As Integer

        For i = 0 To 4
            x = x + tempData(i)
        Next

        MsgBox(x)

    End Sub

    Private Sub btnEx4_Click(sender As Object, e As EventArgs) Handles btnEx4.Click
        Dim i As Integer
        Dim x As Integer

        For i = 0 To 4
            x = x + tempData(i)
        Next

        MsgBox(x / i)
    End Sub

    Private Sub btnEx5_Click(sender As Object, e As EventArgs) Handles btnEx5.Click
        Dim i As Integer
        Dim x As Integer


        For i = 0 To 4
            If tempData(i) > 20 Then
                x = x + tempData(i)
            End If
        Next
        MsgBox(x)
    End Sub

    Private Sub btnEx6_Click(sender As Object, e As EventArgs) Handles btnEx6.Click
        Dim i As Integer
        Dim x As Integer = UBound(tempData)
        Dim dStore As Integer

        For i = 0 To 4
            If i = x Then
                dStore = tempData(i)
            End If
        Next
        MsgBox(dStore)
    End Sub

    Private Sub btnEx7_Click(sender As Object, e As EventArgs) Handles btnEx7.Click
        Dim i As Integer
        Dim x As Integer = LBound(tempData)
        Dim dStore As Integer

        For i = 0 To 4
            If i = x Then
                dStore = tempData(i)
            End If
        Next
        MsgBox(dStore)
    End Sub

    Private Sub btnEx8_Click(sender As Object, e As EventArgs) Handles btnEx8.Click
        Dim i As Integer
        Dim x As String
        For i = 0 To 4
            x = x & (tempData(i) * 2) & vbNewLine
        Next
        MsgBox(x)

    End Sub


End Class
