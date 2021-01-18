/*
 * Создано в SharpDevelop.
 * Пользователь: 123
 * Дата: 18.01.2021
 * Время: 22:40
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace laba3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Вариант 7: Запрашивает у пользователя 4 числа и выводит на экран только четные");
			Console.WriteLine("================================================");
			Console.Write("Введите 1-ое число:");
				int a = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите 2-ое число:");
				int b = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите 3-е число:");
				int c = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите 4-ое число:");
				int d = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("================================================");
				Console.WriteLine("Четные числа из введенных: ");
				if (a%2 == 0){
					Console.WriteLine( a);}
				if (b%2 == 0){
					Console.WriteLine( b);}
				if (c%2 == 0){
					Console.WriteLine( c);}
				if (d%2 == 0){
					Console.WriteLine( d);}
				Console.WriteLine("================================================");
				Console.WriteLine("Для выхода нажмите любую клавишу.....");
			Console.ReadKey();
		
		}
	}
}