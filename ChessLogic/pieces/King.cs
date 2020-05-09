﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessLogic.pieces
{
    class King : Piece
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="coords">piece startcoords</param>
        /// <param name="pieces">list of other pieces</param>
        /// <param name="color">piece color</param>
        public King(Point coords, Game board, bool color) : base(coords, board, color)
        {
            pieceName = "King";
        }
        /// <summary>
        /// return list of possible moves
        /// </summary>
        /// <returns></returns>
        public override List<Point> PossibleMoves()
        {
            List<Point> tmp = new List<Point>();

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (!(i == 0 && j == 0) && !other.TryGetPiece(position + new Point(i, j), out bool color, out string piece))
                    {
                        tmp.Add(position + new Point(i, j));
                    }
                }
            }

            return tmp;
        }
    }
}