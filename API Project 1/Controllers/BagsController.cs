
using System;
using Microsoft.AspNetCore.Mvc;
using API_Project_1.Models;
using API_Project_1.Controllers;
using API_Project_1.Services;
namespace API_Project_1.Controllers;



[ApiController]
[Route("[controller]")]
public class BagsController : ControllerBase
{
    public BagsController()
    {

    }

    [HttpGet]
    public ActionResult<List<Bags>> GetAll() =>
        BagsServices.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Bags> Get(int id)
    {
        var bag = BagsServices.Get(id);
        if (bag == null)
            return NotFound();

        return bag;
    }
}