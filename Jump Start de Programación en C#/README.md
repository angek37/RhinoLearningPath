# Jump Start de programación en C#
## Programación Orientada a Objetos
¿Qué es un Objeto ?
- Un objeto generalmente es algo
- Un objeto generalmente tiene datos
- Un objeto generalmente realiza acciones

Las características de la programación orientada a objeto son:
- Encapsulamiento
- Herencia
- Polimorfismo
 
 C# es un *Managed Lenguage* esto quiere decir que depende de servicios que le provee un *runtime enviroment*, el *Managed Code* es ejecutado por el *Common Language Runtime (CLR)*, esto le da ciertas ventajas, tales como, una administración automática de memoria, manejo de excepciones, tipos estándar,  y seguridad.
 Todos los tipos en C# tienen un *Common base* - **Object**.
- Existen 3 categorías de tipos
	- Value types - Apuntan directamente a los datos
		- Int
		- boolean
		- double
	- Reference types - Almacenan la referencia a donde se encuentran los datos del objeto
	- Pointer types - Se utilizan para manipular directamente la memoria y están disponibles solo para código inseguro
## Clases y estructuras
Las clases y estructuras se usan para definir objetos, las clases representan un tipo por referencia, las estructuras representan un tipo por valor, ambas implican estrategias de memoria.
### Definir una estructura
La estructura lógica de representan un solo valor, y sus instancias del tipo son pequeñas
```C#
public struct Point
{
    public int X { set; get; }
    public int Y { set; get; }
}
```
Las clases definen a un tipo por referencia o objeto. Las clases pueden ser declaradas opcionalmente como
- static - No se pueden instanciar
- abstract - clases incompletas; pueden completarse en clases derivadas
- sealed - No pueden ser heredado
## Clases parciales
Cuando la implementación de una clase es demasiado grande, podemos recurrir a las clases parciales las cuales permiten almacenar la implementación de una clase en dos archivos físicos.
- Dog.cs
- Dog2.cs
El nombre de la clase debe ser el mismo.
```C#
partial class Dog
{
}
```
## Modificadores de Acceso
| Keyword | Accesibility Level |
|--|--|
| public | can be accessed by any code in the same assembly or any other assembly that references it |
| private | can only be accessed by code in the same class or struct |
| protected | can only be accessed by code in the same class or struct or in a class derived from the class |
| internal | can be accessed by any code in the same assembly, but not from any other assembly |
## Propiedades
Las propiedades encapsulan el acceso a los elementos de los datos de un objeto. Existe una sintáxis simplificada.
```C#
public string Name { set; private get; }
``` 
O puede realizarse de una forma explícita
```C#
private string _color;
public string Color
{
	get { return _color; }
	set { _color = value; }
}
``` 
## Métodos
Los métodos exponen las funciones que un objeto puede realizar; Lo que el objeto hace.
```C#
public class Lion()
{
	public string Sound { get; set; }
	public void MakeSound()
	{
		Console.WriteLine(Sound);
	}
}
```
Los métodos son declarados en una clase o estructura especificando:
- el nivel de acceso
- cualquier modificador
- el tipo que retorna
- el nombre
- los parámetros
El método puede contener parámetros y especificar su valor predeterminado
```C#
public int AddPoint(int pointsToAdd = 1, int maxPoints)
{
	points += pointsToAdd;
	if (points > maxPoints)
	{
		points = maxPoints;
	}
	return points;
}

// De esta forma se envia el valor de default para pointsToAdd
int newPoints = AddPoints(maxPoints:10); // Argumentos nombrados
```
## Herencia
```C#
public class Class1
{
	public string Name { set; get; }
	public Class1(string Name)
	{
		this.Name = Name;
	}
}
public class Class2 : Class1 // Class2 hereda de Class1
{
	public int Age { set; get; }
	public Class2(string Name, int Age) : base(Name) // Con base se envia el parametro al constructor de la clase padre
	{
		this.Age = Age;
	}
}
public class Class3 : Class2 // Class3 hereda de Class2
{
	public string Address { set; get; }
	public Class3(string Name, int Age, string Address) : base(Name, Age)
	{
		this.Address = Address;
	}
}
```
## Virtuales
Son usados para modificar métodos, propiedades, índices, o eventos, y permiten ser sobrecargados en clases derivadas.
```C#
internal class BaseClass
{
	internal virtual void Name() // El método puede ser sustituido
	{
		Console.WriteLine("BaseClass");
	}
}
// Llaman al método de su propia clase 
internal class DerivedOverride : BaseClass
{
	internal override void Name(){ // El método sustituye el contenido del método virtual
		Console.WriteLine("DerivedOverride");
	}
}
``` 
## Interfaces
Las interfaces son un compromiso que debe cumplirse, los métodos que se definen en la interfaz deben implementarse en las clases que la implementan
```C#
interface IDataRecord // La forma de definir una interfaz
{
	void Save();
}
public class Customer : IDataRecord // Se implementa la interfaz
{
	public void Save()
	{
		// Se implementa el método Save Record
	}
}
```
## Genéricos
Los genéricos hacen posible el diseñar clases y métodos de definir el tipo según la especificación.
```C#
var list = new List<int>();
list.Add(1);
list.Add(2);
```
## Boxing / Unboxing
Se refiere al acto de convertir un tipo por valor a un tipo por referencia, unboxing es lo reverso.
```C#
int count = 1;
object countObject = count; // Boxing

count += 1;
count = (int)countObject; // Unboxing
```
## Controlling Flow
### Ternary if
```C#
Console.WriteLine(value == 1 ? "One" : "Not One");
```
### Foreach
Foreach loop itera sobre cada elemento de un objeto enumerable
```C#
foreach (var s in string)
{
	Console.WriteLine(s);
}
```
### Jump Statements
- *break* termina un loop o un switch
- *continue* brinca la iteración de un loop y continua en la siguiente iteración
- *goto* transfiere la ejecución a una posición marcada por una etiqueta
```C#
goto label;

label:
	// Sentencias
```
- *return* sale de un método
- *throw* plantea una excepción
## Cast
Casting nos permite trabajar con tipos en sentido general, como su objeto base o como una instancia de una implementación de interfaz. Podemos intentar hacer cast a un objeto a otro tipo.
Una clase hija puede hacer cast a una padre, pero, una instancia padre no puede hacer cast a una clase hija
```C#
// var dog = a as Dog;
// Otra forma
var dog = (Dog)a;
```
## Strings
Un objeto String es una secuencia de caracteres *inmutable*, cuando un método manipula un string realmente regresa un nuevo string, el **StringBuilder** provee una implementación mutable de string.
```C#
var source = "The quick brown fox jumped over the lazy dog";
var value = source.Substring(4, 5); // regresa "quick"
value = string.Concat(value, " fox"); // regresa "quick fox"
value = value.Replace("fox", "dog"); // regresa "quick dog"
value = value.ToUpper(); // regresa "QUICK DOG"
var array = "dog".ToArray(); // array = {'d','o','g'}
var bytes = Encoding.ASCII.GetBytes("dog"); // bytes = byte[] of "dog"
```
## Reflection
Reflection inspecciona **type metadata** en *runtime*, este contiene información como:
- El nombre de ltipo
- El contenido del ensamblado
- Constructores
- Propiedades
- Métodos
- Atributos
Estos datos pueden ser usados para crear instancias, acceder a valores y ejecutar métodos dinámicamente en *runtime*.
### Obtener el *Type data*
- Dos métodos
	- Estáticamente en tiempo de compilación
	- Dinámicamente en tiempo de ejecución
