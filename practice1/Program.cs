// class Program{

//     static void printmsg()
//     {
//         Console.WriteLine("This is first session");
//     }
    
//     static void createmsg()
//     {
//         Console.WriteLine("Hi");
//     }
    
//     static void Main(string [] arg)
//     {
//         Console.WriteLine("Welcome to csarp");

//         printmsg();

//         createmsg();
//     }
// }

class Program{


    static void Main(string [] arg){
        Console.WriteLine("To Practice method overflow");

        Console.WriteLine(add(10,5));

        Console.WriteLine(add(10,5,5));

        Console.WriteLine(add(10.5,5,5));

        Console.WriteLine("Concatenated string is:"+ add("Mani","Mohana"));
        
        Console.WriteLine(subtract(10,5));

        constructordemo d=new constructordemo();
        d.demo();
   
    }

    static int add(int a, int b )
    {
        return a+b;
    }

    static int add(int a, int b, int c )
    {
        return a+b+c;
    }

    static double add(double a, double b, double c )
    {
        return a+b+c;
    }

    static string add(string a, string b )
    {
        return a+b;
    }

    static int subtract(int a, int b )
    {
        return a-b;
    }


}

class constructordemo{
    
    public void demo()
    {
        Console.WriteLine("write method");
    }
    public  constructordemo()
    {
        Console.WriteLine("write constructor");
    }
   
}
   
