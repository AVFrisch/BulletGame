Public MustInherit Class Bullet
    Inherits Piece
    'Base class for all bullets

    Overrides Property Sym As Char = "^"c

    Public MustOverride Property Damage As Integer

    Public Sub New()

        MyBase.New()
        Damage = 50

    End Sub


End Class
