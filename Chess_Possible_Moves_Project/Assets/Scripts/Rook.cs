
using UnityEngine;

public class Rook : ChessPiece
{
    private void Awake()
    {
        moveStrategy = new RookMoveStrategy();
    }
}
