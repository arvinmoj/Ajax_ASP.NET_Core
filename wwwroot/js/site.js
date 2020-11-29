$(document).ready(function () {

    $('#buttonDemo1').click(function () {
        $.ajax({
            type: 'GET',
            url: '/demo/demo1',
            success: function (result) {
                $('#result1').html(result);
            }
        });
    });

    $('#buttonDemo2').click(function () {
        var fullName = $('#fullName').val();
        $.ajax({
            type: 'GET',
            url: '/demo/demo2/' + fullName,
            success: function (result) {
                $('#result2').html(result);
            }
        });
    });

    $('#buttonDemo3').click(function () {
        $.ajax({
            type: 'GET',
            url: '/demo/demo3',
            success: function (result) {
                var s = 'Id: ' + result.id;
                s += '<br>Name: ' + result.name;
                s += '<br>Price: ' + result.price;
                $('#result3').html(s);
            }
        });
    });

    $('#buttonDemo4').click(function () {
        $.ajax({
            type: 'GET',
            url: '/demo/demo4',
            success: function (result) {
                var s = '';
                for (var i = 0; i < result.length; i++) {
                    s += '<br>Id: ' + result[i].id;
                    s += '<br>Name: ' + result[i].name;
                    s += '<br>Price: ' + result[i].price;
                    s += '<br>------------------';
                }
                $('#result4').html(s);
            }
        });
    });
});