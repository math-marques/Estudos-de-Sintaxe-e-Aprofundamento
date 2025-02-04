using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos;

public class Carro
{
    public int Cor;

    public int Chassi { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public int Ano { get; set; }

    public Carro(int cor)
    {
        Cor = cor;
    }
}
