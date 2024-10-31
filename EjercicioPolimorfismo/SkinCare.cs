namespace EjercicioPolimorfismo
{
    public class SkinCare
    {
        public string Producto { get; set; }
        public string Marca { get; set; }
        public string aplicacion { get; set; }
        public double precio { get; set; }

        public SkinCare() { }

        public SkinCare(string Producto, string Marca, string aplicacion, double precio)
        {
            this.Producto = Producto;
            this.Marca = Marca;
            this.aplicacion = aplicacion;
            this.precio = precio;
        }

        public void Vender()
        {
            Console.WriteLine($"Producto tipo {Producto} de marca {Marca} para aplicar en {aplicacion} ha sido vendido por el precio de {precio} lempiras");
        }

        public void Vender(string aplicacion)
        {
            Console.WriteLine($"Crema tipo {Producto} de marca {Marca} para aplicar en {aplicacion} ha sido vendido por el precio de {precio} lempiras");
        }

        public void Vender(double precio)
        {
            Console.WriteLine($"Crema tipo {Producto} de marca {Marca} para aplicar en {aplicacion} ha sido vendido por el precio de {precio} lempiras");
        }
    }
}
