function fillPWs() {
    $.ajax({
        url: $('#entranceArea').data('request-url'),
        dataType: 'html',
        method: 'GET',
        success: function (pw) {
            $('#entranceArea').html(pw);
        }, complete: function () {
            //$.getScript("/lib/mdbootstrap/js/mdb.min.js", function () { });
            $.getScript("/lib/viewport-detection/viewport-detect.js", function () { });
            $.getScript("/lib/freelancer/vendor/jquery-easing/jquery.easing.min.js", function () { });
            $.getScript("/lib/freelancer/vendor/magnific-popup/jquery.magnific-popup.min.js", function () { });
            $.getScript("/lib/freelancer/js/freelancer.min.js", function () { });
            $.getScript("/lib/t.js-master/t.js", function () { });
            $.getScript("/lib/entrance/entrance.js", function () { });
        }
    });
    $.ajax({
        url: $('#developerArea').data('request-url'),
        dataType: 'html',
        method: 'GET',
        success: function (pw) {
            $('#developerArea').html(pw);
        }
    });
    $.ajax({
        url: $('#timelineArea').data('request-url'),
        dataType: 'html',
        method: 'GET',
        success: function (pw) {
            $('#timelineArea').html(pw);
        }, complete: function () {
            $.getScript("/lib/timeline/assets/js/util.js", function () { });
            $.getScript("/lib/timeline/assets/js/main.js", function () { });
            $.getScript("/lib/timeline/assets/js/swipe-content.js", function () { });
        }
    });
    $.ajax({
        url: $('#projectsArea').data('request-url'),
        dataType: 'html',
        method: 'GET',
        success: function (pw) {
            $('#projectsArea').html(pw);
        }, complete: function () {
            $.getScript("/lib/slider/js/jquery.mobile.custom.min.js", function () { });
            $.getScript("/lib/slider/js/main.js", function () { });
        }

    });
    $.ajax({
        url: $('#personalTalentsArea').data('request-url'),
        dataType: 'html',
        method: 'GET',
        success: function (pw) {
            $('#personalTalentsArea').html(pw);
        }, complete: function () {
            $.getScript("/lib/work-talents/wtScript.js", function () { });
        }

    });
}

$(function () {
    fillPWs();
});