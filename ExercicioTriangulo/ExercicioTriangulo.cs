using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace Triangulo {
    class Programa{
        static void Main(string[] args){

            //instanciando o objeto
            Triangulo objTriangulo = new Triangulo();

            //definindo os lados do objeto triangulo
            Console.Write("Digite o 1o lado: ");
            objTriangulo.lado1 = Double.Parse(Console.ReadLine());            
            Console.Write("Digite o 2o lado: ");
            objTriangulo.lado2 = Double.Parse(Console.ReadLine());
            Console.Write("Digite o 3o lado: ");
            objTriangulo.lado3 = Double.Parse(Console.ReadLine());

            if(!objTriangulo.isTriangle()){
                Console.WriteLine("Os lados inseridos NÃO formam um triangulo!!");
                Environment.Exit(1);
            }
            objTriangulo.Classificar();
            objTriangulo.calcPerimetro();
            objTriangulo.calcArea();
        }
    }
}