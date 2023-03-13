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

string[] campos = new string[textoSTRING.Length];
var primeiralinha = textoSTRING.Split(",");

int p = 0;
foreach (var item in primeiralinha)
{
    var nomes = item.Split('"');
    campos.SetValue(nomes[1], p);
    p++;
}

Console.WriteLine(campos[0]);
Console.WriteLine(campos[1]);
Console.WriteLine(campos[2]);
Console.WriteLine(campos[3]);

Console.Write("\n");

// 6. Como construir meu CSV?

// a. Construir primeiro o cabeçalho do CSV

string[] textoCSV = new string[campos.Length];


foreach (var item in campos)
{
    if (item != null)
    {
        textoCSV[0] += "\"" + item + "\",";
    }
}

Console.WriteLine(textoCSV[0]);
Console.WriteLine(textoCSV[1]);
Console.WriteLine(textoCSV[2]);
Console.WriteLine(textoCSV[3]);