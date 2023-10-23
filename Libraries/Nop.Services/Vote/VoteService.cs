using Nop.Core.Domain.Vote;
using Nop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nop.Services.Vote
{
	public partial class VoteService : IVoteService
	{
		private readonly IRepository<VoteItem> _voteItemRepository;

		public VoteService(IRepository<VoteItem> voteItemRepository)
		{
			_voteItemRepository = voteItemRepository;
		}

		public void Insert(VoteItem vi)
		{
            _voteItemRepository.Insert(vi);
		}

        public IList<VoteItem> GetAllVotes()
        {
            var voteItems = _voteItemRepository.Table.ToList();
            return voteItems;
        }

        public VoteItem GetById(int id)
        {
	        var voteItem=_voteItemRepository.GetById(id);
	        return voteItem;
        }
	}
}
