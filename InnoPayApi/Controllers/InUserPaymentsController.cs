using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InnoPayApi.Models;
using InnoPayApi.Repositories.Payment;
using InnoPayApi.Repositories.Interfaces;
using Innovator.Server;

namespace InnoPayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InUserPaymentsController
    {
        private IRepositoryWrapper _repository;

        public InUserPaymentsController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }
        [HttpPost("GetOrgPayments")]
        public async Task<ActionResult<List<InUserPayment>>> GetOrgPayments(string org_name)
        {
            var orgPayments = _repository.Payments.GetOrgPayment(org_name).ToList();
            return orgPayments;
        }

       
    }
}
