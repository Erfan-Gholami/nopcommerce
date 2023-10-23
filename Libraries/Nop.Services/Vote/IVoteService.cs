using Nop.Core.Domain.Vote;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Services.Vote
{
	public partial interface IVoteService
	{
		public void Insert(VoteItem vi);

        public IList<VoteItem> GetAllVotes();

		public VoteItem GetById(int id);

    }
}
