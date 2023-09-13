using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LibraryApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryContext _context;

        public HomeController(LibraryContext context)
        {
            _context = context;
        }

        // Ana sayfa: Tüm kitapları listeleyen bir görünüm döndürür.
        public IActionResult Index()
        {
            var books = _context.Book.ToList();
            return View(books);
        }

        // Müşteri bilgilerini girmek için bir görünüm döndürür.
        public IActionResult Customer()
        {
            return View();
        }

        // Kitap ekleme sayfasını gösteren bir görünüm döndürür.
        public IActionResult AddBookPage()
        {
            return View();
        }

        // Kitap ekleme işlemine yönlendiren bir HTTP POST işlemi.
        [HttpPost]
        public IActionResult Book()
        {
            return RedirectToAction("AddBookPage");
        }

        // Müşteriye kitap ödünç verme işlemini başlatır ve müşteri bilgileri giriş ekranına yönlendirir.
        [HttpPost]
        public IActionResult Customer(int bookId)
        {
            TempData["SelectedBookId"] = bookId;
            return RedirectToAction("Customer");
        }

        // Müşteri bilgilerini kaydeder ve kitap durumunu günceller.
        [HttpPost]
        public IActionResult SaveCustomer(string DomainCrm, DateTime ReleaseDate)
        {
            int bookId = (int)TempData["SelectedBookId"];
            var book = _context.Book.FirstOrDefault(b => b.Id == bookId);

            if (book != null)
            {
                book.Customer = DomainCrm;
                book.Backtime = ReleaseDate;
                book.Location = "Dışarda";
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // Kitap resmini yükler ve kitap bilgilerini kaydeder.
        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile file, Books book)
        {
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;

                string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                string path = Path.Combine(folderPath, imageName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using var stream = new FileStream(path, FileMode.Create);
                await file.CopyToAsync(stream);

                book.ImageURL = "/images/" + imageName;
                book.Location = "Kütüphane";

                _context.Book.Add(book);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // Hata görünümünü döndürür.
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
