﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TadaNomina.Models.DB;
using TadaNomina.Models.ViewModels.Catalogos;

namespace TadaNomina.Models.ClassCore
{
    /// <summary>
    /// Conceptos de Nomina
    /// Autor: Diego Rodríguez
    /// Fecha Ultima Modificación: 17/05/2022, Razón: Documentación del código
    /// </summary>
	public class ClassConceptos
	{
        /// <summary>
        /// Método para obtener los conceptos de nómina activos
        /// </summary>
        /// <returns>Listado de los conceptos activos</returns>
        public List<Cat_ConceptosNomina> GetConceptos()
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = from b in entidad.Cat_ConceptosNomina.Where(x => x.IdEstatus == 1) select b;

                return conceptos.ToList();
            }
        }

        /// <summary>
        /// Método para obtener los conceptos de nómina por cliente
        /// </summary>
        /// <param name="IdCliente">Identificador del Cliente</param>
        /// <returns>Listado de los conceptos de nomina por cliente</returns>
        public List<Cat_ConceptosNomina> GetConceptos(int IdCliente)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = from b in entidad.Cat_ConceptosNomina.Where(x => x.IdEstatus == 1 && x.IdCliente == IdCliente) select b;

                return conceptos.ToList();
            }
        }

        /// <summary>
        /// Método para obtener los Conceptos de nómina por cliente y el tipo de esquema tradicional
        /// </summary>
        /// <param name="IdCliente"> Identificador del Cliente</param>
        /// <returns>Listado de los conceptos de nómina por cliente y tipi de esquema tradicional</returns>
        public List<Cat_ConceptosNomina> GetConceptosTradicional(int IdCliente)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = from b in entidad.Cat_ConceptosNomina.Where(x => x.IdEstatus == 1 && x.IdCliente == IdCliente && x.TipoEsquema == "Tradicional") select b;

                return conceptos.ToList();
            }
        }


        /// <summary>
        /// Método para obtener los conceptos de nómina con información complementaria
        /// </summary>
        /// <returns>Listado de los conceptos de nómina con su información complementaria</returns>
        public List<vConceptos> GetvConceptos()
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = from b in entidad.vConceptos.Where(x => x.IdEstatus == 1) select b;

                return conceptos.ToList();
            }
        }

        /// <summary>
        /// Método para obteneter un concepto con su información complementaria por su identificador
        /// </summary>
        /// <param name="IdConcepto">Identificador del concepto de nómina</param>
        /// <returns>Concepto de nómina con su información complementaria</returns>
        public string GetTipoDato(int IdConcepto)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = (from b in entidad.vConceptos.Where(x => x.IdConcepto == IdConcepto) select b.TipoDato).FirstOrDefault();

                return conceptos;
            }
        }

        /// <summary>
        /// Método para obtener los conceptos de nómina con su información complementaria por cliente 
        /// </summary>
        /// <param name="IdCliente">Identificador del Cliente</param>
        /// <returns>Listado de los conceptos de nómina con su información complementaria por cliente </returns>
        public List<vConceptos> GetvConceptos(int IdCliente)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = from b in entidad.vConceptos.Where(x => x.IdEstatus == 1 && x.IdCliente == IdCliente) select b;

                return conceptos.ToList();
            }
        }

        /// <summary>
        /// Método para obtener el concepto de nómina con su información complementaria por su identificador 
        /// </summary>
        /// <param name="IdConcepto">Identificador del concepto de nómina</param>
        /// <returns>Concepto de nómina con su información complementaria</returns>
        public vConceptos GetvConcepto(int IdConcepto)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = entidad.vConceptos.Where(x => x.IdConcepto == IdConcepto).FirstOrDefault();

                return conceptos;
            }
        }

        public vConceptos GetvConcepto(string ClaveConcepto, int IdCliente)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = (from b in entidad.vConceptos.Where(x => x.IdCliente == IdCliente && x.ClaveConcepto == ClaveConcepto && x.IdEstatus == 1) select b).FirstOrDefault();

                return conceptos;
            }
        }

        /// <summary>
        /// Método para llenar un modelo con la información del concepto de nómina
        /// </summary>
        /// <param name="IdConcepto">Identificador del concepto de nómina</param>
        /// <returns>Clase de tipo ModelConcpto con la información del concepto de nómina</returns>
        public ModelConceptos GetModelConcepto(int IdConcepto)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = (from b in entidad.vConceptos.Where(x => x.IdConcepto == IdConcepto) select b).FirstOrDefault();
                ModelConceptos modelConceptos = new ModelConceptos() {
                    IdConcepto = conceptos.IdConcepto,
                    IdCliente = (int)conceptos.IdCliente,
                    Cliente = conceptos.Cliente,
                    ClaveGpo = conceptos.ClaveGpo,
                    ClaveConcepto = conceptos.ClaveConcepto,
                    ClaveSAT = conceptos.ClaveSAT,
                    Concepto = conceptos.Concepto,
                    Informacion = conceptos.Informacion,
                    TipoConcepto = conceptos.TipoConcepto,
                    TipoDato = conceptos.TipoDato,
                    TipoEsquema = conceptos.TipoEsquema,
                    CalculaMontos = conceptos.CalculaMontos,
                    SDPor = (decimal)conceptos.SDPor,
                    SDEntre = (decimal)conceptos.SDEntre,                     
                    AfectaSueldo = conceptos.AfectaSeldo,
                    Integrable = conceptos.Integrable,
                    IntegraSDI = conceptos.IntegraSDI,
                    Exenta = conceptos.Exenta,
                    UnidadExenta = conceptos.UnidadExenta,
                    CantidadExenta = (decimal)conceptos.CantidadExenta,
                    PorcentajeGravado = (decimal)conceptos.PorcentajeGravado,
                    sumaNetoFinal = conceptos.SumaNetoFinal,
                    MultiplicacDiasTrabajados = conceptos.MultiplicaDT,
                    ExcentaPorUnidad = conceptos.ExentaPorUnidad,
                };

                return modelConceptos;
            }
        }

        /// <summary>
        /// Método para crear un nuevo concepto de nómina, usando un concepto de nómina base ya existente pero ligandolo a un cliente
        /// </summary>
        /// <param name="IdConcepto">Identificadoer del concepto de nómina</param>
        /// <param name="IdCliente">Identificador del cliente</param>
        /// <param name="IdUsuario">Identificador del usuario</param>
        public void AgregaExistente(int IdConcepto, int IdCliente, int IdUsuario)
        {
            if (!ValidaExistente(IdCliente, IdConcepto))
            {
                AddExistente(IdConcepto, IdCliente, IdUsuario);
            }
        }

        /// <summary>
        /// Método para validar si el concepto de nómina que se desea agregar ya existe
        /// </summary>
        /// <param name="IdCliente">Identificador de cliente</param>
        /// <param name="IdExistente">Identifocador del concepto</param>
        /// <returns>true/false si existe el concepto de nómina o no</returns>
        public bool ValidaExistente(int IdCliente, int IdExistente)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = (from b in entidad.Cat_ConceptosNomina.Where(x => x.IdCliente == IdCliente && x.IdConceptoSistema == IdExistente && x.IdEstatus == 1) select b).FirstOrDefault();

                if (conceptos != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Método para insertar en la base de datos el nuevo concepto de nómina ligado al cliente
        /// </summary>
        /// <param name="IdConcepto">Identificador del concepto de nómina</param>
        /// <param name="IdCliente">Identificador del cliente</param>
        /// <param name="IdUsuario">Identificador del usuario</param>
        public void AddExistente(int IdConcepto, int IdCliente, int IdUsuario)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var conceptos = (from b in entidad.Cat_ConceptosNomina.Where(x => x.IdConcepto == IdConcepto) select b).FirstOrDefault();

                if (conceptos != null)
                {
                    Cat_ConceptosNomina nuevoConcepto = conceptos;
                    nuevoConcepto.IdCliente = IdCliente;
                    nuevoConcepto.IdConceptoSistema = conceptos.IdConcepto;
                    nuevoConcepto.IdCaptura = IdUsuario;
                    nuevoConcepto.FechaCaptura = DateTime.Now;

                    entidad.Cat_ConceptosNomina.Add(nuevoConcepto);
                    entidad.SaveChanges();
                }
            }
        }
        
        /// <summary>
        /// Método para agregar un concepto base
        /// </summary>
        /// <param name="modelConcepto">Objeto de tipo ModelConcepto</param>
        /// <param name="IdCliente">Identificador cliente</param>
        /// <param name="IdUsuario">Identificador usuario</param>
        public void AddConcepto(ModelConceptos modelConcepto, int IdCliente, int IdUsuario)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                Cat_ConceptosNomina concepto = new Cat_ConceptosNomina()
                {
                    IdCliente = IdCliente,
                    ClaveGpo = modelConcepto.ClaveGpo,
                    ClaveConcepto = modelConcepto.ClaveConcepto,
                    ClaveSAT = modelConcepto.ClaveSAT,
                    Concepto = modelConcepto.Concepto,
                    Informacion = modelConcepto.Informacion,
                    TipoConcepto = modelConcepto.TipoConcepto,
                    TipoDato = modelConcepto.TipoDato,
                    TipoEsquema = modelConcepto.TipoEsquema,
                    CalculaMontos = modelConcepto.CalculaMontos,
                    SDPor = modelConcepto.SDPor,
                    SDEntre = modelConcepto.SDEntre,
                    Integrable = modelConcepto.Integrable,
                    IntegraSDI = modelConcepto.IntegraSDI,
                    AfectaSeldo = modelConcepto.AfectaSueldo,
                    AfectaCargaSocial = modelConcepto.AfectaCargaSocial,
                    Exenta = modelConcepto.Exenta,
                    UnidadExenta = modelConcepto.UnidadExenta,
                    CantidadExenta = modelConcepto.CantidadExenta,
                    PorcentajeGravado = modelConcepto.PorcentajeGravado,
                    MultiplicaDT = modelConcepto.MultiplicacDiasTrabajados,
                    IdEstatus = 1,
                    IdCaptura = IdUsuario,
                    FechaCaptura = DateTime.Now,
                    SumaNetoFinal = modelConcepto.sumaNetoFinal,
                    ExentaPorUnidad = modelConcepto.ExcentaPorUnidad
                };

                entidad.Cat_ConceptosNomina.Add(concepto);
                entidad.SaveChanges();
            }
        }

        /// <summary>
        /// Método para actualizar él concepto de nómina
        /// </summary>
        /// <param name="modelConceptos">Objeto de tipo ModelConceptos</param>
        /// <param name="IdUsuario">Identificador usuario</param>
        public void UpdateConcepto(ModelConceptos modelConceptos, int IdUsuario)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var concepto = (from b in entidad.Cat_ConceptosNomina.Where(x => x.IdConcepto == modelConceptos.IdConcepto) select b).FirstOrDefault();

                if (concepto != null)
                {
                    concepto.ClaveGpo = modelConceptos.ClaveGpo;
                    concepto.ClaveConcepto = modelConceptos.ClaveConcepto;
                    concepto.ClaveSAT = modelConceptos.ClaveSAT;
                    concepto.Concepto = modelConceptos.Concepto;
                    concepto.Informacion = modelConceptos.Informacion;
                    concepto.TipoConcepto = modelConceptos.TipoConcepto;
                    concepto.TipoDato = modelConceptos.TipoDato;
                    concepto.TipoEsquema = modelConceptos.TipoEsquema;
                    concepto.CalculaMontos = modelConceptos.CalculaMontos;
                    concepto.SDPor = modelConceptos.SDPor;
                    concepto.SDEntre = modelConceptos.SDEntre;
                    concepto.SDPor = modelConceptos.SDPor;
                    concepto.SDEntre = modelConceptos.SDEntre;                    
                    concepto.Integrable = modelConceptos.Integrable;
                    concepto.IntegraSDI = modelConceptos.IntegraSDI;
                    concepto.AfectaSeldo = modelConceptos.AfectaSueldo;
                    concepto.AfectaCargaSocial = modelConceptos.AfectaCargaSocial;
                    concepto.Exenta = modelConceptos.Exenta;
                    concepto.UnidadExenta = modelConceptos.UnidadExenta;
                    concepto.CantidadExenta = modelConceptos.CantidadExenta;
                    concepto.PorcentajeGravado = modelConceptos.PorcentajeGravado;
                    concepto.IdModifica = IdUsuario;
                    concepto.FechaModifica = DateTime.Now;
                    concepto.SumaNetoFinal = modelConceptos.sumaNetoFinal;
                    concepto.MultiplicaDT = modelConceptos.MultiplicacDiasTrabajados;
                    concepto.ExentaPorUnidad = modelConceptos.ExcentaPorUnidad;
                }

                entidad.SaveChanges();
            }
        }

        /// <summary>
        /// Método para llenar el modelo ModelConceptos con las listas desplegables requeridas para usar el el formulario
        /// </summary>
        /// <returns>Objeto de tipo ModelConceptos</returns>
        public ModelConceptos LlenaListasConcpetos()
        {
            List<SelectListItem> lagrupador = new List<SelectListItem>();
            List<Cat_AgrupadorConceptos> grupo = GetAgrupadorConceptos();
            grupo.ForEach(x=> { lagrupador.Add(new SelectListItem { Text=x.ClaveGpo + " - " + x.Descripcion, Value=x.ClaveGpo }); });

            List<SelectListItem> _tipoConcpto = new List<SelectListItem>();
            _tipoConcpto.Add(new SelectListItem { Text = "Percepcion", Value = "ER" });
            _tipoConcpto.Add(new SelectListItem { Text = "Deduccion", Value = "DD" });
            _tipoConcpto.Add(new SelectListItem { Text = "Informativo", Value = "IF" });            

            List<SelectListItem> _tipoEsquema = new List<SelectListItem>();
            _tipoEsquema.Add(new SelectListItem { Text = "Tradicional", Value = "Tradicional" });
            _tipoEsquema.Add(new SelectListItem { Text = "Esquema", Value = "Esquema" });
            _tipoEsquema.Add(new SelectListItem { Text = "Mixto", Value = "Mixto" });

            List<SelectListItem> _TipoDato = new List<SelectListItem>();
            _TipoDato.Add(new SelectListItem { Text = "Pesos/Monto", Value = "Pesos" });
            _TipoDato.Add(new SelectListItem { Text = "Cantidades", Value = "Cantidades" });
            _TipoDato.Add(new SelectListItem { Text = "Porcentaje", Value = "Porcentaje" });

            List<SelectListItem> _listSINO = new List<SelectListItem>();
            _listSINO.Add(new SelectListItem { Text = "SI", Value = "SI" });
            _listSINO.Add(new SelectListItem { Text = "NO", Value = "NO" });

            List<SelectListItem> _listSINO1 = new List<SelectListItem>();
            _listSINO1.Add(new SelectListItem { Text = "SI", Value = "SI" });
            _listSINO1.Add(new SelectListItem { Text = "NO", Value = "NO" });

            List<SelectListItem> _UnidadExenta = new List<SelectListItem>();
            _UnidadExenta.Add(new SelectListItem { Text = "SMGV", Value = "SMGV" });
            _UnidadExenta.Add(new SelectListItem { Text = "UMA", Value = "UMA" });           

            ModelConceptos modelConceptos = new ModelConceptos();
            modelConceptos.LAgrupador = lagrupador;
            modelConceptos.LTipoConcepto = _tipoConcpto;
            modelConceptos.LTipoDato = _TipoDato;            
            modelConceptos.LTipoEsquema = _tipoEsquema;
            modelConceptos.LIntegra = _listSINO;
            modelConceptos.LIntegraSDI = _listSINO;
            modelConceptos.LAfectaSueldo = _listSINO;
            modelConceptos.LAfectaCargaSocial = _listSINO;
            modelConceptos.LExenta = _listSINO;
            modelConceptos.LUExenta = _UnidadExenta;
            modelConceptos.LCalculaMontos = _listSINO;
            modelConceptos.lSumaNeto = _listSINO;
            modelConceptos.lMultiplicaDiasTrabajados = _listSINO;
            modelConceptos.lExcentaPorUnidad = _listSINO1;

            return modelConceptos;
        }

        /// <summary>
        /// Método para llenar el modelo ModelConceptos con las listas desplegables requeridas para usar el el formulario
        /// </summary>
        /// <param name="modelConceptos">Objeto tipo ModelConceptos</param>
        /// <returns>Objeto de tipo ModelConceptos</returns>
        public ModelConceptos LlenaListasConcpetos(ModelConceptos modelConceptos)
        {
            List<SelectListItem> lagrupador = new List<SelectListItem>();
            List<Cat_AgrupadorConceptos> grupo = GetAgrupadorConceptos();
            grupo.ForEach(x => { lagrupador.Add(new SelectListItem { Text = x.ClaveGpo + " - " + x.Descripcion, Value = x.ClaveGpo }); });

            List<SelectListItem> _tipoConcpto = new List<SelectListItem>();
            _tipoConcpto.Add(new SelectListItem { Text = "Percepcion", Value = "ER" });
            _tipoConcpto.Add(new SelectListItem { Text = "Deduccion", Value = "DD" });
            _tipoConcpto.Add(new SelectListItem { Text = "Informativo", Value = "IF" });

            List<SelectListItem> _tipoEsquema = new List<SelectListItem>();
            _tipoEsquema.Add(new SelectListItem { Text = "Tradicional", Value = "Tradicional" });
            _tipoEsquema.Add(new SelectListItem { Text = "Esquema", Value = "Esquema" });
            _tipoEsquema.Add(new SelectListItem { Text = "Mixto", Value = "Mixto" });

            List<SelectListItem> _TipoDato = new List<SelectListItem>();
            _TipoDato.Add(new SelectListItem { Text = "Pesos/Monto", Value = "Pesos" });
            _TipoDato.Add(new SelectListItem { Text = "Cantidades", Value = "Cantidades" });

            List<SelectListItem> _listSINO = new List<SelectListItem>();
            _listSINO.Add(new SelectListItem { Text = "SI", Value = "SI" });
            _listSINO.Add(new SelectListItem { Text = "NO", Value = "NO" }); 
            
            List<SelectListItem> _listSINO1 = new List<SelectListItem>();
            _listSINO1.Add(new SelectListItem { Text = "SI", Value = "SI" });
            _listSINO1.Add(new SelectListItem { Text = "NO", Value = "NO" });            

            List<SelectListItem> _UnidadExenta = new List<SelectListItem>();
            _UnidadExenta.Add(new SelectListItem { Text = "SMGV", Value = "SMGV" });
            _UnidadExenta.Add(new SelectListItem { Text = "UMA", Value = "UMA" });

            modelConceptos.LAgrupador = lagrupador;
            modelConceptos.LTipoConcepto = _tipoConcpto;
            modelConceptos.LTipoDato = _TipoDato;            
            modelConceptos.LIntegra = _listSINO;
            modelConceptos.LIntegraSDI = _listSINO;
            modelConceptos.LAfectaSueldo = _listSINO;
            modelConceptos.LAfectaCargaSocial = _listSINO;
            modelConceptos.LExenta = _listSINO;
            modelConceptos.LUExenta = _UnidadExenta;
            modelConceptos.LCalculaMontos = _listSINO;
            modelConceptos.LTipoEsquema = _tipoEsquema;
            modelConceptos.lSumaNeto = _listSINO;
            modelConceptos.lMultiplicaDiasTrabajados = _listSINO;
            modelConceptos.lExcentaPorUnidad = _listSINO1;

            return modelConceptos;
        }

        /// <summary>
        /// Método para ontener un listado del catalogo de agrupadores de conceptos
        /// </summary>
        /// <returns>Listado con los Agrupadores de conceptos activos</returns>
        public List<Cat_AgrupadorConceptos> GetAgrupadorConceptos()
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var agrupadores = from b in entidad.Cat_AgrupadorConceptos.Where(x => x.IdEstatus == 1) select b;

                return agrupadores.ToList();
            }
        }

        /// <summary>
        /// Método para cambiar el estatus del concepto de nómina a inactivo 
        /// </summary>
        /// <param name="Id">Identificador del concepto</param>
        /// <param name="IdUsuario">Identificador del usuario</param>
        public void deleteConcepto(int Id, int IdUsuario)
        {
            using (TadaNominaEntities entidad = new TadaNominaEntities())
            {
                var concepto = (from b in entidad.Cat_ConceptosNomina.Where(x => x.IdConcepto == Id) select b).FirstOrDefault();

                if (concepto != null)
                {
                    concepto.IdEstatus = 2;
                    concepto.IdModifica = IdUsuario;
                    concepto.FechaModifica = DateTime.Now;

                    entidad.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Método para obtener una lista de tipo SelectListItem de los conceptos de nómina por cliente
        /// </summary>
        /// <param name="IdCliente">Identificador del cliente</param>
        /// <returns>Lista de tipo SelectListItem de los conceptos de nómina por cliente</returns>
        public List<SelectListItem> getSelectConceptos(int IdCliente)
        {
            var conceptos = GetConceptos(IdCliente).OrderBy(x=> x.Concepto).ToList();
            var list = new List<SelectListItem>();

            conceptos.ForEach(x=> { list.Add(new SelectListItem { Text = x.ClaveConcepto + " - " + x.Concepto, Value = x.IdConcepto.ToString() }); });

            return list;
        }

        public List<SelectListItem> getSelectConceptosPiramidables(int IdCliente)
        {
            var conceptos = GetConceptos(IdCliente).Where(x=> x.Piramida == "SI").OrderBy(x => x.Concepto).ToList();
            var list = new List<SelectListItem>();

            conceptos.ForEach(x => { list.Add(new SelectListItem { Text = x.ClaveConcepto + " - " + x.Concepto, Value = x.IdConcepto.ToString() }); });

            return list;
        }

        /// <summary>
        /// Método para obtener una lista de tipo SelectListItem de los conceptos de nómina por su identificadores
        /// </summary>
        /// <param name="ids">Array de los identificadores de los conceptos de nómina</param>
        /// <param name="IdCliente">Identificador del cliente</param>
        /// <returns>Lista de tipo SelectListItem de los conceptos de nómina por sus identificadores</returns>
        public List<SelectListItem> getSelectConceptosIds(int?[] ids, int IdCliente)
        {
            var list = new List<SelectListItem>();
            if (ids != null)
            {
                var conceptos = GetConceptos(IdCliente).Where(x => ids.Contains(x.IdConcepto)).OrderBy(x => x.Concepto).ToList();                
                conceptos.ForEach(x => { list.Add(new SelectListItem { Text = x.ClaveConcepto + " - " + x.Concepto, Value = x.IdConcepto.ToString() }); });
            }

            return list;
        }
    }
}