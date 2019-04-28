#region Using

using Microsoft.AspNetCore.Mvc;
using SAP.Business.Providers.People;
using SAP.Common.Entities.People;
using System;
using System.Collections.Generic;

#endregion

namespace SAP.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class PlayersController : ControllerBase
    {
        #region Private Fileds

        private readonly IProvider<Player> _provider;

        #endregion

        #region Constructor

        public PlayersController(IProvider<Player> provider)
        {

            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        #endregion

        // GET: api/Players
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return _provider.FindBy(player => player.Id > 1);
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public Player Get(int id)
        {
            return _provider.Get(id);
        }
    }
}
