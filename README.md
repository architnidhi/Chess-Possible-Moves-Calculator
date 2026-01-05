# Chess Possible Moves Calculator (Unity)

## Project Overview
The Chess Possible Moves Calculator is a Unity-based logic project that calculates and highlights all valid legal moves for a selected chess piece on a standard 8×8 chessboard. The project focuses on clean coding practices, object-oriented design, and maintainable architecture rather than UI or animations.

## Objective
The primary goal of this project is to demonstrate:
- Strong OOP principles
- Proper use of design patterns
- Clean, readable, and extensible code structure

## Key Features
- Highlights all possible legal moves when a chess piece is selected
- Uses provided helper methods for board interaction
- Initial piece positions configurable via Inspector
- Minimal UI to keep focus on logic

## Implemented Chess Pieces
- Rook
- Bishop
- Knight

The architecture allows easy extension for Queen, King, Pawn, and enemy capture logic.

## Design & Architecture
- `ChessPiece` (abstract base class)
- `IChessMoveStrategy` (Strategy Pattern interface)
- Separate move calculation strategies for each piece
- Clear separation of responsibilities

## Notes
- Movement execution is intentionally not implemented
- E
