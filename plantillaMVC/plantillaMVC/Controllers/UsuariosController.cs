using AutoMapper;
using plantillaMVC.BLL;
using plantillaMVC.Models;
using plantillaMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace plantillaMVC.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        private readonly IMapper _mapper;
        public UsuariosController()
        {
            
        }
        public UsuariosController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: Usuarios
        public JsonResult Index()
        {
            var usuarios = _mapper.Map<IEnumerable<Usuario>, List<UsuarioViewModel>>(usuarioBLL.GetAll());
            return Json(new { data = usuarios }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AgregarUsuario(UsuarioViewModel usuarioVm)
        {       
            
            var usuarios = usuarioBLL.Insert(_mapper.Map<UsuarioViewModel, Usuario>(usuarioVm));
            return Json(usuarios, JsonRequestBehavior.AllowGet);    
        }
        [HttpPost]
        public JsonResult ModificarUsuario(UsuarioViewModel usuarioVm)
        {
           
            var usuarios = usuarioBLL.Update(_mapper.Map<UsuarioViewModel, Usuario>(usuarioVm));
            return Json(usuarios, JsonRequestBehavior.AllowGet);
        }
    }
}