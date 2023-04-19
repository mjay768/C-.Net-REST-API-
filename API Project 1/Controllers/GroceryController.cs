using System;
using Microsoft.AspNetCore.Mvc;
using API_Project_1.Models;
using API_Project_1.Controllers;
using API_Project_1.Services;
namespace API_Project_1.Controllers;

[ApiController]
[Route("[controller]")]
public class GroceryController : ControllerBase
{
    public GroceryController()
    {
    }

    [HttpGet]
    public ActionResult<List<Grocery>> GetAll() =>
        GroceryService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Grocery> Get(int id)
    {
        var grocery = GroceryService.Get(id);
        if (grocery == null)
            return NotFound();

        return grocery;
    }

}






