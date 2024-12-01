Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class CirclePanel
    Inherits Panel

    <DllImport("gdi32.dll", EntryPoint:="CreateEllipticRgn")>
    Private Shared Function CreateEllipticRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer,
                                              ByVal nRightRect As Integer, ByVal nBottomRect As Integer) As IntPtr
    End Function

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim regionHandle As IntPtr = CreateEllipticRgn(0, 0, Me.Width, Me.Height)
        Me.Region = Region.FromHrgn(regionHandle)
        If regionHandle <> IntPtr.Zero Then
            DeleteObject(regionHandle)
        End If
    End Sub

    <DllImport("gdi32.dll", EntryPoint:="DeleteObject")>
    Private Shared Function DeleteObject(hObject As IntPtr) As Boolean
    End Function
End Class
Public Class Class4

End Class