```C#
var dog = new Dog { NumberOfLegs = 4 };
Type t1 = typeof(Dog); // En tiempo de compilación
Type t2 = dog.GetType(); // En tiempo de ejecución
Console.WriteLine(t2.Name); // output: Dog
Console.WriteLine(t2.Assembly); // output: After002, Version=1.0.0.0
```
### Crear una instancia de un *Type*
- Dos maneras de instanciar dinámicamente un *type*
	- Activator.CreateInstance
	- Llamar *Invoke* en un *ConstructorInfo object*
```C#
var newDog = (Dog)Activator.CreateInstance(typeof(Dog));
var genericDog = Activator.CreateInstance<Dog>();

// uses default constructor
// with no defined parameters
var dogConstructor = typeof(Dog).GetConstructors()[0];
var advancedDog = (Dog)dogConstructor.Invoke(null); //Llama al constructor sin parámetros
```
### Acceder a una propiedad
```C#
void Property()
{
	var horse = new Animal() { Name = "Ed" };
	var type = horse.GetType();
	var property = type.GetProperty("Name");
	var value = property.GetValue(horse, null); // value == "Ed"
}

public class Animal
{
	public string Name { set; get; }
	public string Speak() { return "Hello"; }
}
```
### Invocar un método
```C#
void Method()
{
	var horse = new Animal();
	var type = horse.GetType();
	var method = type.GetMethod("Speak");
	var value = (string)method.Invoke(horse,null); // value == "Hello"
}
```
## Garbage Collection
El *Garbage Collection* es un administrador de memoria automático, las referencias "huerfanas" no son colectadas inmediatamente pero sí periodicamente, el Garbage Collection es computacionalmente caro.
### Forzar Garbage Collection
```C#
GC.Collect();
GC.WaitForPendingFinalizers();
GC.Collect();
```
### Using keyword
Provee un útil forma de invocar el Dispose.
De esta forma al terminar las sentencias del bloque de código el garbage Collection realiza la limpieza.
```C#
using(Stream stream1 = File.Open(file, FileMode.Open)) // En particular esta acción gasta mucho recurso 
{
	// Statements
	Console.WriteLine(stream1.length);
}
```
## Validación de datos
La validación de datos es probar los valores que se introducen en una app que se trate de los que se esperan y no rebasen el rango. Lo anterior para prevenir:
- Overflow
- Resultados incorrectos
- Efectos indeseados
- Intrusiones de seguridad
Una forma de validar
```C#
public override void SetName(string value)
{
	if(string.isNullOrWhiteSpace(value)) // valida vacios
		throw new ArgumentNullException("value");
	if(value == this.Name) // valida conflictos
		throw new ArgumentException("value is duplicate");
	if(value.Length > 10) // valida tamaño
		throw new ArgumentException("value is too long");
	this.Name = value;
}
```
### Data contracts
Los contratos de código son un sistema unificado que puede remplazar otros enfoques de validación de datos, estos tiene:
- Precodiciones (Requires)
- Post-conditions (Ensures)
```C#
public string Name { get; protected set; }
public void SetName(string value)
{
	Contract.Requires(!string.IsNullOrWhiteSpace(value), "value is empty");	// valida entrada
	this.Name = value;
}

public string GetName()
{
	// valida salida
	Contract.Ensures(!string.IsNullOrWhiteSpace(Contract.Result<string>()));
	return this.Name;
}
```
## Unhandled Exception
Una excepción arrojada por nuestro código en tiempo de ejecución en un bloque de código a intentar, el *runtime* maneja todas las excepciones para proteger el sistema, sin embargo, no nuestra aplicación, lo que puede causar:
- Inestabilidad
- Terminación de ejecución
```C#
try{
	Process();
}
catch(DivideByZeroException ex)
{
	// specific exception
}
catch(Exception ex)
{
	// generic Exception
}
finally
{
	// this will always occur
}
```
## Encriptación
Un algoritmo de encriptación hace datos ilegible a cualquier persona o sistema a menos que sea aplicado un algoritmo de desencriptación.
Tipos de encriptación
- Encriptación de archivos
- Protección de datos de Windows
- Hashing, usado para firmar y validar
Es una forma de encriptar, los más comunes algoritmos son MD5, SHA. El hashing es rápido y es muy usado para almacenar contraseñas, comparar archivos, etc. El hashing genera una cadena para los datos que se introduzcan y siempre es el mismo para esos datos, sin embargo, no se garantiza que el hash sea único, por lo que para datos sensibles es recomendable usar algoritmos que generen una cadena más larga, lo cual reduce las probabilidades de que ocurrar colisiones (SHA256 o greater).
- Simétrico y Asimétrico
En el encriptado simétrico se realiza la encriptación y desencriptación con una sola llave (AES recommended), en la asimétrica se requiere una llave para cada una (RSA most popular).
[Ejemplos](https://github.com/angek37/RhinoLearningPath/blob/master/Jump%20Start%20de%20Programaci%C3%B3n%20en%20C#/ValidationsAndEncryption/ValidationsAndEncryption/Program.cs)
## File System
### Leer y escribir *archivos*
Los archivos permiten mostrar datos existentes a los usuarios, serializar objetos fuera de memoria, persistir datos a través de sesiones. Ejemplo:
```C#
var dir = System.IO.Directory.GetCurrentDirectory();
var file = System.IO.Path.Combine(dir, "File.txt");
var content = "how now brown cow?";
// write
System.IO.File.WriteAllText(file, content);
// read
var read = System.IO.File.ReadAllText(file);
Trace.Assert(read.Equals(content));
```
### Encontrar archivos
```C#
// special folders
var docs = Environment.SpecialFolder.MyDocuments;
var app = Environment.SpecialFolder.CommonApplicationData;
var prog = Environment.SpecialFolder.ProgramFiles;
var desk = Environment.SpecialFolder.Desktop;
// appplication folder
var dir = System.IO.Directory.GetCurrentDirectory();
// isolated storage folder(s)
var iso = IsolatedStorageFile
	.GetStore(IsolatedStorageScope.Assembly, "Demo")
	.GetDirectoryNames("*");
// manual path
var temp = new System.IO.DirectoryInfo("c:\\temp");
```
### Modificar archivos
```C#
var dir = System.IO.Directory.GetCurrentDirectory();
// files
foreach (var item in System.IO.Directory.GetFiles(dir))
	Console.WriteLine(System.IO.Path.GetFileName(item)); // enlista los archivos del directorio seleccionado
// rename / move
var path1 = "c:\\temp\\file1.txt";
var path2 = "c:\\temp\\file2.txt";
System.IO.File.Move(path1, path2);
// file info
var info = new System.IO.FileInfo(path2);
Console.WriteLine("{0}kb", info.Length / 1000);
```
## Web Services
Los web services encapsulan la implementación, permiten a los sistemas clientes comunicar servidores a través de los protocolos web (HTTP, GET, POST, etc), y son importantes para los *Service Oriented Architecture* (SOA).
### SOAP
SOAP es un estándar para regresar datos estructurados desde un Web Service como un *XML*
```XML
<?xml version="1.0"?>
<soap:Envelope xmlns:soap="http://www.w3.org/2003/05/soap.envelope">
	<soap:Header>
	</soap:Heaader>
	<soap:Body>
		<m:GetStockPrice xmlns:m="http://www.example.org/stock">
			<m:StockName>IBM</m:StockName>
		</m:GetStockPrice>
	</soap:Body>
</soap:Envelope>
```
### REST
REST se esta convirtiendo en un estándar de la industrial, este no require *XML parsing* o un cabezal de mensaje, generalmente es legible para los humanos, además de usar un ancho de banda menor a SOAP, los servicios REST usualmente regresan un *XML* o *JSON*.
*JSON* es **JavaScript Object notation**, estos son más ligeros que la carga de un *XML* (o *SOAP*)
### Programación Asíncrona
Asíncrona maximiza los recursos en los sistemas multicore, permitiendo a las unidades de trabjo por separado y completo. La programación asíncrona libera las llamadas al sistemas, especialmente una interfaz de usuario, como para no esperar por operaciones largas.
## LINQ
Tipos de acceso a una base de datos
- Low-level
	- Manual queries
	- DbDataReader
- Object Relationshio Models (ORM)
	- Conceptual Modelling
	- Entity Framework, Hibernate, CSLA, Dapper
### Language Integrated Query
LINQ es un lenguage de consulta de propositos generales, esta integrado en parte de los lenguajes de *.Net* es *Type Safe* y tiene Intellisense, incluye operadores como Traversal, filtro y proyección.
El primer pasa consiste en crear el contexto, quién es el que se encarga de administrar todas las conexiones de la base de datos.
```C#
var context = new DBEntities();
```
Las consultas se realizan con una sintáxis de C#
```C#
var products = context.Products;
foreach(var product in products
	.Where(x => x.Name.Countains("o"))) // La consulta Where crea una instancia 'x' para seleccionar los que cumplen la condición
{
	Console.WriteLine(product.Name);
}
```
Podemos obtener únicamente el primer resultado y además añadir una condición
```C#
var Prod = products.First(x => x.Name.StartsWith("c"));
```
Además realizar modificaciones sobre un registro
```C#
Prod.Name = "ChocoRoles Marinela";
context.SaveChanges(); // El contexto revisa si se han realizado cambios para realizarlos en la DB
```
Otra acción básica, eliminar un registro.
```C#
context.Products.Remove(Prod);
context.SaveChanges();
```
