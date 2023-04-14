﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using TraversalCoreDemo.Areas.Admin.Models;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VisitorApiController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public VisitorApiController(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5094/api/Visitor");
            if(responseMessage.IsSuccessStatusCode) {
                var json=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<VisitorViewModel>>(json);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddVisitor()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> AddVisitor(VisitorViewModel visitorViewModel)
        {
            var client=_httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(visitorViewModel);
            StringContent content=new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("http://localhost:5094/api/Visitor",content);
            if(responseMessage.IsSuccessStatusCode )
            {
                return RedirectToAction("Index");
            }
            return View();
        }

   
        public async Task<IActionResult> DeleteVisitor(int id)
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("http://localhost:5094/api/Visitor"+"/"+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> UpdateVisitor(int id)
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5094/api/Visitor" + "/" + id);
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<VisitorViewModel>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateVisitor(VisitorViewModel visitorViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(visitorViewModel);
            StringContent content= new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("http://localhost:5094/api/Visitor", content);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
