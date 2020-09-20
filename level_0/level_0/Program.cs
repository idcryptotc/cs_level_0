using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_0
{
	class Program
	{
		static void Main(string[] args)
		{
			bool isNotExit = true;
			int numberTask;

			while (isNotExit)
			{
				Console.Clear();
				Console.Write("Блок 3. Вариант 1. Введите номер задачи (0 - выход): ");
				
				try
				{
					numberTask = Convert.ToInt32(Console.ReadLine());
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					continue;
				}

				Console.Clear();

				switch (numberTask)
				{
				case 0:
					{
						isNotExit = false;
						break;
					}
				case 1:
					{
						Console.WriteLine("1-97. Пусть\nx1=y1=1; xi=0.3xi-1;\nyi=xi-1+yi-1, i=2,3,...");
						Console.WriteLine("Дано натуральное n. Найти sum(xi/(1+|yi|), i=1..n");
						solution_01();
						Console.ReadKey(true);
						break;
					}
				case 2:
					{
						Console.WriteLine("2-138. Даны действительные числа a1,...,a70.");
						Console.WriteLine("Получить (вывести) последовательность a2,a3,...,a70,a1.");
						solution_02();
						Console.ReadKey(true);
						break;
					}
				case 3:
					{
						Console.WriteLine("3-120. Потстроить:");
						Console.WriteLine("а) треугольник с вершинами (100, 100), (150, 100), (80, 170)");
						Console.WriteLine("б) прямоугольник с вершинами (80, 80), (170, 80), (170, 150), (80,150)");
						Console.WriteLine("в) пятиугольник с вершинами (100, 100), (150, 100), (170, 120),(150, 140), (100, 140), (80, 120)");
						Console.WriteLine("г) шестиугольник с вершинами (120, 100), (140, 120), (140, 140),(120, 160), (100, 140), (100, 120)");
						Console.WriteLine("д) закрасить фигуры");
						solution_03();
						Console.ReadKey(true);
						break;
					}
				case 4:
					{
						Console.WriteLine("4-184. Даны целые числа p, q, a1,..., a67 ( p > q ≥ 0 ). В");
						Console.WriteLine("последовательности a1,...,a67 заменить нулями члены, модуль");
						Console.WriteLine("которых при делении на p дает в остатке q.");
						solution_04();
						Console.ReadKey(true);
						break;
					}
				case 5:
					{
						Console.WriteLine("5-194. Даны натуральное число n, целые числа a1, x1, ... , xn. Если");
						Console.WriteLine("в последовательности x1, ... , xn есть хотя бы один член, равный a, то");
						Console.WriteLine("получить сумму всех членов, следующих за первым таким членом;");
						Console.WriteLine("в противном случае ответом должно быть число –10.");
						solution_05();
						Console.ReadKey(true);
						break;
					}
				case 6:
					{
						Console.WriteLine("6-124. Столбчатая диаграмма (гистограмма) представляет собой");
						Console.WriteLine("набор прямоугольников, основания которых равны, а высоты");
						Console.WriteLine("пропорциональны числовым величинам, взятым из некоторой");
						Console.WriteLine("cовокупности. Для большей наглядности прямоугольники");
						Console.WriteLine("диаграммы обычно закрашивают в разные цвета.");
						Console.WriteLine("Даны семь действительных положительных чисел a1, a2, ..., a7.");
						Console.WriteLine("Построить гистограмму для этих значений.");
						solution_06();
						Console.ReadKey(true);
						break;
					}
				case 7:
					{
						Console.WriteLine("7-255. Даны натуральное число n, символы s1, ..., sn. Получить");
						Console.WriteLine("первое натуральное число i, для которого каждый из символов si и si + 1");
						Console.WriteLine("совпадает с буквой a.Если такой пары символов в последовательности");
						Console.WriteLine("s1, ..., sn нет, то ответом должно быть число 0.");
						solution_07();
						Console.ReadKey(true);
						break;
					}
				case 8:
					{
						Console.WriteLine("8-276. Построить последовательность целых чисел а1, ..., а30, где");
						Console.WriteLine("a1 = 1, a2 = 1;");
						Console.WriteLine("ai = a[i / 2] + ai–2(i = 3, ..., 30).");
						solution_08();
						Console.ReadKey(true);
						break;
					}
				case 9:
					{
						Console.WriteLine("9-135. Получить на экране изображение действующих");
						Console.WriteLine("электронных часов, показывающих текущее время.Шаблоны");
						Console.WriteLine("используемых цифр должны соответствовать обычному для");
						Console.WriteLine("электронных часов семисегментному шаблону.");
						solution_09();
						Console.ReadKey(true);
						break;
					}
				case 10:
					{
						Console.WriteLine("10-359. Даны натуральное число n , символы s1,..., s10 , t1,..., tn *).");
						Console.WriteLine("Получить все не превосходящие n − 9 натуральные i, для которых");
						Console.WriteLine("s1 = ti, s2 = ti + 1, ..., s10 = ti + 9.");
						solution_10();
						Console.ReadKey(true);
						break;
					}
				case 11:
					{
						Console.WriteLine("11-554.Дано натуральное число n.Получить все пифагоровы");
						Console.WriteLine("тройки натуральных чисел, каждое из которых не превосходит n, т.е.");
						Console.WriteLine("все такие тройки натуральных чисел a, b, c, что");
						Console.WriteLine("a2 + b2 = c2(a ≤ b ≤ c ≤ n).");
						solution_11();
						Console.ReadKey(true);
						break;
					}
				case 12:
					{
						Console.WriteLine("12-173. Даны натуральные числа n, a0, a1, a2, ..., 4n−1 a . Каждые");
						Console.WriteLine("четыре числа ai, ai + 1, ai + 2, ai + 3, где i кратно четырем, задают");
						Console.WriteLine("прямоугольник со сторонами, параллельными осям координат экрана:");
						Console.WriteLine("числа ai, ai + 1 - это координаты центра прямоугольника, ai + 2, ai + 3 -");
						Console.WriteLine("длины его сторон.Построить и закрасить каким - либо цветами");
						Console.WriteLine("прямоугольники, заданные последовательностью a0, a1, a2, ..., 4n−1 a.");
						solution_12();
						Console.ReadKey(true);
						break;
					}
				case 13:
					{
						Console.WriteLine("13-396. Дана действительная квадратная матрица порядка n.");
						Console.WriteLine("Построить последовательность действительных чисел n a, ..., a 1 по");
						Console.WriteLine("правилу: если в i - й строке матрицы элемент, принадлежащий главной");
						Console.WriteLine("диагонали, отрицателен, то ai равно сумме элементов i - й строки,");
						Console.WriteLine("предшествующих первому отрицательному элементу;");
						Console.WriteLine("в противном случае ai равно сумме последних элементов i - й строки, начиная с");
						Console.WriteLine("первого по порядку неотрицательного элемента.");
						solution_13();
						Console.ReadKey(true);
						break;
					}
				case 14:
					{
						Console.WriteLine("14-424. Даны действительные числа s, t. Получить");
						Console.WriteLine("f(t, –2s, 1.17) + f(2.2, t, s – t),");
						Console.WriteLine("где f(a, b, c) = (2a-b-sin(c))/(5+|c|);");
						solution_14();
						Console.ReadKey(true);
						break;
					}
				case 15:
					{
						Console.WriteLine("15-1014. Магическим квадратом порядка п называется квадратная");
						Console.WriteLine("таблица размера n× n, составленная из чисел 1, 2, ..., n2 так, что суммы");
						Console.WriteLine("по каждому столбцу, каждой строке и каждой из двух диагоналей");
						Console.WriteLine("равны между собой.Дана целочисленная квадратная матрица порядка 5;");
						Console.WriteLine("определить, является ли она магическим квадратом.");
						solution_15();
						Console.ReadKey(true);
						break;
					}
				case 16:
					{
						Console.WriteLine("16-536. Даны натуральное число n, целые числа a1, ..., an.");
						Console.WriteLine("Выяснить, имеются ли среди чисел a1, ..., an совпадающие.");
						solution_16();
						Console.ReadKey(true);
						break;
					}
				case 17:
					{
						Console.WriteLine("17-810. Дано натуральное число п ( n ≤ 1000). Записать это число");
						Console.WriteLine("русскими словами(семнадцать, двести пятьдесят три, тысяча и т.д.).");
						solution_17();
						Console.ReadKey(true);
						break;
					}
				case 18:
					{
						Console.WriteLine("18-832. В некоторой библиотеке последний четверг каждого");
						Console.WriteLine("месяца - санитарный день.Дано натуральное число n, означающее");
						Console.WriteLine("номер года.Получить по порядку все числа, на которые в январе,");
						Console.WriteLine("феврале, . . . , декабре указанного года приходится санитарный день.");
						solution_18();
						Console.ReadKey(true);
						break;
					}
				case 19:
					{
						Console.WriteLine("19-498(б). Дан символьный файл f. Найти самое длинное слово");
						Console.WriteLine("среди слов, вторая буква которых есть е;");
						Console.WriteLine("если таких слов с наибольшей длиной несколько, то найти последнее. Если");
						Console.WriteLine("таких слов нет вообще, то сообщить об этом. Решить эту задачу без ограничения на число символов в слове.");
						solution_19();
						Console.ReadKey(true);
						break;
					}
				case 20:
					{
						Console.WriteLine("20-802. Дан текст; найти наибольшее количество цифр, идущих в");
						Console.WriteLine("нем подряд.");
						solution_20();
						Console.ReadKey(true);
						break;
					}
				case 21:
					{
						Console.WriteLine("21-1046. «Задача о рюкзаке». Имеется т различных предметов,");
						Console.WriteLine("известны вес каждого предмета и его стоимость.Определить, какие");
						Console.WriteLine("предметы надо положить в рюкзак, чтобы общий вес не превышал");
						Console.WriteLine("заданной границы, а общая стоимость была максимальна.Решить эту");
						Console.WriteLine("задачу для т предметов, веса которых в килограммах равны m p, ..., p 1,");
						Console.WriteLine("стоимости - m c, ..., c 1.Вес рюкзака не должен превышать 50кг.");
						solution_21();
						Console.ReadKey(true);
						break;
					}
				case 22:
					{
						Console.WriteLine("22-839(а). Зафиксируем натуральное k и перестановку чисел 1, ..., k");
						Console.WriteLine("(ее можно задать с помощью последовательности натуральных чисел");
						Console.WriteLine("k p, ..., p 1, в которую входит каждое из чисел 1, . . . , k). При шифровке в");
						Console.WriteLine("исходном тексте к каждой из последовательных групп по k символов");
						Console.WriteLine("применяется зафиксированная перестановка.Пусть k = 4 и");
						Console.WriteLine("перестановка есть 3, 2, 4, 1.Тогда группа символов");
						Console.WriteLine("1 2 3 4 s, s, s, s заменяется на 3 2 4 1 s, s, s, s.Если в последней группе меньше");
						Console.WriteLine("четырех символов, то к ней добавляются пробелы.Пользуясь");
						Console.WriteLine("изложенным способом зашифровать данный текст;");
						solution_22();
						Console.ReadKey(true);
						break;
					}
				case 23:
					{
						Console.WriteLine("23-834(а). Чтобы зашифровать текст, записанный с помощью русских");
						Console.WriteLine("букв и знаков препинания, его можно переписать, заменив каждую");
						Console.WriteLine("букву непосредственно следующей за ней по алфавиту(буква я");
						Console.WriteLine("заменяется на а). Зашифровать данный текст.");
						solution_23();
						Console.ReadKey(true);
						break;
					}
				case 24:
					{
						Console.WriteLine("24-1028. Даны натуральные числа т, a , ..., an 1 . В");
						Console.WriteLine("последовательности n a, ..., a 1 выбрать подпоследовательность");
						Console.WriteLine("i i ik a, a, ..., a 1 2(i i i n k 0 ≤ < < ...< ≤ 1 2) такую, что a a m i ik + ...+ = 1.");
						Console.WriteLine("Если такую подпоследовательность выбрать невозможно, то следует");
						Console.WriteLine("сообщить об этом.");
						Console.WriteLine("При решении этой задачи полезно следующее соображение.");
						Console.WriteLine("Чтобы выбрать подпоследовательность из последовательности");
						Console.WriteLine("n a, ..., a 1, нужно про каждый член n a, ..., a 1, решить, принимается он в");
						Console.WriteLine("подпоследовательность или нет.Может возникнуть следующая");
						Console.WriteLine("ситуация: относительно членов i a, ..., a 1(i < n) приняты какие - то");
						Console.WriteLine("решения, после этого обнаружилось, что, как бы мы ни распоряжались");
						Console.WriteLine("остальными п - i членами, нам все равно не удастся получить");
						Console.WriteLine("подпоследовательность, удовлетворяющую поставленному условию");
						Console.WriteLine("(например, если сумма нескольких положительных чисел больше m, то");
						Console.WriteLine("невозможно добавить к ним ещё несколько положительных чисел так,");
						Console.WriteLine("чтобы сумма стала равна m).В этом случае можно сразу исключить из");
						Console.WriteLine("рассмотрения все подпоследовательности, первые члены которых");
						Console.WriteLine("выбраны из a, ..., ai 1 в соответствии с принятыми решениями.");
						solution_24();
						Console.ReadKey(true);
						break;
					}
				case 25:
					{
						Console.WriteLine("25-1023. Дана целочисленная матрица [a i j ]i n j m a =1,..., ; =1,..., .");
						Console.WriteLine("Прямоугольником в этой матрице будем называть множество всех");
						Console.WriteLine("элементов i j a, для которых выполнено 1≤ p ≤ i ≤ q ≤ n, 1≤ r ≤ j ≤ s ≤ m,");
						Console.WriteLine("где p, q, r, s - натуральные числа, задающие прямоугольник.");
						Console.WriteLine("Площадью прямоугольника назовем число элементов в нем.");
						Console.WriteLine("Среди прямоугольников матрицы, состоящих целиком из нулей, найти");
						Console.WriteLine("тот, который имеет наибольшую площадь.");
						solution_25();
						Console.ReadKey(true);
						break;
					}
				case 26:
					{
						Console.WriteLine("26-1014. Магическим квадратом порядка п называется квадратная");
						Console.WriteLine("таблица размера n× n, составленная из чисел 1, 2, ..., n2 так, что суммы");
						Console.WriteLine("по каждому столбцу, каждой строке и каждой из двух диагоналей");
						Console.WriteLine("равны между собой.Дана целочисленная квадратная матрица порядка 5;");
						Console.WriteLine("определить, является ли она магическим квадратом.");
						solution_26();
						Console.ReadKey(true);
						break;
					}
				case 27:
					{
						Console.WriteLine("27-1036. Лабиринт может быть задан матрицей соединений, в");
						Console.WriteLine("которой для каждой пары комнат указано, соединены ли они");
						Console.WriteLine("коридором. Даны матрица соединений для лабиринта");
						Console.WriteLine("из п комнат и номера комнат i, j(1≤ i ≤ n, 1≤ j ≤ n).Построить путь из");
						Console.WriteLine("комнаты с номером i в комнату с номером j.");
						solution_27();
						Console.ReadKey(true);
						break;
					}
				case 28:
					{
						Console.WriteLine("28-996. «Сбей самолет». По экрану летят вражеские самолеты.");
						Console.WriteLine("Цель - сбить их.Пусковая установка находится в нижней строке");
						Console.WriteLine("экрана.Пусковую установку можно перемещать по строке вперед и");
						Console.WriteLine("назад.");
						solution_28();
						Console.ReadKey(true);
						break;
					}
				case 29:
					{
						Console.WriteLine("29-987. «Кости». Играющий называет любое число в диапазоне от");
						Console.WriteLine("2 до 12 и ставку, которую он делает в этот ход.Программа с помощью");
						Console.WriteLine("датчика случайных чисел дважды выбирает числа от 1 до 6(«бросает");
						Console.WriteLine("кубик», на гранях которого цифры от 1 до 6).Если сумма выпавших");
						Console.WriteLine("цифр меньше 7 и играющий задумал число меньшее 7, он выигрывает");
						Console.WriteLine("сделанную ставку.Если сумма выпавших цифр больше 7 и играющий");
						Console.WriteLine("задумал число большее 7, он также выигрывает сделанную ставку.");
						Console.WriteLine("Если играющий угадал сумму цифр, он получает в четыре раза больше");
						Console.WriteLine("очков, чем сделанная ставка.Ставка проиграна, если не имеет место ни");
						Console.WriteLine("одна из описанных ситуаций.В начальный момент у играющего 100");
						Console.WriteLine("очков.");
						solution_29();
						Console.ReadKey(true);
						break;
					}
				case 30:
					{
						Console.WriteLine("30-1027. Правильное скобочное выражение получается из");
						Console.WriteLine("некоторого математического выражения, содержащего круглые");
						Console.WriteLine("скобки, вычеркиванием всех знаков, кроме круглых скобок.Например,");
						Console.WriteLine("из выражения a - b(c + 2(x + y(z + 1))) + a(c + x) получается");
						Console.WriteLine("правильное скобочное выражение((( )))().Более точное описание");
						Console.WriteLine("множества правильных скобочных выражений:");
						Console.WriteLine("1)() - правильное скобочное выражение;");
						Console.WriteLine("2) если P -правильное скобочное выражение, то (P) -");
						Console.WriteLine("правильное скобочное выражение;");
						Console.WriteLine("3) если P и Q -правильные скобочные выражения, то PQ -");
						Console.WriteLine("правильное скобочное выражение.");
						Console.WriteLine("Даны натуральное число п и последовательность символов");
						Console.WriteLine("c c n 1 2 , ..., , каждый из которых - круглая скобка.Определить, является");
						Console.WriteLine("ли последовательность n c c1 2 , ..., правильным скобочным выражением.");
						solution_30();
						Console.ReadKey(true);
						break;
					}
				default:
					{
						Console.WriteLine("Что-то пошло не так...");
						break;
					}
				}
			}
		}

		private static void solution_30()
		{
			throw new NotImplementedException();
		}

		private static void solution_29()
		{
			throw new NotImplementedException();
		}

		private static void solution_28()
		{
			throw new NotImplementedException();
		}

		private static void solution_27()
		{
			throw new NotImplementedException();
		}

		private static void solution_26()
		{
			throw new NotImplementedException();
		}

		private static void solution_25()
		{
			throw new NotImplementedException();
		}

		private static void solution_24()
		{
			throw new NotImplementedException();
		}

		private static void solution_23()
		{
			throw new NotImplementedException();
		}

		private static void solution_22()
		{
			throw new NotImplementedException();
		}

		private static void solution_21()
		{
			throw new NotImplementedException();
		}

		private static void solution_20()
		{
			throw new NotImplementedException();
		}

		private static void solution_19()
		{
			throw new NotImplementedException();
		}

		private static void solution_18()
		{
			throw new NotImplementedException();
		}

		private static void solution_17()
		{
			throw new NotImplementedException();
		}

		private static void solution_16()
		{
			throw new NotImplementedException();
		}

		private static void solution_15()
		{
			throw new NotImplementedException();
		}

		private static void solution_14()
		{
			throw new NotImplementedException();
		}

		private static void solution_13()
		{
			throw new NotImplementedException();
		}

		private static void solution_12()
		{
			throw new NotImplementedException();
		}

		private static void solution_11()
		{
			throw new NotImplementedException();
		}

		private static void solution_10()
		{
			throw new NotImplementedException();
		}

		private static void solution_09()
		{
			throw new NotImplementedException();
		}

		private static void solution_08()
		{
			throw new NotImplementedException();
		}

		private static void solution_07()
		{
			throw new NotImplementedException();
		}

		private static void solution_06()
		{
			throw new NotImplementedException();
		}

		private static void solution_05()
		{
			throw new NotImplementedException();
		}

		private static void solution_04()
		{
			throw new NotImplementedException();
		}

		private static void solution_03()
		{
			throw new NotImplementedException();
		}

		private static void solution_02()
		{
			throw new NotImplementedException();
		}

		private static void solution_01()
		{
			double x1 = 1;
			double y1 = 1;
			double sum = x1 / (1 + Math.Abs(y1));
		input_1:
			Console.Write("Введите натуральное n: ");
			uint n;

			try
			{
				n = Convert.ToUInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_1;
			}

			if (n == 0)
			{
				Console.WriteLine("n - не натуральное");
				goto input_1;
			}

			double x = 0; 
			double y = 0;

			for (int i = 2; i <= n; ++i)
			{
				x = 0.3 * x1;
				y = x1 + y1;
				sum += x1 / (1 + Math.Abs(y1));
				x1 = x;
				y1 = y;
			}

			Console.WriteLine("Результат: {0}", sum);
		}
	}
}
