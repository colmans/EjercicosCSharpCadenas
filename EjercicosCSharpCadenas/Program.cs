// See https://aka.ms/new-console-template for more information

/*7- Solicite al usuario ingrese su nombre y presente el mensaje "Hola [nombre]"*/
Console.WriteLine("Por favor ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Hola" + " " + nombre);

/*8-
 */

Console.WriteLine("Por favor ingrese una Frase");
string frase = Console.ReadLine();
Console.WriteLine("Tiene la palabra fin?   ");

/*9-
 * mostrarlo en mayuscula: 
 */

Console.WriteLine("Ingrese una palabra cualquiera");
string fraseEnmayuscula = Console.ReadLine();
Console.WriteLine(fraseEnmayuscula.ToLowerInvariant);