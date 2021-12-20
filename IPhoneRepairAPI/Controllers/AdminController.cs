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

        [HttpPost(nameof(AdminDetails))]
        public async Task<string> AdminDetails(AdminList data)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("UserName", data.UserName);
            dbparams.Add("Password", data.Password);
            var result = await Task.FromResult(_dapper.Get<string>("[dbo].[AdminLoginDetails]"
                , dbparams,
                commandType: CommandType.StoredProcedure));
            return result.ToString();

        }

        [HttpPost(nameof(CreateIPad))]
        public async Task<int> CreateIPad(CompanyMenu data)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("MenuName", data.MenuName);
            dbparams.Add("Url", data.MenuUrl);
            dbparams.Add("UserName", "");
            var result = await Task.FromResult(_dapper.Insert<int>("[dbo].[AddIphoneMenu]"
                , dbparams,
                commandType: CommandType.StoredProcedure));
            return result;
        }

        [HttpGet(nameof(GetALLCreateIPad))]
        public async Task<IEnumerable<CompanyMenu>> GetALLCreateIPad()
        {
            var result = await Task.FromResult(_dapper.GetAll<CompanyMenu>($"Select * from IPhoneMenu", null, commandType: CommandType.Text));
            return result;
        }

        [HttpGet(nameof(GetIPadById))]
        public async Task<CompanyMenu> GetIPadById(int Id)
        {
            var result = await Task.FromResult(_dapper.Get<CompanyMenu>($"Select * from IPhoneMenu where autoid = {Id}", null, commandType: CommandType.Text));
            return result;
        }
        [HttpPost(nameof(DeleteIPadMenu))]
        public async Task<string> DeleteIPadMenu(int Id)
        {
            var result = await Task.FromResult(_dapper.Execute($"Delete from IPhoneMenu Where autoid = {Id}", null, commandType: CommandType.Text));
            return "Deleted";
        }

        [HttpPost(nameof(UpdateIPadMenu))]
        public Task<int> UpdateIPadMenu(CompanyMenu data)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Autoid", data.AutoId);
            dbPara.Add("MenuName", data.MenuName);
            dbPara.Add("Url", data.MenuUrl);
            dbPara.Add("UserName", "");
            var updateArticle = Task.FromResult(_dapper.Update<int>("[dbo].[UpdateIphoneMenu]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }

        [HttpPost(nameof(CreateIPadSubMenu))]
        public async Task<int> CreateIPadSubMenu(SubMenuList data)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("MenuName", data.MenuName);
            dbparams.Add("SubMenu", data.SubMenu);
            dbparams.Add("Url", data.MenuUrl);
            dbparams.Add("UserName", "");
            var result = await Task.FromResult(_dapper.Insert<int>("[dbo].[AddIPhoneSubMenu]"
                , dbparams,
                commandType: CommandType.StoredProcedure));
            return result;
        }

        [HttpGet(nameof(GetALLIPadSubMenu))]
        public async Task<IEnumerable<SubMenuList>> GetALLIPadSubMenu()
        {
            var result = await Task.FromResult(_dapper.GetAll<SubMenuList>($"Select * from IPhoneSubMenu", null, commandType: CommandType.Text));
            return result;
        }

        [HttpGet(nameof(GetIPadSubMenuById))]
        public async Task<SubMenuList> GetIPadSubMenuById(int Id)
        {
            var result = await Task.FromResult(_dapper.Get<SubMenuList>($"Select * from IPhoneSubMenu where autoid = {Id}", null, commandType: CommandType.Text));
            return result;
        }
        [HttpPost(nameof(DeleteIPadSubMenu))]
        public async Task<string> DeleteIPadSubMenu(int Id)
        {
            var result = await Task.FromResult(_dapper.Execute($"Delete from IPhoneSubMenu Where autoid = {Id}", null, commandType: CommandType.Text));
            return "Deleted";
        }

        [HttpPost(nameof(UpdateIPadSubMenu))]
        public Task<int> UpdateIPadSubMenu(SubMenuList data)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Autoid", data.AutoId);
            dbPara.Add("MenuName", data.MenuName);
            dbPara.Add("SubMenu", data.SubMenu);
            dbPara.Add("Url", data.MenuUrl);
            dbPara.Add("UserName", "");
            var updateArticle = Task.FromResult(_dapper.Update<int>("[dbo].[IPhoneSubMenutb]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }
    }
}
