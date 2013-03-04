using System;


class Persona{
	public string nombre;
	public string telefono;
	public string email;
	public string domicilio;
		
public static void Main(){
	Persona datos = new Persona();
	Console.WriteLine("Dame el nombre");
	datos.nombre=Console.ReadLine();
	Console.WriteLine("Dame telefono");
	datos.telefono=Console.ReadLine();
	Console.WriteLine("Dame e-mail");
	datos.email=Console.ReadLine();
	Console.WriteLine("Dame domicilio");
	datos.domicilio=Console.ReadLine();

		Console.Clear();

		Console.WriteLine("Nombre: " +datos.nombre);
		Console.WriteLine("Telefono: " +datos.telefono);
		Console.WriteLine("E-mail: " +datos.email);
		Console.WriteLine("Domicilio: " +datos.domicilio);
}
	}