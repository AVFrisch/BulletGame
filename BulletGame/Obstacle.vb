Public Class Obstacle
    Inherits Piece

    Overrides Property Sym As Char = "+"c

    Public Overridable Property Health As Integer

    Public Sub New()

        MyBase.New()
        Health = 100

    End Sub

    Public Function Hit(ByVal pDamage As Integer) As Boolean

        Health -= pDamage

        Sym = "*"c

        If Health <= 0 Then
            Return 1
        End If

        Return 0

    End Function



End Class
