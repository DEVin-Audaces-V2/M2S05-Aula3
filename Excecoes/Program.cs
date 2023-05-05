using Excecoes;
using Excecoes.CustomExceptions;


// Console.WriteLine("digite Um Numero");
// var num = int.Parse(Console.ReadLine());


// var divisor = 0;
// var resultado = 5/divisor ;

// Calculadora calculadora = null;

// calculadora.Soma(1,2);

try{
  //throw new Exception("Aconteceu um erro");
  var usuario = "Vitor";
  var usuarioValido = false;
  if(!usuarioValido ){
    throw new UsuarioInvalidoException($"O Usuario {usuario} não é válido ",usuario);
  }
}
catch(UsuarioInvalidoException ex){
  Console.WriteLine("Aconteceu uma tragedia"+ ex.Message);
  Console.WriteLine ("O usuario Causador: "+ ex.UsuarioNome);
}
catch(Exception ex){
  Console.WriteLine("Aconteceu uma tragedia pior "+ ex.Message);
}
finally{
  Console.WriteLine("Bloco do Finally");
}