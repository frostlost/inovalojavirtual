﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Inova.LojaVirtual.Dominio.Repositorio;

namespace Inova.LojaVirtual.Web.Controllers
{

    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 8;
        //
        // GET: /Vitrine/
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos
            .OrderBy(p => p.Descricao)
            .Skip((pagina - 1) * ProdutosPorPagina)
            .Take(ProdutosPorPagina);

            return View(produtos);

        }
    }
}