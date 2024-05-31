using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task27
{
    enum L1st { InputLowercase = 1, OutPut = 2, convertToUppercase, Count, InputInEnd,InputInBeginning, DeleteThirdElem,SortReverse,Exit } 
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<string> st = new List<string>();
                st.Add("ТПАПАПАП");
                Console.Clear();
                Console.WriteLine("Введите действие над коллекцией\nДобавить в список элемент строчными буквами - 1\nВывести содержимое коллекции - 2\nПреобразовать все буквы элементов в прописные - 3\nОпределить кол-во элементов коллекции - 4\nДобавить элемент в конец коллекции - 5\nДобавить элемент в начало коллекции - 6\nУдалить 3-й элемент коллекции - 7\nРасположить элементы в обратном порядке - 7\nExit - 8");
                int act = int.Parse(Console.ReadLine());
                L1st ll = (L1st)act;
                switch (ll)
                {
                    case L1st.InputLowercase:
                        Console.Clear();
                        Console.Write("Введите элемент, который нужно добавить строчными буквами в коллекцию: ");
                        string elem1 = Console.ReadLine();
                        st.Add(elem1.ToLower());
                        Console.ReadKey();
                        break;
                    case L1st.OutPut:
                        Console.Clear();
                        foreach(var eleem in st)
                        {
                            Console.WriteLine(eleem);
                        }
                        Console.ReadKey();
                        break;
                    case L1st.convertToUppercase:
                        foreach(var elem3 in st)
                        {
                            elem3.ToUpper();
                        }
                        break;
                    case L1st.Count:
                        Console.Write($"Кол-во элементов в коллекции: {st.Count()}");
                        Console.ReadKey();
                        break;
                    case L1st.InputInEnd:
                        Console.Clear();
                        Console.Write("Введите элемент, который нужно добавить в конец коллекции: ");
                        string elem4 = Console.ReadLine();
                        st.Add(elem4);
                        break;
                    case L1st.InputInBeginning:
                        Console.Clear();
                        Console.Write("Введите элемент, который нужно добавить в начало коллекции: ");
                        string elem5 = Console.ReadLine();
                        st.Insert(0, elem5);
                        break;
                    case L1st.DeleteThirdElem:
                        st.RemoveAt(3);
                        break;
                    case L1st.SortReverse:
                        st.Reverse();
                        break;
                    case L1st.Exit:
                        return;
                    

                }


            }
        }
    }
}
