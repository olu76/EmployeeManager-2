using EmployeeManager.RazorPages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace EmployeeManager.RazorPages
{
  public class ListModel : PageModel
  {
    private readonly AppDbContext db = null;
    public List<Employee>  Employees { get; set;}
    public ListModel(AppDbContext db)
    {
      this.db = db;
    }
    public void OnGet()
  {
    Employees = (from e in db.Employees orderby e.EmployeeID select e).ToList();
  }
  }

}
  