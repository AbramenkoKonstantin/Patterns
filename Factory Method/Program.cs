using System;
/// <summary>
/// Тип - порождающий
/// 
/// Описание - В его классическом варианте вводится полиморфный класс Factory, в котором определяется интерфейс фабричного метода, 
/// а ответственность за создание объектов конкретных классов переносится на производные от Factory классы, в которых этот метод переопределяется.
/// 
/// Потенциальные проблемы - может привести к созданию больших параллельных иерархий классов, так как для каждого класса продукта надо создать свой подкласс создателя.
/// </summary>

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory1 fact1 = new Factory1();
            Factory2 fact2 = new Factory2();
            Factory[] factories = { fact1, fact2 };
            for (int i = 0; i < factories.Length; i++)
            {
                BaseClass bc = factories[i].FactoryMethod();
                Console.WriteLine("Type={0}, Object={1}", bc.GetType().ToString(), bc.GetName());
            }
            Console.ReadKey();
        }
    }
}
