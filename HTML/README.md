# *H*yper*T*ext *M*arkup *L*anguage (HTML)
## Conceptos básicos
#### ¿Qué es la World Wide Web?
La WWW es un espacio de información donde los documentos u otros recursos web son identificados por el **Uniform Resource Locators (URLs)**, interligados por **hypertext links**, y puede ser accesada por **El Internet**.
#### Hypertext Markup Language (HTML)
Es el estándar de *markup language* para crear páginas web y aplicaciones web.
Lanzamiento de últimas especificaciones:
 - HTML 5 - 2014
 - HTML 5.1 - 2016
 - HTML 5.2 - 2017
### Estructura de documentos HTML
.HTM o .HTML
Elementos básicos de la estructura de un documento HTML
```HTML
<!DOCTYPE html>
<html>
	<head>
		<!--meta information-->
	</head>
	<body>
		<!--the content of the page-->
	</body>
</html>
```
### Elementos más expresivos de HTML
Con el objetivo de ser más específicos en la importancia de las secciones de un documento HTML fueron añadidas etiquetas muy especificas sobre el contenido de un documento en la versión **HTML 5**, ayudando de esta forma a los motores de búsqueda.
```HTML
<!DOCTYPE html>
<html>
	<head></head>
	<body>
		<header>
			<nav />			
		</header>
		<main>
			<article />
			<aside />
		</main>
		<footer>
			<address />
		</footer>
	</body>
</html>
```
## Nuevos Elementos
| article | header | svg |
|--|--|--|
| aside | main | time |
| audio | math | track |
| bdi | mark | video |
| canvas | meter | wbr |
| datalist | nav |  |
| details | output |  |
| embed | progress |  |
| figcaption | section |  |
| figure | source |  |
| footer | summary |  |

## Elementos estructurales
- **main**: Esta etiqueta indica que es la parte principal del documento
	- **article**: Y como lo indica el nombre del elemento, el contenido que va dentro del elemento del artículo representa una forma de agrupar la información indicando al motor de búsqueda que el contenido dentro es muy importante al contrario del que lo rodea.
- **aside**: Se usa para marcar contenido que podría ser importante, pero tal vez no tan necesario como el resto del contenido de la página. Como un sidebar
- **section**: Es un poco como el elemento **div**, se usa para agrupar contenido relacionado, pero el agrupamiento es para un grupo lógico en lugar de un propósito visual, para lo cual es usado *div*.
- **header**
	- **nav**: Es un contenedor lógico para la navegación del sitio, está explícitamente reservado para links a puntos de localización de las partes de la página web 
- **footer**
	- **address**
- **time**: Ayuda a identificar semánticamente un punto en el tiempo
	```HTML
	<time
		date="2016-08-12" pubdate>
		August 12, 2016
	</time>
	```
- **figure - figcaption**: Ahora las imágenes tienen otro aspecto de la página para obtener más atención formal, proveen un significado semántico a los motores de búsqueda para imágenes y diagramas.
	 ```HTML
		<figure>
			<figcaption>
				Screenshot of Menu
			</figcaption>
			<img src="screenshot.png">
		</figure>
	```
- **details - summary**: Una forma no-Javascript de agregar un poco de interactividad a la página
	```HTML
	<details>
		<summary>Events</summary>
		<p>Come join us.</p>
	</details>
	```
- **mark**: Esta destinado a envolver texto para ofrecer un significado semántico
- **bdi**: Funciona para cambiar la dirección de un texto
- **output**: Es un tag para contener un significado semántico de algún cálculo
- **embed**: El proposito de este elemento es ser un host contenedor para plugin externos

## Elementos con APIs
### Canvas
Si quieres dibujar en la página, entonces puedes usar el elemento canvas para ese trabajo.
```HTML
<canvas></canvas>
```
### Video
La etiqueta vídeo puede contener distintos medios, tal como se muestra en el código de ejemplo, que incluye subtítulos. Este medio no contendría los controles para realizar funciones sobre le medio, para ello debemos agregar el atributo `controls` , otro atributo importante es `loop` que provoca que una vez que el medio termine este inicie automáticamente de nuevo.
- `preload`: puede tener 3 valores: auto, none, metadata
- `poster`: la imagen que mostrará antes de iniciar el vídeo  
```HTML
<video>
	<source src="vid.mp4">
	<source src="vid.ogg">
	<source src="vid.webm">
	<track
		kind="subtitles"
		label="Spanish Subtitles"
		src="es.vtt"
		srclang="en">
</video>
```
## Form elements
### Meter
Este elemento esta destinado a mostrar valores de forma visual, puede ser usado para representar el nivel de bateria, ratings de productos, etc.
```HTML
<meter
	min="0"
	max="100"
	value="70">
		70 out of 100
</meter>
```
<meter
	min="0"
	max="100"
	value="70">
		70 out of 100
