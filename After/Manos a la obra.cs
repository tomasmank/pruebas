/*string caramelo = "caramelo";
string gaseosa = "gaseosa";
string alfajor = "alfajor";
string chocolate = "chocolate";

int preciocaramelo = 2;
int preciogaseosa = 100;
int precioalfajor = 55;
int preciochocolate = 30;

int totalCliente = 0;
int totalDia = 0;

int Precio(string producto)
{
    if ("caramelo".Equals(producto))
    {
        return preciocaramelo;
    }
    else if("gaseosa".Equals(producto))
    {
        return preciogaseosa;
    }
    else if ("alfajor".Equals(producto))
    {
        return preciogaseosa;
    }
    else if("chocolate".Equals(producto))
    {
        return preciochocolate;
    }
    else
    {
        return 0;
    }
}

int CalcularTotalProducto(int precio, int cantidad)
{
    return precio * cantidad;
}

Console.WriteLine("Bienvenido Lucas!");
string opcion;
do
{
    Console.WriteLine("Ingresa una opcion:");
    Console.WriteLine("1-Consultar Producto");
    Console.WriteLine("2-Pedir Producto");
    Console.WriteLine("3-Finalizar Venta de Cliente");
    Console.WriteLine("9-Finaliza el dia");
    opcion = Console.ReadLine();
    ProcesarOpcion(opcion);
} while (!opcion.Equals("9"));

do
{
    Console.WriteLine("Ingresa una opcion:");
    Console.WriteLine("1-Ventas del dia");
    Console.WriteLine("2-Ganancias del dia");
    Console.WriteLine("3-Salario del dia");
    Console.WriteLine("9-Finaliza el dia");
    opcion = Console.ReadLine();
    ProcesarOpcion(opcion);
} while (!opcion.Equals("FIN"));


void ProcesarOpcion(string opcion)
{
    if (opcion.Equals("1"))
    {
        string producto = Console.ReadLine();
        int precio=Precio(producto);
        Console.WriteLine("el precio de :"+producto+" es: "+precio);
    }
    else if (opcion.Equals("2"))
    {

    }
    else if (opcion.Equals("3"))
    {

    }
    else if (opcion.Equals("9"))
    {
        Console.WriteLine("Ya casi te podes ir a descansar! Felicidades!");
    }
    else
    {
        Console.WriteLine("Te equivocaste de numero, no tenemos opcion "+opcion);
    }
}*/





/* string caramelo = "caramelo";
string gaseosa = "gaseosa";
string alfajor = "alfajor";
string chocolate = "chocolate";

int preciocaramelo = 2;
int preciogaseosa = 100;
int precioalfajor = 55;
int preciochocolate = 30;
int vervariable=DevolverPrecio("caramelos");
int totalCliente = 0;

int PrecioProductos(string producto, int cantidad)
{
    int precio = DevolverPrecio(producto);
    return precio * cantidad;
}

int DevolverPrecio(string producto)
{

    if ("caramelo".Equals(producto))
    {
        return preciocaramelo;
    }
    else if ("gaseosa".Equals(producto))
    {
        return preciogaseosa;
    }
    else if ("alfajor".Equals(producto))
    {
        return preciogaseosa;
    }
    else if ("chocolate".Equals(producto))
    {
        return preciochocolate;
    }
    else
    {
        return 0;
    }
}*/