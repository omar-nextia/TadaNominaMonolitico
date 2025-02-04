﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TadaNomina.Models.ClassCore;
using TadaNomina.Models.DB;
using TadaNomina.Models.ViewModels.Catalogos;

namespace TadaNomina.Controllers.Administracion
{
    public class ConceptosController : BaseController
    {
        // GET: Conceptos
        /// <summary>
        /// Acción para listar los conceptos.
        /// </summary>
        /// <returns>Regresa la vista con la lista de los conceptos.</returns>
        public ActionResult Index()
        {
            int IdCliente = 0;
            try { IdCliente = (int)Session["sIdCliente"]; } catch { IdCliente = 0; }

            if (IdCliente == 0) { return RedirectToAction("Index", "Default"); }
            else
            {
                ClassConceptos ccon = new ClassConceptos();
                List<vConceptos> lconceptos = ccon.GetvConceptos(IdCliente).OrderBy(x => x.Concepto).ToList();

                return View(lconceptos);
            }
        }

        // GET: Conceptos/Details/5
        /// <summary>
        /// Acción que muestra un concepto específico.
        /// </summary>
        /// <param name="id">Recibe el identificador del concepto.</param>
        /// <returns>Regresa la vista con el concepto específico.</returns>
        public ActionResult Details(int id)
        {
            ClassConceptos cconceptos = new ClassConceptos();
            ModelConceptos model = cconceptos.GetModelConcepto(id);
            return PartialView("Details", model);
        }

        // GET: Conceptos/Create
        /// <summary>
        /// Acción que agrega un concepto nuevo.
        /// </summary>
        /// <returns>Regresa la vista con el modelo de conceptos.</returns>
        public ActionResult Create()
        {
            int IdCliente = (int)Session["sIdCliente"];
            
            ClassConceptos conceptos = new ClassConceptos();
            ModelConceptos modConcpetos = conceptos.LlenaListasConcpetos(IdCliente);

            return View(modConcpetos);
        }

        // POST: Conceptos/Create
        /// <summary>
        /// Acción que guarda el concepto nuevo.
        /// </summary>
        /// <param name="collection">Recibe el modelo de conceptos.</param>
        /// <returns>Regresa la vista con la lista de los conceptos.</returns>
        [HttpPost]
        public ActionResult Create(ModelConceptos collection)
        {
            int IdCliente = (int)Session["sIdCliente"];
            collection.mensaje = string.Empty;
            ClassConceptos cconceptos = new ClassConceptos();            
            try
            {                
                if (ModelState.IsValid)
                {                    
                    int IdUsuario = (int)Session["sIdUsuario"];

                    if (collection.Formula != null)
                        collection.Formula = collection.Formula.Trim();

                    cconceptos.AddConcepto(collection, IdCliente, IdUsuario);
                    return Json(1, JsonRequestBehavior.AllowGet);
                }                
            }
            catch(Exception ex)
            {
                collection = cconceptos.LlenaListasConcpetos(IdCliente);
                collection.mensaje = ex.Message;
            }

            
            return View(collection);
        }

        // GET: Conceptos/Edit/5
        /// <summary>
        /// Acción que modifica un concepto específico.
        /// </summary>
        /// <param name="id">Recibe el identificador del concepto.</param>
        /// <returns>Regresa la vista con el modelo de conceptos.</returns>
        public ActionResult Edit(int id)
        {
            ClassConceptos cconceptos = new ClassConceptos();
            ModelConceptos model = cconceptos.GetModelConcepto(id);
            ModelConceptos _model = cconceptos.LlenaListasConcpetos(model);
            
            return View(_model);
        }

