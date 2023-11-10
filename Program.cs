using System.Globalization;
using System.Linq.Expressions;

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

internal class Program
{
    private static void Main(string[] args)
    {
        decimal valorMonetario = 82.40M;

        Console.WriteLine(valorMonetario);

        Console.WriteLine($"{valorMonetario:C}");


        //não esqueça do "M"
        valorMonetario = 1582.48M;

        Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

        //Representa QTDE de casas decimais
        valorMonetario = 7821.94321M;

        //Representa em REAL
        Console.WriteLine($"{valorMonetario:C}");

        //Representa QTDE de casas decimais
        Console.WriteLine(valorMonetario.ToString("C1"));
        Console.WriteLine(valorMonetario.ToString("C2"));
        Console.WriteLine(valorMonetario.ToString("C3"));
        Console.WriteLine(valorMonetario.ToString("C4"));
        Console.WriteLine(valorMonetario.ToString("C5"));

        //Representa Numericamente
        Console.WriteLine(valorMonetario.ToString("N1"));
        Console.WriteLine(valorMonetario.ToString("N2"));
        Console.WriteLine(valorMonetario.ToString("N3"));
        Console.WriteLine(valorMonetario.ToString("N4"));
        Console.WriteLine(valorMonetario.ToString("N5"));


        //Tratando Porcentagem - resultado 34,22% "Atenção: Faz Arredondamento"
        double porcentagem = .342156;

        Console.WriteLine(porcentagem.ToString("P"));

        long telefone = 991433242;
        Console.WriteLine(telefone.ToString("#-####-####"));

        long cpf = 15682932838;
        Console.WriteLine(cpf.ToString("XXX.XXX.XXX-XX"));

        long cnpj = 14218414000138;
        Console.WriteLine(cnpj.ToString("##-###-###-####-##"));

        int senha = 123456;
        Console.WriteLine(senha.ToString("##-##-##"));

        string numCpf = cpf.ToString();

        Console.WriteLine($"Tamanho: {numCpf.Length}");

        FormatCPF(numCpf);

        static string FormatCPF(string numCpf)
        {
            string response = numCpf.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(9, "-");
                response = response.Insert(6, ".");
                response = response.Insert(3, ".");
            }
            Console.WriteLine(response);
            return response;
        }
    }
}