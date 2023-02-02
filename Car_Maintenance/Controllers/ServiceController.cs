using Car_Maintenance.Data;
using Car_Maintenance.Models;
using Microsoft.AspNetCore.Mvc;

//Câu 1
namespace Car_Maintenance.Controllers
{
    public class ServiceController : Controller
    {
        private readonly CarMaintenanceContext _db;

        public ServiceController(CarMaintenanceContext db)
        {
            _db = db;
        }

        //Trả về view thêm công việc, không xử lý gì cả
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Thêm công việc vào database
        //async, await là để xử lý bất đồng bộ, không phải chờ khi có một tiến trình đang xử lý

        /*Bind ở đây lấy dữ liệu từ view(Create) mà người dùng đã nhập trong form bằng method post 
        rồi gán cho biến congviec*/
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Macv,Tencv,Dongia")] Congviec congviec)
        {
            //ModelState.IsValid: kiểm tra xem dữ liệu đầu vào có hợp lệ hay không, nếu có thì sẽ thực hiện hành động và trả về view Index trong HomeControlller, ngược lại  sẽ trả về view của chính nó (view Create trong Controller)
            if (ModelState.IsValid)
            {
                _db.Add(congviec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
