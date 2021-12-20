using Dapper;
using IPhoneRepairAPI.Models;
using IPhoneRepairAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace IPhoneRepairAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IDapper _dapper;
        public ContactController(IDapper dapper)
        {
            _dapper = dapper;
        }
        [HttpPost(nameof(Create))]
        public async Task<int> Create(Quote_Contact data)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("Name", data.Name);
            dbparams.Add("Phone", data.Phone);
            dbparams.Add("Email", data.Email);
            dbparams.Add("Query", data.Query);
            dbparams.Add("Location", data.Location);
            dbparams.Add("Repair_type", data.Repair_type);
            dbparams.Add("QueryType", data.QueryType);
            var result = await Task.FromResult(_dapper.Insert<int>("[dbo].[AddContact]"
                , dbparams,
                commandType: CommandType.StoredProcedure));
            return result;
        }

        [HttpGet(nameof(GetALL))]
        public async Task <IEnumerable<Quote_Contact>> GetALL()
        {
            var result = await Task.FromResult(_dapper.GetAll<Quote_Contact>($"Select * from Quote_contact", null, commandType: CommandType.Text));
            return result;
        }

        [HttpGet(nameof(GetById))]
        public async Task<Quote_Contact> GetById(int Id)
        {
            var result = await Task.FromResult(_dapper.Get<Quote_Contact>($"Select * from Quote_contact where Id = {Id}", null, commandType: CommandType.Text));
            return result;
        }
        [HttpDelete(nameof(Delete))]
        public async Task<string> Delete(int Id)
        {
            var result = await Task.FromResult(_dapper.Execute($"Delete from Quote_contact Where Id = {Id}", null, commandType: CommandType.Text));
            return "Deleted";
        }
        [HttpGet(nameof(Count))]
        public Task<int> Count(int num)
        {
            var totalcount = Task.FromResult(_dapper.Get<int>($"select COUNT(*) from Quote_contact WHERE id like '%{num}%'", null,
                    commandType: CommandType.Text));
            return totalcount;
        }
        [HttpPatch(nameof(Update))]
        public Task<int> Update(Quote_Contact data)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("id", data.Id);
            dbPara.Add("Name", data.Name);
            dbPara.Add("Phone", data.Phone);
            dbPara.Add("Email", data.Email);
            dbPara.Add("Query", data.Query);
            dbPara.Add("Location", data.Location);
            dbPara.Add("Repair_type", data.Repair_type);
            dbPara.Add("QueryType", data.QueryType);
            var updateArticle = Task.FromResult(_dapper.Update<int>("[dbo].[UpdateContactDetails]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }
    }
}