</meter>
### Progress
Un elemento nativo que ofrece la oportunidad de representar el progreso de una aplicación.
```HTML
<progress
	max="100"
	value="50">
</progress>
```
<progress
	max="100"
	value="50">
</progress>
### math
Este elemento funciona para definir ecuaciones y formulas, permite renderizarlas en la pagina de tal forma que se verían en un cuaderno.
```HTML
<math>
	<!-- MathML elements -->
</math>
```
### datalist
Funciona para representar una lista de elementos que muestre opciones en un campo de input.
```HTML
<input
	type="text"
	list="colors"
	min="70">
<datalist id="colors">
	<option src="blue">
	<option src="red">
</datalist>
```
## Javascript APIs
### Interaction, Events & Messaging
- Battery Status
- Clipboard API & Events
- Cross Document Messaging
- Device & Screen Orientation
- Fullscreen
- Geolocation
- Media Capture
- Notifications
- Touch events
- Vibration
### Storage & Files
- **Blob URLs**: representan datos en trozos de bites, los blobs son una forma de muy bajo nivel de representar datos en el navegador
- **File API**
- **File Reader**: Provee una forma leer datos en el navegador que puede venir de diferentes formas
- **IndexedDB**: Es un sofisticado objeto donde el documento de base de datos es implementado de forma completa en el navegador. Si tienes una gran cantidad de datos que necesitas almacenar y consultar en el cliente, entonces el indexedDB es una buena opción.
- **Local Storage**: Con este tienes la opción de almacenar datos por periodos largos de tiempo o solo por el tiempo de la sesión
### Real-Time Communication
- **Push API**: Datos pueden ser *pushed* al navegador incluso cuando esta corriendo en segundo plano en la computadora. Ofreciendo lo necesario para realizar tareas de real-time
- **Server-Sent Events**
- **Web Sockets**

## Web Components
- *Custom Elements* - e.g:
```HTML
<comments>
	<comment author="Craig Shoemaker"
			avatarUrl="images/cs.png"
			publishDate="12/01/2016">
		HTML5 is a set of markup enhancements and new JavaScript APIs.
	</comment>
</comments>
```
- *Shadow DOM*: Es una forma simple de encapsular elementos en el árbol del DOM. Lo que significa que puedes aplicar CSS y Javascript a elementos contenidos en el Shadow DOM, y evitar que estos afecten al resto de la página.
- *Templates*: Es una forma de crear un patrón de HTMl y facilmente llenarlo con datos antes de mostrarlo en pantalla.
## Performance Optimization & Analysis
- *High Resolution Time*: Ofrece la oportunidad de medir el tiempo con una precisión de milisegundos
- *Navigation Timing*: Con esta API pueden encontrar como los usuarios navegan a nuestra página para responder a eventos personalizados como el *lifecycle* de la carga de una página
- Page Visibility: Indica cuando la página esta siendo visible, según el estado del tab del navegador. 
- User Timing: Una simple interfaz disponible para crear límites de tiempo dentro del código que nos da una forma fácil de medir con alta resolución como se ejecuta nuestra aplicación
- Web Workers: Nos ofrecen una oportunidad de obtener un gran rendimiento usando diferentes hilos en el navegador.
## Security & Privacy
- Content Security Policy
- Referrer Policy
- Web Cryptography
## Miscellaneous Features
- scripts: async & defer
- contentEditable
- Drag & Drop
- History
- Promises
- Service Workers
## API Selection
Este método retorna todos los elementos en el documento que concuerden con los selectores **CSS** especificados en un objeto NodeList estático.
```js
var items = document.querySelectorAll('.features');
```
`querySelector` Al igual que el `querySelectorAll` obtiene los resultados por medio de selectores CSS pero obtiene únicamente al primer elemento.
```js
var item = document.querySelector('.features');
```
Si la selección se requiere hacer por selectores HTML tenemos la opción de `getElementsByClass`  que retorna un objeto de tipo NodeList **no estático**.
```js
var items = document.getElementsByClassName('feature');
```
## User Input
### New Elements
| color | email | tel |
|--|--|--|
| datalist | month | time |
| date | number | url |
| datetime | range | week
| datetime-local | search | |
```html
<input type="color" />
```
```html
<input list="colors" />
<datalist id="colors">
	<option value="Blue">
	<option value="Red">
	<option value="Yellow">
	<option value="Orange">
	<option value="White">
</datalist>
```
```html
<input type="datetime" />
```
```html
<input type="datetime-local" />
```
```html
<input type="email" />
```
```html
<input type="url" />
```
```html
<input type="tel" />
```
```html
<input type="month" />
```
```html
<input type="number" />
```
```html
<input type="range" />
```
```html
<input type="week" />
```
```html
<input type="time" />
```
```html
<input type="search" />
```

