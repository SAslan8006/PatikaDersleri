using Microsoft.AspNetCore.Mvc;

namespace Layout_Yapilanmasi.ViewComponents
{
    public class PersonellerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)  // viewcomponent çağrılıp render edildiğinde çalışmasını istediğimiz kodları bu imzada bir metodun içine yerleştirmeliyiz. Kalıp yani bu
        {
            return View();
        }
    }
}
