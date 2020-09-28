using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using Timer = System.Threading.Timer;

namespace level_0
{
	class Program
	{
		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();
		delegate double f14(double a, double b, double c);
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
						Console.WriteLine("электронных часов, показывающих текущее время. Шаблоны");
						Console.WriteLine("используемых цифр должны соответствовать обычному для");
						Console.WriteLine("электронных часов семисегментному шаблону.");
						solution_09();
						Graphics g = Graphics.FromHwnd(GetConsoleWindow());
						g.Clear(Color.Black);
						break;
					}
				case 10:
					{
						Console.WriteLine("10-359. Даны натуральное число n , символы s1,..., s10 , t1,..., tn).");
						Console.WriteLine("Получить все не превосходящие n − 9 натуральные i, для которых");
						Console.WriteLine("s1 = ti, s2 = ti + 1, ..., s10 = ti + 9.");
						solution_10();
						Console.ReadKey(true);
						break;
					}
				case 11:
					{
						Console.WriteLine("11-554. Дано натуральное число n.Получить все пифагоровы");
						Console.WriteLine("тройки натуральных чисел, каждое из которых не превосходит n, т.е.");
						Console.WriteLine("все такие тройки натуральных чисел a, b, c, что");
						Console.WriteLine("a2 + b2 = c2(a <= b <= c <= n).");
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
						break;
					}
				case 13:
					{
						Console.WriteLine("13-396. Дана действительная квадратная матрица порядка n.");
						Console.WriteLine("Построить последовательность действительных чисел a1, ..., an по");
						Console.WriteLine("правилу: если в i-й строке матрицы элемент, принадлежащий главной");
						Console.WriteLine("диагонали, отрицателен, то ai равно сумме элементов i-й строки,");
						Console.WriteLine("предшествующих первому отрицательному элементу;");
						Console.WriteLine("в противном случае ai равно сумме последних элементов i-й строки,");
						Console.WriteLine("начиная с первого по порядку неотрицательного элемента.");
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
						Console.WriteLine("15-1014. Магическим квадратом порядка n называется квадратная");
						Console.WriteLine("таблица размера n*n, составленная из чисел 1, 2, ..., n2 так, что суммы");
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
						Console.WriteLine("17-810. Дано натуральное число n ( n <= 1000). Записать это число");
						Console.WriteLine("русскими словами(семнадцать, двести пятьдесят три, тысяча и т.д.).");
						solution_17();
						Console.ReadKey(true);
						break;
					}
				case 18:
					{
						Console.WriteLine("18-832. В некоторой библиотеке последний четверг каждого");
						Console.WriteLine("месяца - санитарный день. Дано натуральное число n, означающее");
						Console.WriteLine("номер года. Получить по порядку все числа, на которые в январе,");
						Console.WriteLine("феврале, ..., декабре указанного года приходится санитарный день.");
						solution_18();
						Console.ReadKey(true);
						break;
					}
				case 19:
					{
						Console.WriteLine("19-498(б). Дан символьный файл f. Найти самое длинное слово");
						Console.WriteLine("среди слов, вторая буква которых есть е;");
						Console.WriteLine("если таких слов с наибольшей длиной несколько, то найти последнее. Если");
						Console.WriteLine("таких слов нет вообще, то сообщить об этом.");
						Console.WriteLine("Решить эту задачу без ограничения на число символов в слове.");
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
						Console.WriteLine("21-1046. \"Задача о рюкзаке\". Имеется m различных предметов,");
						Console.WriteLine("известны вес каждого предмета и его стоимость.Определить, какие");
						Console.WriteLine("предметы надо положить в рюкзак, чтобы общий вес не превышал");
						Console.WriteLine("заданной границы, а общая стоимость была максимальна. Решить эту");
						Console.WriteLine("задачу для m предметов, веса которых в килограммах равны p1, ..., pm,");
						Console.WriteLine("стоимости - c1, ..., cm. Вес рюкзака не должен превышать 50кг.");
						solution_21();
						Console.ReadKey(true);
						break;
					}
				case 22:
					{
						Console.WriteLine("22-839(а). Зафиксируем натуральное k и перестановку чисел 1, ..., k");
						Console.WriteLine("(ее можно задать с помощью последовательности натуральных чисел");
						Console.WriteLine("p1, ..., pk, в которую входит каждое из чисел 1, ..., k). При шифровке в");
						Console.WriteLine("исходном тексте к каждой из последовательных групп по k символов");
						Console.WriteLine("применяется зафиксированная перестановка. Пусть k = 4 и");
						Console.WriteLine("перестановка есть 3, 2, 4, 1. Тогда группа символов");
						Console.WriteLine("s1, s2, s3, s4 заменяется на s3, s2, s4, s1. Если в последней группе меньше");
						Console.WriteLine("четырех символов, то к ней добавляются пробелы. Пользуясь");
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
						Console.WriteLine("24-1028. Даны натуральные числа m, a1, ..., an. В");
						Console.WriteLine("последовательности a1, ..., an выбрать подпоследовательность");
						Console.WriteLine("ai1, ai2, ..., aik (0 <= i1 < i2 < ... < ik <= n)");
						Console.WriteLine("такую, что ai1 + ... + aik = m.");
						Console.WriteLine("Если такую подпоследовательность выбрать невозможно, то следует");
						Console.WriteLine("сообщить об этом.");
						solution_24();
						Console.ReadKey(true);
						break;
					}
				case 25:
					{
						Console.WriteLine("25-1023. Дана целочисленная матрица [aij] (i=1...n, j=1...m).");
						Console.WriteLine("Прямоугольником в этой матрице будем называть множество всех");
						Console.WriteLine("элементов aij, для которых выполнено 1 <= p <= i <= q <= n,");
						Console.WriteLine("1 <= r <= j <= s <= m,");
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
						Console.WriteLine("из n комнат и номера комнат i, j");
						Console.WriteLine("(1 <= i <= n, 1 <= j <= n). Построить путь из");
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

		}

