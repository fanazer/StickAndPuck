#region Using

using Microsoft.AspNetCore.Mvc;
using SAP.Business.Providers.Contracts;
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

        private readonly ITeamsProvider _provider;

        #endregion

        #region Constructor

        public TeamsController(ITeamsProvider provider)
        {
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        #endregion

        // GET: api/Teams/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            return _provider.GetById(id);
        }
    }
}