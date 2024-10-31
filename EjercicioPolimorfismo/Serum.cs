namespace EjercicioPolimorfismo
{
    public class Serum : SkinCare
    {
        public void Vender(string Producto)
        {
            Console.WriteLine($"Producto tipo {Producto} de marca {Marca} para aplicar en {aplicacion} ha sido vendido por el precio de {precio} lempiras");
        }
    }
}
