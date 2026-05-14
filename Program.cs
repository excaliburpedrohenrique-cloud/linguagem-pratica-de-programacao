Console.WriteLine("Informe seu nome: ");
string nomeUsuario = Console.ReadLine();

Console.WriteLine("Informe a sua idade: ");
int idadeConvertida = int.Parse(Console.ReadLine());

Console.WriteLine("Informe sua altura: ");
double alturaConvertida = double.Parse(Console.ReadLine());

Console.WriteLine("Você possui CNH? insira 'true' para verdadeiro e 'false' para falso");
bool CNH = bool.Parse(Console.ReadLine());



Console.WriteLine("Seu nome é: " + nomeUsuario);
Console.WriteLine("Minha idade é: " + idadeConvertida);
Console.WriteLine("Sua altura é: " + alturaConvertida);
Console.WriteLine("Possui CNH: " + CNH);