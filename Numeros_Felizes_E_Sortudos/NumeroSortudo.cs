using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Felizes_E_Sortudos
{
    public class NumeroSortudo
    {
        public List<int> ListaNumerosSortudos(List<int> _numeros)
        {
            List<int> _listaNumeros = new List<int>();
            List<int> _listaTermos = new List<int>();
            int numInicial = 2;
            int numTermo = 0;

            foreach (int num in _numeros)
            {
                if (num % numInicial != 0)
                    _listaNumeros.Add(num);
            }
            _numeros = new List<int>(_listaNumeros);

            if (_listaTermos.Count == 0)
            {
                numTermo = numInicial + 1;
                _listaTermos.Add(numTermo);
            }

            bool proximoTermo = false;
            bool ultimoTermo = false;
            while (ultimoTermo == false)
            {
                proximoTermo = false;
                for (int i = 1; i != _numeros.Last(); i++)
                {
                    if (_numeros.Contains(i) != false)
                    {
                        if ((_numeros.IndexOf(i) + 1) % numTermo == 0 && _numeros.IndexOf(i) != 0)
                            _listaNumeros.Remove(i);
                        else
                        {
                            if (proximoTermo == false && i > numTermo)
                            {
                                _listaTermos.Add(i);
                                proximoTermo = true;
                            }
                        }
                    }
                }
                numTermo = _listaTermos.Last();
                _numeros = new List<int>(_listaNumeros);
                if (numTermo > _numeros.Count())
                    break;
            }

            return _listaNumeros;
        }
    }
}
