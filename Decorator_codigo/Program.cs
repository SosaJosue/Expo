internal class Program
{
    private static void Main(string[] args)
    {
        Bebida un_cafe = new CafeLatte();
        un_cafe = new Azucar(un_cafe);
        un_cafe = new Leche (un_cafe);
        un_cafe = new Crema (un_cafe);

        Console.WriteLine($"Tipo de bebida: {un_cafe.descripcion} , tiene un valor de: ${un_cafe.Costo}");
    }
}