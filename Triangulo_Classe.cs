using System;
using System.Globalization;

//O código está dentro de um namespace chamado Course, que agrupa as classes relacionadas a um determinado curso ou projeto
namespace Course
{
    //classe Triangulo é declarada. Essa classe representa um triângulo e possui três propriedades: A, B e C, que armazenam as medidas dos lados do triângulo
    public class Triangulo
    {

        public double A { get; set; }
        public double B { get; set; }   
        public double C { get; set; }

        //Esse método realiza o cálculo da área do triângulo com base nas medidas dos lados A, B e C. 
        public double CalcularArea()
        {
            //O cálculo é feito utilizando a fórmula de Heron, onde é calculado o semiperímetro p e, em seguida, a área é obtida usando a fórmula de Bhaskara.
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }

    //declarada classe "Program"
    public class Program
    {
        //classe "main" dentro do "program" é declarada
        public static void Main(string[] args)
        {
            //declaração de duas instancias da classe triangulo
            Triangulo x = LerTriangulo("x");
            Triangulo y = LerTriangulo("y");
            //Esse método é responsável por ler as medidas dos lados de um triângulo e retornar uma instância da classe Triangulo com as medidas fornecidas
            
            //Após obter as instâncias x e y, o programa chama o método "CalcularArea" para cada uma delas, armazenando o resultado nas variáveis "areaX" e "areaY"
            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            //Os valores são formatados com quatro casas decimais ("F4") e a cultura CultureInfo.InvariantCulture é utilizada para evitar problemas com a formatação 
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //nessa parte, é comparado a área X e área Y.
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            //O método exibe uma mensagem solicitando ao usuário que insira as medidas do triângulo com o nome especificado
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            //As medidas são lidas usando o método "Console.ReadLine()" e são atribuídas às propriedades A, B e C do objeto triangulo.
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             return triangulo;
        }
        
    }
}
