$(document).ready(function () {
    $.ajax({
        url: '/SuperAdmin/GetColor/',
        dataType: 'json',
        type: 'GET',
        contentType: 'application/json',
        success: function (data) {

            $.each(data, function (index, item) {

                if (item.isgradient == true) {

                    $(".gaurang-gradient").css("background", "-webkit-linear-gradient(50deg," + item.fcolor + "," + item.scolor + ")");
                    $(".gaurang-gradient").css("background", "-o-linear-gradient(50deg," + item.fcolor + "," + item.scolor + ")");
                    $(".gaurang-gradient").css("background", "linear-gradient(40deg," + item.fcolor + "," + item.scolor + ")");

                    $(".gaurang-gradient").css("color", "" + item.textcolor + "");

                    $(".myactive").css("background", "-webkit-linear-gradient(50deg," + item.fcolor + "," + item.scolor + ")");
                    $(".myactive").css("background", "-o-linear-gradient(50deg," + item.fcolor + "," + item.scolor + ")");
                    $(".myactive").css("background", "linear-gradient(40deg," + item.fcolor + "," + item.scolor + ")");
                    
                    $(".rubi").hover(function () {

                        $(this).css("background", "-webkit-linear-gradient(50deg," + item.scolor + "," + item.fcolor + ")");
                        $(this).css("background", "-o-linear-gradient(50deg," + item.scolor + "," + item.fcolor + ")");
                        $(this).css("background", "linear-gradient(50deg," + item.scolor + "," + item.fcolor + ")");

                    });

                    $(".rubi").mouseout(function () {

                        $(this).css("background", "white");
                    });

                    $(".myactive").css("color", "" + item.textcolor + "");
                }
                else {

                    //alert("False");

                    $(".gaurang-gradient").css("background", "" + item.singlecolor + "");

                    $(".myactive").css("background", "" + item.singlecolor + "");

                    $(".gaurang-gradient").css("color", "" + item.textcolor + "");

                    $(".myactive").css("color", "" + item.textcolor + "");

                    $(".rubi").hover(function () {

                        $(this).css("background", "" + item.singlecolor + "");

                    });

                    $(".rubi").mouseout(function () {

                        $(this).css("background", "white");

                    });
                }
            });
        },
        error: function (data) {
            alert("error" + data);
        }
    });
});