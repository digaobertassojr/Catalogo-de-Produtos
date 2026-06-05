using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CatalogoProdutos.Models;

namespace CatalogoProdutos.Controllers;

 ViewBag.Nomes = new List<string>
        {
            "Caneta BIC", "Fone Bluetooth", "Notebook Dell",
            "Mouse Gamer", "Teclado Mecânico", "Monitor 24\"",
            "Pendrive 64GB", "Webcam HD"
        };

        ViewBag.Precos = new List<double>
        {
            3.50, 89.90, 3499.00,
            249.90, 450.00, 899.00,
            49.90, 179.90
        };

        // Estoque
        ViewBag.Estoques = new List<int>
        {
            200, 45, 3,
            0, 8, 15,
            120, 0
        };

        return View();
    }
}
