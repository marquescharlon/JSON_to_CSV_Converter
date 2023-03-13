using System.Collections;

Console.Clear();

// Pedir que seja informado na execução do programa
//var textoJSON = Console.ReadLine();

// 3. Como ler a informação JSON para realizar a manipulação?

Console.WriteLine("3. Como ler a informação JSON para realizar a manipulação?");

var textoJSON = @"{""Vaga"":""Desenvolvedor.NET"",""Empresa"":""Yardim"",""Nivel"":""Junior"",""Site"":""https://www.yardim.com.br/""}";
Console.WriteLine(textoJSON);
Console.Write("\n");

// 4. Como manipular cada objeto encontrado do JSON?

Console.WriteLine("4. Como manipular cada objeto encontrado do JSON?");

var textoSTRING = Convert.ToString(textoJSON).Replace("{", "").Replace("}", "").Trim();
var linha = textoSTRING.Split(",");

foreach (var item in linha)
{
    Console.WriteLine(item);
}

Console.Write("\n");

// 5. Como extrair as Chaves que irão formar o cabeçalho no formato CSV?

Console.WriteLine("5. Como extrair as Chaves que irão formar o cabeçalho no formato CSV?");

ArrayList campos = new ArrayList();
var primeiralinha = textoSTRING.Split(",");

foreach (var item in primeiralinha)
{
    var vagas = item.Split('"');
    campos.Add(vagas[1]);
}

Console.WriteLine(campos[0]);
Console.WriteLine(campos[1]);
Console.WriteLine(campos[2]);
Console.WriteLine(campos[3]);

Console.Write("\n");