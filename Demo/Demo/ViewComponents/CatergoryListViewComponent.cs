using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.ViewComponents
{
    public class CatergoryListViewComponent : ViewComponent
    {
        private readonly NhanContext _context;

        public CatergoryListViewComponent(NhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> catList = await _context.Categories.ToListAsync();
            return View(catList);
        }
    }
}