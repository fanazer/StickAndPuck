#region Using

using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SAP.API.Business.Providers;
using SAP.API.Common.Entities.People;

#endregion

namespace SAP.API.WEB.Controllers
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
