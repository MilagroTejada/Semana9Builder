using System;

// Clase que representa la configuración
public class ConfiguracionBD
{
    public string Servidor { get; set; }
    public string BaseDatos { get; set; }
    public string Usuario { get; set; }
    public string Password { get; set; }
    public int Puerto { get; set; }
    public int Timeout { get; set; }

    public void MostrarConfig()
    {
        Console.WriteLine("Servidor: " + Servidor);
        Console.WriteLine("Base de Datos: " + BaseDatos);
        Console.WriteLine("Usuario: " + Usuario);
        Console.WriteLine("Password: " + Password);
        Console.WriteLine("Puerto: " + Puerto);
        Console.WriteLine("Timeout: " + Timeout);
    }
}

// Builder
public class ConfiguracionBuilder
{
    private ConfiguracionBD config = new ConfiguracionBD();

    public ConfiguracionBuilder SetServidor(string servidor)
    {
        config.Servidor = servidor;
        return this;
    }

    public ConfiguracionBuilder SetBaseDatos(string bd)
    {
        config.BaseDatos = bd;
        return this;
    }

    public ConfiguracionBuilder SetUsuario(string usuario)
    {
        config.Usuario = usuario;
        return this;
    }

    public ConfiguracionBuilder SetPassword(string password)
    {
        config.Password = password;
        return this;
    }

    public ConfiguracionBuilder SetPuerto(int puerto)
    {
        config.Puerto = puerto;
        return this;
    }

    public ConfiguracionBuilder SetTimeout(int timeout)
    {
        config.Timeout = timeout;
        return this;
    }

    public ConfiguracionBD Build()
    {
        return config;
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        var config = new ConfiguracionBuilder()
            .SetServidor("localhost")
            .SetBaseDatos("EmpresaDB")
            .SetUsuario("admin")
            .SetPassword("1234")
            .SetPuerto(1433)
            .SetTimeout(30)
            .Build();

        config.MostrarConfig();
    }
}