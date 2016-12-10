Public Class Player
    Inherits Piece

    Overrides Property Sym As Char = Settings.chrPlayer

    Public Sub RefreshChar()
        Sym = Settings.chrPlayer
    End Sub

End Class
