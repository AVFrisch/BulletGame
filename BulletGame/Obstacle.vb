﻿Public Class Obstacle
    Inherits Piece
    'Standard obstacle that takes two standard bullets to be destroyed

    Overrides Property Sym As Char = "+"c

    Public Overridable Property Health As Integer

    Public Sub New()

        MyBase.New()
        Health = 100

    End Sub

    Public Function Hit(ByVal pDamage As Integer) As Boolean

        Health -= pDamage

        'Changes shape when damaged
        Sym = "*"c

        If Health <= 0 Then
            Return 1
        End If

        Return 0

    End Function



End Class
