# Testing in Visual Studio
## Unit Test Basics
### Unit Test
Un Unit test es una pieza automátizada de código que invoca una unidad de trabajo en el sistema y verifica una sola suposición acerca del comportamiento del trabajo.
### Test-Driven Development
Integrar testing dentro del proceso de desarrollo. Los test definen el código que se hará.

![TDD](http://lewandowski.io/images/tdd_flow.gif)

Ejemplo:
```C#
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestAdd()
    {
        // Arrange
        int num1 = 2;
        int num2 = 3;

        // Act
        int sum = MyMath.Add(num1, num2);

        // Assert
        Assert.AreEqual(5, sum);
    }
}
```
## Integration Test
Un *Integration test* valida dos o más módulos de software dependientes como un grupo de múltiples maneras. 
## Acceptance / Manual Testing Basics
### Manual acceptance test
Un *acceptance test* valida si un requerimiento o especificaciones se cumplan.
![Test Plan](https://visualstudio.microsoft.com/wp-content/uploads/2016/04/IC809524-new.png)

![Test Case](https://msdnshared.blob.core.windows.net/media/MSDNBlogsFS/prod.evol.blogs.msdn.com/CommunityServer.Blogs.Components.WeblogFiles/00/00/00/43/11/metablogapi/4555.image_4.png)

## Automated UI Testing Basics
### Automated UI test
Un *automated user interface test* maneja la aplicación UI a validar las especificaciones del usuario.
[Adjunto por default solo en Visual Studio 2015]
## Web Performance and Load Testing Basics
Un *performance test* valida la capacidad de respuesta, el rendimiento, la confiabilidad y la escalabilidad de una aplicación.
[Característica solo para Visual Studio Enterprise] - Demo Pendiente
## Exploratory Testing Basics
### Exploratory test
Un *Exploratory test* usa la inteligencia del tester y creatividad para validar la calidad, usabilidad, rendimiento, experiencia, etc.
Plugin de Chrome
![Plugin Chrome](https://www.red-gate.com/simple-talk/wp-content/uploads/2016/08/word-image-88.png)



