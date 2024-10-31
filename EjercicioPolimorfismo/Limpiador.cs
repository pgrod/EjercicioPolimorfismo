using static System.Net.Mime.MediaTypeNames;

namespace EjercicioPolimorfismo
{
    public class Limpiador : SkinCare
    {
        public Limpiador() { }

        public Limpiador(string Marca)
        {
            this.Marca = Marca;
        }
        public Limpiador(string Producto,string aplicacion)
        {
            this.Producto = Producto;
            this.aplicacion = aplicacion;
        }
        public Limpiador(double precio)
        {
            this.precio = precio;
        }
        public void Vender(string Producto, string Marca, string aplicacion, double precio)
        {
            Console.WriteLine($"Producto tipo {Producto} de marca {Marca} para aplicar en {aplicacion} ha sido vendido por el precio de {precio} lempiras");
        }
    }
}
