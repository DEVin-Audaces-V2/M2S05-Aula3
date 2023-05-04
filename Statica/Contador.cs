
namespace Statica
{
    public class Contador
    {
        private static int _num;
        public static int ContadorDeInstancias;  

        public Contador()
        {
            ContadorDeInstancias ++;
        }

        public void IncremntaNum(){
            _num ++; 
        }
        public int GetNum(){
            return _num; 
        }
    }
}