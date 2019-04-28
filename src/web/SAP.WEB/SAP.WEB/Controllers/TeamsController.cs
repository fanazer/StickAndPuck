#region Using

using Microsoft.AspNetCore.Mvc;
using SAP.Business.Providers.People;
using SAP.Common.Entities;
using System;

#endregion

namespace SAP.WEB.Controllers
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