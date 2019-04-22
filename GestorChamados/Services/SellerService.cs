﻿using GestorChamados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestorChamados.Services
{
    public class SellerService
    {
        private readonly GestorChamadosContext _context;

        public SellerService(GestorChamadosContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
