//using System;
//using System.Diagnostics;

//namespace program
//{
//    public class program
//    {

//        public static void Main(string[] args)
//        {
//            string? nomyap, nom, ap;
//            int spos;

//            nomyap = Console.ReadLine();

//            spos = nomyap.IndexOf(" ");

//            nom = nomyap.Substring(0, spos);
//            ap = nomyap.Substring(spos + 1, nomyap.Length - spos - 1);

//            Console.WriteLine($"Hola, {ap} {nom}!");

//        }
//    }
//}

//namespace punto2
//{
//    class punto2
//    {
//        public static void Main(string[] args) 
//        {
//            string nya, n, a;
//            int spos;

//            Console.WriteLine("Ingrese su nombre y apellido en minúscula");

//            nya = Console.ReadLine();

//            spos = nya.IndexOf(" ");

//            nya = char.ToUpper(nya[0]) + nya.Substring(1, spos) + char.ToUpper(nya[spos + 1]) + nya.Substring(spos + 2, nya.Length - spos - 2);

//            Console.WriteLine("Hola, " + nya + "!");
//        }
//    }
//}

//namespace punto3
//{
//    class punto3
//    {
//        public static void Main(string[] args)
//        {
//            string nombre, vocales;

//            int conteo;

//            vocales = "aeiou";

//            conteo = 0;

//            nombre = Console.ReadLine();

//            nombre = nombre.Replace(" ", @"/");

//            for (int i = 0; i < nombre.Length; i++)
//            {

//                if (vocales.Contains(nombre[i])) {

//                    conteo++;

//                }
//            }
//            Console.WriteLine($"La cantidad de vocales es {conteo} y el texto con reemplazo es: \n {nombre}");
//        }
//    }
//}

//using System.Text;

//namespace punto4
//{
//    class punto4
//    {
//        public static void Main(string[] args)
//        {
//            string nya, n, ap;
//            int sp;

//            nya = Console.ReadLine();

//            sp = nya.IndexOf(" ");

//            n = nya.Substring(0, sp);

//            char o1 = nya[0];

//            ap = nya.Substring(sp + 1, nya.Length - sp - 1);

//            n = Mayus(n);

//            ap = Mayus(ap);

//            Console.WriteLine($"Hola, {n} {ap}!");
//            //inicial = char.ToUpper(n[0]);

//        }
//        public static string Mayus(string p)
//        {   
//            return char.ToUpper(p[0]) + p.Substring(1);
//        }
//    }
//}

//using System;
//using System.Text.RegularExpressions;

//namespace punto5
//{
//    class p5
//    {
//        public static void Main(string[] args)
//        {
//            string username;
//            bool cumple = false;
//            Console.WriteLine("Ingrese un nombre de usuario");

//            do
//            {
//                username = Console.ReadLine();

//                cumple = verificarLargo(username)  && verificarContenido(username);

//                if (username.Length < 6)
//                {
//                    Console.WriteLine("El nombre de usuario debe ser mas largo que 6.");
//                }
//                else if (username.Length > 12)
//                {
//                    Console.WriteLine("Debe tener menos de 12 caracteres");
//                }
//                else if (verificarContenido(username) == false)
//                {
//                    Console.WriteLine("El nombre de usuario debe tener solo caracteres afanuméricos");
//                }
//            }
//            while (cumple == false);
//            Console.WriteLine($"El nombre de usuario ha sido correctamente verificado y es {username}");
//        }
//        public static bool verificarLargo(string a)
//        {
//            return (a.Length >= 6 && a.Length <= 12);
//        }
//        public static bool verificarContenido(string a)
//        { 
//            string regex = "^[a-zA-Z0-9]*$";

//            return Regex.IsMatch(a, regex);

//        }
//    }
//}


//using System;
//using System.Text.RegularExpressions;


//Clases y Objetos:

//    Crea una clase Persona con propiedades como nombre, edad y dirección. Luego, crea una lista de objetos Persona y ordénalos por edad.



//namespace Program
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Persona[] arr = new Persona[3];

//            for (int i = 0; i < arr.Length; i++)
//            {
//                string n, direc;
//                int edad;

//                Console.WriteLine("Ingresa tu nombre, dirección y edad, por separado, pulsando enter al cargar tal dato.");
//                n = Console.ReadLine();
//                direc = Console.ReadLine();
//                edad = Convert.ToInt32(Console.ReadLine());

//                arr[i] = (new Persona(n, direc, edad));
//            }

//            Array.Sort(arr, (p1, p2) => p1.Edad.CompareTo(p2.Edad));

//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(arr[i].ToString());
//            }
//            Console.WriteLine(Persona.cantidadPersonas);
//        }
//    }
//    class Persona
//    {
//        private string nombre, direccion;
//        private int edad;
//        public static int cantidadPersonas = 0;

//        public Persona(string nombre, string direccion, int edad)
//        {
//            this.nombre = nombre;
//            this.direccion = direccion;
//            this.edad = edad;
//            cantidadPersonas++;
//        }

//        // Propiedades automáticas
//        public string Nombre { get; set; }
//        public string Direccion { get; set; }
//        public int Edad { get; set; }

//        public override string ToString()
//        {
//            return $"Hola, soy {Nombre}, vivo en {Direccion} y tengo {Edad}.";
//        }
//    }
//}

using System.Text.RegularExpressions;

//namespace punto5
//{
//    class p5
//    {
//        public static void Main(string[] args)
//        {
//            string username;
//            bool cumple = false;
//            Console.WriteLine("Ingrese un nombre de usuario");

