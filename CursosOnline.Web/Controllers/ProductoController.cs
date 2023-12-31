﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CursosOnline.Web.Models.Responses;
using CursosOnline.Web.Models.Requests;
using CursosOnline.Web.ApiServices.Interfaces;
using static System.Net.WebRequestMethods;

namespace CursosOnline.Web.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductApiService productApiService;
        private readonly IConfiguration configuration;
        private readonly ILogger<ProductoController> logger;
        private HttpClientHandler clientHandler = new HttpClientHandler();
        public ProductoController(IProductApiService productApiService,
                                  IConfiguration configuration,
                                  ILogger<ProductoController> logger)
        {
            this.productApiService = productApiService;
            this.configuration = configuration;
            this.logger = logger;
        }

        // GET: ProductoController
        public async Task<ActionResult> Index()
        {
            ProductoListResponse productoList = new ProductoListResponse();
            try
            {
                productoList = await this.productApiService.GetProductos();
            }
            catch (Exception ex)
            {
                this.logger.Log(LogLevel.Error, ex.ToString());
            }
            return View(productoList.data);
        }

        // GET: ProductoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ProductoGetResponse productoGet = new ProductoGetResponse();
            try
            {
                productoGet = await this.productApiService.GetProducto(id);
            }
            catch (Exception ex)
            {
                this.logger.Log(LogLevel.Error, ex.ToString());
            }
            return View(productoGet.data);
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductSaveRequest productSave)
        {
            try
            {

                var result = await this.productApiService.SaveProducto(productSave);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var productoGet = await this.productApiService.GetProducto(id);
            ProductSaveRequest productSave = new ProductSaveRequest()
            {
                codigoBarra = productoGet.data.codigoBarra,
                descripcion = productoGet.data.descripcion,
                idCategoria = productoGet.data.idCategoria,
                marca = productoGet.data.marca,
                nombreImagen = productoGet.data.nombreImagen,
                precio = productoGet.data.precio,
                stock = productoGet.data.stock,
                urlImagen = productoGet.data.urlImagen,
                productoId = productoGet.data.productoId

            };
            return View(productSave);
        }
        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProductSaveRequest productSave)
        {
            try
            {
                await this.productApiService.UpdateProducto(productSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
