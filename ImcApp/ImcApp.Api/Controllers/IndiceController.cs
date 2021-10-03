using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ImcApp.Api.Entities;
using ImcApp.Api.Controllers;

namespace ImcApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndiceController : ControllerBase
    {
   [HttpPost]
        public string Resultado( IndiceIMC Datos)
        {    
             double Resultado;
             String mensaje="";
            Resultado = (Datos.Peso / Math.Pow((Datos.Altura/100), 2));

           
            if(Resultado < 18.5)
            {
                 mensaje= "Su peso es inferior a lo normal";
            }
            else
            {
                if(Resultado>= 18.5  && Resultado <=24.9)
                {
                     mensaje="Su peso esta bien";
                }
                else
                {
                    if(Resultado>=25.00 && Resultado <= 29.9)
                    {
                         mensaje="Su Peso esta un poco mas alto de lo normal";
                    }
                    else
                    {
                         mensaje="Tienes sobre peso";
                    }
                }
                
            }
          return"Tu imc: "+ Convert.ToString(Resultado)+"Tu peso es:"+ mensaje;
           
        
        }

    }
    
}
 /* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 2, Ejercicio 1: iIMC
    Nombre del alumno: Erika Guadalupe Bojon Martinez 
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */