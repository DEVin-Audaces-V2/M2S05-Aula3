
namespace Excecoes.CustomExceptions
{
    public class UsuarioInvalidoException : Exception
    {
        public string UsuarioNome { get; private set; }
        public UsuarioInvalidoException()
        {
            
        }
        public UsuarioInvalidoException(string message, string usuarioNome) : base(message)
        {
           UsuarioNome = usuarioNome;
        }
        
    }
}