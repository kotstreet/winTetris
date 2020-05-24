﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinTetris.Records;

public static class RecordHandler
{
    /// <summary>
    /// Get string with players records
    /// </summary>
    /// <param name="players">players for build string</param>
    /// <returns>string with ordered players reocords</returns>
    public static string GetRecords(List<Player> players)
    {
        var position = 0;
        StringBuilder sb = new StringBuilder();

        players.OrderByDescending(player => player.Score).ThenBy(player => player.Name).ToList().ForEach(player =>
        {
            //get length
            var nameLength = player.Name.Length;

            //get separator
            var separator = CreateSeparator(nameLength);

            //add string tu result
            var record = String.Format(Constants.TextForARecord, ++position, player.Name, separator, player.Score);
            sb.AppendLine(record);
        });

        return sb.ToString();
    }

    /// <summary>
    /// Create seporator string 
    /// </summary>
    /// <param name="nameLength">length of player name</param>
    /// <returns>separator string</returns>
    private static string CreateSeparator(int nameLength)
    {
        var separatorCount = Constants.MaxLengthForRecordString - Constants.PositionLengthForRecordString
           - Constants.SpacesLengthForRecordString - nameLength - Constants.ScoreLengthForRecordString;

        return new String(Constants.Separator, separatorCount);
    }

    /// <summary>
    /// get name, creeate new player and add the one into database if it needed
    /// </summary>
    /// <param name="currentScore">current score for add new record</param>
    public static void AddRecord(int currentScore)
    {
        //check for need save record
        var isentered = WorkWithRecords.IsEntered(currentScore);
        if (isentered == false)
        {
            return;
        }

        //get name of player and create a new one
        var form = new frmInputName();
        var result = form.ShowDialog();

        var name = result == DialogResult.OK ? form.textBox1.Text : String.Empty;
        var player = new Player();
        player.Name = name;
        player.Score = currentScore;

        //add player into database
        WorkWithRecords.AddPlayer(player);
    }
}
