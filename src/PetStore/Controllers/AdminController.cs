using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class AdminController : Controller
    {
        private IPetRepository repository;

        public AdminController(IPetRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Customer);  //Index is what the view is called I think
    }
}// I am a cute little coment
