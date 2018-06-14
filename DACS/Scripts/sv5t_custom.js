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
            url: 'lay_tinh_nguyen1',
            method: 'POST',
            sucess: function (data) {
                //$("#tn2_title").html(data);
                console.log(data);
            }
        });
    }

    layTinhNguyen2();
    function layTinhNguyen2() {
        $.ajax({
            url: 'lay_tinh_nguyen2',
            method: 'POST',
            sucess: function (data) {
                $("#tn2_title").html(data);
            }
        });
    }

    layHoiNhap();
    function layHoiNhap() {
        $.ajax({
            url: 'lay_hoi_nhap',
            method: 'POST',
            sucess: function (data) { 
                $("#hn_title").html(data);
            }
        });
    }
    //layCheckBox();
    //function layCheckBox() {
    //    $.ajax({
    //        url: 'lay_check_box',
    //        method: 'POST',
    //        success: function (data) {
                
    //        }
    //    });
    //}

    $("#test1").on("change", function () {
        alert("blah blah");
    });
});