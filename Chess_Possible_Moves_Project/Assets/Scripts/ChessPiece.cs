
using UnityEngine;

public abstract class ChessPiece : MonoBehaviour
{
    [Range(0,7)] public int Row;
    [Range(0,7)] public int Column;
    public bool IsWhite = true;

    protected IChessMoveStrategy moveStrategy;

    protected virtual void Start()
    {
        ChessBoardPlacementHandler.Instance.ClearHighlights();
    }

    private void OnMouseDown()
    {
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        moveStrategy.CalculateMoves(this);
    }
}
