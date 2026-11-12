
using EstructurasLinealesEstaticas;

PilaEstatica pila = new PilaEstatica(5);
ColaSimple cola = new ColaSimple(5);
ColaCircular circular = new ColaCircular(5);

int opcion;

do
{
    Console.WriteLine("\n===== ESTRUCTURAS LINEALES ESTATICAS =====");
    Console.WriteLine("1. Pila estatica");
    Console.WriteLine("2. Cola simple");
    Console.WriteLine("3. Cola circular");
    Console.WriteLine("0. Salir");
    Console.Write("Selecciona una opcion: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Opcion no valida.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            MenuPila(pila);
            break;

        case 2:
            MenuCola(cola);
            break;

        case 3:
            MenuCircular(circular);
            break;

        case 0:
            Console.WriteLine("Programa finalizado.");
            break;

        default:
            Console.WriteLine("Opcion no valida.");
            break;
    }

} while (opcion != 0);


static void MenuPila(PilaEstatica pila)
{
    int opcion;

    do
    {
        Console.WriteLine("\n===== PILA ESTATICA =====");
        Console.WriteLine("1. Push");
        Console.WriteLine("2. Pop");
        Console.WriteLine("3. Peek");
        Console.WriteLine("4. Mostrar");
        Console.WriteLine("5. IsEmpty");
        Console.WriteLine("6. IsFull");
        Console.WriteLine("0. Regresar");
        Console.Write("Opcion: ");

        if (!int.TryParse(Console.ReadLine(), out opcion))
            continue;

        switch (opcion)
        {
            case 1:
                Console.Write("Numero: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                    pila.Push(valor);
                break;

            case 2:
                Console.WriteLine("Eliminado: " + pila.Pop());
                break;

            case 3:
                Console.WriteLine("Superior: " + pila.Peek());
                break;

            case 4:
                pila.Mostrar();
                break;

            case 5:
                Console.WriteLine(pila.IsEmpty());
                break;

            case 6:
                Console.WriteLine(pila.IsFull());
                break;
        }

    } while (opcion != 0);
}


static void MenuCola(ColaSimple cola)
{
    int opcion;

    do
    {
        Console.WriteLine("\n===== COLA SIMPLE =====");
        Console.WriteLine("1. Enqueue");
        Console.WriteLine("2. Dequeue");
        Console.WriteLine("3. Peek");
        Console.WriteLine("4. Mostrar");
        Console.WriteLine("5. IsEmpty");
        Console.WriteLine("6. IsFull");
        Console.WriteLine("0. Regresar");
        Console.Write("Opcion: ");

        if (!int.TryParse(Console.ReadLine(), out opcion))
            continue;

        switch (opcion)
        {
            case 1:
                Console.Write("Numero: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                    cola.Enqueue(valor);
                break;

            case 2:
                Console.WriteLine("Eliminado: " + cola.Dequeue());
                break;

            case 3:
                Console.WriteLine("Primero: " + cola.Peek());
                break;

            case 4:
                cola.Mostrar();
                break;

            case 5:
                Console.WriteLine(cola.IsEmpty());
                break;

            case 6:
                Console.WriteLine(cola.IsFull());
                break;
        }

    } while (opcion != 0);
}


static void MenuCircular(ColaCircular cola)
{
    int opcion;

    do
    {
        Console.WriteLine("\n===== COLA CIRCULAR =====");
        Console.WriteLine("1. Enqueue");
        Console.WriteLine("2. Dequeue");
        Console.WriteLine("3. Peek");
        Console.WriteLine("4. Mostrar");
        Console.WriteLine("5. IsEmpty");
        Console.WriteLine("6. IsFull");
        Console.WriteLine("0. Regresar");
        Console.Write("Opcion: ");

        if (!int.TryParse(Console.ReadLine(), out opcion))
            continue;

        switch (opcion)
        {
            case 1:
                Console.Write("Numero: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                    cola.Enqueue(valor);
                break;

            case 2:
                Console.WriteLine("Eliminado: " + cola.Dequeue());
                break;

            case 3:
                Console.WriteLine("Primero: " + cola.Peek());
                break;

            case 4:
                cola.Mostrar();
                break;

            case 5:
                Console.WriteLine(cola.IsEmpty());
                break;

            case 6:
                Console.WriteLine(cola.IsFull());
                break;
        }

    } while (opcion != 0);
}
