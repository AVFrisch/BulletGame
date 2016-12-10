Public Class Player
    Inherits Piece
    'Piece designated for the player character

    Overrides Property Sym As Char = Settings.chrPlayer

    Public Sub RefreshChar()
        Sym = Settings.chrPlayer
    End Sub

End Class
