Console.Clear();

// Pedir que seja informado na execução do programa
//var textoJSON = Console.ReadLine();

// 3. Como ler a informação JSON para realizar a manipulação?

var textoJSON = @"{""Vaga"":""Desenvolvedor.NET"",""Empresa"":""Yardim"",""Nivel"":""Junior"",""Site"":""https://www.yardim.com.br/""}";
Console.WriteLine(textoJSON);

// 4. Como manipular cada objeto encontrado do JSON?

var textoSTRING = Convert.ToString(textoJSON).Replace("{", "").Replace("}", "").Replace("\"", "").Trim();
var linha = textoSTRING.Split(",");

foreach (var item in linha)
{
    Console.WriteLine(item);
}