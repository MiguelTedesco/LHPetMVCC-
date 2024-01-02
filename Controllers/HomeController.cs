using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(1, "João", "123.456.789-10", "teste1@gmail", "teste1");
        Cliente cliente2 = new Cliente(2, "Maria", "123.456.789-10", "teste2@gmail", "teste2");
        Cliente cliente3 = new Cliente(3, "Fernando", "123.456.789-10", "teste3@gmail", "teste3");
        Cliente cliente4 = new Cliente(4, "Cesar", "123.456.789-10", "teste4@gmail", "teste4");
        Cliente cliente5 = new Cliente(5, "Leandro", "123.456.789-10", "teste5@gmail", "teste5");

        List<Cliente> clientes = new List<Cliente>();
        clientes.Add(cliente1);
        clientes.Add(cliente2);
        clientes.Add(cliente3);
        clientes.Add(cliente4);
        clientes.Add(cliente5);

        ViewBag.Clientes = clientes;

        Fornecedor fornecedor1 = new Fornecedor(1, "Fornecedor1", "123.456.789-10", "teste1@gmail");
        Fornecedor fornecedor2 = new Fornecedor(2, "Fornecedor2", "123.456.789-10", "teste2@gmail");
        Fornecedor fornecedor3 = new Fornecedor(3, "Fornecedor3", "123.456.789-10", "teste3@gmail");
        Fornecedor fornecedor4 = new Fornecedor(4, "Fornecedor4", "123.456.789-10", "teste4@gmail");
        Fornecedor fornecedor5 = new Fornecedor(5, "Fornecedor5", "123.456.789-10", "teste5@gmail");

        List<Fornecedor> fornecedores = new List<Fornecedor>();
        fornecedores.Add(fornecedor1);
        fornecedores.Add(fornecedor2);
        fornecedores.Add(fornecedor3);
        fornecedores.Add(fornecedor4);
        fornecedores.Add(fornecedor5);

        ViewBag.Fornecedores = fornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
