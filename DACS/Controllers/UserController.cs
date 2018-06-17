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
        [HttpGet]
        public ActionResult TTinSV()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TTinSV(FormCollection collection, PHIEUDK_SV5T pdki)
        {
            int DRL_HK1 = int.Parse(collection["DRL_HK1"]);
            int DRL_HK2 = int.Parse(collection["DRL_HK2"]);
            int DRL_tb = int.Parse(collection["DRL_tb"]);
            string kq = collection["CLDoanvien"];
            bool tntt = bool.Parse(collection["tntt"]);
            bool ttHCM = bool.Parse(collection["ttHCM"]);
            float dht_hk1 = float.Parse(collection["DHT_HK1"]);
            float dht_hk2 = float.Parse(collection["DHT_HK2"]);
            float dht_tb = float.Parse(collection["DHT_TB"]);
            pdki.DRL_HK1 = DRL_HK1;

            pdki.DRL_HK2 = DRL_HK2;

            pdki.DRL_TB = DRL_tb;

            pdki.KQ_CHATLUONGDOANVIEN = kq;
            return View();
        }

        [HttpGet]
        public ActionResult SV5T()
        {
            if (string.IsNullOrEmpty(Session["LoaiTaikhoan"] as string))
                return RedirectToAction("Login", "User");
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
        public ActionResult Login(FormCollection collection)
        {
            //gán các giá trị người dùng nhập liệu cho các biến 
            var tendn = collection["username"];
            var matkhau = collection["Password"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập mã số sinh viên";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Mật khẩu là MSSV";
            }
            else
            {
                //Gán giá trị cho đối tượng được tạo mới ad
                ACCOUNT ac = data.ACCOUNTs.SingleOrDefault(n => n.USERNAME == tendn && n.PASSWORD == matkhau);
                if (ac != null)
                {
                    ViewBag.THongbao = "Chúc mừng bạn đã đăng nhập thành công";
                    Session["Taikhoan"] = ac;
                    Session["LoaiTaikhoan"] = ac.MALOAI.ToLower().Trim();
                    Session["TaikhoanUsername"] = ac.USERNAME;
                    return RedirectToAction("Index", "User");
                }
                else
                    ViewBag.Thongbao = "Tài khoản bị lỗi. Liên hệ phòng CTSV để được giải quyết";
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
        public string lay_tc_tinh_nguyen1()
        {
            var tn1 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "TN");
            return tn1.NOIDUNG_TC1;
        }

        public string lay_tc_tinh_nguyen2()
        {
            var tn1 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "TN");
            return tn1.NOIDUNG_TC2;
        }

        public string lay_tc_hoi_nhap1()
        {
            var hn = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "HN");
            return hn.NOIDUNG_TC1;
        }

        public string lay_tc_hoi_nhap2()
        {
            var tn1 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "HN");
            return tn1.NOIDUNG_TC2;
        }
        public string lay_tc_hoi_nhap3()
        {
            var tn1 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "HN");
            return tn1.NOIDUNG_TC3;
        }
        public string lay_tc_hoi_nhap4()
        {
            var tn1 = data.CHITIET_TCs.SingleOrDefault(t => t.MATC == "HN");
            return tn1.NOIDUNGTC_4;
        }

        //lay diem ren luyen
        public string lay_check_box_DRL()
        {
            var s = "";
            var lst_result = from li in data.KQDANHGIA_ACCOUNTs
                             where li.USERNAME == Session["TaikhoanUsername"].ToString()
                             select new { user_chkboxDRL = li.DIEMRL };
            int count = 0;
            foreach (var item in lst_result)
            {
                s += "<td>";
                if ((bool)item.user_chkboxDRL)
                {
                    if (count == 0)
                    {
                        s += "<input type='checkbox' checked='checked' id='DRL_SV'/>";
                        s += "<label for='DRL_SV'></label>";
                    }
                    else if (count == 1)
                    {
                        if (Session["LoaiTaikhoan"].ToString() == "sv")
                        {
                            s += "<input disabled type='checkbox' checked='checked' id='DRL_K'/>";
                            s += "<label for='DRL_K'></label>";
                        }
                        else
                        {
                            s += "<input type='checkbox' checked='checked' id='DRL_K'/>";
                            s += "<label for='DRL_K'></label>";
                        }
                    }
                    else
                    {
                        if (Session["LoaiTaikhoan"].ToString() == "sv" || Session["LoaiTaikhoan"].ToString() == "k")
                        {
                            s += "<input disabled type='checkbox' checked='checked' id='DRL_PB'/>";
                            s += "<label for='DRL_PB'></label>";
                        }
                        else
                        {
                            s += "<input type='checkbox' checked='checked' id='DRL_PB'/>";
                            s += "<label for='DRL_PB'></label>";
                        }
                    }
                }
                else
                {
                    if (count == 0)
                    {
                        s += "<input type='checkbox' id='DRL_SV'/>";
                        s += "<label for='DRL_SV'></label>";
                    }
                    else if (count == 1)
                    {
                        if (Session["LoaiTaikhoan"].ToString() == "sv")
                        {
                            s += "<input disabled type='checkbox' id='DRL_K'/>";
                            s += "<label for='DRL_K'></label>";
                        }
                        else
                        {
                            s += "<input type='checkbox' id='DRL_K'/>";
                            s += "<label for='DRL_K'></label>";
                        }
                    }
                    else
                    {
                        if (Session["LoaiTaikhoan"].ToString() == "sv" || Session["LoaiTaikhoan"].ToString() == "k")
                        {
                            s += "<input disabled type='checkbox' id='DRL_PB'/>";
                            s += "<label for='DRL_PB'></label>";
                        }
                        else
                        {
                            s += "<input type='checkbox' id='DRL_PB'/>";
                            s += "<label for='DRL_PB'></label>";
                        }
                    }
                }
                s+="</td>";
                count++;
            }
            return s;
        }

        //lay diem hoc tap
        public string lay_check_box_DHT()
        {
            var s = "";
            var lst_result = from li in data.KQDANHGIA_ACCOUNTs
                             where li.USERNAME == Session["TaikhoanUsername"].ToString()
                             select new { user_chkboxDHT = li.DIEMHOCTAP };
            int count = 0;
            foreach (var item in lst_result)
            {
                s += "<td>";
                if ((bool)item.user_chkboxDHT)
                {
                    if (count == 0)
                    {
                        s += "<input type='checkbox' checked='checked' id='DHT_SV'/>";
                        s += "<label for='DHT_SV'></label>";
                    }
                    else if (count == 1)
                    {
                        if (Session["LoaiTaikhoan"].ToString() == "sv")
                        {
                            s += "<input disabled type='checkbox' checked='checked' id='DHT_K'/>";
                            s += "<label for='DHT_K'></label>";
                        }
                        else
                        {
                            s += "<input type='checkbox' checked='checked' id='DHT_K'/>";
                            s += "<label for='DHT_K'></label>";
                        }
                    }
                    else
                    {
                        if (Session["LoaiTaikhoan"].ToString() == "sv" || Session["LoaiTaikhoan"].ToString() == "k")
                        {
                            s += "<input disabled type='checkbox' checked='checked' id='DHT_PB'/>";
                            s += "<label for='DHT_PB'></label>";
                        }
                        else
                        {
                            s += "<input type='checkbox' checked='checked' id='DHT_PB'/>";
                            s += "<label for='DHT_PB'></label>";
                        }
                    }
                }
                else
                {
                    if (count == 0)
                    {
                        s += "<input type='checkbox' id='DHT_SV'/>";
                        s += "<label for='DHT_SV'></label>";
                    }
                    else if (count == 1)
                    {
                        if (Session["LoaiTaikhoan"].ToString() == "sv")
                        {
                            s += "<input disabled type='checkbox' id='DHT_K'/>";
                            s += "<label for='DHT_K'></label>";
                        }
                        else
                        {
                            s += "<input type='checkbox' id='DHT_K'/>";
                            s += "<label for='DHT_K'></label>";
                        }
                    }
                    else
                    {
                        if (Session["LoaiTaikhoan"].ToString() == "sv" || Session["LoaiTaikhoan"].ToString() == "k")
                        {
                            s += "<input disabled type='checkbox' id='DHT_PB'/>";
                            s += "<label for='DHT_PB'></label>";
                        }
                        else
                        {
                            s += "<input type='checkbox' id='DHT_PB'/>";
                            s += "<label for='DHT_PB'></label>";
                        }
                    }
                }
                s += "</td>";
                count++;
            }
            return s;
        }

        //thay doi checkbox
        public string thaydoi_checkbox(string chkbox_id)
        {

        }
    }
}