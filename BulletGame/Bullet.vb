Public MustInherit Class Bullet
    Inherits Piece

    Overrides Property Sym As Char = "^"c

    Public MustOverride Property Damage As Integer

    Public Sub New()

        MyBase.New()
        Damage = 50

    End Sub


End Class
