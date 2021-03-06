﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashBoatModel.DTO;

namespace TrashBoatModel.DAL
{
    public class ContenedorDAL : IContenedor
    {
        private static List<Contenedor> 
            contenedores = new List<Contenedor>();

        public static ContenedorDAL instance;
        public ContenedorDAL()
        {

        }

        public static ContenedorDAL Instance()
        {
            if (instance == null)
            {
                instance = new ContenedorDAL();
            }
            return instance;
        }

        public void Add(Contenedor contenedor)
        {
            contenedores.Add(contenedor);
        }

        public void Delete(Contenedor contenedor)
        {
            contenedores.Remove(contenedor);
        }

        public List<Contenedor> FindByRegion(string region)
        {
            return contenedores.FindAll(c => c.Region == region);
        }

        public List<Contenedor> GetAll()
        {
            return contenedores;
        }

        public List<Contenedor> GetContenedorById(string contenedor)
        {
            return contenedores.FindAll(c => c.NumeroDeSerie == contenedor);
        }

    }
}
