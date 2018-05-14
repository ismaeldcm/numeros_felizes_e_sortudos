using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Felizes_E_Sortudos
{
    public class NumeroFeliz
    {
        public bool VerificaNumFeliz(int _numero)
        {
            bool numfeliz = false;
            _numero = QuadradoDoNumero(_numero);
            for (int i = 0; i < 100 && !numfeliz; i++)
            {
                _numero = SomaDigitos(_numero);
                if (_numero == 1)
                    numfeliz = true;
            }
            return numfeliz;
        }

        public int QuadradoDoNumero(int num)
        {
            int quadrado_num = num * num;
            return quadrado_num;
        }

        public List<int> ListaDigitos(int _quadrado_num)
        {
            List<int> dividido = new List<int>();
            while (_quadrado_num != 0)
            {
                dividido.Add(_quadrado_num % 10);
                _quadrado_num = _quadrado_num / 10;
            }
            return dividido;
        }

        public int SomaDigitos(int _num_quadrado)
        {
            int digitosSomados = 0;
            List<int> listadigitos = ListaDigitos(_num_quadrado);
            foreach (int digito in listadigitos)
            {
                digitosSomados = digitosSomados + QuadradoDoNumero(digito);
            }
            return digitosSomados;
        }
    }
}
