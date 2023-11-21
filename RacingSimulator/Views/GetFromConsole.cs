﻿using RacingSimulator.Models;

namespace RacingSimulator.Views;

public partial class Menu
{
    private static int GetRaceTypeFromConsole()
    {
        int raceType;
        bool isRaceTypeValid;

        do
        {
            Console.WriteLine("Выберите желаемый тип гонки (введите цифру):\n1. Наземная;\n2. Воздушная;\n3. Для всех.");
            isRaceTypeValid = int.TryParse(Console.ReadLine(), out raceType);

            if (!Enum.IsDefined(typeof(RaceTypeEnum), raceType) || !isRaceTypeValid)
            {
                isRaceTypeValid = false;
                ShowErrorMessage("Тип гонки не найден!");
            }
        } while (!isRaceTypeValid);

        return raceType;
    }

    private static int GetDistanceFromConsole()
    {
        int distance;
        bool isParseDistanceValid;

        do
        {
            Console.WriteLine("Введите дистанцию гонки:");
            isParseDistanceValid = int.TryParse(Console.ReadLine(), out distance);
            if (!isParseDistanceValid)
            {
                ShowErrorMessage("Неверно указана дистанция!");
            }
        } while (!isParseDistanceValid);

        return distance;
    }
}