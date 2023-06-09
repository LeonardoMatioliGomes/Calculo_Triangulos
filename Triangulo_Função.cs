using System;
using System.Globalization;

//"Course" agrupa as classes do programa.
namespace Course
{ 
    //declaro a classe "Program" dentro do "Course". para assim ter método "Main", que é o ponto de entrada.
    public class Program
    {
        public static void Main(string[] args)
        {
            //são declarados dois arrays de "double", "medidasX" e "medidasY", que irão armazenar as medidas dos triângulos 'X' e 'Y', respectivamente.
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");
            //"LerMedidasTriangulo" é um método responsável por ler as medidas digitadas pelo usuário e retorná-las em um array de double.
            
            //"CalcularAreaTriangulo" é um método que recebe como argumento o array de medidas e retorna a área calculada.
            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);

            //"Console.WriteLine" exibe as áreas dos triangulos.
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //formatando os valores com quatro casas decimais ("F4") e utilizando a cultura "CultureInfo.InvariantCulture" para evitar problemas com formatação de números em diferentes configurações regionais
            
            //nessa parte é feita a comparação das áreas (se X ou Y é maior).
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
        
        //O método "LerMedidasTriangulo" recebe como argumento uma string nomeTriangulo, que representa o nome do triângulo a ser lido
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            double[] medidas = new double[3];

            //O método exibe uma mensagem pedindo para o usuário inserir as medidas do triângulo e, em seguida, lê as três medidas digitadas pelo usuário usando "Console.ReadLine()"
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            for (int i = 0; i < 3; i++)
            {
                
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            return medidas;
        }

        public static double CalcularAreaTriangulo(double[] medidas)
        {
            //Essas medidas são armazenadas em um array de double e, por fim, o array é retornado
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];

            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

    }

}
