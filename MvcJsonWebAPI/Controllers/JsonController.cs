using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcJsonWebAPI.Models;

namespace MvcJsonWebAPI.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public ActionResult LineTemperatureJSON()
        {
            //1.string 陣列(資料物件 Data Object)
            string[] Labels = {"1月","2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月", };//C#字串陣列
            //序列化成為 JSON 物件物件結構字串
            string JsonLabels = Newtonsoft.Json.JsonConvert.SerializeObject(Labels);
            //以 ViewBag 將資料傳給 View
            ViewBag.Labels = JsonLabels;

            //2.List 集合包含台北,台中及高雄三個地方的氣溫資料
            List<Location> Locations = new List<Location>//C# 泛型集合，裡面宣告三個城市氣溫資料
            {
                new Location
                {
                    City="台北",
                    Temperature=new double[]{16.1,16.5,18.5,21.9,25.2,27.7,29.6,29.2,27.4,24.5,21.5,17.9}
                },
                new Location{
                City="台中",
                Temperature=new double[]{ 16.6,17.3,19.6,23.1,26.0,27.6,28.6,28.3,27.4,25.2,21.9,18.1}
                },
                new Location{
                City="高雄",
                Temperature=new double[]{19.3,20.3,22.6,25.4,27.5,28.5,29.2,28.7,28.1,26.7,24.0,20.6 }
                }
            };
            //將 List 集合序列化成為 JSON 物件結構字串
            string JsonLocations = Newtonsoft.Json.JsonConvert.SerializeObject(Locations);//用序列化 C#集合轉成JSON字串
            //以 ViewBag 將資料傳給 View
            ViewBag.JsonLocations = JsonLocations;

            //將 Models 資料傳給 View，用於資料顯示
            return View(Locations);
        }

        public ActionResult CarSalesAjaxJSON() {
            return View();
        }
    }
}