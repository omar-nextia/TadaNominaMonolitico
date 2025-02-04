﻿using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TadaNomina.Models.ClassCore.Timbrado;
using TadaNomina.Models.ClassCore.TimbradoTP;
using TadaNomina.Models.ViewModels.CFDI;
using TadaNomina.Services;
using TadaNomina.Services.CFDI40;
using TadaNomina.Services.CFDI40.Models;

namespace TadaNomina.Controllers.CFDI
{
    public class GeneraXMLController : BaseController
    {
        // GET: GeneraXML
        public ActionResult Index(string Mensaje)
        {
            if(Mensaje != null && Mensaje.Length > 0)
                ViewBag.MensajeError = Mensaje;

            int IdUnidadNegocio = (int)Session["sIdUnidadNegocio"];
            ClassTimbradoNomina cperiodo = new ClassTimbradoNomina();
            ModelTimbradoNomina model = cperiodo.GetModeloTimbradoNomina(IdUnidadNegocio);

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ModelTimbradoNomina timbrado)
        {

            int IdUnidadNegocio = (int)Session["sIdUnidadNegocio"];
            ClassTimbradoNomina cperiodo = new ClassTimbradoNomina();
            ModelTimbradoNomina model = cperiodo.GetModeloTimbradoNomina(IdUnidadNegocio);
            model.IdPeriodoNomina = timbrado.IdPeriodoNomina;
            model.tipoTimbrado = timbrado.tipoTimbrado;

            cGeneraXML cgx = new cGeneraXML();
            var cantidad = cgx.getRegistrosXMLPeriodo(timbrado.IdPeriodoNomina).Count();
            model.MensajeContador = "XML que hay actualmente en este periodo : " + cantidad;

            var cantidadRegistrosNomina = cgx.obtenDatosTimbrado(timbrado.IdPeriodoNomina).Count();
            model.RegistrosNomina = "Registros procesados en nómina para este periodo: " + cantidadRegistrosNomina;            

            var cantidadRegistrosTimbrados = cgx.getTimbrados(timbrado.IdPeriodoNomina);
            model.RegistrosYaTimbrados = "Registros ya timbrados para este periodo: " + cantidadRegistrosTimbrados.Count();

            return View(model);            
        }

        public JsonResult GenerarArchivos(int IdPeriodoNomina, string tipoTimbrado, string claves)
        {
            int IdCliente = (int)Session["sIdCliente"];
            int IdUnidadNegocio = (int)Session["sIdUnidadNegocio"];
            int IdUsuario = (int)Session["sIdUsuario"];
            
            try
            {
                if (tipoTimbrado == null || tipoTimbrado == string.Empty) { throw new Exception("Debe Elegir el Uso del XML"); }
                Guid Id = Guid.NewGuid();
                cGeneraXML ct = new cGeneraXML();

                claves = claves.Trim().Replace(" ", "");
                string[] _claves = new string[0];
                if(claves != string.Empty)
                    _claves = claves.ToUpper().Split(',');

                var errores = ct.GeneraXMLTimbradoNomina(IdPeriodoNomina, IdUnidadNegocio, IdCliente, Id, tipoTimbrado, _claves, IdUsuario);
                var cantidad = ct.getRegistrosXMLPeriodo(IdPeriodoNomina).Count();

                return Json(new { estatus = "Ok", mensaje = "Se generaron correctamente los archivos.", cantidad, errores });               
            }
            catch (Exception ex)
            {
                return Json(new { estatus = "error", mensaje = ex.Message });
            }            
        }

        [HttpPost]
        public JsonResult EliminarXML(int IdPeriodoNomina)
        {
            try
            {
                cGeneraXML ct = new cGeneraXML();
               
                ct.deleteRegistrosXMl(IdPeriodoNomina, (int)Session["sIdUsuario"]);
                var cantidad = ct.getRegistrosXMLPeriodo(IdPeriodoNomina).Count();

                return Json(new { estatus = "Ok", mensaje = "Se elimininaron los datos de forma correcta.", cantidad });
            }
            catch (Exception ex)
            {
                return Json(new { estatus = "error", mensaje = ex.Message });
            }            
        }

        public JsonResult getCantiadXML(int IdPeriodoNomina)
        {
            try
            {
                cGeneraXML cgx = new cGeneraXML();
                var cantidad = cgx.getRegistrosXMLPeriodo(IdPeriodoNomina).Count();
                return Json(new { estatus = "Ok", cantidad });
            }
            catch (Exception ex)
            {
                return Json(new { estatus = "Error", mensaje = ex.Message });
            }
        }

        public ActionResult DescargaCFDIPrevio(int IdPeriodoNomina)
        {
            try
            {
                int IdUnidad = (int)Session["sIdUnidadNegocio"];
                cGeneraXML cgx = new cGeneraXML();
                cgx.GetZip(IdPeriodoNomina, IdUnidad);

                byte[] fileBytes = System.IO.File.ReadAllBytes(@"D:\TadaNomina\DescargaCFDINominaPrevio\" + IdPeriodoNomina + ".zip");
                string fileName = IdPeriodoNomina + ".zip";

                return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
                
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", new { Mensaje = "Error al generar los archivos: " + ex.Message });
            }
        }

        public ActionResult DescargaXMLPrevio(int IdPeriodoNomina)
        {
            try
            {
                int IdUnidad = (int)Session["sIdUnidadNegocio"];
                cGeneraXML cgx = new cGeneraXML();
                cgx.GetZipXML(IdPeriodoNomina, IdUnidad);

                byte[] fileBytes = System.IO.File.ReadAllBytes(@"D:\TadaNomina\DescargaCFDINominaPrevio\" + IdPeriodoNomina + ".zip");
                string fileName = IdPeriodoNomina + ".zip";

                return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", new { Mensaje = "Error al generar los archivos: " + ex.Message });
            }
        }
    }
}