//            do
//            {
//                username = Console.ReadLine();

//                cumple = verificarLargo(username) && verificarContenido(username);

//                if (username.Length < 6)
//                {
//                    Console.WriteLine("El nombre de usuario debe ser mas largo que 6.");
//                }
//                else if (username.Length > 12)
//                {
//                    Console.WriteLine("Debe tener menos de 12 caracteres");
//                }
//                else if (verificarContenido(username) == false)
//                {
//                    Console.WriteLine("El nombre de usuario debe tener solo caracteres afanuméricos");
//                }
//            }
//            while (cumple == false);
//            Console.WriteLine($"El nombre de usuario ha sido correctamente verificado y es {username}");
//        }
//        public static bool verificarLargo(string a)
//        {
//            return (a.Length >= 6 && a.Length <= 12);
//        }
//        public static bool verificarContenido(string a)
//        {
//            string regex = "^[a-zA-Z0-9]*$";

//            return Regex.IsMatch(a, regex);

//        }
//        public static bool CorroborarUser(string a)
//        {
//            return verificarContenido(a) && verificarLargo(a);
//        }
//    }
//}


//namespace punto5
//{
//    class p5
//    {
//        public static void Main(string[] args)
//        {
//            string username;
//            bool cumple = false;
//            Console.WriteLine("Ingrese un nombre de usuario");

//            do
//            {
//                username = Console.ReadLine();

//                cumple = verificarLargo(username) && verificarContenido(username);

//                if (username.Length < 6)
//                {
//                    Console.WriteLine("El nombre de usuario debe ser mas largo que 6.");
//                }
//                else if (username.Length > 12)
//                {
//                    Console.WriteLine("Debe tener menos de 12 caracteres");
//                }
//                else if (verificarContenido(username) == false)
//                {
//                    Console.WriteLine("El nombre de usuario debe tener solo caracteres afanuméricos");
//                }
//            }
//            while (cumple == false);
//            Console.WriteLine($"El nombre de usuario ha sido correctamente verificado y es {username}");
//        }
//        public static bool verificarLargo(string a)
//        {
//            return (a.Length >= 6 && a.Length <= 12);
//        }
//        public static bool verificarContenido(string a)
//        {
//            string regex = "^[a-zA-Z0-9]*$";

//            return Regex.IsMatch(a, regex);

//        }
//        public static bool CorroborarUser(string a)
//        {
//            return verificarContenido(a) && verificarLargo(a);
//        }
//    }
//}

//using System.Diagnostics;

//class Punto1
//{
//    public static void Main(string[] args)
//    {
//        string frase;
//        Console.WriteLine("Ingrese la frase que quiere corroborar");
//        frase = Console.ReadLine();

//        Dictionary<char, int> letras = new Dictionary<char, int>
//        {
//            {'a' , 0},
//            {'e', 0 },
//            {'i', 0},
//            {'o', 0 },
//            {'u', 0 }
//        };

//        for (int i = 0; i < frase.Length; i++)
//        {
//            char letra = char.ToLower(frase[i]);

//            if (letras.ContainsKey(letra))
//            {
//                letras[letra]++;
//            }
//        }
//        Reemplazar(letras, ref frase);
//        Console.WriteLine(frase);
//    }
//    public static void Reemplazar(Dictionary<char, int> let, ref string fra)
//    {
//        if  (let['a'] > let['e'] && let['a'] > let['i'] && let['a'] > let['o'] && let['a'] > let['u'])
//        {
//            fra = fra.Replace('a', '@');
//            fra = fra.Replace('A', '@');
//            fra = $"Su frase modificada, es {fra}";
//        }
//        else
//        if (let['e'] > let['a'] && let['e'] > let['i'] && let['e'] > let['o'] && let['e'] > let['u'])
//        {
//            fra = fra.Replace('e', '@');
//            fra = fra.Replace('E', '@');
//            fra = $"Su frase modificada, es {fra}";

//        }
//        else
//        if (let['i'] > let['a'] && let['i'] > let['e'] && let['i'] > let['o'] && let['i'] > let['u'])
//        {
//            fra = fra.Replace('i', '@');
//            fra = fra.Replace('I', '@');
//            fra = $"Su frase modificada, es {fra}";

//        }
//        else
//        if (let['o'] > let['a'] && let['o'] > let['e'] && let['o'] > let['i'] && let['o'] > let['u'])
//        {
//            fra = fra.Replace('o', '@');
//            fra = fra.Replace('O', '@');
//            fra = $"Su frase modificada, es {fra}";

//        }
//        else
//        if (let['u'] > let['a'] && let['u'] > let['e'] && let['u'] > let['i'] && let['u'] > let['o'])
//        {
//            fra = fra.Replace('u', '@');
//            fra = fra.Replace('U', '@');
//            fra = $"Su frase modificada, es {fra}";

//        }
//        else
//        {
//            fra = $"Su frase no ha sufrido modificaciones: {fra}";
//        }
//    }
//}


//class punto5
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(factorial(5));
//    }
//    public static int factorial(int a) 
//    {
//        return a == 0 ? 1 : a * factorial(a - 1);
//    }
//}


class punto2
{
    public static void Main(string[] args)
    {
        int num;
        do
        {
            Console.WriteLine("Ingrese un un numero para saber su factorial. Debe ser mayor a 0");
            num = Convert.ToInt32(Console.ReadLine());
        } while (num < 1);
        Console.WriteLine($"El factorial de su numero es {Factorial(num)}");

    }
    public static int Factorial (int n)
    {
        return n == 0 ? 1 : n * Factorial (n - 1);
    }

}