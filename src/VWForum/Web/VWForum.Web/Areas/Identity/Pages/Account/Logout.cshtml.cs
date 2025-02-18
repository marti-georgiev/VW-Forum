using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using VWForum.Data.Models;

public class LogoutModel : PageModel
{
    private readonly SignInManager<ForumUser> _signInManager;

    public LogoutModel(SignInManager<ForumUser> signInManager)
    {
        _signInManager = signInManager;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _signInManager.SignOutAsync();
        return RedirectToPage("/Index");  // Redirect to homepage or login page
    }
}
