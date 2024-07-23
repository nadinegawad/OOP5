namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region static modifier
            // static is used to declare static members inside class or struct which belongs to the type itself
            // static is used to declare static class 
            // {property,method ,field,CTOR}

            /* MyType m1=new MyType();

             MyType m2=new MyType();

             MyType.MyProp = 5;

            double inch = 19;
            double cm=Helper.convertTCm(inch);
            Console.WriteLine(cm);

            double result = Helper.circleArea(9);
            Console.WriteLine(result);
            Employee m1 = new Employee();
            Employee m2 = new Employee();
            Employee m3 = new Employee();
            Employee m4 = new Employee();
            Employee m5 = new Employee();

            Console.WriteLine(Employee.count);;*/
            #endregion

            #region opertors overloading
            /*
            Complex c1=new Complex() { real = 1 ,imag=2};
            Complex c2=new Complex() {real = 3 ,imag=5};

            Complex c3=c2+c1;

            Complex c4=c3+6;

            Complex c5=4+c2;


            */



            #endregion
        }
    }
    class MyType
    {
        //public int MyProp { get; set; }   instance field

        public static int MyProp { get; set; }  //static property ==>belongs to the type itself

        public void print()  // instance method
        {

        }

        public MyType()
        {

        }
    }
}
