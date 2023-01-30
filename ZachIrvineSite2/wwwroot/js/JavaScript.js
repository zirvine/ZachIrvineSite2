$("#submitScores").click(function () {
    var totalScore = 0;
    totalScore = ($("#assignments").val() * 0.5) + ($("#groupProjects").val() * 0.1) + ($("#quizzes").val() * 0.1) + ($("#midterm").val() * 0.1) + ($("#final").val() * 0.1) + ($("#intex").val() * 0.1)
    $("#results").text("Your total score is " + totalScore + "\%");
})