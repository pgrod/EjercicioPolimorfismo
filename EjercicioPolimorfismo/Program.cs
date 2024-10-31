using EjercicioPolimorfismo;

SkinCare skinCare = new SkinCare();
Serum serum = new Serum();
CremaHidratante cremaHidratante = new CremaHidratante();
Limpiador limpiador = new Limpiador();

Console.WriteLine("Ingrese el tipo de producto:");
string producto = Console.ReadLine();

Console.WriteLine("Ingrese la marca del producto:");
string marca = Console.ReadLine();

Console.WriteLine("Ingrese la aplicación del producto:");
string aplicacion = Console.ReadLine();

Console.WriteLine("Ingrese el precio del producto:");
double precio = Convert.ToDouble(Console.ReadLine());

skinCare.Vender();
