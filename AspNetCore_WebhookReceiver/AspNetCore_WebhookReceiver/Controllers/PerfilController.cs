using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dominio.Models;
using Dominio.Interfaces;
using Servico.Services;

namespace AspNetCore_WebhookReceiver.Controllers
{
    public class PerfilController : Controller
    {
        private IBaseService<Webhook_perfil> _basePerfilService;
        public PerfilController(IBaseService<Webhook_perfil> basePerfilService)
        {
            _basePerfilService = basePerfilService;
        }


        public IActionResult Index()
        {
            IList<Webhook_perfil> listaPerfis = _basePerfilService.GetAll();

            return View();
        }
    }
}
