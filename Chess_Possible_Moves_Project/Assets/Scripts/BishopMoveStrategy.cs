
public class BishopMoveStrategy : IChessMoveStrategy
{
    public void CalculateMoves(ChessPiece piece)
    {
        int r = piece.Row;
        int c = piece.Column;

        for (int i = 1; i < 8; i++)
        {
            if (r+i < 8 && c+i < 8) ChessBoardPlacementHandler.Instance.Highlight(r+i, c+i);
            if (r-i >= 0 && c-i >= 0) ChessBoardPlacementHandler.Instance.Highlight(r-i, c-i);
            if (r+i < 8 && c-i >= 0) ChessBoardPlacementHandler.Instance.Highlight(r+i, c-i);
            if (r-i >= 0 && c+i < 8) ChessBoardPlacementHandler.Instance.Highlight(r-i, c+i);
        }
    }
}
