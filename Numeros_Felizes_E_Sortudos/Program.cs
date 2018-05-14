using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Felizes_E_Sortudos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroContador = 1;
            List<int> listaNumeroTestes = new List<int> { 7, 21, 28, 142, 37, 100 };

            List<int> listaNumero = new List<int>();
            for (int i = 1; i <= 100; i++)
                listaNumero.Add(i);

            List<int> listaNumeroFeliz = new List<int>();

            NumeroFeliz quadrado = new NumeroFeliz();
            for (int i = numeroContador; numeroContador <= 100; i++)
            {
                bool numFeliz = quadrado.VerificaNumFeliz(numeroContador);
                if (numFeliz == true)
                    listaNumeroFeliz.Add(numeroContador);
                numeroContador++;
            }
            Console.Write("Lista de Números Felizes: \n");
            listaNumeroFeliz.ForEach(i => Console.Write("{0},", i));
            Console.WriteLine("\n\nLista de Números Sortudos: ");
            //Console.ReadKey();

            NumeroSortudo listaNumeroSortudo = new NumeroSortudo();
            List<int> _listaNumero = listaNumeroSortudo.ListaNumerosSortudos(listaNumero);
            _listaNumero.ForEach(i => Console.Write("{0},", i));
            Console.WriteLine("\n\nTestes:");
            //Console.ReadKey();

            foreach (int numero in listaNumeroTestes)
            {
                string _msgTeste = "";
                string _numeroTestado = Convert.ToString(numero);
                string _feliz = "";
                string _sortudo = "";

                if (quadrado.VerificaNumFeliz(numero) == true)
                    _feliz = "Feliz";
                else
                    _feliz = "Não-Feliz";

                if (_listaNumero.Contains(numero) == true)
                    _sortudo = "Sortudo";
                else
                    _sortudo = "Não-Sortudo";

                _msgTeste = _numeroTestado + " - Número " + _sortudo + " e " + _feliz;
                Console.WriteLine(_msgTeste);
            }
            Console.ReadKey();
        }
    }
}
