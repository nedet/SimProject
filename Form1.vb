Public Class Form1


    Dim x(7, 3) As Integer
    Dim y(7, 7) As Integer
    Dim Vy(7) As Integer
    Dim Vx(7) As Integer
    Dim bc, PixelColor As Color



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bc = Me.BackColor
        For f As Integer = 1 To 7
            x(f, 3) = 10
            x(f, 2) = 20
            x(f, 1) = 30
            x(f, 0) = 40
        Next
        For L As Integer = 0 To 4
            y(1, L) = 180
            y(2, L) = 200
            y(3, L) = 220
            y(4, L) = 240
            y(5, L) = 260
            y(6, L) = 280
            y(7, L) = 300
        Next
        Vy(1) = -0
        Vy(2) = -0
        Vy(3) = -0
        Vy(4) = 0
        Vy(5) = 0
        Vy(6) = 0
        Vy(7) = 0
        Vx(1) = 10
        Vx(2) = 10
        Vx(3) = 10
        Vx(4) = 10
        Vx(5) = 10
        Vx(6) = 10
        Vx(7) = 10

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tmrA.Start() 'starts timer


    End Sub

    Private Sub tmrA_Tick(sender As Object, e As EventArgs) Handles tmrA.Tick
        Dim penA As New Pen(bc)
        With PicA.CreateGraphics
            For K As Integer = 0 To 3
                ' draws dot that goes across pic box
                .DrawEllipse(Pens.Black, x(1, K), y(1, K), 2, 2)
                .DrawEllipse(Pens.Black, x(2, K), y(2, K), 2, 2)
                .DrawEllipse(Pens.Black, x(3, K), y(3, K), 2, 2)
                .DrawEllipse(Pens.Black, x(4, K), y(4, K), 2, 2)
                .DrawEllipse(Pens.Black, x(5, K), y(5, K), 2, 2)
                .DrawEllipse(Pens.Black, x(6, K), y(6, K), 2, 2)
                .DrawEllipse(Pens.Black, x(7, K), y(7, K), 2, 2)

            Next
            For j As Integer = 1 To 7
                .DrawEllipse(penA, x(j, 3), y(j, 3), 2, 2) 'covers last dots
            Next

            For M As Integer = 1 To 7
                x(M, 3) = x(M, 2)
                x(M, 2) = x(M, 1)
                x(M, 1) = x(M, 0)
                x(M, 0) += Vx(M)
                y(M, 3) = y(M, 2) ' makes lines curve 
                y(M, 2) = y(M, 1)
                y(M, 1) = y(M, 0)
                y(M, 0) += Vy(M)

                If x(M, 0) > Me.Width Then
                    x(M, 0) = 0
                End If

            Next M

            Dim Pict1 As Object


            ' the color is obtained from the top left (bx,by) of the picture

            Pict1 = PicA.Image
            For C As Integer = 1 To 7
                PixelColor = Pict1.getpixel(x(C, 0), y(C, 0))    'usual case gets actual color
                If PixelColor.ToArgb = Color.Black.ToArgb Then
                    Label1.Text = "black"
                    Vx(C) *= -1
                    If x(C, 0) < 45 Then
                        Vx(C) *= -1
                    End If
                End If
            Next


            If RadSQ.Checked = True Then
                PicA.CreateGraphics.DrawEllipse(penA, 310, 200, 80, 80)         'erases other object and draws new object
                PicA.CreateGraphics.DrawRectangle(Pens.Red, 310, 200, 80, 80)
            ElseIf radCir.Checked = True Then
                PicA.CreateGraphics.DrawRectangle(penA, 310, 200, 80, 80)
                PicA.CreateGraphics.DrawEllipse(Pens.Red, 310, 200, 80, 80)
            End If







        End With
    End Sub



    Private Sub Btnstop_Click(sender As Object, e As EventArgs) Handles Btnstop.Click
        tmrA.Stop() 'stops timer

    End Sub
End Class