        // POST: Conceptos/Edit/5
        /// <summary>
        /// Acción que guarda el cambio de un concepto específico.
        /// </summary>
        /// <param name="id">Recibe el identificador de concepto.</param>
        /// <param name="collection">Recibe el modelo de conceptos.</param>
        /// <returns>Regresa la vista con la lista de conceptos.</returns>
        [HttpPost]
        public ActionResult Edit(int id, ModelConceptos collection)
        {
            try
            {
                ClassConceptos cconceptos = new ClassConceptos();
                int IdUsuario = (int)Session["sIdUsuario"];
                collection.IdCliente = (int)Session["sIdCliente"];
                           
                if(collection.Formula != null)
                    collection.Formula = collection.Formula.Trim();

                cconceptos.UpdateConcepto(collection, IdUsuario);

                return Json(1, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return View();
            }
        }

        // GET: Conceptos/Delete/5
        /// <summary>
        /// Acción para eliminar un concepto.
        /// </summary>
        /// <param name="id">Recibe el identificador del concepto.</param>
        /// <returns>Regresa una vista parcial para eliminar el concepto.</returns>
        public ActionResult Delete(int id)
        {
            ClassConceptos cconceptos = new ClassConceptos();
            ModelConceptos model = cconceptos.GetModelConcepto(id);
            return PartialView("Delete", model);
        }

        // POST: Conceptos/Delete/5
        /// <summary>
        /// Acción que confirma la eliminación del concepto.
        /// </summary>
        /// <param name="id">Recibe el identificador del concepto.</param>
        /// <param name="collection">Contiene los proveedores de valor de formulario para la aplicación.</param>
        /// <returns>Regresa la vista con la lista de los conceptos.</returns>
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                int IdUsuario = (int)Session["sIdUsuario"];
                ClassConceptos cc = new ClassConceptos();
                cc.deleteConcepto(id, IdUsuario);
            }
            catch
            {

            }

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Acción que agrega un concepto existente a la nómina.
        /// </summary>
        /// <param name="id">Recibe el identificador del concepto.</param>
        /// <returns>Regresa una vista con la lista de los conceptos existentes.</returns>
        public ActionResult AgregarExistente(int? id)
        {
            ClassConceptos ccon = new ClassConceptos();
            int IdCliente = (int)Session["sIdCliente"];
            int IdUsuario = (int)Session["sIdUsuario"];
            if (id != null)
            {
                ccon.AgregaExistente((int)id, IdCliente, IdUsuario);
            }

            List<vConceptos> lconceptos = ccon.GetvConceptos(0).OrderBy(x => x.Concepto).ToList();

            return View(lconceptos);
        }

        public JsonResult getPalabrasReservadas()
        {
            try
            {
                ClassConceptos cc = new ClassConceptos();
                var conceptos = cc.getConceptosFormulacion((int)Session["sIdCliente"]);
                return Json(conceptos);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        public ActionResult TablaFactores(int IdConcepto, string NombreConcepto)
        {
            ClassConceptos cc = new ClassConceptos();
            ModelFactores modelFactores = new ModelFactores();
            modelFactores.IdConcepto = IdConcepto;
            modelFactores.NombreConcepto = NombreConcepto;
            modelFactores.lFactores = cc.getFactoresByConcepto(IdConcepto);
            return View(modelFactores);
        }

        [HttpPost]
        public JsonResult guardaFactor(int? IdConcepto, decimal? limInferior, decimal? limSuperior, string tipoDato, decimal? Valor, string fIniVig)
        {
            try
            {
                ClassConceptos cc = new ClassConceptos();
                cc.addFactorConcepto((int)IdConcepto, (decimal)limInferior, (decimal)limSuperior, tipoDato, (decimal)Valor, fIniVig, (int)Session["sIdUsuario"]);
                return Json(new { result = "Ok", mensaje = "Se guardo correctamente el factor para este concepto." });
            }
            catch (Exception ex)
            {
                return Json(new { result = "Error", mensaje = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult getFactor(int IdConceptoFactor)
        {
            try
            {
                ClassConceptos cc = new ClassConceptos();
                var factor = cc.getFactoresByIDFactorConcepto(IdConceptoFactor);
                var fecha = string.Empty;
                fecha = ((DateTime)factor.FechaInicioVigencia).ToShortDateString();
                return Json(new { result = "Ok", factor, fecha });
            }
            catch (Exception ex)
            {
                return Json(new { result = "Error", mensaje = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult editFactor(int IdConceptoFactor, decimal? limInferior, decimal? limSuperior, string tipoDato, decimal? Valor, string fIniVig)
        {
            try
            {
                ClassConceptos cc = new ClassConceptos();
                cc.editFactorConcepto(IdConceptoFactor, (decimal)limInferior, (decimal)limSuperior, tipoDato, (decimal)Valor, fIniVig, (int)Session["sIdUsuario"]);
                
                return Json(new { result = "Ok", mensaje = "Se actualizo correctamente la informacion del factor." });
            }
            catch (Exception ex)
            {
                return Json(new { result = "Error", mensaje = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult deleteFactor(int IdConceptoFactor)
        {
            try
            {
                ClassConceptos cc = new ClassConceptos();
                cc.deleteFactorConcepto(IdConceptoFactor, (int)Session["sIdUsuario"]);

                return Json(new { result = "Ok", mensaje = "Se elimino correctamente la informacion del factor." });
            }
            catch (Exception ex)
            {
                return Json(new { result = "Error", mensaje = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult CargaCatalogoSAT(string tipo)
        {
            try
            {
                ClassConceptos cc = new ClassConceptos();
                var catalogo = cc.getCatalogoSAT(tipo);
                return Json(new { result = "Ok", catalogo });
            }
            catch (Exception ex)
            {

                return Json(new { result = "Error", mensaje = ex.Message });
            }
        }
    }
}
