
public class KnightMoveStrategy : IChessMoveStrategy
{
    private readonly int[,] moves = {
        {2,1},{2,-1},{-2,1},{-2,-1},
        {1,2},{1,-2},{-1,2},{-1,-2}
    };

    public void CalculateMoves(ChessPiece piece)
    {
        for (int i = 0; i < moves.GetLength(0); i++)
        {
            int r = piece.Row + moves[i,0];
            int c = piece.Column + moves[i,1];
            if (r >= 0 && r < 8 && c >= 0 && c < 8)
                ChessBoardPlacementHandler.Instance.Highlight(r, c);
        }
    }
}
