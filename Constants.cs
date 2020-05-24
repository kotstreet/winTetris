using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Constants
{
    //for save setting
    public const string PathOfSettingFile = "Settings.txt";

    //sefault settings 
    public const int DefaultDeep = 20;
    public const int DefaultWidth = 10;
    public const int DefaultSpeed = 240;

    //size of rectangle
    public const int SizeInPixeles = 15;

    //for check name length
    public const string MessageAbouteIncorrectNameLength = "Введённо вами имя слишком длинное(максимум {0} символов)";
    public const int MaxLengthForName = 25;

    //for print records
    public const int MaxLengthForRecordString = 40;
    public const int SpacesLengthForRecordString = 2;
    public const int ScoreLengthForRecordString = 5;
    public const int PositionLengthForRecordString = 3;

    public const string TextForARecord = "{0:d2}.{1} {2} {3:d5}";
    public const char Separator = '_';

    public const int MaxRecords = 15;

    //for find interval by speed
    public const double MilisecondsInAMinute = 60000;

    //for increace score
    public const int PointsForARow = 10;
    public const int PointsForTetris = 100;

    //for generate figures
    public const int GeneratedValueForS = 1;
    public const int GeneratedValueForZ = 2;
    public const int GeneratedValueForT = 3;
    public const int GeneratedValueForO = 4;
    public const int GeneratedValueForJ = 6;
    public const int GeneratedValueForL = 5;
    public const int GeneratedValueForI = 7;

    //for pause
    public const string StatusGamePause = "Пауза";
    public const string StatusGamePlay = "Начать";
    public const string TextForContinueGame= "Для продолжения нажмите ОК";

    //for exit game
    public const string ExitGameCaption = "Подтвердите действие";
    public const string ExitGameText = "Вы уверены, что хотите выйти из игры?";
}