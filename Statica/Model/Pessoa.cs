

namespace Statica.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString(){
            return  $"Id = {Id }| Nome = {Nome}";
        }
    }
}