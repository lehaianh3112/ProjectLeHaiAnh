let likebtn = document.querySelector('#likebtn');
let dislikebtn = document.querySelector('#dislikebtn');
let input1 = document.querySelector('#input1');
let input2 = document.querySelector('#input2');
likebtn.addEventListener('click', () => {
    input1.value = parseInt(input1.value) + 1;
    input1.style.color = "#ff0000";
})
dislikebtn.addEventListener('click', () => {
    input2.value = parseInt(input2.value) + 1;
    input2.style.color = "#blue";
})


$(document).ready(function() {
    $('.like').click(function() {
        var cauhoi_id = $(this).attr('id');
        // alert("Ban chon id" + cauhoi_id);
        $.ajax({
            url: 'server.php',
            type: 'post',
            async: false,
            data: {
                'liked': 1,
                'cauhoi_id': cauhoi_id
            },
            success: function() {

            }
        });
    });
    $('.unlike').click(function() {
        var cauhoi_id = $(this).attr('id');
        // alert("Ban chon id" + cauhoi_id);
        $.ajax({
            url: 'server.php',
            type: 'post',
            async: false,
            data: {
                'unliked': 1,
                'cauhoi_id': cauhoi_id
            },
            success: function() {}
        });
    });
});