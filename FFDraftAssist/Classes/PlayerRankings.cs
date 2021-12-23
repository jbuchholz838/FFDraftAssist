using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FFDraftAssist
{

    public abstract class PlayerRankings
    {

        public string title = "";

        public PlayerRankings()
        {



        }

        public abstract List<Player> GetPlayers(Draft draft = null);
    }
}
