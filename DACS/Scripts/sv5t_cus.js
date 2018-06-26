$(document).ready(function () {
    layDaoDuc();
    function layDaoDuc() {
        $.ajax({
            url: 'lay_dao_duc',
            method: 'POST',
            success: function (data) {
                $("#dd_title").html(data);
            }
        });
    }

    //layDaoDuc2();
    //function layDaoDuc2() {
    //    $.ajax({
    //        url: 'lay_dao_duc2',
    //        method: 'POST',
    //        success: function (data) {
    //            $("#dd2_title").html(data);
    //        }
    //    });
    //}

    layHocTap();
    function layHocTap() {
        $.ajax({
            url: 'lay_hoc_tap',
            method: 'POST',
            success: function (data) {
                $("#ht_title").html(data);
            }
        });
    }

    layTheLuc();
    function layTheLuc() {
        $.ajax({
            url: 'lay_the_luc',
            method: 'POST',
            success: function (data) {
        
                $("#tl1_title").html(data);
            }
        });
    }

    layTheLuc2();
    function layTheLuc2() {
        $.ajax({
            url: 'lay_the_luc2',
            method: 'POST',
            success: function (data) {
                $("#tl2_title").html(data);
            }
        });
    }

    layTinhNguyen1();
    function layTinhNguyen1() {
        $.ajax({
            url: 'lay_tc_tinh_nguyen1',
            method: 'POST',
            success: function (data) {
                $("#tn1_title").html(data);
            }
        });
    }

    layTinhNguyen2();
    function layTinhNguyen2() {
        $.ajax({
            url: 'lay_tc_tinh_nguyen2',
            method: 'POST',
            success: function (data) {
                $("#tn2_title").html(data);
            }
        });
    }

    layHoiNhap1();
    function layHoiNhap1() {
        $.ajax({
            url: 'lay_tc_hoi_nhap1',
            method: 'POST',
            success: function (data) {
                $("#hn1_title").html(data);
            }
        });
    }

    layHoiNhap2();
    function layHoiNhap2() {
        $.ajax({
            url: 'lay_tc_hoi_nhap2',
            method: 'POST',
            success: function (data) {
                $("#hn2_title").html(data);
            }
        });
    }
    layHoiNhap3();
    function layHoiNhap3() {
        $.ajax({
            url: 'lay_tc_hoi_nhap3',
            method: 'POST',
            success: function (data) {
                $("#hn3_title").html(data);
            }
        });
    }

    layCheckBox_DRL();
    function layCheckBox_DRL() {
        $.ajax({
            url: 'lay_check_box_DRL',
            method: 'POST',
            success: function (data) {
                $("#dd_title").after(data);
            }
        });
    }

    layCheckBox_DHT();
    function layCheckBox_DHT() {
        $.ajax({
            url: 'lay_check_box_DHT',
            method: 'POST',
            success: function (data) {
                $("#ht_title").after(data);
            }
        });
    }
    layCheckBox_TLSVKhoe();
    function layCheckBox_TLSVKhoe() {
        $.ajax({
            url: 'lay_check_box_TLSVKhoe',
            method: 'POST',
            success: function (data) {
                $("#tl1_title").after(data);
            }
        });
    }
    layCheckBox_TLTDTT();
    function layCheckBox_TLTDTT() {
        $.ajax({
            url: 'lay_check_box_TLTDTT',
            method: 'POST',
            success: function (data) {
                $("#tl2_title").after(data);
            }
        });
    }

    layCheckBox_TNChienDich();
    function layCheckBox_TNChienDich() {
        $.ajax({
            url: 'lay_check_box_TNChienDich',
            method: 'POST',
            success: function (data) {
                $("#tn1_title").after(data);
            }
        });
    }
    layCheckBox_TN3ngay();
    function layCheckBox_TN3ngay() {
        $.ajax({
            url: 'lay_check_box_TN3ngay',
            method: 'POST',
            success: function (data) {
                $("#tn2_title").after(data);
            }
        });
    }
    layCheckBox_HN_AVB1();
    function layCheckBox_HN_AVB1() {
        $.ajax({
            url: 'lay_check_box_HN_AVB1',
            method: 'POST',
            success: function (data) {
                $("#hn1_title").after(data);
            }
        });
    }
    layCheckBox_HN_NNC();
    function layCheckBox_HN_NNC() {
        $.ajax({
            url: 'lay_check_box_HN_NNC',
            method: 'POST',
            success: function (data) {
                $("#hn2_title").after(data);
            }
        });
    }
    layCheckBox_HN_GiaoLuuQT();
    function layCheckBox_HN_GiaoLuuQT() {
        $.ajax({
            url: 'lay_check_box_HN_GiaoLuuQT',
            method: 'POST',
            success: function (data) {
                $("#hn3_title").after(data);
            }
        });
    }
    $('body').delegate("button#XacNhanDanhGia", 'click', function () {
        console.log("ssss");
    });
});