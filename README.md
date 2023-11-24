# POO.CS


# Aplicación de Gestión de Empleados

Este proyecto es una aplicación simple de gestión de empleados implementada en C# utilizando conceptos de Programación Orientada a Objetos (POO). La aplicación incluye las siguientes características:

1. **Definición de Clases:**
   - Clase `Empleado` con atributos como `Nombre` y `Salario`.
   - Método en la clase `Empleado` para calcular el salario anual.

2. **Herencia:**
   - Clase `Gerente` que hereda de la clase `Empleado`.
   - Nuevo atributo `Departamento` para la clase `Gerente`.

3. **Interfaz:**
   - Interfaz `IMostrarInformacion` con un método para mostrar información general.

4. **Implementación:**
   - Implementación de la interfaz `IMostrarInformacion` en las clases `Empleado` y `Gerente`.
   - Creación de instancias de `Empleado` y `Gerente` y muestra de información utilizando polimorfismo a través de la interfaz.

## Cómo Ejecutar la Aplicación

Asegúrate de tener un entorno de desarrollo C# configurado. Puedes ejecutar la aplicación desde Visual Studio o mediante la línea de comandos con el comando `dotnet run`.

```bash
dotnet run
