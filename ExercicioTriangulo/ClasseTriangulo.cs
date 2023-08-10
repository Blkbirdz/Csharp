namespace Triangulo{
    class Triangulo {
        // atributos
        public double lado1=0;
        public double lado2=0;
        public double lado3=0;

        // métodos
        public bool isTriangle(){
            if(lado1+lado2<=lado3 || lado1+lado3<=lado2 || lado2+lado3<=lado1){
                return false;
            }
            return true;
        }
        public void calcPerimetro(){
            double perimetro = lado1+lado2+lado3;
            Console.WriteLine("O perimetro do triângulo vale " + perimetro);
        }        
        public void calcArea(){
            double semip = (lado1+lado2+lado3)/2;
            double area = Math.Sqrt(semip*(semip-lado1)*(semip-lado2)*(semip-lado3)); // área pela Fórmula de Herão

            Console.WriteLine("A área do triângulo vale " + Math.Round(area, 3));
        }
        public void Classificar(){
            if(lado1!=lado2 && lado2!=lado3 && lado1!=lado3){
                Console.WriteLine("Esse triângulo é Escaleno!");
            }else if(lado1 == lado2 && lado2 == lado3){
                Console.WriteLine("Esse triângulo é Equilátero!");
            }else{
                Console.WriteLine("Esse triângulo é Isósceles!");
            }
        }

    }
}