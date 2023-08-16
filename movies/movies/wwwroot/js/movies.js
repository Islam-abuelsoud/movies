function loadFile(event) {
    $("#Poster-Contaner").removeClass('d-none');    
    var reader = new FileReader();
    reader.onload = function () {
        var output = document.getElementById('output');
        output.src = reader.result;
    };
    reader.readAsDataURL(event.target.files[0]);
};
$("#year").datepicker({
    format: 'yyyy',
    viewMode: 'years',
    minViewMode: 'years',
    autoclose: true,
    startDate: new Date('1950-01-01'),
    endDate: new Date()
});