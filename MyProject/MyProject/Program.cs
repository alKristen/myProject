namespace ClassDot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] dotX = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] dotY = { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };

            Dot coordinates1 = new Dot();
            coordinates1.DotX = 1;
            coordinates1.DotY = -1;

            Dot coordinates2 = new Dot();
            coordinates2.DotX = 2;
            coordinates2.DotY = -2;

            Dot coordinates3 = new Dot();
            coordinates3.DotX = 3;
            coordinates3.DotY = -3;

            Dot coordinates4 = new Dot();
            coordinates4.DotX = 4;
            coordinates4.DotY = -4;

            Dot coordinates5 = new Dot();
            coordinates5.DotX = 5;
            coordinates5.DotY = -5;

            Dot coordinates6 = new Dot();
            coordinates6.DotX = 6;
            coordinates6.DotY = -6;

            Dot coordinates7 = new Dot();
            coordinates7.DotX = 7;
            coordinates7.DotY = -7;

            Dot coordinates8 = new Dot();
            coordinates8.DotX = 8;
            coordinates8.DotY = -8;

            Dot coordinates9 = new Dot();
            coordinates9.DotX = 9;
            coordinates9.DotY = -9;

            Dot coordinates10 = new Dot();
            coordinates10.DotX = 10;
            coordinates10.DotY = -10;

            Dot[] coordinates = { coordinates1, coordinates2, coordinates3, coordinates4, coordinates5, coordinates6, coordinates7, coordinates8, coordinates9, coordinates10 };

            foreach (Dot coordinate in coordinates)
            {
                Console.WriteLine(coordinate.GeInfo());
            }
        }
    }
}

