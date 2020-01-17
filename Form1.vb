Public Class Form1
    Dim Second As Int32 = -1

    Private Sub marindoSevenSegment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBasE.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, q As EventArgs) Handles Timer1.Tick
        Second = Second + 1
        If (Second = 1) Then
            A.BackColor = Color.Gray
            B.BackColor = Color.Gold
            C.BackColor = Color.Gold
            D.BackColor = Color.Gray
            E.BackColor = Color.Gray
            F.BackColor = Color.Gray
            G.BackColor = Color.Gray
        ElseIf (Second = 2) Then
            A.BackColor = Color.Gold
            B.BackColor = Color.Gold
            C.BackColor = Color.Gray
            D.BackColor = Color.Gold
            E.BackColor = Color.Gold
            F.BackColor = Color.Gray
            G.BackColor = Color.Gold

        ElseIf (Second = 3) Then
            A.BackColor = Color.Gold
            B.BackColor = Color.Gold
            C.BackColor = Color.Gold
            D.BackColor = Color.Gold
            E.BackColor = Color.Gray
            F.BackColor = Color.Gray
            G.BackColor = Color.Gold

        ElseIf (Second = 4) Then
            A.BackColor = Color.Gray
            B.BackColor = Color.Gold
            C.BackColor = Color.Gold
            D.BackColor = Color.Gray
            E.BackColor = Color.Gray
            F.BackColor = Color.Gold
            G.BackColor = Color.Gold

        ElseIf (Second = 5) Then
            A.BackColor = Color.Gold
            B.BackColor = Color.Gray
            C.BackColor = Color.Gold
            D.BackColor = Color.Gold
            E.BackColor = Color.Gray
            F.BackColor = Color.Gold
            G.BackColor = Color.Gold

        ElseIf (Second = 6) Then
            A.BackColor = Color.Gold
            B.BackColor = Color.Gray
            C.BackColor = Color.Gold
            D.BackColor = Color.Gold
            E.BackColor = Color.Gold
            F.BackColor = Color.Gold
            G.BackColor = Color.Gold

        ElseIf (Second = 7) Then
            A.BackColor = Color.Gold
            B.BackColor = Color.Gold
            C.BackColor = Color.Gold
            D.BackColor = Color.Gray
            E.BackColor = Color.Gray
            F.BackColor = Color.Gray
            G.BackColor = Color.Gray

        ElseIf (Second = 8) Then
            A.BackColor = Color.Gold
            B.BackColor = Color.Gold
            C.BackColor = Color.Gold
            D.BackColor = Color.Gold
            E.BackColor = Color.Gold
            F.BackColor = Color.Gold
            G.BackColor = Color.Gold

        ElseIf (Second = 9) Then
            A.BackColor = Color.Gold
            B.BackColor = Color.Gold
            C.BackColor = Color.Gold
            D.BackColor = Color.Gold
            E.BackColor = Color.Gray
            F.BackColor = Color.Gold
            G.BackColor = Color.Gold

        Else
            A.BackColor = Color.Gold
            B.BackColor = Color.Gold
            C.BackColor = Color.Gold
            D.BackColor = Color.Gold
            E.BackColor = Color.Gold
            F.BackColor = Color.Gold
            G.BackColor = Color.Gray
            Second = 0
        End If

    End Sub
End Class