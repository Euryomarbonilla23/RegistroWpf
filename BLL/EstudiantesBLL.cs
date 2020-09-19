using System;
using System.Linq;
using System.Linq.Expressions;
using Registro.DAL;
using Registro.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Registro.BLL{

    public class EstudiantesBLL{
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
              
                var Estudiante = contexto.Estudiantes.Find(id);
                if (Estudiante != null)
                {
                    contexto.Estudiantes.Remove(Estudiante);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static Estudiantes Buscar(int Id)
        {
            Contexto contexto = new Contexto();
            Estudiantes Estudiante;

            try
            {
                Estudiante = contexto.Estudiantes.Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
            contexto.Dispose();
            return Estudiante;


        }
        public static bool Guardar(Estudiantes Estudiante)
        {
            if (!Existe(Estudiante.EstudianteId))
                return Insertar(Estudiante);
            else
                return Modificar(Estudiante);
        }
        public static bool Modificar(Estudiantes Estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Estudiante).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Insertar(Estudiantes Estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
              
                contexto.Estudiantes.Add(Estudiante);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }


       
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Estudiantes
                .Any(e => e.EstudianteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado; 
        }
    }
}
