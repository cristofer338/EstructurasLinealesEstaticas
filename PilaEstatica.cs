
namespace EstructurasLinealesEstaticas
{
    public class PilaEstatica
    {
        private int[] elementos;
        private int top;
        private int capacidad;

        public PilaEstatica(int tamaño)
        {
            capacidad = tamaño;
            elementos = new int[capacidad];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == capacidad - 1;
        }

        public void Push(int valor)
        {
            if (IsFull())
            {
                Console.WriteLine("La pila está llena.");
                return;
            }

            top++;
            elementos[top] = valor;

            Console.WriteLine("Elemento insertado.");
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La pila está vacía.");
                return -1;
            }

            int valor = elementos[top];
            top--;

            return valor;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La pila está vacía.");
                return -1;
            }

            return elementos[top];
        }

        public void Mostrar()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }

            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(elementos[i]);
            }
        }
    }
}
