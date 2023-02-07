//$("#buttonSend").addEventListener("click", function () {
//   alert("from: " + $("#textFrom").val() +
//       "subject:" + $("#textSubject").val() +
//        "Message:" + $("#textMessage").val());

//});

$("#buttonSend").click(function () {
    alert(((parseFloat($("#Assignments").val()) + parseFloat($("#Quizzes").val()) + parseFloat($("#GP").val())
        + parseFloat($("#Intex").val()) + parseFloat($("#Exams").val())) / 100) * 100 + "%"
    );
})

document.getElementById("submitBtn").addEventListener("click", function () {
    alert("Hello");
});