### Native Validation
> Never trust (user) input

Con HTML5 existen diferentes reglas de validación y APIs disponibles para ayudar a realizar validaciones de entradas de datos.
> Always replicate validation on the server

#### Value Missing
`true` si un elemento es marcado como `required` tiene un valor vacío
```html
<input type="text" required value="" />
```
#### Type Mismatch
`true` cuando el valor no coincide con el tipo declarado
```html
<input type="url" value="hi" />
```
#### Pattern Mismatch
`true` cuando el valor del elemento no coincide con la Expresión Regular dada
```html
<input type="text" pattern="/^[A-z]+$/" value="1234" />
```
#### Too Long
`true` cuando el valor de longitud de un elemento es más largo del valor en el atributo `maxlength` 
```html
<input type="text" maxlength="3" value="hello" />
```
#### Range Underflow
`true` cuando el rango del tipo de valor es más pequeño que el atributo `min`
```html
<input type="range" min="3" max="5" value="3" />
```
#### Range Overflow
`true` cuando el rango de tipo de valor es más grande que el atributo `max`.
```html
<input type="range" min="3" max="5" value="9" />
```
#### Step Mismatch 
`true` cuando el tipo del rango del valor es imposible dado el valor `step`
```html
<input type="range" min="5" max="20" step="5" value="8" />
```
#### Valid
`true` cuando todas las otras validaciones retornaron `false`

## Drag and Drop
### Events
- dragover
- drag
- dragstart
- dragleave
- dragenter
- drop
- dragend

| DRAG SOURCE | DROP TARGET |
| -- | -- |
| dragstart | dragenter |
| drag | dragover |
| dragend | dragleave
|  | drop |


## \<head> - metadata
 - \<title> el título del documento
 - \<meta> Incluye metadatos como keyword
 - \<script> Incluye script para páginas interactivas
 - \<link> Directiva indicando documentos relacionados
 - \<base> Define la dirección base para todos los links relativos en la página
## HTML Text
### Headings
```HTML
<h1>HTML Fundamentals</h1>
```
 - Es buena práctica usar solo uno por página, contribuye en los resultados de búsqueda
```HTML
<h2></h2>
<h3></h3>
<h4></h4>
<h5></h5>
<h6></h6>
```
### Block vs. Inline
 - Block elements
	- Contienen elementos para agrupar
	- Pueden contener otros bloques
\<div>
 - Inline elements
	- Contenedor para texto y otros inline elements
\<span>
```HTML
<div id="overviewContainer">This is my <span>overview </span></div>
<div id="secondDiv">This is another div</div>
```
### Whitespace
 - \<pre> - Considera los espacios y saltos de línea
 - \<br> - Añade un salto de línea 
 - \<hr> Crea una línea horizontal
 - \&lt; Caracteres especiales 
### List
 - Unordered List
```HTML
<ul>
	<li></li>
	<li></li>
</ul>
```
 - Ordered List
```HTML
<ol>
	<li></li>
	<li>
		<ol>
			<li></li>
		</ol>
	</li>
</ol>
```
 - Definition List
```HTML
<dl>
	<dt>HTML</dt>
	<dd>HyperText Markup Language</dd>
	<dt>HTTP</dt>
	<dd>HyperText Transfer Protocol</dd>
</dl>
```
### Links
Link a un sitio especifico
```HTML
<a href="https://google.com">Ir a Google</a>
```
Link a una posición en el mismo documento
```HTML
<a href="#header">Ir al encabezado</a>
```
## Tables
Ejemplo del cuerpo de una tabla
```HTML
<table>
	<thead>
		<tr>
		<th>Type</th>
		<th>Tag</th>
		</tr>
	</thead>
	<tfoot>
		<tr><td>Pie de tabla</td></tr>
	</tfoot>
	<tbody>
		<tr>
		<td>Unordered List</td>
		<td>ul</td>
		</tr>
		<tr>
		<td>Ordered List</td>
		<td>ol</td>
		</tr>
	</tbody>
</table>
```
## Images and Objects
### Images
- Referencia al archivo de la imagen
```HTML
<img src=".\images\mx.jpg" alt="Flag" />
```
### Objects
Insertar objetos en un documento HTML, e.g.: Flash, Silverlight
```HTML
<object data="data:application/x-silverlight-2," type="application/x-silverlight-2" width="50%" height="150px">
<param name="source" value="./apps/SilverlightObjectDemo.xap" />
<param name="initParams" value="TextMessage=Do not use marquees" />
</object>
```

