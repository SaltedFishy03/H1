//XXXX skal udskiftes med den korrekte kode

namespace sange
{
    class Program

    {

        static void Main(string[] args)
        {
            string[] Sange = { "Old time road", "Paris", "SOS", "So Am I" };

            Console.WriteLine("Her er mine ynglingssange");

            foreach (string ynglingssange in Sange)
            {
                Console.WriteLine(ynglingssange);
            }

            Console.ReadKey();
        }
    }
}