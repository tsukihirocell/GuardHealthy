Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class CirclePictureBox
    Inherits PictureBox

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        ' Adjust the region to a circular shape based on the current size
        UpdateCircleRegion()
    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)

        ' Apply smoothing for smooth edges
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
    End Sub

    Private Sub UpdateCircleRegion()
        If Me.Width > 0 AndAlso Me.Height > 0 Then
            ' Create a circular region
            Dim circlePath As New GraphicsPath()
            circlePath.AddEllipse(0, 0, Me.Width, Me.Height)
            Me.Region = New Region(circlePath)
        End If
    End Sub
End Class
