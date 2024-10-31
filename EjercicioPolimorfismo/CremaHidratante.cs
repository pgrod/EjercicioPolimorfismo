namespace EjercicioPolimorfismo
{
    public class CremaHidratante : SkinCare
    {
        public void Vender(string Marca)
        {
            Console.WriteLine($"Crema tipo {Producto} de marca {Marca} para aplicar en {aplicacion} ha sido vendido por el precio de {precio} lempiras");
        }
    }
}
