//XXXX skal udskiftes med den korrekte kode

namespace sange

{

    class Program

    {

        static void Main(string[] args)
        {

            string[] Sange = { "Old time road", "Paris", "SOS", "So Am I" };



            Console.WriteLine("Her er mine ynglingssange");



            foreach (string s in Sange)
            {
                Console.WriteLine(s);
            }


            Console.ReadKey();



        }

    }

}