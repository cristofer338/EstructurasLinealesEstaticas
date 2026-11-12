
namespace EstructurasLinealesEstaticas
{
    public class ColaSimple
    {
        private int[] elementos;
        private int front;
        private int rear;
        private int capacidad;

        public ColaSimple(int tamaño)
        {
            capacidad = tamaño;
            elementos = new int[capacidad];
            front = 0;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return rear < front;
        }

        public bool IsFull()
        {
            return rear == capacidad - 1;
        }

        public void Enqueue(int valor)
        {
            if (IsFull())
            {
                Console.WriteLine("La cola esta llena.");
                return;
            }

            rear++;
            elementos[rear] = valor;

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
            front++;

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

            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(elementos[i]);
            }
        }
    }
}
