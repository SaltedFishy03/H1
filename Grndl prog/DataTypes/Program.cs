using System.Security.Cryptography;

namespace DataTypes
{
    public class DataTypes
    {

        public static void Main()
        {
            static void ByteDiagram(int ByteSize)
            {
                for (int i = 0; i < ByteSize; i++)
                {
                    Console.WriteLine(" _______\n|   1   |");
                }
            }

            Console.WriteLine("skriv navnet på den variable du gerne vil vide størelsen på. Du har disse muligheder...\n (Double), (Int), (Char), (Float) og (Array)");
            Console.Write("skriv her... ");
            var type = Console.ReadLine();

            switch (type)
            {
                case "Double":
                    Console.WriteLine($"Byte størelsen på {type}");
                    ByteDiagram(sizeof(double));
                    Console.WriteLine($"Max værdien {type} kan indeholde {double.MaxValue}");
                    break;

                case "Int":
                    Console.WriteLine($"Byte størelsen på {type}");
                    for (int i = 0; i < sizeof(int); i++)
                    {
                        Console.WriteLine(" _______\n|   1   |");
                    }
                    Console.WriteLine($"Her er max værdien {type} can indeholde {int.MaxValue}");
                    break;

                case "Char":
                    Console.WriteLine($"Byte størelsen på {type}");
                    for (int i = 0; i < sizeof(double); i++)
                    {
                        Console.WriteLine(" _______\n|   1   |");
                    }
                    Console.WriteLine($"Her er max værdien {type} can indeholde {char.MaxValue}");
                    break;

                case "Float":
                    Console.WriteLine($"Byte størelsen på {type}");
                    for (int i = 0; i < sizeof(double); i++)
                    {
                        Console.WriteLine(" _______\n|   1   |");
                    }
                    Console.WriteLine($"Her er max værdien float can indeholde {float.MaxValue}");
                    break;

                case "Array":
                    int[] arr = { 1, 2, 3 };
                    Console.WriteLine(arr.Length + 1);
                    Console.WriteLine("Jeg aner ikke hvad max værdien skulle være for et array hvis der overhovdet har et");

                    break;
                default:
                    break;
            }
        }
    }
}