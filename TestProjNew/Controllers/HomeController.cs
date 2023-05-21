using Magicodes.ExporterAndImporter.Pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NrcTaskWeb.HelperMethods;
using System.Threading.Tasks;
using TestProjNew.Models;

namespace TestProjNew.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        IRepo _repo;

        public HomeController(IRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index(string pdfFileName = null)
        {
            if (pdfFileName != null)
            {
                ViewData["PdfFile"] = pdfFileName;
            }
            else
            {
                ViewData["PdfFile"] = null;
            }

            var data = _repo.GetDataSamples();
            return View(data);
        }

        public async Task<IActionResult> Print()
        {
            string fileNameResult = null;
            var exporter = new PdfExporter();
            var pdfFilePath = DirectoryMethods.GetPdfFileLocation();

            var data = _repo.GetDataSamples();
            var result = await exporter.ExportListByTemplate(pdfFilePath, data);

            if (!string.IsNullOrEmpty(result.FileName))
            {
                fileNameResult = result.FileName;
            }
            return RedirectToAction("Index", new { pdfFileName = fileNameResult });
        }
    }
}
