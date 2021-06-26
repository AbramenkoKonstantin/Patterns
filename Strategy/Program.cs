using System;

/// <summary>
/// Тип - поведенческий
/// 
/// Описание - переносит семейство алгоритмов в отдельную иерархию классов, что позволяет заменять один алгоритм другим в ходе выполнения программы.
/// 
/// Назначение -  предназначен для определения семейства алгоритмов и инкапсуляции каждого из них и обеспечения их взаимозаменяемости.
/// 
/// Метафора:
/// Вам нужно добраться до аэропорта. Можно доехать на автобусе, такси или велосипеде. 
/// Здесь вид транспорта является стратегией. Вы выбираете конкретную стратегию в зависимости от контекста — наличия денег или времени до отлёта.
/// 
/// Потенциальные проблемы:
/// 1) Усложняет программу за счёт дополнительных классов.
/// 2) Клиент должен знать, в чём состоит разница между стратегиями, чтобы выбрать подходящую.
/// </summary>

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IStrategyClient stClient = new StrategyClient1();
            stClient.SetStrategy(new GoToWorkStrategy());
            stClient.UseStrategy();
            Console.WriteLine();
            stClient.SetStrategy(new GoToGymStrategy());
            stClient.UseStrategy();
            Console.WriteLine();
            stClient.SetStrategy(new GoWalkStrategy());
            stClient.UseStrategy();
            Console.ReadKey();
        }
    }
}
