namespace CarWorld.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    using CarWorld.Data;
    using CarWorld.Models;

    [Area("Administration")]
    public class AdministrationCarsController : Controller
    {
        private readonly ApplicationDbContext context;

        public AdministrationCarsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: Administration/AdministrationCars
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = context.Cars
                .Include(c => c.AddedByUser)
                .Include(c => c.BodyType)
                .Include(c => c.Make)
                .Include(c => c.Model);

            return this.View(await applicationDbContext.ToListAsync());
        }

        // GET: Administration/AdministrationCars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                ViewBag.ErrorMessage = $"Car with id {id} cannot be found!";
                return this.View("NotFound");
            }

            var car = await context.Cars
                .Include(c => c.AddedByUser)
                .Include(c => c.BodyType)
                .Include(c => c.Make)
                .Include(c => c.Model)
                .FirstOrDefaultAsync(m => m.Id == id);

            return this.View(car);
        }

        // GET: Administration/AdministrationCars/Create
        public IActionResult Create()
        {
            ViewData["AddedByUserId"] = new SelectList(context.ApplicationUsers, "Id", "Id");
            ViewData["BodyTypeId"] = new SelectList(context.BodyTypes, "Id", "Name");
            ViewData["MakeId"] = new SelectList(context.Makes, "Id", "Name");
            ViewData["ModelId"] = new SelectList(context.Models, "Id", "Name");
            return this.View();
        }

        // POST: Administration/AdministrationCars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AddedByUserId,MakeId,ModelId,BodyTypeId,Year,Price,Description,CreatedOn,IsDeleted")] Car car)
        {
            if (ModelState.IsValid)
            {
                context.Add(car);
                await context.SaveChangesAsync();

                return this.RedirectToAction(nameof(Index));
            }
            ViewData["AddedByUserId"] = new SelectList(context.ApplicationUsers, "Id", "Id", car.AddedByUserId);
            ViewData["BodyTypeId"] = new SelectList(context.BodyTypes, "Id", "Name", car.BodyTypeId);
            ViewData["MakeId"] = new SelectList(context.Makes, "Id", "Name", car.MakeId);
            ViewData["ModelId"] = new SelectList(context.Models, "Id", "Name", car.ModelId);

            return this.View(car);
        }

        // GET: Administration/AdministrationCars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                ViewBag.ErrorMessage = $"Car with id {id} cannot be found!";
                return this.View("NotFound");
            }

            var car = await context.Cars.FindAsync(id);

            ViewData["AddedByUserId"] = new SelectList(context.ApplicationUsers, "Id", "Id", car.AddedByUserId);
            ViewData["BodyTypeId"] = new SelectList(context.BodyTypes, "Id", "Name", car.BodyTypeId);
            ViewData["MakeId"] = new SelectList(context.Makes, "Id", "Name", car.MakeId);
            ViewData["ModelId"] = new SelectList(context.Models, "Id", "Name", car.ModelId);

            return this.View(car);
        }

        // POST: Administration/AdministrationCars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AddedByUserId,MakeId,ModelId,BodyTypeId,Year,Price,Description,CreatedOn,IsDeleted")] Car car)
        {
            if (id != car.Id)
            {
                ViewBag.ErrorMessage = $"Car with id {id} cannot be found!";
                return this.View("NotFound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(car);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.Id))
                    {
                        ViewBag.ErrorMessage = $"Car with id {id} cannot be found!";
                        return this.View("NotFound");
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(Index));
            }
            ViewData["AddedByUserId"] = new SelectList(context.ApplicationUsers, "Id", "Id", car.AddedByUserId);
            ViewData["BodyTypeId"] = new SelectList(context.BodyTypes, "Id", "Name", car.BodyTypeId);
            ViewData["MakeId"] = new SelectList(context.Makes, "Id", "Name", car.MakeId);
            ViewData["ModelId"] = new SelectList(context.Models, "Id", "Name", car.ModelId);

            return this.View(car);
        }

        // GET: Administration/AdministrationCars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                ViewBag.ErrorMessage = $"Car with id {id} cannot be found!";
                return this.View("NotFound");
            }

            var car = await context.Cars
                .Include(c => c.AddedByUser)
                .Include(c => c.BodyType)
                .Include(c => c.Make)
                .Include(c => c.Model)
                .FirstOrDefaultAsync(m => m.Id == id);

            return this.View(car);
        }

        // POST: Administration/AdministrationCars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await context.Cars.FindAsync(id);
            car.IsDeleted = true;

            await context.SaveChangesAsync();

            return this.RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return context.Cars.Any(e => e.Id == id);
        }
    }
}
