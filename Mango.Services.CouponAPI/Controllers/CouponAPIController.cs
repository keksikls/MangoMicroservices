﻿using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CouponAPIController(AppDbContext db)
        {
            _db = db;
        }

        //получение всех
        [HttpGet]
        public object Get() 
        {
            try
            {
                IEnumerable<Coupon> ObjList = _db.Coupons.ToList();
                return ObjList;
            }
            catch (Exception ex)
            {

                
            }
            return null;
        }

        [HttpGet]
        [Route("{id:int}")]
        public object Get(int id)
        {
            try
            {
              Coupon objList = _db.Coupons.FirstOrDefault(u => u.CouponId == id);
              return objList;
            }
            catch (Exception ex)
            {


            }
            return null;
        }
    }
}