var number = 1;
var index = 0;
var i = 1;
var correct = 0;
var counter = 0;
var list = [];
function ShowResult() {
    $('.numberCorrect').text(correct);
    if (counter < 60) {
        $('.time').text(counter);
    }
    else {
        var minutes = Math.floor(counter/60);
        var seconds = counter % 60;
        $('.time').text(minutes + ' phút ' + seconds);
    }
    $('.modal-box-passed').css("display", "block");
    if (correct > 6 && counter < 120) {                         // Passed => Nếu trả lời đúng 7 câu trong 2 phút
        $('.modal-passed').css("display", "block");
        $('.modal-playAgain').css("display", "none");
    }
    else {
        $('.modal-passed').css("display", "none");
        $('.modal-playAgain').css("display", "block");
    }
}
$(document).ready(function () {
    setInterval(function () {
        ++counter;
    }, 1000);
});
$('.item-answer').off('click').on('click', function () {
    var answerSelectedId = $(this).find('input').attr('id');
    list.push({
        id: answerSelectedId
    });
    if (number != $('.questionMax').val()) {
        $(".continue").prop('disabled', false);         // Hiển thị button Tiếp tục
        $(".continue").addClass('color-continue');      // Thêm màu cho button Tiếp tục
    }
    var selected = $(this).find("input").val();
    if (selected == 'value') {                      // Nếu đáp án đúng thì thêm viền xanh, icon true
        $(this).css("border", "1px solid green");
        $(this).css("color", "green");
        $(this).find("i").remove();
        $(this).find("span").append("<i style=\"color: green\" class=\"fa-solid fa-circle-check\"></i>");
        correct++;

    }
    else {                                          // Nếu đáp án sai, thêm viền đỏ, icon banned
        $(this).css("border", "1px solid #b11313");
        $(this).css("color", "#b11313");
        $(this).find("i").remove();
        $(this).find("span").append("<i style=\"color: #b11313\" class=\"fa-solid fa-ban\"></i>");
    }
    $('.item-answer').addClass("dis");              // disable tất cả đáp án

    var questionMax = $('.questionMax').val();
    if (number == $('.questionMax').val()) {
        setTimeout(ShowResult, 1000);
    }
});
$('.continue').off('click').on('click', function () {
    if (number < 10) {
        $('.item-answer').removeClass("dis");                   // enable tất cả đáp án
        $(".continue").removeClass('color-continue');           // disable btn tiếp tục
        $(".continue").prop('disabled', true);
        $('.question_' + number).css("display", "none");        // hiển thị câu hỏi
        number++;
        $('.question_' + number).css("display", "block");
    }
});
$('.history').click(function () {
    $.ajax({
        url: '/Home/History',
        type: 'POST',
        dataType: "json",
        data: {
            list: list
        },
        success: function (response) {
            $('.question_10').css('display', 'none');
            $('.modal-box-passed').css('display', 'none');
            var html = '';
            $.each(response.model, function (i, item) {
                index++;
                html += "<div class=\"question history" + index + "\">"
                    + "<a class=\"closeHistory\">X</a>"
                    + "<div>"
                    + "<img class=\"logo-question\" src=\"/img/quiz.png\" />"
                    + "</div>"
                    + "<div class=\"title\">"
                    + "<h3>Đáp án: Câu hỏi " + index + "/"+ response.model.length +"</h3>"
                    + "</div>"
                    + "<div class=\"content-question\">"
                    + "<p>" + item.content + "</p>"
                    + "</div>"
                    + "<div class=\"answerHistory answer_"+ index +"\">"
                            // Vòng lặp item cc
                    + "</div>"
                    + "<div class=\"box-continue" + index + "\">"
                    + "</div>"
                    + "</div > "
            });
            $('.historyQuestion').append(html);
            $.each(response.model, function (j, jtem) {
                j++;
                $.each(jtem.answers, function (index, value) {
                    if (value.correct && value.selected)
                        $('.answer_' + j).append("<div style=\"border: 1px solid green; color: green;\" class=\"item-answer\"><p>" + value.content + "</p><span><i style=\"color: green\" class=\"fa-solid fa-circle-check\"></i></div>");
                    else if (!value.correct && value.selected)
                        $('.answer_' + j).append("<div style=\"border: 1px solid #b11313; color: #b11313;\" class=\"item-answer\"><p>" + value.content + "</p><span><i style=\"color: #b11313\" class=\"fa-solid fa-ban\"></i></span></div>");
                    else if (value.correct && !value.selected)
                        $('.answer_' + j).append("<div style=\"border: 1px solid green; color: green;\" class=\"item-answer\"><p>" + value.content + "</p><span><i style=\"color: green\" class=\"fa-solid fa-circle-check\"></i></span></div>");
                    else
                        $('.answer_' + j).append("<div class=\"item-answer\"><p>" + value.content + "</p><span><i class=\"fa-regular fa-circle\"></i></span></div>");
                });
                if (j < 10) {
                    $('.box-continue' + j).append("<button class=\"continueHistory\" >Câu tiếp theo</button>");
                } else {
                    $('.box-continue' + j).append("<button class=\"continueHistory playAgain\" >Quay lại</button>");
                }
            });

            $('.continueHistory').click(function () {
                if (i < 10) {
                    $('.history' + i).css("display", "none");        // hiển thị câu hỏi
                    i++;
                    $('.history' + i).css("display", "block");
                }
            });

            $('.closeHistory').off('click').on('click', function () {
                window.location.href = '/Home';
            });
            $('.playAgain').off('click').on('click', function () {
                window.location.href = '/Home';
            });
        }
    });
});

