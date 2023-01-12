namespace githubb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             int n = int.Parse(Console.ReadLine());
            int idk = 1;
            Console.WriteLine("otpechatva chislata ot 1 do N prez 3");
            for (var i = 0; i >= n; i=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}