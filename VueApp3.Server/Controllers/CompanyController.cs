using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace VueApp1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public CompanyController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet(Name = "GetCompany")]
        public ActionResult<IEnumerable<CompanyData>> Get([FromQuery] string companyCode = null)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            using var connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CompanyData";
            if (!string.IsNullOrEmpty(companyCode))
            {
                query += " WHERE CompanyCode = @CompanyCode";
                var companies = connection.Query<CompanyData>(query, new { CompanyCode = companyCode });
                return Ok(companies);
            }
            else
            {
                var companies = connection.Query<CompanyData>(query);
                return Ok(companies);
            }
        }
    }
}
