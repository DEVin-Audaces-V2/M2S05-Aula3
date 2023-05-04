using Statica.Model;

namespace Statica.Service
{
    public class PessoaService
    {
        static private List<Pessoa> _pessoas = new List<Pessoa>();

        public void Add(Pessoa pessoa){
            _pessoas.Add(pessoa);
        }

        public void imprimirPessoas(){
            Console.WriteLine("Imprimindo pessoas");
            foreach(var pessoa in _pessoas){

                Console.WriteLine(pessoa.ToString());
            }
        }
    }
}