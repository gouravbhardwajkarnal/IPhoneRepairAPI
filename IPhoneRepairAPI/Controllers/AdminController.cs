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
    public class AdminController : ControllerBase
    {
        private readonly IDapper _dapper;

        public AdminController(IDapper dapper)
        {
            _dapper = dapper;
        }

        [HttpPost(nameof(Create))]
        public async Task<int> Create(CompanyMenu data)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("MenuName", data.MenuName);
            dbparams.Add("Url", data.MenuUrl);
            dbparams.Add("UserName", "");
            var result = await Task.FromResult(_dapper.Insert<int>("[dbo].[AddCompanyMenu]"
                , dbparams,
                commandType: CommandType.StoredProcedure));
            return result;
        }

        [HttpGet(nameof(GetALL))]
        public async Task<IEnumerable<CompanyMenu>> GetALL()
        {
            var result = await Task.FromResult(_dapper.GetAll<CompanyMenu>($"Select * from CompanyMenu", null, commandType: CommandType.Text));
            return result;
        }

        [HttpGet(nameof(GetById))]
        public async Task<CompanyMenu> GetById(int Id)
        {
            var result = await Task.FromResult(_dapper.Get<CompanyMenu>($"Select * from CompanyMenu where autoid = {Id}", null, commandType: CommandType.Text));
            return result;
        }
        [HttpPost(nameof(Delete))]
        public async Task<string> Delete(int Id)
        {
            var result = await Task.FromResult(_dapper.Execute($"Delete from CompanyMenu Where autoid = {Id}", null, commandType: CommandType.Text));
            return "Deleted";
        }
        
        [HttpPost(nameof(Update))]
        public Task<int> Update(CompanyMenu data)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Autoid", data.AutoId);
            dbPara.Add("MenuName", data.MenuName);
            dbPara.Add("Url", data.MenuUrl);
            dbPara.Add("UserName", "");
            var updateArticle = Task.FromResult(_dapper.Update<int>("[dbo].[UpdateCompanyMenu]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }

        [HttpPost(nameof(CreateSubMenu))]
        public async Task<int> CreateSubMenu(SubMenuList data)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("MenuName", data.MenuName);
            dbparams.Add("SubMenu", data.SubMenu);
            dbparams.Add("Url", data.MenuUrl);
            dbparams.Add("UserName", "");
            var result = await Task.FromResult(_dapper.Insert<int>("[dbo].[AddSubMenu]"
                , dbparams,
                commandType: CommandType.StoredProcedure));
            return result;
        }

        [HttpGet(nameof(GetALLSubMenu))]
        public async Task<IEnumerable<SubMenuList>> GetALLSubMenu()
        {
            var result = await Task.FromResult(_dapper.GetAll<SubMenuList>($"Select * from SubMenuTb", null, commandType: CommandType.Text));
            return result;
        }

        [HttpGet(nameof(GetSubMenuById))]
        public async Task<SubMenuList> GetSubMenuById(int Id)
        {
            var result = await Task.FromResult(_dapper.Get<SubMenuList>($"Select * from SubMenuTb where autoid = {Id}", null, commandType: CommandType.Text));
            return result;
        }
        [HttpPost(nameof(DeleteSubMenu))]
        public async Task<string> DeleteSubMenu(int Id)
        {
            var result = await Task.FromResult(_dapper.Execute($"Delete from SubMenuTb Where autoid = {Id}", null, commandType: CommandType.Text));
            return "Deleted";
        }

        [HttpPost(nameof(UpdateSubMenu))]
        public Task<int> UpdateSubMenu(SubMenuList data)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Autoid", data.AutoId);
            dbPara.Add("MenuName", data.MenuName);
            dbPara.Add("SubMenu", data.SubMenu);
            dbPara.Add("Url", data.MenuUrl);
            dbPara.Add("UserName", "");
            var updateArticle = Task.FromResult(_dapper.Update<int>("[dbo].[UpdateSubMenu]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }

    }
}
