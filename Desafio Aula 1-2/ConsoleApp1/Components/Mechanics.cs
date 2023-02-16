using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.components
{
    internal class Mechanics
    {
        private double accel { get; set; }
        private double velc { get; set; }
        private double mass { get; set; }

        private double position { get; set; }

        private double time { get; set; }

        public void CacularForca(double mass, double accel)
        {
            double forca = accel * mass;
            Console.WriteLine($"Massa: {mass}\nAceleração: {accel}\nForça Resultante: {forca}");
        }

        public void CalcularVelocidade(double position, double time)
        {
            double velocidade = position / time;
            Console.WriteLine($"Deslocamento: {position}\nVariação do Tempo: {time}\nVelocidade Média: {velocidade}");
        }

        

    }
}
