//<script src="~/lib/freelancer/vendor/jquery-easing/jquery.easing.min.js"></script>
//    <script src="~/lib/freelancer/vendor/magnific-popup/jquery.magnific-popup.min.js"></script>
//    <script src="~/lib/freelancer/js/freelancer.min.js"></script>
//    <script src="~/lib/t.js-master/t.js"></script>

    $(function () {
    //$('.container').addClass('container-fluid');
    //$('.container').removeClass('container');

    $('#t').t({

        delay: 0,                // start delay in seconds [default:0]

        speed: 75,               // typing speed (ms) [default:75]
        speed_vary: true,       // 'human like' speed variation [default:false]

        beep: true,              // beep while typing (Web Audio API) [default:false]

        mistype: false,          // mistype rate: 1:N per char [default:false]
        locale: 'en',            // keyboard layout (to fit mistype); supported: 'en' (english) or 'de' (german) [default:'en']

        caret: '\u2589',         // caret content; can be html too [default:true (\u258e)]
        blink: true,             // blink-interval in ms; if TRUE, speed*3  [default:true]
        blink_perm: false,       // permanent blinking? if FALSE, caret blinks only on delay/pause/finish [default:false]

        repeat: 0,               // repeat typing: if TRUE, infinite or N times [default:0]
        tag: 'span',             // wrapper tag (.t-container, .t-caret) [default:'span']
        pause_on_click: true,    // pauses/continues typing on click/tap (elm) [default:false]


        // init callback (ready-to-type)
        init: function (elm) { },
        // typing callback
        typing: function (elm, chr_or_elm, left, total) { },
        // finished callback
        fin: function (elm) { }
    });

    $('#t1').t({

        delay: 0,                // start delay in seconds [default:0]

        speed: 90,               // typing speed (ms) [default:75]
        speed_vary: false,       // 'human like' speed variation [default:false]

        beep: true,              // beep while typing (Web Audio API) [default:false]

        mistype: false,          // mistype rate: 1:N per char [default:false]
        locale: 'en',            // keyboard layout (to fit mistype); supported: 'en' (english) or 'de' (german) [default:'en']

        caret: '\u2589',         // caret content; can be html too [default:true (\u258e)]
        blink: true,             // blink-interval in ms; if TRUE, speed*3  [default:true]
        blink_perm: false,       // permanent blinking? if FALSE, caret blinks only on delay/pause/finish [default:false]

        repeat: 0,               // repeat typing: if TRUE, infinite or N times [default:0]
        tag: 'span',             // wrapper tag (.t-container, .t-caret) [default:'span']
        pause_on_click: true,    // pauses/continues typing on click/tap (elm) [default:false]


        // init callback (ready-to-type)
        init: function (elm) { },
        // typing callback
        typing: function (elm, chr_or_elm, left, total) { },
        // finished callback
        fin: function (elm) { }
    });
});
