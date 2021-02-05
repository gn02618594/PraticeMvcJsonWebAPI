using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiServices.Helpers;
using WebApiServices.Models;
namespace WebApiServices.Controllers
{
    public class CarsController : ApiController
    {
        List<CarSales> CarSalesNumber;
        public CarsController()//<--在預設建構式中初始化 List 集合資料
        {
            //以亂數產生 1-12 月銷售數據
            Utility util = new Utility();
            var random1 = util.getNumbers(12);
            var random2 = util.getNumbers(12);
            CarSalesNumber = new List<CarSales>
            {
                new CarSales{Id=1,Car="BMW",Salesdata=random1},
                new CarSales{Id=2,Car="BENZ",Salesdata=random2}
            };
        }

        //URL api/cars
        //回傳所有汽車的銷售資料
        [AcceptVerbs("GET", "POST")]
        public IEnumerable<CarSales> getCarSalesNumber() {//回傳所有汽車銷售資料
            return CarSalesNumber;
        }

        //URL api/cars/2
        //根據汽車 Id 找出銷售資料
        [AcceptVerbs("GET", "POST")]
        public IHttpActionResult getSingleCarSalesNumber(int id) { //以 Id 找出單筆汽車銷售資料
            var car = CarSalesNumber.FirstOrDefault(c => c.Id == id);
            if (car == null) {
                return NotFound();
            }
            return Ok(car);
        }
    }
}
