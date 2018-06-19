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
        DataClasses1DataContext data = new DataClasses1DataContext();
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

            bool NCKH = bool.Parse(collection["NCKH"]);
            string CT_HT = collection["CT_HT"];
            bool SVK = bool.Parse(collection["SVK"]);
            bool TDTT = bool.Parse(collection["TDTT"]);
            string Hoithao = collection["HoiThao"];
            bool XTN = bool.Parse(collection["XTN"]);
            bool tn_5 = bool.Parse(collection["5TN"]);
            bool B1 = bool.Parse(collection["B1"]);
            string B1khac = collection["B1khac"];
            bool HN = bool.Parse(collection["HN"]);
            bool giai_NN = bool.Parse(collection["giai_NN"]);
            bool HoithaoKN = bool.Parse(collection["HoithaoKN"]);

            pdki.DRL_HK1 = DRL_HK1;
            pdki.DRL_HK2 = DRL_HK2;
            pdki.DRL_TB = DRL_tb;
            pdki.KQ_CHATLUONGDOANVIEN = kq;
            pdki.DD_THANHNIENTTLAMTHEOLOIBAC = tntt;
            pdki.DD_HOITHI_TTHCM = ttHCM;
            pdki.DIEMHK1 = dht_hk1;
            pdki.DIEMHK2 = dht_hk2;
            pdki.DIEMTB = dht_tb;
            pdki.HT_BAIVIETKH = NCKH;
            pdki.TEN_THIHOCTHUAT = CT_HT;
            pdki.TL_SVKHOE = SVK;
            pdki.TL_TV_DOITUYENTDTT = TDTT;
            data.PHIEUDK_SV5Ts.InsertOnSubmit(pdki);
            data.SubmitChanges();

            return RedirectToAction("Index");
        }
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
                    Session["TaikhoanUsername"] = ac.USERNAME;
                    Session["LoaiTaikhoan"] = ac.MALOAI.ToLower().Trim();
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
            return "đá";
        }
    }
}