#region Using

using Microsoft.AspNetCore.Mvc;
using SAP.API.Business.Providers;
using SAP.API.Common.Entities;
using System;

#endregion

namespace SAP.API.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class TeamsController : ControllerBase
    {
        #region Private Fileds

        private readonly IProvider<Team> _provider;

        #endregion

        #region Constructor

        public TeamsController(IProvider<Team> provider)
        {
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        #endregion

        // GET: api/Teams/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            return _provider.Get(id);
        }
    }
}