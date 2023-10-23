using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Vote;
using Nop.Services.Vote;
using Nop.Web.Areas.Admin.Models.VoteList;
using Nop.Web.Models.Vote;

namespace Nop.Web.Areas.Admin.Controllers
{
    public class VoteListController : BaseAdminController
    {
        private readonly IVoteService _voteService;

        public VoteListController(IVoteService voteService)
        {
            _voteService = voteService;
        }

        public IActionResult Index()
        {
            var voteResults = _voteService.GetAllVotes();
            var vim = ToVoteModelItemList(voteResults);
            return View(vim);
        }

        public IActionResult Details(int id)
        {
	        var voteResult = _voteService.GetById(id);
            var vim = ToVoteModelItem(voteResult);

            return View(vim);
        }
        public static VoteItemModel ToVoteModelItem(VoteItem vi)
        {
            var vim = new VoteItemModel
            {
                Birthday = vi.Birthday,
                Critisize = vi.Critisize,
                CustomerId = vi.CustomerId,
                DrchiaKnowledge = vi.DrchiaKnowledge,
                Email = vi.Email,
                EnviromentPrettiness = vi.EnviromentPrettiness,
                FoodQuality = vi.FoodQuality,
                HowFindUs = vi.HowFindUs,
                Mobile = vi.Mobile,
                Name = vi.Name,
                SawVip = vi.SawVip,
                StaffLook = vi.StaffLook,
                Tahsilat = vi.Tahsilat,
                WhoIsGuest = vi.WhoIsGuest
            };
            return vim;
        }

        public static IList<VoteListItemModel> ToVoteModelItemList(IList<VoteItem> vil)
        {
            var list = new List<VoteListItemModel>();
            foreach (var vi in vil)
            {
                var vim = new VoteListItemModel
                {
                    Id = vi.Id,
                    Birthday = vi.Birthday,
                    Critisize = vi.Critisize,
                    CustomerId = vi.CustomerId,
                    DrchiaKnowledge = vi.DrchiaKnowledge,
                    Email = vi.Email,
                    EnviromentPrettiness = vi.EnviromentPrettiness,
                    FoodQuality = vi.FoodQuality,
                    HowFindUs = vi.HowFindUs,
                    Mobile = vi.Mobile,
                    Name = vi.Name,
                    SawVip = vi.SawVip,
                    StaffLook = vi.StaffLook,
                    Tahsilat = vi.Tahsilat,
                    WhoIsGuest = vi.WhoIsGuest
                };
                list.Add(vim);
            }
            return list;
        }
    }
}
