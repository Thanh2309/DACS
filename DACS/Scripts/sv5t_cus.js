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

    layDaoDuc2();
    function layDaoDuc2() {
        $.ajax({
            url: 'lay_dao_duc2',
            method: 'POST',
            success: function (data) {
                $("#dd2_title").html(data);
            }
        });
    }

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

    layTheLuc3();
    function layTheLuc3() {
        $.ajax({
            url: 'lay_the_luc3',
            method: 'POST',
            success: function (data) {
                $("#tl3_title").html(data);
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
    layHoiNhap4();
    function layHoiNhap4() {
        $.ajax({
            url: 'lay_tc_hoi_nhap4',
            method: 'POST',
            success: function (data) {
                $("#hn4_title").html(data);
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

    //$("#test1").on("change", function () {
    //    alert("blah blah");
    //});
});