		private static void solution_29()
		{

		}

		private static void solution_28()
		{

		}

		private static void solution_27()
		{
			int n;

			do
			{
				Console.WriteLine("Введите n: ");
				int.TryParse(Console.ReadLine(), out n);
			}
			while (n <= 0);

			int[,] arrayIn = new int[n, n];
			Random r = new Random();
			Console.WriteLine("Матрица соединений: ");

			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j)
				{
					arrayIn[i, j] = i == j ? 0 : r.Next() % 6 == 0 ? 1 : 0;
					Console.Write(arrayIn[i, j] + " ");
				}

				Console.WriteLine();
			}

			for (int i = 0; i < n; ++i)
			{
				int[] flag = new int[n];

				for (int j = 0; j < n; ++j)
				{
					if (arrayIn[i, j] != 0 && flag[j] == 0)
					{
						for (int k = 0; k < n; ++k)
						{
							arrayIn[i, k] = Convert.ToInt32(arrayIn[i, k] | arrayIn[j, k]);
						}

						flag[j] = 1;
						j = -1;
					}
				}
			}

			Console.WriteLine("Матрица связей: ");

			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j)
				{
					Console.Write(arrayIn[i, j] + " ");
				}

				Console.WriteLine();
			}
		}

		private static void solution_26()
		{
			solution_15();
		}

		struct rect
		{
			public int square;
			public int p;
			public int q;
			public int r;
			public int s;

			public override string ToString()
			{
				return string.Format("x1 = {2}, x2 = {3}, y1 = {0}, y2 = {1}", p, q, r, s);
			}
		};

		private static void solution_25()
		{
		input_25_1:
			Console.Write("Введите m: ");
			int m;

			try
			{
				m = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_25_1;
			}

			if (m <= 0)
			{
				Console.WriteLine("Подумай и введи снова");
				goto input_25_1;
			}

		input_25_2:
			Console.Write("Введите n: ");
			int n;

			try
			{
				n = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_25_2;
			}

			if (n <= 0)
			{
				Console.WriteLine("Подумай и введи снова");
				goto input_25_2;
			}

			Random rand = new Random();
			int[,] array = new int[m, n];

			for (int i = 0; i < m; ++i)
			{
				for (int j = 0; j < n; ++j)
				{
					array[i, j] = rand.Next(0, 2);
					Console.Write(array[i, j] + " ");
				}

				Console.WriteLine();
			}

			List<rect> stack = new List<rect>();
			rect rt;

			for (int i = 0; i < m; ++i)
			{
				for (int j = 0; j < n; ++j)
				{
					rt = new rect();
					
					if (array[i, j] == 0)
					{
						rt.p = i;
						rt.r = j;
						int n1 = n;

						for (rt.q = rt.p; rt.q < m; ++rt.q)
						{
							if (array[rt.q, rt.r] == 1)
							{
								break;
							}

							for (rt.s = rt.r; rt.s < n1; ++rt.s)
							{
								if (array[rt.q, rt.s] == 1)
								{
									n1 = rt.s;
									--rt.s;
									rt.square = (rt.q - rt.p + 1) * (rt.s - rt.r + 1);
									stack.Add(rt);
									break;
								}

								if (rt.s == n1 - 1)
								{
									rt.square = (rt.q - rt.p + 1) * (rt.s - rt.r + 1);
									stack.Add(rt);
								}
							}
						}
					}
				}
			}

			var x = stack.Max(s => s.square);
			var y = stack.Find(s => s.square == x);

			Console.WriteLine("Самый большой прямоугольник: {0} нулей", x);
			Console.WriteLine("Один из прямоугольников: {0}", y.ToString());
		}

		private static void solution_24()
		{
		input_24:
			Console.Write("Введите натуральное m: ");
			int m;

			try
			{
				m = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_24;
			}

			if (m <= 0)
			{
				Console.WriteLine("Подумай и введи снова");
				goto input_24;
			}

			const int N = 100;
			Random r = new Random();
			int[] array = new int[N];

			for (int i = 0; i < N; ++i)
			{
				array[i] = r.Next(1, N + 1);
				Console.Write(array[i] + (i % 10 == 9 ? "\n" : "\t"));
			}

			int sum = 0;
			int indexStart = 0;
			int indexFinish = 0;

			for (int i = 0; i < N; ++i)
			{
				sum = 0;

				for (int j = i; j < N; ++j)
				{
					sum += array[j];

					if (m < sum)
					{
						sum = 0;
						break;
					}

					if (m == sum)
					{
						indexStart = i;
						indexFinish = j;
						i = N;
						break;
					}
				}
			}

			if (sum == m)
			{
				Console.WriteLine((1 + indexStart) + "..." + (1 + indexFinish));
				Console.Write("m = ");

				for (int i = indexStart; i < indexFinish; ++i)
				{
					Console.Write("{0} + ", array[i]);
				}

				Console.WriteLine(array[indexFinish]);
			}
			else
			{
				Console.WriteLine("Такой последовательности нет");
			}
		}

		private static void solution_23()
		{
			Console.WriteLine("Введите текст: ");
			string text = Console.ReadLine();
			char[] textTemp = text.ToCharArray();
			Dictionary<char, char> alphabet = new Dictionary<char, char>();
			{
				alphabet['а'] = 'б';
				alphabet['б'] = 'в';
				alphabet['в'] = 'г';
				alphabet['г'] = 'д';
				alphabet['д'] = 'е';
				alphabet['е'] = 'ё';
				alphabet['ё'] = 'ж';
				alphabet['ж'] = 'з';
				alphabet['з'] = 'и';
				alphabet['и'] = 'й';
				alphabet['й'] = 'к';
				alphabet['к'] = 'л';
				alphabet['л'] = 'м';
				alphabet['м'] = 'н';
				alphabet['н'] = 'о';
				alphabet['о'] = 'п';
				alphabet['п'] = 'р';
				alphabet['р'] = 'с';
				alphabet['с'] = 'т';
				alphabet['т'] = 'у';
				alphabet['у'] = 'ф';
				alphabet['ф'] = 'х';
				alphabet['х'] = 'ц';
				alphabet['ц'] = 'ч';
				alphabet['ч'] = 'ш';
				alphabet['ш'] = 'щ';
				alphabet['щ'] = 'ъ';
				alphabet['ъ'] = 'ы';
				alphabet['ы'] = 'ь';
				alphabet['ь'] = 'э';
				alphabet['э'] = 'ю';
				alphabet['ю'] = 'я';
				alphabet['я'] = 'а';
				alphabet['А'] = 'Б';
				alphabet['Б'] = 'В';
				alphabet['В'] = 'Г';
				alphabet['Г'] = 'Д';
				alphabet['Д'] = 'Е';
				alphabet['Е'] = 'Ё';
				alphabet['Ё'] = 'Ж';
				alphabet['Ж'] = 'З';
				alphabet['З'] = 'И';
				alphabet['И'] = 'Й';
				alphabet['Й'] = 'К';
				alphabet['К'] = 'Л';
				alphabet['Л'] = 'М';
				alphabet['М'] = 'Н';
				alphabet['Н'] = 'О';
				alphabet['О'] = 'П';
				alphabet['П'] = 'Р';
				alphabet['Р'] = 'С';
				alphabet['С'] = 'Т';
				alphabet['Т'] = 'У';
				alphabet['У'] = 'Ф';
				alphabet['Ф'] = 'Х';
				alphabet['Х'] = 'Ц';
				alphabet['Ц'] = 'Ч';
				alphabet['Ч'] = 'Ш';
				alphabet['Ш'] = 'Щ';
				alphabet['Щ'] = 'Ъ';
				alphabet['Ъ'] = 'Ы';
				alphabet['Ы'] = 'Ь';
				alphabet['Ь'] = 'Э';
				alphabet['Э'] = 'Ю';
				alphabet['Ю'] = 'Я';
				alphabet['Я'] = 'А';
			}

			for (int i = 0; i < text.Length; ++i)
			{
				try
				{
					textTemp[i] = alphabet[textTemp[i]];
				}
				catch (Exception) { }
			}

			text = new string(textTemp);
			Console.WriteLine(text);
		}

		private static void solution_22()
		{
		input_22:
			Console.Write("Введите натуральное k: ");
			uint k;

			try
			{
				k = Convert.ToUInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_22;
			}

			if (k == 0)
			{
				Console.WriteLine("k - не натуральное");
				goto input_22;
			}

			int[] swapArray = new int[k];
			Random r = new Random();

			for (int i = 1; i <= k; ++i)
			{
				int j = r.Next(0, (int)k);

				if (swapArray[j] == 0)
				{
					swapArray[j] = i;
				}
				else
				{
					--i;
				}
			}

			for(int i=0;i<k;++i)
			{
				Console.Write(swapArray[i] + " ");
			}

			Console.WriteLine("\nВведите текст для зашифровки: ");
			string text = Console.ReadLine();
			string ciphertext;

			if (text.Length % k != 0)
			{
				ciphertext = text + (new string(new char[k - text.Length % k])).Replace('\0', ' ');
			}
			else
			{
				ciphertext = text;
			}

			int ptrInciphertext = 0;

			do
			{
				char[] ciphertextTemp = ciphertext.ToCharArray();

				for (int i = ptrInciphertext; i < k + ptrInciphertext; ++i)
				{
					ciphertextTemp[i] = ciphertext[swapArray[i - ptrInciphertext] + ptrInciphertext - 1];
				}

				ciphertext = new string(ciphertextTemp);
				ptrInciphertext += (int)k;
			}
			while (ptrInciphertext < ciphertext.Length);

			Console.WriteLine(ciphertext);
		}

		private static void solution_21()
		{
		input_21:
			Console.Write("Введите количество предметов: ");
			int m;

			try
			{
				m = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_21;
			}

			if (m <= 0)
			{
				Console.WriteLine("Тебя в поход не возьмут... Введи снова");
				goto input_21;
			}

			const int P = 50;
			Random r = new Random();
			int[] p = new int[m];
			int[] c = new int[m];
			double[] pc = new double[m];

			for (int i = 0; i < m; ++i)
			{
				p[i] = r.Next(1, 51);
				c[i] = r.Next(1, 1001);
				Console.WriteLine("{0}. Вес: {1},\tСтоимость: {2}\tВес/Стоимость: {3}",
					i + 1, p[i], c[i], pc[i] = (double)c[i] / (double)p[i]);
			}

			for (int i = 0; i < m-1; ++i)
			{
				for (int j = i; j < m; ++j)
				{
					if (pc[i] < pc[j])
					{
						int temp1 = p[i];
						int temp2 = c[i];
						double temp = pc[i];
						p[i] = p[j];
						c[i] = c[j];
						pc[i] = pc[j];
						p[j] = temp1;
						c[j] = temp2;
						pc[j] = temp;
					}
				}
			}

			for (int i = 0; i < m - 1; ++i)
			{
				for (int j = i; j < m; ++j)
				{
					if (p[i] < p[j] && pc[i] == pc[j])
					{
						int temp1 = p[i];
						int temp2 = c[i];
						double temp = pc[i];
						p[i] = p[j];
						c[i] = c[j];
						pc[i] = pc[j];
						p[j] = temp1;
						c[j] = temp2;
						pc[j] = temp;
					}
				}
			}

			int result = 0;

			for (int i = 0; i < m; ++i)
			{
				if (result + p[i] <= P)
				{
					result += p[i];
					Console.WriteLine("Вес: " + p[i] + "\tСтоимость: " + c[i]);
				}
			}

		}

		private static void solution_20()
		{
			Console.WriteLine("Введите текст: ");
			string text = Console.ReadLine();
			int count = 0;
			int countMax = 0;

			for (int i = 0; i < text.Length; ++i)
			{
				if (text[i] >= '0' && text[i] <= '9')
				{
					++count;
				}
				else
				{
					countMax = count > countMax ? count : countMax;
					count = 0;
				}
			}

			countMax = count > countMax ? count : countMax;
			Console.WriteLine("Результат: {0}", countMax);
		}

		private static void solution_19()
		{
			string path = @"..\..\res\solution_19.txt";
			Console.WriteLine();
			string result = "";

			using (StreamReader sr = new StreamReader(path))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					Console.WriteLine("\t" + line);
					List<string> ls = line.Split(' ').ToList().FindAll(l => l.IndexOf('е') == 1);

					foreach (string str in ls)
					{
						result = result.Length < str.Length ? str : result;
					}
				}
			}

			if (result.Length == 0)
			{
				Console.WriteLine("\nТаких слов нет");
			}
			else
			{
				Console.WriteLine("\nРезультат: {0}", result);
			}
		}

		private static void solution_18()
		{
			int n;
		input_18:
			Console.Write("Введите n: ");

			try
			{
				n = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_18;
			}

			DateTime data = DateTime
				.Now
				.AddYears(n - DateTime.Now.Year)
				.AddDays(1 - DateTime.Now.Day)
				.AddMonths(1 - DateTime.Now.Month);

			Console.WriteLine("Санитарные дни: ");

			for (int i = 1; i <= 12; ++i)
			{
				for (int j = 1; j <= 7; ++j)
				{
					if (data.AddMonths(i).AddDays(-j).DayOfWeek == DayOfWeek.Thursday)
					{
						Console.WriteLine(data.AddMonths(i).AddDays(-j).ToShortDateString());
						break;
					}
				}
			}
		}

		private static void solution_17()
		{
			uint n;

		input_17:
			Console.Write("Введите n: ");

			try
			{
				n = Convert.ToUInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_17;
			}

			if (n == 0)
			{
				Console.WriteLine("n - не натуральное");
				goto input_17;
			}

			if (n > 1000)
			{
				Console.WriteLine("Великовато число, вводи снова");
				goto input_17;
			}

			Dictionary<uint, string> rusWords = new Dictionary<uint, string>();
			rusWords.Add(1, "один");
			rusWords.Add(2, "два");
			rusWords.Add(3, "три");
			rusWords.Add(4, "четыре");
			rusWords.Add(5, "пять");
			rusWords.Add(6, "шесть");
			rusWords.Add(7, "семь");
			rusWords.Add(8, "восемь");
			rusWords.Add(9, "девять");
			rusWords.Add(10, "десять");
			rusWords.Add(11, "одиннадцать");
			rusWords.Add(12, "двенадцать");
			rusWords.Add(13, "тринадцать");
			rusWords.Add(14, "четырнадцать");
			rusWords.Add(15, "пятнадцать");
			rusWords.Add(16, "шестнадцать");
			rusWords.Add(17, "семнадцать");
			rusWords.Add(18, "восемнадцать");
			rusWords.Add(19, "девятнадцать");
			rusWords.Add(20, "двадцать");
			rusWords.Add(30, "тридцать");
			rusWords.Add(40, "сорок");
			rusWords.Add(50, "пятьдесят");
			rusWords.Add(60, "шестьдесят");
			rusWords.Add(70, "семьдесят");
			rusWords.Add(80, "восемьдесят");
			rusWords.Add(90, "девяноста");
			rusWords.Add(100, "сто");
			rusWords.Add(200, "двести");
			rusWords.Add(300, "триста");
			rusWords.Add(400, "четыреста");
			rusWords.Add(500, "пятьсот");
			rusWords.Add(600, "шестьсот");
			rusWords.Add(700, "семьсот");
			rusWords.Add(800, "восемьсот");
			rusWords.Add(900, "девятьсот");
			rusWords.Add(1000, "тысяча");
			rusWords.Add(0, "");

			uint[] divNum = new uint[4];
			divNum[0] = n / 1000 * 1000;
			divNum[1] = n % 1000 - n % 100;
			divNum[2] = n % 100 >= 20 ? n % 100 - n % 10 : n % 100 < 20 && n % 100 >= 10 ? n % 100 : 0;
			divNum[3] = n % 100 < 20 && n % 100 >= 10 ? 0 : n % 10;
			Console.WriteLine
				(
					rusWords[divNum[0]] + (divNum[0] == 0 ? "" : " ") + 
					rusWords[divNum[1]] + (divNum[1] == 0 ? "" : " ") + 
					rusWords[divNum[2]] + (divNum[2] == 0 ? "" : " ") + 
					rusWords[divNum[3]] + (divNum[3] == 0 ? "" : " ")
				);
		}

		private static void solution_16()
		{
			uint n;
		input_16:
			Console.Write("Введите n: ");

			try
			{
				n = Convert.ToUInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_16;
			}

			if (n == 0)
			{
				Console.WriteLine("n - не натуральное");
				goto input_16;
			}

			uint[] array = new uint[n];
			Random r = new Random();

			for (uint i = 0; i < n; ++i)
			{
				array[i] = (uint)r.Next(1, 10);
				Console.Write(array[i] + " ");
			}

			for (uint i = 0; i < n-1; ++i)
			{
				for (uint j = i + 1; j < n; ++j)
				{
					if (array[i] == array[j])
					{
						Console.WriteLine("\nСовпадающие числа имеются");
						return;
					}
				}
			}

			Console.WriteLine("\nСовпадающих чисел не обнаружено");
		}

		private static void solution_15()
		{
			int[,] array = new int[5, 5];
			Random r = new Random();

			for (int i = 1; i < 26; ++i)
			{
				int a = r.Next(0, 5);
				int b = r.Next(0, 5);

				if (array[a, b] == 0)
				{
					array[a, b] = i;
				}
				else
				{
					--i;
				}
			}

			/*Тестовый магический квадрат*//*
			array = new int[,]
				{
					{ 11, 24, 7, 20, 3 },
					{ 4, 12, 25, 8, 16 },
					{ 17, 5, 13, 21, 9 },
					{ 10, 18, 1, 14, 22 },
					{ 23, 6, 19, 2, 15 }
				};*/

			for (int i = 0; i < 5; ++i)
			{
				for (int j = 0; j < 5; ++j)
				{
					Console.Write("{0,3} ", array[i, j]);
				}

				Console.WriteLine();
			}

			int temp = 0;

			for (int i = 0; i < 5; ++i)
			{
				int tempStr = 0;

				for (int j = 0; j < 5; ++j)
				{
					tempStr += array[i, j];
				}

				if (temp == 0)
				{
					temp = tempStr;
				}
				else
				{
					if (temp != tempStr)
					{
						Console.WriteLine("Не является магическим квадратом");
						return;
					}
				}
			}

			for (int i = 0; i < 5; ++i)
			{
				int tempCol = 0;

				for (int j = 0; j < 5; ++j)
				{
					tempCol += array[j, i];
				}

				if (temp != tempCol)
				{
					Console.WriteLine("Не является магическим квадратом");
					return;
				}
			}

			int tempDiag = 0;

			for (int i = 0; i < 5; ++i)
			{
				tempDiag += array[i, i];
			}

			if (temp != tempDiag)
			{
				Console.WriteLine("Не является магическим квадратом");
				return;
			}

			tempDiag = 0;

			for (int i = 0; i < 5; ++i)
			{
				tempDiag += array[4-i, i];
			}

			if (temp != tempDiag)
			{
				Console.WriteLine("Не является магическим квадратом");
				return;
			}
			else
			{
				Console.WriteLine("Является магическим квадратом");
			}
		}

		private static void solution_14()
		{
			double s;
			double t;
		input_14_1:
			Console.Write("Введите s: ");

			try
			{
				s = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_14_1;
			}

		input_14_2:
			Console.Write("Введите t: ");
			
			try
			{
				t = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_14_2;
			}

			f14 f = delegate (double a, double b, double c)
			{

				return (2 * a - b - Math.Sin(c)) / (5 + Math.Abs(c));
			};

			double result = f(t, -2 * s, 1.17) + f(2.2, t, s - t);
			Console.WriteLine("Результат: {0}", result);
		}

		private static void solution_13()
		{
			uint n;

		input_13:
			Console.Write("Введите n: ");

			try
			{
				n = Convert.ToUInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_13;
			}

			if (n == 0)
			{
				Console.WriteLine("0? А смысл? Вводи снова");
				goto input_13;
			}

			int[,] array = new int[n, n];
			Random r = new Random();

			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j)
				{
					array[i, j] = r.Next(-9, 10);
					Console.Write("{0,2} ", array[i, j]);
				}

				Console.WriteLine();
			}

			Console.WriteLine();
			int[] arrayOut = new int[n];

			for (int i = 0; i < n; ++i)
			{
				if (array[i, i] < 0)
				{
					for (int j = 0; array[i, j] >= 0; ++j)
					{
						arrayOut[i] += array[i, j];
					}
				}
				else
				{
					bool isFirstPositive = false;

					for (int j = 0; j < n; ++j)
					{
						if (!isFirstPositive && array[i, j] >= 0)
						{
							isFirstPositive = true;
						}

						if (isFirstPositive)
						{
							arrayOut[i] += array[i, j];
						}
					}
				}
			}

			for (int i = 0; i < n; ++i)
			{
				Console.Write(arrayOut[i] + " ");
			}

			Console.WriteLine();
		}

		private static void solution_12()
		{
			uint n;

		input_12:
			Console.Write("Введите n: ");

			try
			{
				n = Convert.ToUInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_12;
			}

			if (n == 0)
			{
				Console.WriteLine("n - не натуральное");
				goto input_12;
			}

			Console.WriteLine("\nЖми кнопку для рисования...");
			Console.ReadKey(true);
			Console.Clear();
			Graphics g = Graphics.FromHwnd(GetConsoleWindow());
			Brush[] brush = new Brush[n];
			Random rBrush = new Random();

			for (int i = 0; i < n; ++i)
			{
				brush[i] = new SolidBrush(
					Color.FromArgb
					(
						rBrush.Next(0,256), 
						rBrush.Next(0, 256), 
						rBrush.Next(0, 256)
					));
			}

			Random r = new Random();
			int[] array = new int[4 * n];

			for (int i = 0; i < 4 * n; ++i)
			{
				array[i] = r.Next(1, 301);
			}

			for (int i = 0; i < 4 * n; i += 4)
			{
				g.FillRectangle
				(
					brush[i / 4],
					array[i] - array[i + 2] / 2 + 200,
					array[i + 1] - array[i + 3] / 2 + 100,
					array[i + 2],
					array[i + 3]
				);
			}

			Console.ReadKey(true);
			g.Clear(Color.Black);
		}

		private static void solution_11()
		{
			uint n;

		input_11:
			Console.Write("Введите n: ");

			try
			{
				n = Convert.ToUInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_11;
			}

			if (n == 0)
			{
				Console.WriteLine("n - не натуральное");
				goto input_11;
			}

			bool isFound = false;

			for (int a = 1; a <= n; ++a)
			{
				for (int b = a; b <= n; ++b)
				{
					for (int c = b; c <= n; ++c)
					{
						if (a * a + b * b == c * c)
						{
							isFound = true;
							Console.WriteLine("{0}, {1}, {2}", a, b, c);
						}
					}
				}
			}

			if (!isFound)
			{
				Console.WriteLine("Тройки не найдены");
			}
		}

		private static void solution_10()
		{
			const int sLength = 10;
			char[] s = new char[sLength+1];
		input_10:
			Console.WriteLine("Введите n: ");
			uint n;

			try
			{
				n = Convert.ToUInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_10;
			}

			if (n == 0)
			{
				Console.WriteLine("n - не натуральное");
				goto input_10;
			}

			char[] t = new char[n];
			Random rs = new Random();

			for (int i = 0; i < sLength; ++i)
			{
				s[i] = (char)rs.Next('a','c');
			}

			Console.WriteLine(s);

			for (int i = 0; i < n; ++i)
			{
				t[i] = (char)rs.Next('a', 'c');
			}

			Console.WriteLine(t);

			for (int i = 0; i < n - 9; ++i)
			{
				if (s[0] == t[i])
				{
					for (int j = 0; j < 10; ++j)
					{
						if (s[j] != t[j + i])
						{
							break;
						}

						if (j == 9)
						{
							Console.Write(i + " ");
						}
					}
				}
			}

			Console.WriteLine();
		}

		private static void solution_09()
		{
			Console.WriteLine("\nЖми кнопку для рисования...");
			Console.ReadKey(true);
			Console.Clear();
			Timer timer = new Timer(new TimerCallback(TimerTick),null,500,500);
			Console.ReadKey(true);
			timer.Dispose();
		}

		static bool isPoints = true;

		private static void TimerTick(object state)
		{
			Graphics g = Graphics.FromHwnd(GetConsoleWindow());
			Bitmap bmp = new Bitmap(600, 300, g);
			Graphics gBmp = Graphics.FromImage(bmp);
			gBmp.Clear(Color.Black);
			Brush brush = Brushes.Aqua;
			Point[,,] fullNumberTemplate =
				new Point[,,]
				{
					{
						{//верхний сегмент
							new Point(0+30, 30),
							new Point(100+30, 30),
							new Point(70+30, 50),
							new Point(30+30, 50)
						},
						{//левый верхний сегмент
							new Point(0+30, 30),
							new Point(0+30, 130),
							new Point(20+30, 100),
							new Point(20+30, 60)
						},
						{//правый верхний сегмент
							new Point(100+30, 30),
							new Point(100+30, 130),
							new Point(80+30, 100),
							new Point(80+30, 60)
						},
						{//верхний средний сегмент
							new Point(0+30, 130),
							new Point(100+30, 130),
							new Point(70+30, 120),
							new Point(30+30, 120)
						},
						{//нижний средний сегмент
							new Point(0+30, 130),
							new Point(100+30, 130),
							new Point(70+30, 140),
							new Point(30+30, 140)
						},
						{//левый нижний сегмент
							new Point(0+30, 130),
							new Point(0+30, 230),
							new Point(20+30, 200),
							new Point(20+30, 160)
						},
						{//правый нижний сегмент
							new Point(100+30, 130),
							new Point(100+30, 230),
							new Point(80+30, 200),
							new Point(80+30, 160)
						},
						{//нижний сегмент
							new Point(0+30, 230),
							new Point(100+30, 230),
							new Point(70+30, 210),
							new Point(30+30, 210)
						}
					},
					{//вторая цифра
						{//верхний сегмент
							new Point(0+150, 30),
							new Point(100+150, 30),
							new Point(70+150, 50),
							new Point(30+150, 50)
						},
						{//левый верхний сегмент
							new Point(0+150, 30),
							new Point(0+150, 130),
							new Point(20+150, 100),
							new Point(20+150, 60)
						},
						{//правый верхний сегмент
							new Point(100+150, 30),
							new Point(100+150, 130),
							new Point(80+150, 100),
							new Point(80+150, 60)
						},
						{//верхний средний сегмент
							new Point(0+150, 130),
							new Point(100+150, 130),
							new Point(70+150, 120),
							new Point(30+150, 120)
						},
						{//нижний средний сегмент
							new Point(0+150, 130),
							new Point(100+150, 130),
							new Point(70+150, 140),
							new Point(30+150, 140)
						},
						{//левый нижний сегмент
							new Point(0+150, 130),
							new Point(0+150, 230),
							new Point(20+150, 200),
							new Point(20+150, 160)
						},
						{//правый нижний сегмент
							new Point(100+150, 130),
							new Point(100+150, 230),
							new Point(80+150, 200),
							new Point(80+150, 160)
						},
						{//нижний сегмент
							new Point(0+150, 230),
							new Point(100+150, 230),
							new Point(70+150, 210),
							new Point(30+150, 210)
						}
					},
					{//третья цифра
						{//верхний сегмент
							new Point(0+300, 30),
							new Point(100+300, 30),
							new Point(70+300, 50),
							new Point(30+300, 50)
						},
						{//левый верхний сегмент
							new Point(0+300, 30),
							new Point(0+300, 130),
							new Point(20+300, 100),
							new Point(20+300, 60)
						},
						{//правый верхний сегмент
							new Point(100+300, 30),
							new Point(100+300, 130),
							new Point(80+300, 100),
							new Point(80+300, 60)
						},
						{//верхний средний сегмент
							new Point(0+300, 130),
							new Point(100+300, 130),
							new Point(70+300, 120),
							new Point(30+300, 120)
						},
						{//нижний средний сегмент
							new Point(0+300, 130),
							new Point(100+300, 130),
							new Point(70+300, 140),
							new Point(30+300, 140)
						},
						{//левый нижний сегмент
							new Point(0+300, 130),
							new Point(0+300, 230),
							new Point(20+300, 200),
							new Point(20+300, 160)
						},
						{//правый нижний сегмент
							new Point(100+300, 130),
							new Point(100+300, 230),
							new Point(80+300, 200),
							new Point(80+300, 160)
						},
						{//нижний сегмент
							new Point(0+300, 230),
							new Point(100+300, 230),
							new Point(70+300, 210),
							new Point(30+300, 210)
						}
					},
					{//четвёртая цифра
						{//верхний сегмент
							new Point(0+420, 30),
							new Point(100+420, 30),
							new Point(70+420, 50),
							new Point(30+420, 50)
						},
						{//левый верхний сегмент
							new Point(0+420, 30),
							new Point(0+420, 130),
							new Point(20+420, 100),
							new Point(20+420, 60)
						},
						{//правый верхний сегмент
							new Point(100+420, 30),
							new Point(100+420, 130),
							new Point(80+420, 100),
							new Point(80+420, 60)
						},
						{//верхний средний сегмент
							new Point(0+420, 130),
							new Point(100+420, 130),
							new Point(70+420, 120),
							new Point(30+420, 120)
						},
						{//нижний средний сегмент
							new Point(0+420, 130),
							new Point(100+420, 130),
							new Point(70+420, 140),
							new Point(30+420, 140)
						},
						{//левый нижний сегмент
							new Point(0+420, 130),
							new Point(0+420, 230),
							new Point(20+420, 200),
							new Point(20+420, 160)
						},
						{//правый нижний сегмент
							new Point(100+420, 130),
							new Point(100+420, 230),
							new Point(80+420, 200),
							new Point(80+420, 160)
						},
						{//нижний сегмент
							new Point(0+420, 230),
							new Point(100+420, 230),
							new Point(70+420, 210),
							new Point(30+420, 210)
						}
					}
				};
			bool[,] arraySegments =
				new bool[10, 8]
				{
					{//0
						true,true,true,false,false,true,true,true
					},
					{//1
						false,false,true,false,false,false,true,false
					},
					{//2
						true,false,true,true,true,true,false,true
					},
					{//3
						true,false,true,true,true,false,true,true
					},
					{//4
						false,true,true,true,true,false,true,false
					},
					{//5
						true,true,false,true,true,false,true,true
					},
					{//6
						true,true,false,true,true,true,true,true
					},
					{//7
						true,false,true,false,false,false,true,false
					},
					{//8
						true,true,true,true,true,true,true,true
					},
					{//9
						true,true,true,true,true,false,true,true
					}
				};
			string time =
				(DateTime.Now.Hour < 10 ? ("0" + DateTime.Now.Hour.ToString()) : DateTime.Now.Hour.ToString()) +
				(DateTime.Now.Minute < 10 ? ("0" + DateTime.Now.Minute.ToString()) : DateTime.Now.Minute.ToString());

			for (int i = 0; i < time.Length; ++i)
			{
				for (int j = 0; j < 8; ++j)
				{
					if (!arraySegments[time[i] - '0', j])
					{
						continue;
					}

					Point[] temp = new Point[4];

					for (int k = 0; k < 4; ++k)
					{
						temp[k] = fullNumberTemplate[i, j, k];
					}

					gBmp.FillPolygon(brush, temp);
				}
			}

			if (isPoints)
			{
				gBmp.FillEllipse(brush, 270, 100, 10, 10);
				gBmp.FillEllipse(brush, 270, 160, 10, 10);
				isPoints = false;
			}
			else
			{
				isPoints = true;
			}

			g.DrawImageUnscaled(bmp, 0, 0);
			gBmp.Dispose();
		}

		private static void solution_08()
		{
			int a1 = 1;
			int a2 = 1;
			const int arrayLength = 30;
			int[] array = new int[arrayLength];
			array[0] = a1;
			array[1] = a2;

			for (int i = 2; i < arrayLength; ++i)
			{
				array[i] = array[(i + 1) / 2 - 1] + array[i - 2];
			}

			for (int i = 0; i < arrayLength; ++i)
			{
				Console.Write(array[i] + " ");

				if (i % 10 == 9)
				{
					Console.WriteLine();
				}
			}
		}

		private static void solution_07()
		{
			uint n;
		input_7:
			Console.Write("Введите n: ");
			
			try
			{
				n = Convert.ToUInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_7;
			}

			if (n == 0)
			{
				Console.WriteLine("0 - не подходит. Вводи снова");
				goto input_7;
			}
			
			char[] s = new char[n+1];
			Random r = new Random();

			for (int i = 0; i < n + 1; ++i)
			{
				s[i] = (char)r.Next('а', 'я');
			}

			Console.WriteLine(s);
			bool isFound = false;

			for (int i = 0; i < n; ++i)
			{
				if (s[i] == 'а' && s[i] == s[i + 1])
				{
					Console.WriteLine("i = {0}", i);
					isFound = true;
					break;
				}
			}

			if (!isFound)
			{
				Console.WriteLine(0);
			}
		}

		private static void solution_06()
		{
			Console.WriteLine("\nЖми кнопку для рисования...");
			Console.ReadKey(true);
			Console.Clear();
			Random r = new Random();
			const int arrayLength = 7;
			int[] array = new int[arrayLength];

			for (int i = 0; i < arrayLength; ++i)
			{
				array[i] = r.Next(1, 10);
				Console.Write(array[i] + " ");
			}

			Graphics g = Graphics.FromHwnd(GetConsoleWindow());
			Pen[] pen = new Pen[]
			{ 
				new Pen(Color.Red, 2),
				new Pen(Color.Orange, 2),
				new Pen(Color.Yellow, 2),
				new Pen(Color.Green, 2),
				new Pen(Color.Cyan, 2),
				new Pen(Color.Blue, 2),
				new Pen(Color.Violet, 2),
				new Pen(Color.White, 2)
			};
			int x = 10;
			int y = 120;
			g.DrawLine(pen[7], x, y, 160, y);

			for (int i = 0; i < arrayLength; ++i)
			{
				g.DrawRectangle(pen[i], x + 20 * i + 10, y - 10 * array[i], 10, 10 * array[i]);
			}

			Console.ReadKey(true);
			g.Clear(Color.Black);
		}

		private static void solution_05()
		{
			int n;
			int a;
		input_5_1:
			Console.Write("Введите n: ");
			
			try
			{
				n = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_5_1;
			}
		
			int[] array = new int[n];
			Random rand = new Random();

			for (int i = 0; i < n; ++i)
			{
				array[i] = rand.Next(-100, 101);
				Console.Write(array[i] + "\t");
			}

		input_5_2:
			Console.Write("\nВведите a: ");

			try
			{
				a = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_5_2;
			}

			int sum = -10;
			bool isSum = false;

			for (int i = 0; i < n; ++i)
			{
				if (array[i] == a && !isSum)
				{
					isSum = true;
					sum = 0;
					continue;
				}

				if (isSum)
				{
					sum += array[i];
				}
			}

			Console.WriteLine(isSum ? ("Сумма: " + sum.ToString()) : sum.ToString());

		}

		private static void solution_04()
		{
			int p;
			int q;
		input_4_1:
			Console.Write("Введите p: ");

			try
			{
				p = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_4_1;
			}

		input_4_2:
			Console.Write("Введите q: ");

			try
			{
				q = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				goto input_4_2;
			}

			if (p <= q || q < 0)
			{
				Console.WriteLine("Не соответствует условию p > q >= 0. Вводи снова");
				goto input_4_1;
			}

			const int arrayLength = 67;
			int[] array = new int[arrayLength];
			Random rand = new Random();

			for (int i = 0; i < arrayLength; ++i)
			{
				array[i] = rand.Next(-100, 101);
				Console.Write(array[i] + "\t");
			}

			Console.WriteLine("\n");

			for (int i = 0; i < arrayLength; ++i)
			{
				if (Math.Abs(array[i]) % p == 0)
				{
					array[i] = 0;
				}
			}

			for (int i = 0; i < arrayLength; ++i)
			{
				Console.Write(array[i] + "\t");
			}

			Console.WriteLine();
		}

		private static void solution_03()
		{
			Console.WriteLine("\nЖми кнопку для рисования...");
			Console.ReadKey(true);
			Console.Clear();
			Graphics g = Graphics.FromHwnd(GetConsoleWindow());
			Pen pen = new Pen(Color.Red, 2);
			Brush brush = Brushes.Aqua;
			Point[] treangle = 
				new Point[]
				{
					new Point(100, 100), 
					new Point(150, 100), 
					new Point(80, 170)
				};
			g.DrawPolygon(pen, treangle);
			g.FillPolygon(brush, treangle);
			Point[] rectangle =
				new Point[]
				{
					new Point(180, 80),
					new Point(270, 80),
					new Point(270, 150),
					new Point(180, 150)
				};
			pen = Pens.Brown;
			brush = Brushes.Yellow;
			g.DrawPolygon(pen, rectangle);
			g.FillPolygon(brush, rectangle);
			Point[] pentagon =
				new Point[]
				{
					new Point(300, 100),
					new Point(350, 100),
					new Point(370, 120),
					new Point(350, 140),
					new Point(300, 120)
				};
			pen = Pens.Blue;
			brush = Brushes.Green;
			g.DrawPolygon(pen, pentagon);
			g.FillPolygon(brush, pentagon);
			Point[] hexagon =
				new Point[]
				{
					new Point(420, 100),
					new Point(440, 120),
					new Point(440, 140),
					new Point(420, 160),
					new Point(400, 140),
					new Point(400, 120)
				};
			pen = Pens.Pink;
			brush = Brushes.Orange;
			g.DrawPolygon(pen, hexagon);
			g.FillPolygon(brush, hexagon);
			Console.ReadKey(true);
			g.Clear(Color.Black);
		}

		private static void solution_02()
		{
			const int arrayLength = 70;
			double[] array = new double[arrayLength + 1];
			Random randomNumber = new Random();

			for (int i = 0; i < arrayLength; ++i)
			{
				array[i] = randomNumber.Next(-9, 10);
				Console.Write(array[i] + "\t");
			}

			Console.WriteLine();
			array[arrayLength] = array[0];

			for (int i = 1; i < arrayLength + 1; ++i)
			{
				Console.Write(array[i] + "\t");
			}

			Console.WriteLine();
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

			double x; 
			double y;

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
