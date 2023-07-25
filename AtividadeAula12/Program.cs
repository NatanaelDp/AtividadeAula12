
using AtividadeAula12;

Console.WriteLine("Boas-vindas ao Conradito salgados");
Console.WriteLine("A seguir temos 3 opções de salgados");


Produto coxinha = new Produto();
coxinha.nome = "Coxinha";
coxinha.valor =  5.50;
coxinha.quantidade = 10;
coxinha.descricao = "Nossa suculenta coxinha de frango e catupiry é a melhor da região";
coxinha.status = true;

coxinha.mostra();


Produto esfirra = new Produto();

esfirra.nome = "Esfirra";
esfirra.valor = 6.00;
esfirra.quantidade = 10;
esfirra.descricao = "Nossas esfirras feitas de carne moída , tomate e queijo trazer o sabor da pizza em forma de esfirra!";
esfirra.status = true;

esfirra.mostra();

Produto kibe= new Produto();

kibe.nome = "Kibe";
kibe.valor = 7.50;
kibe.quantidade = 10;
kibe.descricao = "O Kibe mais saboroso que você poderia comer na vida !";
kibe.status= true;

kibe.mostra();
coxinha.desativa();
esfirra.desativa();
coxinha.mostra();
esfirra.mostra();



Console.ReadKey();
