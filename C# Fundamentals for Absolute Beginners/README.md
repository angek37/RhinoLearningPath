# Learn C# for Beginners
## First Program
### Estructura básica de un programa
```C#
using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			// Comentarios en línea
			/*
             Comentarios multilinea
            */
		}
	}
}
```
Hello World! en C# en una aplicación para terminal, realizando una impresión por consola con el método:
```C#
Console.WriteLine("Hello World!");
Console.Read();
```
Con el método Read se pausa el hilo para poder leer la impresión.
## Variables
La declaración de variables se realiza indicando el tipo de esta, seguido de su identificador y opcionalmente su asignación del valor.
```C#
int x;
x = 22;
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Hi!, my name is" + name
	+ "and i am " + x + " years old");
Console.Read();
```
## Decisions
La sentencia para el control de flujo de una decisión tiene la estructura:
```C#
if(4 > 2) // No necesita llaves cuando es una sola sentencia
	//Sentencias SI se cumple la condición
else
	//Sentencias si NO se cumple la condición
```
Existe otra forma de realizar una decisión:
```C#
int num = 2;
string numStr = (num == 4) ? "Four" : "Two";
```
## For Iterator
En el iterador For se declara la variable que trabajará como contador, se añade la condición y se establece el incremento o decremento que debe realizar el contador.
```C#
for(int x = 0; x < 100; x++)
{
	Console.WriteLine(x);
	// La instrucción break; detiene el ciclo
}
``` 
## Arrays
Los arreglos son estructuras de datos que permiten almacenar múltiples variables del mismo tipo. Es necesario al declararlos especificar su tipo de datos, así como indicar si esta será unidimensional o multidimensional.
```C#
string[] names = {"Miguel", "Angel"};
string[] brothers = new String[]{"Erick","David"};
string[] parents = new String[2];

```
Los arreglos tienen una longitud fija.
## Dates & Times
Para representar un instante en el tiempo se utiliza la clase System.DateTime que permite realizar múltiples declaraciones de tiempo y fecha.
```C#
DateTime today = DateTime.Now;
Console.WriteLine(today.ToString());
today.AddDays(3); //DateTime contiene métodos para hacer cálculos con las fechas

DateTime birthday = new DateTime(1995, 08, 07);
Console.WriteLine(birthday.ToShortDateString());
TimeSpan myAge = DateTime.Now.Subtract(birthday);
Console.WriteLine(myAge.TotalDays);
```
## Classes
Las clases se declaran de la siguiente forma con sus métodos *setters and getters* para los atributos.
```C#
class Car
{
	public string Make { set; get; }
	public string Model { set; get; }
	public int Year { set; get; }
	public string Color { set; get; }
}
```
Cuando se realiza una instancia de un objeto esta se carga en la memoria de la computadora:
```C#
Car myCar = new Car();
Car myOtherCar = myCar; // Se puede realizar una referencia desde otra instancia
```
Cuando no hay ninguna referencia a cierto espacio en memoria el ***Garbage Collector*** se encarga de remover los datos de la memoria.
```C#
myCar = null;
myOtherCar = null;
```
## Constructors
Los constructores nos permiten ejecutar código al momento de instanciar una clase, por default cada clase contiene un constructor implicito el cual no recibe parámetros, al declarar un constructor por nuestra parte el constructor implicito desaparece.
```C#
class Car
{
	public Car(){
		Make = "Nissan";
	}
	public string Make { set; get; }
}
``` 
Los constructores se pueden sobrecargar cambiando el ***Method Signature***, o en otras palabras los parámetros que recibe.
```C#
class Car
{
	public Car()
	{
		Make = "Nissan";
	}
	public Car(string Make)
	{
		this.Make = Make;
	}
	public string Make { set; get; }
}
``` 
## Scope
Se refiere al alcance que tiene una variable declarada dentro de un bloque de código, cuando tal bloque termina de ejecutarse la variable deja de estar accesible. 
```C#
public void myMethod()
{
	int c = 0; // La variable esta accesible dentro del método
	for(int i = 0; i < 10, i++)
	{
		Console.WriteLine(i); // La variable i solo es accesible dentro del bloque For
	}
}
```
## Accessibility Modifiers
Cuando no se declara el modificador de acceso este se establece implicitamente como *private*,  de forma que el elemento puede ser accedido desde la propia clase.
El modificador *public* permite acceder al elemento desde fuera de la clase.
## Collections
Se refiere a estructuras de datos que proporciona LINQ en C#, variedades:
- List
El tamaño de las listas es dinámico por lo que no es necesario establecer un tamaño
```C#
List<Car> myList = new List<Car>(); // Utiliza un tipo genérico
myList.Add(car1);
myList.Add(car2);
```
- Dictionaries
Los diccionarios están compuestos por una clave y un valor
```C#
Dictionary<string, Car> myDictionary = new Dictionary<string, Car>(); // Se debe establecer de que tipo será la clave y el valor
myDictionary.Add(car.VIN, car1);
myDictionary.Add(car2.VIN, car2);
Console.WriteLine(myDictionary["WDZPE7CC5D5800669"].Make);
```
### Collection initializer
La inicialización de objetos y colecciones puede realizarse con una sintaxis simplificada
```C#
List<Car> myList = new List<Car>()
{
	new Car { Make = "Nissan", Model = "Cutlas Supreme"},
	new Car { Make = "Chevrolet", Model = "Equinox"}
};
```
## LINQ
Language Integrated Query (LINQ) son un conjunto herramientas de Microsoft para realizar todo tipo de consultas a distintas fuentes de datos.
- LINQ Query Syntax
```C#
var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
```
- LINQ Method Syntax
```C#
var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
```
Obtener el primer registro después de ordenar la lista por distinta sintáxis:
```C#
var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
```
Usar la función Sum para obtener el costo de todos los autos
```C#
Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));
```
## Enumerations
Las enumerations permiten una eficiente forma de definir un conjunto de constantes que pueden ser asignadas a una variable.
```C#
enum Status
{
    NotStarted,
    InProgress,
    OnHold,
    Completed,
    Deleted
}
```
Asignar a una variable
```C#
Status = Status.Completed;
```
## Switch
La sentencia Switch es un control de flujo que surge como alternativa al if-else su estructura es la siguiente:
```C#
switch(todo.Status) // El valor a evaluar
{
	case Status.NotStated:
		//Sentencias
		break;
	case Status.OnHold:
		//Sentencias
		break;
	default:
		break;
}
```
## Handling Exceptions
Las excepciones son errores que suceden en tiempo de ejecución de un programa (Runtime), es esencial manejarlas para evitar que el usuario final tenga problemas al utilizar el software.
La sintáxis es la siguiente:
```C#
try
{
	// Sentencias que pueden ocasionar excepciones
}
catch(Exception ex) 
// Exception es la más general
// debemos usar la más adecuada y especifica del caso e.g. `NullReferenceException`
{
	Console.WriteLine(ex.Message);
}
finally
{
	// Sentencias como terminar una conexión de DB, etc.
	Console.WriteLine("Closing application now ...");
}
```
