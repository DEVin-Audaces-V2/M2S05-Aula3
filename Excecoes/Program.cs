using Excecoes;
using Excecoes.CustomExceptions;


// Console.WriteLine("digite Um Numero");
// var num = int.Parse(Console.ReadLine());


// var divisor = 0;
// var resultado = 5/divisor ;

// Calculadora calculadora = null;

// calculadora.Soma(1,2);

var usuario = "Vitor";
var usuarioValido = false;
if(!usuarioValido ){
  throw new UsuarioInvalidoException($"O Usuario {usuario} não é válido ");
}

