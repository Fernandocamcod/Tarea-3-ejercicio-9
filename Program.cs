using System;

class MaquinaExpendedora
{
    static void Main()
    {
        // Arreglo de productos y precios
        string[] productos = { "1. Agua", "2. Refresco", "3. Snack", "4. Galletas", "5. Café" };
        double[] precios = { 1.50, 1.75, 2.00, 1.25, 2.50 };

        Console.WriteLine("Bienvenido a la Máquina Expendedora");
        Console.WriteLine("Seleccione un producto:");

        // Mostrar los productos y sus precios
        for (int i = 0; i < productos.Length; i++)
        {
            Console.WriteLine($"{productos[i]} - Precio: ${precios[i]:F2}");
        }

        // Solicitar la selección del producto
        Console.Write("Ingrese el número del producto que desea comprar (1-5): ");
        int seleccion = Convert.ToInt32(Console.ReadLine()) - 1; // Restar 1 para usar como índice

        // Verificar que la selección sea válida
        if (seleccion < 0 || seleccion >= productos.Length)
        {
            Console.WriteLine("Selección no válida. Por favor, seleccione un número entre 1 y 5.");
            return; // Salir del programa si la selección es inválida
        }

        // Solicitar el pago
        Console.Write($"El precio de {productos[seleccion]} es: ${precios[seleccion]:F2}. Ingrese el dinero: ");
        double dineroIngresado = Convert.ToDouble(Console.ReadLine());

        // Procesar la selección del producto
        switch (seleccion)
        {
            case 0: // Agua
            case 1: // Refresco
            case 2: // Snack
            case 3: // Galletas
            case 4: // Café
                if (dineroIngresado >= precios[seleccion])
                {
                    double cambio = dineroIngresado - precios[seleccion];
                    Console.WriteLine($"Gracias por su compra. Ha recibido: {productos[seleccion]}.");
                    if (cambio > 0)
                    {
                        Console.WriteLine($"Su cambio es: ${cambio:F2}");
                    }
                }
                else
                {
                    Console.WriteLine("Dinero insuficiente. No se puede completar la compra.");
                }
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
