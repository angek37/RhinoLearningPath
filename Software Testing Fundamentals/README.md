# Software Testing Fundamentals
## Testing Fundamentals
Testing es el proceso de examinación de una aplicación para asegurarse de que los requerimientos están adecuadamente diseñados y cumplen las expectativas de calidad. El testing mide la calidad de una aplicación o proyecto. El testing beneficia a los usuarios finales en forma que los resultados de testing ofrecen mejor usabilidad y confiabilidad.
#### Medición de calidad de software
Existen muchas diferentes tipo de métricas (medidas estándar) para la calidad de software. Las metricas comunmente incluyen:
- Métricas de rendimiento
- Métricas de confiabilidad
### Metodologías para el Desarrollo de Software
Existen muchos modelos diferentes para administrar el desarrollo de proyectos, cada uno tiene sus ventajas y desventajas. Pueden dividirse en dos categorías mayores:
- Desarrollo Secuencial
- Desarrollo Iterativo
#### Modelo Cascada
Un ejemplo de metodología secuencial es el modelo Cascada nombrado de esta forma debido a que el flujo es a través de fases como el agua en cascada.
![Waterfall model](https://www.researchgate.net/profile/Ece_Calikus/publication/283048282/figure/fig5/AS:286978932916228@1445432517136/Waterfall-Model.png)
 
#### Modelo Ágil
En el desarrollo Ágil, el software desarrollado es incremental, con ciclos rápidos. Estos resultados en pequeñas e incrementales lanzamientos, con cad auno construyendo en funcionalidad previa. Cada lanzamiento es testeado, lo ue asegura que todos los inconvenientes dirijidos en la próxima iteración.
![agile Model](https://content-project.inprogress.rocks/uploads/2018/01/Img-1-2x-4.png)

## Testing Methodologies
### Testing techniques
#### Testing Manual
En el testing manual nosotros probamos el programa y observamos si este funciona, el tester toma el rol de un usuario y verifica existe un asunto inesperado o indeseado. *El Tester puede ser o no parte del equipo de desarrollo que creo el código*.
#### Automated Testing
Los test automatizados usan software de testing para controlar el flujo de uno o más test automáticos ejecutados. Estos pueden ser creados y configurados para correr cada uno en una versión del proyecto ( o segmento del código fuente) creado. **Microsoft Test Manager** provee un reporte detallado de cada uno de los test automáticos.

Ambos tipos de test se complementan, y ambos son importantes para asegurar una alta calidad de software.
#### Black Box Testing
Black box testing es conducido sin conocimientos del funcionamiento interno del sistema que comienza a probarse. Este tipo de testing simula la experiencia del usuario final. e.g.:
- Probar una interfaz de usario para comprobar si todos los requerimientos son funcionales
- Probar una variedad de entrada de tipos de datos (datos fuera del rango esperado, números negativos, o más pesados)
- Cargar o estresar en testing un sistema
- Testing de la seguridad de un proyecto o sistema
#### White Box Testing
También conocido como caja de cristal, caja clara, y caja abierta de testing. El White box testing permite examinar código para comprobar escenarios potenciales de falla. White box test son creados por alguien que analiza el código de un bloque de aplicación y prepara casos de prueba para asegurar que las clases concuerden con las especificaciones. e.g.:
- Testing subrutinas internas, "detrás de escenas".
- Testing loops y sentencias condicionales para la precisión.
- Realizar testing de una parte de código o algoritmo.
### Testing Levels
#### Unit testing
Unit test son test automatizados que verifican la funcionalidad de un componente, clase, método o nivel de propiedad. El primer objetivo de un unit testing es tomar una pequeña parte de un software estable en la aplicación, y verificar que este se comporte como lo esperas.
#### Component and Integration Testing
Integration testing identifica problemas que ocurren cuando las unidades son combinadas. Debido a que desde la perspectiva de testing, las unidades individuales son integradas para formar componentes más grandes.
### Testing types
#### Regression Testing
Sin importar los cambios que se hagan al proyecto, es posible que el código existente no trabaje más propiamente, o previamente bugs sin descubrir se hagan presentes por si mismos. Este tipo de bug es llamdo *regression*.
#### Stress Testing
Testing en una escala menor, el cual es un solo usuario corriendo en una aplicación web o una base de datos con solo un puñado de registros, quizá no revele los problemas que podrían ocurrirle a una aplicación usada en el "mundo real".
Stress testing empuja un sistema a su limite funcional. Es realizado en condiciones extremas, simulando usuarios simultaneos, grandes cantidades de datos, etc. La automatización de test permite pruebas de riguroso estrés sin un mínimo monto de labor manual.
#### Security Testing
Security testing valida los servicios de seguridad de una aplicación e identifica las brechas potenciales de seguridad. Muchos proyectos usan *Black box* para el security testing, permitiendo a los expertos de seguridad sin conocimiento del software probar la aplicación para huevos o vulnerabilidades.
#### Usability Testing
Usability testing evalua un proyecto para estudial como los usuario reales usan el software, incluyendo:
- Medidas de que tan largo es el proceso de un usuario para completar una tarea.
- Qué tantos "clics" o acciones de usuario toma completar una tarea o acceder a una característica.
#### Localization Testing
Localización traduce el UI de un producto y ocacionalmente cambia algunas configuraciones iniciales para hacer parecer en otra región.
- Por ejemplo, un proyecto localizado en francias podría cambiar el lenguaje de frances y las unidades de medida al sistema métrico.
#### Accessibility Testing
Valida una aplicación que cuente con soporte para usuarios con discapacidades.
Accessibility testing es posible que incluyan:
- Compliance
- Effectiveness
- Usefulness
- Satisfaction
#### User Interface (UI) Testing
Cualquier test de operación y funcionalidad de una interfaz de usuario es considerada un *UI test*.
## Creating Software Test
### User Centric Testing
#### User Requiremnets
Un requerimiento de usuario es un documento o diagrama que define que es lo que un usuario necesita para un sistema o aplicación. Estos no explican el diseño interno o como trabaja el sistema. Existen muchas otras forma de un documento de requerimiento de usuariom incluyendo los diagramas de caso de uso o las historias de usuario (*user stories*).
#### Use Case Diagrams
Los diagramas de caso de uso describen quien usa el sistema y para que lo usan.
#### User Stories
Un **user story** comunica la funcionalidad del valor de un usuario final del producto o sistema. Cada user story deberia describir una actividad que el usuario quiere completar con el software desde su perspectiva. e.g.: "Como cliente, puedo ver el menú actual.", "Como restaurante, puedo agregar un elemento al menú".
### Software Testability
#### **TEST-DRIVEN DEVELOPMENT**
**Test-Driven Development** es una técnica que usa *unit test* para guiar el diseño de software. Requiere que desarrolles los casos de prueba antes de desarrollar el código. Los desarrolladores entonces desarrollan funcionalmente el paso de los casos de prueba existentes.

![TDD](http://haselt.com/wp-content/uploads/2016/02/stride-nyc-test-driven-development-chart-700x400.jpg)

#### Testing Hooks
Un *testing hook* es una característica que permite el funcionamiento interno para hacer probado independientemente del resto de software.
#### Code Coverage
Una estrategia de testing podría incluir el objetivo específico de covertura de código. Code Coverage es una métrica que describe, qué tanto código del proyecto esta siendo probado. Normalmente se expresa en porcentaje.
## Managing Software Testing Projects
#### Process Guidance
*Process* refiere a las actividades que son usadas para completar un proyecto.
#### Phases
La terminología usada para describir **phases** del desarrollo de proyecto variaría dependiendo en el modelo usado. Por ejemplo, los modelos ágiles refieren iteraciones como sprints, donde las etapas o versiones es más usados por desarrolladores de cascada. En general, una fase incluye:
- Actividades, incluyendo *user stories* y tareas para realizar la phase
- Criterio para entrar
- Criterio para salir
#### Milestones
Como intervalos regulares, un equipo de desarrollo puede tomar tiempo para evaluar el progreso y calidad. A menudo, estas **milestones** ocurren al final de una o más phases. En general existen dos tipos de milestones:
- **Internal milestones** enfocadas en el proceso y proveer objectivos concretos para el equipo, como procede a través del proceso.
- **External milestones** enfocadas en el cliente o quiza en áreas de la organización fuera del equipo de desarrollo, como un departamento de marketing.
Los Milestones pueden estar vinculados a fechas límite de fechas de calendario específicas en lugar de avanzar en el proyecto.
#### Entry Criteria
**Entry criteria** son condiciones que deben presentarse antes de que una *phase* pueda comenzar satisfactoriamente. En otras palabras, qué necesita estar realizado antes de que la *phase* pueda empezar?
### Exit Criteria
Son las condiciones que el producto  servicio debe satisfacer antes de un particular milestone este completo. Los Exit criteria pueden incluir condiciones como covertura de código, densidad de defecto, o características completas.
## Working with Bugs
#### Managing Distributed Testing
Distributed testing is el uso de múltiples computadoras (configuradas como **lab enviroment**) para ejecutar pruebas y recolectar datos.
El lab puede consistir de físicas o máquinas virtuales. **Distributing testing** requiere una máquina con un **test controller** y las máquinas lab con **test agents**.
- **Test Controller**: es un proceso en segundo plano que administra un conjunto de maquinas con el *test agent* instalado.
- **Test Agent**: Es un proceso en segundo plano que recibe, corre, y reporta en los test, recoje datos en una sola computadora. El *test agent* comunica con el *test controller*, por lo regular localizado en otra computadora. 
#### Bug Priority
**Priority** es una calificación subjetiva del bug en lo que se refiere al negocio.
#### Bug Severity
**Severity** es una calificación subjetiva del impacto del bug en el proyecto
- Critical
- High
- Medium
- Low
#### Bug Stack Rank
**Stack rank** es una calificación subjetiva de la comparación del bug con otros. Un bug que es asignado a un número bajo debería ser arreglado antes que un bug que tiene un número asignado más alto.
#### Reproducing (Repor) Steps
Repro steps son los pasos que otros testers o desarrolladores deben ejecutar para reproducir el bug o el comportamiento innesperado
#### Bug States
Un equipo puede rastrear el progreso de un bug por el ajuste a su *State*. Los posibles valores para el estado podrían variar basado en la metodología de desarrollo, pero los modelos usan conceptos similares.
- **Active**
- **Resolved**
- **Closed**
## Automating Software Test
#### Testing Login with Assertions
Una **Assertion** es una sentencia del test con una condición durante la ejecución del programa. Si la **assertion** es true, no ocurre una acción; si la **assertion** es false, la **assertion** falla.


