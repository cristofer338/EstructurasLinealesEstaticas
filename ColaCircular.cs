
namespace EstructurasLinealesEstaticas
{
    public class ColaCircular
    {
        private int[] elementos;
        private int front;
        private int rear;
        private int count;
        private int capacidad;

        public ColaCircular(int tamaño)
        {
            capacidad = tamaño;
            elementos = new int[capacidad];

            front = 0;
            rear = -1;
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == capacidad;
        }

        public void Enqueue(int valor)
        {
            if (IsFull())
            {
                Console.WriteLine("La cola esta llena.");
                return;
            }

            rear = (rear + 1) % capacidad;
            elementos[rear] = valor;
            count++;

            Console.WriteLine("Elemento insertado.");
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola esta vacia.");
                return -1;
            }

            int valor = elementos[front];

            front = (front + 1) % capacidad;
            count--;

            if (count == 0)
            {
                front = 0;
                rear = -1;
            }

            return valor;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola esta vacia.");
                return -1;
            }

            return elementos[front];
        }

        public void Mostrar()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola esta vacia.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                int posicion = (front + i) % capacidad;
                Console.WriteLine(elementos[posicion]);
            }
        }
    }
}
