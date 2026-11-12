# 📚 Estructuras Lineales Estáticas en C#

**Unidad 3 – Estructuras Lineales | Tarea 3.1**

Implementación desde cero de estructuras de datos lineales estáticas mediante arreglos en C#. El proyecto desarrolla una pila, una cola simple y una cola circular, administrando manualmente sus índices de control y operaciones principales.

---

## 🎯 Objetivo

Comprender e implementar el funcionamiento de las estructuras de datos lineales utilizando memoria estática, aplicando operaciones de inserción, eliminación, consulta y validación de capacidad.

El desarrollo se realiza sin utilizar colecciones nativas de C#, implementando directamente la lógica de almacenamiento y administración de elementos.

## 🧩 Estructuras implementadas

### 1. Pila estática (Stack)

Estructura que sigue el principio **LIFO (Last In, First Out)**, donde el último elemento en ingresar es el primero en salir.

**Operaciones:**

| Operación | Descripción |
|---|---|
| `Push()` | Inserta un elemento en la parte superior. |
| `Pop()` | Elimina y devuelve el elemento superior. |
| `Peek()` | Consulta el elemento superior sin eliminarlo. |
| `IsEmpty()` | Comprueba si la pila está vacía. |
| `IsFull()` | Comprueba si la pila alcanzó su capacidad máxima. |

**Índice utilizado:** `top`.

### 2. Cola simple estática (Queue)

Estructura que sigue el principio **FIFO (First In, First Out)**, donde el primer elemento en ingresar es el primero en salir.

**Operaciones:**

| Operación | Descripción |
|---|---|
| `Enqueue()` | Inserta un elemento al final. |
| `Dequeue()` | Elimina y devuelve el primer elemento. |
| `Peek()` | Consulta el primer elemento. |
| `IsEmpty()` | Comprueba si la cola está vacía. |
| `IsFull()` | Comprueba si la cola está llena. |

**Índices utilizados:** `front` y `rear`.

**Característica:** utiliza un arreglo de tamaño fijo y no recupera las posiciones anteriores cuando se eliminan elementos.

### 3. Cola circular estática (Circular Queue)

Estructura que también utiliza el principio FIFO, pero permite reutilizar las posiciones liberadas del arreglo mediante una organización circular.

**Operaciones:**

| Operación | Descripción |
|---|---|
| `Enqueue()` | Inserta un elemento en la siguiente posición disponible. |
| `Dequeue()` | Elimina el primer elemento. |
| `Peek()` | Consulta el primer elemento. |
| `IsEmpty()` | Comprueba si está vacía. |
| `IsFull()` | Comprueba si alcanzó su capacidad máxima. |

**Índices utilizados:** `front`, `rear` y `count`.

**Característica principal:** utiliza el operador módulo (`%`) para regresar al inicio del arreglo cuando se alcanza su última posición.

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET 8 o superior.
- **Entorno de desarrollo:** Visual Studio 2022.
- **Tipo de aplicación:** Consola.
- **Almacenamiento:** Arreglos estáticos.
- **Control de versiones:** Git y GitHub.

## 📁 Organización del proyecto

```text
EstructurasLinealesEstaticas/
│
├── Program.cs
│
├── PilaEstatica.cs
│
├── ColaSimple.cs
│
├── ColaCircular.cs
│
├── Evidencias/
│   ├── Pila.png
│   ├── ColaSimple.png
│   ├── ColaCircular.png
│   └── Pruebas.png
│
└── README.md
```

## ▶️ Ejecución del proyecto

1. Clonar o descargar este repositorio.
2. Abrir el proyecto en Visual Studio.
3. Compilar la solución.
4. Ejecutar la aplicación de consola.
5. Seleccionar una estructura desde el menú principal.
6. Realizar las operaciones disponibles.

## 🧪 Pruebas realizadas

Se contemplan las siguientes pruebas para verificar el funcionamiento:

- Inserción de elementos en cada estructura.
- Eliminación de elementos.
- Consulta del primer o último elemento según corresponda.
- Comprobación de estructuras vacías.
- Comprobación de capacidad máxima.
- Validación de reutilización de posiciones en la cola circular.

## 📸 Evidencias de funcionamiento

En esta sección se incorporan capturas de pantalla que muestran la ejecución de cada estructura y los resultados de sus operaciones.

| Estructura | Evidencia |
|---|---|
| Pila estática | `Evidencias/Pila.png` |
| Cola simple | `Evidencias/ColaSimple.png` |
| Cola circular | `Evidencias/ColaCircular.png` |
| Pruebas generales | `Evidencias/Pruebas.png` |

## 📖 Conceptos fundamentales

- **Memoria estática:** espacio de almacenamiento reservado con una capacidad definida.
- **LIFO:** último en entrar, primero en salir.
- **FIFO:** primero en entrar, primero en salir.
- **Índice top:** controla la posición superior de una pila.
- **Índice front:** identifica el primer elemento de una cola.
- **Índice rear:** identifica la última posición ocupada de una cola.
- **Aritmética modular:** permite implementar el comportamiento circular de una cola.

## 👨‍💻 Autor

Proyecto académico desarrollado como parte de la asignatura **Estructuras de Datos**, correspondiente a la Unidad 3: Estructuras Lineales.

## 📌 Conclusión

La implementación de estas estructuras permitió comprender cómo se administra la memoria estática mediante arreglos y cómo funcionan los índices de control para insertar, eliminar y consultar elementos.

Además, se identificaron las diferencias entre una cola simple y una cola circular, especialmente en el aprovechamiento de las posiciones disponibles del arreglo.
