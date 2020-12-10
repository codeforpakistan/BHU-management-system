$(document).ready(function () {
    $('#LastMestrualDate').change(function () {
        var lastMestrualDate = document.getElementById('LastMestrualDate').value;

        var date = new Date(lastMestrualDate);
        var newdate = new Date(date);
        newdate.setDate(date.getDate() + 7);
        newdate.setMonth(newdate.getMonth() + 9);
        document.getElementById('EDD').value = newdate.getDay() + '/' + newdate.getMonth() + '/' + newdate.getFullYear();




        const oneDay = 24 * 60 * 60 * 1000; // hours*minutes*seconds*milliseconds
        const firstDate = new Date(lastMestrualDate);
        const secondDate = new Date();

        const diffDays = Math.round(Math.abs((firstDate - secondDate) / oneDay));
        var weeks = diffDays / 7;
        var days = diffDays % 7;
        document.getElementById('EGA').value = parseInt(weeks)+' Weeks' +' '+ days +' Days';
    });

    $("#LastBabyBorn").datepicker({
        format: "yyyy",
        viewMode: "years",
        minViewMode: "years",
        autoclose: true,
        orientation: 'bottom'
    });
});