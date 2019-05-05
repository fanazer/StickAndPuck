#region Using

using Microsoft.AspNetCore.Mvc;
using SAP.Business.Providers.People;
using SAP.Common.Entities.People;
using System;
using System.Collections.Generic;
using SAP.Business.Providers.Contracts;

#endregion

namespace SAP.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class PlayersController : ControllerBase
    {
        #region Private Fileds

        private readonly IPlayerProvider _provider;

        #endregion

        #region Constructor

        public PlayersController(IPlayerProvider provider)
        {

            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        #endregion

        // GET: api/Players/5
        [HttpGet("{id}")]
        public Player GetById(int id)
        {
            return _provider.GetById(id);
        }

        // POST: api/Players
        [HttpPost]
        public IEnumerable<Player> GetByTop([FromBody]int quantity)
        {
            return _provider.GetByTop(quantity);
        }
    }
}
