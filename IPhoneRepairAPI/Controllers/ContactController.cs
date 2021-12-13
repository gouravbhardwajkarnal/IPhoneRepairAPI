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
            dbparams.Add("Id", data.Id, DbType.Int32);
            var result = await Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Add_Article]"
                , dbparams,
                commandType: CommandType.StoredProcedure));
            return result;
        }
        [HttpGet(nameof(GetById))]
        public async Task<Quote_Contact> GetById(int Id)
        {
            var result = await Task.FromResult(_dapper.Get<Quote_Contact>($"Select * from Quote_contact where Id = {Id}", null, commandType: CommandType.Text));
            return result;
        }
        [HttpDelete(nameof(Delete))]
        public async Task<int> Delete(int Id)
        {
            var result = await Task.FromResult(_dapper.Execute($"Delete Quote_contact Where Id = {Id}", null, commandType: CommandType.Text));
            return result;
        }
        [HttpGet(nameof(Count))]
        public Task<int> Count(int num)
        {
            var totalcount = Task.FromResult(_dapper.Get<int>($"select COUNT(*) from Quote_contact WHERE Age like '%{num}%'", null,
                    commandType: CommandType.Text));
            return totalcount;
        }
        [HttpPatch(nameof(Update))]
        public Task<int> Update(Quote_Contact data)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", data.Id);
            dbPara.Add("Name", data.Name, DbType.String);

            var updateArticle = Task.FromResult(_dapper.Update<int>("[dbo].[SP_Update_Article]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }
    }
}

