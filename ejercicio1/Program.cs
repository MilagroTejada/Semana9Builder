using System;
using System.Collections.Generic;

// Producto simple
public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

// Clase principal que se va a construir
public class Pedido
{
    public string Cliente { get; set; }
    public List<Producto> Productos { get; set; } = new List<Producto>();
    public string DireccionEnvio { get; set; }
    public string MetodoPago { get; set; }
    public double Descuento { get; set; }
    public double Impuestos { get; set; }

    public void MostrarPedido()
    {
        Console.WriteLine("Cliente: " + Cliente);
        Console.WriteLine("Productos:");
        foreach (var p in Productos)
        {
            Console.WriteLine($"- {p.Nombre}: ${p.Precio}");
        }
        Console.WriteLine("Dirección: " + DireccionEnvio);
        Console.WriteLine("Método de Pago: " + MetodoPago);
        Console.WriteLine("Descuento: " + Descuento);
        Console.WriteLine("Impuestos: " + Impuestos);
    }
}

// Builder
public class PedidoBuilder
{
    private Pedido pedido = new Pedido();

    public PedidoBuilder SetCliente(string cliente)
    {
        pedido.Cliente = cliente;
        return this;
    }

    public PedidoBuilder AgregarProducto(Producto producto)
    {
        pedido.Productos.Add(producto);
        return this;
    }

    public PedidoBuilder SetDireccion(string direccion)
    {
        pedido.DireccionEnvio = direccion;
        return this;
    }

    public PedidoBuilder SetMetodoPago(string metodo)
    {
        pedido.MetodoPago = metodo;
        return this;
    }

    public PedidoBuilder SetDescuento(double descuento)
    {
        pedido.Descuento = descuento;
        return this;
    }

    public PedidoBuilder SetImpuestos(double impuestos)
    {
        pedido.Impuestos = impuestos;
        return this;
    }

    public Pedido Build()
    {
        return pedido;
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        var pedido = new PedidoBuilder()
            .SetCliente("Juan Pérez")
            .AgregarProducto(new Producto("Laptop", 800))
            .AgregarProducto(new Producto("Mouse", 25))
            .SetDireccion("San Salvador")
            .SetMetodoPago("Tarjeta")
            .SetDescuento(50)
            .SetImpuestos(13)
            .Build();

        pedido.MostrarPedido();
    }
}

// Ejercicio 1 - revisión final