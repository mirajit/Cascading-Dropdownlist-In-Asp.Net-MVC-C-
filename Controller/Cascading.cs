 public IActionResult Droupdown()
        {
            return View();
        }
        public JsonResult GetCountry()
        {
            var country = _dbcontext.Division.ToList();
            return Json(country);
        }
        public JsonResult GetState(int id)
        {
            var state = _dbcontext.District.Where(x=>x.CountryId==id).ToList(); 
            return Json(state);
        }
        public JsonResult GetCity(int id)
        {
            var city = _dbcontext.Upazila.Where(x => x.StateId == id).ToList();
            return Json(city);
        }