﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class Game
{
    public delegate void ShowGameElements();
    public delegate void EndOfGame();
    public delegate void ShowScoreAndLines(int score, int lines);

    public event EndOfGame OnEndOfGame;
    public event ShowGameElements ChangedGameField;
    public event ShowGameElements ChangedNextFigure;
    public event ShowScoreAndLines ChangedScoreAndLines;

    private int _startColumn;
    private int _score = 0;
    private int _lines = 0;

    public TypeOfCell[,] GameField { get; private set; }
    public Figure CurrentFigure { get; private set; }
    public Figure NextFigure { get; private set; }
    public int Width { get; private set; }
    public int Deep { get; private set; }
    public int Interval { get; private set; }

    public Game()
    {
        var settings = WorkWithSettings.GetSettings();

        Deep = settings.deep;
        Width = settings.width;
        Interval = Convert.ToInt32(Math.Round(Constants.MilisecondsInAMinute / settings.speed));

        GameField = new TypeOfCell[Deep, Width];
        _startColumn = Convert.ToInt32(Math.Round((double)Width / 2) - 1);
    }

    /// <summary>
    /// Create first figures couple and show them
    /// </summary>
    public void Start()
    {
        NextFigure = FigureGenerator.Generate(_startColumn);
        Thread.Sleep(25); //because computer generate two the same figure without it
        CurrentFigure = FigureGenerator.Generate(_startColumn);

        CurrentFigure.ChangeFigurePosition += InvokeRefresh;

        //invoke 
        ChangedGameField.Invoke();
        ChangedNextFigure.Invoke();
    }

    /// <summary>
    /// move figure downm generate new one and finish the game
    /// </summary>
    public void MoveFigureDown()
    {
        //move figure down by one
        var isFall = CurrentFigure.MoveDown(GameField);
        if (isFall == false)
        {
            //fill the field with the current figure
            foreach(var point in CurrentFigure.Position)
            {
                GameField[point.Y, point.X] = CurrentFigure.TypeOfCell;
            }

            //check for fill rows
            CheckForFilledRows();

            //change next and current figures, show it
            CurrentFigure = NextFigure;
            CurrentFigure.ChangeFigurePosition += InvokeRefresh;
            NextFigure = FigureGenerator.Generate(_startColumn);

            ChangedNextFigure.Invoke();
            ChangedGameField.Invoke();

            //check for end of game(can't insert figure in game field)
            var isEnd = CurrentFigure.IsCorrect(GameField);
            if(isEnd == false)
            {
                OnEndOfGame.Invoke();
            }
        }
        
        ChangedGameField.Invoke();
    }

    /// <summary>
    /// check on filled rows and refill game field
    /// </summary>
    private void CheckForFilledRows()
    {
        var filledRows = FindFilledRows();

        //find count of filled rows and exit if not any row was filled
        var countOfFilledRow = filledRows.Count(row => row != -1);
        if (countOfFilledRow == 0)
        {
            return;
        }

        RefreshGameFieldAfterFilledRows(filledRows, countOfFilledRow);
        AddScoreAndLines(countOfFilledRow);
    }

    /// <summary>
    /// Add score and lines count
    /// </summary>
    /// <param name="countOfFilledRow">count of filled row in the game filed</param>
    private void AddScoreAndLines(int countOfFilledRow)
    {
        _lines += countOfFilledRow;
        _score += countOfFilledRow == 4 ? Constants.PointsForTetris : countOfFilledRow * Constants.PointsForARow;
        ChangedScoreAndLines.Invoke(_score, _lines);
    }

    /// <summary>
    /// find indexes of filled rows
    /// </summary>
    /// <returns>array of filled rows indexes</returns>
    private int[] FindFilledRows()
    {
        var filledRow = new int[4] { -1, -1, -1, -1 };
        var index = 0;

        for (int row = Deep - 1; row > 0; row--)
        {
            var isFilled = true;
            var isEmpty = true;

            for (int column = 0; column < Width; column++)
            {
                //check for filled row
                if (GameField[row, column] == TypeOfCell.Empty)
                {
                    isFilled = false;
                }

                //check for empty row
                if (GameField[row, column] < TypeOfCell.Static)
                {
                    isEmpty = false;
                }
            }

            //reset data aboute filled rows
            if (isFilled)
            {
                filledRow[index++] = row;
            }

            //exit if we will not can meet filled row
            if (isEmpty || (filledRow[0] - 3 >= row && filledRow[0] >= 0))
            {
                return filledRow;
            }
        }

        return filledRow;
    }

    /// <summary>
    /// refill game field after filled some rows
    /// </summary>
    /// <param name="filledRows">indexes of filled rows</param>
    /// <param name="countOfFilledRow">count of filled rows</param>
    private void RefreshGameFieldAfterFilledRows(int[] filledRows, int countOfFilledRow)
    {
        var shift = 1;
        var index = 0;

        //shift all rows from the first filled to top end of fields
        for (int row = filledRows[index]; row >= countOfFilledRow; row--)
        {
            //check for skip if the next row is filled
            while (index != 3 && filledRows[index + 1] == row - shift)
            {
                //inc shift 
                if (filledRows[index + 1] == row - shift)
                {
                    index++;
                    shift++;
                }
            }

            //shift
            for (int column = 0; column < Width; column++)
            {
                GameField[row, column] = GameField[row - shift, column];
            }
        }

        AddEmptyRowToTheTop(countOfFilledRow);
    }

    /// <summary>
    /// fill top of game field with empty rows
    /// </summary>
    /// <param name="countOfFilledRow">count of needed rows</param>
    private void AddEmptyRowToTheTop(int countOfFilledRow)
    {
        for (int row = 0; row < countOfFilledRow; row++)
        {
            for (int column = 0; column < Width; column++)
            {
                GameField[row, column] = TypeOfCell.Empty;
            }
        }
    }

    public void InvokeRefresh() => ChangedGameField.Invoke();
}