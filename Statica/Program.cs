using Statica;
using Statica.Model;
using Statica.Service;


Calculadora calculadora = new Calculadora();


var soma = Calculadora.Soma(5,3);
var subtracao = Calculadora.Subtracao(5,3);

Console.WriteLine(soma);


var contador = new Contador();
contador.IncremntaNum();
contador.IncremntaNum();
contador.IncremntaNum();

var contador2 = new Contador();
contador2.IncremntaNum();
contador2.IncremntaNum();

Console.WriteLine(contador.GetNum());
Console.WriteLine(contador2.GetNum());


var contador3 = new Contador();
Console.WriteLine("Quantidade instancias= " + Contador.ContadorDeInstancias);


//Pessoas

PessoaService pessoaService = new PessoaService();

pessoaService.Add(new Pessoa(1, "Vitor") );
pessoaService.Add(new Pessoa(2, "Lucas") );

pessoaService.imprimirPessoas();


PessoaService pessoaService2 = new PessoaService();

pessoaService2.Add(new Pessoa(3, "Ana") );
pessoaService2.Add(new Pessoa(4, "Maria") );

pessoaService2.imprimirPessoas();

