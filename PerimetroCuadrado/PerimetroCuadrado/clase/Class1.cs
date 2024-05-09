namespace PerimetroCuadrado
{
    public class PerimetroCuadrado
    {
        public void CalcularPerimetroCuadrado()
        {

            int lado = 0;
            int resultado = 0;

            try
            {
                Console.WriteLine("Ingrese el valor de los lados de su cuadrado: ");
                lado = int.Parse(Console.ReadLine());

                resultado = lado * 4;

                Console.WriteLine($"El perímetro del cuadrado es: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error inesperado: {ex.Message}");
            }
        }
    }
}
