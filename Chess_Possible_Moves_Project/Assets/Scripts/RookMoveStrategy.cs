
public class RookMoveStrategy : IChessMoveStrategy
{
    public void CalculateMoves(ChessPiece piece)
    {
        int r = piece.Row;
        int c = piece.Column;

        for (int i = r + 1; i < 8; i++) ChessBoardPlacementHandler.Instance.Highlight(i, c);
        for (int i = r - 1; i >= 0; i--) ChessBoardPlacementHandler.Instance.Highlight(i, c);
        for (int j = c + 1; j < 8; j++) ChessBoardPlacementHandler.Instance.Highlight(r, j);
        for (int j = c - 1; j >= 0; j--) ChessBoardPlacementHandler.Instance.Highlight(r, j);
    }
}
