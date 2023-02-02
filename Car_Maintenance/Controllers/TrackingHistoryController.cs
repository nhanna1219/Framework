using Car_Maintenance.Data;
using Car_Maintenance.Models;
using Car_Maintenance.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

//Câu 2
namespace Car_Maintenance.Controllers
{
    public class TrackingHistoryController : Controller
    {
        private readonly CarMaintenanceContext _db;

        public TrackingHistoryController(CarMaintenanceContext db)
        {
            _db = db;
        }

        //Tạo view Index, và trả về view (tìm trong phần Views/TrackingHistory/Index.cshtml)
        public IActionResult Index()
        {

            return View();
        }

        //Lấy searchString ở trên thanh tìm kiếm (xuất hiện khi người dùng nhập vào biển số xe và ấn Track)
        //searchString có trên thanh tìm kiếm là vì trong view Index, thẻ form có method là get
        //Ngược lại nếu là post thì nó sẽ không xuất hiện rõ ràng nữa (thích hợp cho những thông tin bảo mật)

        //Khai báo biến result và gán cho nó giá trị vừa tìm được bằng Linq to Entity (đọc thêm), sau đấy gán biến result vào view (cách này được gọi là strongly typed, truyền giá trị qua view, view muốn sử dụng thì phải khai báo bằng @model.tên_project.thư_mục.model_có_chứa_kết_quả)  
        public async Task<IActionResult> SearchResult(string searchString)
        {
            var result = _db.Baoduongs
                            .Where(r => r.Soxe == searchString)
                            .ToListAsync();
            return View(await result);
        }

        //Cau 3
        // a.
        //Tạo ra một viewmodels có chứa các model, sau đấy gán giá trị vào và truyền qua view Details
        public async Task<IActionResult> Details(string id)
        {
            TrackingVM result = new TrackingVM()
            {
                CT_BD = await _db.CT_BDs
                        .Include(cv => cv.Congviec)
                        .Where(i => i.Mabd == id)
                        .AsNoTracking()
                        .ToListAsync(),
                Baoduong = await _db.Baoduongs
                            .Where(i => i.Mabd == id)
                            .AsNoTracking()
                            .FirstOrDefaultAsync(),
            };
            return View(result);
        }

        //b.
        public async Task<IActionResult> Delete(string? id)
        {
            //Tìm MỘT công việc trong database
            var cv =  await _db.CT_BDs
                        .FirstOrDefaultAsync(i => i.Macv == id);
            //Xóa công việc
            if (ModelState.IsValid)
            {
                _db.Remove(cv);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cv);
        }

        //c.
        //Hiểu đơn giản, Get là display dữ liệu, còn Post là lấy dữ liệu về
        //ở đây dùng get để display dữ liệu lên view
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var bd = await _db.Baoduongs
                        .Where(bd => bd.Mabd == id)
                        .AsNoTracking()
                        .FirstOrDefaultAsync();
            return View(bd);
        }

        //e.
        //Còn ở đây dùng Post để lấy dữ liệu người dùng nhập về và Update trên database
        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Mabd,Ngaygionhan,Ngaygiotra,Sokm,Noidung,Soxe")] Baoduong baoduong)
        {
            if (ModelState.IsValid)
            {
                _db.Update(baoduong);
                await _db.SaveChangesAsync();
                return RedirectToAction("SearchResult", new {SearchString = baoduong.Soxe});
            }
            return View();
        }
    }
}
