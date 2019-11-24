Public Class PictureBox
    Inherits Windows.Forms.PictureBox

    Private moCurrentWriting As New List(Of Point)

    Private moRememberInk As New List(Of List(Of Point))

    Private mbPenDown As Boolean = False

    Private Sub PictureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mbPenDown = True

    End Sub


    Private Sub PictureBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mbPenDown Then
            moCurrentWriting.Add(e.Location)
            mdLastSignatureUpdate = Now

            Me.Refresh()
        End If
    End Sub

    Private Sub PictureBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        If moCurrentWriting.Count > 2 Then
            moRememberInk.Add(moCurrentWriting)
        End If

        moCurrentWriting = New List(Of Point)
        mbPenDown = False

    End Sub


    Private Sub PictureBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint


        mRenderSignature(e.Graphics)

        Dim lsText As String = ""

        e.Graphics.DrawString(lsText, Me.Font, Brushes.Black, (Me.Width / 2) - (e.Graphics.MeasureString(lsText, Me.Font).Width / 2), (Me.Height / 2) - (e.Graphics.MeasureString(lsText, Me.Font).Height / 2))

    End Sub

    Private Sub mRenderSignature(ByVal g As Graphics)

        Using loPen As New Pen(Color.Black)

            loPen.Width = 2
            For Each loLines As List(Of Point) In moRememberInk

                g.DrawLines(loPen, loLines.ToArray)
            Next

            If moCurrentWriting.Count > 1 Then
                g.DrawLines(loPen, moCurrentWriting.ToArray)
            End If
        End Using
    End Sub

    Public Sub ClearSignature()

        moRememberInk.Clear()
        Me.Refresh()
    End Sub

    Private mdLastSignatureUpdate As Nullable(Of Date) = Nothing

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property LastSignatureUpdate() As Date
        Get

            Return mdLastSignatureUpdate

        End Get

        Set(ByVal value As Date)

            mdLastSignatureUpdate = value
        End Set
    End Property

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public ReadOnly Property SignatureImage() As Image

        Get
            Dim loBitmap As New Bitmap(Me.Width, Me.Height)

            Using loGfx As Graphics = Graphics.FromImage(loBitmap)

                mRenderSignature(loGfx)

            End Using


            Return loBitmap

        End Get

    End Property
End Class
