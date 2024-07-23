namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            #region First project

            #region Q3
            // 3-- Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            Point p1 = new Point();
            Point p2 = new Point();

            /*Console.WriteLine("please enter x of p1");
            p1.X=int.Parse(Console.ReadLine());
            p1.X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter y of p1");
            //p1.Y = int.Parse(Console.ReadLine());
            p1.Y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter Z of p1");
            //p1.Z = int.Parse(Console.ReadLine());
            p1.Z = Convert.ToInt32(Console.ReadLine());*/
            /* int x1;
            do
            {
                Console.WriteLine("please enter x of p1");
            } while (!int.TryParse(Console.ReadLine(), out x1));
            p1.X = x1;

            int y1;
            do
            {
                Console.WriteLine("please enter y of p1");
            } while (!int.TryParse(Console.ReadLine(), out y1));
            p1.Y = y1;

            int z1;
            do
            {
                Console.WriteLine("please enter z of p1");
            } while (!int.TryParse(Console.ReadLine(), out z1));
            p1.Z = z1;

            int x2;
            do
            {
                Console.WriteLine("please enter x of p2");
            } while (!int.TryParse(Console.ReadLine(), out x2));
            p2.X = x2;

            int y2;
            do
            {
                Console.WriteLine("please enter y of p2");
            } while (!int.TryParse(Console.ReadLine(), out y2));
            p2.Y = y2;

            int z2;
            do
            {
                Console.WriteLine("please enter z of p2");
            } while (!int.TryParse(Console.ReadLine(), out z2));
            p2.Z = z2;


            Console.WriteLine($"{p1}\n{p2}");*/

            #endregion

            #region Q4
            // 4-- Try to use ==If(P1 == P2)   Does it work properly? 

            /*if (p1 == p2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }*/

            //although they have the same value but operator == compare between two addresses not the value
            #endregion

            #region Q5
            //5--Define an array of points and sort this array based on X & Y coordinates.
            /*Point[] points=new Point[2];
            Array.Sort(points);*/
            #endregion


            #endregion
            
            #region Second project
            /*Maths m=new Maths();
            m.Add(5, 10);
            m.Subtract(15, 10);
            m.Multiply(5, 10);
            m.Divide(50, 10);*/
            Maths.Subtract(10, 5);
            Maths.Multiply(10, 5);
            Maths.Divide(10, 5);
            Maths.Add(10, 5);

            #endregion

            #region Third project


            Duration d= new Duration(7200);
            Console.WriteLine(d);
            DateTime dateTime = new DateTime();
            Console.WriteLine(dateTime.Hour);

            #endregion
        }
    }

   
}
