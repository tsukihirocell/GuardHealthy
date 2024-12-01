Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class RoundedPanel
    Inherits Panel

    <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer,
                                               ByVal nRightRect As Integer, ByVal nBottomRect As Integer,
                                               ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    Private _cornerRadius As Integer = 20

    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Me.Invalidate() ' Redraw the panel to apply changes
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, Me.Width, Me.Height, _cornerRadius, _cornerRadius)
        Me.Region = Region.FromHrgn(regionHandle)
        ' Cleanup the region handle
        If regionHandle <> IntPtr.Zero Then
            DeleteObject(regionHandle)
        End If
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate() ' Ensure the rounding is maintained on resize
    End Sub

    <DllImport("gdi32.dll", EntryPoint:="DeleteObject")>
    Private Shared Function DeleteObject(hObject As IntPtr) As Boolean
    End Function
End Class

