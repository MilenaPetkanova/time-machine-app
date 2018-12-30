namespace TimeMachine.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using System.Security.Claims;

    using TimeMachine.Data.Models.UserProfile;
    using TimeMachine.Services.DataServices.Contracts;
    using TimeMachine.Web.Areas.Identity.Data;
    using TimeMachine.Services.Models.Stories;
    using Microsoft.AspNetCore.Authorization;

    public class StoriesController : BaseController
    {
        private readonly IStoriesService _storiesService;

        public StoriesController(UserManager<TimeMachineUser> userManager, SignInManager<TimeMachineUser> signInManager, IMapper mapper, IStoriesService storiesService) 
            : base(userManager, signInManager, mapper)
        {
            this._storiesService = storiesService;
        }

        public async Task<IActionResult> Index()
        {
            var currentUserId = _userManager.GetUserId(User);

            var allStoriesViewModels = this._storiesService.GetAllUserStories(currentUserId);

            return this.View(allStoriesViewModels);
        }

        //    // GET: Stories/Details/5
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var story = await _context.Stories
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (story == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(story);
        //    }

        //    // GET: Stories/Create
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: Stories/Create
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("CreatedOn,CurrentUserAge,TextContent,UserId,Id")] Story story)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(story);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(story);
        //    }

        //    // GET: Stories/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var story = await _context.Stories.FindAsync(id);
        //        if (story == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(story);
        //    }

        //    // POST: Stories/Edit/5
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, [Bind("CreatedOn,CurrentUserAge,TextContent,UserId,Id")] Story story)
        //    {
        //        if (id != story.Id)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(story);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!StoryExists(story.Id))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(story);
        //    }

        //    // GET: Stories/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var story = await _context.Stories
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (story == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(story);
        //    }

        //    // POST: Stories/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var story = await _context.Stories.FindAsync(id);
        //        _context.Stories.Remove(story);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool StoryExists(int id)
        //    {
        //        return _context.Stories.Any(e => e.Id == id);
        //    }
    }
}
