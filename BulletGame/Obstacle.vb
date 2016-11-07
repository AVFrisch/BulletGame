Public Class Obstacle
    Inherits Piece

    Overrides Property Sym As Char = "+"c

    Public Property Health As Integer

    Public Sub New()

        MyBase.New()
        Health = 100

    End Sub

    Public Sub Hit(ByVal pDamage As Integer)

        Health -= pDamage

        If Health <= 0 Then
            'make ded
        End If

    End Sub



End Class
