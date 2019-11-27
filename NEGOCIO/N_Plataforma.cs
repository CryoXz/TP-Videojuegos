﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DAO;
using System.Data;


namespace NEGOCIO
{
   public class N_Plataforma
    {
        public DataTable getTabla()
        {
            DaoPlataforma dao = new DaoPlataforma();
            return dao.getTablaPlataformas();
        }

        public Plataforma get(int id)
        {
            DaoPlataforma dao = new DaoPlataforma();
            //Validar si existe esa plataforma
            return dao.getPlataforma(id);
        }

        public bool eliminarPlataforma(int id)
        {
            //Validar id existente 
            DaoPlataforma dao = new DaoPlataforma();
            Plataforma cat = new Plataforma();
            cat.setCodigoPlataforma(id);
            int op = dao.eliminarPlataforma(cat);
            if (op == 1)
                return true;
            else
                return false;
        }
    }
}
