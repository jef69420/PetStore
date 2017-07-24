using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class PetController : Controller
    {
        private IPetRepository repository;

        public PetController(IPetRepository repo)
        {
            repository = repo;
        }

        public ViewResult CustomerList() => View(repository.Customer);
    }
}
