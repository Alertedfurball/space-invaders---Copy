Public Class Form1
    Dim shipploc, allenloc As Point

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown


        'move left
        If (e.KeyCode = Keys.A Or e.KeyCode = Keys.Left) And shipp.Location.X >= 5 Then
            shipploc = New Point(shipp.Location.X - 5, shipp.Location.Y)
            shipp.Location = shipploc
        End If
        'move right
        If (e.KeyCode = Keys.D Or e.KeyCode = Keys.Right) And shipp.Location.X <= Me.Width - shipp.Width - 22 Then
            shipploc = New Point(shipp.Location.X + 5, shipp.Location.Y)
            shipp.Location = shipploc
        End If
    End Sub

    Private Sub AllenTimer_Tick(sender As Object, e As EventArgs) Handles AllenTimer.Tick
        'move allen left
        If allen1.Tag = "left" Then

            allenloc = New Point(allen1.Location.X - 5, allen1.Location.Y)
            allen1.Location = allenloc
            If allen1.Left <= 5 Then 'if hit left wall



                allenloc = New Point(allen1.Location.X + 5, allen1.Location.Y + 20)
                allen1.Location = allenloc
                allen1.Tag = "right"
            End If

            'move allen right
        ElseIf allen1.Tag = "right" Then
            allen2.Tag = "right"
            allen3.Tag = "right"
            allen4.Tag = "right"
            allen5.Tag = "right"
            allen6.Tag = "right"


            allenloc = New Point(allen1.Location.X + 5, allen1.Location.Y)
            allen1.Location = allenloc
            If allen1.Right >= Me.Width - 400 Then 'if hit right wall
                allenloc = New Point(allen1.Location.X - 5, allen1.Location.Y + 20)

                allen1.Location = allenloc
                allen1.Tag = "left"
                If allen1.Tag = "left" Then
                    allen2.Tag = "left"
                    allen3.Tag = "left"
                    allen4.Tag = "left"
                    allen5.Tag = "left"
                    allen6.Tag = "left"

                End If
            End If
        End If
        'move allen left
        If allen2.Tag = "left" Then
            allenloc = New Point(allen2.Location.X - 5, allen2.Location.Y)
            allen2.Location = allenloc
            If allen1.Left <= 5 Then 'if hit left wall

                allenloc = New Point(allen2.Location.X + 5, allen2.Location.Y + 20)
                allen2.Location = allenloc

            End If

            'move allen right
        ElseIf allen2.Tag = "right" Then
            allenloc = New Point(allen2.Location.X + 5, allen2.Location.Y)
            allen2.Location = allenloc
            If allen1.Right >= Me.Width - 50 Then 'if hit right wall
                allenloc = New Point(allen2.Location.X - 5, allen2.Location.Y + 20)

                allen2.Location = allenloc

            End If
        End If
        'move allen left
        If allen3.Tag = "left" Then
            allenloc = New Point(allen3.Location.X - 5, allen3.Location.Y)
            allen3.Location = allenloc
            If allen1.Left <= 5 Then 'if hit left wall

                allenloc = New Point(allen3.Location.X + 5, allen3.Location.Y + 20)
                allen3.Location = allenloc

            End If

            'move allen right
        ElseIf allen3.Tag = "right" Then
            allenloc = New Point(allen3.Location.X + 5, allen3.Location.Y)
            allen3.Location = allenloc
            If allen1.Right >= Me.Width - 50 Then 'if hit right wall
                allenloc = New Point(allen3.Location.X - 5, allen3.Location.Y + 20)

                allen3.Location = allenloc

            End If
        End If
        'move allen left
        If allen4.Tag = "left" Then
            allenloc = New Point(allen4.Location.X - 5, allen4.Location.Y)
            allen4.Location = allenloc
            If allen1.Left <= 5 Then 'if hit left wall

                allenloc = New Point(allen4.Location.X + 5, allen4.Location.Y + 20)
                allen4.Location = allenloc

            End If

            'move allen right
        ElseIf allen4.Tag = "right" Then
            allenloc = New Point(allen4.Location.X + 5, allen4.Location.Y)
            allen4.Location = allenloc
            If allen1.Right >= Me.Width - 50 Then 'if hit right wall
                allenloc = New Point(allen4.Location.X - 5, allen4.Location.Y + 20)

                allen4.Location = allenloc

            End If
        End If
        'move allen left
        If allen5.Tag = "left" Then
            allenloc = New Point(allen5.Location.X - 5, allen5.Location.Y)
            allen5.Location = allenloc
            If allen1.Left <= 5 Then 'if hit left wall

                allenloc = New Point(allen5.Location.X + 5, allen5.Location.Y + 20)
                allen5.Location = allenloc

            End If

            'move allen right
        ElseIf allen5.Tag = "right" Then
            allenloc = New Point(allen5.Location.X + 5, allen5.Location.Y)
            allen5.Location = allenloc
            If allen1.Right >= Me.Width - 50 Then 'if hit right wall
                allenloc = New Point(allen5.Location.X - 5, allen5.Location.Y + 20)

                allen5.Location = allenloc

            End If
        End If

        Dim point As Point = New Point(allen6.Location.X - 5, allen6.Location.Y)
        'move allen left
        If allen6.Tag = "left" Then
            allenloc = New Point(allen6.Location.X - 5, allen6.Location.Y)
            allen6.Location = allenloc
            If allen6.Left <= 5 Then 'if hit left wall

                allenloc = New Point(allen6.Location.X + 5, allen6.Location.Y + 20)
                allen6.Location = allenloc
                allen6.Tag = "right"
            End If

            'move allen right
        ElseIf allen6.Tag = "right" Then
            allenloc = New Point(allen6.Location.X + 5, allen6.Location.Y)
            allen6.Location = allenloc
            If allen6.Right >= Me.Width Then 'if hit right wall
                allenloc = point

                allen6.Location = allenloc
                allen6.Tag = "left"
            End If
        End If
    End Sub
End Class
