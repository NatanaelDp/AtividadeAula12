using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula12
{
    internal class Produto
    {
        public string nome;
        public string descricao;
        public int quantidade;
        public double valor;
        public bool status;


        public void mostra()
        {
            Console.WriteLine("Nome:" + nome);
            Console.WriteLine("Valor " + valor);
            Console.WriteLine("Status " + status);
            Console.WriteLine("\nDescrição:" + descricao);
            


        }

        public void desativa()
        {
            quantidade= 0;
            status= false;
        }

        
    }
}
