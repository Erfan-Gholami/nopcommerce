using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Vote;
using Nop.Services.Customers;
using Nop.Services.Vote;
using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Web.Models.Vote;

namespace Nop.Web.Controllers
{
    [HttpsRequirement]
    [AutoValidateAntiforgeryToken]
    public class VoteController : BasePublicController
    {
        private readonly IVoteService _iVoteService;
        private readonly IWorkContext _workContext;

		public VoteController(IVoteService iVoteService, IWorkContext workContext)
        {
            _iVoteService = iVoteService;
            _workContext = workContext;
        }

		public IActionResult Index()
        {
            var model = new VoteItemModel();
            return View();
        }

        [HttpPost]
		public virtual ActionResult VoteSent(VoteItemModel vm)
		{
            if (ModelState.IsValid)
            {
                var cid = _workContext.CurrentCustomer.Id;
                vm.CustomerId = cid;
                var model = ToVoteItem(vm);
				_iVoteService.Insert(model);
				return RedirectToAction("Index");
			}
			return View("Index");
		}

		public static VoteItem ToVoteItem(VoteItemModel vim)
		{
			var vi = new VoteItem
			{
				Birthday = vim.Birthday,
				Critisize = vim.Critisize,
				CustomerId = vim.CustomerId,
				DrchiaKnowledge = vim.DrchiaKnowledge,
				Email = vim.Email,
				EnviromentPrettiness = vim.EnviromentPrettiness,
				FoodQuality = vim.FoodQuality,
				HowFindUs = vim.HowFindUs,
				Mobile = vim.Mobile,
				Name = vim.Name,
				SawVip = vim.SawVip,
				StaffLook = vim.StaffLook,
				Tahsilat = vim.Tahsilat,
				WhoIsGuest = vim.WhoIsGuest
			};
			return vi;
		}
	}
}
