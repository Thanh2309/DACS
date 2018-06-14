using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DACS.Models;
namespace DACS.Controllers
{
    public class UserController : Controller
    {
        DBL_DACSDataContext data = new DBL_DACSDataContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TTinSV()
        {
            return View();
        }
        public ActionResult SV5T()
        {
            //var dd = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "DD");
            return View();
        }
        public ActionResult LHTT()
        {
            return View();
        }
        public ActionResult NCKH()
        {
            return View();
        }
        public ActionResult Help()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            //gán các giá trị người dùng nhập liệu cho các biến 
            var tendn = collection["username"];
            var matkhau = collection["password"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu";
            }
            else
            {
                //Gán giá trị cho đối tượng được tạo mới ad
                //Admin ad = db.Admins.SingleOrDefault(n => n.UserAdmin == tendn && n.PassAdmin == matkhau);
                //if (ad != null)
                //{
                //    //ViewBag.THongbao-"Chúc mừng bạn đã đăng nhập thàn công";
                //    Session["Taikhoanadmin"] = ad;
                //    return RedirectToAction("Index", "Admin");
                //}
                //else
                //    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }

        //========= JS Handle ========================================
        public string lay_dao_duc()
        {
            var dd = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "DD");
            return dd.NOIDUNG_TC1;
        }
        public string lay_dao_duc2()
        {
            var dd2 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "DD");
            return dd2.NOIDUNG_TC2;
        }
        public string lay_hoc_tap()
        {
            var ht = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "HT");
            return ht.NOIDUNG_TC1;
        }
        public string lay_the_luc()
        {
            var tl = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "TL");
            return tl.NOIDUNG_TC1;
        }
        public string lay_the_luc2()
        {
            var tl2 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "TL");
            return tl2.NOIDUNG_TC2;
        }
        public string lay_the_luc3()
        {
            var tl3 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "TL");
            return tl3.NOIDUNG_TC3;
        }
        public string lay_tinh_nguyen1()
        {
            var tn1 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "TN");
            return tn1.NOIDUNG_TC1;
        }

        public string lay_tinh_nguyen2()
        {
            var tn1 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "TN");
            return tn1.NOIDUNG_TC2;
        }

        public string lay_hoi_nhap()
        {
            var hn = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "HN");
            return hn.NOIDUNG_TC1;
        }
        //public bool? lay_check_box()
        //{
        //    var dd = data.KQDANHGIA_ACCOUNTs.SingleOrDefault(t => t.USERNAME == "TK_CNTT");
        //    var diem_rl = dd.DIEMRL;
        //    var diem_ht = dd.DIEMHOCTAP;
        //    var test_tl = dd.TEST_THELUC;
        //    var tn_5ngaytn = dd.TN_5NGAYTN;
        //    var tn_3cdl = dd.TN_3CHIENDICHLON;
        //    var hn_nn = dd.HN_NGOAINGU;
        //    var hn_kn = dd.HN_KYNANG;
        //    var ut_knd = dd.UT_KETNAPDANG;
        //    var ut_hm = dd.UT_HIENMAU;
        //    var ut_bd = dd.UT_BIEUDUONG;


        //}
    }
}