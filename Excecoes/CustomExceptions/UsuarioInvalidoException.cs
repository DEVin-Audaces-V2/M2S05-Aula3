
namespace Excecoes.CustomExceptions
{
    public class UsuarioInvalidoException : Exception
    {
        public UsuarioInvalidoException()
        {
            
        }
        public UsuarioInvalidoException(string message) : base(message)
        {
           
        }
        
    }
}