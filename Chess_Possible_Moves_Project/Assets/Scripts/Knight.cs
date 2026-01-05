
using UnityEngine;

public class Knight : ChessPiece
{
    private void Awake()
    {
        moveStrategy = new KnightMoveStrategy();
    }
}
