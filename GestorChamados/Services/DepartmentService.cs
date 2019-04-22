using GestorChamados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorChamados.Services
{
    public class DepartmentService
    {
        private readonly GestorChamadosContext _context;

        public DepartmentService(GestorChamadosContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();

        }
    }
}
