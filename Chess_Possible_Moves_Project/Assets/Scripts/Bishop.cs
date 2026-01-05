
using UnityEngine;

public class Bishop : ChessPiece
{
    private void Awake()
    {
        moveStrategy = new BishopMoveStrategy();
    }
}
