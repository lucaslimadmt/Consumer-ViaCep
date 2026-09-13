using static System.Console;

WriteLine("Digite o seu CEP: ");
var cep = ReadLine();

var enderecoUrl = $@"https://viacep.com.br/ws/{cep}/json/";

WriteLine($"Realizando requisição para o endpoint: {enderecoUrl}");

var client = new HttpClient();

try
{
    HttpResponseMessage? response = await client.GetAsync(enderecoUrl);
    response.EnsureSuccessStatusCode();

    string respostaApi = await response.Content.ReadAsStringAsync();

    WriteLine(respostaApi);
}
catch (System.Exception e)
{
    WriteLine("Aconteceu um erro ao consultar a api: " + e.Message);
}