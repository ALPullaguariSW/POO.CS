using System;

// Definición de la interfaz
public interface IMostrarInformacion
{
    // Método para mostrar información general
    void MostrarInformacion();
}

// Definición de la clase Empleado
public class Empleado : IMostrarInformacion
{
    // Propiedades auto-implementadas para Nombre y Salario
    public string Nombre { get; set; }
    public double Salario { get; set; }

    // Constructor de la clase Empleado
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    // Método para calcular el salario anual
    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    // Implementación del método de la interfaz IMostrarInformacion
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Salario: {Salario:C}");
    }
}

// Definición de la clase Gerente que hereda de Empleado
public class Gerente : Empleado, IMostrarInformacion
{
    // Propiedad auto-implementada para el nuevo atributo Departamento
    public string Departamento { get; set; }

    // Constructor de la clase Gerente, utilizando la base para inicializar el empleado
    public Gerente(string nombre, double salario, string departamento)
        : base(nombre, salario)
    {
        Departamento = departamento;
    }

    // Implementación del método de la interfaz IMostrarInformacion con override
    public override void MostrarInformacion()
    {
        // Llama al método de la clase base antes de agregar información específica del gerente
        base.MostrarInformacion();
        Console.WriteLine($"Departamento: {Departamento}");
    }
}

class Program
{
    static void Main()
    {
        // Crear instancias de Empleado y Gerente
        Empleado empleado = new Empleado("Juan", 50000);
        Gerente gerente = new Gerente("Ana", 80000, "Ventas");

        // Mostrar información utilizando polimorfismo a través de la interfaz
        Console.WriteLine("Información del Empleado:");
        MostrarInformacionConInterfaz(empleado);

        Console.WriteLine("\nInformación del Gerente:");
        MostrarInformacionConInterfaz(gerente);
    }

    // Método genérico para mostrar información utilizando la interfaz IMostrarInformacion
    static void MostrarInformacionConInterfaz(IMostrarInformacion objeto)
    {
        objeto.MostrarInformacion();
    }
}
